// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkstorage_1_0.models;

import com.aliyun.tea.*;

public class ListAllDentriesResponseBody extends TeaModel {
    @NameInMap("dentries")
    public java.util.List<ListAllDentriesResponseBodyDentries> dentries;

    @NameInMap("nextToken")
    public String nextToken;

    public static ListAllDentriesResponseBody build(java.util.Map<String, ?> map) throws Exception {
        ListAllDentriesResponseBody self = new ListAllDentriesResponseBody();
        return TeaModel.build(map, self);
    }

    public ListAllDentriesResponseBody setDentries(java.util.List<ListAllDentriesResponseBodyDentries> dentries) {
        this.dentries = dentries;
        return this;
    }
    public java.util.List<ListAllDentriesResponseBodyDentries> getDentries() {
        return this.dentries;
    }

    public ListAllDentriesResponseBody setNextToken(String nextToken) {
        this.nextToken = nextToken;
        return this;
    }
    public String getNextToken() {
        return this.nextToken;
    }

    public static class ListAllDentriesResponseBodyDentriesProperties extends TeaModel {
        @NameInMap("readOnly")
        public Boolean readOnly;

        public static ListAllDentriesResponseBodyDentriesProperties build(java.util.Map<String, ?> map) throws Exception {
            ListAllDentriesResponseBodyDentriesProperties self = new ListAllDentriesResponseBodyDentriesProperties();
            return TeaModel.build(map, self);
        }

        public ListAllDentriesResponseBodyDentriesProperties setReadOnly(Boolean readOnly) {
            this.readOnly = readOnly;
            return this;
        }
        public Boolean getReadOnly() {
            return this.readOnly;
        }

    }

    public static class ListAllDentriesResponseBodyDentriesThumbnail extends TeaModel {
        @NameInMap("height")
        public Integer height;

        @NameInMap("url")
        public String url;

        @NameInMap("width")
        public Integer width;

        public static ListAllDentriesResponseBodyDentriesThumbnail build(java.util.Map<String, ?> map) throws Exception {
            ListAllDentriesResponseBodyDentriesThumbnail self = new ListAllDentriesResponseBodyDentriesThumbnail();
            return TeaModel.build(map, self);
        }

        public ListAllDentriesResponseBodyDentriesThumbnail setHeight(Integer height) {
            this.height = height;
            return this;
        }
        public Integer getHeight() {
            return this.height;
        }

        public ListAllDentriesResponseBodyDentriesThumbnail setUrl(String url) {
            this.url = url;
            return this;
        }
        public String getUrl() {
            return this.url;
        }

        public ListAllDentriesResponseBodyDentriesThumbnail setWidth(Integer width) {
            this.width = width;
            return this;
        }
        public Integer getWidth() {
            return this.width;
        }

    }

    public static class ListAllDentriesResponseBodyDentries extends TeaModel {
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
        public ListAllDentriesResponseBodyDentriesProperties properties;

        @NameInMap("size")
        public Long size;

        @NameInMap("spaceId")
        public String spaceId;

        @NameInMap("status")
        public String status;

        @NameInMap("storageDriver")
        public String storageDriver;

        @NameInMap("thumbnail")
        public ListAllDentriesResponseBodyDentriesThumbnail thumbnail;

        @NameInMap("type")
        public String type;

        @NameInMap("uuid")
        public String uuid;

        @NameInMap("version")
        public Long version;

        public static ListAllDentriesResponseBodyDentries build(java.util.Map<String, ?> map) throws Exception {
            ListAllDentriesResponseBodyDentries self = new ListAllDentriesResponseBodyDentries();
            return TeaModel.build(map, self);
        }

        public ListAllDentriesResponseBodyDentries setAppProperties(java.util.Map<String, java.util.List<DentriesAppPropertiesValue>> appProperties) {
            this.appProperties = appProperties;
            return this;
        }
        public java.util.Map<String, java.util.List<DentriesAppPropertiesValue>> getAppProperties() {
            return this.appProperties;
        }

        public ListAllDentriesResponseBodyDentries setCreateTime(String createTime) {
            this.createTime = createTime;
            return this;
        }
        public String getCreateTime() {
            return this.createTime;
        }

        public ListAllDentriesResponseBodyDentries setCreatorId(String creatorId) {
            this.creatorId = creatorId;
            return this;
        }
        public String getCreatorId() {
            return this.creatorId;
        }

        public ListAllDentriesResponseBodyDentries setExtension(String extension) {
            this.extension = extension;
            return this;
        }
        public String getExtension() {
            return this.extension;
        }

        public ListAllDentriesResponseBodyDentries setId(String id) {
            this.id = id;
            return this;
        }
        public String getId() {
            return this.id;
        }

        public ListAllDentriesResponseBodyDentries setModifiedTime(String modifiedTime) {
            this.modifiedTime = modifiedTime;
            return this;
        }
        public String getModifiedTime() {
            return this.modifiedTime;
        }

        public ListAllDentriesResponseBodyDentries setModifierId(String modifierId) {
            this.modifierId = modifierId;
            return this;
        }
        public String getModifierId() {
            return this.modifierId;
        }

        public ListAllDentriesResponseBodyDentries setName(String name) {
            this.name = name;
            return this;
        }
        public String getName() {
            return this.name;
        }

        public ListAllDentriesResponseBodyDentries setParentId(String parentId) {
            this.parentId = parentId;
            return this;
        }
        public String getParentId() {
            return this.parentId;
        }

        public ListAllDentriesResponseBodyDentries setPartitionType(String partitionType) {
            this.partitionType = partitionType;
            return this;
        }
        public String getPartitionType() {
            return this.partitionType;
        }

        public ListAllDentriesResponseBodyDentries setPath(String path) {
            this.path = path;
            return this;
        }
        public String getPath() {
            return this.path;
        }

        public ListAllDentriesResponseBodyDentries setProperties(ListAllDentriesResponseBodyDentriesProperties properties) {
            this.properties = properties;
            return this;
        }
        public ListAllDentriesResponseBodyDentriesProperties getProperties() {
            return this.properties;
        }

        public ListAllDentriesResponseBodyDentries setSize(Long size) {
            this.size = size;
            return this;
        }
        public Long getSize() {
            return this.size;
        }

        public ListAllDentriesResponseBodyDentries setSpaceId(String spaceId) {
            this.spaceId = spaceId;
            return this;
        }
        public String getSpaceId() {
            return this.spaceId;
        }

        public ListAllDentriesResponseBodyDentries setStatus(String status) {
            this.status = status;
            return this;
        }
        public String getStatus() {
            return this.status;
        }

        public ListAllDentriesResponseBodyDentries setStorageDriver(String storageDriver) {
            this.storageDriver = storageDriver;
            return this;
        }
        public String getStorageDriver() {
            return this.storageDriver;
        }

        public ListAllDentriesResponseBodyDentries setThumbnail(ListAllDentriesResponseBodyDentriesThumbnail thumbnail) {
            this.thumbnail = thumbnail;
            return this;
        }
        public ListAllDentriesResponseBodyDentriesThumbnail getThumbnail() {
            return this.thumbnail;
        }

        public ListAllDentriesResponseBodyDentries setType(String type) {
            this.type = type;
            return this;
        }
        public String getType() {
            return this.type;
        }

        public ListAllDentriesResponseBodyDentries setUuid(String uuid) {
            this.uuid = uuid;
            return this;
        }
        public String getUuid() {
            return this.uuid;
        }

        public ListAllDentriesResponseBodyDentries setVersion(Long version) {
            this.version = version;
            return this;
        }
        public Long getVersion() {
            return this.version;
        }

    }

}
