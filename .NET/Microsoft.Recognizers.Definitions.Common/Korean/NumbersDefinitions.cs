//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
//
//     Generation parameters:
//     - DataFilename: Patterns\Korean\Korean-Numbers.yaml
//     - Language: Korean
//     - ClassName: NumbersDefinitions
// </auto-generated>
//
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.
// ------------------------------------------------------------------------------

namespace Microsoft.Recognizers.Definitions.Korean
{
    using System;
    using System.Collections.Generic;

    public static class NumbersDefinitions
    {
      public const string LangMarker = @"Kor";
      public const bool CompoundNumberLanguage = true;
      public const bool MultiDecimalSeparatorCulture = false;
      public const char DecimalSeparatorChar = '.';
      public const string FractionMarkerToken = @"";
      public const char NonDecimalSeparatorChar = ' ';
      public const string HalfADozenText = @"";
      public const string WordSeparatorToken = @"";
      public const char ZeroChar = '영';
      public const char PairChar = '?';
      public static readonly Dictionary<string, long> RoundNumberMap = new Dictionary<string, long>
        {
            { @"k", 1000 },
            { @"m", 1000000 },
            { @"g", 1000000000 },
            { @"t", 1000000000000 }
        };
      public static readonly Dictionary<char, long> RoundNumberMapChar = new Dictionary<char, long>
        {
            { '십', 10 },
            { '백', 100 },
            { '천', 1000 },
            { '만', 10000 },
            { '억', 100000000 },
            { '조', 1000000000000 },
            { '경', 10000000000000000 },
            { '열', 10 }
        };
      public static readonly Dictionary<char, double> ZeroToNineMap = new Dictionary<char, double>
        {
            { '영', 0 },
            { '일', 1 },
            { '하', 1 },
            { '한', 1 },
            { '이', 2 },
            { '두', 2 },
            { '삼', 3 },
            { '셋', 3 },
            { '세', 3 },
            { '사', 4 },
            { '네', 4 },
            { '오', 5 },
            { '다', 5 },
            { '육', 6 },
            { '여', 6 },
            { '칠', 7 },
            { '곱', 7 },
            { '팔', 8 },
            { '덟', 8 },
            { '구', 9 },
            { '홉', 9 },
            { '빵', 0 },
            { '０', 0 },
            { '１', 1 },
            { '２', 2 },
            { '３', 3 },
            { '４', 4 },
            { '５', 5 },
            { '６', 6 },
            { '７', 7 },
            { '８', 8 },
            { '９', 9 },
            { '0', 0 },
            { '1', 1 },
            { '2', 2 },
            { '3', 3 },
            { '4', 4 },
            { '5', 5 },
            { '6', 6 },
            { '7', 7 },
            { '8', 8 },
            { '9', 9 },
            { '반', 0.5 }
        };
      public static readonly Dictionary<char, char> FullToHalfMap = new Dictionary<char, char>
        {
            { '０', '0' },
            { '１', '1' },
            { '２', '2' },
            { '３', '3' },
            { '４', '4' },
            { '５', '5' },
            { '６', '6' },
            { '７', '7' },
            { '８', '8' },
            { '９', '9' },
            { '／', '/' },
            { '－', '-' },
            { '，', '\'' },
            { 'Ｇ', 'G' },
            { 'Ｍ', 'M' },
            { 'Ｔ', 'T' },
            { 'Ｋ', 'K' },
            { 'ｋ', 'k' },
            { '．', '.' }
        };
      public static readonly Dictionary<string, string> UnitMap = new Dictionary<string, string>
        {
            { @"첫", @"일" },
            { @"처음", @"일" },
            { @"여섯", @"육" },
            { @"하나", @"일" },
            { @"둘", @"이" },
            { @"셋", @"삼" },
            { @"넷", @"사" },
            { @"다섯", @"오" },
            { @"일곱", @"칠" },
            { @"여덟", @"팔" },
            { @"아홉", @"구" },
            { @"스물", @"이십" },
            { @"서른", @"삼십" },
            { @"마흔", @"사십" },
            { @"쉰", @"오십" },
            { @"예순", @"육십" },
            { @"일흔", @"칠십" },
            { @"여든", @"팔십" },
            { @"아흔", @"구십" },
            { @"온", @"백" },
            { @"즈믄", @"천" },
            { @"다스", @"십이" },
            { @"이십오일", @"이십오" },
            { @"스무", @"이십" },
            { @"번째", @"" },
            { @"등", @"" },
            { @"이백십", @"백백십" },
            { @"삼백십", @"백백백십" },
            { @" ", @"" }
        };
      public static readonly IList<char> RoundDirectList = new List<char>
        {
            '빵',
            '열',
            '조',
            '번'
        };
      public static readonly IList<char> TenChars = new List<char>
        {
            '?'
        };
      public static readonly string DigitalNumberRegex = $@"((?<=(\d|\b)){BaseNumbers.MultiplierLookupRegex}(?=\b))";
      public const string ZeroToNineFullHalfRegex = @"[\d１２３４５６７８９０]";
      public static readonly string DigitNumRegex = $@"{ZeroToNineFullHalfRegex}+|반";
      public const string DozenRegex = @".*타$";
      public const string PercentageRegex = @"(?<=백\s*분\s*의).+|.+(?=퍼\s*센\s*트*)|.*(?=[％%])|.+(?=프\s*로*)";
      public static readonly string DoubleAndRoundRegex = $@"{ZeroToNineFullHalfRegex}+(\.{ZeroToNineFullHalfRegex}+)?{RoundNumberIntegerRegex}{{1,2}}(\s*(이상))?";
      public const string FracSplitRegex = @"(와|과|분\s*의|중)";
      public const string ZeroToNineIntegerRegex = @"(영|령|공|(?<!생|주|\d)(?<=십|백|천|만|억|조|\s*)일|(?<!(율|답|둘))이(?!다)|두|삼|사(?!(랑|주))|(?<!시)오(?!(월|늘))|육|(?<!며)칠|팔|구|한(?=\s*)|하나|둘|세|셋|넷|다섯|여섯|일곱|여덟|아홉)";
      public static readonly string TenToNinetySinoIntegerRegex = $@"({ZeroToNineIntegerRegex})?십";
      public const string TenToNinetyNativeIntegerRegex = @"(스무|열|스물|서른|마흔|쉰|예순|일흔|여든|아흔)";
      public static readonly string ElevenToNineteenSinoIntegerRegex = $@"십({ZeroToNineIntegerRegex})";
      public const string NegativeNumberTermsRegex = @"((마\s*이\s*너\s*스|음\s*수)\s*)";
      public const string NegativeNumberTermsRegexNum = @"((?<!(\d+\s*)|[-－])[-－])";
      public static readonly string NegativeNumberSignRegex = $@"^{NegativeNumberTermsRegex}|^{NegativeNumberTermsRegexNum}";
      public static readonly string SpeGetNumberRegex = $@"{ZeroToNineFullHalfRegex}|{ZeroToNineIntegerRegex}|[십반]";
      public const string PairRegex = @".*[쌍짝]$";
      public const string RoundNumberIntegerRegex = @"(십|백|천|(?<!(큼|\s일|다스|하|하나))만(?![큼|을])|억|조(?!각)(\s번째)?|경|열)";
      public const string AllowListRegex = @"(。|，|、|（|）|“|”|까지|가지|가치|갓|거리|국|[곳|군데]|개|그루|급|기|길|[까풀|꺼풀]|꼭지|닢|다스|대|돈|롤|리|미터|[밀리|미리]|마리|매|모|[면|페이지]|벌|박|배|부|분|살|술|승|쌈|[옴큼|웅큼]|원|일|잎|잔|장|전|점|제곱|주|종|평|평방|척|채|차|첩|켤레|쾌|탕|푼|[연|년]|은|\s|$|/|만)";
      public static readonly string NotSingleRegex = $@"({TenToNinetyNativeIntegerRegex})|((({ZeroToNineIntegerRegex}+|{ZeroToNineFullHalfRegex}+|[십천백셋])\s*(\s*{RoundNumberIntegerRegex}){{1,2}}(와)?|[십천백셋]|{RoundNumberIntegerRegex}\s*((과\s*)?{ZeroToNineIntegerRegex}|{ZeroToNineFullHalfRegex}|영))((\s*({ZeroToNineIntegerRegex}|{ZeroToNineFullHalfRegex})\s*(\s*{RoundNumberIntegerRegex}){{1,2}}(와)?|영)\s*)*(\s*{ZeroToNineIntegerRegex})?)";
      public static readonly string SingleRegex = $@"(?<!((연필)|(예산)|(사람들)|(년)|(명)))((?<!{ZeroToNineIntegerRegex})(영|령|공|(?<!생)일|두|삼|사(?!(랑|주))|(?<![시])오(?!(월|늘))|육|(?<!며)칠|팔|구|세|한(?=(\s*개))|하나|둘|셋|넷|다섯|여섯|일곱|여덟|아홉)(?={AllowListRegex}))";
      public static readonly string NativeSingleRegex = $@"(?<!((연필)|(예산)|(사람들)|(년|명|원)))({TenToNinetyNativeIntegerRegex}\s*{ZeroToNineIntegerRegex})";
      public static readonly string NativeIntRegex = $@"((({ZeroToNineIntegerRegex}\s*)?({RoundNumberIntegerRegex}+\s*)?({TenToNinetyNativeIntegerRegex}\s*)?({ZeroToNineIntegerRegex}))|({TenToNinetyNativeIntegerRegex}))";
      public static readonly string AllIntRegex = $@"(((({ZeroToNineIntegerRegex}|{ZeroToNineFullHalfRegex}|십)\s*(\s*{RoundNumberIntegerRegex}){{1,2}}|[십]|{RoundNumberIntegerRegex}\s*({ZeroToNineIntegerRegex}|{ZeroToNineFullHalfRegex}|영))\s*((({ZeroToNineIntegerRegex}|{ZeroToNineFullHalfRegex})\s*(\s*{RoundNumberIntegerRegex}){{1,2}}|영)\s*)*{ZeroToNineIntegerRegex}?|{ZeroToNineIntegerRegex})|{NativeIntRegex}+)";
      public static readonly string NativeCumKoreanRegex = $@"({ZeroToNineFullHalfRegex}+)\s*(({RoundNumberIntegerRegex}+)({ZeroToNineFullHalfRegex}+))+";
      public static readonly string NumbersWithDozen = $@"(((({ZeroToNineIntegerRegex}|{ZeroToNineFullHalfRegex}|십)\s*(\s*{RoundNumberIntegerRegex}){{1,2}}|[십]|{RoundNumberIntegerRegex}\s*({ZeroToNineIntegerRegex}|{ZeroToNineFullHalfRegex}|영))\s*((({ZeroToNineIntegerRegex}|{ZeroToNineFullHalfRegex})\s*(\s*{RoundNumberIntegerRegex}){{1,2}}|영)\s*)*{ZeroToNineIntegerRegex}?|{ZeroToNineIntegerRegex}))?(다스)(?!{AllIntRegex})";
      public static readonly string NumbersSpecialsChars = $@"((({NegativeNumberTermsRegexNum}|{NegativeNumberTermsRegex})\s*)?({ZeroToNineFullHalfRegex}+))(?=\b|\D)(?!(([\.．]{ZeroToNineFullHalfRegex}+)?(k|mil|t|g|b|km|ml|m|월|미터)))";
      public static readonly string NumbersSpecialsCharsWithSuffix = $@"({NegativeNumberTermsRegexNum}?{ZeroToNineFullHalfRegex}+(\s*{BaseNumbers.NumberMultiplierRegex}+)?)(?=\b|\D)(?!(([\.．]{ZeroToNineFullHalfRegex}+)?(k|mil|t|g|b|km|ml|m|월|미터)))";
      public static readonly string ZeroToNineIntegerSpecialsChars = $@"((({NegativeNumberTermsRegexNum}|{NegativeNumberTermsRegex})\s*){ZeroToNineIntegerRegex}+)";
      public static readonly string DottedNumbersSpecialsChar = $@"({NegativeNumberTermsRegexNum}?{ZeroToNineFullHalfRegex}{{1,3}}(([,，\s]{ZeroToNineFullHalfRegex}{{3}})(?!{ZeroToNineFullHalfRegex}))+)";
      public const string PointRegexStr = @"[점\.．]";
      public static readonly string AllFloatRegex = $@"{NegativeNumberTermsRegex}?{AllIntRegex}\s*{PointRegexStr}\s*[일이삼사오육칠팔구영](\s*{ZeroToNineIntegerRegex})*";
      public static readonly string NumbersWithAllowListRegex = $@"((?<!백\s*분\s*의\s*({AllIntRegex}점*|{AllFloatRegex})*){NegativeNumberTermsRegex}?({RoundNumberIntegerRegex})?({NotSingleRegex}|{SingleRegex})(?!({AllIntRegex}*(점{ZeroToNineIntegerRegex}+)*|{AllFloatRegex})*\s*개\s*백\s*분\s*점))+";
      public static readonly string NumbersAggressiveRegex = $@"(?<!백\s*분\s*의\s*({AllIntRegex}점*|{AllFloatRegex})*){NegativeNumberTermsRegex}?{AllIntRegex}(?!({AllIntRegex}*(점{ZeroToNineIntegerRegex}+)*|{AllFloatRegex})*\s*개\s*백\s*분\s*점)";
      public static readonly string PointRegex = $@"{PointRegexStr}";
      public static readonly string DoubleSpecialsChars = $@"((?<!({ZeroToNineFullHalfRegex}+[\.．]{ZeroToNineFullHalfRegex}*))({NegativeNumberTermsRegexNum}\s*)?{ZeroToNineFullHalfRegex}+[\.．]{ZeroToNineFullHalfRegex}+(?!({ZeroToNineFullHalfRegex}*[\.．]{ZeroToNineFullHalfRegex}+)))(?=\b|\D)(?!(k|mil|t|g|b|km|ml|m))";
      public static readonly string DoubleRoundNumberSpecialsChars = $@"(?<!(({ZeroToNineIntegerRegex}|{RoundNumberIntegerRegex})+[\.．점]({ZeroToNineIntegerRegex}|{RoundNumberIntegerRegex})*))(({NegativeNumberTermsRegexNum}|{NegativeNumberTermsRegex})\s*)?({ZeroToNineIntegerRegex}|{RoundNumberIntegerRegex})+[\.．점]\s?({ZeroToNineIntegerRegex}|{RoundNumberIntegerRegex})+(?!(({ZeroToNineIntegerRegex}|{RoundNumberIntegerRegex})*[\.．점]({ZeroToNineIntegerRegex}|{RoundNumberIntegerRegex})+))";
      public static readonly string DoubleSpecialsCharsWithNegatives = $@"((?<!({ZeroToNineFullHalfRegex}+|\.\.|．．))({NegativeNumberTermsRegexNum}\s*)?[\.．]{ZeroToNineFullHalfRegex}+(?!{ZeroToNineFullHalfRegex}*([\.．]{ZeroToNineFullHalfRegex}+)))(?=\b|\D)(?!(k|mil|t|g|b|km|ml|m))";
      public static readonly string SimpleDoubleSpecialsChars = $@"(({NegativeNumberTermsRegexNum}\s*)?{ZeroToNineFullHalfRegex}{{1,3}}([,，\s]{ZeroToNineFullHalfRegex}{{3}})+[\.．]{ZeroToNineFullHalfRegex}+)";
      public static readonly string DoubleWithMultiplierRegex = $@"(({NegativeNumberTermsRegexNum}\s*)?{ZeroToNineFullHalfRegex}+[\.．]{ZeroToNineFullHalfRegex}+\s*{BaseNumbers.NumberMultiplierRegex})(?=\b|\D)(?!(k|mil|t|g|b|km|ml|m))";
      public static readonly string DoubleWithThousandsRegex = $@"{NegativeNumberTermsRegex}?{ZeroToNineFullHalfRegex}+([\.．]{ZeroToNineFullHalfRegex}+)?\s*?[백천만억]{{1,2}}";
      public static readonly string DoubleAllFloatRegex = $@"(?<!백\s*분\s*의\s*(({AllIntRegex}점*)|{AllFloatRegex})*){AllFloatRegex}(?!{ZeroToNineIntegerRegex}*\s*개\s*백\s*분\s*점)";
      public static readonly string DoubleExponentialNotationRegex = $@"(?<!{ZeroToNineFullHalfRegex}+[\.．])({NegativeNumberTermsRegexNum}\s*)?{ZeroToNineFullHalfRegex}+([\.．]{ZeroToNineFullHalfRegex}+)?e(([-－+＋]*[1-9１２３４５６７８９]{ZeroToNineFullHalfRegex}*)|[0０](?!{ZeroToNineFullHalfRegex}+))";
      public static readonly string DoubleScientificNotationRegex = $@"(?<!{ZeroToNineFullHalfRegex}+[\.．])({NegativeNumberTermsRegexNum}\s*)?({ZeroToNineFullHalfRegex}+([\.．]{ZeroToNineFullHalfRegex}+)?)\^([-－+＋]*[1-9１２３４５６７８９]{ZeroToNineFullHalfRegex}*)";
      public static readonly string OrdinalRegex = $@"((({AllIntRegex}|{RoundNumberIntegerRegex}+)\s*(번째|위))|첫(음|번째)?|처음|일등)|((({ZeroToNineIntegerRegex}|{RoundNumberIntegerRegex})+)(?:일|등|번째))";
      public const string RelativeOrdinalRegex = @"(?<relativeOrdinal>((끝(에서)?\s*((세|두)번째)?(바로)?\s*(전의)?(\s*것)?)|뒤에서 세번째|다음(\s*것)?|이전 것|현재|(((마지막)((에)?\s*((서)?\s*(두번째|((바로)?\s*(것|전)))|의 옆))?)|지금)(의 것)?))";
      public static readonly string OrdinalNumbersRegex = $@"({ZeroToNineFullHalfRegex}+\s*(번째))|({ZeroToNineFullHalfRegex}+(?:일))";
      public static readonly string OrdinalKoreanRegex = $@"({OrdinalRegex}|{RelativeOrdinalRegex}|{OrdinalNumbersRegex})";
      public static readonly string AllFractionNumber = $@"(반)|({NegativeNumberTermsRegex}?((({ZeroToNineFullHalfRegex}+|{AllIntRegex}+|{ZeroToNineIntegerRegex}+|{RoundNumberIntegerRegex}+)\s*(와|과)\s*)+)?{NegativeNumberTermsRegex}?({ZeroToNineFullHalfRegex}+|{AllIntRegex}+|{ZeroToNineIntegerRegex}+|{RoundNumberIntegerRegex}+)\s*(분\s*의|중)\s*{NegativeNumberTermsRegex}?({ZeroToNineFullHalfRegex}+|{AllIntRegex}+|{ZeroToNineIntegerRegex}+|{RoundNumberIntegerRegex}+))";
      public static readonly string FractionNotationSpecialsCharsRegex = $@"(?<!(/|-|\d+))(({NegativeNumberTermsRegexNum}\s*)?{ZeroToNineFullHalfRegex}+\s+{ZeroToNineFullHalfRegex}+[/／]{ZeroToNineFullHalfRegex}+)(?!(/|\d+))";
      public static readonly string FractionNotationRegex = $@"(?<!(/|-|\d+))(({NegativeNumberTermsRegexNum}\s*)?{ZeroToNineFullHalfRegex}+[/／]{ZeroToNineFullHalfRegex}+)(?!(/|\d+))";
      public static readonly string PercentagePointRegex = $@"(?<!{AllIntRegex})({AllFloatRegex}|{AllIntRegex})\s*개\s*백\s*분\s*점";
      public static readonly string SimplePercentageRegex = $@"(?<!{ZeroToNineIntegerRegex})백\s*분\s*의\s*({AllFloatRegex}|{AllIntRegex}|백)(?!{AllIntRegex})";
      public static readonly string NumbersPercentagePointRegex = $@"(?<!{ZeroToNineIntegerRegex})백\s*분\s*의\s*{ZeroToNineFullHalfRegex}+[\.．]{ZeroToNineFullHalfRegex}+(?!([\.．]{ZeroToNineFullHalfRegex}+))";
      public static readonly string NumbersPercentageWithSeparatorRegex = $@"(?<!{ZeroToNineIntegerRegex})백\s*분\s*의\s*{ZeroToNineFullHalfRegex}{{1,3}}([,，]{ZeroToNineFullHalfRegex}{{3}})+[\.．]{ZeroToNineFullHalfRegex}+";
      public static readonly string NumbersPercentageWithMultiplierRegex = $@"(?<!{ZeroToNineIntegerRegex})백\s*분\s*의\s*{ZeroToNineFullHalfRegex}+[\.．]{ZeroToNineFullHalfRegex}+\s*{BaseNumbers.NumberMultiplierRegex}";
      public static readonly string FractionPercentagePointRegex = $@"(?<!({ZeroToNineFullHalfRegex}+[\.．])){ZeroToNineFullHalfRegex}+[\.．]{ZeroToNineFullHalfRegex}+(?!([\.．]{ZeroToNineFullHalfRegex}+))\s*개\s*백\s*분\s*점";
      public static readonly string FractionPercentageWithSeparatorRegex = $@"{ZeroToNineFullHalfRegex}{{1,3}}([,，]{ZeroToNineFullHalfRegex}{{3}})+[\.．]{ZeroToNineFullHalfRegex}+\s*개\s*백\s*분\s*점";
      public static readonly string FractionPercentageWithMultiplierRegex = $@"{ZeroToNineFullHalfRegex}+[\.．]{ZeroToNineFullHalfRegex}+\s*{BaseNumbers.NumberMultiplierRegex}\s*개\s*백\s*분\s*점";
      public static readonly string SimpleNumbersPercentageRegex = $@"(?<!{ZeroToNineIntegerRegex})백\s*분\s*의\s*{ZeroToNineFullHalfRegex}+(?!([\.．]{ZeroToNineFullHalfRegex}+))";
      public static readonly string SimpleNumbersPercentageWithMultiplierRegex = $@"(?<!{ZeroToNineIntegerRegex})백\s*분\s*의\s*{ZeroToNineFullHalfRegex}+\s*{BaseNumbers.NumberMultiplierRegex}";
      public static readonly string SimpleNumbersPercentagePointRegex = $@"(?!{ZeroToNineIntegerRegex})백\s*분\s*의\s*{ZeroToNineFullHalfRegex}{{1,3}}([,，]{ZeroToNineFullHalfRegex}{{3}})+";
      public static readonly string IntegerPercentageRegex = $@"{ZeroToNineFullHalfRegex}+\s*개\s*백\s*분\s*점";
      public static readonly string IntegerPercentageWithMultiplierRegex = $@"{ZeroToNineFullHalfRegex}+\s*{BaseNumbers.NumberMultiplierRegex}\s*개\s*백\s*분\s*점";
      public static readonly string NumbersFractionPercentageRegex = $@"{ZeroToNineFullHalfRegex}{{1,3}}([,，]{ZeroToNineFullHalfRegex}{{3}})+\s*개\s*백\s*분\s*점";
      public static readonly string SimpleIntegerPercentageRegex = $@"(?<!%|\d)({NegativeNumberTermsRegexNum}|{NegativeNumberTermsRegex})?({AllIntRegex}|{ZeroToNineFullHalfRegex}|{RoundNumberIntegerRegex})+([\.．]{ZeroToNineFullHalfRegex}+)?(\s*)([％%]|(퍼\s*센\s*트)|(프\s*로)|(퍼\s*센\s*티\s*지))(?!\d)";
      public const string TillRegex = @"(부터|에서|--|-|—|–|——|~)";
      public const string MoreRegex = @"(초과|많|높|더많|더높|더크|>|넘는|초과이다|크고|(을 초과하는)|크)";
      public const string LessRegex = @"(미만|적|낮|작|더적|더낮|더적|이하|이하이다|<|아래|작다)";
      public const string EqualRegex = @"(동일|같|=|(해당하는)|는|그와 같다)";
      public const string RangePrefixLessRegex = @"(까지최소|(?<!>|=)<|≤)";
      public const string RangePrefixMoreRegex = @"((?<!<|=)>|≥)";
      public static readonly string MoreOrEqual = $@"(({MoreRegex}\s*(거나)?\s*{EqualRegex}))";
      public static readonly string MoreOrEqual2 = $@"(\s*(거나)?\s*(그보다)\s*{MoreRegex})";
      public const string MoreOrEqualSuffix = @"\s*(이상)";
      public static readonly string LessOrEqual = $@"(?:(이|보다)?)?\s*(({LessRegex}\s*(거나)?\s*{EqualRegex}(은|다)?))";
      public const string LessOrEqualSuffix = @"\s*(이하|(달하는))";
      public const string OneNumberRangeMoreSeparateRegex = @"^[.]";
      public const string OneNumberRangeLessSeparateRegex = @"^[.]";
      public static readonly string OneNumberRangeEqualRegex = $@"((?<number1>((?!((\s(?!\d+))|(,(?!\d+))|。)).)+)\s*(과|에)+\s*{EqualRegex})(거나|다|개)?(\s*({LessRegex})(은)?)?|((?<number1>((?!((\s(?!\d+))|(,(?!\d+))|。)).)+)\s*(년에)\s*(\d+)(은|이다))";
      public static readonly string OneNumberRangeEqualRegex2 = $@"((?<number1>(((?!((\s(?!\d+))|(,(?!\d+))|。)))(?<=((는\s+))))([\d]|{AllIntRegex})+)(이다))";
      public static readonly string OneNumberRangeMoreRegex1 = $@"((?<number1>((?!(((?!\d+))|((,)(?!\d+))|。)).)+)\s*(이|보다|거나|또는)+\s*(그|그보다)?\s*({MoreOrEqual}|{MoreRegex}|{MoreOrEqualSuffix})(은|다)?)";
      public static readonly string OneNumberRangeMoreRegex2 = $@"(?<number1>(((?!(((?!([십백천만억조경열]|(영|령|공|일|이(?!다)|두|삼|사|오|육|(?<!며)칠|팔|구))+))))|(사분의\s)).)+)(보다)?\s({MoreRegex})|(?<number1>((?!((、(?!\d+))|(、(?!\d+))|。))|(?!\s+).)+)\s*(((혹은\s*그)?){MoreRegex}|((혹은\s*그)?){MoreOrEqualSuffix})";
      public static readonly string OneNumberRangeMoreRegex3 = $@"({RangePrefixMoreRegex})\s*(?<number1>(((?!(((?!\d+))|((,)(?!\d+))|。)).)+))";
      public static readonly string OneNumberRangeMoreRegex4 = $@"((?<number1>((?!((\s(?!\d+))|(,(?!\d+))|。)).)+)\s*(과|에)+\s*{EqualRegex}){MoreOrEqual2}(다)?";
      public static readonly string OneNumberRangeMoreRegex5 = $@"(?<number1>((?![,.](?!\d+)).)+)\s*((또는)\s+(그){MoreOrEqualSuffix})";
      public static readonly string OneNumberRangeMoreRegexFraction = $@"((?<number1>(((\d+)[/／]).)+)(이)\s*{MoreRegex})";
      public static readonly string OneNumberRangeLessRegex1 = $@"((?<number2>((?!(((?!\d+))|((,)(?!\d+))|。)).)+)\s*({LessOrEqual}|{LessRegex}))|((?<number2>((?!(((?!\d+))|((,)(?!\d+))|。)).)+)\s*(이|보다|거나|또는)+\s*(그|그보다)?\s*{LessRegex}(은|다)?)|{OneNumberRangeLessRegex5}";
      public static readonly string OneNumberRangeLessRegex2 = $@"((?<number2>((?!((\s(?!\d+))|(,(?!\d+))|。)).)+)\s*(과|에|이)+\s*{EqualRegex}?)(거나)\s*(최소)\s*(\d+)";
      public static readonly string OneNumberRangeLessRegex3 = $@"(?:({RangePrefixLessRegex}))\s*(?<number2>(((?!((\s(?!\d+))|((,)(?!\d+))|。)).)+))";
      public static readonly string OneNumberRangeLessRegex4 = $@"(?<number2>(((?!((\s(?!\d+))|((,)(?!\d+))|。)).)+))\s*(에)(?:({LessOrEqualSuffix}))";
      public const string OneNumberRangeLessRegex5 = @"((?<number2>((이분의\s)|[영령공일이두삼사오육칠팔구]+|[십백천만억조경열]+)+)\s*(또는)?\s*(그|그보다|보다)?\s*(미만|적게|밑|이하|작다))";
      public static readonly string TwoNumberRangeRegex1 = $@"(?<number1>((?!((，(?!\d+))|(,(?!\d+))|。)).)+)(위?)\s*(과|와|{TillRegex})\s*(?<number2>((?!((，(?!\d+))|(,(?!\d+))|。)).)+)(위?)\s*(사이)";
      public static readonly string TwoNumberRangeRegex2 = $@"(({OneNumberRangeMoreRegex1}|{OneNumberRangeMoreRegex2})\s*(과|또는|，|、|,)?\s*({OneNumberRangeLessRegex1}))|({OneNumberRangeLessRegex1}|{OneNumberRangeMoreRegex2})";
      public static readonly string TwoNumberRangeRegex3 = $@"({OneNumberRangeLessRegex1})\s*(과|또는|，|、|,)?\s*({OneNumberRangeMoreRegex1}|{OneNumberRangeMoreRegex2})";
      public static readonly string TwoNumberRangeRegex4 = $@"(?<number1>((?!((，(?!\d+))|(,(?!\d+))|。)).)+)\s*{TillRegex}\s*(?<number2>((?!((，(?!\d+))|(,(?!\d+))|。)).)+)(까지)?";
      public static readonly string TwoNumberRangeRegex5 = $@"(?<number1>([십백천만억조경열]|(영|령|공|일|이(?!다)|두|삼|사|오|육|(?<!며)칠|팔|구))+)\s*{TillRegex}\s*(?<number2>([십백천만억조경열]|(영|령|공|일|이(?!다)|두|삼|사|오|육|칠|팔|구))+)\s*([십백천만억조경열]|((미만|적|낮|작|더적|더낮|더적|이하이다|까지|아래))+)";
      public static readonly string TwoNumberRangeRegex6 = $@"((?<number1>((?!((，(?!\d+))|(,(?!\d+))|。|\D)).)+)\s*{TillRegex}+\s*(?<number2>((?!((，(?!\d+))|(,(?!\d+))|。)).)+)\s*(까지))";
      public static readonly string TwoNumberRangeRegex7 = $@"({OneNumberRangeMoreRegex2}\s*{OneNumberRangeLessRegex5})";
      public const string InexactNumberUnitRegex = @"(몇(?!.+\?)|며|여러)";
      public static readonly Dictionary<string, string> RelativeReferenceOffsetMap = new Dictionary<string, string>
        {
            { @"마지막", @"0" },
            { @"다음", @"1" },
            { @"뒤에서 세번째", @"-2" },
            { @"마지막에서 두번째", @"-1" },
            { @"마지막의 옆", @"-1" },
            { @"마지막에서 바로 전의 것", @"-1" },
            { @"이전 것", @"-1" },
            { @"다음 것", @"1" },
            { @"마지막에서 바로 전", @"-1" },
            { @"지금의 것", @"0" },
            { @"현재", @"0" },
            { @"끝", @"0" },
            { @"끝에서 세번째", @"-2" },
            { @"끝에서 두번째", @"-1" },
            { @"끝에서 바로 전의 것", @"-1" }
        };
      public static readonly Dictionary<string, string> RelativeReferenceRelativeToMap = new Dictionary<string, string>
        {
            { @"마지막", @"end" },
            { @"다음", @"current" },
            { @"뒤에서 세번째", @"end" },
            { @"마지막에서 두번째", @"end" },
            { @"마지막의 옆", @"end" },
            { @"마지막에서 바로 전의 것", @"end" },
            { @"이전 것", @"current" },
            { @"다음 것", @"current" },
            { @"마지막에서 바로 전", @"end" },
            { @"지금의 것", @"current" },
            { @"현재", @"current" },
            { @"끝", @"end" },
            { @"끝에서 세번째", @"end" },
            { @"끝에서 두번째", @"end" },
            { @"끝에서 바로 전의 것", @"end" }
        };
    }
}