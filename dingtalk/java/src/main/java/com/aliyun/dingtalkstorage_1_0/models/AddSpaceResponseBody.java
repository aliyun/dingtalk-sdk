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
        @NameInMap("canRecordRecentFile")
        public Boolean canRecordRecentFile;

        @NameInMap("canRename")
        public Boolean canRename;

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
        @NameInMap("max")
        public Long max;

        @NameInMap("reserved")
        public Long reserved;

        @NameInMap("type")
        public String type;

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
        @NameInMap("appId")
        public String appId;

        @NameInMap("capabilities")
        public AddSpaceResponseBodySpaceCapabilities capabilities;

        @NameInMap("corpId")
        public String corpId;

        @NameInMap("createTime")
        public String createTime;

        @NameInMap("creatorId")
        public String creatorId;

        @NameInMap("id")
        public String id;

        @NameInMap("modifiedTime")
        public String modifiedTime;

        @NameInMap("modifierId")
        public String modifierId;

        @NameInMap("name")
        public String name;

        @NameInMap("ownerId")
        public String ownerId;

        @NameInMap("ownerType")
        public String ownerType;

        @NameInMap("partitions")
        public java.util.List<AddSpaceResponseBodySpacePartitions> partitions;

        @NameInMap("quota")
        public Long quota;

        @NameInMap("scene")
        public String scene;

        @NameInMap("sceneId")
        public String sceneId;

        @NameInMap("status")
        public String status;

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
