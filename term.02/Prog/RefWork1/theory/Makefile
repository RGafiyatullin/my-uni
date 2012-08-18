
TEXI2PDF = texi2pdf
RM_F = rm -f

all: RG-Uni-Prog-RefW-1.pdf

RG-Uni-Prog-RefW-1.pdf: RG-Uni-Prog-RefW-1.tex
	$(TEXI2PDF) RG-Uni-Prog-RefW-1.tex

clean: dist-clean
	$(RM_F) RG-Uni-Prog-RefW-1.pdf

dist-clean:
	$(RM_F) RG-Uni-Prog-RefW-1.aux
	$(RM_F) RG-Uni-Prog-RefW-1.log
