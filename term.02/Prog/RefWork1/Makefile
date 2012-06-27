
CSC = gmcs
MKDIR_P = mkdir -p
RM_F = rm -f
RMDIR = rmdir

all: bin/RefWork1.dll

clean:
	$(RM_F) bin/RefWork1.dll
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

