
MONO = mono --debug
CSC = dmcs -debug
MKDIR_P = mkdir -p
RM_F = rm -f
RMDIR = rmdir

all: bin/RefWork1.dll \
	bin/Test01.exe bin/Test02.exe \
	bin/Test03.exe bin/Test04.exe bin/Test05.exe

clean:
	$(RM_F) src/ArithHack.cs
	$(RM_F) bin/RefWork1.dll*
	$(RM_F) bin/Test01.exe*
	$(RM_F) bin/Test02.exe*
	$(RM_F) bin/Test03.exe*
	$(RM_F) bin/Test04.exe*
	$(RM_F) bin/Test05.exe*
	$(RMDIR) bin

clean-dist:


bin:
	$(MKDIR_P) bin

src/ArithHack.cs: \
	src/ArithHack.cs.template.1 \
	src/ArithHack.cs.template.2 \
	src/ArithHack.cs.template.3 \
	Makefile.arithhack-generate.sh
	./Makefile.arithhack-generate.sh

bin/RefWork1.dll: bin src/ArithHack.cs src/*.cs
	$(CSC) \
		-out:bin/RefWork1.dll \
		-target:library \
		-r:System.dll \
		src/*.cs

bin/Test01.exe: bin bin/RefWork1.dll src.exe/Test01.cs
	$(CSC) \
		-out:bin/Test01.exe \
		-target:exe \
		-r:System.dll \
		-r:bin/RefWork1.dll \
		src.exe/Test01.cs

bin/Test02.exe: bin bin/RefWork1.dll src.exe/Test02.cs
	$(CSC) \
		-out:bin/Test02.exe \
		-target:exe \
		-r:System.dll \
		-r:bin/RefWork1.dll \
		src.exe/Test02.cs

bin/Test03.exe: bin bin/RefWork1.dll src.exe/Test03.cs
	$(CSC) \
		-out:bin/Test03.exe \
		-target:exe \
		-r:System.dll \
		-r:bin/RefWork1.dll \
		src.exe/Test03.cs

bin/Test04.exe: bin bin/RefWork1.dll src.exe/Test04.cs
	$(CSC) \
		-out:bin/Test04.exe \
		-target:exe \
		-r:System.dll \
		-r:bin/RefWork1.dll \
		src.exe/Test04.cs

bin/Test05.exe: bin bin/RefWork1.dll src.exe/Test05.cs
	$(CSC) \
		-out:bin/Test05.exe \
		-target:exe \
		-r:System.dll \
		-r:bin/RefWork1.dll \
		src.exe/Test05.cs

run-01: bin/Test01.exe
	$(MONO) bin/Test01.exe

run-02: bin/Test02.exe
	$(MONO) bin/Test02.exe

run-03: bin/Test03.exe
	$(MONO) bin/Test03.exe

run-04: bin/Test04.exe
	$(MONO) bin/Test04.exe

run-05: bin/Test05.exe
	$(MONO) bin/Test05.exe
