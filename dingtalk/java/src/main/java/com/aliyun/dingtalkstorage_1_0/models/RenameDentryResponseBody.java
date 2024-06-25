// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkstorage_1_0.models;

import com.aliyun.tea.*;

public class RenameDentryResponseBody extends TeaModel {
    @NameInMap("dentry")
    public RenameDentryResponseBodyDentry dentry;

    public static RenameDentryResponseBody build(java.util.Map<String, ?> map) throws Exception {
        RenameDentryResponseBody self = new RenameDentryResponseBody();
        return TeaModel.build(map, self);
    }

    public RenameDentryResponseBody setDentry(RenameDentryResponseBodyDentry dentry) {
        this.dentry = dentry;
        return this;
    }
    public RenameDentryResponseBodyDentry getDentry() {
        return this.dentry;
    }

    public static class RenameDentryResponseBodyDentryProperties extends TeaModel {
        /**
         * <strong>example:</strong>
         * <p>true</p>
         */
        @NameInMap("readOnly")
        public Boolean readOnly;

        public static RenameDentryResponseBodyDentryProperties build(java.util.Map<String, ?> map) throws Exception {
            RenameDentryResponseBodyDentryProperties self = new RenameDentryResponseBodyDentryProperties();
            return TeaModel.build(map, self);
        }

        public RenameDentryResponseBodyDentryProperties setReadOnly(Boolean readOnly) {
            this.readOnly = readOnly;
            return this;
        }
        public Boolean getReadOnly() {
            return this.readOnly;
        }

    }

    public static class RenameDentryResponseBodyDentry extends TeaModel {
        @NameInMap("appProperties")
        public java.util.Map<String, java.util.List<DentryAppPropertiesValue>> appProperties;

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
        public RenameDentryResponseBodyDentryProperties properties;

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

        public static RenameDentryResponseBodyDentry build(java.util.Map<String, ?> map) throws Exception {
            RenameDentryResponseBodyDentry self = new RenameDentryResponseBodyDentry();
            return TeaModel.build(map, self);
        }

        public RenameDentryResponseBodyDentry setAppProperties(java.util.Map<String, java.util.List<DentryAppPropertiesValue>> appProperties) {
            this.appProperties = appProperties;
            return this;
        }
        public java.util.Map<String, java.util.List<DentryAppPropertiesValue>> getAppProperties() {
            return this.appProperties;
        }

        public RenameDentryResponseBodyDentry setCreateTime(String createTime) {
            this.createTime = createTime;
            return this;
        }
        public String getCreateTime() {
            return this.createTime;
        }

        public RenameDentryResponseBodyDentry setCreatorId(String creatorId) {
            this.creatorId = creatorId;
            return this;
        }
        public String getCreatorId() {
            return this.creatorId;
        }

        public RenameDentryResponseBodyDentry setExtension(String extension) {
            this.extension = extension;
            return this;
        }
        public String getExtension() {
            return this.extension;
        }

        public RenameDentryResponseBodyDentry setId(String id) {
            this.id = id;
            return this;
        }
        public String getId() {
            return this.id;
        }

        public RenameDentryResponseBodyDentry setModifiedTime(String modifiedTime) {
            this.modifiedTime = modifiedTime;
            return this;
        }
        public String getModifiedTime() {
            return this.modifiedTime;
        }

        public RenameDentryResponseBodyDentry setModifierId(String modifierId) {
            this.modifierId = modifierId;
            return this;
        }
        public String getModifierId() {
            return this.modifierId;
        }

        public RenameDentryResponseBodyDentry setName(String name) {
            this.name = name;
            return this;
        }
        public String getName() {
            return this.name;
        }

        public RenameDentryResponseBodyDentry setParentId(String parentId) {
            this.parentId = parentId;
            return this;
        }
        public String getParentId() {
            return this.parentId;
        }

        public RenameDentryResponseBodyDentry setPartitionType(String partitionType) {
            this.partitionType = partitionType;
            return this;
        }
        public String getPartitionType() {
            return this.partitionType;
        }

        public RenameDentryResponseBodyDentry setPath(String path) {
            this.path = path;
            return this;
        }
        public String getPath() {
            return this.path;
        }

        public RenameDentryResponseBodyDentry setProperties(RenameDentryResponseBodyDentryProperties properties) {
            this.properties = properties;
            return this;
        }
        public RenameDentryResponseBodyDentryProperties getProperties() {
            return this.properties;
        }

        public RenameDentryResponseBodyDentry setSize(Long size) {
            this.size = size;
            return this;
        }
        public Long getSize() {
            return this.size;
        }

        public RenameDentryResponseBodyDentry setSpaceId(String spaceId) {
            this.spaceId = spaceId;
            return this;
        }
        public String getSpaceId() {
            return this.spaceId;
        }

        public RenameDentryResponseBodyDentry setStatus(String status) {
            this.status = status;
            return this;
        }
        public String getStatus() {
            return this.status;
        }

        public RenameDentryResponseBodyDentry setStorageDriver(String storageDriver) {
            this.storageDriver = storageDriver;
            return this;
        }
        public String getStorageDriver() {
            return this.storageDriver;
        }

        public RenameDentryResponseBodyDentry setType(String type) {
            this.type = type;
            return this;
        }
        public String getType() {
            return this.type;
        }

        public RenameDentryResponseBodyDentry setUuid(String uuid) {
            this.uuid = uuid;
            return this;
        }
        public String getUuid() {
            return this.uuid;
        }

        public RenameDentryResponseBodyDentry setVersion(Long version) {
            this.version = version;
            return this;
        }
        public Long getVersion() {
            return this.version;
        }

    }

}
