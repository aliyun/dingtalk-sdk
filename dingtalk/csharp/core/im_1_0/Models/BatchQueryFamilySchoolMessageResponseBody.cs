// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkim_1_0.Models
{
    public class BatchQueryFamilySchoolMessageResponseBody : TeaModel {
        [NameInMap("messages")]
        [Validation(Required=false)]
        public List<BatchQueryFamilySchoolMessageResponseBodyMessages> Messages { get; set; }
        public class BatchQueryFamilySchoolMessageResponseBodyMessages : TeaModel {
            [NameInMap("contentType")]
            [Validation(Required=false)]
            public int? ContentType { get; set; }

            [NameInMap("createAt")]
            [Validation(Required=false)]
            public long? CreateAt { get; set; }

            [NameInMap("mediaModels")]
            [Validation(Required=false)]
            public List<BatchQueryFamilySchoolMessageResponseBodyMessagesMediaModels> MediaModels { get; set; }
            public class BatchQueryFamilySchoolMessageResponseBodyMessagesMediaModels : TeaModel {
                [NameInMap("fileName")]
                [Validation(Required=false)]
                public string FileName { get; set; }

                [NameInMap("fileType")]
                [Validation(Required=false)]
                public string FileType { get; set; }

                [NameInMap("mediaId")]
                [Validation(Required=false)]
                public string MediaId { get; set; }

                [NameInMap("size")]
                [Validation(Required=false)]
                public string Size { get; set; }

                [NameInMap("url")]
                [Validation(Required=false)]
                public string Url { get; set; }

                [NameInMap("videoPicMediaId")]
                [Validation(Required=false)]
                public string VideoPicMediaId { get; set; }

            }

            [NameInMap("openMsgId")]
            [Validation(Required=false)]
            public string OpenMsgId { get; set; }

        }

    }

}
