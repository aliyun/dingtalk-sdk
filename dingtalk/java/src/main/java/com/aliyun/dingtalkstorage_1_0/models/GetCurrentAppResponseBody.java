// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkstorage_1_0.models;

import com.aliyun.tea.*;

public class GetCurrentAppResponseBody extends TeaModel {
    // 企业存储应用信息
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
        // 最大容量, 单位: Byte
        // 当前应用容量被设置为max时，代表当前应用容量设置了上限，used<=max
        // 当前应用容量未设置max时，返回空，此时应用共享该企业剩余可用容量
        @NameInMap("max")
        public Long max;

        // 容量类型
        // 枚举值:
        // 	SHARE: 共享容量
        // 此模式下，Quota.max为空，表示共享企业容量
        // 	PRIVATE: 专享容量
        // 当Quota.max设置值后，表示容量独占
        // 使用场景：当需要保证单个应用的可用容量不受其他应用影响时, 可使用共享容量
        @NameInMap("type")
        public String type;

        // 已使用容量, 单位: Byte
        // 表示该应用下所用文件占用容量的总和，文件的上传、复制、删除相关操作会对used的值做相应变更
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
        // 分区类型
        // 枚举值:
        // 	PUBLIC_OSS_PARTITION: 公有云OSS存储分区
        // 	MINI_OSS_PARTITION: 专属Mini OSS存储分区
        @NameInMap("partitionType")
        public String partitionType;

        // 容量信息
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
        // 开放平台应用appId
        @NameInMap("appId")
        public String appId;

        // 应用归属企业的id
        @NameInMap("corpId")
        public String corpId;

        // 应用创建时间
        @NameInMap("createTime")
        public String createTime;

        // 应用修改时间
        @NameInMap("modifiedTime")
        public String modifiedTime;

        // 应用名称，对应开放平台应用名称
        @NameInMap("name")
        public String name;

        // 分区容量信息
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
