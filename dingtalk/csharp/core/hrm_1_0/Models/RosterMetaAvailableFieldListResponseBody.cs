// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkhrm_1_0.Models
{
    public class RosterMetaAvailableFieldListResponseBody : TeaModel {
        [NameInMap("result")]
        [Validation(Required=false)]
        public List<RosterMetaAvailableFieldListResponseBodyResult> Result { get; set; }
        public class RosterMetaAvailableFieldListResponseBodyResult : TeaModel {
            /// <summary>
            /// 字段标识
            /// </summary>
            [NameInMap("fieldCode")]
            [Validation(Required=false)]
            public string FieldCode { get; set; }

            /// <summary>
            /// 字段名称
            /// </summary>
            [NameInMap("fieldName")]
            [Validation(Required=false)]
            public string FieldName { get; set; }

            /// <summary>
            /// 字段类型
            /// </summary>
            [NameInMap("fieldType")]
            [Validation(Required=false)]
            public string FieldType { get; set; }

        }

    }

}
