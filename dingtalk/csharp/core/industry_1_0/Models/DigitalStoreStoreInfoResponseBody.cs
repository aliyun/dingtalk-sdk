// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkindustry_1_0.Models
{
    public class DigitalStoreStoreInfoResponseBody : TeaModel {
        /// <summary>
        /// 门店地址
        /// </summary>
        [NameInMap("address")]
        [Validation(Required=false)]
        public string Address { get; set; }

        /// <summary>
        /// 营业时间
        /// </summary>
        [NameInMap("businessHours")]
        [Validation(Required=false)]
        public string BusinessHours { get; set; }

        [NameInMap("dingDeptId")]
        [Validation(Required=false)]
        public long? DingDeptId { get; set; }

        /// <summary>
        /// 纬度
        /// </summary>
        [NameInMap("latitude")]
        [Validation(Required=false)]
        public string Latitude { get; set; }

        /// <summary>
        /// 定位地址
        /// </summary>
        [NameInMap("locationAddress")]
        [Validation(Required=false)]
        public string LocationAddress { get; set; }

        /// <summary>
        /// 经度
        /// </summary>
        [NameInMap("longitude")]
        [Validation(Required=false)]
        public string Longitude { get; set; }

        /// <summary>
        /// 门店名称
        /// </summary>
        [NameInMap("name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// 上级节点id
        /// </summary>
        [NameInMap("parentId")]
        [Validation(Required=false)]
        public long? ParentId { get; set; }

        /// <summary>
        /// 门店状态
        /// </summary>
        [NameInMap("status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        /// <summary>
        /// 门店面积
        /// </summary>
        [NameInMap("storeAcreage")]
        [Validation(Required=false)]
        public string StoreAcreage { get; set; }

        /// <summary>
        /// 门店带宽
        /// </summary>
        [NameInMap("storeBandwidth")]
        [Validation(Required=false)]
        public string StoreBandwidth { get; set; }

        /// <summary>
        /// 门店编号
        /// </summary>
        [NameInMap("storeCode")]
        [Validation(Required=false)]
        public string StoreCode { get; set; }

        /// <summary>
        /// 门店Id
        /// </summary>
        [NameInMap("storeId")]
        [Validation(Required=false)]
        public long? StoreId { get; set; }

        /// <summary>
        /// 门店电话
        /// </summary>
        [NameInMap("telephone")]
        [Validation(Required=false)]
        public string Telephone { get; set; }

    }

}
