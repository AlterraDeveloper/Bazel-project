
# A newer version should be fine
load("@bazel_tools//tools/build_defs/repo:git.bzl", "git_repository")

git_repository(
	name = "d2l_rules_csharp",
	remote = "https://github.com/Brightspace/rules_csharp.git",
	branch = "master",
)

load(
    "@d2l_rules_csharp//csharp:defs.bzl",
    "csharp_register_toolchains",
    "csharp_repositories",
    "import_nuget_package",
)

csharp_register_toolchains()
csharp_repositories()

import_nuget_package(
    name = "Newtonsoft.Json.13.0.1",
    dir = "packages/Newtonsoft.Json.13.0.1",
)
