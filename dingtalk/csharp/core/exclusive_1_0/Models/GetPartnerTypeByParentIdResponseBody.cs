// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkexclusive_1_0.Models
{
    public class GetPartnerTypeByParentIdResponseBody : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("data")]
        [Validation(Required=false)]
        public List<GetPartnerTypeByParentIdResponseBodyData> Data { get; set; }
        public class GetPartnerTypeByParentIdResponseBodyData : TeaModel {
            /// <summary>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1234</para>
            /// </summary>
            [NameInMap("labelId")]
            [Validation(Required=false)]
            public string LabelId { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>目前无意义</para>
            /// </summary>
            [NameInMap("typeId")]
            [Validation(Required=false)]
            public float? TypeId { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>经销商</para>
            /// </summary>
            [NameInMap("typeName")]
            [Validation(Required=false)]
            public string TypeName { get; set; }

        }

    }

}
