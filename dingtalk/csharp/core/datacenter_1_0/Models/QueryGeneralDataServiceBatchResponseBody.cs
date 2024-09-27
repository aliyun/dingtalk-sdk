// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkdatacenter_1_0.Models
{
    public class QueryGeneralDataServiceBatchResponseBody : TeaModel {
        [NameInMap("dataList")]
        [Validation(Required=false)]
        public List<Dictionary<string, object>> DataList { get; set; }

        [NameInMap("metaList")]
        [Validation(Required=false)]
        public List<QueryGeneralDataServiceBatchResponseBodyMetaList> MetaList { get; set; }
        public class QueryGeneralDataServiceBatchResponseBodyMetaList : TeaModel {
            /// <summary>
            /// <para>This parameter is required.</para>
            /// </summary>
            [NameInMap("fieldDesc")]
            [Validation(Required=false)]
            public string FieldDesc { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// </summary>
            [NameInMap("fieldId")]
            [Validation(Required=false)]
            public string FieldId { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// </summary>
            [NameInMap("fieldName")]
            [Validation(Required=false)]
            public string FieldName { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// </summary>
            [NameInMap("fieldType")]
            [Validation(Required=false)]
            public string FieldType { get; set; }

        }

        [NameInMap("total")]
        [Validation(Required=false)]
        public long? Total { get; set; }

    }

}
