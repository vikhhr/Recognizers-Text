// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.
// ------------------------------------------------------------------------------

package com.microsoft.recognizers.text.number.resources;

import java.util.Arrays;
import java.util.List;
import java.util.Map;

import com.google.common.collect.ImmutableMap;

public class PortugueseNumeric {

    public static final String LangMarker = "Por";

    public static final Boolean CompoundNumberLanguage = false;

    public static final Boolean MultiDecimalSeparatorCulture = false;

    public static final String HundredsNumberIntegerRegex = "(quatrocent[ao]s|trezent[ao]s|seiscent[ao]s|setecent[ao]s|oitocent[ao]s|novecent[ao]s|duzent[ao]s|quinhent[ao]s|cem|(?<!por\\s+)(cento))";

    public static final String RoundNumberIntegerRegex = "(mil(h([ãa]o|[õo]es))?|bilh([ãa]o|[õo]es)|trilh([ãa]o|[õo]es)|qua[td]rilh([ãa]o|[õo]es)|quintilh([ãa]o|[õo]es))";

    public static final String ZeroToNineIntegerRegex = "(quatro|cinco|sete|nove|zero|tr[êe]s|seis|oito|d(oi|ua)s|h?uma?)";

    public static final String TwoToNineIntegerRegex = "(quatro|cinco|sete|nove|tr[êe]s|seis|oito|d(oi|ua)s)";

    public static final String TenToNineteenIntegerRegex = "(dez[ea]sseis|dez[ea]ssete|dez[ea]nove|dezoito|(c|qua)torze|quinze|treze|d[ée]z|onze|doze)";

    public static final String TensNumberIntegerRegex = "(cinquenta|quarenta|trinta|sessenta|setenta|oitenta|noventa|vinte)";

    public static final String DigitsNumberRegex = "\\d|\\d{1,3}(\\.\\d{3})";

    public static final String BelowHundredsRegex = "(({TenToNineteenIntegerRegex}|({TensNumberIntegerRegex}(\\s+e\\s+{ZeroToNineIntegerRegex})?))|{ZeroToNineIntegerRegex})"
            .replace("{TenToNineteenIntegerRegex}", TenToNineteenIntegerRegex)
            .replace("{TensNumberIntegerRegex}", TensNumberIntegerRegex)
            .replace("{ZeroToNineIntegerRegex}", ZeroToNineIntegerRegex);

    public static final String BelowThousandsRegex = "({HundredsNumberIntegerRegex}(\\s+e\\s+{BelowHundredsRegex})?|{BelowHundredsRegex})"
            .replace("{HundredsNumberIntegerRegex}", HundredsNumberIntegerRegex)
            .replace("{BelowHundredsRegex}", BelowHundredsRegex);

    public static final String SupportThousandsRegex = "(({BelowThousandsRegex}|{BelowHundredsRegex})\\s+{RoundNumberIntegerRegex}(\\s+{RoundNumberIntegerRegex})?)"
            .replace("{BelowThousandsRegex}", BelowThousandsRegex)
            .replace("{BelowHundredsRegex}", BelowHundredsRegex)
            .replace("{RoundNumberIntegerRegex}", RoundNumberIntegerRegex);

    public static final String NegativeNumberTermsRegex = "^[.]";

    public static final String NegativeNumberSignRegex = "^({NegativeNumberTermsRegex}\\s+).*"
            .replace("{NegativeNumberTermsRegex}", NegativeNumberTermsRegex);

    public static final String SeparaIntRegex = "({SupportThousandsRegex}(\\s+{SupportThousandsRegex})*(\\s+{BelowThousandsRegex})?|{BelowThousandsRegex})"
            .replace("{SupportThousandsRegex}", SupportThousandsRegex)
            .replace("{BelowThousandsRegex}", BelowThousandsRegex);

    public static final String AllIntRegex = "({SeparaIntRegex}|mil(\\s+{BelowThousandsRegex})?)"
            .replace("{SeparaIntRegex}", SeparaIntRegex)
            .replace("{BelowThousandsRegex}", BelowThousandsRegex);

    public static final String AllPointRegex = "((\\s+{ZeroToNineIntegerRegex})+|(\\s+{AllIntRegex}))"
            .replace("{ZeroToNineIntegerRegex}", ZeroToNineIntegerRegex)
            .replace("{AllIntRegex}", AllIntRegex);

