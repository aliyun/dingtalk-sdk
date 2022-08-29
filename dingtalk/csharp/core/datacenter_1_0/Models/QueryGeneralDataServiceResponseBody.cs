// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkdatacenter_1_0.Models
{
    public class QueryGeneralDataServiceResponseBody : TeaModel {
        /// <summary>
        /// 指标数据
        /// </summary>
        [NameInMap("dataList")]
        [Validation(Required=false)]
        public List<Dictionary<string, object>> DataList { get; set; }

        /// <summary>
        /// 指标元数据
        /// </summary>
        [NameInMap("metaList")]
        [Validation(Required=false)]
        public List<QueryGeneralDataServiceResponseBodyMetaList> MetaList { get; set; }
        public class QueryGeneralDataServiceResponseBodyMetaList : TeaModel {
            /// <summary>
            /// 指标名称
            /// </summary>
            [NameInMap("fieldDesc")]
            [Validation(Required=false)]
            public string FieldDesc { get; set; }

            /// <summary>
            /// 指标口径
            /// </summary>
            [NameInMap("fieldId")]
            [Validation(Required=false)]
            public string FieldId { get; set; }

            /// <summary>
            /// 指标ID
            /// </summary>
            [NameInMap("fieldName")]
            [Validation(Required=false)]
            public string FieldName { get; set; }

            /// <summary>
            /// 指标单位
            /// </summary>
            [NameInMap("fieldType")]
            [Validation(Required=false)]
            public string FieldType { get; set; }

        }

    }

}
