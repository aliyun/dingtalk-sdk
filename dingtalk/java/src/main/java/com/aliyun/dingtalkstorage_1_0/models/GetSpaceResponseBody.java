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
        @NameInMap("canRecordRecentFile")
        public Boolean canRecordRecentFile;

        @NameInMap("canRename")
        public Boolean canRename;

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
        @NameInMap("max")
        public Long max;

        @NameInMap("reserved")
        public Long reserved;

        @NameInMap("type")
        public String type;

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
        @NameInMap("appId")
        public String appId;

        @NameInMap("capabilities")
        public GetSpaceResponseBodySpaceCapabilities capabilities;

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
        public java.util.List<GetSpaceResponseBodySpacePartitions> partitions;

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
