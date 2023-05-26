// Code generated by the Pulumi Terraform Bridge (tfgen) Tool DO NOT EDIT.
// *** WARNING: Do not edit by hand unless you're certain you know what you are doing! ***

package matchbox

import (
	"context"
	"reflect"

	"errors"
	"github.com/pulumi/pulumi/sdk/v3/go/pulumi"
)

// The provider type for the matchbox package. By default, resources use package-wide configuration
// settings, however an explicit `Provider` instance may be created and passed during resource
// construction to achieve fine-grained programmatic control over provider settings. See the
// [documentation](https://www.pulumi.com/docs/reference/programming-model/#providers) for more information.
type Provider struct {
	pulumi.ProviderResourceState

	Ca         pulumi.StringOutput `pulumi:"ca"`
	ClientCert pulumi.StringOutput `pulumi:"clientCert"`
	ClientKey  pulumi.StringOutput `pulumi:"clientKey"`
	Endpoint   pulumi.StringOutput `pulumi:"endpoint"`
}

// NewProvider registers a new resource with the given unique name, arguments, and options.
func NewProvider(ctx *pulumi.Context,
	name string, args *ProviderArgs, opts ...pulumi.ResourceOption) (*Provider, error) {
	if args == nil {
		return nil, errors.New("missing one or more required arguments")
	}

	if args.Ca == nil {
		return nil, errors.New("invalid value for required argument 'Ca'")
	}
	if args.ClientCert == nil {
		return nil, errors.New("invalid value for required argument 'ClientCert'")
	}
	if args.ClientKey == nil {
		return nil, errors.New("invalid value for required argument 'ClientKey'")
	}
	if args.Endpoint == nil {
		return nil, errors.New("invalid value for required argument 'Endpoint'")
	}
	if args.ClientKey != nil {
		args.ClientKey = pulumi.ToSecret(args.ClientKey).(pulumi.StringInput)
	}
	secrets := pulumi.AdditionalSecretOutputs([]string{
		"clientKey",
	})
	opts = append(opts, secrets)
	opts = pkgResourceDefaultOpts(opts)
	var resource Provider
	err := ctx.RegisterResource("pulumi:providers:matchbox", name, args, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

type providerArgs struct {
	Ca         string `pulumi:"ca"`
	ClientCert string `pulumi:"clientCert"`
	ClientKey  string `pulumi:"clientKey"`
	Endpoint   string `pulumi:"endpoint"`
}

// The set of arguments for constructing a Provider resource.
type ProviderArgs struct {
	Ca         pulumi.StringInput
	ClientCert pulumi.StringInput
	ClientKey  pulumi.StringInput
	Endpoint   pulumi.StringInput
}

func (ProviderArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*providerArgs)(nil)).Elem()
}

type ProviderInput interface {
	pulumi.Input

	ToProviderOutput() ProviderOutput
	ToProviderOutputWithContext(ctx context.Context) ProviderOutput
}

func (*Provider) ElementType() reflect.Type {
	return reflect.TypeOf((**Provider)(nil)).Elem()
}

func (i *Provider) ToProviderOutput() ProviderOutput {
	return i.ToProviderOutputWithContext(context.Background())
}

func (i *Provider) ToProviderOutputWithContext(ctx context.Context) ProviderOutput {
	return pulumi.ToOutputWithContext(ctx, i).(ProviderOutput)
}

type ProviderOutput struct{ *pulumi.OutputState }

func (ProviderOutput) ElementType() reflect.Type {
	return reflect.TypeOf((**Provider)(nil)).Elem()
}

func (o ProviderOutput) ToProviderOutput() ProviderOutput {
	return o
}

func (o ProviderOutput) ToProviderOutputWithContext(ctx context.Context) ProviderOutput {
	return o
}

func (o ProviderOutput) Ca() pulumi.StringOutput {
	return o.ApplyT(func(v *Provider) pulumi.StringOutput { return v.Ca }).(pulumi.StringOutput)
}

func (o ProviderOutput) ClientCert() pulumi.StringOutput {
	return o.ApplyT(func(v *Provider) pulumi.StringOutput { return v.ClientCert }).(pulumi.StringOutput)
}

func (o ProviderOutput) ClientKey() pulumi.StringOutput {
	return o.ApplyT(func(v *Provider) pulumi.StringOutput { return v.ClientKey }).(pulumi.StringOutput)
}

func (o ProviderOutput) Endpoint() pulumi.StringOutput {
	return o.ApplyT(func(v *Provider) pulumi.StringOutput { return v.Endpoint }).(pulumi.StringOutput)
}

func init() {
	pulumi.RegisterInputType(reflect.TypeOf((*ProviderInput)(nil)).Elem(), &Provider{})
	pulumi.RegisterOutputType(ProviderOutput{})
}
