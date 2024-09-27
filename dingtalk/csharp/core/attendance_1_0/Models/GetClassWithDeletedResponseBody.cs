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
            /// <summary>
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("classId")]
            [Validation(Required=false)]
            public long? ClassId { get; set; }

            [NameInMap("classSetting")]
            [Validation(Required=false)]
            public GetClassWithDeletedResponseBodyResultClassSetting ClassSetting { get; set; }
            public class GetClassWithDeletedResponseBodyResultClassSetting : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
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
                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>0</para>
                        /// </summary>
                        [NameInMap("across")]
                        [Validation(Required=false)]
                        public int? Across { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>1970-01-01T12:00Z</para>
                        /// </summary>
                        [NameInMap("checkTime")]
                        [Validation(Required=false)]
                        public string CheckTime { get; set; }

                    }

                    [NameInMap("end")]
                    [Validation(Required=false)]
                    public GetClassWithDeletedResponseBodyResultClassSettingRestTimeListEnd End { get; set; }
                    public class GetClassWithDeletedResponseBodyResultClassSettingRestTimeListEnd : TeaModel {
                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>0</para>
                        /// </summary>
                        [NameInMap("across")]
                        [Validation(Required=false)]
                        public int? Across { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>1970-01-01T13:00Z</para>
                        /// </summary>
                        [NameInMap("checkTime")]
                        [Validation(Required=false)]
                        public string CheckTime { get; set; }

                    }

                }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>ding1234</para>
            /// </summary>
            [NameInMap("corpId")]
            [Validation(Required=false)]
            public string CorpId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>夜班</para>
            /// </summary>
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
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>0</para>
                    /// </summary>
                    [NameInMap("across")]
                    [Validation(Required=false)]
                    public int? Across { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>10</para>
                    /// </summary>
                    [NameInMap("beginMin")]
                    [Validation(Required=false)]
                    public long? BeginMin { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>1970-01-01T09:00Z</para>
                    /// </summary>
                    [NameInMap("checkTime")]
                    [Validation(Required=false)]
                    public string CheckTime { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>OnDuty</para>
                    /// </summary>
                    [NameInMap("checkType")]
                    [Validation(Required=false)]
                    public string CheckType { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>10</para>
                    /// </summary>
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
