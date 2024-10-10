// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkexclusive_1_0.Models
{
    public class ListByCodesResponseBody : TeaModel {
        [NameInMap("robotInfoList")]
        [Validation(Required=false)]
        public List<ListByCodesResponseBodyRobotInfoList> RobotInfoList { get; set; }
        public class ListByCodesResponseBodyRobotInfoList : TeaModel {
            [NameInMap("brief")]
            [Validation(Required=false)]
            public string Brief { get; set; }

            [NameInMap("code")]
            [Validation(Required=false)]
            public string Code { get; set; }

            [NameInMap("createAt")]
            [Validation(Required=false)]
            public long? CreateAt { get; set; }

            [NameInMap("description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            [NameInMap("dev")]
            [Validation(Required=false)]
            public string Dev { get; set; }

            [NameInMap("icon")]
            [Validation(Required=false)]
            public string Icon { get; set; }

            [NameInMap("modifiedAt")]
            [Validation(Required=false)]
            public long? ModifiedAt { get; set; }

            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            [NameInMap("outgoingToken")]
            [Validation(Required=false)]
            public string OutgoingToken { get; set; }

            [NameInMap("outgoingUrl")]
            [Validation(Required=false)]
            public string OutgoingUrl { get; set; }

            [NameInMap("previewMediaId")]
            [Validation(Required=false)]
            public string PreviewMediaId { get; set; }

            [NameInMap("sourceUrl")]
            [Validation(Required=false)]
            public string SourceUrl { get; set; }

            [NameInMap("status")]
            [Validation(Required=false)]
            public int? Status { get; set; }

        }

    }

}
