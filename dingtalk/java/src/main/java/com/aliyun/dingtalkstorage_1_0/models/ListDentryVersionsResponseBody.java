// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkstorage_1_0.models;

import com.aliyun.tea.*;

public class ListDentryVersionsResponseBody extends TeaModel {
    @NameInMap("dentries")
    public java.util.List<ListDentryVersionsResponseBodyDentries> dentries;

    @NameInMap("nextToken")
    public String nextToken;

    public static ListDentryVersionsResponseBody build(java.util.Map<String, ?> map) throws Exception {
        ListDentryVersionsResponseBody self = new ListDentryVersionsResponseBody();
        return TeaModel.build(map, self);
    }

    public ListDentryVersionsResponseBody setDentries(java.util.List<ListDentryVersionsResponseBodyDentries> dentries) {
        this.dentries = dentries;
        return this;
    }
    public java.util.List<ListDentryVersionsResponseBodyDentries> getDentries() {
        return this.dentries;
    }

    public ListDentryVersionsResponseBody setNextToken(String nextToken) {
        this.nextToken = nextToken;
        return this;
    }
    public String getNextToken() {
        return this.nextToken;
    }

    public static class ListDentryVersionsResponseBodyDentriesProperties extends TeaModel {
        @NameInMap("readOnly")
        public Boolean readOnly;

        public static ListDentryVersionsResponseBodyDentriesProperties build(java.util.Map<String, ?> map) throws Exception {
            ListDentryVersionsResponseBodyDentriesProperties self = new ListDentryVersionsResponseBodyDentriesProperties();
            return TeaModel.build(map, self);
        }

        public ListDentryVersionsResponseBodyDentriesProperties setReadOnly(Boolean readOnly) {
            this.readOnly = readOnly;
            return this;
        }
        public Boolean getReadOnly() {
            return this.readOnly;
        }

    }

    public static class ListDentryVersionsResponseBodyDentries extends TeaModel {
        @NameInMap("appProperties")
        public java.util.Map<String, java.util.List<DentriesAppPropertiesValue>> appProperties;

        @NameInMap("createTime")
        public String createTime;

        @NameInMap("creatorId")
        public String creatorId;

        @NameInMap("extension")
        public String extension;

        @NameInMap("id")
        public String id;

        @NameInMap("modifiedTime")
        public String modifiedTime;

        @NameInMap("modifierId")
        public String modifierId;

        @NameInMap("name")
        public String name;

        @NameInMap("parentId")
        public String parentId;

        @NameInMap("partitionType")
        public String partitionType;

        @NameInMap("path")
        public String path;

        @NameInMap("properties")
        public ListDentryVersionsResponseBodyDentriesProperties properties;

        @NameInMap("size")
        public Long size;

        @NameInMap("spaceId")
        public String spaceId;

        @NameInMap("status")
        public String status;

        @NameInMap("storageDriver")
        public String storageDriver;

        @NameInMap("type")
        public String type;

        @NameInMap("uuid")
        public String uuid;

        @NameInMap("version")
        public Long version;

        public static ListDentryVersionsResponseBodyDentries build(java.util.Map<String, ?> map) throws Exception {
            ListDentryVersionsResponseBodyDentries self = new ListDentryVersionsResponseBodyDentries();
            return TeaModel.build(map, self);
        }

        public ListDentryVersionsResponseBodyDentries setAppProperties(java.util.Map<String, java.util.List<DentriesAppPropertiesValue>> appProperties) {
            this.appProperties = appProperties;
            return this;
        }
        public java.util.Map<String, java.util.List<DentriesAppPropertiesValue>> getAppProperties() {
            return this.appProperties;
        }

        public ListDentryVersionsResponseBodyDentries setCreateTime(String createTime) {
            this.createTime = createTime;
            return this;
        }
        public String getCreateTime() {
            return this.createTime;
        }

        public ListDentryVersionsResponseBodyDentries setCreatorId(String creatorId) {
            this.creatorId = creatorId;
            return this;
        }
        public String getCreatorId() {
            return this.creatorId;
        }

        public ListDentryVersionsResponseBodyDentries setExtension(String extension) {
            this.extension = extension;
            return this;
        }
        public String getExtension() {
            return this.extension;
        }

        public ListDentryVersionsResponseBodyDentries setId(String id) {
            this.id = id;
            return this;
        }
        public String getId() {
            return this.id;
        }

        public ListDentryVersionsResponseBodyDentries setModifiedTime(String modifiedTime) {
            this.modifiedTime = modifiedTime;
            return this;
        }
        public String getModifiedTime() {
            return this.modifiedTime;
        }

        public ListDentryVersionsResponseBodyDentries setModifierId(String modifierId) {
            this.modifierId = modifierId;
            return this;
        }
        public String getModifierId() {
            return this.modifierId;
        }

        public ListDentryVersionsResponseBodyDentries setName(String name) {
            this.name = name;
            return this;
        }
        public String getName() {
            return this.name;
        }

        public ListDentryVersionsResponseBodyDentries setParentId(String parentId) {
            this.parentId = parentId;
            return this;
        }
        public String getParentId() {
            return this.parentId;
        }

        public ListDentryVersionsResponseBodyDentries setPartitionType(String partitionType) {
            this.partitionType = partitionType;
            return this;
        }
        public String getPartitionType() {
            return this.partitionType;
        }

        public ListDentryVersionsResponseBodyDentries setPath(String path) {
            this.path = path;
            return this;
        }
        public String getPath() {
            return this.path;
        }

        public ListDentryVersionsResponseBodyDentries setProperties(ListDentryVersionsResponseBodyDentriesProperties properties) {
            this.properties = properties;
            return this;
        }
        public ListDentryVersionsResponseBodyDentriesProperties getProperties() {
            return this.properties;
        }

        public ListDentryVersionsResponseBodyDentries setSize(Long size) {
            this.size = size;
            return this;
        }
        public Long getSize() {
            return this.size;
        }

        public ListDentryVersionsResponseBodyDentries setSpaceId(String spaceId) {
            this.spaceId = spaceId;
            return this;
        }
        public String getSpaceId() {
            return this.spaceId;
        }

        public ListDentryVersionsResponseBodyDentries setStatus(String status) {
            this.status = status;
            return this;
        }
        public String getStatus() {
            return this.status;
        }

        public ListDentryVersionsResponseBodyDentries setStorageDriver(String storageDriver) {
            this.storageDriver = storageDriver;
            return this;
        }
        public String getStorageDriver() {
            return this.storageDriver;
        }

        public ListDentryVersionsResponseBodyDentries setType(String type) {
            this.type = type;
            return this;
        }
        public String getType() {
            return this.type;
        }

        public ListDentryVersionsResponseBodyDentries setUuid(String uuid) {
            this.uuid = uuid;
            return this;
        }
        public String getUuid() {
            return this.uuid;
        }

        public ListDentryVersionsResponseBodyDentries setVersion(Long version) {
            this.version = version;
            return this;
        }
        public Long getVersion() {
            return this.version;
        }

    }

}