    public static final String SpecialFractionInteger = "((({AllIntRegex})i?({ZeroToNineIntegerRegex})|({AllIntRegex}))\\s+a?v[oa]s?)"
            .replace("{AllIntRegex}", AllIntRegex)
            .replace("{ZeroToNineIntegerRegex}", ZeroToNineIntegerRegex);

    public static final String PlaceHolderDefault = "\\D|\\b";

    public static final String PlaceHolderPureNumber = "\\b";

    public static final String AllIntRegexWithLocks = "((?<=\\b){AllIntRegex}(?=\\b))"
            .replace("{AllIntRegex}", AllIntRegex);

    public static final String AllIntRegexWithDozenSuffixLocks = "(?<=\\b)(((meia)?\\s+(d[úu]zia))|({AllIntRegex}\\s+(e|com)\\s+)?({AllIntRegex}\\s+(d[úu]zia(s)?|dezena(s)?)))(?=\\b)"
            .replace("{AllIntRegex}", AllIntRegex);

    public static String NumbersWithPlaceHolder(String placeholder) {
        return "(((?<!\\d+\\s*)-\\s*)|(?<=\\b))\\d+(?!(,\\d+[a-zA-Z]))(?={placeholder})"
            .replace("{placeholder}", placeholder);
    }

    public static final String NumbersWithSuffix = "(((?<=\\W|^)-\\s*)|(?<=\\b))\\d+\\s*{BaseNumbers.NumberMultiplierRegex}(?=\\b)"
            .replace("{BaseNumbers.NumberMultiplierRegex}", BaseNumbers.NumberMultiplierRegex);

    public static final String RoundNumberIntegerRegexWithLocks = "(?<=\\b)({DigitsNumberRegex})+\\s+{RoundNumberIntegerRegex}(?=\\b)"
            .replace("{DigitsNumberRegex}", DigitsNumberRegex)
            .replace("{RoundNumberIntegerRegex}", RoundNumberIntegerRegex);

    public static final String NumbersWithDozenSuffix = "(((?<!\\d+\\s*)-\\s*)|(?<=\\b))\\d+\\s+dezena(s)?(?=\\b)";

    public static final String NumbersWithDozen2Suffix = "(((?<=\\W|^)-\\s*)|(?<=\\b))\\d+\\s+d[úu]zia(s)(?=\\b)";

    public static final String SimpleRoundOrdinalRegex = "(mil[eé]sim[oa]|milion[eé]sim[oa]|bilion[eé]sim[oa]|trilion[eé]sim[oa]|quatrilion[eé]sim[oa]|quintilion[eé]sim[oa])";

    public static final String OneToNineOrdinalRegex = "(primeir[oa]|segund[oa]|terceir[oa]|terç[oa]|quart[oa]|quint[oa]|sext[oa]|s[eé]tim[oa]|oitav[oa]|non[oa])";

    public static final String TensOrdinalRegex = "(nonag[eé]sim[oa]|octog[eé]sim[oa]|setuag[eé]sim[oa]|septuag[eé]sim[oa]|sexag[eé]sim[oa]|quinquag[eé]sim[oa]|quadrag[eé]sim[oa]|trig[eé]sim[oa]|vig[eé]sim[oa]|d[eé]cim[oa])";

    public static final String HundredOrdinalRegex = "(cent[eé]sim[oa]|ducent[eé]sim[oa]|tricent[eé]sim[oa]|cuadringent[eé]sim[oa]|quingent[eé]sim[oa]|sexcent[eé]sim[oa]|septingent[eé]sim[oa]|octingent[eé]sim[oa]|noningent[eé]sim[oa])";

    public static final String SpecialUnderHundredOrdinalRegex = "(und[eé]cim[oa]|duod[eé]cimo)";

    public static final String UnderHundredOrdinalRegex = "((({TensOrdinalRegex}(\\s)?)?{OneToNineOrdinalRegex})|{TensOrdinalRegex}|{SpecialUnderHundredOrdinalRegex})"
            .replace("{TensOrdinalRegex}", TensOrdinalRegex)
            .replace("{OneToNineOrdinalRegex}", OneToNineOrdinalRegex)
            .replace("{SpecialUnderHundredOrdinalRegex}", SpecialUnderHundredOrdinalRegex);

