//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
//
//     Generation parameters:
//     - DataFilename: Patterns\French\French-Numbers.yaml
//     - Language: French
//     - ClassName: NumbersDefinitions
// </auto-generated>
//
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.
// ------------------------------------------------------------------------------

namespace Microsoft.Recognizers.Definitions.French
{
    using System;
    using System.Collections.Generic;

    public static class NumbersDefinitions
    {
      public const string LangMarker = @"Fre";
      public const bool CompoundNumberLanguage = false;
      public const bool MultiDecimalSeparatorCulture = true;
      public const string RoundNumberIntegerRegex = @"(cent|mille|millions?|milliards?|billions?)";
      public const string ZeroToNineIntegerRegex = @"(une?|deux|trois|quatre|cinq|six|sept|huit|neuf|z[ée]ro)";
      public const string TwoToNineIntegerRegex = @"(deux|trois|quatre|cinq|six|sept|huit|neuf)";
      public const string TenToNineteenIntegerRegex = @"((seize|quinze|quatorze|treize|douze|onze)|dix(\Wneuf|\Whuit|\Wsept)?)";
      public const string TensNumberIntegerRegex = @"(quatre\Wvingt(s|\Wdix)?|soixante(\Wdix)?|vingt|trente|quarante|cinquante|septante|octante|huitante|nonante)";
      public const string DigitsNumberRegex = @"\d|\d{1,3}(\.\d{3})";
      public const string NegativeNumberTermsRegex = @"^[.]";
      public static readonly string NegativeNumberSignRegex = $@"^({NegativeNumberTermsRegex}\s+).*";
      public static readonly string HundredsNumberIntegerRegex = $@"(({ZeroToNineIntegerRegex}(\s+cent))|cent|((\s+cent\s)+{TensNumberIntegerRegex}))";
      public static readonly string BelowHundredsRegex = $@"(({TenToNineteenIntegerRegex}|({TensNumberIntegerRegex}((-|(\s+et)?\s+)({TenToNineteenIntegerRegex}|{ZeroToNineIntegerRegex}))?))|{ZeroToNineIntegerRegex})";
      public static readonly string BelowThousandsRegex = $@"(({HundredsNumberIntegerRegex}(\s+{BelowHundredsRegex})?|{BelowHundredsRegex}|{TenToNineteenIntegerRegex})|cent\s+{TenToNineteenIntegerRegex})";
      public static readonly string SupportThousandsRegex = $@"(({BelowThousandsRegex}|{BelowHundredsRegex})\s+{RoundNumberIntegerRegex}(\s+{RoundNumberIntegerRegex})?)";
      public static readonly string SeparaIntRegex = $@"({SupportThousandsRegex}(\s+{SupportThousandsRegex})*(\s+{BelowThousandsRegex})?|{BelowThousandsRegex})";
      public static readonly string AllIntRegex = $@"({SeparaIntRegex}|mille(\s+{BelowThousandsRegex})?)";
      public static readonly Func<string, string> NumbersWithPlaceHolder = (placeholder) => $@"(((?<!\d+\s*)-\s*)|(?<=\b))\d+(?!([,\.]\d+[a-zA-Z]))(?={placeholder})";
      public static readonly string NumbersWithSuffix = $@"(((?<=\W|^)-\s*)|(?<=\b))\d+\s*{BaseNumbers.NumberMultiplierRegex}(?=\b)";
      public static readonly string RoundNumberIntegerRegexWithLocks = $@"(?<=\b)({DigitsNumberRegex})+\s+{RoundNumberIntegerRegex}(?=\b)";
      public const string NumbersWithDozenSuffix = @"(((?<!\d+\s*)-\s*)|(?<=\b))\d+\s+douzaine(s)?(?=\b)";
      public static readonly string AllIntRegexWithLocks = $@"((?<=\b){AllIntRegex}(?=\b))";
      public static readonly string AllIntRegexWithDozenSuffixLocks = $@"(?<=\b)(((demi\s+)?\s+douzaine)|({AllIntRegex}\s+douzaines?))(?=\b)";
      public const string SimpleRoundOrdinalRegex = @"(centi|[bm]illioni|milli(ardi)?)[eè]me";
      public const string OneToNineOrdinalRegex = @"(premi[eè]re?|second[e]|tier(s|ce)|(deuxi|troisi|quatri|cinqui|sixi|septi|hui[tr]i|neuvi)[eè]me)";
      public const string SpecialUnderHundredOrdinalRegex = @"(di[xz]i|onzi|douzi|treizi|quatorzi|quinzi|seizi|dix[\s-](septi|huiri|neuvi))[eè]me";
      public const string TensOrdinalRegex = @"(quatre-vingt-di[xz]i[eè]me|quatre-vingti[eè]me|huitanti[eè]me|octanti[eè]me|soixante-dixi[eè]me|septanti[eè]me|soixanti[eè]me|cinquanti[eè]me|quaranti[eè]me|trenti[eè]me|vingti[eè]me)";
      public static readonly string HundredOrdinalRegex = $@"({AllIntRegex}(\s+(centi[eè]me)))";
      public static readonly string UnderHundredOrdinalRegex = $@"(((({AllIntRegex}|{TensNumberIntegerRegex})(\W)?)?({OneToNineOrdinalRegex}|\s+et\s+uni[eè]me))|{SpecialUnderHundredOrdinalRegex}|{TensOrdinalRegex})";
      public static readonly string UnderThousandOrdinalRegex = $@"((({HundredOrdinalRegex}(\s|-)?)?{UnderHundredOrdinalRegex})|(({AllIntRegex}(\W)?)?{SimpleRoundOrdinalRegex})|{HundredOrdinalRegex})";
      public static readonly string OverThousandOrdinalRegex = $@"(({AllIntRegex})(-i[eè]me))";
      public static readonly string ComplexOrdinalRegex = $@"(({OverThousandOrdinalRegex}(\s)?)?{UnderThousandOrdinalRegex}|{OverThousandOrdinalRegex}|{UnderHundredOrdinalRegex})";
      public static readonly string SuffixOrdinalRegex = $@"(({AllIntRegex})({SimpleRoundOrdinalRegex}))";
      public static readonly string ComplexRoundOrdinalRegex = $@"((({SuffixOrdinalRegex}(\s)?)?{ComplexOrdinalRegex})|{SuffixOrdinalRegex})";
      public static readonly string AllOrdinalRegex = $@"({ComplexOrdinalRegex}|{SimpleRoundOrdinalRegex}|{ComplexRoundOrdinalRegex})";
      public const string PlaceHolderPureNumber = @"\b";
      public const string PlaceHolderDefault = @"\D|\b";
      public const string OrdinalSuffixRegex = @"(?<=\b)((\d*(11e(me)?|1[eè]re?|[02-9]e(me)?)))(?=\b)";
      public static readonly string OrdinalFrenchRegex = $@"(?<=\b){AllOrdinalRegex}(?=\b)";
      public const string FractionNotationWithSpacesRegex = @"(((?<=\W|^)-\s*)|(?<=\b))\d+\s+\d+[/]\d+(?=(\b[^/]|$))";
      public static readonly string FractionNotationRegex = $@"{BaseNumbers.FractionNotationRegex}";
      public static readonly string FractionMultiplierRegex = $@"(?<fracMultiplier>\s+et\s+(demi[es]?|(une?|{TwoToNineIntegerRegex})\s+(demie?|tier|quart|(cinqui|sixi|septi|hui[tr]i|neuvi|dixi)[eè]me)s?))";
      public static readonly string RoundMultiplierWithFraction = $@"(?<multiplier>(millions?|milliards?|billions?))(?={FractionMultiplierRegex}?$)";
      public static readonly string RoundMultiplierRegex = $@"\b\s*({RoundMultiplierWithFraction}|(?<multiplier>(cent|mille))$)";
      public static readonly string FractionNounRegex = $@"(?<=\b)({AllIntRegex}\s+((et)\s+)?)?({AllIntRegex}(\s+((et)\s)?)(({AllOrdinalRegex}s?|{SuffixOrdinalRegex}s?)|(demi[es]?|tiers?|quarts?))|(un\s+)?(demi|tier|quart)(\s+(de\s+)?|\s*-\s*){RoundNumberIntegerRegex})(?=\b)";
      public static readonly string FractionNounWithArticleRegex = $@"(?<=\b)(({AllIntRegex}|{RoundNumberIntegerRegexWithLocks})\s+(et\s+)?)?((une?)(\s+)(({AllOrdinalRegex})|({SuffixOrdinalRegex})|(et\s+)?demi[es]?)|demi[es]?)(?=\b)";
      public static readonly string FractionPrepositionRegex = $@"(?<!{BaseNumbers.CommonCurrencySymbol}\s*)(?<=\b)(?<numerator>({AllIntRegex})|((?<!\.)\d+))\s+sur\s+(?<denominator>({AllIntRegex})|((\d+)(?!\.)))(?=\b)";
      public static readonly string AllPointRegex = $@"((\s+{ZeroToNineIntegerRegex})+|(\s+{SeparaIntRegex}))";
      public static readonly string AllFloatRegex = $@"({AllIntRegex}(\s+(virgule|point)){AllPointRegex})";
      public static readonly Func<string, string> DoubleDecimalPointRegex = (placeholder) => $@"(((?<!\d+\s*)-\s*)|((?<=\b)(?<!\d+[,\.])))\d+[,\.]\d+(?!([,\.]\d+))(?={placeholder})";
      public static readonly Func<string, string> DoubleWithoutIntegralRegex = (placeholder) => $@"(?<=\s|^)(?<!(\d+))[,\.]\d+(?!([,\.]\d+))(?={placeholder})";
      public static readonly string DoubleWithMultiplierRegex = $@"(((?<!\d+\s*)-\s*)|((?<=\b)(?<!\d+\[,\.])))\d+[,\.]\d+\s*{BaseNumbers.NumberMultiplierRegex}(?=\b)";
      public static readonly string DoubleWithRoundNumber = $@"(((?<!\d+\s*)-\s*)|((?<=\b)(?<!\d+\[,\.])))\d+[,\.]\d+\s+{RoundNumberIntegerRegex}(?=\b)";
      public static readonly string DoubleAllFloatRegex = $@"((?<=\b){AllFloatRegex}(?=\b))";
      public const string DoubleExponentialNotationRegex = @"(((?<!\d+\s*)-\s*)|((?<=\b)(?<!\d+[,\.])))(\d+([,\.]\d+)?)e([+-]*[1-9]\d*)(?=\b)";
      public const string DoubleCaretExponentialNotationRegex = @"(((?<!\d+\s*)-\s*)|((?<=\b)(?<!\d+[,\.])))(\d+([,\.]\d+)?)\^([+-]*[1-9]\d*)(?=\b)";
      public static readonly string NumberWithSuffixPercentage = $@"(?<!%)({BaseNumbers.NumberReplaceToken})(\s*)(%(?!{BaseNumbers.NumberReplaceToken})|(pourcent(s|ages?)?)\b)";
      public static readonly string NumberWithPrefixPercentage = $@"((?<!{BaseNumbers.NumberReplaceToken})%|pourcent|pourcent des|pourcentage de)(\s*)({BaseNumbers.NumberReplaceToken})(?=\s|$)";
      public const string TillRegex = @"((?<!\b[èe]ga(l(es)?|ux)\s+)[àa]|--|-|—|——|~|–)";
      public const string MoreRegex = @"(?:(bigger|greater|more|plus(\s+(haut|grand|âgée?))?|sup[ée]rieure?s?)(\s+([àa]|que))?|dépassant|(au-dessus|(a\s+)?plus|dépassant|au-delà)\s+d[e'’]|exceed(ed|ing)?|(?<!<|=)>)";
      public const string LessRegex = @"(?:(less|plus\s+(bas|petit|jeune)|moins|inf[ée]rieure?s?)(\s+([àa]|d[e'’]|que))?|((en )?dessous)\s+de|under|(?<!>|=)<)";
      public const string EqualRegex = @"(([ée]ga(l(es)?|ux)|au\s+nombre)(\s+([àa]|d[e'’]))?|(?<!<|>)=)";
      public static readonly string MoreOrEqualPrefix = $@"((pas\s+{LessRegex})|(au\s+moins|[àa] partir d[e'’]))";
      public static readonly string MoreOrEqual = $@"(?:({MoreRegex}\s+(ou)?\s+{EqualRegex})|({EqualRegex}\s+(ou)?\s+{MoreRegex})|{MoreOrEqualPrefix}(\s+(ou)?\s+{EqualRegex})?|({EqualRegex}\s+(ou)?\s+)?{MoreOrEqualPrefix}|>\s*=|≥)";
      public const string MoreOrEqualSuffix = @"((et|ou)\s+(((more|greater|higher|plus(\s+grand)?|sup[ée]rieure?s?)((?!\s+([àa]|que))|(\s+([àa]|que)(?!((\s+ou\s+[èe]ga(l(es)?|ux)\s+[àa])?\s*\d+)))))|((a plus|au-dessus)\s+d[e'’](?!\s+than))))";
      public static readonly string LessOrEqualPrefix = $@"((pas\s+{MoreRegex})|(au\s+plus)|(jusqu'[àa]))";
      public static readonly string LessOrEqual = $@"(({LessRegex}\s+(ou)?\s+{EqualRegex})|({EqualRegex}\s+(ou)?\s+{LessRegex})|{LessOrEqualPrefix}(\s+(ou)?\s+{EqualRegex})?|({EqualRegex}\s+(ou)?\s+)?{LessOrEqualPrefix}|<\s*=|≤)";
      public const string LessOrEqualSuffix = @"((et|ou)\s+(less|lower|plus petit|moins|inf[ée]rieure?s?)((?!\s+([àa]|de|que))|(\s+([àa]|d[e'’]|que)(?!(\s*\d+)))))";
      public static readonly string NumberSplitMark = $@"(?![,.](?!\d+))(?!\s*\b(et\s+({LessRegex}|{MoreRegex})|mais|ou|to)\b)";
      public const string MoreRegexNoNumberSucceed = @"((bigger|greater|more|plus(\s+grand)?|sup[ée]rieure?s?)((?!\s+([àa]|que))|\s+(([àa]|que)(?!(\s*\d+))))|((au-dessus|a plus)\s+d[e'’])(?!(\s*\d+)))";
      public const string LessRegexNoNumberSucceed = @"((less|lower|plus petit|moins|inf[ée]rieure?s?)((?!\s+([àa]|d[e'’]|que))|\s+(([àa]|d[e'’]|que)(?!(\s*\d+))))|(((en )?dessous)\s+d[e'’]|under)(?!(\s*\d+)))";
      public const string EqualRegexNoNumberSucceed = @"([èe]ga(l(es)?|ux)((?!\s+([àa]))|(\s+([àa]|que)(?!(\s*\d+)))))";
      public static readonly string OneNumberRangeMoreRegex1 = $@"({MoreOrEqual}|{MoreRegex})\s*(l[ae]\s+)?(?<number1>({NumberSplitMark}.)+)";
      public static readonly string OneNumberRangeMoreRegex1LB = $@"(?<!pas\s+){OneNumberRangeMoreRegex1}";
      public static readonly string OneNumberRangeMoreRegex2 = $@"(?<number1>({NumberSplitMark}.)+)\s*{MoreOrEqualSuffix}";
      public static readonly string OneNumberRangeMoreSeparateRegex = $@"({EqualRegex}\s+(?<number1>({NumberSplitMark}.)+)(\s+ou\s+){MoreRegexNoNumberSucceed})|({MoreRegex}\s+(?<number1>({NumberSplitMark}.)+)(\s+ou\s+){EqualRegexNoNumberSucceed})";
      public static readonly string OneNumberRangeLessRegex1 = $@"({LessOrEqual}|{LessRegex})\s*(l[ae]\s+)?(?<number2>({NumberSplitMark}.)+)";
      public static readonly string OneNumberRangeLessRegex1LB = $@"(?<!pas\s+){OneNumberRangeLessRegex1}";
      public static readonly string OneNumberRangeLessRegex2 = $@"(?<number2>({NumberSplitMark}.)+)\s*{LessOrEqualSuffix}";
      public static readonly string OneNumberRangeLessSeparateRegex = $@"({EqualRegex}\s+(?<number1>({NumberSplitMark}.)+)(\s+ou\s+){LessRegexNoNumberSucceed})|({LessRegex}\s+(?<number1>({NumberSplitMark}.)+)(\s+ou\s+){EqualRegexNoNumberSucceed})";
      public static readonly string OneNumberRangeEqualRegex = $@"(?<!\b([àa]|que)\s+ou\s+){EqualRegex}\s*(l[ae]\s+)?(?<number1>({NumberSplitMark}.)+)";
      public static readonly string TwoNumberRangeRegex1 = $@"entre\s*(l[ae]\s+)?(?<number1>({NumberSplitMark}.)+)\s*et\s*(l[ae]\s+)?(?<number2>({NumberSplitMark}.)+)";
      public static readonly string TwoNumberRangeRegex2 = $@"({OneNumberRangeMoreRegex1}|{OneNumberRangeMoreRegex2})\s*(et|mais|,)\s*({OneNumberRangeLessRegex1}|{OneNumberRangeLessRegex2})";
      public static readonly string TwoNumberRangeRegex3 = $@"({OneNumberRangeLessRegex1}|{OneNumberRangeLessRegex2})\s*(et|mais|,)\s*({OneNumberRangeMoreRegex1}|{OneNumberRangeMoreRegex2})";
      public static readonly string TwoNumberRangeRegex4 = $@"(de\s+)?(?<number1>({NumberSplitMark}(?!\bde\b).)+)\s*{TillRegex}\s*(l[ae]\s+)?(?<number2>({NumberSplitMark}.)+)";
      public const char DecimalSeparatorChar = ',';
      public const string FractionMarkerToken = @"sur";
      public const char NonDecimalSeparatorChar = '.';
      public const string HalfADozenText = @"six";
      public const string WordSeparatorToken = @"et";
      public static readonly string[] WrittenDecimalSeparatorTexts = { @"virgule" };
      public static readonly string[] WrittenGroupSeparatorTexts = { @"point", @"points" };
      public static readonly string[] WrittenIntegerSeparatorTexts = { @"et", @"-" };
      public static readonly string[] WrittenFractionSeparatorTexts = { @"et", @"sur" };
      public static readonly string[] OneHalfTokens = { @"un", @"demi" };
      public const string HalfADozenRegex = @"(?<=\b)demie?\s+douzaine";
      public static readonly string DigitalNumberRegex = $@"((?<=\b)(cent|mille|millions?|milliards?|billions?|douzaines?)(?=\b))|((?<=(\d|\b)){BaseNumbers.MultiplierLookupRegex}(?=\b))";
      public const string AmbiguousFractionConnectorsRegex = @"^[.]";
      public static readonly Dictionary<string, long> CardinalNumberMap = new Dictionary<string, long>
        {
            { @"zéro", 0 },
            { @"zero", 0 },
            { @"un", 1 },
            { @"une", 1 },
            { @"deux", 2 },
            { @"trois", 3 },
            { @"quatre", 4 },
            { @"cinq", 5 },
            { @"six", 6 },
            { @"sept", 7 },
            { @"huit", 8 },
            { @"neuf", 9 },
            { @"dix", 10 },
            { @"onze", 11 },
            { @"douze", 12 },
            { @"douzaine", 12 },
            { @"douzaines", 12 },
            { @"treize", 13 },
            { @"quatorze", 14 },
            { @"quinze", 15 },
            { @"seize", 16 },
            { @"dix-sept", 17 },
            { @"dix-huit", 18 },
            { @"dix-huir", 18 },
            { @"dix-neuf", 19 },
            { @"vingt", 20 },
            { @"trente", 30 },
            { @"quarante", 40 },
            { @"cinquante", 50 },
            { @"soixante", 60 },
            { @"soixante-dix", 70 },
            { @"septante", 70 },
            { @"quatre-vingts", 80 },
            { @"quatre-vingt", 80 },
            { @"quatre vingts", 80 },
            { @"quatre vingt", 80 },
            { @"quatre-vingt-dix", 90 },
            { @"quatre-vingt dix", 90 },
            { @"quatre vingt dix", 90 },
            { @"quatre-vingts-dix", 90 },
            { @"quatre-vingts-onze", 91 },
            { @"quatre-vingt-onze", 91 },
            { @"quatre-vingts-douze", 92 },
            { @"quatre-vingt-douze", 92 },
            { @"quatre-vingts-treize", 93 },
            { @"quatre-vingt-treize", 93 },
            { @"quatre-vingts-quatorze", 94 },
            { @"quatre-vingt-quatorze", 94 },
            { @"quatre-vingts-quinze", 95 },
            { @"quatre-vingt-quinze", 95 },
            { @"quatre-vingts-seize", 96 },
            { @"quatre-vingt-seize", 96 },
            { @"huitante", 80 },
            { @"octante", 80 },
            { @"nonante", 90 },
            { @"cent", 100 },
            { @"mille", 1000 },
            { @"un million", 1000000 },
            { @"million", 1000000 },
            { @"millions", 1000000 },
            { @"un milliard", 1000000000 },
            { @"milliard", 1000000000 },
            { @"milliards", 1000000000 },
            { @"un mille milliards", 1000000000000 },
            { @"un billion", 1000000000000 }
        };
      public static readonly Dictionary<string, long> OrdinalNumberMap = new Dictionary<string, long>
        {
            { @"premier", 1 },
            { @"première", 1 },
            { @"premiere", 1 },
            { @"unième", 1 },
            { @"unieme", 1 },
            { @"deuxième", 2 },
            { @"deuxieme", 2 },
            { @"second", 2 },
            { @"seconde", 2 },
            { @"troisième", 3 },
            { @"demi", 2 },
            { @"demie", 2 },
            { @"tiers", 3 },
            { @"tierce", 3 },
            { @"quart", 4 },
            { @"quarts", 4 },
            { @"troisieme", 3 },
            { @"quatrième", 4 },
            { @"quatrieme", 4 },
            { @"cinquième", 5 },
            { @"cinquieme", 5 },
            { @"sixième", 6 },
            { @"sixieme", 6 },
            { @"septième", 7 },
            { @"septieme", 7 },
            { @"huitième", 8 },
            { @"huitieme", 8 },
            { @"huirième", 8 },
            { @"huirieme", 8 },
            { @"neuvième", 9 },
            { @"neuvieme", 9 },
            { @"dixième", 10 },
            { @"dixieme", 10 },
            { @"dizième", 10 },
            { @"dizieme", 10 },
            { @"onzième", 11 },
            { @"onzieme", 11 },
            { @"douzième", 12 },
            { @"douzieme", 12 },
            { @"treizième", 13 },
            { @"treizieme", 13 },
            { @"quatorzième", 14 },
            { @"quatorzieme", 14 },
            { @"quinzième", 15 },
            { @"quinzieme", 15 },
            { @"seizième", 16 },
            { @"seizieme", 16 },
            { @"dix-septième", 17 },
            { @"dix-septieme", 17 },
            { @"dix-huitième", 18 },
            { @"dix-huitieme", 18 },
            { @"dix-huirième", 18 },
            { @"dix-huirieme", 18 },
            { @"dix-neuvième", 19 },
            { @"dix-neuvieme", 19 },
            { @"vingtième", 20 },
            { @"vingtieme", 20 },
            { @"trentième", 30 },
            { @"trentieme", 30 },
            { @"quarantième", 40 },
            { @"quarantieme", 40 },
            { @"cinquantième", 50 },
            { @"cinquantieme", 50 },
            { @"soixantième", 60 },
            { @"soixantieme", 60 },
            { @"soixante-dixième", 70 },
            { @"soixante-dixieme", 70 },
            { @"septantième", 70 },
            { @"septantieme", 70 },
            { @"quatre-vingtième", 80 },
            { @"quatre-vingtieme", 80 },
            { @"huitantième", 80 },
            { @"huitantieme", 80 },
            { @"octantième", 80 },
            { @"octantieme", 80 },
            { @"quatre-vingt-dixième", 90 },
            { @"quatre-vingt-dixieme", 90 },
            { @"nonantième", 90 },
            { @"nonantieme", 90 },
            { @"centième", 100 },
            { @"centieme", 100 },
            { @"millième", 1000 },
            { @"millieme", 1000 },
            { @"millionième", 1000000 },
            { @"millionieme", 1000000 },
            { @"milliardième", 1000000000 },
            { @"milliardieme", 1000000000 },
            { @"billionieme", 1000000000000 },
            { @"billionième", 1000000000000 },
            { @"trillionième", 1000000000000000000 },
            { @"trillionieme", 1000000000000000000 }
        };
      public static readonly Dictionary<string, long> PrefixCardinalMap = new Dictionary<string, long>
        {
            { @"deux", 2 },
            { @"trois", 3 },
            { @"quatre", 4 },
            { @"cinq", 5 },
            { @"six", 6 },
            { @"sept", 7 },
            { @"huit", 8 },
            { @"neuf", 9 },
            { @"dix", 10 },
            { @"onze", 11 },
            { @"douze", 12 },
            { @"treize", 13 },
            { @"quatorze", 14 },
            { @"quinze", 15 },
            { @"seize", 16 },
            { @"dix sept", 17 },
            { @"dix-sept", 17 },
            { @"dix-huit", 18 },
            { @"dix huit", 18 },
            { @"dix-neuf", 19 },
            { @"dix neuf", 19 },
            { @"vingt", 20 },
            { @"vingt-et-un", 21 },
            { @"vingt et un", 21 },
            { @"vingt-deux", 21 },
            { @"vingt deux", 22 },
            { @"vingt-trois", 23 },
            { @"vingt trois", 23 },
            { @"vingt-quatre", 24 },
            { @"vingt quatre", 24 },
            { @"vingt-cinq", 25 },
            { @"vingt cinq", 25 },
            { @"vingt-six", 26 },
            { @"vingt six", 26 },
            { @"vingt-sept", 27 },
            { @"vingt sept", 27 },
            { @"vingt-huit", 28 },
            { @"vingt huit", 28 },
            { @"vingt-neuf", 29 },
            { @"vingt neuf", 29 },
            { @"trente", 30 },
            { @"quarante", 40 },
            { @"cinquante", 50 },
            { @"soixante", 60 },
            { @"soixante-dix", 70 },
            { @"soixante dix", 70 },
            { @"septante", 70 },
            { @"quatre-vingt", 80 },
            { @"quatre vingt", 80 },
            { @"huitante", 80 },
            { @"octante", 80 },
            { @"nonante", 90 },
            { @"quatre vingt dix", 90 },
            { @"quatre-vingt-dix", 90 },
            { @"cent", 100 },
            { @"deux cent", 200 },
            { @"trois cents", 300 },
            { @"quatre cents", 400 },
            { @"cinq cent", 500 },
            { @"six cent", 600 },
            { @"sept cent", 700 },
            { @"huit cent", 800 },
            { @"neuf cent", 900 }
        };
      public static readonly Dictionary<string, long> SuffixOrdinalMap = new Dictionary<string, long>
        {
            { @"millième", 1000 },
            { @"million", 1000000 },
            { @"milliardième", 1000000000000 }
        };
      public static readonly Dictionary<string, long> RoundNumberMap = new Dictionary<string, long>
        {
            { @"cent", 100 },
            { @"mille", 1000 },
            { @"million", 1000000 },
            { @"millions", 1000000 },
            { @"milliard", 1000000000 },
            { @"milliards", 1000000000 },
            { @"billion", 1000000000000 },
            { @"billions", 1000000000000 },
            { @"centieme", 100 },
            { @"centième", 100 },
            { @"millieme", 1000 },
            { @"millième", 1000 },
            { @"millionième", 1000000 },
            { @"millionieme", 1000000 },
            { @"milliardième", 1000000000 },
            { @"milliardieme", 1000000000 },
            { @"billionième", 1000000000000 },
            { @"billionieme", 1000000000000 },
            { @"centiemes", 100 },
            { @"centièmes", 100 },
            { @"millièmes", 1000 },
            { @"milliemes", 1000 },
            { @"millionièmes", 1000000 },
            { @"millioniemes", 1000000 },
            { @"milliardièmes", 1000000000 },
            { @"milliardiemes", 1000000000 },
            { @"billionièmes", 1000000000000 },
            { @"billioniemes", 1000000000000 },
            { @"douzaine", 12 },
            { @"douzaines", 12 },
            { @"k", 1000 },
            { @"m", 1000000 },
            { @"g", 1000000000 },
            { @"b", 1000000000 },
            { @"t", 1000000000000 }
        };
      public static readonly Dictionary<string, string> AmbiguityFiltersDict = new Dictionary<string, string>
        {
            { @"^[.]", @"" }
        };
      public static readonly Dictionary<string, string> RelativeReferenceOffsetMap = new Dictionary<string, string>
        {
            { @"", @"" }
        };
      public static readonly Dictionary<string, string> RelativeReferenceRelativeToMap = new Dictionary<string, string>
        {
            { @"", @"" }
        };
    }
}