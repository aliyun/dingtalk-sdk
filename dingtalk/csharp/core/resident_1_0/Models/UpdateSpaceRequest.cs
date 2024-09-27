// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkresident_1_0.Models
{
    public class UpdateSpaceRequest : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>A栋</para>
        /// </summary>
        [NameInMap("spaceInfoVOList")]
        [Validation(Required=false)]
        public List<UpdateSpaceRequestSpaceInfoVOList> SpaceInfoVOList { get; set; }
        public class UpdateSpaceRequestSpaceInfoVOList : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>123.4</para>
            /// </summary>
            [NameInMap("billingArea")]
            [Validation(Required=false)]
            public float? BillingArea { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>123.4</para>
            /// </summary>
            [NameInMap("buildingArea")]
            [Validation(Required=false)]
            public float? BuildingArea { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>当tagcode为Building的时候必填</para>
            /// </summary>
            [NameInMap("buildingType")]
            [Validation(Required=false)]
            public long? BuildingType { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10005</para>
            /// </summary>
            [NameInMap("deptId")]
            [Validation(Required=false)]
            public long? DeptId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>12</para>
            /// </summary>
            [NameInMap("floor")]
            [Validation(Required=false)]
            public string Floor { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("houseState")]
            [Validation(Required=false)]
            public long? HouseState { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("houseType")]
            [Validation(Required=false)]
            public long? HouseType { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>二单元</para>
            /// </summary>
            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            [NameInMap("parentDeptId")]
            [Validation(Required=false)]
            public long? ParentDeptId { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>空间类型标签code，House/Unit/Building/Partition</para>
            /// </summary>
            [NameInMap("tagCode")]
            [Validation(Required=false)]
            public string TagCode { get; set; }

        }

    }

}
