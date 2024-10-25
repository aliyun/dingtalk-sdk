// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkexclusive_1_0.Models
{
    public class SetOrgTopConversationCategoryRequest : TeaModel {
        [NameInMap("body")]
        [Validation(Required=false)]
        public List<SetOrgTopConversationCategoryRequestBody> Body { get; set; }
        public class SetOrgTopConversationCategoryRequestBody : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>123111</para>
            /// </summary>
            [NameInMap("categoryId")]
            [Validation(Required=false)]
            public long? CategoryId { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>重要保障</para>
            /// </summary>
            [NameInMap("categoryName")]
            [Validation(Required=false)]
            public string CategoryName { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("order")]
            [Validation(Required=false)]
            public int? Order { get; set; }

        }

    }

}
