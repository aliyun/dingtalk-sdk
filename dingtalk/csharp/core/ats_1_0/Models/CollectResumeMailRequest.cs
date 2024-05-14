// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkats_1_0.Models
{
    public class CollectResumeMailRequest : TeaModel {
        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("bizCode")]
        [Validation(Required=false)]
        public string BizCode { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("channelCode")]
        [Validation(Required=false)]
        public string ChannelCode { get; set; }

        [NameInMap("deliverJobId")]
        [Validation(Required=false)]
        public string DeliverJobId { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("fromMailAddress")]
        [Validation(Required=false)]
        public string FromMailAddress { get; set; }

        [NameInMap("historyMailImport")]
        [Validation(Required=false)]
        public bool? HistoryMailImport { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("mailId")]
        [Validation(Required=false)]
        public string MailId { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("mailTitle")]
        [Validation(Required=false)]
        public string MailTitle { get; set; }

        [NameInMap("optUserId")]
        [Validation(Required=false)]
        public string OptUserId { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("receiveMailAddress")]
        [Validation(Required=false)]
        public string ReceiveMailAddress { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("receiveMailType")]
        [Validation(Required=false)]
        public int? ReceiveMailType { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("receivedTime")]
        [Validation(Required=false)]
        public long? ReceivedTime { get; set; }

        [NameInMap("resumeChannelUrl")]
        [Validation(Required=false)]
        public string ResumeChannelUrl { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("resumeFile")]
        [Validation(Required=false)]
        public CollectResumeMailRequestResumeFile ResumeFile { get; set; }
        public class CollectResumeMailRequestResumeFile : TeaModel {
            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("downloadUrl")]
            [Validation(Required=false)]
            public string DownloadUrl { get; set; }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("fileName")]
            [Validation(Required=false)]
            public string FileName { get; set; }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("fileType")]
            [Validation(Required=false)]
            public string FileType { get; set; }

        }

    }

}
