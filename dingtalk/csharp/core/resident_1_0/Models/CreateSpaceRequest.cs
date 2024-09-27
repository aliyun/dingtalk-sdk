// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkresident_1_0.Models
{
    public class CreateSpaceRequest : TeaModel {
        [NameInMap("billingArea")]
        [Validation(Required=false)]
        public float? BillingArea { get; set; }

        [NameInMap("buildingArea")]
        [Validation(Required=false)]
        public float? BuildingArea { get; set; }

        [NameInMap("floor")]
        [Validation(Required=false)]
        public string Floor { get; set; }

        [NameInMap("houseState")]
        [Validation(Required=false)]
        public long? HouseState { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>A栋</para>
        /// </summary>
        [NameInMap("name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>-7</para>
        /// </summary>
        [NameInMap("parentDeptId")]
        [Validation(Required=false)]
        public string ParentDeptId { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>House</para>
        /// </summary>
        [NameInMap("tagCode")]
        [Validation(Required=false)]
        public string TagCode { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("type")]
        [Validation(Required=false)]
        public string Type { get; set; }

    }

}
