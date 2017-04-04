all: ctags
	mcs lab2.cs

.PHONY: clean
clean:
	rm -f lab2.exe TAGS

.PHONY: ctags
ctags: clean
	ctags -e -R .
