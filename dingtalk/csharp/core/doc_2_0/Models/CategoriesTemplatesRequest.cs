// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkdoc_2_0.Models
{
    public class CategoriesTemplatesRequest : TeaModel {
        [NameInMap("option")]
        [Validation(Required=false)]
        public CategoriesTemplatesRequestOption Option { get; set; }
        public class CategoriesTemplatesRequestOption : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("categoryStatus")]
            [Validation(Required=false)]
            public int? CategoryStatus { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>pc</para>
            /// </summary>
            [NameInMap("queryPlatform")]
            [Validation(Required=false)]
            public string QueryPlatform { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("size")]
            [Validation(Required=false)]
            public int? Size { get; set; }

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
        public CategoriesTemplatesRequestParam Param { get; set; }
        public class CategoriesTemplatesRequestParam : TeaModel {
            /// <summary>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>categoryIds</para>
            /// </summary>
            [NameInMap("categoryIds")]
            [Validation(Required=false)]
            public List<string> CategoryIds { get; set; }

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
