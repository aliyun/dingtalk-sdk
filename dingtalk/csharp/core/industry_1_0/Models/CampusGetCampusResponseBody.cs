// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkindustry_1_0.Models
{
    public class CampusGetCampusResponseBody : TeaModel {
        /// <summary>
        /// 详细地址
        /// </summary>
        [NameInMap("address")]
        [Validation(Required=false)]
        public string Address { get; set; }

        /// <summary>
        /// 面积
        /// </summary>
        [NameInMap("area")]
        [Validation(Required=false)]
        public double? Area { get; set; }

        /// <summary>
        /// 项目组ID
        /// </summary>
        [NameInMap("belongProjectGroupId")]
        [Validation(Required=false)]
        public string BelongProjectGroupId { get; set; }

        /// <summary>
        /// 园区组织ID
        /// </summary>
        [NameInMap("campusCorpId")]
        [Validation(Required=false)]
        public string CampusCorpId { get; set; }

        /// <summary>
        /// 园区部门ID
        /// </summary>
        [NameInMap("campusDeptId")]
        [Validation(Required=false)]
        public long? CampusDeptId { get; set; }

        /// <summary>
        /// 园区名称
        /// </summary>
        [NameInMap("campusName")]
        [Validation(Required=false)]
        public string CampusName { get; set; }

        /// <summary>
        /// 容纳人数
        /// </summary>
        [NameInMap("capacity")]
        [Validation(Required=false)]
        public string Capacity { get; set; }

        /// <summary>
        /// 市
        /// </summary>
        [NameInMap("cityId")]
        [Validation(Required=false)]
        public int? CityId { get; set; }

        /// <summary>
        /// 国家
        /// </summary>
        [NameInMap("country")]
        [Validation(Required=false)]
        public string Country { get; set; }

        /// <summary>
        /// 区
        /// </summary>
        [NameInMap("countyId")]
        [Validation(Required=false)]
        public int? CountyId { get; set; }

        /// <summary>
        /// 描述
        /// </summary>
        [NameInMap("description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// 扩展属性
        /// </summary>
        [NameInMap("extend")]
        [Validation(Required=false)]
        public string Extend { get; set; }

        /// <summary>
        /// 经纬度
        /// </summary>
        [NameInMap("location")]
        [Validation(Required=false)]
        public string Location { get; set; }

        /// <summary>
        /// 过期时间
        /// </summary>
        [NameInMap("orderEndTime")]
        [Validation(Required=false)]
        public long? OrderEndTime { get; set; }

        /// <summary>
        /// 购买信息
        /// </summary>
        [NameInMap("orderInfo")]
        [Validation(Required=false)]
        public string OrderInfo { get; set; }

        /// <summary>
        /// 订购时间
        /// </summary>
        [NameInMap("orderStartTime")]
        [Validation(Required=false)]
        public long? OrderStartTime { get; set; }

        /// <summary>
        /// 省
        /// </summary>
        [NameInMap("provId")]
        [Validation(Required=false)]
        public int? ProvId { get; set; }

        /// <summary>
        /// 电话
        /// </summary>
        [NameInMap("telephone")]
        [Validation(Required=false)]
        public string Telephone { get; set; }

    }

}
