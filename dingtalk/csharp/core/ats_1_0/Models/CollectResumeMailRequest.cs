// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkats_1_0.Models
{
    public class CollectResumeMailRequest : TeaModel {
        /// <summary>
        /// 业务标识
        /// </summary>
        [NameInMap("bizCode")]
        [Validation(Required=false)]
        public string BizCode { get; set; }

        /// <summary>
        /// 渠道编码
        /// </summary>
        [NameInMap("channelCode")]
        [Validation(Required=false)]
        public string ChannelCode { get; set; }

        /// <summary>
        /// 候选人投递职位标识
        /// </summary>
        [NameInMap("deliverJobId")]
        [Validation(Required=false)]
        public string DeliverJobId { get; set; }

        /// <summary>
        /// 邮件来源地址
        /// </summary>
        [NameInMap("fromMailAddress")]
        [Validation(Required=false)]
        public string FromMailAddress { get; set; }

        /// <summary>
        /// 邮件唯一标识
        /// </summary>
        [NameInMap("mailId")]
        [Validation(Required=false)]
        public string MailId { get; set; }

        /// <summary>
        /// 邮件标题
        /// </summary>
        [NameInMap("mailTitle")]
        [Validation(Required=false)]
        public string MailTitle { get; set; }

        /// <summary>
        /// 操作人userId
        /// </summary>
        [NameInMap("optUserId")]
        [Validation(Required=false)]
        public string OptUserId { get; set; }

        /// <summary>
        /// 收件邮箱地址
        /// </summary>
        [NameInMap("receiveMailAddress")]
        [Validation(Required=false)]
        public string ReceiveMailAddress { get; set; }

        /// <summary>
        /// 收件邮箱类型
        /// </summary>
        [NameInMap("receiveMailType")]
        [Validation(Required=false)]
        public int? ReceiveMailType { get; set; }

        /// <summary>
        /// 收件时间
        /// </summary>
        [NameInMap("receivedTime")]
        [Validation(Required=false)]
        public long? ReceivedTime { get; set; }

        /// <summary>
        /// 渠道简历跳转链接
        /// </summary>
        [NameInMap("resumeChannelUrl")]
        [Validation(Required=false)]
        public string ResumeChannelUrl { get; set; }

        /// <summary>
        /// 简历原始文件
        /// </summary>
        [NameInMap("resumeFile")]
        [Validation(Required=false)]
        public CollectResumeMailRequestResumeFile ResumeFile { get; set; }
        public class CollectResumeMailRequestResumeFile : TeaModel {
            /// <summary>
            /// 文件下载地址
            /// </summary>
            [NameInMap("downloadUrl")]
            [Validation(Required=false)]
            public string DownloadUrl { get; set; }

            /// <summary>
            /// 文件名称
            /// </summary>
            [NameInMap("fileName")]
            [Validation(Required=false)]
            public string FileName { get; set; }

            /// <summary>
            /// 文件类型
            /// </summary>
            [NameInMap("fileType")]
            [Validation(Required=false)]
            public string FileType { get; set; }

        }

    }

}
