// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkservice_group_1_0.Models
{
    public class CustomerSendMsgTaskRequest : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("messageContent")]
        [Validation(Required=false)]
        public CustomerSendMsgTaskRequestMessageContent MessageContent { get; set; }
        public class CustomerSendMsgTaskRequestMessageContent : TeaModel {
            [NameInMap("btns")]
            [Validation(Required=false)]
            public List<CustomerSendMsgTaskRequestMessageContentBtns> Btns { get; set; }
            public class CustomerSendMsgTaskRequestMessageContentBtns : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para><a href="http://www.baidu.com">http://www.baidu.com</a></para>
                /// </summary>
                [NameInMap("actionURL")]
                [Validation(Required=false)]
                public string ActionURL { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>百度</para>
                /// </summary>
                [NameInMap("title")]
                [Validation(Required=false)]
                public string Title { get; set; }

            }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>内容</para>
            /// </summary>
            [NameInMap("content")]
            [Validation(Required=false)]
            public string Content { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ACTIONCAR：卡片消息</para>
            /// </summary>
            [NameInMap("messageType")]
            [Validation(Required=false)]
            public string MessageType { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>标题</para>
            /// </summary>
            [NameInMap("title")]
            [Validation(Required=false)]
            public string Title { get; set; }

        }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>8888</para>
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

            /// <summary>
            /// <b>Example:</b>
            /// <para>AIMED</para>
            /// </summary>
            [NameInMap("queryType")]
            [Validation(Required=false)]
            public string QueryType { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>{}</para>
            /// </summary>
            [NameInMap("searchContactConditions")]
            [Validation(Required=false)]
            public string SearchContactConditions { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>{}</para>
            /// </summary>
            [NameInMap("searchCustomerConditions")]
            [Validation(Required=false)]
            public string SearchCustomerConditions { get; set; }

        }

        [NameInMap("sendConfig")]
        [Validation(Required=false)]
        public CustomerSendMsgTaskRequestSendConfig SendConfig { get; set; }
        public class CustomerSendMsgTaskRequestSendConfig : TeaModel {
            /// <summary>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("needUrlTrack")]
            [Validation(Required=false)]
            public bool? NeedUrlTrack { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2023-06-01 00:00:00</para>
            /// </summary>
            [NameInMap("sendTime")]
            [Validation(Required=false)]
            public string SendTime { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>INSTANT</para>
            /// </summary>
            [NameInMap("sendType")]
            [Validation(Required=false)]
            public string SendType { get; set; }

            [NameInMap("urlTrackConfig")]
            [Validation(Required=false)]
            public List<CustomerSendMsgTaskRequestSendConfigUrlTrackConfig> UrlTrackConfig { get; set; }
            public class CustomerSendMsgTaskRequestSendConfigUrlTrackConfig : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>百度</para>
                /// </summary>
                [NameInMap("title")]
                [Validation(Required=false)]
                public string Title { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>88888</para>
                /// </summary>
                [NameInMap("trackId")]
                [Validation(Required=false)]
                public string TrackId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para><a href="http://www.baidu.com">http://www.baidu.com</a></para>
                /// </summary>
                [NameInMap("trackUrl")]
                [Validation(Required=false)]
                public string TrackUrl { get; set; }

            }

        }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>任务名称</para>
        /// </summary>
        [NameInMap("taskName")]
        [Validation(Required=false)]
        public string TaskName { get; set; }

    }

}
