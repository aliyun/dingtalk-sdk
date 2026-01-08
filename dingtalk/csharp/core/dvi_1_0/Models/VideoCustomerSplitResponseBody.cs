// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkdvi_1_0.Models
{
    public class VideoCustomerSplitResponseBody : TeaModel {
        [NameInMap("errorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        [NameInMap("errorMsg")]
        [Validation(Required=false)]
        public string ErrorMsg { get; set; }

        [NameInMap("result")]
        [Validation(Required=false)]
        public VideoCustomerSplitResponseBodyResult Result { get; set; }
        public class VideoCustomerSplitResponseBodyResult : TeaModel {
            [NameInMap("createServiceRecordResult")]
            [Validation(Required=false)]
            public List<VideoCustomerSplitResponseBodyResultCreateServiceRecordResult> CreateServiceRecordResult { get; set; }
            public class VideoCustomerSplitResponseBodyResultCreateServiceRecordResult : TeaModel {
                [NameInMap("recordIds")]
                [Validation(Required=false)]
                public List<string> RecordIds { get; set; }

                [NameInMap("segmentId")]
                [Validation(Required=false)]
                public string SegmentId { get; set; }

            }

        }

        [NameInMap("success")]
        [Validation(Required=false)]
        public string Success { get; set; }

    }

}
