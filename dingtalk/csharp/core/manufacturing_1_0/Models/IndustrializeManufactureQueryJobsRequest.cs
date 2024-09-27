// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkmanufacturing_1_0.Models
{
    public class IndustrializeManufactureQueryJobsRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("currentPage")]
        [Validation(Required=false)]
        public int? CurrentPage { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>d41d8cd98f00b204e9800998ecf8427e</para>
        /// </summary>
        [NameInMap("instNo")]
        [Validation(Required=false)]
        public string InstNo { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>2021-07-05</para>
        /// </summary>
        [NameInMap("manufactureDay")]
        [Validation(Required=false)]
        public string ManufactureDay { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>mes41d8cd98f00b204e9800998ecf8427e</para>
        /// </summary>
        [NameInMap("mesAppKey")]
        [Validation(Required=false)]
        public string MesAppKey { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("pageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("processName")]
        [Validation(Required=false)]
        public string ProcessName { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>A001</para>
        /// </summary>
        [NameInMap("productCode")]
        [Validation(Required=false)]
        public string ProductCode { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>双头螺柱001</para>
        /// </summary>
        [NameInMap("productName")]
        [Validation(Required=false)]
        public string ProductName { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>M56<em>3</em>10501</para>
        /// </summary>
        [NameInMap("productSpecification")]
        [Validation(Required=false)]
        public string ProductSpecification { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("qualifiedQuantity")]
        [Validation(Required=false)]
        public string QualifiedQuantity { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1.2</para>
        /// </summary>
        [NameInMap("unitPrice")]
        [Validation(Required=false)]
        public string UnitPrice { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1919442747879773</para>
        /// </summary>
        [NameInMap("userId")]
        [Validation(Required=false)]
        public string UserId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>111,222</para>
        /// </summary>
        [NameInMap("userIdList")]
        [Validation(Required=false)]
        public string UserIdList { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>张三</para>
        /// </summary>
        [NameInMap("userName")]
        [Validation(Required=false)]
        public string UserName { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>d41d8cd98f00b204e9800998ecf8427e</para>
        /// </summary>
        [NameInMap("uuid")]
        [Validation(Required=false)]
        public string Uuid { get; set; }

    }

}
