// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkats_1_0.Models
{
    public class CollectResumeMailRequest : TeaModel {
        [NameInMap("bizCode")]
        [Validation(Required=false)]
        public string BizCode { get; set; }

        [NameInMap("channelCode")]
        [Validation(Required=false)]
        public string ChannelCode { get; set; }

        [NameInMap("deliverJobId")]
        [Validation(Required=false)]
        public string DeliverJobId { get; set; }

        [NameInMap("fromMailAddress")]
        [Validation(Required=false)]
        public string FromMailAddress { get; set; }

        [NameInMap("mailId")]
        [Validation(Required=false)]
        public string MailId { get; set; }

        [NameInMap("mailTitle")]
        [Validation(Required=false)]
        public string MailTitle { get; set; }

        [NameInMap("optUserId")]
        [Validation(Required=false)]
        public string OptUserId { get; set; }

        [NameInMap("receiveMailAddress")]
        [Validation(Required=false)]
        public string ReceiveMailAddress { get; set; }

        [NameInMap("receiveMailType")]
        [Validation(Required=false)]
        public int? ReceiveMailType { get; set; }

        [NameInMap("receivedTime")]
        [Validation(Required=false)]
        public long? ReceivedTime { get; set; }

        [NameInMap("resumeChannelUrl")]
        [Validation(Required=false)]
        public string ResumeChannelUrl { get; set; }

        [NameInMap("resumeFile")]
        [Validation(Required=false)]
        public CollectResumeMailRequestResumeFile ResumeFile { get; set; }
        public class CollectResumeMailRequestResumeFile : TeaModel {
            [NameInMap("downloadUrl")]
            [Validation(Required=false)]
            public string DownloadUrl { get; set; }

            [NameInMap("fileName")]
            [Validation(Required=false)]
            public string FileName { get; set; }

            [NameInMap("fileType")]
            [Validation(Required=false)]
            public string FileType { get; set; }

        }

    }

}