    public static final String UnderThousandOrdinalRegex = "((({HundredOrdinalRegex}(\\s)?)?{UnderHundredOrdinalRegex})|{HundredOrdinalRegex})"
            .replace("{HundredOrdinalRegex}", HundredOrdinalRegex)
            .replace("{UnderHundredOrdinalRegex}", UnderHundredOrdinalRegex);

    public static final String OverThousandOrdinalRegex = "(({AllIntRegex})([eé]sim[oa]))"
            .replace("{AllIntRegex}", AllIntRegex);

    public static final String ComplexOrdinalRegex = "(({OverThousandOrdinalRegex}(\\s)?)?{UnderThousandOrdinalRegex}|{OverThousandOrdinalRegex})"
            .replace("{OverThousandOrdinalRegex}", OverThousandOrdinalRegex)
            .replace("{UnderThousandOrdinalRegex}", UnderThousandOrdinalRegex);

    public static final String SuffixRoundOrdinalRegex = "(({AllIntRegex})({SimpleRoundOrdinalRegex}))"
            .replace("{AllIntRegex}", AllIntRegex)
            .replace("{SimpleRoundOrdinalRegex}", SimpleRoundOrdinalRegex);

    public static final String ComplexRoundOrdinalRegex = "((({SuffixRoundOrdinalRegex}(\\s)?)?{ComplexOrdinalRegex})|{SuffixRoundOrdinalRegex})"
            .replace("{SuffixRoundOrdinalRegex}", SuffixRoundOrdinalRegex)
            .replace("{ComplexOrdinalRegex}", ComplexOrdinalRegex);

    public static final String AllOrdinalRegex = "{ComplexOrdinalRegex}|{SimpleRoundOrdinalRegex}|{ComplexRoundOrdinalRegex}"
            .replace("{ComplexOrdinalRegex}", ComplexOrdinalRegex)
            .replace("{SimpleRoundOrdinalRegex}", SimpleRoundOrdinalRegex)
            .replace("{ComplexRoundOrdinalRegex}", ComplexRoundOrdinalRegex);

    public static final String OrdinalSuffixRegex = "(?<=\\b)(\\d*((1|2|3|4|5|6|7|8|9|0)[oaºª]|(1|2|3|4|5|6|7|8|9)(\\.[ºª])))(?=\\b)";

    public static final String OrdinalEnglishRegex = "(?<=\\b){AllOrdinalRegex}(?=\\b)"
            .replace("{AllOrdinalRegex}", AllOrdinalRegex);

    public static final String FractionNotationRegex = "{BaseNumbers.FractionNotationRegex}"
            .replace("{BaseNumbers.FractionNotationRegex}", BaseNumbers.FractionNotationRegex);

    public static final String FractionNotationWithSpacesRegex = "(((?<=\\W|^)-\\s*)|(?<=\\b))\\d+\\s+\\d+[/]\\d+(?=(\\b[^/]|$))";

    public static final String FractionMultiplierRegex = "(?<fracMultiplier>\\s+(e|com)\\s+(meio|(um|{TwoToNineIntegerRegex})\\s+(meio|terç[oa]|quart[oa]|quint[oa]|sext[oa]|s[eé]tim[oa]|oitav[oa]|non[oa]|d[eé]cim[oa])s?))"
            .replace("{TwoToNineIntegerRegex}", TwoToNineIntegerRegex);

    public static final String RoundMultiplierWithFraction = "(?<multiplier>(?:(mil(h([ãa]o|[õo]es))|bilh([ãa]o|[õo]es)|trilh([ãa]o|[õo]es)|qua[td]rilh([ãa]o|[õo]es)|quintilh([ãa]o|[õo]es))))(?={FractionMultiplierRegex}?$)"
            .replace("{FractionMultiplierRegex}", FractionMultiplierRegex);

    public static final String RoundMultiplierRegex = "\\b\\s*({RoundMultiplierWithFraction}|(?<multiplier>(mil))$)"
            .replace("{RoundMultiplierWithFraction}", RoundMultiplierWithFraction);

    public static final String FractionNounRegex = "(?<=\\b)({AllIntRegex}\\s+((e|com)\\s+)?)?(({AllIntRegex})(\\s+((e|com)\\s)?)((({AllOrdinalRegex})s?|({SpecialFractionInteger})|({SuffixRoundOrdinalRegex})s?)|mei[oa]?|ter[çc]o?)|(meio|um\\s+quarto\\s+de)\\s+{RoundNumberIntegerRegex})(?=\\b)"
            .replace("{AllIntRegex}", AllIntRegex)
            .replace("{AllOrdinalRegex}", AllOrdinalRegex)
            .replace("{SpecialFractionInteger}", SpecialFractionInteger)
            .replace("{SuffixRoundOrdinalRegex}", SuffixRoundOrdinalRegex)
            .replace("{RoundNumberIntegerRegex}", RoundNumberIntegerRegex);

