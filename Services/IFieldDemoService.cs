﻿using Litium.Runtime.DependencyInjection;

namespace Litium.Accelerator.Demo.Services
{
    [Service(
        ServiceType = typeof(IFieldDemoService),
        Lifetime = DependencyLifetime.Singleton)]
    public interface IFieldDemoService
    {
        void AddTextField(string fieldName, bool baseProductfield, string fieldGroup, string templateName);
        void AddTextOptionField(string fieldName, bool baseProductfield, string fieldGroup, string templateName, string options);
    }
}