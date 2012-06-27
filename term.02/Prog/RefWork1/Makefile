
MONO = mono --debug
CSC = gmcs -debug
MKDIR_P = mkdir -p
RM_F = rm -f
RMDIR = rmdir

all: bin/RefWork1.dll bin/Test01.exe

clean:
	$(RM_F) bin/RefWork1.dll*
	$(RM_F) bin/Test01.exe*
	$(RM_F) bin/Test02.exe*
	$(RMDIR) bin

clean-dist:


bin:
	$(MKDIR_P) bin

bin/RefWork1.dll: bin src/*.cs
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

run-01: bin/Test01.exe
	$(MONO) bin/Test01.exe

run-02: bin/Test02.exe
	$(MONO) bin/Test02.exe
