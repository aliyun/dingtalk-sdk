// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkstorage_1_0.models;

import com.aliyun.tea.*;

public class GetDentriesResponseBody extends TeaModel {
    @NameInMap("resultItems")
    public java.util.List<GetDentriesResponseBodyResultItems> resultItems;

    public static GetDentriesResponseBody build(java.util.Map<String, ?> map) throws Exception {
        GetDentriesResponseBody self = new GetDentriesResponseBody();
        return TeaModel.build(map, self);
    }

    public GetDentriesResponseBody setResultItems(java.util.List<GetDentriesResponseBodyResultItems> resultItems) {
        this.resultItems = resultItems;
        return this;
    }
    public java.util.List<GetDentriesResponseBodyResultItems> getResultItems() {
        return this.resultItems;
    }

    public static class GetDentriesResponseBodyResultItemsDentryProperties extends TeaModel {
        /**
         * <strong>example:</strong>
         * <p>true</p>
         */
        @NameInMap("readOnly")
        public Boolean readOnly;

        public static GetDentriesResponseBodyResultItemsDentryProperties build(java.util.Map<String, ?> map) throws Exception {
            GetDentriesResponseBodyResultItemsDentryProperties self = new GetDentriesResponseBodyResultItemsDentryProperties();
            return TeaModel.build(map, self);
        }

        public GetDentriesResponseBodyResultItemsDentryProperties setReadOnly(Boolean readOnly) {
            this.readOnly = readOnly;
            return this;
        }
        public Boolean getReadOnly() {
            return this.readOnly;
        }

    }

    public static class GetDentriesResponseBodyResultItemsDentryThumbnail extends TeaModel {
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

        public static GetDentriesResponseBodyResultItemsDentryThumbnail build(java.util.Map<String, ?> map) throws Exception {
            GetDentriesResponseBodyResultItemsDentryThumbnail self = new GetDentriesResponseBodyResultItemsDentryThumbnail();
            return TeaModel.build(map, self);
        }

        public GetDentriesResponseBodyResultItemsDentryThumbnail setHeight(Integer height) {
            this.height = height;
            return this;
        }
        public Integer getHeight() {
            return this.height;
        }

        public GetDentriesResponseBodyResultItemsDentryThumbnail setUrl(String url) {
            this.url = url;
            return this;
        }
        public String getUrl() {
            return this.url;
        }

        public GetDentriesResponseBodyResultItemsDentryThumbnail setWidth(Integer width) {
            this.width = width;
            return this;
        }
        public Integer getWidth() {
            return this.width;
        }

    }

    public static class GetDentriesResponseBodyResultItemsDentry extends TeaModel {
        @NameInMap("appProperties")
        public java.util.Map<String, java.util.List<ResultItemsDentryAppPropertiesValue>> appProperties;

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
        public GetDentriesResponseBodyResultItemsDentryProperties properties;

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
        public GetDentriesResponseBodyResultItemsDentryThumbnail thumbnail;

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

        public static GetDentriesResponseBodyResultItemsDentry build(java.util.Map<String, ?> map) throws Exception {
            GetDentriesResponseBodyResultItemsDentry self = new GetDentriesResponseBodyResultItemsDentry();
            return TeaModel.build(map, self);
        }

        public GetDentriesResponseBodyResultItemsDentry setAppProperties(java.util.Map<String, java.util.List<ResultItemsDentryAppPropertiesValue>> appProperties) {
            this.appProperties = appProperties;
            return this;
        }
        public java.util.Map<String, java.util.List<ResultItemsDentryAppPropertiesValue>> getAppProperties() {
            return this.appProperties;
        }

        public GetDentriesResponseBodyResultItemsDentry setCreateTime(String createTime) {
            this.createTime = createTime;
            return this;
        }
        public String getCreateTime() {
            return this.createTime;
        }

        public GetDentriesResponseBodyResultItemsDentry setCreatorId(String creatorId) {
            this.creatorId = creatorId;
            return this;
        }
        public String getCreatorId() {
            return this.creatorId;
        }

        public GetDentriesResponseBodyResultItemsDentry setExtension(String extension) {
            this.extension = extension;
            return this;
        }
        public String getExtension() {
            return this.extension;
        }

        public GetDentriesResponseBodyResultItemsDentry setId(String id) {
            this.id = id;
            return this;
        }
        public String getId() {
            return this.id;
        }

        public GetDentriesResponseBodyResultItemsDentry setModifiedTime(String modifiedTime) {
            this.modifiedTime = modifiedTime;
            return this;
        }
        public String getModifiedTime() {
            return this.modifiedTime;
        }

        public GetDentriesResponseBodyResultItemsDentry setModifierId(String modifierId) {
            this.modifierId = modifierId;
            return this;
        }
        public String getModifierId() {
            return this.modifierId;
        }

