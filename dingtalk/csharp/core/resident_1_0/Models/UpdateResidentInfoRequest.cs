// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkresident_1_0.Models
{
    public class UpdateResidentInfoRequest : TeaModel {
        [NameInMap("address")]
        [Validation(Required=false)]
        public string Address { get; set; }

        [NameInMap("buildingArea")]
        [Validation(Required=false)]
        public float? BuildingArea { get; set; }

        [NameInMap("cityName")]
        [Validation(Required=false)]
        public string CityName { get; set; }

        [NameInMap("communityType")]
        [Validation(Required=false)]
        public long? CommunityType { get; set; }

        [NameInMap("countyName")]
        [Validation(Required=false)]
        public string CountyName { get; set; }

        [NameInMap("location")]
        [Validation(Required=false)]
        public string Location { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>测试小区1</para>
        /// </summary>
        [NameInMap("name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        [NameInMap("provName")]
        [Validation(Required=false)]
        public string ProvName { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("state")]
        [Validation(Required=false)]
        public long? State { get; set; }

        [NameInMap("telephone")]
        [Validation(Required=false)]
        public string Telephone { get; set; }

    }

}
