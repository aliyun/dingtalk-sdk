// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkcrm_1_0.Models
{
    public class GetRelationUkSettingResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("result")]
        [Validation(Required=false)]
        public List<GetRelationUkSettingResponseBodyResult> Result { get; set; }
        public class GetRelationUkSettingResponseBodyResult : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>customer_name</para>
            /// </summary>
            [NameInMap("bizAlias")]
            [Validation(Required=false)]
            public string BizAlias { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>TextField_U2K5A122</para>
            /// </summary>
            [NameInMap("fieldId")]
            [Validation(Required=false)]
            public string FieldId { get; set; }

        }

    }

}
