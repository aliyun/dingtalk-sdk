// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkindustry_1_0.Models
{
    public class IndustryManufactureMesProductionPlanRequest : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>add</para>
        /// </summary>
        [NameInMap("action")]
        [Validation(Required=false)]
        public string Action { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>2021-03-12 00:00:00</para>
        /// </summary>
        [NameInMap("actualEndTime")]
        [Validation(Required=false)]
        public string ActualEndTime { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>2021-03-12 00:00:00</para>
        /// </summary>
        [NameInMap("actualStartTime")]
        [Validation(Required=false)]
        public string ActualStartTime { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>opsoft</para>
        /// </summary>
        [NameInMap("appKey")]
        [Validation(Required=false)]
        public string AppKey { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>productionplan</para>
        /// </summary>
        [NameInMap("baseDataName")]
        [Validation(Required=false)]
        public string BaseDataName { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>39C1E213-86B2-706B-9615-5B957DF8C15D</para>
        /// </summary>
        [NameInMap("bomUuid")]
        [Validation(Required=false)]
        public string BomUuid { get; set; }

        [NameInMap("events")]
        [Validation(Required=false)]
        public List<string> Events { get; set; }

        [NameInMap("extendData")]
        [Validation(Required=false)]
        public List<IndustryManufactureMesProductionPlanRequestExtendData> ExtendData { get; set; }
        public class IndustryManufactureMesProductionPlanRequestExtendData : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>staffName</para>
            /// </summary>
            [NameInMap("code")]
            [Validation(Required=false)]
            public string Code { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>生产人员</para>
            /// </summary>
            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>张三</para>
            /// </summary>
            [NameInMap("value")]
            [Validation(Required=false)]
            public string Value { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>string</para>
            /// </summary>
            [NameInMap("valueType")]
            [Validation(Required=false)]
            public string ValueType { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>20220509034</para>
        /// </summary>
        [NameInMap("no")]
        [Validation(Required=false)]
        public string No { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("overdue")]
        [Validation(Required=false)]
        public string Overdue { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>2021-03-12 00:00:00</para>
        /// </summary>
        [NameInMap("planEndTime")]
        [Validation(Required=false)]
        public string PlanEndTime { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>321</para>
        /// </summary>
        [NameInMap("planQuantity")]
        [Validation(Required=false)]
        public string PlanQuantity { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>2021-03-12 00:00:00</para>
        /// </summary>
        [NameInMap("planStartTime")]
        [Validation(Required=false)]
        public string PlanStartTime { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>{ TODO       &quot;uuid&quot;: &quot;1543878029722550273&quot;,       &quot;name&quot;: &quot;YF-钣金&quot;,       &quot;preProcess&quot;: &quot;&quot;     }</para>
        /// </summary>
        [NameInMap("processUuids")]
        [Validation(Required=false)]
        public string ProcessUuids { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>011351</para>
        /// </summary>
        [NameInMap("productCode")]
        [Validation(Required=false)]
        public string ProductCode { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>毛坯KM50三级盖</para>
        /// </summary>
        [NameInMap("productName")]
        [Validation(Required=false)]
        public string ProductName { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>KM50</para>
        /// </summary>
        [NameInMap("productSpecification")]
        [Validation(Required=false)]
        public string ProductSpecification { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>300</para>
        /// </summary>
        [NameInMap("qualifiedQuantity")]
        [Validation(Required=false)]
        public string QualifiedQuantity { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>sell20220509034</para>
        /// </summary>
        [NameInMap("sellOrderNo")]
        [Validation(Required=false)]
        public string SellOrderNo { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>WORKING</para>
        /// </summary>
        [NameInMap("status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>{     &quot;processId1&quot;: [&quot;teamId11&quot;, &quot;teamId12&quot;, &quot;teamId13&quot;],     &quot;processId2&quot;: [&quot;teamId21&quot;, &quot;teamId22&quot;, &quot;teamId23&quot;] }</para>
        /// </summary>
        [NameInMap("teamList")]
        [Validation(Required=false)]
        public string TeamList { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>毛坯KM50三级盖</para>
        /// </summary>
        [NameInMap("title")]
        [Validation(Required=false)]
        public string Title { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>NORMAL</para>
        /// </summary>
        [NameInMap("type")]
        [Validation(Required=false)]
        public string Type { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>个</para>
        /// </summary>
        [NameInMap("unit")]
        [Validation(Required=false)]
        public string Unit { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>39C1E213-86B2-706B-9615-5B957DF8C15D</para>
        /// </summary>
        [NameInMap("uuid")]
        [Validation(Required=false)]
        public string Uuid { get; set; }

    }

}
