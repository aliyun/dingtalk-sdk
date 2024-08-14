// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkdatacenter_1_0.Models
{
    public class QueryGeneralDataServiceResponseBody : TeaModel {
        [NameInMap("dataList")]
        [Validation(Required=false)]
        public List<Dictionary<string, object>> DataList { get; set; }

        [NameInMap("metaList")]
        [Validation(Required=false)]
        public List<QueryGeneralDataServiceResponseBodyMetaList> MetaList { get; set; }
        public class QueryGeneralDataServiceResponseBodyMetaList : TeaModel {
            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("fieldDesc")]
            [Validation(Required=false)]
            public string FieldDesc { get; set; }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("fieldId")]
            [Validation(Required=false)]
            public string FieldId { get; set; }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("fieldName")]
            [Validation(Required=false)]
            public string FieldName { get; set; }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("fieldType")]
            [Validation(Required=false)]
            public string FieldType { get; set; }

        }

        [NameInMap("total")]
        [Validation(Required=false)]
        public string Total { get; set; }

    }

}