    public static final String FractionNounWithArticleRegex = "(?<=\\b)(({AllIntRegex}|{RoundNumberIntegerRegexWithLocks})\\s+(e\\s+)?)?((um|um[as])(\\s+)(({AllOrdinalRegex})|({SuffixRoundOrdinalRegex})|(e\\s+)?mei[oa]?)|mei[oa]?)(?=\\b)"
            .replace("{AllIntRegex}", AllIntRegex)
            .replace("{AllOrdinalRegex}", AllOrdinalRegex)
            .replace("{SuffixRoundOrdinalRegex}", SuffixRoundOrdinalRegex)
            .replace("{RoundNumberIntegerRegexWithLocks}", RoundNumberIntegerRegexWithLocks);

    public static final String FractionPrepositionRegex = "(?<!{BaseNumbers.CommonCurrencySymbol}\\s*)(?<=\\b)(?<numerator>({AllIntRegex})|((?<!\\.)\\d+))\\s+sobre\\s+(?<denominator>({AllIntRegex})|((\\d+)(?!\\.)))(?=\\b)"
            .replace("{AllIntRegex}", AllIntRegex)
            .replace("{BaseNumbers.CommonCurrencySymbol}", BaseNumbers.CommonCurrencySymbol);

    public static final String AllFloatRegex = "{AllIntRegex}(\\s+(vírgula|virgula|e|ponto)){AllPointRegex}"
            .replace("{AllIntRegex}", AllIntRegex)
            .replace("{AllPointRegex}", AllPointRegex);

    public static final String DoubleWithMultiplierRegex = "(((?<!\\d+\\s*)-\\s*)|((?<=\\b)(?<!\\d+\\,)))\\d+,\\d+\\s*{BaseNumbers.NumberMultiplierRegex}(?=\\b)"
            .replace("{BaseNumbers.NumberMultiplierRegex}", BaseNumbers.NumberMultiplierRegex);

    public static final String DoubleExponentialNotationRegex = "(((?<!\\d+\\s*)-\\s*)|((?<=\\b)(?<!\\d+,)))(\\d+(,\\d+)?)e([+-]*[1-9]\\d*)(?=\\b)";

    public static final String DoubleCaretExponentialNotationRegex = "(((?<!\\d+\\s*)-\\s*)|((?<=\\b)(?<!\\d+,)))(\\d+(,\\d+)?)\\^([+-]*[1-9]\\d*)(?=\\b)";

    public static String DoubleDecimalPointRegex(String placeholder) {
        return "(((?<!\\d+\\s*)-\\s*)|((?<=\\b)(?<!\\d+,)))\\d+,\\d+(?!(,\\d+))(?={placeholder})"
            .replace("{placeholder}", placeholder);
    }

    public static String DoubleWithoutIntegralRegex(String placeholder) {
        return "(?<=\\s|^)(?<!(\\d+)),\\d+(?!(,\\d+))(?={placeholder})"
            .replace("{placeholder}", placeholder);
    }

    public static final String DoubleWithRoundNumber = "(((?<!\\d+\\s*)-\\s*)|((?<=\\b)(?<!\\d+\\,)))\\d+,\\d+\\s+{RoundNumberIntegerRegex}(?=\\b)"
            .replace("{RoundNumberIntegerRegex}", RoundNumberIntegerRegex);

    public static final String DoubleAllFloatRegex = "((?<=\\b){AllFloatRegex}(?=\\b))"
            .replace("{AllFloatRegex}", AllFloatRegex);

    public static final String NumberWithSuffixPercentage = "(?<!%)({BaseNumbers.NumberReplaceToken})(\\s*)(%(?!{BaseNumbers.NumberReplaceToken})|(por cento|pontos percentuais)\\b)"
            .replace("{BaseNumbers.NumberReplaceToken}", BaseNumbers.NumberReplaceToken);

    public static final String AmbiguousFractionConnectorsRegex = "^[.]";

    public static final Character DecimalSeparatorChar = ',';

