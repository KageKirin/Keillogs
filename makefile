
format:
	@fd cs$$ -X dotnet csharpier {}
	@fd cs$$ -X dos2unix -r -q {}
	@fd csproj$$ -X dos2unix -r -q {}
