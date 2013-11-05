﻿using NRules.IntegrationTests.TestAssets;

namespace NRules.IntegrationTests.TestRules
{
    public class HaltRule : BaseRule
    {
        public override void Define()
        {
            FactType1 fact1 = null;

            When()
                .If<FactType1>(() => fact1, f => f.TestProperty == "Valid Value");
            Then()
                .Do(ctx => Notifier.RuleActivated())
                .Do(ctx => ctx.Halt());
        }
    }
}