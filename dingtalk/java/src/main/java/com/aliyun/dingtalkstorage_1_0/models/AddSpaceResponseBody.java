// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkstorage_1_0.models;

import com.aliyun.tea.*;

public class AddSpaceResponseBody extends TeaModel {
    @NameInMap("space")
    public AddSpaceResponseBodySpace space;

    public static AddSpaceResponseBody build(java.util.Map<String, ?> map) throws Exception {
        AddSpaceResponseBody self = new AddSpaceResponseBody();
        return TeaModel.build(map, self);
    }

    public AddSpaceResponseBody setSpace(AddSpaceResponseBodySpace space) {
        this.space = space;
        return this;
    }
    public AddSpaceResponseBodySpace getSpace() {
        return this.space;
    }

    public static class AddSpaceResponseBodySpaceCapabilities extends TeaModel {
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

        public static AddSpaceResponseBodySpaceCapabilities build(java.util.Map<String, ?> map) throws Exception {
            AddSpaceResponseBodySpaceCapabilities self = new AddSpaceResponseBodySpaceCapabilities();
            return TeaModel.build(map, self);
        }

        public AddSpaceResponseBodySpaceCapabilities setCanRecordRecentFile(Boolean canRecordRecentFile) {
            this.canRecordRecentFile = canRecordRecentFile;
            return this;
        }
        public Boolean getCanRecordRecentFile() {
            return this.canRecordRecentFile;
        }

        public AddSpaceResponseBodySpaceCapabilities setCanRename(Boolean canRename) {
            this.canRename = canRename;
            return this;
        }
        public Boolean getCanRename() {
            return this.canRename;
        }

        public AddSpaceResponseBodySpaceCapabilities setCanSearch(Boolean canSearch) {
            this.canSearch = canSearch;
            return this;
        }
        public Boolean getCanSearch() {
            return this.canSearch;
        }

    }

    public static class AddSpaceResponseBodySpacePartitionsQuota extends TeaModel {
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

        public static AddSpaceResponseBodySpacePartitionsQuota build(java.util.Map<String, ?> map) throws Exception {
            AddSpaceResponseBodySpacePartitionsQuota self = new AddSpaceResponseBodySpacePartitionsQuota();
            return TeaModel.build(map, self);
        }

        public AddSpaceResponseBodySpacePartitionsQuota setMax(Long max) {
            this.max = max;
            return this;
        }
        public Long getMax() {
            return this.max;
        }

        public AddSpaceResponseBodySpacePartitionsQuota setReserved(Long reserved) {
            this.reserved = reserved;
            return this;
        }
        public Long getReserved() {
            return this.reserved;
        }

        public AddSpaceResponseBodySpacePartitionsQuota setType(String type) {
            this.type = type;
            return this;
        }
        public String getType() {
            return this.type;
        }

        public AddSpaceResponseBodySpacePartitionsQuota setUsed(Long used) {
            this.used = used;
            return this;
        }
        public Long getUsed() {
            return this.used;
        }

    }

    public static class AddSpaceResponseBodySpacePartitions extends TeaModel {
        /**
         * <strong>example:</strong>
         * <p>PUBLIC_OSS_PARTITION</p>
         */
        @NameInMap("partitionType")
        public String partitionType;

        @NameInMap("quota")
        public AddSpaceResponseBodySpacePartitionsQuota quota;

        public static AddSpaceResponseBodySpacePartitions build(java.util.Map<String, ?> map) throws Exception {
            AddSpaceResponseBodySpacePartitions self = new AddSpaceResponseBodySpacePartitions();
            return TeaModel.build(map, self);
        }

        public AddSpaceResponseBodySpacePartitions setPartitionType(String partitionType) {
            this.partitionType = partitionType;
            return this;
        }
        public String getPartitionType() {
            return this.partitionType;
        }

        public AddSpaceResponseBodySpacePartitions setQuota(AddSpaceResponseBodySpacePartitionsQuota quota) {
            this.quota = quota;
            return this;
        }
        public AddSpaceResponseBodySpacePartitionsQuota getQuota() {
            return this.quota;
        }

    }

