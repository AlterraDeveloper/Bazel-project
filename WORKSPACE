
# A newer version should be fine
load("@bazel_tools//tools/build_defs/repo:git.bzl", "git_repository")
git_repository(
    name = "io_bazel_rules_dotnet",
    remote = "https://github.com/bazelbuild/rules_dotnet",
    branch = "master",
)

load("@io_bazel_rules_dotnet//dotnet:deps.bzl", "dotnet_repositories")
dotnet_repositories()

load(
    "@io_bazel_rules_dotnet//dotnet:defs.bzl",
    "dotnet_register_toolchains",
    "dotnet_repositories_nugets",
	"nuget_package"
)

dotnet_register_toolchains()
dotnet_repositories_nugets()


git_repository(
	name = "d2l_rules_csharp",
	remote = "https://github.com/Brightspace/rules_csharp.git",
	branch = "master",
)

load(
    "@d2l_rules_csharp//csharp:defs.bzl",
    "csharp_register_toolchains",
    "csharp_repositories",
	
)

csharp_register_toolchains()
csharp_repositories()
