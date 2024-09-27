// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkdoc_2_0.Models
{
    public class CategoryTemplatesRequest : TeaModel {
        [NameInMap("option")]
        [Validation(Required=false)]
        public CategoryTemplatesRequestOption Option { get; set; }
        public class CategoryTemplatesRequestOption : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("categoryStatus")]
            [Validation(Required=false)]
            public int? CategoryStatus { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("templateStatus")]
            [Validation(Required=false)]
            public int? TemplateStatus { get; set; }

        }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("param")]
        [Validation(Required=false)]
        public CategoryTemplatesRequestParam Param { get; set; }
        public class CategoryTemplatesRequestParam : TeaModel {
            /// <summary>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>categoryId</para>
            /// </summary>
            [NameInMap("categoryId")]
            [Validation(Required=false)]
            public string CategoryId { get; set; }

        }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>union_id</para>
        /// </summary>
        [NameInMap("operatorId")]
        [Validation(Required=false)]
        public string OperatorId { get; set; }

    }

}
