// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkstorage_1_0.models;

import com.aliyun.tea.*;

public class GetDentriesResponseBody extends TeaModel {
    /**
     * <p>批量获取文件(夹)信息结果列表</p>
     * <p>最大size:</p>
     * <p>	30</p>
     */
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
         * <p>文件是否只读</p>
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
         * <p>缩略图高度</p>
         */
        @NameInMap("height")
        public Integer height;

        /**
         * <p>缩略图url</p>
         */
        @NameInMap("url")
        public String url;

        /**
         * <p>缩略图宽度</p>
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
        /**
         * <p>在特定应用上的属性。key是微应用Id, value是属性列表。</p>
         * <p>可以通过修改DentryAppProperty里的scope来设置属性的可见性</p>
         * <p>最大size:</p>
         * <p>	10</p>
         */
        @NameInMap("appProperties")
        public java.util.Map<String, java.util.List<ResultItemsDentryAppPropertiesValue>> appProperties;

        /**
         * <p>创建时间</p>
         */
        @NameInMap("createTime")
        public String createTime;

        /**
         * <p>创建者id</p>
         */
        @NameInMap("creatorId")
        public String creatorId;

        /**
         * <p>后缀</p>
         */
        @NameInMap("extension")
        public String extension;

        /**
         * <p>id</p>
         */
        @NameInMap("id")
        public String id;

        /**
         * <p>修改时间</p>
         */
        @NameInMap("modifiedTime")
        public String modifiedTime;

        /**
         * <p>修改者id</p>
         */
        @NameInMap("modifierId")
        public String modifierId;

        /**
         * <p>名称</p>
         */
        @NameInMap("name")
        public String name;

        /**
         * <p>父目录id, 根目录id值为0</p>
         * <p>空值代表根目录的parentId不存在</p>
         */
        @NameInMap("parentId")
        public String parentId;

        /**
         * <p>存储分区，目前包括公有云OSS存储分区和专属Mini OSS存储分区</p>
         * <p>枚举值:</p>
         * <p>	PUBLIC_OSS_PARTITION: 公有云OSS存储分区</p>
         * <p>	MINI_OSS_PARTITION: 专属Mini OSS存储分区</p>
         */
        @NameInMap("partitionType")
        public String partitionType;

        /**
         * <p>路径</p>
         */
        @NameInMap("path")
        public String path;

        /**
         * <p>属性</p>
         */
        @NameInMap("properties")
        public GetDentriesResponseBodyResultItemsDentryProperties properties;

        /**
         * <p>大小, 单位:Byte</p>
         */
        @NameInMap("size")
        public Long size;

        /**
         * <p>所在空间id</p>
         */
        @NameInMap("spaceId")
        public String spaceId;

        /**
         * <p>状态</p>
         * <p>枚举值:</p>
         * <p>	NORMAL: 正常</p>
         * <p>	DELETED: 已删除</p>
         * <p>	EXPIRED: 已过期</p>
         */
        @NameInMap("status")
        public String status;

        /**
         * <p>驱动类型</p>
         * <p>枚举值:</p>
         * <p>	DINGTALK: 钉钉统一存储驱动</p>
         * <p>	ALIDOC: 钉钉文档存储驱动</p>
         * <p>	SHANJI: 闪记存储驱动</p>
         * <p>	UNKNOWN: 未知驱动</p>
         */
        @NameInMap("storageDriver")
        public String storageDriver;

        /**
         * <p>缩略图信息</p>
         */
        @NameInMap("thumbnail")
        public GetDentriesResponseBodyResultItemsDentryThumbnail thumbnail;

        /**
         * <p>类型，目录或文件</p>
         * <p>枚举值:</p>
         * <p>	FILE: 文件</p>
         * <p>	FOLDER: 文件夹</p>
         */
        @NameInMap("type")
        public String type;

        /**
         * <p>uuid，如移动文件，此字段不变</p>
         */
        @NameInMap("uuid")
        public String uuid;

        /**
         * <p>版本</p>
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
        /**
         * <p>文件(夹)信息</p>
         */
        @NameInMap("dentry")
        public GetDentriesResponseBodyResultItemsDentry dentry;

        /**
         * <p>文件(夹)id</p>
         */
        @NameInMap("dentryId")
        public String dentryId;

        /**
         * <p>错误原因</p>
         */
        @NameInMap("errorCode")
        public String errorCode;

        /**
         * <p>文件(夹)空间id</p>
         */
        @NameInMap("spaceId")
        public String spaceId;

        /**
         * <p>是否成功</p>
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