    public static final String FractionMarkerToken = "sobre";

    public static final Character NonDecimalSeparatorChar = '.';

    public static final String HalfADozenText = "seis";

    public static final String WordSeparatorToken = "e";

    public static final List<String> WrittenDecimalSeparatorTexts = Arrays.asList("virgula", "vírgula");

    public static final List<String> WrittenGroupSeparatorTexts = Arrays.asList("ponto");

    public static final List<String> WrittenIntegerSeparatorTexts = Arrays.asList("e");

    public static final List<String> WrittenFractionSeparatorTexts = Arrays.asList("com");

    public static final List<String> WrittenFractionSuffix = Arrays.asList("avo", "ava");

    public static final List<String> OneHalfTokens = Arrays.asList("um", "meio");

    public static final Character PluralSuffix = 's';

    public static final String HalfADozenRegex = "meia\\s+d[uú]zia";

    public static final String DigitalNumberRegex = "((?<=\\b)(mil|cem|milh[oõ]es|milh[aã]o|bilh[oõ]es|bilh[aã]o|trilh[oõ]es|trilh[aã]o|milhares|centena|centenas|dezena|dezenas?)(?=\\b))|((?<=(\\d|\\b)){BaseNumbers.MultiplierLookupRegex}(?=\\b))"
            .replace("{BaseNumbers.MultiplierLookupRegex}", BaseNumbers.MultiplierLookupRegex);

    public static final ImmutableMap<String, Long> CardinalNumberMap = ImmutableMap.<String, Long>builder()
        .put("zero", 0L)
        .put("hum", 1L)
        .put("um", 1L)
        .put("uma", 1L)
        .put("dois", 2L)
        .put("duas", 2L)
        .put("meia", 2L)
        .put("meio", 2L)
        .put("tres", 3L)
        .put("três", 3L)
        .put("quatro", 4L)
        .put("cinco", 5L)
        .put("seis", 6L)
        .put("sete", 7L)
        .put("oito", 8L)
        .put("nove", 9L)
        .put("dez", 10L)
        .put("dezena", 10L)
        .put("déz", 10L)
        .put("onze", 11L)
        .put("doze", 12L)
        .put("dúzia", 12L)
        .put("duzia", 12L)
        .put("dúzias", 12L)
        .put("duzias", 12L)
        .put("treze", 13L)
        .put("catorze", 14L)
        .put("quatorze", 14L)
        .put("quinze", 15L)
        .put("dezesseis", 16L)
        .put("dezasseis", 16L)
        .put("dezessete", 17L)
        .put("dezassete", 17L)
        .put("dezoito", 18L)
        .put("dezenove", 19L)
        .put("dezanove", 19L)
        .put("vinte", 20L)
        .put("trinta", 30L)
        .put("quarenta", 40L)
        .put("cinquenta", 50L)
        .put("cincoenta", 50L)
        .put("sessenta", 60L)
        .put("setenta", 70L)
        .put("oitenta", 80L)
        .put("noventa", 90L)
        .put("cem", 100L)
        .put("cento", 100L)
        .put("duzentos", 200L)
        .put("duzentas", 200L)
        .put("trezentos", 300L)
        .put("trezentas", 300L)
        .put("quatrocentos", 400L)
        .put("quatrocentas", 400L)
        .put("quinhentos", 500L)
        .put("quinhentas", 500L)
        .put("seiscentos", 600L)
        .put("seiscentas", 600L)
        .put("setecentos", 700L)
        .put("setecentas", 700L)
        .put("oitocentos", 800L)
        .put("oitocentas", 800L)
        .put("novecentos", 900L)
        .put("novecentas", 900L)
        .put("mil", 1000L)
        .put("milhão", 1000000L)
        .put("milhao", 1000000L)
        .put("milhões", 1000000L)
        .put("milhoes", 1000000L)
        .put("bilhão", 1000000000L)
        .put("bilhao", 1000000000L)
        .put("bilhões", 1000000000L)
        .put("bilhoes", 1000000000L)
        .put("trilhão", 1000000000000L)
        .put("trilhao", 1000000000000L)
        .put("trilhões", 1000000000000L)
        .put("trilhoes", 1000000000000L)
        .build();

