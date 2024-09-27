// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkmanufacturing_1_0.Models
{
    public class IndustrializeManufactureJobBookRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>ding2fff8349a3ae0105d</para>
        /// </summary>
        [NameInMap("corpId")]
        [Validation(Required=false)]
        public string CorpId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>[     { 		&quot;code&quot;: &quot;equipmentName&quot;， 		&quot;name&quot;: &quot;设备名称&quot;, 		&quot;value&quot;: &quot;8000&quot;, 		&quot;valueType&quot;: &quot;类型：字符串，数字等&quot; 	}, { 		&quot;code&quot;: &quot;唯一标识&quot;， 		&quot;name&quot;: &quot;自定义字段1&quot;, 		&quot;value&quot;: &quot;值&quot;, 		&quot;valueType&quot;: &quot;类型：字符串，数字等&quot; 	}, { 		&quot;code&quot;: &quot;唯一标识&quot;， 		&quot;name&quot;: &quot;自定义字段2&quot;, 		&quot;value&quot;: &quot;值&quot;, 		&quot;valueType&quot;: &quot;类型：字符串，数字等&quot; 	}  ]</para>
        /// </summary>
        [NameInMap("extend")]
        [Validation(Required=false)]
        public string Extend { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("instNo")]
        [Validation(Required=false)]
        public string InstNo { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>n</para>
        /// </summary>
        [NameInMap("isBatchJob")]
        [Validation(Required=false)]
        public string IsBatchJob { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2021-07-05 08:00:21</para>
        /// </summary>
        [NameInMap("manufactureDate")]
        [Validation(Required=false)]
        public string ManufactureDate { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("mesAppKey")]
        [Validation(Required=false)]
        public string MesAppKey { get; set; }

        [NameInMap("processEnName")]
        [Validation(Required=false)]
        public string ProcessEnName { get; set; }

        [NameInMap("processName")]
        [Validation(Required=false)]
        public string ProcessName { get; set; }

        [NameInMap("productCode")]
        [Validation(Required=false)]
        public string ProductCode { get; set; }

        [NameInMap("productEnName")]
        [Validation(Required=false)]
        public string ProductEnName { get; set; }

        [NameInMap("productName")]
        [Validation(Required=false)]
        public string ProductName { get; set; }

        [NameInMap("productSpecification")]
        [Validation(Required=false)]
        public string ProductSpecification { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("qualifiedQuantity")]
        [Validation(Required=false)]
        public string QualifiedQuantity { get; set; }

        [NameInMap("reworkableQuantity")]
        [Validation(Required=false)]
        public string ReworkableQuantity { get; set; }

        [NameInMap("scrappedQuantity")]
        [Validation(Required=false)]
        public string ScrappedQuantity { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1.02</para>
        /// </summary>
        [NameInMap("unitPrice")]
        [Validation(Required=false)]
        public string UnitPrice { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1919442747879777, 1919442747879774</para>
        /// </summary>
        [NameInMap("userIdList")]
        [Validation(Required=false)]
        public string UserIdList { get; set; }

        [NameInMap("userName")]
        [Validation(Required=false)]
        public string UserName { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>张三,李四</para>
        /// </summary>
        [NameInMap("userNameList")]
        [Validation(Required=false)]
        public string UserNameList { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("uuid")]
        [Validation(Required=false)]
        public string Uuid { get; set; }

    }

}
