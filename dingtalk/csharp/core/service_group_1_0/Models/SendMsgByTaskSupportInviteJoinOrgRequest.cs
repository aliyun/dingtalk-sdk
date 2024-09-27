// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkservice_group_1_0.Models
{
    public class SendMsgByTaskSupportInviteJoinOrgRequest : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("messageContent")]
        [Validation(Required=false)]
        public SendMsgByTaskSupportInviteJoinOrgRequestMessageContent MessageContent { get; set; }
        public class SendMsgByTaskSupportInviteJoinOrgRequestMessageContent : TeaModel {
            [NameInMap("btns")]
            [Validation(Required=false)]
            public List<SendMsgByTaskSupportInviteJoinOrgRequestMessageContentBtns> Btns { get; set; }
            public class SendMsgByTaskSupportInviteJoinOrgRequestMessageContentBtns : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para><a href="http://www.baidu.com">http://www.baidu.com</a></para>
                /// </summary>
                [NameInMap("actionURL")]
                [Validation(Required=false)]
                public string ActionURL { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>按钮标题</para>
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
            /// <para>ACTIONCARD：卡片消息</para>
            /// </summary>
            [NameInMap("messageType")]
            [Validation(Required=false)]
            public string MessageType { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>标题内容</para>
            /// </summary>
            [NameInMap("title")]
            [Validation(Required=false)]
            public string Title { get; set; }

        }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("mobilePhones")]
        [Validation(Required=false)]
        public List<string> MobilePhones { get; set; }

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
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>88888</para>
        /// </summary>
        [NameInMap("openTeamId")]
        [Validation(Required=false)]
        public string OpenTeamId { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>发送渠道      * 工作通知：WORK_NOTICE      * 机器人：SINGLE_ROBOT</para>
        /// </summary>
        [NameInMap("sendChannel")]
        [Validation(Required=false)]
        public string SendChannel { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>群发任务</para>
        /// </summary>
        [NameInMap("taskName")]
        [Validation(Required=false)]
        public string TaskName { get; set; }

    }

}
