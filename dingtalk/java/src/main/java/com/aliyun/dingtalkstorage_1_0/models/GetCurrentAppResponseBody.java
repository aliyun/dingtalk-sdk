// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkstorage_1_0.models;

import com.aliyun.tea.*;

public class GetCurrentAppResponseBody extends TeaModel {
    /**
     * <p>企业存储应用信息</p>
     */
    @NameInMap("app")
    public GetCurrentAppResponseBodyApp app;

    public static GetCurrentAppResponseBody build(java.util.Map<String, ?> map) throws Exception {
        GetCurrentAppResponseBody self = new GetCurrentAppResponseBody();
        return TeaModel.build(map, self);
    }

    public GetCurrentAppResponseBody setApp(GetCurrentAppResponseBodyApp app) {
        this.app = app;
        return this;
    }
    public GetCurrentAppResponseBodyApp getApp() {
        return this.app;
    }

    public static class GetCurrentAppResponseBodyAppPartitionsQuota extends TeaModel {
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

        public static GetCurrentAppResponseBodyAppPartitionsQuota build(java.util.Map<String, ?> map) throws Exception {
            GetCurrentAppResponseBodyAppPartitionsQuota self = new GetCurrentAppResponseBodyAppPartitionsQuota();
            return TeaModel.build(map, self);
        }

        public GetCurrentAppResponseBodyAppPartitionsQuota setMax(Long max) {
            this.max = max;
            return this;
        }
        public Long getMax() {
            return this.max;
        }

        public GetCurrentAppResponseBodyAppPartitionsQuota setReserved(Long reserved) {
            this.reserved = reserved;
            return this;
        }
        public Long getReserved() {
            return this.reserved;
        }

        public GetCurrentAppResponseBodyAppPartitionsQuota setType(String type) {
            this.type = type;
            return this;
        }
        public String getType() {
            return this.type;
        }

        public GetCurrentAppResponseBodyAppPartitionsQuota setUsed(Long used) {
            this.used = used;
            return this;
        }
        public Long getUsed() {
            return this.used;
        }

    }

    public static class GetCurrentAppResponseBodyAppPartitions extends TeaModel {
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
        public GetCurrentAppResponseBodyAppPartitionsQuota quota;

        public static GetCurrentAppResponseBodyAppPartitions build(java.util.Map<String, ?> map) throws Exception {
            GetCurrentAppResponseBodyAppPartitions self = new GetCurrentAppResponseBodyAppPartitions();
            return TeaModel.build(map, self);
        }

        public GetCurrentAppResponseBodyAppPartitions setPartitionType(String partitionType) {
            this.partitionType = partitionType;
            return this;
        }
        public String getPartitionType() {
            return this.partitionType;
        }

        public GetCurrentAppResponseBodyAppPartitions setQuota(GetCurrentAppResponseBodyAppPartitionsQuota quota) {
            this.quota = quota;
            return this;
        }
        public GetCurrentAppResponseBodyAppPartitionsQuota getQuota() {
            return this.quota;
        }

    }

    public static class GetCurrentAppResponseBodyApp extends TeaModel {
        /**
         * <p>开放平台应用appId</p>
         */
        @NameInMap("appId")
        public String appId;

        /**
         * <p>应用归属企业的id</p>
         */
        @NameInMap("corpId")
        public String corpId;

        /**
         * <p>应用创建时间</p>
         */
        @NameInMap("createTime")
        public String createTime;

        /**
         * <p>应用修改时间</p>
         */
        @NameInMap("modifiedTime")
        public String modifiedTime;

        /**
         * <p>应用名称，对应开放平台应用名称</p>
         */
        @NameInMap("name")
        public String name;

        /**
         * <p>分区容量信息</p>
         * <p>最大size:</p>
         * <p>	3</p>
         */
        @NameInMap("partitions")
        public java.util.List<GetCurrentAppResponseBodyAppPartitions> partitions;

        public static GetCurrentAppResponseBodyApp build(java.util.Map<String, ?> map) throws Exception {
            GetCurrentAppResponseBodyApp self = new GetCurrentAppResponseBodyApp();
            return TeaModel.build(map, self);
        }

        public GetCurrentAppResponseBodyApp setAppId(String appId) {
            this.appId = appId;
            return this;
        }
        public String getAppId() {
            return this.appId;
        }

        public GetCurrentAppResponseBodyApp setCorpId(String corpId) {
            this.corpId = corpId;
            return this;
        }
        public String getCorpId() {
            return this.corpId;
        }

        public GetCurrentAppResponseBodyApp setCreateTime(String createTime) {
            this.createTime = createTime;
            return this;
        }
        public String getCreateTime() {
            return this.createTime;
        }

        public GetCurrentAppResponseBodyApp setModifiedTime(String modifiedTime) {
            this.modifiedTime = modifiedTime;
            return this;
        }
        public String getModifiedTime() {
            return this.modifiedTime;
        }

        public GetCurrentAppResponseBodyApp setName(String name) {
            this.name = name;
            return this;
        }
        public String getName() {
            return this.name;
        }

        public GetCurrentAppResponseBodyApp setPartitions(java.util.List<GetCurrentAppResponseBodyAppPartitions> partitions) {
            this.partitions = partitions;
            return this;
        }
        public java.util.List<GetCurrentAppResponseBodyAppPartitions> getPartitions() {
            return this.partitions;
        }

    }

}
