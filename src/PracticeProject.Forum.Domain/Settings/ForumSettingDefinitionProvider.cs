using Volo.Abp.Settings;

namespace PracticeProject.Forum.Settings
{
    public class ForumSettingDefinitionProvider : SettingDefinitionProvider
    {
        public override void Define(ISettingDefinitionContext context)
        {
            //Define your own settings here. Example:
            //context.Add(new SettingDefinition(ForumSettings.MySetting1));
        }
    }
}