    public static final ImmutableMap<String, Long> OrdinalNumberMap = ImmutableMap.<String, Long>builder()
        .put("primeiro", 1L)
        .put("primeira", 1L)
        .put("segundo", 2L)
        .put("segunda", 2L)
        .put("terceiro", 3L)
        .put("terceira", 3L)
        .put("terço", 3L)
        .put("terça", 3L)
        .put("quarto", 4L)
        .put("quarta", 4L)
        .put("quinto", 5L)
        .put("quinta", 5L)
        .put("sexto", 6L)
        .put("sexta", 6L)
        .put("sétimo", 7L)
        .put("setimo", 7L)
        .put("sétima", 7L)
        .put("setima", 7L)
        .put("oitavo", 8L)
        .put("oitava", 8L)
        .put("nono", 9L)
        .put("nona", 9L)
        .put("décimo", 10L)
        .put("decimo", 10L)
        .put("décima", 10L)
        .put("decima", 10L)
        .put("undécimo", 11L)
        .put("undecimo", 11L)
        .put("undécima", 11L)
        .put("undecima", 11L)
        .put("duodécimo", 11L)
        .put("duodecimo", 11L)
        .put("duodécima", 11L)
        .put("duodecima", 11L)
        .put("vigésimo", 20L)
        .put("vigesimo", 20L)
        .put("vigésima", 20L)
        .put("vigesima", 20L)
        .put("trigésimo", 30L)
        .put("trigesimo", 30L)
        .put("trigésima", 30L)
        .put("trigesima", 30L)
        .put("quadragésimo", 40L)
        .put("quadragesimo", 40L)
        .put("quadragésima", 40L)
        .put("quadragesima", 40L)
        .put("quinquagésimo", 50L)
        .put("quinquagesimo", 50L)
        .put("quinquagésima", 50L)
        .put("quinquagesima", 50L)
        .put("sexagésimo", 60L)
        .put("sexagesimo", 60L)
        .put("sexagésima", 60L)
        .put("sexagesima", 60L)
        .put("septuagésimo", 70L)
        .put("septuagesimo", 70L)
        .put("septuagésima", 70L)
        .put("septuagesima", 70L)
        .put("setuagésimo", 70L)
        .put("setuagesimo", 70L)
        .put("setuagésima", 70L)
        .put("setuagesima", 70L)
        .put("octogésimo", 80L)
        .put("octogesimo", 80L)
        .put("octogésima", 80L)
        .put("octogesima", 80L)
        .put("nonagésimo", 90L)
        .put("nonagesimo", 90L)
        .put("nonagésima", 90L)
        .put("nonagesima", 90L)
        .put("centesimo", 100L)
        .put("centésimo", 100L)
        .put("centesima", 100L)
        .put("centésima", 100L)
        .put("ducentésimo", 200L)
        .put("ducentesimo", 200L)
        .put("ducentésima", 200L)
        .put("ducentesima", 200L)
        .put("tricentésimo", 300L)
        .put("tricentesimo", 300L)
        .put("tricentésima", 300L)
        .put("tricentesima", 300L)
        .put("trecentésimo", 300L)
        .put("trecentesimo", 300L)
        .put("trecentésima", 300L)
        .put("trecentesima", 300L)
        .put("quadringentésimo", 400L)
        .put("quadringentesimo", 400L)
        .put("quadringentésima", 400L)
        .put("quadringentesima", 400L)
        .put("quingentésimo", 500L)
        .put("quingentesimo", 500L)
        .put("quingentésima", 500L)
        .put("quingentesima", 500L)
        .put("sexcentésimo", 600L)
        .put("sexcentesimo", 600L)
        .put("sexcentésima", 600L)
        .put("sexcentesima", 600L)
        .put("seiscentésimo", 600L)
        .put("seiscentesimo", 600L)
        .put("seiscentésima", 600L)
        .put("seiscentesima", 600L)
        .put("septingentésimo", 700L)
        .put("septingentesimo", 700L)
        .put("septingentésima", 700L)
        .put("septingentesima", 700L)
        .put("setingentésimo", 700L)
        .put("setingentesimo", 700L)
        .put("setingentésima", 700L)
        .put("setingentesima", 700L)
        .put("octingentésimo", 800L)
        .put("octingentesimo", 800L)
        .put("octingentésima", 800L)
        .put("octingentesima", 800L)
        .put("noningentésimo", 900L)
        .put("noningentesimo", 900L)
        .put("noningentésima", 900L)
        .put("noningentesima", 900L)
        .put("nongentésimo", 900L)
        .put("nongentesimo", 900L)
        .put("nongentésima", 900L)
        .put("nongentesima", 900L)
        .put("milésimo", 1000L)
        .put("milesimo", 1000L)
        .put("milésima", 1000L)
        .put("milesima", 1000L)
        .put("milionésimo", 1000000L)
        .put("milionesimo", 1000000L)
        .put("milionésima", 1000000L)
        .put("milionesima", 1000000L)
        .put("bilionésimo", 1000000000L)
        .put("bilionesimo", 1000000000L)
        .put("bilionésima", 1000000000L)
        .put("bilionesima", 1000000000L)
        .build();

