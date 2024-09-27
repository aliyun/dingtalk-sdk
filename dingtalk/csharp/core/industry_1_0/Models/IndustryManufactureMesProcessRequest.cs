// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkindustry_1_0.Models
{
    public class IndustryManufactureMesProcessRequest : TeaModel {
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
        /// <para>process</para>
        /// </summary>
        [NameInMap("baseDataName")]
        [Validation(Required=false)]
        public string BaseDataName { get; set; }

        [NameInMap("extendData")]
        [Validation(Required=false)]
        public List<IndustryManufactureMesProcessRequestExtendData> ExtendData { get; set; }
        public class IndustryManufactureMesProcessRequestExtendData : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>username</para>
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
            /// <para>李四</para>
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
        /// <para>打磨</para>
        /// </summary>
        [NameInMap("name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>y</para>
        /// </summary>
        [NameInMap("needDispatch")]
        [Validation(Required=false)]
        public string NeedDispatch { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>n</para>
        /// </summary>
        [NameInMap("needQualityTest")]
        [Validation(Required=false)]
        public string NeedQualityTest { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>011354</para>
        /// </summary>
        [NameInMap("no")]
        [Validation(Required=false)]
        public string No { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>0.21</para>
        /// </summary>
        [NameInMap("price")]
        [Validation(Required=false)]
        public string Price { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>自制</para>
        /// </summary>
        [NameInMap("prop")]
        [Validation(Required=false)]
        public string Prop { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>这里是备注</para>
        /// </summary>
        [NameInMap("remark")]
        [Validation(Required=false)]
        public string Remark { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>止口面攻牙的操作方法</para>
        /// </summary>
        [NameInMap("sop")]
        [Validation(Required=false)]
        public string Sop { get; set; }

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
