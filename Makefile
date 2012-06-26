
all: all-term.01 all-term.02

clean:
	make -C term.01 clean
	make -C term.02 clean

dist-clean:
	make -C term.01 dist-clean
	make -C term.02 dist-clean

all-term.01:
	make -C term.01

all-term.02:
	make -C term.02

