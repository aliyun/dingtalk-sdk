// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkyida_2_0.Models
{
    public class GetInstancesRequest : TeaModel {
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
        /// <para>agree</para>
        /// </summary>
        [NameInMap("approvedResult")]
        [Validation(Required=false)]
        public string ApprovedResult { get; set; }

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
        /// <para>RUNNING</para>
        /// </summary>
        [NameInMap("instanceStatus")]
        [Validation(Required=false)]
        public string InstanceStatus { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>zh_CN</para>
        /// </summary>
        [NameInMap("language")]
        [Validation(Required=false)]
        public string Language { get; set; }

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

        /// <summary>
        /// <b>Example:</b>
        /// <para>例如按照创建时间升序再按照文本组件值升序排序则填{&quot;gmt_create&quot;:&quot;+&quot;,&quot;textField_1234&quot;:&quot;+&quot;} ，详情参考 <a href="https://www.yuque.com/yida/support/agb8im#CQro8">https://www.yuque.com/yida/support/agb8im#CQro8</a></para>
        /// </summary>
        [NameInMap("orderConfigJson")]
        [Validation(Required=false)]
        public string OrderConfigJson { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>manager123</para>
        /// </summary>
        [NameInMap("originatorId")]
        [Validation(Required=false)]
        public string OriginatorId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>模式1：根据组件值模糊匹配，示例：{&quot;textField_jcr0069m&quot;:&quot;danhang&quot;,&quot;selectField_jcr0069q&quot;:&quot;K&quot;}     模式2: 采用数据管理的查询过滤条件，匹配功能更强大，示例：[{&quot;key&quot;:&quot;currentNodeName&quot;,&quot;value&quot;:&quot;步凡&quot;,&quot;type&quot;:&quot;TEXT&quot;,&quot;operator&quot;:&quot;like&quot;,&quot;componentName&quot;:&quot;TextField”}]，详情参考  <a href="https://www.yuque.com/yida/support/agb8im#F4S8e">https://www.yuque.com/yida/support/agb8im#F4S8e</a></para>
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
        /// <b>Example:</b>
        /// <para>2199132092</para>
        /// </summary>
        [NameInMap("taskId")]
        [Validation(Required=false)]
        public string TaskId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("useAlias")]
        [Validation(Required=false)]
        public bool? UseAlias { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("userId")]
        [Validation(Required=false)]
        public string UserId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("pageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("pageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

    }

}
