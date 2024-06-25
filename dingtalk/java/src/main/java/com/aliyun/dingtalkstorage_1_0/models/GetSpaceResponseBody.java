// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkstorage_1_0.models;

import com.aliyun.tea.*;

public class GetSpaceResponseBody extends TeaModel {
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
         * <strong>example:</strong>
         * <p>true</p>
         */
        @NameInMap("canRecordRecentFile")
        public Boolean canRecordRecentFile;

        /**
         * <strong>example:</strong>
         * <p>true</p>
         */
        @NameInMap("canRename")
        public Boolean canRename;

        /**
         * <strong>example:</strong>
         * <p>true</p>
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
         * <strong>example:</strong>
         * <p>10000</p>
         */
        @NameInMap("max")
        public Long max;

        /**
         * <strong>example:</strong>
         * <p>1000</p>
         */
        @NameInMap("reserved")
        public Long reserved;

        /**
         * <strong>example:</strong>
         * <p>SHARE</p>
         */
        @NameInMap("type")
        public String type;

        /**
         * <strong>example:</strong>
         * <p>1024</p>
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
         * <strong>example:</strong>
         * <p>PUBLIC_OSS_PARTITION</p>
         */
        @NameInMap("partitionType")
        public String partitionType;

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
         * <strong>example:</strong>
         * <p>app_id</p>
         */
        @NameInMap("appId")
        public String appId;

        @NameInMap("capabilities")
        public GetSpaceResponseBodySpaceCapabilities capabilities;

        /**
         * <strong>example:</strong>
         * <p>corp_id</p>
         */
        @NameInMap("corpId")
        public String corpId;

        /**
         * <strong>example:</strong>
         * <p>2022-01-01T10:00:00Z</p>
         */
        @NameInMap("createTime")
        public String createTime;

        /**
         * <strong>example:</strong>
         * <p>creator_id</p>
         */
        @NameInMap("creatorId")
        public String creatorId;

        /**
         * <strong>example:</strong>
         * <p>space_id</p>
         */
        @NameInMap("id")
        public String id;

        /**
         * <strong>example:</strong>
         * <p>2022-01-01T10:00:00Z</p>
         */
        @NameInMap("modifiedTime")
        public String modifiedTime;

        /**
         * <strong>example:</strong>
         * <p>modifier_id</p>
         */
        @NameInMap("modifierId")
        public String modifierId;

        /**
         * <strong>example:</strong>
         * <p>space_name</p>
         */
        @NameInMap("name")
        public String name;

        /**
         * <strong>example:</strong>
         * <p>owner_id</p>
         */
        @NameInMap("ownerId")
        public String ownerId;

        /**
         * <strong>example:</strong>
         * <p>USER</p>
         */
        @NameInMap("ownerType")
        public String ownerType;

        @NameInMap("partitions")
        public java.util.List<GetSpaceResponseBodySpacePartitions> partitions;

        /**
         * <strong>example:</strong>
         * <p>1048576</p>
         */
        @NameInMap("quota")
        public Long quota;

        /**
         * <strong>example:</strong>
         * <p>scene</p>
         */
        @NameInMap("scene")
        public String scene;

        /**
         * <strong>example:</strong>
         * <p>scene_id</p>
         */
        @NameInMap("sceneId")
        public String sceneId;

        /**
         * <strong>example:</strong>
         * <p>NORMAL</p>
         */
        @NameInMap("status")
        public String status;

        /**
         * <strong>example:</strong>
         * <p>1024</p>
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
