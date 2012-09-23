
TEXI2PDF = texi2pdf
RM_F = rm -f

all: RG-Uni-Calculus-Reference_Work_4.pdf

RG-Uni-Calculus-Reference_Work_4.pdf: RG-Uni-Calculus-Reference_Work_4.tex
	$(TEXI2PDF) RG-Uni-Calculus-Reference_Work_4.tex

clean: dist-clean
	$(RM_F) RG-Uni-Calculus-Reference_Work_4.pdf

dist-clean:
	$(RM_F) RG-Uni-Calculus-Reference_Work_4.aux
	$(RM_F) RG-Uni-Calculus-Reference_Work_4.log
