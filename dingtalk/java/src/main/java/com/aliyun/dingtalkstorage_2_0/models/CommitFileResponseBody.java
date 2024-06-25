// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkstorage_2_0.models;

import com.aliyun.tea.*;

public class CommitFileResponseBody extends TeaModel {
    @NameInMap("dentry")
    public CommitFileResponseBodyDentry dentry;

    public static CommitFileResponseBody build(java.util.Map<String, ?> map) throws Exception {
        CommitFileResponseBody self = new CommitFileResponseBody();
        return TeaModel.build(map, self);
    }

    public CommitFileResponseBody setDentry(CommitFileResponseBodyDentry dentry) {
        this.dentry = dentry;
        return this;
    }
    public CommitFileResponseBodyDentry getDentry() {
        return this.dentry;
    }

    public static class CommitFileResponseBodyDentryProperties extends TeaModel {
        /**
         * <strong>example:</strong>
         * <p>true</p>
         */
        @NameInMap("readOnly")
        public Boolean readOnly;

        public static CommitFileResponseBodyDentryProperties build(java.util.Map<String, ?> map) throws Exception {
            CommitFileResponseBodyDentryProperties self = new CommitFileResponseBodyDentryProperties();
            return TeaModel.build(map, self);
        }

        public CommitFileResponseBodyDentryProperties setReadOnly(Boolean readOnly) {
            this.readOnly = readOnly;
            return this;
        }
        public Boolean getReadOnly() {
            return this.readOnly;
        }

    }

    public static class CommitFileResponseBodyDentryThumbnail extends TeaModel {
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

        public static CommitFileResponseBodyDentryThumbnail build(java.util.Map<String, ?> map) throws Exception {
            CommitFileResponseBodyDentryThumbnail self = new CommitFileResponseBodyDentryThumbnail();
            return TeaModel.build(map, self);
        }

        public CommitFileResponseBodyDentryThumbnail setHeight(Integer height) {
            this.height = height;
            return this;
        }
        public Integer getHeight() {
            return this.height;
        }

        public CommitFileResponseBodyDentryThumbnail setUrl(String url) {
            this.url = url;
            return this;
        }
        public String getUrl() {
            return this.url;
        }

        public CommitFileResponseBodyDentryThumbnail setWidth(Integer width) {
            this.width = width;
            return this;
        }
        public Integer getWidth() {
            return this.width;
        }

    }

    public static class CommitFileResponseBodyDentry extends TeaModel {
        @NameInMap("appProperties")
        public java.util.Map<String, java.util.List<DentryAppPropertiesValue>> appProperties;

        /**
         * <strong>example:</strong>
         * <p>DOCUMENT</p>
         */
        @NameInMap("category")
        public String category;

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
        public CommitFileResponseBodyDentryProperties properties;

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
        public CommitFileResponseBodyDentryThumbnail thumbnail;

        /**
         * <strong>example:</strong>
         * <p>FILE</p>
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

        public static CommitFileResponseBodyDentry build(java.util.Map<String, ?> map) throws Exception {
            CommitFileResponseBodyDentry self = new CommitFileResponseBodyDentry();
            return TeaModel.build(map, self);
        }

        public CommitFileResponseBodyDentry setAppProperties(java.util.Map<String, java.util.List<DentryAppPropertiesValue>> appProperties) {
            this.appProperties = appProperties;
            return this;
        }
        public java.util.Map<String, java.util.List<DentryAppPropertiesValue>> getAppProperties() {
            return this.appProperties;
        }

        public CommitFileResponseBodyDentry setCategory(String category) {
            this.category = category;
            return this;
        }
        public String getCategory() {
            return this.category;
        }

        public CommitFileResponseBodyDentry setCreateTime(String createTime) {
            this.createTime = createTime;
            return this;
        }
        public String getCreateTime() {
            return this.createTime;
        }

        public CommitFileResponseBodyDentry setCreatorId(String creatorId) {
            this.creatorId = creatorId;
            return this;
        }
        public String getCreatorId() {
            return this.creatorId;
        }

        public CommitFileResponseBodyDentry setExtension(String extension) {
            this.extension = extension;
            return this;
        }
        public String getExtension() {
            return this.extension;
        }

        public CommitFileResponseBodyDentry setId(String id) {
            this.id = id;
            return this;
        }
        public String getId() {
            return this.id;
        }

        public CommitFileResponseBodyDentry setModifiedTime(String modifiedTime) {
            this.modifiedTime = modifiedTime;
            return this;
        }
        public String getModifiedTime() {
            return this.modifiedTime;
        }

        public CommitFileResponseBodyDentry setModifierId(String modifierId) {
            this.modifierId = modifierId;
            return this;
        }
        public String getModifierId() {
            return this.modifierId;
        }

        public CommitFileResponseBodyDentry setName(String name) {
            this.name = name;
            return this;
        }
        public String getName() {
            return this.name;
        }

        public CommitFileResponseBodyDentry setParentId(String parentId) {
            this.parentId = parentId;
            return this;
        }
        public String getParentId() {
            return this.parentId;
        }

        public CommitFileResponseBodyDentry setPartitionType(String partitionType) {
            this.partitionType = partitionType;
            return this;
        }
        public String getPartitionType() {
            return this.partitionType;
        }

        public CommitFileResponseBodyDentry setPath(String path) {
            this.path = path;
            return this;
        }
        public String getPath() {
            return this.path;
        }

        public CommitFileResponseBodyDentry setProperties(CommitFileResponseBodyDentryProperties properties) {
            this.properties = properties;
            return this;
        }
        public CommitFileResponseBodyDentryProperties getProperties() {
            return this.properties;
        }

        public CommitFileResponseBodyDentry setSize(Long size) {
            this.size = size;
            return this;
        }
        public Long getSize() {
            return this.size;
        }

        public CommitFileResponseBodyDentry setSpaceId(String spaceId) {
            this.spaceId = spaceId;
            return this;
        }
        public String getSpaceId() {
            return this.spaceId;
        }

        public CommitFileResponseBodyDentry setStatus(String status) {
            this.status = status;
            return this;
        }
        public String getStatus() {
            return this.status;
        }

        public CommitFileResponseBodyDentry setStorageDriver(String storageDriver) {
            this.storageDriver = storageDriver;
            return this;
        }
        public String getStorageDriver() {
            return this.storageDriver;
        }

        public CommitFileResponseBodyDentry setThumbnail(CommitFileResponseBodyDentryThumbnail thumbnail) {
            this.thumbnail = thumbnail;
            return this;
        }
        public CommitFileResponseBodyDentryThumbnail getThumbnail() {
            return this.thumbnail;
        }

        public CommitFileResponseBodyDentry setType(String type) {
            this.type = type;
            return this;
        }
        public String getType() {
            return this.type;
        }

        public CommitFileResponseBodyDentry setUuid(String uuid) {
            this.uuid = uuid;
            return this;
        }
        public String getUuid() {
            return this.uuid;
        }

        public CommitFileResponseBodyDentry setVersion(Long version) {
            this.version = version;
            return this;
        }
        public Long getVersion() {
            return this.version;
        }

    }

}
