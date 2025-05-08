// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkhrbrain_1_0.Models
{
    public class HrbrainTalentProfileAttachmentQueryResponseBody : TeaModel {
        [NameInMap("content")]
        [Validation(Required=false)]
        public HrbrainTalentProfileAttachmentQueryResponseBodyContent Content { get; set; }
        public class HrbrainTalentProfileAttachmentQueryResponseBodyContent : TeaModel {
            [NameInMap("staffAttachmentInfoList")]
            [Validation(Required=false)]
            public List<HrbrainTalentProfileAttachmentQueryResponseBodyContentStaffAttachmentInfoList> StaffAttachmentInfoList { get; set; }
            public class HrbrainTalentProfileAttachmentQueryResponseBodyContentStaffAttachmentInfoList : TeaModel {
                [NameInMap("attachmentInfoList")]
                [Validation(Required=false)]
                public List<HrbrainTalentProfileAttachmentQueryResponseBodyContentStaffAttachmentInfoListAttachmentInfoList> AttachmentInfoList { get; set; }
                public class HrbrainTalentProfileAttachmentQueryResponseBodyContentStaffAttachmentInfoListAttachmentInfoList : TeaModel {
                    [NameInMap("name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                    [NameInMap("url")]
                    [Validation(Required=false)]
                    public string Url { get; set; }

                }

                [NameInMap("workNo")]
                [Validation(Required=false)]
                public string WorkNo { get; set; }

            }

        }

        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("result")]
        [Validation(Required=false)]
        public bool? Result { get; set; }

        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
