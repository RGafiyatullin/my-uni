
MONO = mono --debug
CSC = gmcs -debug
MKDIR_P = mkdir -p
RM_F = rm -f
RMDIR = rmdir

all: bin/RefWork2.dll \
	bin/Test01.exe

clean:
	$(RM_F) bin/RefWork2.dll*
	$(RM_F) bin/Test01.exe*
	$(RMDIR) bin

clean-dist:


bin:
	$(MKDIR_P) bin

bin/RefWork2.dll: bin src/*.cs
	$(CSC) \
		-out:bin/RefWork2.dll \
		-target:library \
		-r:System.dll \
		src/*.cs

bin/Test01.exe: bin bin/RefWork2.dll src.exe/Test01.cs
	$(CSC) \
		-out:bin/Test01.exe \
		-target:exe \
		-r:System.dll \
		-r:bin/RefWork2.dll \
		src.exe/Test01.cs


run-01: bin/Test01.exe
	$(MONO) bin/Test01.exe

