// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalksns_storage_1_0.models;

import com.aliyun.tea.*;

public class GetDentriesResponseBody extends TeaModel {
    // 批量获取文件(夹)信息结果列表
    // 最大size:
    // 	30
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
        // 文件是否只读
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
        // 缩略图高度
        @NameInMap("height")
        public Integer height;

        // 缩略图url
        @NameInMap("url")
        public String url;

        // 缩略图宽度
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
        // 在特定应用上的属性。key是微应用Id, value是属性列表。
        // 可以通过修改DentryAppProperty里的scope来设置属性的可见性
        // 最大size:
        // 	10
        @NameInMap("appProperties")
        public java.util.Map<String, java.util.List<ResultItemsDentryAppPropertiesValue>> appProperties;

        // 创建时间
        @NameInMap("createTime")
        public String createTime;

        // 创建者id
        @NameInMap("creatorId")
        public String creatorId;

        // 后缀
        @NameInMap("extension")
        public String extension;

        // id
        @NameInMap("id")
        public String id;

        // 修改时间
        @NameInMap("modifiedTime")
        public String modifiedTime;

        // 修改者id
        @NameInMap("modifierId")
        public String modifierId;

        // 名称
        @NameInMap("name")
        public String name;

        // 父目录id, 根目录id值为0
        // 空值代表根目录的parentId不存在
        @NameInMap("parentId")
        public String parentId;

        // 存储分区，目前包括公有云OSS存储分区和专属Mini OSS存储分区
        // 枚举值:
        // 	PUBLIC_OSS_PARTITION: 公有云OSS存储分区
        // 	MINI_OSS_PARTITION: 专属Mini OSS存储分区
        @NameInMap("partitionType")
        public String partitionType;

        // 路径
        @NameInMap("path")
        public String path;

        // 属性
        @NameInMap("properties")
        public GetDentriesResponseBodyResultItemsDentryProperties properties;

        // 大小, 单位:Byte
        @NameInMap("size")
        public Long size;

        // 所在空间id
        @NameInMap("spaceId")
        public String spaceId;

        // 状态
        // 枚举值:
        // 	NORMAL: 正常
        // 	DELETED: 已删除
        // 	EXPIRED: 已过期
        @NameInMap("status")
        public String status;

        // 驱动类型
        // 枚举值:
        // 	DINGTALK: 钉钉统一存储驱动
        // 	ALIDOC: 钉钉文档存储驱动
        // 	SHANJI: 闪记存储驱动
        // 	UNKNOWN: 未知驱动
        @NameInMap("storageDriver")
        public String storageDriver;

        // 缩略图信息
        @NameInMap("thumbnail")
        public GetDentriesResponseBodyResultItemsDentryThumbnail thumbnail;

        // 类型，目录或文件
        // 枚举值:
        // 	FILE: 文件
        // 	FOLDER: 文件夹
        @NameInMap("type")
        public String type;

        // uuid，如移动文件，此字段不变
        @NameInMap("uuid")
        public String uuid;

        // 版本
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
        // 文件(夹)信息
        @NameInMap("dentry")
        public GetDentriesResponseBodyResultItemsDentry dentry;

        // 文件(夹)id
        @NameInMap("dentryId")
        public String dentryId;

        // 错误原因
        @NameInMap("errorCode")
        public String errorCode;

        // 文件(夹)空间id
        @NameInMap("spaceId")
        public String spaceId;

        // 是否成功
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
