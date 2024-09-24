// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkexclusive_1_0.Models
{
    public class GroupQueryByOpenIdResponseBody : TeaModel {
        [NameInMap("code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        [NameInMap("data")]
        [Validation(Required=false)]
        public GroupQueryByOpenIdResponseBodyData Data { get; set; }
        public class GroupQueryByOpenIdResponseBodyData : TeaModel {
            [NameInMap("groupName")]
            [Validation(Required=false)]
            public string GroupName { get; set; }

            [NameInMap("groupTemplateId")]
            [Validation(Required=false)]
            public string GroupTemplateId { get; set; }

            [NameInMap("groupTemplateName")]
            [Validation(Required=false)]
            public string GroupTemplateName { get; set; }

            [NameInMap("groupTopic")]
            [Validation(Required=false)]
            public string GroupTopic { get; set; }

            [NameInMap("groupType")]
            [Validation(Required=false)]
            public string GroupType { get; set; }

            [NameInMap("id")]
            [Validation(Required=false)]
            public long? Id { get; set; }

            [NameInMap("listGroupDynamicAttr")]
            [Validation(Required=false)]
            public List<GroupQueryByOpenIdResponseBodyDataListGroupDynamicAttr> ListGroupDynamicAttr { get; set; }
            public class GroupQueryByOpenIdResponseBodyDataListGroupDynamicAttr : TeaModel {
                [NameInMap("attrCode")]
                [Validation(Required=false)]
                public string AttrCode { get; set; }

                [NameInMap("listAttrOptionsCode")]
                [Validation(Required=false)]
                public List<string> ListAttrOptionsCode { get; set; }

            }

            [NameInMap("openConversationId")]
            [Validation(Required=false)]
            public string OpenConversationId { get; set; }

        }

        [NameInMap("message")]
        [Validation(Required=false)]
        public string Message { get; set; }

    }

}
