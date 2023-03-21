// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkcrm_2_0.Models
{
    public class GetRelationUkSettingResponseBody : TeaModel {
        [NameInMap("result")]
        [Validation(Required=false)]
        public GetRelationUkSettingResponseBodyResult Result { get; set; }
        public class GetRelationUkSettingResponseBodyResult : TeaModel {
            [NameInMap("formUkSettings")]
            [Validation(Required=false)]
            public List<GetRelationUkSettingResponseBodyResultFormUkSettings> FormUkSettings { get; set; }
            public class GetRelationUkSettingResponseBodyResultFormUkSettings : TeaModel {
                [NameInMap("fieldList")]
                [Validation(Required=false)]
                public List<GetRelationUkSettingResponseBodyResultFormUkSettingsFieldList> FieldList { get; set; }
                public class GetRelationUkSettingResponseBodyResultFormUkSettingsFieldList : TeaModel {
                    /// <summary>
                    /// 查重字段的bizAlias。
                    /// </summary>
                    [NameInMap("bizAlias")]
                    [Validation(Required=false)]
                    public string BizAlias { get; set; }

                    /// <summary>
                    /// 查重字段的字段id。
                    /// </summary>
                    [NameInMap("fieldId")]
                    [Validation(Required=false)]
                    public string FieldId { get; set; }

                }

            }

            /// <summary>
            /// 查重列表表头字段id列表。
            /// </summary>
            [NameInMap("headerFieldIds")]
            [Validation(Required=false)]
            public List<string> HeaderFieldIds { get; set; }

        }

    }

}
