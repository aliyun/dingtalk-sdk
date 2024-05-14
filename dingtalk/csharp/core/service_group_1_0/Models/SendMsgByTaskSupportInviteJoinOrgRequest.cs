// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkservice_group_1_0.Models
{
    public class SendMsgByTaskSupportInviteJoinOrgRequest : TeaModel {
        /// <summary>
        /// This parameter is required.
        /// </summary>
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

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("content")]
            [Validation(Required=false)]
            public string Content { get; set; }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("messageType")]
            [Validation(Required=false)]
            public string MessageType { get; set; }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("title")]
            [Validation(Required=false)]
            public string Title { get; set; }

        }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("mobilePhones")]
        [Validation(Required=false)]
        public List<string> MobilePhones { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("needUrlTrack")]
        [Validation(Required=false)]
        public bool? NeedUrlTrack { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("openTeamId")]
        [Validation(Required=false)]
        public string OpenTeamId { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("sendChannel")]
        [Validation(Required=false)]
        public string SendChannel { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("taskName")]
        [Validation(Required=false)]
        public string TaskName { get; set; }

    }

}
