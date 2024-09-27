// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkindustry_1_0.Models
{
    public class IndustryManufactureMesMaterialRequest : TeaModel {
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
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>opsoft</para>
        /// </summary>
        [NameInMap("appKey")]
        [Validation(Required=false)]
        public string AppKey { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>material</para>
        /// </summary>
        [NameInMap("baseDataName")]
        [Validation(Required=false)]
        public string BaseDataName { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>紧压白茶,白茶,红茶</para>
        /// </summary>
        [NameInMap("category")]
        [Validation(Required=false)]
        public string Category { get; set; }

        /// <summary>
        /// <b>if can be null:</b>
        /// <c>true</c>
        /// </summary>
        [NameInMap("extendData")]
        [Validation(Required=false)]
        public List<IndustryManufactureMesMaterialRequestExtendData> ExtendData { get; set; }
        public class IndustryManufactureMesMaterialRequestExtendData : TeaModel {
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
        /// <para>20220509028</para>
        /// </summary>
        [NameInMap("productCode")]
        [Validation(Required=false)]
        public string ProductCode { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>毛坯SNR47端盖</para>
        /// </summary>
        [NameInMap("productName")]
        [Validation(Required=false)]
        public string ProductName { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>KM63</para>
        /// </summary>
        [NameInMap("productSpecification")]
        [Validation(Required=false)]
        public string ProductSpecification { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>原材料</para>
        /// </summary>
        [NameInMap("prop")]
        [Validation(Required=false)]
        public string Prop { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>件</para>
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
