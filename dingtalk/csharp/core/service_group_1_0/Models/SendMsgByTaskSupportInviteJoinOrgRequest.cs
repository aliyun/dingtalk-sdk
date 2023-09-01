// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkservice_group_1_0.Models
{
    public class SendMsgByTaskSupportInviteJoinOrgRequest : TeaModel {
        [NameInMap("messageContent")]
        [Validation(Required=false)]
        public SendMsgByTaskSupportInviteJoinOrgRequestMessageContent MessageContent { get; set; }
        public class SendMsgByTaskSupportInviteJoinOrgRequestMessageContent : TeaModel {
            [NameInMap("btns")]
            [Validation(Required=false)]
            public List<SendMsgByTaskSupportInviteJoinOrgRequestMessageContentBtns> Btns { get; set; }
            public class SendMsgByTaskSupportInviteJoinOrgRequestMessageContentBtns : TeaModel {
                [NameInMap("actionURL")]
                [Validation(Required=false)]
                public string ActionURL { get; set; }

                [NameInMap("title")]
                [Validation(Required=false)]
                public string Title { get; set; }

            }

            [NameInMap("content")]
            [Validation(Required=false)]
            public string Content { get; set; }

            [NameInMap("messageType")]
            [Validation(Required=false)]
            public string MessageType { get; set; }

            [NameInMap("title")]
            [Validation(Required=false)]
            public string Title { get; set; }

        }

        [NameInMap("mobilePhones")]
        [Validation(Required=false)]
        public List<string> MobilePhones { get; set; }

        [NameInMap("needUrlTrack")]
        [Validation(Required=false)]
        public bool? NeedUrlTrack { get; set; }

        [NameInMap("openTeamId")]
        [Validation(Required=false)]
        public string OpenTeamId { get; set; }

        [NameInMap("sendChannel")]
        [Validation(Required=false)]
        public string SendChannel { get; set; }

        [NameInMap("taskName")]
        [Validation(Required=false)]
        public string TaskName { get; set; }

    }

}