    public static final ImmutableMap<String, Long> PrefixCardinalMap = ImmutableMap.<String, Long>builder()
        .put("hum", 1L)
        .put("um", 1L)
        .put("dois", 2L)
        .put("tres", 3L)
        .put("três", 3L)
        .put("quatro", 4L)
        .put("cinco", 5L)
        .put("seis", 6L)
        .put("sete", 7L)
        .put("oito", 8L)
        .put("nove", 9L)
        .put("dez", 10L)
        .put("onze", 11L)
        .put("doze", 12L)
        .put("treze", 13L)
        .put("catorze", 14L)
        .put("quatorze", 14L)
        .put("quinze", 15L)
        .put("dezesseis", 16L)
        .put("dezasseis", 16L)
        .put("dezessete", 17L)
        .put("dezassete", 17L)
        .put("dezoito", 18L)
        .put("dezenove", 19L)
        .put("dezanove", 19L)
        .put("vinte", 20L)
        .put("trinta", 30L)
        .put("quarenta", 40L)
        .put("cinquenta", 50L)
        .put("cincoenta", 50L)
        .put("sessenta", 60L)
        .put("setenta", 70L)
        .put("oitenta", 80L)
        .put("noventa", 90L)
        .put("cem", 100L)
        .put("duzentos", 200L)
        .put("trezentos", 300L)
        .put("quatrocentos", 400L)
        .put("quinhentos", 500L)
        .put("seiscentos", 600L)
        .put("setecentos", 700L)
        .put("oitocentos", 800L)
        .put("novecentos", 900L)
        .build();

    public static final ImmutableMap<String, Long> SuffixOrdinalMap = ImmutableMap.<String, Long>builder()
        .put("milesimo", 1000L)
        .put("milionesimo", 1000000L)
        .put("bilionesimo", 1000000000L)
        .put("trilionesimo", 1000000000000L)
        .build();

    public static final ImmutableMap<String, Long> RoundNumberMap = ImmutableMap.<String, Long>builder()
        .put("mil", 1000L)
        .put("milesimo", 1000L)
        .put("milhão", 1000000L)
        .put("milhao", 1000000L)
        .put("milhões", 1000000L)
        .put("milhoes", 1000000L)
        .put("milionésimo", 1000000L)
        .put("milionesimo", 1000000L)
        .put("bilhão", 1000000000L)
        .put("bilhao", 1000000000L)
        .put("bilhões", 1000000000L)
        .put("bilhoes", 1000000000L)
        .put("bilionésimo", 1000000000L)
        .put("bilionesimo", 1000000000L)
        .put("trilhão", 1000000000000L)
        .put("trilhao", 1000000000000L)
        .put("trilhões", 1000000000000L)
        .put("trilhoes", 1000000000000L)
        .put("trilionésimo", 1000000000000L)
        .put("trilionesimo", 1000000000000L)
        .put("dezena", 10L)
        .put("dezenas", 10L)
        .put("dúzia", 12L)
        .put("duzia", 12L)
        .put("dúzias", 12L)
        .put("duzias", 12L)
        .put("k", 1000L)
        .put("m", 1000000L)
        .put("g", 1000000000L)
        .put("b", 1000000000L)
        .put("t", 1000000000000L)
        .build();

    public static final ImmutableMap<String, String> AmbiguityFiltersDict = ImmutableMap.<String, String>builder()
        .put("^[.]", "")
        .build();

    public static final ImmutableMap<String, String> RelativeReferenceOffsetMap = ImmutableMap.<String, String>builder()
        .put("", "")
        .build();

    public static final ImmutableMap<String, String> RelativeReferenceRelativeToMap = ImmutableMap.<String, String>builder()
        .put("", "")
        .build();
}
