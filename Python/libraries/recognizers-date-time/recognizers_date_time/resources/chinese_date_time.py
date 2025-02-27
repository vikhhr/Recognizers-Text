# ------------------------------------------------------------------------------
# <auto-generated>
#     This code was generated by a tool.
#     Changes to this file may cause incorrect behavior and will be lost if
#     the code is regenerated.
# </auto-generated>
#
# Copyright (c) Microsoft Corporation. All rights reserved.
# Licensed under the MIT License.
# ------------------------------------------------------------------------------

from .base_date_time import BaseDateTime
# pylint: disable=line-too-long


class ChineseDateTime:
    LangMarker = 'Chi'
    MonthRegex = f'(?<month>正月|一月|二月|三月|四月|五月|六月|七月|八月|九月|十月|十一月|十二月|01月|02月|03月|04月|05月|06月|07月|08月|09月|10月|11月|12月|1月|2月|3月|4月|5月|6月|7月|8月|9月|大年(?!龄|纪|级))'
    DayRegex = f'(?<day>01|02|03|04|05|06|07|08|09|10|11|12|13|14|15|16|17|18|19|20|21|22|23|24|25|26|27|28|29|30|31|1|2|3|4|5|6|7|8|9)'
    OneToNineIntegerRegex = f'[一二三四五六七八九壹贰叁肆伍陆柒捌玖]'
    DateDayRegexInCJK = f'(?<day>(([12][0-9]|3[01]|[1-9]|[三叁][十拾][一壹]?|[二贰貳]?[十拾]({OneToNineIntegerRegex})?|{OneToNineIntegerRegex})[日号]|初一|三十))'
    DayRegexNumInCJK = f'(?<day>[12][0-9]|3[01]|[1-9]|[三叁][十拾][一壹]?|[二贰貳]?[十拾]({OneToNineIntegerRegex})?|{OneToNineIntegerRegex}|廿|卅)'
    MonthNumRegex = f'(?<month>01|02|03|04|05|06|07|08|09|10|11|12|1|2|3|4|5|6|7|8|9)'
    TwoNumYear = '50'
    YearNumRegex = f'(?<year>((1[5-9]|20)\\d{{2}})|2100)'
    SimpleYearRegex = f'(?<year>(\\d{{2,4}}))'
    ZeroToNineIntegerRegexCJK = f'[一二三四五六七八九零壹贰叁肆伍陆柒捌玖〇两千俩倆仨]'
    DynastyStartYear = '元'
    RegionTitleRegex = f'(贞观|开元|神龙|洪武|建文|永乐|景泰|天顺|成化|嘉靖|万历|崇祯|顺治|康熙|雍正|乾隆|嘉庆|道光|咸丰|同治|光绪|宣统|民国)'
    DynastyYearRegex = f'(?<dynasty>{RegionTitleRegex})(?<biasYear>({DynastyStartYear}|\\d{{1,3}}|[十拾]?({ZeroToNineIntegerRegexCJK}[十百拾佰]?){{0,3}}))'
    DateYearInCJKRegex = f'(?<yearCJK>({ZeroToNineIntegerRegexCJK}{ZeroToNineIntegerRegexCJK}{ZeroToNineIntegerRegexCJK}{ZeroToNineIntegerRegexCJK}|{ZeroToNineIntegerRegexCJK}{ZeroToNineIntegerRegexCJK}|{ZeroToNineIntegerRegexCJK}{ZeroToNineIntegerRegexCJK}{ZeroToNineIntegerRegexCJK}|{DynastyYearRegex}))'
    WeekDayRegex = f'(?<weekday>周日|周天|周一|周二|周三|周四|周五|周六|星期一|星期二|星期三|星期四|星期五|星期六|星期日|星期天|礼拜一|礼拜二|礼拜三|礼拜四|礼拜五|礼拜六|礼拜日|礼拜天|禮拜一|禮拜二|禮拜三|禮拜四|禮拜五|禮拜六|禮拜日|禮拜天|週日|週天|週一|週二|週三|週四|週五|週六)'
    WeekDayStartEnd = f'^[.]'
    LunarRegex = f'(农历|初一|正月|大年(?!龄|纪|级))'
    DateThisRegex = f'(这个|这一个|这|这一|本){WeekDayRegex}'
    DateLastRegex = f'(上一个|上个|上一|上|最后一个|最后)(的)?{WeekDayRegex}'
    DateNextRegex = f'(下一个|下个|下一|下)(的)?{WeekDayRegex}'
    WoMLastRegex = f'最后一'
    WoMPreviousRegex = f'上个'
    WoMNextRegex = f'下个'
    SpecialMonthRegex = f'^[.]'
    SpecialYearRegex = f'^[.]'
    SpecialDayRegex = f'(最近|前天|后天|昨天|明天|今天|今日|明日|昨日|大后天|大前天|後天|大後天)'
    SpecialDayWithNumRegex = f'^[.]'
    WeekDayOfMonthRegex = f'((({MonthRegex}|{MonthNumRegex})的\\s*)(?<cardinal>第一个|第二个|第三个|第四个|第五个|最后一个)\\s*{WeekDayRegex})'
    WeekDayAndDayRegex = f'^[.]'
    ThisPrefixRegex = f'这个|这一个|这|这一|本|今'
    LastPrefixRegex = f'上个|上一个|上|上一|去'
    NextPrefixRegex = f'下个|下一个|下|下一|明'
    RelativeRegex = f'(?<order>({ThisPrefixRegex}|{LastPrefixRegex}|{NextPrefixRegex}))'
    SpecialDate = f'(?<thisyear>({ThisPrefixRegex}|{LastPrefixRegex}|{NextPrefixRegex})年)?(?<thismonth>({ThisPrefixRegex}|{LastPrefixRegex}|{NextPrefixRegex})月)?{DateDayRegexInCJK}'
    DateUnitRegex = f'(?<unit>年|个月|周|週|日|天)'
    BeforeRegex = f'以前|之前|前'
    AfterRegex = f'以后|以後|之后|之後|后|後'
    DateRegexList1 = f'({LunarRegex}(\\s*))?((({SimpleYearRegex}|{DateYearInCJKRegex})年)(\\s*))?{MonthRegex}(\\s*){DateDayRegexInCJK}((\\s*|,|，){WeekDayRegex})?'
    DateRegexList2 = f'((({SimpleYearRegex}|{DateYearInCJKRegex})年)(\\s*))?({LunarRegex}(\\s*))?{MonthRegex}(\\s*){DateDayRegexInCJK}((\\s*|,|，){WeekDayRegex})?'
    DateRegexList3 = f'((({SimpleYearRegex}|{DateYearInCJKRegex})年)(\\s*))?({LunarRegex}(\\s*))?{MonthRegex}(\\s*)({DayRegexNumInCJK}|{DayRegex})((\\s*|,|，){WeekDayRegex})?'
    DateRegexList4 = f'{MonthNumRegex}\\s*/\\s*{DayRegex}'
    DateRegexList5 = f'{DayRegex}\\s*/\\s*{MonthNumRegex}'
    DateRegexList6 = f'{MonthNumRegex}\\s*[/\\\\\\-]\\s*{DayRegex}\\s*[/\\\\\\-]\\s*{SimpleYearRegex}'
    DateRegexList7 = f'{DayRegex}\\s*[/\\\\\\-\\.]\\s*{MonthNumRegex}\\s*[/\\\\\\-\\.]\\s*{SimpleYearRegex}'
    DateRegexList8 = f'{SimpleYearRegex}\\s*[/\\\\\\-\\. ]\\s*{MonthNumRegex}\\s*[/\\\\\\-\\. ]\\s*{DayRegex}'
    DatePeriodTillRegex = f'(?<till>到|至|--|-|—|——|~|–)'
    DatePeriodRangeSuffixRegex = f'^\\b$'
    DatePeriodRangePrefixRegex = f'从'
    DatePeriodTillSuffixRequiredRegex = f'(?<till>与|和)'
    DatePeriodDayRegexInCJK = f'(?<day>初一|三十|一日|十一日|二十一日|三十一日|二日|三日|四日|五日|六日|七日|八日|九日|十二日|十三日|十四日|十五日|十六日|十七日|十八日|十九日|二十二日|二十三日|二十四日|二十五日|二十六日|二十七日|二十八日|二十九日|一日|十一日|十日|二十一日|二十日|三十一日|三十日|二日|三日|四日|五日|六日|七日|八日|九日|十二日|十三日|十四日|十五日|十六日|十七日|十八日|十九日|二十二日|二十三日|二十四日|二十五日|二十六日|二十七日|二十八日|二十九日|十日|二十日|三十日|10日|11日|12日|13日|14日|15日|16日|17日|18日|19日|1日|20日|21日|22日|23日|24日|25日|26日|27日|28日|29日|2日|30日|31日|3日|4日|5日|6日|7日|8日|9日|一号|十一号|二十一号|三十一号|二号|三号|四号|五号|六号|七号|八号|九号|十二号|十三号|十四号|十五号|十六号|十七号|十八号|十九号|二十二号|二十三号|二十四号|二十五号|二十六号|二十七号|二十八号|二十九号|一号|十一号|十号|二十一号|二十号|三十一号|三十号|二号|三号|四号|五号|六号|七号|八号|九号|十二号|十三号|十四号|十五号|十六号|十七号|十八号|十九号|二十二号|二十三号|二十四号|二十五号|二十六号|二十七号|二十八号|二十九号|十号|二十号|三十号|10号|11号|12号|13号|14号|15号|16号|17号|18号|19号|1号|20号|21号|22号|23号|24号|25号|26号|27号|28号|29号|2号|30号|31号|3号|4号|5号|6号|7号|8号|9号|一|十一|二十一|三十一|二|三|四|五|六|七|八|九|十二|十三|十四|十五|十六|十七|十八|十九|二十二|二十三|二十四|二十五|二十六|二十七|二十八|二十九|一|十一|十|二十一|二十|三十一|三十|二|三|四|五|六|七|八|九|十二|十三|十四|十五|十六|十七|十八|十九|二十二|二十三|二十四|二十五|二十六|二十七|二十八|二十九|十|二十|三十|廿|卅)'
    DatePeriodThisRegex = f'这个|这一个|这|这一|本'
    DatePeriodLastRegex = f'上个|上一个|上|上一'
    DatePeriodNextRegex = f'下个|下一个|下|下一'
    RelativeMonthRegex = f'(?<relmonth>({DatePeriodThisRegex}|{DatePeriodLastRegex}|{DatePeriodNextRegex})\\s*月)'
    HalfYearRegex = f'((?<firstHalf>(上|前)半年)|(?<secondHalf>(下|后)半年))'
    YearRegex = f'(({YearNumRegex})(\\s*年)?|({SimpleYearRegex})\\s*年){HalfYearRegex}?'
    StrictYearRegex = f'({YearRegex}(?=[\\u4E00-\\u9FFF]|\\s|$|\\W))'
    YearRegexInNumber = f'(?<year>(\\d{{4}}))'
    DatePeriodYearInCJKRegex = f'{DateYearInCJKRegex}年{HalfYearRegex}?'
    MonthSuffixRegex = f'(?<msuf>({RelativeMonthRegex}|{MonthRegex}))'
    SimpleCasesRegex = f'((从)\\s*)?(({YearRegex}|{DatePeriodYearInCJKRegex})\\s*)?{MonthSuffixRegex}({DatePeriodDayRegexInCJK}|{DayRegex})\\s*{DatePeriodTillRegex}\\s*({DatePeriodDayRegexInCJK}|{DayRegex})((\\s+|\\s*,\\s*){YearRegex})?'
    YearAndMonth = f'({DatePeriodYearInCJKRegex}|{YearRegex}|(?<yearrel>明年|今年|去年))\\s*({MonthRegex}|的?(?<cardinal>第一|第二|第三|第四|第五|第六|第七|第八|第九|第十|第十一|第十二|最后一)\\s*个月\\s*)'
    SimpleYearAndMonth = f'({YearNumRegex}[/\\\\\\-]{MonthNumRegex}\\b$)'
    PureNumYearAndMonth = f'({YearRegexInNumber}\\s*[-\\.\\/]\\s*{MonthNumRegex})|({MonthNumRegex}\\s*\\/\\s*{YearRegexInNumber})'
    OneWordPeriodRegex = f'(((?<yearrel>(明|今|去)年)\\s*)?{MonthRegex}|({DatePeriodThisRegex}|{DatePeriodLastRegex}|{DatePeriodNextRegex})(?<halfTag>半)?\\s*(周末|周|月|年)|周末|(今|明|去|前|后)年(\\s*{HalfYearRegex})?)'
    WeekOfMonthRegex = f'(?<wom>{MonthSuffixRegex}的(?<cardinal>第一|第二|第三|第四|第五|最后一)\\s*周\\s*)'
    WeekOfYearRegex = f'(?<woy>({YearRegex}|{RelativeRegex}年)的(?<cardinal>第一|第二|第三|第四|第五|最后一)\\s*周\\s*)'
    UnitRegex = f'(?<unit>年|(?<uoy>(个)?月|周|週|日|天))'
    FollowedUnit = f'^\\s*{UnitRegex}'
    NumberCombinedWithUnit = f'(?<num>\\d+(\\.\\d*)?){UnitRegex}'
    DateRangePrepositions = f'((从|在|自)\\s*)?'
    YearToYear = f'({DateRangePrepositions})({DatePeriodYearInCJKRegex}|{YearRegex})\\s*({DatePeriodTillRegex}|后|後|之后|之後)\\s*({DatePeriodYearInCJKRegex}|{YearRegex})(\\s*((之间|之内|期间|中间|间)|前|之前))?'
    YearToYearSuffixRequired = f'({DateRangePrepositions})({DatePeriodYearInCJKRegex}|{YearRegex})\\s*({DatePeriodTillSuffixRequiredRegex})\\s*({DatePeriodYearInCJKRegex}|{YearRegex})\\s*(之间|之内|期间|中间|间)'
    MonthToMonth = f'({DateRangePrepositions})({MonthRegex}){DatePeriodTillRegex}({MonthRegex})'
    MonthToMonthSuffixRequired = f'({DateRangePrepositions})({MonthRegex}){DatePeriodTillSuffixRequiredRegex}({MonthRegex})\\s*(之间|之内|期间|中间|间)'
    DayToDay = f'^[.]'
    DayRegexForPeriod = f'^[.]'
    FirstLastOfYearRegex = f'(({DatePeriodYearInCJKRegex}|{YearRegex}|(?<yearrel>明年|今年|去年))的?)((?<first>前)|(?<last>(最后|最後)))'
    PastRegex = f'(?<past>(之前|前|上|近|过去))'
    FutureRegex = f'(?<future>(之后|之後|后|後|(?<![一两几]\\s*)下|未来(的)?))'
    SeasonRegex = f'(?<season>春|夏|秋|冬)(天|季)?'
    SeasonWithYear = f'(({YearRegex}|{DatePeriodYearInCJKRegex}|(?<yearrel>明年|今年|去年))(的)?)?{SeasonRegex}'
    QuarterRegex = f'(({YearRegex}|{DatePeriodYearInCJKRegex}|(?<yearrel>明年|今年|去年))(的)?)?(第(?<cardinal>1|2|3|4|一|二|三|四)季度)'
    CenturyRegex = f'(?<century>\\d|1\\d|2\\d)世纪'
    CenturyRegexInCJK = f'(?<century>一|二|三|四|五|六|七|八|九|十|十一|十二|十三|十四|十五|十六|十七|十八|十九|二十|二十一|二十二)世纪'
    RelativeCenturyRegex = f'(?<relcentury>({DatePeriodLastRegex}|{DatePeriodThisRegex}|{DatePeriodNextRegex}))世纪'
    DecadeRegexInCJK = f'(?<decade>十|一十|二十|三十|四十|五十|六十|七十|八十|九十)'
    DecadeRegex = f'(?<centurysuf>({CenturyRegex}|{CenturyRegexInCJK}|{RelativeCenturyRegex}))?(?<decade>(\\d0|{DecadeRegexInCJK}))年代'
    PrepositionRegex = f'(?<prep>^的|在$)'
    NowRegex = f'(?<now>现在|马上|立刻|刚刚才|刚刚|刚才|这会儿|当下|此刻)'
    NightRegex = f'(?<night>早|晚)'
    TimeOfTodayRegex = f'(今晚|今早|今晨|明晚|明早|明晨|昨晚)(的|在)?'
    DateTimePeriodTillRegex = f'(?<till>到|直到|--|-|—|——)'
    DateTimePeriodPrepositionRegex = f'(?<prep>^\\s*的|在\\s*$)'
    HourRegex = f'\\b{BaseDateTime.HourRegex}'
    HourNumRegex = f'(?<hour>[零〇一二两三四五六七八九]|二十[一二三四]?|十[一二三四五六七八九]?)'
    ZhijianRegex = f'^\\s*(之间|之内|期间|中间|间)'
    DateTimePeriodThisRegex = f'这个|这一个|这|这一'
    DateTimePeriodLastRegex = f'上个|上一个|上|上一'
    DateTimePeriodNextRegex = f'下个|下一个|下|下一'
    AmPmDescRegex = f'(?<daydesc>(am|a\\.m\\.|a m|a\\. m\\.|a\\.m|a\\. m|a m|pm|p\\.m\\.|p m|p\\. m\\.|p\\.m|p\\. m|p m))'
    TimeOfDayRegex = f'(?<timeOfDay>凌晨|清晨|早上|早间|早|上午|中午|下午|午后|晚上|夜里|夜晚|半夜|夜间|深夜|傍晚|晚)'
    SpecificTimeOfDayRegex = f'((({DateTimePeriodThisRegex}|{DateTimePeriodNextRegex}|{DateTimePeriodLastRegex})\\s+{TimeOfDayRegex})|(今晚|今早|今晨|明晚|明早|明晨|昨晚))'
    DateTimePeriodUnitRegex = f'(个)?(?<unit>(小时|钟头|分钟|秒钟|时|分|秒))'
    DateTimePeriodFollowedUnit = f'^\\s*{DateTimePeriodUnitRegex}'
    DateTimePeriodNumberCombinedWithUnit = f'\\b(?<num>\\d+(\\.\\d*)?){DateTimePeriodUnitRegex}'
    DurationAllRegex = f'^[.]'
    DurationHalfRegex = f'^[.]'
    DurationRelativeDurationUnitRegex = f'^[.]'
    DurationDuringRegex = f'^[.]'
    DurationSomeRegex = f'^[.]'
    DurationMoreOrLessRegex = f'^[.]'
    DurationYearRegex = f'((\\d{{3,4}})|0\\d|两千)\\s*年'
    DurationHalfSuffixRegex = f'半'
    DurationSuffixList = dict([("M", "分钟"),
                               ("S", "秒钟|秒"),
                               ("H", "个小时|小时|个钟头|钟头|时"),
                               ("D", "天"),
                               ("W", "星期|个星期|周|週"),
                               ("Mon", "个月"),
                               ("Y", "年")])
    DurationAmbiguousUnits = [r'分钟', r'秒钟', r'秒', r'个小时', r'小时', r'天', r'星期', r'个星期', r'周', r'週', r'个月', r'年', r'时']
    DurationUnitRegex = f'(?<unit>{DateUnitRegex}|分钟?|秒钟?|个?小时|时|个?钟头|天|个?星期|周|週|个?月|年)'
    DurationConnectorRegex = f'^\\s*(?<connector>[多又余零]?)\\s*$'
    LunarHolidayRegex = f'(({YearRegex}|{DatePeriodYearInCJKRegex}|(?<yearrel>明年|今年|去年))(的)?)?(?<holiday>除夕|春节|中秋节|中秋|元宵节|端午节|端午|重阳节)'
    HolidayRegexList1 = f'(({YearRegex}|{DatePeriodYearInCJKRegex}|(?<yearrel>明年|今年|去年))(的)?)?(?<holiday>新年|五一|劳动节|元旦节|元旦|愚人节|平安夜|圣诞节|植树节|国庆节|情人节|教师节|儿童节|妇女节|青年节|建军节|女生节|光棍节|双十一|清明节|清明)'
    HolidayRegexList2 = f'(({YearRegex}|{DatePeriodYearInCJKRegex}|(?<yearrel>明年|今年|去年))(的)?)?(?<holiday>母亲节|父亲节|感恩节|万圣节)'
    SetUnitRegex = f'(?<unit>年|月|周|星期|日|天|小时|时|分钟|分|秒钟|秒)'
    SetEachUnitRegex = f'(?<each>(每个|每一|每)\\s*{SetUnitRegex})'
    SetEachPrefixRegex = f'(?<each>(每)\\s*$)'
    SetLastRegex = f'(?<last>last|this|next)'
    SetEachDayRegex = f'(每|每一)(天|日)\\s*$'
    TimeHourNumRegex = f'(00|01|02|03|04|05|06|07|08|09|0|10|11|12|13|14|15|16|17|18|19|20|21|22|23|24|1|2|3|4|5|6|7|8|9)'
    TimeMinuteNumRegex = f'(00|01|02|03|04|05|06|07|08|09|10|11|12|13|14|15|16|17|18|19|20|21|22|23|24|25|26|27|28|29|30|31|32|33|34|35|36|37|38|39|40|41|42|43|44|45|46|47|48|49|50|51|52|53|54|55|56|57|58|59|0|1|2|3|4|5|6|7|8|9)'
    TimeSecondNumRegex = f'(00|01|02|03|04|05|06|07|08|09|10|11|12|13|14|15|16|17|18|19|20|21|22|23|24|25|26|27|28|29|30|31|32|33|34|35|36|37|38|39|40|41|42|43|44|45|46|47|48|49|50|51|52|53|54|55|56|57|58|59|0|1|2|3|4|5|6|7|8|9)'
    TimeHourCJKRegex = f'([零〇一二两三四五六七八九]|二十[一二三四]?|十[一二三四五六七八九]?)'
    TimeMinuteCJKRegex = f'([二三四五]?十[一二三四五六七八九]?|六十|[零〇一二三四五六七八九])'
    TimeSecondCJKRegex = f'{TimeMinuteCJKRegex}'
    TimeClockDescRegex = f'(点\\s*整|点\\s*钟|点|时)'
    TimeMinuteDescRegex = f'(分钟|分|)'
    TimeSecondDescRegex = f'(秒钟|秒)'
    TimeBanHourPrefixRegex = f'(第)'
    TimeHourRegex = f'(?<!{TimeBanHourPrefixRegex})(?<hour>{TimeHourCJKRegex}|{TimeHourNumRegex}){TimeClockDescRegex}'
    TimeMinuteRegex = f'(?<min>{TimeMinuteCJKRegex}|{TimeMinuteNumRegex}){TimeMinuteDescRegex}'
    TimeSecondRegex = f'(?<sec>{TimeSecondCJKRegex}|{TimeSecondNumRegex}){TimeSecondDescRegex}'
    TimeHalfRegex = f'(?<half>过半|半)'
    TimeQuarterRegex = f'(?<quarter>[一两二三四1-4])\\s*(刻钟|刻)'
    TimeCJKTimeRegex = f'{TimeHourRegex}({TimeQuarterRegex}|{TimeHalfRegex}|((过|又)?{TimeMinuteRegex})({TimeSecondRegex})?)?'
    TimeDigitTimeRegex = f'(?<hour>{TimeHourNumRegex}):(?<min>{TimeMinuteNumRegex})(:(?<sec>{TimeSecondNumRegex}))?'
    TimeDayDescRegex = f'(?<daydesc>凌晨|清晨|早上|早间|早|上午|中午|下午|午后|晚上|夜里|夜晚|半夜|午夜|夜间|深夜|傍晚|晚)'
    TimeApproximateDescPreffixRegex = f'(大[约概]|差不多|可能|也许|约|不超过|不多[于过]|最[多长少]|少于|[超短长多]过|几乎要|将近|差点|快要|接近|至少|起码|超出|不到)'
    TimeApproximateDescSuffixRegex = f'(左右)'
    TimeRegexes1 = f'{TimeApproximateDescPreffixRegex}?{TimeDayDescRegex}?{TimeCJKTimeRegex}{TimeApproximateDescSuffixRegex}?'
    TimeRegexes2 = f'{TimeApproximateDescPreffixRegex}?{TimeDayDescRegex}?{TimeDigitTimeRegex}{TimeApproximateDescSuffixRegex}?(\\s*{AmPmDescRegex}?)'
    TimeRegexes3 = f'差{TimeMinuteRegex}{TimeCJKTimeRegex}'
    TimePeriodTimePeriodConnectWords = f'(起|至|到|–|-|—|~|～)'
    TimePeriodLeftCJKTimeRegex = f'(从)?(?<left>{TimeDayDescRegex}?({TimeCJKTimeRegex}))'
    TimePeriodRightCJKTimeRegex = f'{TimePeriodTimePeriodConnectWords}(?<right>{TimeDayDescRegex}?{TimeCJKTimeRegex})(之间)?'
    TimePeriodLeftDigitTimeRegex = f'(从)?(?<left>{TimeDayDescRegex}?({TimeDigitTimeRegex}))'
    TimePeriodRightDigitTimeRegex = f'{TimePeriodTimePeriodConnectWords}(?<right>{TimeDayDescRegex}?{TimeDigitTimeRegex})(之间)?'
    TimePeriodShortLeftCJKTimeRegex = f'(从)?(?<left>{TimeDayDescRegex}?({TimeHourCJKRegex}))'
    TimePeriodShortLeftDigitTimeRegex = f'(从)?(?<left>{TimeDayDescRegex}?({TimeHourNumRegex}))'
    TimePeriodRegexes1 = f'({TimePeriodLeftDigitTimeRegex}{TimePeriodRightDigitTimeRegex}|{TimePeriodLeftCJKTimeRegex}{TimePeriodRightCJKTimeRegex})'
    TimePeriodRegexes2 = f'({TimePeriodShortLeftDigitTimeRegex}{TimePeriodRightDigitTimeRegex}|{TimePeriodShortLeftCJKTimeRegex}{TimePeriodRightCJKTimeRegex})'
    FromToRegex = f'(从|自).+([至到]).+'
    AmbiguousRangeModifierPrefix = f'(从|自)'
    ParserConfigurationBefore = f'((?<include>和|或|及)?(之前|以前)|前)'
    ParserConfigurationAfter = f'((?<include>和|或|及)?(之后|之後|以后|以後)|后|後)'
    ParserConfigurationUntil = f'(直到|直至|截至|截止(到)?)'
    ParserConfigurationSincePrefix = f'(自从|自|自打|打|从)'
    ParserConfigurationSinceSuffix = f'(以来|开始|起)'
    ParserConfigurationLastWeekDayToken = '最后一个'
    ParserConfigurationNextMonthToken = '下一个'
    ParserConfigurationLastMonthToken = '上一个'
    ParserConfigurationDatePrefix = ' '
    ParserConfigurationUnitMap = dict([("年", "Y"),
                                       ("月", "MON"),
                                       ("个月", "MON"),
                                       ("日", "D"),
                                       ("周", "W"),
                                       ("週", "W"),
                                       ("天", "D"),
                                       ("小时", "H"),
                                       ("个小时", "H"),
                                       ("时", "H"),
                                       ("分钟", "M"),
                                       ("分", "M"),
                                       ("秒钟", "S"),
                                       ("秒", "S"),
                                       ("星期", "W"),
                                       ("个星期", "W")])
    ParserConfigurationUnitValueMap = dict([("years", 31536000),
                                            ("year", 31536000),
                                            ("months", 2592000),
                                            ("month", 2592000),
                                            ("weeks", 604800),
                                            ("week", 604800),
                                            ("days", 86400),
                                            ("day", 86400),
                                            ("hours", 3600),
                                            ("hour", 3600),
                                            ("hrs", 3600),
                                            ("hr", 3600),
                                            ("h", 3600),
                                            ("minutes", 60),
                                            ("minute", 60),
                                            ("mins", 60),
                                            ("min", 60),
                                            ("seconds", 1),
                                            ("second", 1),
                                            ("secs", 1),
                                            ("sec", 1)])
    MonthTerms = [r'月']
    WeekendTerms = [r'周末']
    WeekTerms = [r'周', r'週', r'星期']
    YearTerms = [r'年']
    ThisYearTerms = [r'今年']
    LastYearTerms = [r'去年']
    NextYearTerms = [r'明年']
    YearAfterNextTerms = [r'后年']
    YearBeforeLastTerms = [r'前年']
    ParserConfigurationSeasonMap = dict([("春", "SP"),
                                         ("夏", "SU"),
                                         ("秋", "FA"),
                                         ("冬", "WI")])
    ParserConfigurationSeasonValueMap = dict([("SP", 3),
                                              ("SU", 6),
                                              ("FA", 9),
                                              ("WI", 12)])
    ParserConfigurationCardinalMap = dict([("一", 1),
                                           ("二", 2),
                                           ("三", 3),
                                           ("四", 4),
                                           ("五", 5),
                                           ("1", 1),
                                           ("2", 2),
                                           ("3", 3),
                                           ("4", 4),
                                           ("5", 5),
                                           ("第一个", 1),
                                           ("第二个", 2),
                                           ("第三个", 3),
                                           ("第四个", 4),
                                           ("第五个", 5),
                                           ("第一", 1),
                                           ("第二", 2),
                                           ("第三", 3),
                                           ("第四", 4),
                                           ("第五", 5),
                                           ("第六", 6),
                                           ("第七", 7),
                                           ("第八", 8),
                                           ("第九", 9),
                                           ("第十", 10),
                                           ("第十一", 11),
                                           ("第十二", 12)])
    ParserConfigurationDayOfMonth = dict([("01", 1),
                                          ("02", 2),
                                          ("03", 3),
                                          ("04", 4),
                                          ("05", 5),
                                          ("06", 6),
                                          ("07", 7),
                                          ("08", 8),
                                          ("09", 9),
                                          ("1", 1),
                                          ("2", 2),
                                          ("3", 3),
                                          ("4", 4),
                                          ("5", 5),
                                          ("6", 6),
                                          ("7", 7),
                                          ("8", 8),
                                          ("9", 9),
                                          ("10", 10),
                                          ("11", 11),
                                          ("12", 12),
                                          ("13", 13),
                                          ("14", 14),
                                          ("15", 15),
                                          ("16", 16),
                                          ("17", 17),
                                          ("18", 18),
                                          ("19", 19),
                                          ("20", 20),
                                          ("21", 21),
                                          ("22", 22),
                                          ("23", 23),
                                          ("24", 24),
                                          ("25", 25),
                                          ("26", 26),
                                          ("27", 27),
                                          ("28", 28),
                                          ("29", 29),
                                          ("30", 30),
                                          ("31", 31),
                                          ("1日", 1),
                                          ("2日", 2),
                                          ("3日", 3),
                                          ("4日", 4),
                                          ("5日", 5),
                                          ("6日", 6),
                                          ("7日", 7),
                                          ("8日", 8),
                                          ("9日", 9),
                                          ("10日", 10),
                                          ("11日", 11),
                                          ("12日", 12),
                                          ("13日", 13),
                                          ("14日", 14),
                                          ("15日", 15),
                                          ("16日", 16),
                                          ("17日", 17),
                                          ("18日", 18),
                                          ("19日", 19),
                                          ("20日", 20),
                                          ("21日", 21),
                                          ("22日", 22),
                                          ("23日", 23),
                                          ("24日", 24),
                                          ("25日", 25),
                                          ("26日", 26),
                                          ("27日", 27),
                                          ("28日", 28),
                                          ("29日", 29),
                                          ("30日", 30),
                                          ("31日", 31),
                                          ("一日", 1),
                                          ("十一日", 11),
                                          ("二十日", 20),
                                          ("十日", 10),
                                          ("二十一日", 21),
                                          ("三十一日", 31),
                                          ("二日", 2),
                                          ("三日", 3),
                                          ("四日", 4),
                                          ("五日", 5),
                                          ("六日", 6),
                                          ("七日", 7),
                                          ("八日", 8),
                                          ("九日", 9),
                                          ("十二日", 12),
                                          ("十三日", 13),
                                          ("十四日", 14),
                                          ("十五日", 15),
                                          ("十六日", 16),
                                          ("十七日", 17),
                                          ("十八日", 18),
                                          ("十九日", 19),
                                          ("二十二日", 22),
                                          ("二十三日", 23),
                                          ("二十四日", 24),
                                          ("二十五日", 25),
                                          ("二十六日", 26),
                                          ("二十七日", 27),
                                          ("二十八日", 28),
                                          ("二十九日", 29),
                                          ("三十日", 30),
                                          ("1号", 1),
                                          ("2号", 2),
                                          ("3号", 3),
                                          ("4号", 4),
                                          ("5号", 5),
                                          ("6号", 6),
                                          ("7号", 7),
                                          ("8号", 8),
                                          ("9号", 9),
                                          ("10号", 10),
                                          ("11号", 11),
                                          ("12号", 12),
                                          ("13号", 13),
                                          ("14号", 14),
                                          ("15号", 15),
                                          ("16号", 16),
                                          ("17号", 17),
                                          ("18号", 18),
                                          ("19号", 19),
                                          ("20号", 20),
                                          ("21号", 21),
                                          ("22号", 22),
                                          ("23号", 23),
                                          ("24号", 24),
                                          ("25号", 25),
                                          ("26号", 26),
                                          ("27号", 27),
                                          ("28号", 28),
                                          ("29号", 29),
                                          ("30号", 30),
                                          ("31号", 31),
                                          ("一号", 1),
                                          ("十一号", 11),
                                          ("二十号", 20),
                                          ("十号", 10),
                                          ("二十一号", 21),
                                          ("三十一号", 31),
                                          ("二号", 2),
                                          ("三号", 3),
                                          ("四号", 4),
                                          ("五号", 5),
                                          ("六号", 6),
                                          ("七号", 7),
                                          ("八号", 8),
                                          ("九号", 9),
                                          ("十二号", 12),
                                          ("十三号", 13),
                                          ("十四号", 14),
                                          ("十五号", 15),
                                          ("十六号", 16),
                                          ("十七号", 17),
                                          ("十八号", 18),
                                          ("十九号", 19),
                                          ("二十二号", 22),
                                          ("二十三号", 23),
                                          ("二十四号", 24),
                                          ("二十五号", 25),
                                          ("二十六号", 26),
                                          ("二十七号", 27),
                                          ("二十八号", 28),
                                          ("二十九号", 29),
                                          ("三十号", 30),
                                          ("初一", 32),
                                          ("三十", 30),
                                          ("一", 1),
                                          ("十一", 11),
                                          ("二十", 20),
                                          ("十", 10),
                                          ("二十一", 21),
                                          ("三十一", 31),
                                          ("二", 2),
                                          ("三", 3),
                                          ("四", 4),
                                          ("五", 5),
                                          ("六", 6),
                                          ("七", 7),
                                          ("八", 8),
                                          ("九", 9),
                                          ("十二", 12),
                                          ("十三", 13),
                                          ("十四", 14),
                                          ("十五", 15),
                                          ("十六", 16),
                                          ("十七", 17),
                                          ("十八", 18),
                                          ("十九", 19),
                                          ("二十二", 22),
                                          ("二十三", 23),
                                          ("二十四", 24),
                                          ("二十五", 25),
                                          ("二十六", 26),
                                          ("二十七", 27),
                                          ("二十八", 28),
                                          ("二十九", 29)])
    ParserConfigurationDayOfWeek = dict([("星期一", 1),
                                         ("星期二", 2),
                                         ("星期三", 3),
                                         ("星期四", 4),
                                         ("星期五", 5),
                                         ("星期六", 6),
                                         ("星期天", 0),
                                         ("星期日", 0),
                                         ("礼拜一", 1),
                                         ("礼拜二", 2),
                                         ("礼拜三", 3),
                                         ("礼拜四", 4),
                                         ("礼拜五", 5),
                                         ("礼拜六", 6),
                                         ("礼拜天", 0),
                                         ("礼拜日", 0),
                                         ("周一", 1),
                                         ("周二", 2),
                                         ("周三", 3),
                                         ("周四", 4),
                                         ("周五", 5),
                                         ("周六", 6),
                                         ("周日", 0),
                                         ("周天", 0),
                                         ("禮拜一", 1),
                                         ("禮拜二", 2),
                                         ("禮拜三", 3),
                                         ("禮拜四", 4),
                                         ("禮拜五", 5),
                                         ("禮拜六", 6),
                                         ("禮拜天", 0),
                                         ("禮拜日", 0),
                                         ("週一", 1),
                                         ("週二", 2),
                                         ("週三", 3),
                                         ("週四", 4),
                                         ("週五", 5),
                                         ("週六", 6),
                                         ("週日", 0),
                                         ("週天", 0)])
    ParserConfigurationMonthOfYear = dict([("1", 1),
                                           ("2", 2),
                                           ("3", 3),
                                           ("4", 4),
                                           ("5", 5),
                                           ("6", 6),
                                           ("7", 7),
                                           ("8", 8),
                                           ("9", 9),
                                           ("10", 10),
                                           ("11", 11),
                                           ("12", 12),
                                           ("01", 1),
                                           ("02", 2),
                                           ("03", 3),
                                           ("04", 4),
                                           ("05", 5),
                                           ("06", 6),
                                           ("07", 7),
                                           ("08", 8),
                                           ("09", 9),
                                           ("一月", 1),
                                           ("二月", 2),
                                           ("三月", 3),
                                           ("四月", 4),
                                           ("五月", 5),
                                           ("六月", 6),
                                           ("七月", 7),
                                           ("八月", 8),
                                           ("九月", 9),
                                           ("十月", 10),
                                           ("十一月", 11),
                                           ("十二月", 12),
                                           ("1月", 1),
                                           ("2月", 2),
                                           ("3月", 3),
                                           ("4月", 4),
                                           ("5月", 5),
                                           ("6月", 6),
                                           ("7月", 7),
                                           ("8月", 8),
                                           ("9月", 9),
                                           ("10月", 10),
                                           ("11月", 11),
                                           ("12月", 12),
                                           ("01月", 1),
                                           ("02月", 2),
                                           ("03月", 3),
                                           ("04月", 4),
                                           ("05月", 5),
                                           ("06月", 6),
                                           ("07月", 7),
                                           ("08月", 8),
                                           ("09月", 9),
                                           ("正月", 13),
                                           ("大年", 13)])
    DateTimeSimpleAmRegex = f'(?<am>早|晨)'
    DateTimeSimplePmRegex = f'(?<pm>晚)'
    DateTimePeriodMORegex = f'(凌晨|清晨|早上|早间|早|上午)'
    DateTimePeriodMIRegex = f'(中午)'
    DateTimePeriodAFRegex = f'(下午|午后|傍晚)'
    DateTimePeriodEVRegex = f'(晚上|夜里|夜晚|晚)'
    DateTimePeriodNIRegex = f'(半夜|夜间|深夜)'
    AmbiguityFiltersDict = dict([("早", "(?<!今|明|日|号)早(?!上)"),
                                 ("晚", "(?<!今|明|昨|傍|夜|日|号)晚(?!上)"),
                                 ("^\\d{1,2}号", "^\\d{1,2}号"),
                                 ("周", "周岁"),
                                 ("今日", "今日头条"),
                                 ("明日", "《明日之后》"),
                                 ("时", "时间")])
    DurationUnitValueMap = dict([("Y", 31536000),
                                 ("Mon", 2592000),
                                 ("W", 604800),
                                 ("D", 86400),
                                 ("H", 3600),
                                 ("M", 60),
                                 ("S", 1)])
    HolidayNoFixedTimex = dict([("父亲节", "-06-WXX-6-3"),
                                ("母亲节", "-05-WXX-7-2"),
                                ("感恩节", "-11-WXX-4-4")])
    MergedBeforeRegex = f'(前|之前)$'
    MergedAfterRegex = f'(后|後|之后|之後)$'
    TimeNumberDictionary = dict([("零", 0),
                                 ("一", 1),
                                 ("二", 2),
                                 ("三", 3),
                                 ("四", 4),
                                 ("五", 5),
                                 ("六", 6),
                                 ("七", 7),
                                 ("八", 8),
                                 ("九", 9),
                                 ("〇", 0),
                                 ("两", 2),
                                 ("十", 10)])
    TimeLowBoundDesc = dict([("中午", 11),
                             ("下午", 12),
                             ("午后", 12),
                             ("晚上", 18),
                             ("夜里", 18),
                             ("夜晚", 18),
                             ("夜间", 18),
                             ("深夜", 18),
                             ("傍晚", 18),
                             ("晚", 18),
                             ("pm", 12)])
    DefaultLanguageFallback = 'YMD'
    MorningTermList = [r'早', r'上午', r'早间', r'早上', r'清晨']
    MidDayTermList = [r'中午', r'正午']
    AfternoonTermList = [r'下午', r'午后']
    EveningTermList = [r'晚', r'晚上', r'夜里', r'傍晚', r'夜晚']
    DaytimeTermList = [r'白天', r'日间']
    NightTermList = [r'深夜']
    DynastyYearMap = dict([("贞观", 627),
                           ("开元", 713),
                           ("神龙", 705),
                           ("洪武", 1368),
                           ("建文", 1399),
                           ("永乐", 1403),
                           ("景泰", 1450),
                           ("天顺", 1457),
                           ("成化", 1465),
                           ("嘉靖", 1522),
                           ("万历", 1573),
                           ("崇祯", 1628),
                           ("顺治", 1644),
                           ("康熙", 1662),
                           ("雍正", 1723),
                           ("乾隆", 1736),
                           ("嘉庆", 1796),
                           ("道光", 1821),
                           ("咸丰", 1851),
                           ("同治", 1862),
                           ("光绪", 1875),
                           ("宣统", 1909),
                           ("民国", 1912)])
# pylint: enable=line-too-long
