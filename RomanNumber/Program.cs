// See https://aka.ms/new-console-template for more information

using Microsoft.Extensions.DependencyInjection;
using RomanNumber.Core.Converter;
using RomanNumber.Core.Manager;
using RomanNumber.Core.Validator;

var services = new ServiceCollection();
services
    .AddTransient<IRomanNumberExecutor, RomanNumberExecutor>()
    .AddTransient<IRomanNumberConverter, RomanNumberConverter>()
    .AddTransient<IRomanNumberValidator, RomanNumberValidator>();

var serviceProvider = services.BuildServiceProvider();

var romanNumberExecutor = serviceProvider.GetService<IRomanNumberExecutor>();
romanNumberExecutor.Run();



