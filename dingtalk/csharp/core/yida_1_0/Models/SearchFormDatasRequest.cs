// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkyida_1_0.Models
{
    public class SearchFormDatasRequest : TeaModel {
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
        /// <para>2018-01-01</para>
        /// </summary>
        [NameInMap("createFromTimeGMT")]
        [Validation(Required=false)]
        public string CreateFromTimeGMT { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>2018-02-01</para>
        /// </summary>
        [NameInMap("createToTimeGMT")]
        [Validation(Required=false)]
        public string CreateToTimeGMT { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("currentPage")]
        [Validation(Required=false)]
        public int? CurrentPage { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>{&quot;numberField_1ac&quot;:&quot;+&quot;}, 表示按照字段numberField_1ac升序排列</para>
        /// </summary>
        [NameInMap("dynamicOrder")]
        [Validation(Required=false)]
        public string DynamicOrder { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>FORM-EF6Y4G8WO2FN0SUB43TDQ3CGC3FMFQ1G9400RCJ3</para>
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

        [NameInMap("logicOperator")]
        [Validation(Required=false)]
        public string LogicOperator { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>2018-01-01</para>
        /// </summary>
        [NameInMap("modifiedFromTimeGMT")]
        [Validation(Required=false)]
        public string ModifiedFromTimeGMT { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>2018-02-01</para>
        /// </summary>
        [NameInMap("modifiedToTimeGMT")]
        [Validation(Required=false)]
        public string ModifiedToTimeGMT { get; set; }

        [NameInMap("originatorId")]
        [Validation(Required=false)]
        public string OriginatorId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("pageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>{&quot;textField_jcr0069m&quot;:&quot;danhang&quot;,&quot;textareaField_jcr0069n&quot;:&quot;duohang&quot;,&quot;numberField_jcr0069o&quot;:[&quot;1&quot;,&quot;10&quot;],&quot;radioField_jcr0069p&quot;:&quot;选项一&quot;,&quot;selectField_jcr0069q&quot;:&quot;选项一&quot;,&quot;checkboxField_jcr0069r&quot;:[&quot;选项二&quot;],&quot;multiSelectField_jcr0069s&quot;:[&quot;选项二&quot;,&quot;选项三&quot;],&quot;dateField_jcr0069t&quot;:[1514736000000,1517414399000],&quot;cascadeDate_jcr0069u&quot;:[[1514736000000,1517414399000],[1514736000000,1517414399000]],&quot;employeeField_jcr0069x&quot;:[&quot;xxxxx&quot;],&quot;citySelectField_jcr0069y&quot;:[&quot;110000&quot;,&quot;110100&quot;,&quot;110101&quot;],&quot;departmentField_jcr0069z&quot;:1123456,&quot;cascadeSelectField_jcr006a0&quot;:[&quot;part&quot;,&quot;part_b&quot;],&quot;tableField_jcr006a1&quot;:&quot;明细数据&quot;}</para>
        /// </summary>
        [NameInMap("searchFieldJson")]
        [Validation(Required=false)]
        public string SearchFieldJson { get; set; }

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
        /// <para>173112212211</para>
        /// </summary>
        [NameInMap("userId")]
        [Validation(Required=false)]
        public string UserId { get; set; }

    }

}
