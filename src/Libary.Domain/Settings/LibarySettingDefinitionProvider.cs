﻿using Volo.Abp.Settings;

namespace Libary.Settings;

public class LibarySettingDefinitionProvider : SettingDefinitionProvider
{
    public override void Define(ISettingDefinitionContext context)
    {
        //Define your own settings here. Example:
        //context.Add(new SettingDefinition(LibarySettings.MySetting1));
    }
}
