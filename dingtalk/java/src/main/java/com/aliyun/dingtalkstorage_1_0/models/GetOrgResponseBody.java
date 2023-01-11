// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkstorage_1_0.models;

import com.aliyun.tea.*;

public class GetOrgResponseBody extends TeaModel {
    /**
     * <p>企业信息</p>
     */
    @NameInMap("org")
    public GetOrgResponseBodyOrg org;

    public static GetOrgResponseBody build(java.util.Map<String, ?> map) throws Exception {
        GetOrgResponseBody self = new GetOrgResponseBody();
        return TeaModel.build(map, self);
    }

    public GetOrgResponseBody setOrg(GetOrgResponseBodyOrg org) {
        this.org = org;
        return this;
    }
    public GetOrgResponseBodyOrg getOrg() {
        return this.org;
    }

    public static class GetOrgResponseBodyOrgPartitionsQuota extends TeaModel {
        /**
         * <p>最大容量, 单位: Byte</p>
         * <p>当前应用容量被设置为max时，代表当前应用容量设置了上限，used<=max</p>
         * <p>当前应用容量未设置max时，返回空，此时应用共享该企业剩余可用容量</p>
         */
        @NameInMap("max")
        public Long max;

        /**
         * <p>预分配剩余容量, 单位: Byte</p>
         * <p>背景：</p>
         * <p>   管理后台可以给应用或空间预分配容量，此字段表示预分剩余容量，即预分配容量中未使用部分</p>
         * <p>如果没有设置预分配容，此字段是空</p>
         */
        @NameInMap("reserved")
        public Long reserved;

        /**
         * <p>容量类型</p>
         * <p>如果是企业维度容量，此值是PRIVATE, 表示企业独占</p>
         * <p>枚举值:</p>
         * <p>	SHARE: 共享容量</p>
         * <p>此模式下，Quota.max为空，表示共享企业容量</p>
         * <p>	PRIVATE: 预分配容量（专享容量）</p>
         * <p>当Quota.max设置值后，表示容量独占</p>
         * <p>使用场景：需要保证单个应用的可用容量不受其他应用影响时, 可使用预分配容量（专享容量）</p>
         */
        @NameInMap("type")
        public String type;

        /**
         * <p>实际已使用容量, 单位: Byte</p>
         * <p>表示该应用下所用文件占用容量的总和，文件的上传、复制、删除相关操作会对used的值做相应变更</p>
         * <p>最小值:</p>
         * <p>	0</p>
         */
        @NameInMap("used")
        public Long used;

        public static GetOrgResponseBodyOrgPartitionsQuota build(java.util.Map<String, ?> map) throws Exception {
            GetOrgResponseBodyOrgPartitionsQuota self = new GetOrgResponseBodyOrgPartitionsQuota();
            return TeaModel.build(map, self);
        }

        public GetOrgResponseBodyOrgPartitionsQuota setMax(Long max) {
            this.max = max;
            return this;
        }
        public Long getMax() {
            return this.max;
        }

        public GetOrgResponseBodyOrgPartitionsQuota setReserved(Long reserved) {
            this.reserved = reserved;
            return this;
        }
        public Long getReserved() {
            return this.reserved;
        }

        public GetOrgResponseBodyOrgPartitionsQuota setType(String type) {
            this.type = type;
            return this;
        }
        public String getType() {
            return this.type;
        }

        public GetOrgResponseBodyOrgPartitionsQuota setUsed(Long used) {
            this.used = used;
            return this;
        }
        public Long getUsed() {
            return this.used;
        }

    }

    public static class GetOrgResponseBodyOrgPartitions extends TeaModel {
        /**
         * <p>分区类型</p>
         * <p>枚举值:</p>
         * <p>	PUBLIC_OSS_PARTITION: 公有云OSS存储分区</p>
         * <p>	MINI_OSS_PARTITION: 专属Mini OSS存储分区</p>
         */
        @NameInMap("partitionType")
        public String partitionType;

        /**
         * <p>容量信息</p>
         */
        @NameInMap("quota")
        public GetOrgResponseBodyOrgPartitionsQuota quota;

        public static GetOrgResponseBodyOrgPartitions build(java.util.Map<String, ?> map) throws Exception {
            GetOrgResponseBodyOrgPartitions self = new GetOrgResponseBodyOrgPartitions();
            return TeaModel.build(map, self);
        }

        public GetOrgResponseBodyOrgPartitions setPartitionType(String partitionType) {
            this.partitionType = partitionType;
            return this;
        }
        public String getPartitionType() {
            return this.partitionType;
        }

        public GetOrgResponseBodyOrgPartitions setQuota(GetOrgResponseBodyOrgPartitionsQuota quota) {
            this.quota = quota;
            return this;
        }
        public GetOrgResponseBodyOrgPartitionsQuota getQuota() {
            return this.quota;
        }

    }

    public static class GetOrgResponseBodyOrg extends TeaModel {
        /**
         * <p>企业id</p>
         */
        @NameInMap("corpId")
        public String corpId;

        /**
         * <p>分区容量信息</p>
         * <p>最大size:</p>
         * <p>	2</p>
         */
        @NameInMap("partitions")
        public java.util.List<GetOrgResponseBodyOrgPartitions> partitions;

        public static GetOrgResponseBodyOrg build(java.util.Map<String, ?> map) throws Exception {
            GetOrgResponseBodyOrg self = new GetOrgResponseBodyOrg();
            return TeaModel.build(map, self);
        }

        public GetOrgResponseBodyOrg setCorpId(String corpId) {
            this.corpId = corpId;
            return this;
        }
        public String getCorpId() {
            return this.corpId;
        }

        public GetOrgResponseBodyOrg setPartitions(java.util.List<GetOrgResponseBodyOrgPartitions> partitions) {
            this.partitions = partitions;
            return this;
        }
        public java.util.List<GetOrgResponseBodyOrgPartitions> getPartitions() {
            return this.partitions;
        }

    }

}
