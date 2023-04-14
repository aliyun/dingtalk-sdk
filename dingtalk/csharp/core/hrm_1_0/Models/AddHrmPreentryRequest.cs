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
                    [NameInMap("fieldCode")]
                    [Validation(Required=false)]
                    public string FieldCode { get; set; }

                    [NameInMap("value")]
                    [Validation(Required=false)]
                    public string Value { get; set; }

                }

                [NameInMap("oldIndex")]
                [Validation(Required=false)]
                public int? OldIndex { get; set; }

            }

        }

        [NameInMap("mobile")]
        [Validation(Required=false)]
        public string Mobile { get; set; }

        [NameInMap("name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// 是否需要发送完善入职登记表的入职IM消息给员工本人
        /// </summary>
        [NameInMap("needSendPreEntryMsg")]
        [Validation(Required=false)]
        public bool? NeedSendPreEntryMsg { get; set; }

        [NameInMap("preEntryTime")]
        [Validation(Required=false)]
        public long? PreEntryTime { get; set; }

    }

}
