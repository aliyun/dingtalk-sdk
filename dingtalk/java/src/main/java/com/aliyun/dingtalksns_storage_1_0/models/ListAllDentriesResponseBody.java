// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalksns_storage_1_0.models;

import com.aliyun.tea.*;

public class ListAllDentriesResponseBody extends TeaModel {
    @NameInMap("dentries")
    public java.util.List<ListAllDentriesResponseBodyDentries> dentries;

    /**
     * <strong>example:</strong>
     * <p>next_token</p>
     */
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
        /**
         * <strong>example:</strong>
         * <p>true</p>
         */
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
        /**
         * <strong>example:</strong>
         * <p>64</p>
         */
        @NameInMap("height")
        public Integer height;

        /**
         * <strong>example:</strong>
         * <p>url</p>
         */
        @NameInMap("url")
        public String url;

        /**
         * <strong>example:</strong>
         * <p>64</p>
         */
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
         * <p>txt</p>
         */
        @NameInMap("extension")
        public String extension;

        /**
         * <strong>example:</strong>
         * <p>dentry_id</p>
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
         * <p>dentry_name</p>
         */
        @NameInMap("name")
        public String name;

        /**
         * <strong>example:</strong>
         * <p>parent_id</p>
         */
        @NameInMap("parentId")
        public String parentId;

        /**
         * <strong>example:</strong>
         * <p>PUBLIC_OSS_PARTITION</p>
         */
        @NameInMap("partitionType")
        public String partitionType;

        /**
         * <strong>example:</strong>
         * <p>dentry_path</p>
         */
        @NameInMap("path")
        public String path;

        @NameInMap("properties")
        public ListAllDentriesResponseBodyDentriesProperties properties;

        /**
         * <strong>example:</strong>
         * <p>512</p>
         */
        @NameInMap("size")
        public Long size;

        /**
         * <strong>example:</strong>
         * <p>space_id</p>
         */
        @NameInMap("spaceId")
        public String spaceId;

        /**
         * <strong>example:</strong>
         * <p>NORMAL</p>
         */
        @NameInMap("status")
        public String status;

        /**
         * <strong>example:</strong>
         * <p>DINGTALK</p>
         */
        @NameInMap("storageDriver")
        public String storageDriver;

        @NameInMap("thumbnail")
        public ListAllDentriesResponseBodyDentriesThumbnail thumbnail;

        /**
         * <strong>example:</strong>
         * <p>file</p>
         */
        @NameInMap("type")
        public String type;

        /**
         * <strong>example:</strong>
         * <p>uuid</p>
         */
        @NameInMap("uuid")
        public String uuid;

        /**
         * <strong>example:</strong>
         * <p>1</p>
         */
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
