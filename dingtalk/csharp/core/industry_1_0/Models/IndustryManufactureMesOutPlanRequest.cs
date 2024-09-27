// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkindustry_1_0.Models
{
    public class IndustryManufactureMesOutPlanRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>APPROVING</para>
        /// </summary>
        [NameInMap("approvalStatus")]
        [Validation(Required=false)]
        public string ApprovalStatus { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>[{&quot;userId&quot;:&quot;123&quot;,&quot;name&quot;:&quot;汉俊&quot;}]</para>
        /// </summary>
        [NameInMap("approver")]
        [Validation(Required=false)]
        public string Approver { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>wwPlan</para>
        /// </summary>
        [NameInMap("baseDataName")]
        [Validation(Required=false)]
        public string BaseDataName { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>WWJH-20220728</para>
        /// </summary>
        [NameInMap("outSourceProjectCode")]
        [Validation(Required=false)]
        public string OutSourceProjectCode { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>cid34444</para>
        /// </summary>
        [NameInMap("outSourceTeamId")]
        [Validation(Required=false)]
        public string OutSourceTeamId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>321</para>
        /// </summary>
        [NameInMap("price")]
        [Validation(Required=false)]
        public string Price { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>20220728_OP20</para>
        /// </summary>
        [NameInMap("processIdentificationCode")]
        [Validation(Required=false)]
        public string ProcessIdentificationCode { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>[{       &quot;uuid&quot;: &quot;1543878029936459777&quot;,       &quot;name&quot;: &quot;YF-盐雾&quot;,       &quot;preProcess&quot;: &quot;1470231820594245633&quot;     }]</para>
        /// </summary>
        [NameInMap("processUuids")]
        [Validation(Required=false)]
        public string ProcessUuids { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>WL12345</para>
        /// </summary>
        [NameInMap("productCode")]
        [Validation(Required=false)]
        public string ProductCode { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>毛坯KM63三级盖</para>
        /// </summary>
        [NameInMap("productName")]
        [Validation(Required=false)]
        public string ProductName { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>5/16*13.5</para>
        /// </summary>
        [NameInMap("productSpecification")]
        [Validation(Required=false)]
        public string ProductSpecification { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>20220728_001</para>
        /// </summary>
        [NameInMap("projectCode")]
        [Validation(Required=false)]
        public string ProjectCode { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>20220728_001</para>
        /// </summary>
        [NameInMap("projectId")]
        [Validation(Required=false)]
        public string ProjectId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>321</para>
        /// </summary>
        [NameInMap("sendPlanQuantity")]
        [Validation(Required=false)]
        public string SendPlanQuantity { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>GX002</para>
        /// </summary>
        [NameInMap("supplierCode")]
        [Validation(Required=false)]
        public string SupplierCode { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>北京供应</para>
        /// </summary>
        [NameInMap("supplierName")]
        [Validation(Required=false)]
        public string SupplierName { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("totalWage")]
        [Validation(Required=false)]
        public string TotalWage { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>C1E213-86B2-706B-9615-5B957DF8C15D</para>
        /// </summary>
        [NameInMap("uuid")]
        [Validation(Required=false)]
        public string Uuid { get; set; }

    }

}
