
TEXI2PDF = texi2pdf
RM_F = rm -f

all: RG-Uni-GnA-Reference-Work-2.pdf

RG-Uni-GnA-Reference-Work-2.pdf: RG-Uni-GnA-Reference-Work-2.tex
	$(TEXI2PDF) RG-Uni-GnA-Reference-Work-2.tex

clean: dist-clean
	$(RM_F) RG-Uni-GnA-Reference-Work-2.pdf

dist-clean:
	$(RM_F) RG-Uni-GnA-Reference-Work-2.aux
	$(RM_F) RG-Uni-GnA-Reference-Work-2.log
