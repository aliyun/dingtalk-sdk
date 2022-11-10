// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkstorage_1_0.models;

import com.aliyun.tea.*;

public class GetSpaceResponseBody extends TeaModel {
    // 空间详情
    @NameInMap("space")
    public GetSpaceResponseBodySpace space;

    public static GetSpaceResponseBody build(java.util.Map<String, ?> map) throws Exception {
        GetSpaceResponseBody self = new GetSpaceResponseBody();
        return TeaModel.build(map, self);
    }

    public GetSpaceResponseBody setSpace(GetSpaceResponseBodySpace space) {
        this.space = space;
        return this;
    }
    public GetSpaceResponseBodySpace getSpace() {
        return this.space;
    }

    public static class GetSpaceResponseBodySpaceCapabilities extends TeaModel {
        // 是否进最近使用, 默认不支持
        // 默认值:
        // 	false
        @NameInMap("canRecordRecentFile")
        public Boolean canRecordRecentFile;

        // 是否支持重命名空间名称, 默认不支持
        // 默认值:
        // 	false
        @NameInMap("canRename")
        public Boolean canRename;

        // 是否支持搜索, 默认不支持
        // 默认值:
        // 	false
        @NameInMap("canSearch")
        public Boolean canSearch;

        public static GetSpaceResponseBodySpaceCapabilities build(java.util.Map<String, ?> map) throws Exception {
            GetSpaceResponseBodySpaceCapabilities self = new GetSpaceResponseBodySpaceCapabilities();
            return TeaModel.build(map, self);
        }

        public GetSpaceResponseBodySpaceCapabilities setCanRecordRecentFile(Boolean canRecordRecentFile) {
            this.canRecordRecentFile = canRecordRecentFile;
            return this;
        }
        public Boolean getCanRecordRecentFile() {
            return this.canRecordRecentFile;
        }

        public GetSpaceResponseBodySpaceCapabilities setCanRename(Boolean canRename) {
            this.canRename = canRename;
            return this;
        }
        public Boolean getCanRename() {
            return this.canRename;
        }

        public GetSpaceResponseBodySpaceCapabilities setCanSearch(Boolean canSearch) {
            this.canSearch = canSearch;
            return this;
        }
        public Boolean getCanSearch() {
            return this.canSearch;
        }

    }

    public static class GetSpaceResponseBodySpacePartitionsQuota extends TeaModel {
        // 最大容量, 单位: Byte
        // 当前应用容量被设置为max时，代表当前应用容量设置了上限，used<=max
        // 当前应用容量未设置max时，返回空，此时应用共享该企业剩余可用容量
        @NameInMap("max")
        public Long max;

        // 预分配剩余容量, 单位: Byte
        // 背景：
        //    管理后台可以给应用或空间预分配容量，此字段表示预分剩余容量，即预分配容量中未使用部分
        // 如果没有设置预分配容，此字段是空
        @NameInMap("reserved")
        public Long reserved;

        // 容量类型
        // 如果是企业维度容量，此值是PRIVATE, 表示企业独占
        // 枚举值:
        // 	SHARE: 共享容量
        // 此模式下，Quota.max为空，表示共享企业容量
        // 	PRIVATE: 预分配容量（专享容量）
        // 当Quota.max设置值后，表示容量独占
        // 使用场景：需要保证单个应用的可用容量不受其他应用影响时, 可使用预分配容量（专享容量）
        @NameInMap("type")
        public String type;

        // 实际已使用容量, 单位: Byte
        // 表示该应用下所用文件占用容量的总和，文件的上传、复制、删除相关操作会对used的值做相应变更
        // 最小值:
        // 	0
        @NameInMap("used")
        public Long used;

        public static GetSpaceResponseBodySpacePartitionsQuota build(java.util.Map<String, ?> map) throws Exception {
            GetSpaceResponseBodySpacePartitionsQuota self = new GetSpaceResponseBodySpacePartitionsQuota();
            return TeaModel.build(map, self);
        }

