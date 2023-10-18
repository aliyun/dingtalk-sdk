// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkindustry_1_0.Models
{
    public class DigitalStoreCardRecordResponseBody : TeaModel {
        [NameInMap("content")]
        [Validation(Required=false)]
        public List<DigitalStoreCardRecordResponseBodyContent> Content { get; set; }
        public class DigitalStoreCardRecordResponseBodyContent : TeaModel {
            [NameInMap("conversationTitle")]
            [Validation(Required=false)]
            public string ConversationTitle { get; set; }

            [NameInMap("detailList")]
            [Validation(Required=false)]
            public List<DigitalStoreCardRecordResponseBodyContentDetailList> DetailList { get; set; }
            public class DigitalStoreCardRecordResponseBodyContentDetailList : TeaModel {
                [NameInMap("deptName")]
                [Validation(Required=false)]
                public string DeptName { get; set; }

                [NameInMap("readStatusStr")]
                [Validation(Required=false)]
                public string ReadStatusStr { get; set; }

                [NameInMap("readTime")]
                [Validation(Required=false)]
                public long? ReadTime { get; set; }

                [NameInMap("roleName")]
                [Validation(Required=false)]
                public string RoleName { get; set; }

                [NameInMap("userName")]
                [Validation(Required=false)]
                public string UserName { get; set; }

            }

            [NameInMap("id")]
            [Validation(Required=false)]
            public long? Id { get; set; }

            [NameInMap("memberNum")]
            [Validation(Required=false)]
            public int? MemberNum { get; set; }

            [NameInMap("readNum")]
            [Validation(Required=false)]
            public int? ReadNum { get; set; }

            [NameInMap("readPercent")]
            [Validation(Required=false)]
            public string ReadPercent { get; set; }

            [NameInMap("receiveNum")]
            [Validation(Required=false)]
            public int? ReceiveNum { get; set; }

            [NameInMap("sceneCardName")]
            [Validation(Required=false)]
            public string SceneCardName { get; set; }

            [NameInMap("sendStatus")]
            [Validation(Required=false)]
            public string SendStatus { get; set; }

            [NameInMap("sendTime")]
            [Validation(Required=false)]
            public long? SendTime { get; set; }

        }

    }

}
