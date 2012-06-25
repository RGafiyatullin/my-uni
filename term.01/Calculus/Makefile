
TEXI2PDF = texi2pdf
RM_F = rm -f

all: RG-Uni-Calculus-Reference_Work_1.pdf RG-Uni-Calculus-Reference_Work_2.pdf RG-Uni-Calculus-Reference_Work_3.pdf

RG-Uni-Calculus-Reference_Work_1.pdf: RG-Uni-Calculus-Reference_Work_1.tex
	$(TEXI2PDF) RG-Uni-Calculus-Reference_Work_1.tex

RG-Uni-Calculus-Reference_Work_2.pdf: RG-Uni-Calculus-Reference_Work_2.tex
	$(TEXI2PDF) RG-Uni-Calculus-Reference_Work_2.tex

RG-Uni-Calculus-Reference_Work_3.pdf: RG-Uni-Calculus-Reference_Work_3.tex RG-Uni-Calculus-Reference_Work_3-04-1-3.eps
	$(TEXI2PDF) RG-Uni-Calculus-Reference_Work_3.tex

clean:
	$(RM_F) RG-Uni-Calculus-Reference_Work_1.aux
	$(RM_F) RG-Uni-Calculus-Reference_Work_1.log
	$(RM_F) RG-Uni-Calculus-Reference_Work_1.pdf
	$(RM_F) RG-Uni-Calculus-Reference_Work_2.aux
	$(RM_F) RG-Uni-Calculus-Reference_Work_2.log
	$(RM_F) RG-Uni-Calculus-Reference_Work_2.pdf
	$(RM_F) RG-Uni-Calculus-Reference_Work_3.aux
	$(RM_F) RG-Uni-Calculus-Reference_Work_3.log
	$(RM_F) RG-Uni-Calculus-Reference_Work_3.pdf
	$(RM_F) RG-Uni-Calculus-Reference_Work_3-04-1-3-eps-converted-to.pdf
