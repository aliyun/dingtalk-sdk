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
            /// <summary>
            /// 查重字段的bizAlias
            /// </summary>
            [NameInMap("bizAlias")]
            [Validation(Required=false)]
            public string BizAlias { get; set; }

            /// <summary>
            /// 查重字段的字段id
            /// </summary>
            [NameInMap("fieldId")]
            [Validation(Required=false)]
            public string FieldId { get; set; }

        }

    }

}
