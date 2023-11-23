// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkattendance_1_0.Models
{
    public class GetClassWithDeletedResponseBody : TeaModel {
        [NameInMap("result")]
        [Validation(Required=false)]
        public GetClassWithDeletedResponseBodyResult Result { get; set; }
        public class GetClassWithDeletedResponseBodyResult : TeaModel {
            [NameInMap("classId")]
            [Validation(Required=false)]
            public long? ClassId { get; set; }

            [NameInMap("classSetting")]
            [Validation(Required=false)]
            public GetClassWithDeletedResponseBodyResultClassSetting ClassSetting { get; set; }
            public class GetClassWithDeletedResponseBodyResultClassSetting : TeaModel {
                [NameInMap("classSettingId")]
                [Validation(Required=false)]
                public long? ClassSettingId { get; set; }

                [NameInMap("restTimeList")]
                [Validation(Required=false)]
                public List<GetClassWithDeletedResponseBodyResultClassSettingRestTimeList> RestTimeList { get; set; }
                public class GetClassWithDeletedResponseBodyResultClassSettingRestTimeList : TeaModel {
                    [NameInMap("begin")]
                    [Validation(Required=false)]
                    public GetClassWithDeletedResponseBodyResultClassSettingRestTimeListBegin Begin { get; set; }
                    public class GetClassWithDeletedResponseBodyResultClassSettingRestTimeListBegin : TeaModel {
                        [NameInMap("across")]
                        [Validation(Required=false)]
                        public int? Across { get; set; }

                        [NameInMap("checkTime")]
                        [Validation(Required=false)]
                        public string CheckTime { get; set; }

                    }

                    [NameInMap("end")]
                    [Validation(Required=false)]
                    public GetClassWithDeletedResponseBodyResultClassSettingRestTimeListEnd End { get; set; }
                    public class GetClassWithDeletedResponseBodyResultClassSettingRestTimeListEnd : TeaModel {
                        [NameInMap("across")]
                        [Validation(Required=false)]
                        public int? Across { get; set; }

                        [NameInMap("checkTime")]
                        [Validation(Required=false)]
                        public string CheckTime { get; set; }

                    }

                }

            }

            [NameInMap("corpId")]
            [Validation(Required=false)]
            public string CorpId { get; set; }

            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            [NameInMap("sections")]
            [Validation(Required=false)]
            public List<GetClassWithDeletedResponseBodyResultSections> Sections { get; set; }
            public class GetClassWithDeletedResponseBodyResultSections : TeaModel {
                [NameInMap("times")]
                [Validation(Required=false)]
                public List<GetClassWithDeletedResponseBodyResultSectionsTimes> Times { get; set; }
                public class GetClassWithDeletedResponseBodyResultSectionsTimes : TeaModel {
                    [NameInMap("across")]
                    [Validation(Required=false)]
                    public int? Across { get; set; }

                    [NameInMap("beginMin")]
                    [Validation(Required=false)]
                    public long? BeginMin { get; set; }

                    [NameInMap("checkTime")]
                    [Validation(Required=false)]
                    public string CheckTime { get; set; }

                    [NameInMap("checkType")]
                    [Validation(Required=false)]
                    public string CheckType { get; set; }

                    [NameInMap("endMin")]
                    [Validation(Required=false)]
                    public long? EndMin { get; set; }

                }

            }

            [NameInMap("workDays")]
            [Validation(Required=false)]
            public List<int?> WorkDays { get; set; }

        }

    }

}