        public GetDentriesResponseBodyResultItemsDentry setName(String name) {
            this.name = name;
            return this;
        }
        public String getName() {
            return this.name;
        }

        public GetDentriesResponseBodyResultItemsDentry setParentId(String parentId) {
            this.parentId = parentId;
            return this;
        }
        public String getParentId() {
            return this.parentId;
        }

        public GetDentriesResponseBodyResultItemsDentry setPartitionType(String partitionType) {
            this.partitionType = partitionType;
            return this;
        }
        public String getPartitionType() {
            return this.partitionType;
        }

        public GetDentriesResponseBodyResultItemsDentry setPath(String path) {
            this.path = path;
            return this;
        }
        public String getPath() {
            return this.path;
        }

        public GetDentriesResponseBodyResultItemsDentry setProperties(GetDentriesResponseBodyResultItemsDentryProperties properties) {
            this.properties = properties;
            return this;
        }
        public GetDentriesResponseBodyResultItemsDentryProperties getProperties() {
            return this.properties;
        }

        public GetDentriesResponseBodyResultItemsDentry setSize(Long size) {
            this.size = size;
            return this;
        }
        public Long getSize() {
            return this.size;
        }

        public GetDentriesResponseBodyResultItemsDentry setSpaceId(String spaceId) {
            this.spaceId = spaceId;
            return this;
        }
        public String getSpaceId() {
            return this.spaceId;
        }

        public GetDentriesResponseBodyResultItemsDentry setStatus(String status) {
            this.status = status;
            return this;
        }
        public String getStatus() {
            return this.status;
        }

        public GetDentriesResponseBodyResultItemsDentry setStorageDriver(String storageDriver) {
            this.storageDriver = storageDriver;
            return this;
        }
        public String getStorageDriver() {
            return this.storageDriver;
        }

        public GetDentriesResponseBodyResultItemsDentry setThumbnail(GetDentriesResponseBodyResultItemsDentryThumbnail thumbnail) {
            this.thumbnail = thumbnail;
            return this;
        }
        public GetDentriesResponseBodyResultItemsDentryThumbnail getThumbnail() {
            return this.thumbnail;
        }

        public GetDentriesResponseBodyResultItemsDentry setType(String type) {
            this.type = type;
            return this;
        }
        public String getType() {
            return this.type;
        }

        public GetDentriesResponseBodyResultItemsDentry setUuid(String uuid) {
            this.uuid = uuid;
            return this;
        }
        public String getUuid() {
            return this.uuid;
        }

        public GetDentriesResponseBodyResultItemsDentry setVersion(Long version) {
            this.version = version;
            return this;
        }
        public Long getVersion() {
            return this.version;
        }

    }

    public static class GetDentriesResponseBodyResultItems extends TeaModel {
        @NameInMap("dentry")
        public GetDentriesResponseBodyResultItemsDentry dentry;

        /**
         * <strong>example:</strong>
         * <p>dentry_id</p>
         */
        @NameInMap("dentryId")
        public String dentryId;

        /**
         * <strong>example:</strong>
         * <p>permissionDenied</p>
         */
        @NameInMap("errorCode")
        public String errorCode;

        /**
         * <strong>example:</strong>
         * <p>space_id</p>
         */
        @NameInMap("spaceId")
        public String spaceId;

        /**
         * <strong>example:</strong>
         * <p>true</p>
         */
        @NameInMap("success")
        public Boolean success;

        public static GetDentriesResponseBodyResultItems build(java.util.Map<String, ?> map) throws Exception {
            GetDentriesResponseBodyResultItems self = new GetDentriesResponseBodyResultItems();
            return TeaModel.build(map, self);
        }

        public GetDentriesResponseBodyResultItems setDentry(GetDentriesResponseBodyResultItemsDentry dentry) {
            this.dentry = dentry;
            return this;
        }
        public GetDentriesResponseBodyResultItemsDentry getDentry() {
            return this.dentry;
        }

        public GetDentriesResponseBodyResultItems setDentryId(String dentryId) {
            this.dentryId = dentryId;
            return this;
        }
        public String getDentryId() {
            return this.dentryId;
        }

        public GetDentriesResponseBodyResultItems setErrorCode(String errorCode) {
            this.errorCode = errorCode;
            return this;
        }
        public String getErrorCode() {
            return this.errorCode;
        }

        public GetDentriesResponseBodyResultItems setSpaceId(String spaceId) {
            this.spaceId = spaceId;
            return this;
        }
        public String getSpaceId() {
            return this.spaceId;
        }

        public GetDentriesResponseBodyResultItems setSuccess(Boolean success) {
            this.success = success;
            return this;
        }
        public Boolean getSuccess() {
            return this.success;
        }

    }

}
