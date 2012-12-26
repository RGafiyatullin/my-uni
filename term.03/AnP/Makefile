
TEXI2PDF = texi2pdf
RM_F = rm -f

all: RG-AnP-Reference_Work_3_1_5.pdf rg-anp-rw-3-1-5

RG-AnP-Reference_Work_3_1_5.pdf: RG-AnP-Reference_Work_3_1_5.tex rg-anp-rw-3-1-5.c rg-anp-rw-3-1-5.output
	echo -n | $(TEXI2PDF) RG-AnP-Reference_Work_3_1_5.tex

rg-anp-rw-3-1-5: rg-anp-rw-3-1-5.c
	clang -o rg-anp-rw-3-1-5 rg-anp-rw-3-1-5.c

clean: dist-clean
	$(RM_F) RG-AnP-Reference_Work_3_1_5.pdf

dist-clean:
	$(RM_F) RG-AnP-Reference_Work_3_1_5.aux
	$(RM_F) RG-AnP-Reference_Work_3_1_5.log
	$(RM_F rg-anp-rw-3-1-5
