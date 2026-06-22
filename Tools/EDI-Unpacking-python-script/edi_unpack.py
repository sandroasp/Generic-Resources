# -*- coding: utf-8 -*-
# Notepad++ PythonScript
# EDI / EDIFACT Unpack Script
# Splits segments into lines while preserving escaped separators

from Npp import editor, console

def edi_unpack():
    editor.beginUndoAction()

    text = editor.getText()

    if not text:
        console.write("No content to process.\n")
        editor.endUndoAction()
        return

    # Default EDIFACT separators
    segment_terminator = "'"
    release_char = "?"
    
    # Detect UNA segment (if exists)
    if text.startswith("UNA") and len(text) >= 9:
        # UNA:+.? '
        # positions:
        # 3 = component data element separator
        # 4 = data element separator
        # 5 = decimal notification
        # 6 = release character
        # 7 = repetition separator (optional)
        # 8 = segment terminator
        release_char = text[6]
        segment_terminator = text[8]

        console.write("Detected UNA -> SegmentTerminator: '%s', ReleaseChar: '%s'\n" % (segment_terminator, release_char))

    # Step 1: Protect escaped terminators (e.g. ?')
    placeholder = "§§TEMP_ESCAPED§§"
    escaped_pattern = release_char + segment_terminator
    text = text.replace(escaped_pattern, placeholder)

    # Step 2: Replace segment terminator with newline
    text = text.replace(segment_terminator, segment_terminator + "\r\n")

    # Step 3: Restore escaped terminators
    text = text.replace(placeholder, escaped_pattern)

    # Optional: remove duplicate blank lines (cleaner output)
    while "\r\n\r\n" in text:
        text = text.replace("\r\n\r\n", "\r\n")

    editor.setText(text)
    editor.endUndoAction()

    console.write("EDI unpack completed successfully.\n")

# Run
edi_unpack()