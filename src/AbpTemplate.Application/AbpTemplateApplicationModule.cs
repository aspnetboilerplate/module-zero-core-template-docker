using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;
using AbpTemplate.Authorization;

namespace AbpTemplate
{
    [DependsOn(
        typeof(AbpTemplateCoreModule), 
        typeof(AbpAutoMapperModule))]
    public class AbpTemplateApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Authorization.Providers.Add<AbpTemplateAuthorizationProvider>();
        }

        public override void Initialize()
        {
            var thisAssembly = typeof(AbpTemplateApplicationModule).GetAssembly();

            IocManager.RegisterAssemblyByConvention(thisAssembly);

            Configuration.Modules.AbpAutoMapper().Configurators.Add(
                // Scan the assembly for classes which inherit from AutoMapper.Profile
                cfg => cfg.AddProfiles(thisAssembly)
            );
        }
    }
}