    public static class AddSpaceResponseBodySpace extends TeaModel {
        /**
         * <strong>example:</strong>
         * <p>app_id</p>
         */
        @NameInMap("appId")
        public String appId;

        @NameInMap("capabilities")
        public AddSpaceResponseBodySpaceCapabilities capabilities;

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
        public java.util.List<AddSpaceResponseBodySpacePartitions> partitions;

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

        public static AddSpaceResponseBodySpace build(java.util.Map<String, ?> map) throws Exception {
            AddSpaceResponseBodySpace self = new AddSpaceResponseBodySpace();
            return TeaModel.build(map, self);
        }

        public AddSpaceResponseBodySpace setAppId(String appId) {
            this.appId = appId;
            return this;
        }
        public String getAppId() {
            return this.appId;
        }

        public AddSpaceResponseBodySpace setCapabilities(AddSpaceResponseBodySpaceCapabilities capabilities) {
            this.capabilities = capabilities;
            return this;
        }
        public AddSpaceResponseBodySpaceCapabilities getCapabilities() {
            return this.capabilities;
        }

        public AddSpaceResponseBodySpace setCorpId(String corpId) {
            this.corpId = corpId;
            return this;
        }
        public String getCorpId() {
            return this.corpId;
        }

        public AddSpaceResponseBodySpace setCreateTime(String createTime) {
            this.createTime = createTime;
            return this;
        }
        public String getCreateTime() {
            return this.createTime;
        }

        public AddSpaceResponseBodySpace setCreatorId(String creatorId) {
            this.creatorId = creatorId;
            return this;
        }
        public String getCreatorId() {
            return this.creatorId;
        }

        public AddSpaceResponseBodySpace setId(String id) {
            this.id = id;
            return this;
        }
        public String getId() {
            return this.id;
        }

        public AddSpaceResponseBodySpace setModifiedTime(String modifiedTime) {
            this.modifiedTime = modifiedTime;
            return this;
        }
        public String getModifiedTime() {
            return this.modifiedTime;
        }

        public AddSpaceResponseBodySpace setModifierId(String modifierId) {
            this.modifierId = modifierId;
            return this;
        }
        public String getModifierId() {
            return this.modifierId;
        }

        public AddSpaceResponseBodySpace setName(String name) {
            this.name = name;
            return this;
        }
        public String getName() {
            return this.name;
        }

        public AddSpaceResponseBodySpace setOwnerId(String ownerId) {
            this.ownerId = ownerId;
            return this;
        }
        public String getOwnerId() {
            return this.ownerId;
        }

        public AddSpaceResponseBodySpace setOwnerType(String ownerType) {
            this.ownerType = ownerType;
            return this;
        }
        public String getOwnerType() {
            return this.ownerType;
        }

        public AddSpaceResponseBodySpace setPartitions(java.util.List<AddSpaceResponseBodySpacePartitions> partitions) {
            this.partitions = partitions;
            return this;
        }
        public java.util.List<AddSpaceResponseBodySpacePartitions> getPartitions() {
            return this.partitions;
        }

        public AddSpaceResponseBodySpace setQuota(Long quota) {
            this.quota = quota;
            return this;
        }
        public Long getQuota() {
            return this.quota;
        }

        public AddSpaceResponseBodySpace setScene(String scene) {
            this.scene = scene;
            return this;
        }
        public String getScene() {
            return this.scene;
        }

        public AddSpaceResponseBodySpace setSceneId(String sceneId) {
            this.sceneId = sceneId;
            return this;
        }
        public String getSceneId() {
            return this.sceneId;
        }

        public AddSpaceResponseBodySpace setStatus(String status) {
            this.status = status;
            return this;
        }
        public String getStatus() {
            return this.status;
        }

        public AddSpaceResponseBodySpace setUsedQuota(Long usedQuota) {
            this.usedQuota = usedQuota;
            return this;
        }
        public Long getUsedQuota() {
            return this.usedQuota;
        }

    }

}
