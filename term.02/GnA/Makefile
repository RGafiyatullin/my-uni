TEXI2PDF = texi2pdf
RM_F = rm -f

all: Hints.pdf RG-Uni-GnA-Reference-Work-1.pdf RG-Uni-GnA-Reference-Work-2.pdf

RG-Uni-GnA-Reference-Work-1.pdf: RG-Uni-GnA-Reference-Work-1.tex
	$(TEXI2PDF) RG-Uni-GnA-Reference-Work-1.tex

RG-Uni-GnA-Reference-Work-2.pdf: RG-Uni-GnA-Reference-Work-2.tex
	$(TEXI2PDF) RG-Uni-GnA-Reference-Work-2.tex

Hints.pdf: Hints.tex
	$(TEXI2PDF) Hints.tex

clean: dist-clean
	$(RM_F) RG-Uni-GnA-Reference-Work-1.pdf
	$(RM_F) RG-Uni-GnA-Reference-Work-2.pdf

dist-clean:
	$(RM_F) RG-Uni-GnA-Reference-Work-1.aux
	$(RM_F) RG-Uni-GnA-Reference-Work-1.log
	$(RM_F) RG-Uni-GnA-Reference-Work-2.aux
	$(RM_F) RG-Uni-GnA-Reference-Work-2.log