        public GetSpaceResponseBodySpacePartitionsQuota setMax(Long max) {
            this.max = max;
            return this;
        }
        public Long getMax() {
            return this.max;
        }

        public GetSpaceResponseBodySpacePartitionsQuota setReserved(Long reserved) {
            this.reserved = reserved;
            return this;
        }
        public Long getReserved() {
            return this.reserved;
        }

        public GetSpaceResponseBodySpacePartitionsQuota setType(String type) {
            this.type = type;
            return this;
        }
        public String getType() {
            return this.type;
        }

        public GetSpaceResponseBodySpacePartitionsQuota setUsed(Long used) {
            this.used = used;
            return this;
        }
        public Long getUsed() {
            return this.used;
        }

    }

    public static class GetSpaceResponseBodySpacePartitions extends TeaModel {
        // 分区类型
        // 枚举值:
        // 	PUBLIC_OSS_PARTITION: 公有云OSS存储分区
        // 	MINI_OSS_PARTITION: 专属Mini OSS存储分区
        @NameInMap("partitionType")
        public String partitionType;

        // 容量信息
        @NameInMap("quota")
        public GetSpaceResponseBodySpacePartitionsQuota quota;

        public static GetSpaceResponseBodySpacePartitions build(java.util.Map<String, ?> map) throws Exception {
            GetSpaceResponseBodySpacePartitions self = new GetSpaceResponseBodySpacePartitions();
            return TeaModel.build(map, self);
        }

        public GetSpaceResponseBodySpacePartitions setPartitionType(String partitionType) {
            this.partitionType = partitionType;
            return this;
        }
        public String getPartitionType() {
            return this.partitionType;
        }

        public GetSpaceResponseBodySpacePartitions setQuota(GetSpaceResponseBodySpacePartitionsQuota quota) {
            this.quota = quota;
            return this;
        }
        public GetSpaceResponseBodySpacePartitionsQuota getQuota() {
            return this.quota;
        }

    }

    public static class GetSpaceResponseBodySpace extends TeaModel {
        // 开放平台应用appId
        @NameInMap("appId")
        public String appId;

        // 空间能力项
        @NameInMap("capabilities")
        public GetSpaceResponseBodySpaceCapabilities capabilities;

        // 空间归属企业的id
        @NameInMap("corpId")
        public String corpId;

        // 创建时间
        @NameInMap("createTime")
        public String createTime;

        // 创建者id
        @NameInMap("creatorId")
        public String creatorId;

        // 空间id
        @NameInMap("id")
        public String id;

        // 修改时间
        @NameInMap("modifiedTime")
        public String modifiedTime;

        // 修改者id
        @NameInMap("modifierId")
        public String modifierId;

        // 空间名称
        @NameInMap("name")
        public String name;

        // 所有者id, 根据ownerType定义, 确定值的所属类型
        @NameInMap("ownerId")
        public String ownerId;

        // owner类型
        // 枚举值:
        // 	USER: 用户类型
        // 	APP: App类型
        @NameInMap("ownerType")
        public String ownerType;

        // 分区容量信息
        // 最大size:
        // 	2
        @NameInMap("partitions")
        public java.util.List<GetSpaceResponseBodySpacePartitions> partitions;

        // 容量上限
        // 管理后台设置的容量上限
        // 建议使用分区上容量信息字段
        @NameInMap("quota")
        public Long quota;

        // 业务场景，可以自定义，表示多个不同空间的聚合，可以提供对特定场景做能力设计、容量管理，如根据场景来做搜索或查询。
        // 创建空间时，不指定scene, 默认值是default
        // 默认值:
        // 	default
        @NameInMap("scene")
        public String scene;

        // 关联业务id, 配合scene一起使用。创建空间时，不指定sceneId， 默认值是0
        // 默认值:
        // 	0
        @NameInMap("sceneId")
        public String sceneId;

