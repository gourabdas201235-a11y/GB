# pdf_export_service.py
from reportlab.lib.pagesizes import letter
from reportlab.pdfgen import canvas

def create_pdf(file_path, content):
    """Creates a PDF file with the given content."""
    c = canvas.Canvas(file_path, pagesize=letter)
    width, height = letter
    c.drawString(100, height - 100, content)
    c.save()
    print(f"PDF created at {file_path}")

# Example usage:
if __name__ == "__main__":
    create_pdf('output.pdf', 'Hello, this is a PDF document!')
