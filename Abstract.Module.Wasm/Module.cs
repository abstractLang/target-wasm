using Abstract.Module.Core;
using Abstract.Module.Core.Configuration;
using Abstract.Realizer.Core.Configuration.LangOutput;
using BetaIsa =  Abstract.Realizer.Core.Configuration.LangOutput.BetaExtendableInstructionSet;

namespace Abstract.Module.Wasm;

public class Module : IModule
{
    public ModuleConfiguration Config { get; } = new()
    {
        Name = "Webassembly",
        Description = "Provides targets for webassembly bytecode",
        
        Author = "lumi2021",
        Version = "1.0.0",
        
        Targets = [
            new ModuleLanguageTargetConfiguration
            {
                TargetName = "Wasm",
                TargetDescription = "Compiles to webassembly",
                TargetIdentifier = "wasm",
                
                LanguageOutput = new BetaOutputConfiguration() {
                    EnabledOpcodes = BetaIsa.None
                        | BetaIsa.Dup
                        | BetaIsa.Swap,
                    SizedOperations = false,
                }
            }
        ]
    };
}
