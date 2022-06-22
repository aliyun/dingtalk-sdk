// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkindustry_1_0.Models
{
    public class CampusUpdateCampusRequest : TeaModel {
        /// <summary>
        /// 所在具体地址
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
        /// 归属项目组
        /// </summary>
        [NameInMap("belongProjectGroupId")]
        [Validation(Required=false)]
        public long? BelongProjectGroupId { get; set; }

        /// <summary>
        /// 项目部门id
        /// </summary>
        [NameInMap("campusDeptId")]
        [Validation(Required=false)]
        public long? CampusDeptId { get; set; }

        /// <summary>
        /// 园区项目名
        /// </summary>
        [NameInMap("campusName")]
        [Validation(Required=false)]
        public string CampusName { get; set; }

        /// <summary>
        /// 容量
        /// </summary>
        [NameInMap("capacity")]
        [Validation(Required=false)]
        public int? Capacity { get; set; }

        /// <summary>
        /// 所在市行政编码
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
        /// 所在区行政编码
        /// </summary>
        [NameInMap("countyId")]
        [Validation(Required=false)]
        public int? CountyId { get; set; }

        /// <summary>
        /// 园区项目描述
        /// </summary>
        [NameInMap("description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// 扩展信息
        /// </summary>
        [NameInMap("extend")]
        [Validation(Required=false)]
        public string Extend { get; set; }

        /// <summary>
        /// 项目订阅到期时间
        /// </summary>
        [NameInMap("orderEndTime")]
        [Validation(Required=false)]
        public long? OrderEndTime { get; set; }

        /// <summary>
        /// 购买信息
        /// </summary>
        [NameInMap("orderInfo")]
        [Validation(Required=false)]
        public long? OrderInfo { get; set; }

        /// <summary>
        /// 项目订阅开始时间
        /// </summary>
        [NameInMap("orderStartTime")]
        [Validation(Required=false)]
        public long? OrderStartTime { get; set; }

        /// <summary>
        /// 所在省行政编码
        /// </summary>
        [NameInMap("provId")]
        [Validation(Required=false)]
        public int? ProvId { get; set; }

        /// <summary>
        /// 联系电话
        /// </summary>
        [NameInMap("telephone")]
        [Validation(Required=false)]
        public string Telephone { get; set; }

    }

}
