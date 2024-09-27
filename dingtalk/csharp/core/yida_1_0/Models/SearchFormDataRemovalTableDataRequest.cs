// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkyida_1_0.Models
{
    public class SearchFormDataRemovalTableDataRequest : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>APP_XCE0EVXS6DYG3YDYC5RD</para>
        /// </summary>
        [NameInMap("appType")]
        [Validation(Required=false)]
        public string AppType { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>2021-05-01</para>
        /// </summary>
        [NameInMap("createFromTimeGMT")]
        [Validation(Required=false)]
        public string CreateFromTimeGMT { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>2021-05-01</para>
        /// </summary>
        [NameInMap("createToTimeGMT")]
        [Validation(Required=false)]
        public string CreateToTimeGMT { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>FORM-GX866MC1NC1VOFF6WVQW33FD16E23L3CPMKVKA</para>
        /// </summary>
        [NameInMap("formUuid")]
        [Validation(Required=false)]
        public string FormUuid { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>2021-05-01</para>
        /// </summary>
        [NameInMap("modifiedFromTimeGMT")]
        [Validation(Required=false)]
        public string ModifiedFromTimeGMT { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>2021-09-10</para>
        /// </summary>
        [NameInMap("modifiedToTimeGMT")]
        [Validation(Required=false)]
        public string ModifiedToTimeGMT { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>示例: 按照创建时间和文本组件值做升序排序则填写 {&quot;gmt_create&quot;:&quot;+&quot;,&quot;textField_1234&quot;:&quot;+&quot;}。详情参考 <a href="https://www.yuque.com/yida/support/agb8im#CQro8">https://www.yuque.com/yida/support/agb8im#CQro8</a></para>
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

        /// <summary>
        /// <b>Example:</b>
        /// <para>支持2种检索规则{&quot;numberField_l0c1cwiu&quot;:1}或者[{&quot;key&quot;:&quot;currentNodeName&quot;,&quot;value&quot;:&quot;步凡&quot;,&quot;type&quot;:&quot;TEXT&quot;,&quot;operator&quot;:&quot;like&quot;,&quot;componentName&quot;:&quot;TextField&quot;}], 前一种规则仅仅做模糊匹配无法设置精确匹配, 第二种可以设置精确匹配条件。详情参考 <a href="https://www.yuque.com/yida/support/agb8im#F4S8e">https://www.yuque.com/yida/support/agb8im#F4S8e</a></para>
        /// </summary>
        [NameInMap("searchFieldJson")]
        [Validation(Required=false)]
        public string SearchFieldJson { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>09866181UTZVVD4R3DC955FNKIM52HVPU5WWK7</para>
        /// </summary>
        [NameInMap("systemToken")]
        [Validation(Required=false)]
        public string SystemToken { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ding173982232112232</para>
        /// </summary>
        [NameInMap("userId")]
        [Validation(Required=false)]
        public string UserId { get; set; }

    }

}
