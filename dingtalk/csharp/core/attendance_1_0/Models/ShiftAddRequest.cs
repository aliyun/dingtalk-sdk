// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkattendance_1_0.Models
{
    public class ShiftAddRequest : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>白班</para>
        /// </summary>
        [NameInMap("name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>user01</para>
        /// </summary>
        [NameInMap("owner")]
        [Validation(Required=false)]
        public string Owner { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("sections")]
        [Validation(Required=false)]
        public List<ShiftAddRequestSections> Sections { get; set; }
        public class ShiftAddRequestSections : TeaModel {
            /// <summary>
            /// <para>This parameter is required.</para>
            /// </summary>
            [NameInMap("times")]
            [Validation(Required=false)]
            public List<ShiftAddRequestSectionsTimes> Times { get; set; }
            public class ShiftAddRequestSectionsTimes : TeaModel {
                /// <summary>
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("across")]
                [Validation(Required=false)]
                public int? Across { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>30</para>
                /// </summary>
                [NameInMap("beginMin")]
                [Validation(Required=false)]
                public int? BeginMin { get; set; }

                /// <summary>
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1714298274613</para>
                /// </summary>
                [NameInMap("checkTime")]
                [Validation(Required=false)]
                public long? CheckTime { get; set; }

                /// <summary>
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>OnDuty</para>
                /// </summary>
                [NameInMap("checkType")]
                [Validation(Required=false)]
                public string CheckType { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>-1</para>
                /// </summary>
                [NameInMap("endMin")]
                [Validation(Required=false)]
                public int? EndMin { get; set; }

                [NameInMap("flexMinutes")]
                [Validation(Required=false)]
                public List<int?> FlexMinutes { get; set; }

                [NameInMap("freeCheck")]
                [Validation(Required=false)]
                public bool? FreeCheck { get; set; }

            }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>123</para>
        /// </summary>
        [NameInMap("serviceId")]
        [Validation(Required=false)]
        public long? ServiceId { get; set; }

        [NameInMap("setting")]
        [Validation(Required=false)]
        public ShiftAddRequestSetting Setting { get; set; }
        public class ShiftAddRequestSetting : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>60</para>
            /// </summary>
            [NameInMap("absenteeismLateMinutes")]
            [Validation(Required=false)]
            public int? AbsenteeismLateMinutes { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>0.8</para>
            /// </summary>
            [NameInMap("attendDays")]
            [Validation(Required=false)]
            public double? AttendDays { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>480</para>
            /// </summary>
            [NameInMap("demandWorkTimeMinutes")]
            [Validation(Required=false)]
            public int? DemandWorkTimeMinutes { get; set; }

            [NameInMap("enableOutsideLateBack")]
            [Validation(Required=false)]
            public bool? EnableOutsideLateBack { get; set; }

            [NameInMap("extras")]
            [Validation(Required=false)]
            public Dictionary<string, object> Extras { get; set; }

            [NameInMap("isFlexible")]
            [Validation(Required=false)]
            public bool? IsFlexible { get; set; }

            [NameInMap("lateBackSetting")]
            [Validation(Required=false)]
            public ShiftAddRequestSettingLateBackSetting LateBackSetting { get; set; }
            public class ShiftAddRequestSettingLateBackSetting : TeaModel {
                [NameInMap("enable")]
                [Validation(Required=false)]
                public bool? Enable { get; set; }

                [NameInMap("sections")]
                [Validation(Required=false)]
                public List<ShiftAddRequestSettingLateBackSettingSections> Sections { get; set; }
                public class ShiftAddRequestSettingLateBackSettingSections : TeaModel {
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>120</para>
                    /// </summary>
                    [NameInMap("extra")]
                    [Validation(Required=false)]
                    public int? Extra { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>60</para>
                    /// </summary>
                    [NameInMap("late")]
                    [Validation(Required=false)]
                    public int? Late { get; set; }

                }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1234</para>
            /// </summary>
            [NameInMap("referenceClassId")]
            [Validation(Required=false)]
            public long? ReferenceClassId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>31</para>
            /// </summary>
            [NameInMap("seriousLateMinutes")]
            [Validation(Required=false)]
            public int? SeriousLateMinutes { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>NORMAL</para>
            /// 
            /// <b>if can be null:</b>
            /// <c>false</c>
            /// </summary>
            [NameInMap("shiftType")]
            [Validation(Required=false)]
            public string ShiftType { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>temp:schedule:isv</para>
            /// </summary>
            [NameInMap("tags")]
            [Validation(Required=false)]
            public string Tags { get; set; }

            [NameInMap("topRestTimeList")]
            [Validation(Required=false)]
            public List<ShiftAddRequestSettingTopRestTimeList> TopRestTimeList { get; set; }
            public class ShiftAddRequestSettingTopRestTimeList : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("across")]
                [Validation(Required=false)]
                public int? Across { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1714298002940</para>
                /// </summary>
                [NameInMap("checkTime")]
                [Validation(Required=false)]
                public long? CheckTime { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>OnDuty</para>
                /// </summary>
                [NameInMap("checkType")]
                [Validation(Required=false)]
                public string CheckType { get; set; }

            }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1234</para>
        /// </summary>
        [NameInMap("shiftId")]
        [Validation(Required=false)]
        public long? ShiftId { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>user01</para>
        /// </summary>
        [NameInMap("opUserId")]
        [Validation(Required=false)]
        public string OpUserId { get; set; }

    }

}
