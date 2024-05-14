// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkcrm_1_0.Models
{
    public class GetRelationUkSettingResponseBody : TeaModel {
        [NameInMap("result")]
        [Validation(Required=false)]
        public List<GetRelationUkSettingResponseBodyResult> Result { get; set; }
        public class GetRelationUkSettingResponseBodyResult : TeaModel {
            [NameInMap("bizAlias")]
            [Validation(Required=false)]
            public string BizAlias { get; set; }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("fieldId")]
            [Validation(Required=false)]
            public string FieldId { get; set; }

        }

    }

}
