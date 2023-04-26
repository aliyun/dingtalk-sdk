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
                    [NameInMap("bizAlias")]
                    [Validation(Required=false)]
                    public string BizAlias { get; set; }

                    [NameInMap("fieldId")]
                    [Validation(Required=false)]
                    public string FieldId { get; set; }

                }

            }

            [NameInMap("headerFieldIds")]
            [Validation(Required=false)]
            public List<string> HeaderFieldIds { get; set; }

        }

    }

}
