load(
    "@d2l_rules_csharp//csharp:defs.bzl",
    "csharp_binary",
    "csharp_library",
	"nuget_package"
)

nuget_package(
	name = "newtonsoft.json",
	package = "Newtonsoft.Json",
	version = "13.0.1",
	sha256 = "2b6b52556e27e1b7913f33eedeb95568110c746bd64afff74357f1683878323a"
)

csharp_library(
	name = "source",
	srcs = ["Helper.cs"],
	target_frameworks = ["net48"],
	deps =["newtonsoft.json"]
)
csharp_binary(
	name = "ConsoleApplication1",
	deps = ["source"],
	srcs = ["Program.cs"],
	target_frameworks = ["net48"],
	out = "ConsoleApplication1"
)