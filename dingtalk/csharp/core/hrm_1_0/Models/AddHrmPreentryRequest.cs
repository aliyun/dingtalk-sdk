// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkhrm_1_0.Models
{
    public class AddHrmPreentryRequest : TeaModel {
        [NameInMap("agentId")]
        [Validation(Required=false)]
        public long? AgentId { get; set; }

        [NameInMap("groups")]
        [Validation(Required=false)]
        public List<AddHrmPreentryRequestGroups> Groups { get; set; }
        public class AddHrmPreentryRequestGroups : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>sys01</para>
            /// </summary>
            [NameInMap("groupId")]
            [Validation(Required=false)]
            public string GroupId { get; set; }

            [NameInMap("sections")]
            [Validation(Required=false)]
            public List<AddHrmPreentryRequestGroupsSections> Sections { get; set; }
            public class AddHrmPreentryRequestGroupsSections : TeaModel {
                [NameInMap("empFieldVOList")]
                [Validation(Required=false)]
                public List<AddHrmPreentryRequestGroupsSectionsEmpFieldVOList> EmpFieldVOList { get; set; }
                public class AddHrmPreentryRequestGroupsSectionsEmpFieldVOList : TeaModel {
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>sys01-birthTime</para>
                    /// </summary>
                    [NameInMap("fieldCode")]
                    [Validation(Required=false)]
                    public string FieldCode { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>2020-10-10</para>
                    /// </summary>
                    [NameInMap("value")]
                    [Validation(Required=false)]
                    public string Value { get; set; }

                }

                /// <summary>
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("oldIndex")]
                [Validation(Required=false)]
                public int? OldIndex { get; set; }

            }

        }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("mobile")]
        [Validation(Required=false)]
        public string Mobile { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        [NameInMap("needSendPreEntryMsg")]
        [Validation(Required=false)]
        public bool? NeedSendPreEntryMsg { get; set; }

        [NameInMap("preEntryTime")]
        [Validation(Required=false)]
        public long? PreEntryTime { get; set; }

    }

}