        // 空间状态
        // 枚举值:
        // 	NORMAL: 正常
        // 	DELETE: 已删除
        @NameInMap("status")
        public String status;

        // 已使用容量, 包含各分区已使用容量和
        // 建议使用分区上容量信息字段
        @NameInMap("usedQuota")
        public Long usedQuota;

        public static GetSpaceResponseBodySpace build(java.util.Map<String, ?> map) throws Exception {
            GetSpaceResponseBodySpace self = new GetSpaceResponseBodySpace();
            return TeaModel.build(map, self);
        }

        public GetSpaceResponseBodySpace setAppId(String appId) {
            this.appId = appId;
            return this;
        }
        public String getAppId() {
            return this.appId;
        }

        public GetSpaceResponseBodySpace setCapabilities(GetSpaceResponseBodySpaceCapabilities capabilities) {
            this.capabilities = capabilities;
            return this;
        }
        public GetSpaceResponseBodySpaceCapabilities getCapabilities() {
            return this.capabilities;
        }

        public GetSpaceResponseBodySpace setCorpId(String corpId) {
            this.corpId = corpId;
            return this;
        }
        public String getCorpId() {
            return this.corpId;
        }

        public GetSpaceResponseBodySpace setCreateTime(String createTime) {
            this.createTime = createTime;
            return this;
        }
        public String getCreateTime() {
            return this.createTime;
        }

        public GetSpaceResponseBodySpace setCreatorId(String creatorId) {
            this.creatorId = creatorId;
            return this;
        }
        public String getCreatorId() {
            return this.creatorId;
        }

        public GetSpaceResponseBodySpace setId(String id) {
            this.id = id;
            return this;
        }
        public String getId() {
            return this.id;
        }

        public GetSpaceResponseBodySpace setModifiedTime(String modifiedTime) {
            this.modifiedTime = modifiedTime;
            return this;
        }
        public String getModifiedTime() {
            return this.modifiedTime;
        }

        public GetSpaceResponseBodySpace setModifierId(String modifierId) {
            this.modifierId = modifierId;
            return this;
        }
        public String getModifierId() {
            return this.modifierId;
        }

        public GetSpaceResponseBodySpace setName(String name) {
            this.name = name;
            return this;
        }
        public String getName() {
            return this.name;
        }

        public GetSpaceResponseBodySpace setOwnerId(String ownerId) {
            this.ownerId = ownerId;
            return this;
        }
        public String getOwnerId() {
            return this.ownerId;
        }

        public GetSpaceResponseBodySpace setOwnerType(String ownerType) {
            this.ownerType = ownerType;
            return this;
        }
        public String getOwnerType() {
            return this.ownerType;
        }

        public GetSpaceResponseBodySpace setPartitions(java.util.List<GetSpaceResponseBodySpacePartitions> partitions) {
            this.partitions = partitions;
            return this;
        }
        public java.util.List<GetSpaceResponseBodySpacePartitions> getPartitions() {
            return this.partitions;
        }

        public GetSpaceResponseBodySpace setQuota(Long quota) {
            this.quota = quota;
            return this;
        }
        public Long getQuota() {
            return this.quota;
        }

        public GetSpaceResponseBodySpace setScene(String scene) {
            this.scene = scene;
            return this;
        }
        public String getScene() {
            return this.scene;
        }

        public GetSpaceResponseBodySpace setSceneId(String sceneId) {
            this.sceneId = sceneId;
            return this;
        }
        public String getSceneId() {
            return this.sceneId;
        }

        public GetSpaceResponseBodySpace setStatus(String status) {
            this.status = status;
            return this;
        }
        public String getStatus() {
            return this.status;
        }

        public GetSpaceResponseBodySpace setUsedQuota(Long usedQuota) {
            this.usedQuota = usedQuota;
            return this;
        }
        public Long getUsedQuota() {
            return this.usedQuota;
        }

    }

}
