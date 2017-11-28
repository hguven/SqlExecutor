﻿namespace FeiniuBus.DynamicQ.Infrastructure
{
    public sealed partial class QueryRelations
    {
        public static QueryRelations And => "And";
        public static QueryRelations Or => "Or";
        public static QueryRelations AndNot => "AndNot";
        public static QueryRelations OrNot => "OrNot";
    }
}