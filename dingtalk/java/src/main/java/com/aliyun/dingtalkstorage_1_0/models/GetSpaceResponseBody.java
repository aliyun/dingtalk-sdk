// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkstorage_1_0.models;

import com.aliyun.tea.*;

public class GetSpaceResponseBody extends TeaModel {
    /**
     * <p>空间详情</p>
     */
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
        /**
         * <p>是否进最近使用, 默认不支持</p>
         * <p>默认值:</p>
         * <p>	false</p>
         */
        @NameInMap("canRecordRecentFile")
        public Boolean canRecordRecentFile;

        /**
         * <p>是否支持重命名空间名称, 默认不支持</p>
         * <p>默认值:</p>
         * <p>	false</p>
         */
        @NameInMap("canRename")
        public Boolean canRename;

        /**
         * <p>是否支持搜索, 默认不支持</p>
         * <p>默认值:</p>
         * <p>	false</p>
         */
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
        /**
         * <p>开放平台应用appId</p>
         */
        @NameInMap("appId")
        public String appId;

        /**
         * <p>空间能力项</p>
         */
        @NameInMap("capabilities")
        public GetSpaceResponseBodySpaceCapabilities capabilities;

        /**
         * <p>空间归属企业的id</p>
         */
        @NameInMap("corpId")
        public String corpId;

        /**
         * <p>创建时间</p>
         */
        @NameInMap("createTime")
        public String createTime;

        /**
         * <p>创建者id</p>
         */
        @NameInMap("creatorId")
        public String creatorId;

        /**
         * <p>空间id</p>
         */
        @NameInMap("id")
        public String id;

        /**
         * <p>修改时间</p>
         */
        @NameInMap("modifiedTime")
        public String modifiedTime;

        /**
         * <p>修改者id</p>
         */
        @NameInMap("modifierId")
        public String modifierId;

        /**
         * <p>空间名称</p>
         */
        @NameInMap("name")
        public String name;

        /**
         * <p>所有者id, 根据ownerType定义, 确定值的所属类型</p>
         */
        @NameInMap("ownerId")
        public String ownerId;

        /**
         * <p>owner类型</p>
         * <p>枚举值:</p>
         * <p>	USER: 用户类型</p>
         * <p>	APP: App类型</p>
         */
        @NameInMap("ownerType")
        public String ownerType;

        /**
         * <p>分区容量信息</p>
         * <p>最大size:</p>
         * <p>	2</p>
         */
        @NameInMap("partitions")
        public java.util.List<GetSpaceResponseBodySpacePartitions> partitions;

        /**
         * <p>容量上限</p>
         * <p>管理后台设置的容量上限</p>
         * <p>建议使用分区上容量信息字段</p>
         */
        @NameInMap("quota")
        public Long quota;

        /**
         * <p>业务场景，可以自定义，表示多个不同空间的聚合，可以提供对特定场景做能力设计、容量管理，如根据场景来做搜索或查询。</p>
         * <p>创建空间时，不指定scene, 默认值是default</p>
         * <p>默认值:</p>
         * <p>	default</p>
         */
        @NameInMap("scene")
        public String scene;

        /**
         * <p>关联业务id, 配合scene一起使用。创建空间时，不指定sceneId， 默认值是0</p>
         * <p>默认值:</p>
         * <p>	0</p>
         */
        @NameInMap("sceneId")
        public String sceneId;

        /**
         * <p>空间状态</p>
         * <p>枚举值:</p>
         * <p>	NORMAL: 正常</p>
         * <p>	DELETE: 已删除</p>
         */
        @NameInMap("status")
        public String status;

        /**
         * <p>已使用容量, 包含各分区已使用容量和</p>
         * <p>建议使用分区上容量信息字段</p>
         */
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
