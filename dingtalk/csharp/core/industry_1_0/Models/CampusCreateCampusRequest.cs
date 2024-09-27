// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkindustry_1_0.Models
{
    public class CampusCreateCampusRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>锦城街道和谐社区101号</para>
        /// </summary>
        [NameInMap("address")]
        [Validation(Required=false)]
        public string Address { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>5200.13（平方千米）</para>
        /// </summary>
        [NameInMap("area")]
        [Validation(Required=false)]
        public double? Area { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("belongProjectGroupId")]
        [Validation(Required=false)]
        public long? BelongProjectGroupId { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>绿城未来park</para>
        /// </summary>
        [NameInMap("campusName")]
        [Validation(Required=false)]
        public string CampusName { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1000</para>
        /// </summary>
        [NameInMap("capacity")]
        [Validation(Required=false)]
        public int? Capacity { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>371500</para>
        /// </summary>
        [NameInMap("cityId")]
        [Validation(Required=false)]
        public int? CityId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>中国</para>
        /// </summary>
        [NameInMap("country")]
        [Validation(Required=false)]
        public string Country { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>371502</para>
        /// </summary>
        [NameInMap("countyId")]
        [Validation(Required=false)]
        public int? CountyId { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("creatorUnionId")]
        [Validation(Required=false)]
        public string CreatorUnionId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>绿城未来park项目</para>
        /// </summary>
        [NameInMap("description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>{&quot;creator&quot;:&quot;dsy&quot;}</para>
        /// </summary>
        [NameInMap("extend")]
        [Validation(Required=false)]
        public string Extend { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>123,456</para>
        /// </summary>
        [NameInMap("location")]
        [Validation(Required=false)]
        public string Location { get; set; }

        [NameInMap("orderEndTime")]
        [Validation(Required=false)]
        public long? OrderEndTime { get; set; }

        [NameInMap("orderInfo")]
        [Validation(Required=false)]
        public string OrderInfo { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1655704317794</para>
        /// </summary>
        [NameInMap("orderStartTime")]
        [Validation(Required=false)]
        public long? OrderStartTime { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>370000（山东）</para>
        /// </summary>
        [NameInMap("provId")]
        [Validation(Required=false)]
        public int? ProvId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>156xxxx4338</para>
        /// </summary>
        [NameInMap("telephone")]
        [Validation(Required=false)]
        public string Telephone { get; set; }

    }

}
