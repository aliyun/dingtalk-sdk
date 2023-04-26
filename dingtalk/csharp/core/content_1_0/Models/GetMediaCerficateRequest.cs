// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkcontent_1_0.Models
{
    public class GetMediaCerficateRequest : TeaModel {
        [NameInMap("fileName")]
        [Validation(Required=false)]
        public string FileName { get; set; }

        [NameInMap("mcnId")]
        [Validation(Required=false)]
        public string McnId { get; set; }

        [NameInMap("mediaId")]
        [Validation(Required=false)]
        public string MediaId { get; set; }

        [NameInMap("mediaIntroduction")]
        [Validation(Required=false)]
        public string MediaIntroduction { get; set; }

        [NameInMap("mediaTitle")]
        [Validation(Required=false)]
        public string MediaTitle { get; set; }

        [NameInMap("thumbUrl")]
        [Validation(Required=false)]
        public string ThumbUrl { get; set; }

        [NameInMap("userId")]
        [Validation(Required=false)]
        public string UserId { get; set; }

    }

}
