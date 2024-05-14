// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkservice_group_1_0.Models
{
    public class CustomerSendMsgTaskRequest : TeaModel {
        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("messageContent")]
        [Validation(Required=false)]
        public CustomerSendMsgTaskRequestMessageContent MessageContent { get; set; }
        public class CustomerSendMsgTaskRequestMessageContent : TeaModel {
            [NameInMap("btns")]
            [Validation(Required=false)]
            public List<CustomerSendMsgTaskRequestMessageContentBtns> Btns { get; set; }
            public class CustomerSendMsgTaskRequestMessageContentBtns : TeaModel {
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
        [NameInMap("openTeamId")]
        [Validation(Required=false)]
        public string OpenTeamId { get; set; }

        [NameInMap("queryCustomer")]
        [Validation(Required=false)]
        public CustomerSendMsgTaskRequestQueryCustomer QueryCustomer { get; set; }
        public class CustomerSendMsgTaskRequestQueryCustomer : TeaModel {
            [NameInMap("openContactIds")]
            [Validation(Required=false)]
            public List<string> OpenContactIds { get; set; }

            [NameInMap("queryType")]
            [Validation(Required=false)]
            public string QueryType { get; set; }

            [NameInMap("searchContactConditions")]
            [Validation(Required=false)]
            public string SearchContactConditions { get; set; }

            [NameInMap("searchCustomerConditions")]
            [Validation(Required=false)]
            public string SearchCustomerConditions { get; set; }

        }

        [NameInMap("sendConfig")]
        [Validation(Required=false)]
        public CustomerSendMsgTaskRequestSendConfig SendConfig { get; set; }
        public class CustomerSendMsgTaskRequestSendConfig : TeaModel {
            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("needUrlTrack")]
            [Validation(Required=false)]
            public bool? NeedUrlTrack { get; set; }

            [NameInMap("sendTime")]
            [Validation(Required=false)]
            public string SendTime { get; set; }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("sendType")]
            [Validation(Required=false)]
            public string SendType { get; set; }

            [NameInMap("urlTrackConfig")]
            [Validation(Required=false)]
            public List<CustomerSendMsgTaskRequestSendConfigUrlTrackConfig> UrlTrackConfig { get; set; }
            public class CustomerSendMsgTaskRequestSendConfigUrlTrackConfig : TeaModel {
                [NameInMap("title")]
                [Validation(Required=false)]
                public string Title { get; set; }

                [NameInMap("trackId")]
                [Validation(Required=false)]
                public string TrackId { get; set; }

                [NameInMap("trackUrl")]
                [Validation(Required=false)]
                public string TrackUrl { get; set; }

            }

        }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("taskName")]
        [Validation(Required=false)]
        public string TaskName { get; set; }

    }

}
