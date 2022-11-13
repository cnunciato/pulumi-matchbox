// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as utilities from "./utilities";

export class Profile extends pulumi.CustomResource {
    /**
     * Get an existing Profile resource's state with the given name, ID, and optional extra
     * properties used to qualify the lookup.
     *
     * @param name The _unique_ name of the resulting resource.
     * @param id The _unique_ provider ID of the resource to lookup.
     * @param state Any extra arguments used during the lookup.
     * @param opts Optional settings to control the behavior of the CustomResource.
     */
    public static get(name: string, id: pulumi.Input<pulumi.ID>, state?: ProfileState, opts?: pulumi.CustomResourceOptions): Profile {
        return new Profile(name, <any>state, { ...opts, id: id });
    }

    /** @internal */
    public static readonly __pulumiType = 'matchbox:index/profile:Profile';

    /**
     * Returns true if the given object is an instance of Profile.  This is designed to work even
     * when multiple copies of the Pulumi SDK have been loaded into the same process.
     */
    public static isInstance(obj: any): obj is Profile {
        if (obj === undefined || obj === null) {
            return false;
        }
        return obj['__pulumiType'] === Profile.__pulumiType;
    }

    /**
     * List of kernel arguments
     */
    public readonly args!: pulumi.Output<string[] | undefined>;
    /**
     * CoreOS Container Linux Config (CLC) (for backwards compatibility)
     */
    public readonly containerLinuxConfig!: pulumi.Output<string | undefined>;
    public readonly genericConfig!: pulumi.Output<string | undefined>;
    /**
     * List of URLs to init RAM filesystems
     */
    public readonly initrds!: pulumi.Output<string[] | undefined>;
    /**
     * URL of the kernel image to boot
     */
    public readonly kernel!: pulumi.Output<string | undefined>;
    /**
     * Unqiue name for the machine matcher
     */
    public readonly name!: pulumi.Output<string>;
    public readonly rawIgnition!: pulumi.Output<string | undefined>;

    /**
     * Create a Profile resource with the given unique name, arguments, and options.
     *
     * @param name The _unique_ name of the resource.
     * @param args The arguments to use to populate this resource's properties.
     * @param opts A bag of options that control this resource's behavior.
     */
    constructor(name: string, args?: ProfileArgs, opts?: pulumi.CustomResourceOptions)
    constructor(name: string, argsOrState?: ProfileArgs | ProfileState, opts?: pulumi.CustomResourceOptions) {
        let resourceInputs: pulumi.Inputs = {};
        opts = opts || {};
        if (opts.id) {
            const state = argsOrState as ProfileState | undefined;
            resourceInputs["args"] = state ? state.args : undefined;
            resourceInputs["containerLinuxConfig"] = state ? state.containerLinuxConfig : undefined;
            resourceInputs["genericConfig"] = state ? state.genericConfig : undefined;
            resourceInputs["initrds"] = state ? state.initrds : undefined;
            resourceInputs["kernel"] = state ? state.kernel : undefined;
            resourceInputs["name"] = state ? state.name : undefined;
            resourceInputs["rawIgnition"] = state ? state.rawIgnition : undefined;
        } else {
            const args = argsOrState as ProfileArgs | undefined;
            resourceInputs["args"] = args ? args.args : undefined;
            resourceInputs["containerLinuxConfig"] = args ? args.containerLinuxConfig : undefined;
            resourceInputs["genericConfig"] = args ? args.genericConfig : undefined;
            resourceInputs["initrds"] = args ? args.initrds : undefined;
            resourceInputs["kernel"] = args ? args.kernel : undefined;
            resourceInputs["name"] = args ? args.name : undefined;
            resourceInputs["rawIgnition"] = args ? args.rawIgnition : undefined;
        }
        opts = pulumi.mergeOptions(utilities.resourceOptsDefaults(), opts);
        super(Profile.__pulumiType, name, resourceInputs, opts);
    }
}

/**
 * Input properties used for looking up and filtering Profile resources.
 */
export interface ProfileState {
    /**
     * List of kernel arguments
     */
    args?: pulumi.Input<pulumi.Input<string>[]>;
    /**
     * CoreOS Container Linux Config (CLC) (for backwards compatibility)
     */
    containerLinuxConfig?: pulumi.Input<string>;
    genericConfig?: pulumi.Input<string>;
    /**
     * List of URLs to init RAM filesystems
     */
    initrds?: pulumi.Input<pulumi.Input<string>[]>;
    /**
     * URL of the kernel image to boot
     */
    kernel?: pulumi.Input<string>;
    /**
     * Unqiue name for the machine matcher
     */
    name?: pulumi.Input<string>;
    rawIgnition?: pulumi.Input<string>;
}

/**
 * The set of arguments for constructing a Profile resource.
 */
export interface ProfileArgs {
    /**
     * List of kernel arguments
     */
    args?: pulumi.Input<pulumi.Input<string>[]>;
    /**
     * CoreOS Container Linux Config (CLC) (for backwards compatibility)
     */
    containerLinuxConfig?: pulumi.Input<string>;
    genericConfig?: pulumi.Input<string>;
    /**
     * List of URLs to init RAM filesystems
     */
    initrds?: pulumi.Input<pulumi.Input<string>[]>;
    /**
     * URL of the kernel image to boot
     */
    kernel?: pulumi.Input<string>;
    /**
     * Unqiue name for the machine matcher
     */
    name?: pulumi.Input<string>;
    rawIgnition?: pulumi.Input<string>;
}
