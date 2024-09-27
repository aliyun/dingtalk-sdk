// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkats_1_0.Models
{
    public class CollectResumeMailRequest : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ddats</para>
        /// </summary>
        [NameInMap("bizCode")]
        [Validation(Required=false)]
        public string BizCode { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>liepin</para>
        /// </summary>
        [NameInMap("channelCode")]
        [Validation(Required=false)]
        public string ChannelCode { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>jobId8fc0d56a605d495ea0214af7axxxxxxx</para>
        /// </summary>
        [NameInMap("deliverJobId")]
        [Validation(Required=false)]
        public string DeliverJobId { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="mailto:xxxx@163.com">xxxx@163.com</a></para>
        /// </summary>
        [NameInMap("fromMailAddress")]
        [Validation(Required=false)]
        public string FromMailAddress { get; set; }

        [NameInMap("historyMailImport")]
        [Validation(Required=false)]
        public bool? HistoryMailImport { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>xxxxxxxx</para>
        /// </summary>
        [NameInMap("mailId")]
        [Validation(Required=false)]
        public string MailId { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>xxxxx应聘贵公司xxx职位</para>
        /// </summary>
        [NameInMap("mailTitle")]
        [Validation(Required=false)]
        public string MailTitle { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>2701606624233xxxxx</para>
        /// </summary>
        [NameInMap("optUserId")]
        [Validation(Required=false)]
        public string OptUserId { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="mailto:xxxx@163.com">xxxx@163.com</a></para>
        /// </summary>
        [NameInMap("receiveMailAddress")]
        [Validation(Required=false)]
        public string ReceiveMailAddress { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("receiveMailType")]
        [Validation(Required=false)]
        public int? ReceiveMailType { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("receivedTime")]
        [Validation(Required=false)]
        public long? ReceivedTime { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>http:<a href="http://www.xxx.com">www.xxx.com</a></para>
        /// </summary>
        [NameInMap("resumeChannelUrl")]
        [Validation(Required=false)]
        public string ResumeChannelUrl { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("resumeFile")]
        [Validation(Required=false)]
        public CollectResumeMailRequestResumeFile ResumeFile { get; set; }
        public class CollectResumeMailRequestResumeFile : TeaModel {
            /// <summary>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>http:<a href="http://www.xxx.com">www.xxx.com</a></para>
            /// </summary>
            [NameInMap("downloadUrl")]
            [Validation(Required=false)]
            public string DownloadUrl { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>xxxx的简历.pdf</para>
            /// </summary>
            [NameInMap("fileName")]
            [Validation(Required=false)]
            public string FileName { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>pdf</para>
            /// </summary>
            [NameInMap("fileType")]
            [Validation(Required=false)]
            public string FileType { get; set; }

        }

    }

}
