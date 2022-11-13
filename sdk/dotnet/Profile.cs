// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;
using Pulumi;

namespace Pulumiverse.Matchbox
{
    [MatchboxResourceType("matchbox:index/profile:Profile")]
    public partial class Profile : global::Pulumi.CustomResource
    {
        /// <summary>
        /// List of kernel arguments
        /// </summary>
        [Output("args")]
        public Output<ImmutableArray<string>> Args { get; private set; } = null!;

        /// <summary>
        /// CoreOS Container Linux Config (CLC) (for backwards compatibility)
        /// </summary>
        [Output("containerLinuxConfig")]
        public Output<string?> ContainerLinuxConfig { get; private set; } = null!;

        [Output("genericConfig")]
        public Output<string?> GenericConfig { get; private set; } = null!;

        /// <summary>
        /// List of URLs to init RAM filesystems
        /// </summary>
        [Output("initrds")]
        public Output<ImmutableArray<string>> Initrds { get; private set; } = null!;

        /// <summary>
        /// URL of the kernel image to boot
        /// </summary>
        [Output("kernel")]
        public Output<string?> Kernel { get; private set; } = null!;

        /// <summary>
        /// Unqiue name for the machine matcher
        /// </summary>
        [Output("name")]
        public Output<string> Name { get; private set; } = null!;

        [Output("rawIgnition")]
        public Output<string?> RawIgnition { get; private set; } = null!;


        /// <summary>
        /// Create a Profile resource with the given unique name, arguments, and options.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resource</param>
        /// <param name="args">The arguments used to populate this resource's properties</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public Profile(string name, ProfileArgs? args = null, CustomResourceOptions? options = null)
            : base("matchbox:index/profile:Profile", name, args ?? new ProfileArgs(), MakeResourceOptions(options, ""))
        {
        }

        private Profile(string name, Input<string> id, ProfileState? state = null, CustomResourceOptions? options = null)
            : base("matchbox:index/profile:Profile", name, state, MakeResourceOptions(options, id))
        {
        }

        private static CustomResourceOptions MakeResourceOptions(CustomResourceOptions? options, Input<string>? id)
        {
            var defaultOptions = new CustomResourceOptions
            {
                Version = Utilities.Version,
                PluginDownloadURL = "github://api.github.com/pulumiverse",
            };
            var merged = CustomResourceOptions.Merge(defaultOptions, options);
            // Override the ID if one was specified for consistency with other language SDKs.
            merged.Id = id ?? merged.Id;
            return merged;
        }
        /// <summary>
        /// Get an existing Profile resource's state with the given name, ID, and optional extra
        /// properties used to qualify the lookup.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resulting resource.</param>
        /// <param name="id">The unique provider ID of the resource to lookup.</param>
        /// <param name="state">Any extra arguments used during the lookup.</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public static Profile Get(string name, Input<string> id, ProfileState? state = null, CustomResourceOptions? options = null)
        {
            return new Profile(name, id, state, options);
        }
    }

    public sealed class ProfileArgs : global::Pulumi.ResourceArgs
    {
        [Input("args")]
        private InputList<string>? _args;

        /// <summary>
        /// List of kernel arguments
        /// </summary>
        public InputList<string> Args
        {
            get => _args ?? (_args = new InputList<string>());
            set => _args = value;
        }

        /// <summary>
        /// CoreOS Container Linux Config (CLC) (for backwards compatibility)
        /// </summary>
        [Input("containerLinuxConfig")]
        public Input<string>? ContainerLinuxConfig { get; set; }

        [Input("genericConfig")]
        public Input<string>? GenericConfig { get; set; }

        [Input("initrds")]
        private InputList<string>? _initrds;

        /// <summary>
        /// List of URLs to init RAM filesystems
        /// </summary>
        public InputList<string> Initrds
        {
            get => _initrds ?? (_initrds = new InputList<string>());
            set => _initrds = value;
        }

        /// <summary>
        /// URL of the kernel image to boot
        /// </summary>
        [Input("kernel")]
        public Input<string>? Kernel { get; set; }

        /// <summary>
        /// Unqiue name for the machine matcher
        /// </summary>
        [Input("name")]
        public Input<string>? Name { get; set; }

        [Input("rawIgnition")]
        public Input<string>? RawIgnition { get; set; }

        public ProfileArgs()
        {
        }
        public static new ProfileArgs Empty => new ProfileArgs();
    }

    public sealed class ProfileState : global::Pulumi.ResourceArgs
    {
        [Input("args")]
        private InputList<string>? _args;

        /// <summary>
        /// List of kernel arguments
        /// </summary>
        public InputList<string> Args
        {
            get => _args ?? (_args = new InputList<string>());
            set => _args = value;
        }

        /// <summary>
        /// CoreOS Container Linux Config (CLC) (for backwards compatibility)
        /// </summary>
        [Input("containerLinuxConfig")]
        public Input<string>? ContainerLinuxConfig { get; set; }

        [Input("genericConfig")]
        public Input<string>? GenericConfig { get; set; }

        [Input("initrds")]
        private InputList<string>? _initrds;

        /// <summary>
        /// List of URLs to init RAM filesystems
        /// </summary>
        public InputList<string> Initrds
        {
            get => _initrds ?? (_initrds = new InputList<string>());
            set => _initrds = value;
        }

        /// <summary>
        /// URL of the kernel image to boot
        /// </summary>
        [Input("kernel")]
        public Input<string>? Kernel { get; set; }

        /// <summary>
        /// Unqiue name for the machine matcher
        /// </summary>
        [Input("name")]
        public Input<string>? Name { get; set; }

        [Input("rawIgnition")]
        public Input<string>? RawIgnition { get; set; }

        public ProfileState()
        {
        }
        public static new ProfileState Empty => new ProfileState();
    }
}
