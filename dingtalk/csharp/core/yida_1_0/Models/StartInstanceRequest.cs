// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkyida_1_0.Models
{
    public class StartInstanceRequest : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>APP_PBKT0MFBEBTDO8T7SLVP</para>
        /// </summary>
        [NameInMap("appType")]
        [Validation(Required=false)]
        public string AppType { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>18295</para>
        /// </summary>
        [NameInMap("departmentId")]
        [Validation(Required=false)]
        public string DepartmentId { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;textField_jcpm6agt&quot;: &quot;单行&quot;,&quot;employeeField_jcos0sar&quot;: [&quot;workno&quot;]}</para>
        /// </summary>
        [NameInMap("formDataJson")]
        [Validation(Required=false)]
        public string FormDataJson { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>FORM-NJYJZELV8YZRDEI2N5IQ7L6VEDMR1VE9GMPCJB</para>
        /// </summary>
        [NameInMap("formUuid")]
        [Validation(Required=false)]
        public string FormUuid { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>zh_CN</para>
        /// </summary>
        [NameInMap("language")]
        [Validation(Required=false)]
        public string Language { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>TPROC--EF6Y4G8WO2FN0SUB43TDQ3CGC3FMFQ1G9400RCJ4</para>
        /// </summary>
        [NameInMap("processCode")]
        [Validation(Required=false)]
        public string ProcessCode { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>[{ 	&quot;key&quot;: &quot;__optionalApproval_node_ocltdztr2b1&quot;, 	&quot;value&quot;: [&quot;5014533041684350&quot;] }, { 	&quot;key&quot;: &quot;__optionalApproval_node_ocltdztr2b3&quot;, 	&quot;value&quot;: [&quot;5014533041684350&quot;, &quot;01536610064226180419&quot;] }, { 	&quot;key&quot;: &quot;__optionalApproval_node_oclte07cwn1&quot;, 	&quot;value&quot;: [&quot;01432910392321237660&quot;] }]</para>
        /// </summary>
        [NameInMap("processData")]
        [Validation(Required=false)]
        public string ProcessData { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>hexxx</para>
        /// </summary>
        [NameInMap("systemToken")]
        [Validation(Required=false)]
        public string SystemToken { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1731234567</para>
        /// </summary>
        [NameInMap("userId")]
        [Validation(Required=false)]
        public string UserId { get; set; }

    }

}
