// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkyida_2_0.Models
{
    public class SaveAndUpdateMatrixDataRequest : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>dingxxxx</para>
        /// </summary>
        [NameInMap("corpId")]
        [Validation(Required=false)]
        public string CorpId { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[{ 	&quot;column_xx&quot;: &quot;deptId&quot;, 	&quot;column_yy&quot;: [&quot;userId&quot;], 	&quot;column_zz&quot;: &quot;项目一&quot;, 	&quot;rowId&quot;: &quot;row_1748398062718&quot; }, { 	&quot;column_xx&quot;: &quot;deptId&quot;, 	&quot;column_yy&quot;: [&quot;userId&quot;, &quot;userId&quot;], 	&quot;column_zz&quot;: &quot;项目二&quot; }]</para>
        /// </summary>
        [NameInMap("dataJson")]
        [Validation(Required=false)]
        public string DataJson { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>MATRIX-C8I4J40EM81XLWZH61ZK</para>
        /// </summary>
        [NameInMap("matrixId")]
        [Validation(Required=false)]
        public string MatrixId { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("token")]
        [Validation(Required=false)]
        public string Token { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>501453</para>
        /// </summary>
        [NameInMap("userId")]
        [Validation(Required=false)]
        public string UserId { get; set; }

    }

}
