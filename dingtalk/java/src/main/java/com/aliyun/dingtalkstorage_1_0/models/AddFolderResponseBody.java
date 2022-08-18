// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkstorage_1_0.models;

import com.aliyun.tea.*;

public class AddFolderResponseBody extends TeaModel {
    // 文件夹信息
    // dentry.type等于FOLDER表示是文件夹
    @NameInMap("dentry")
    public AddFolderResponseBodyDentry dentry;

    public static AddFolderResponseBody build(java.util.Map<String, ?> map) throws Exception {
        AddFolderResponseBody self = new AddFolderResponseBody();
        return TeaModel.build(map, self);
    }

    public AddFolderResponseBody setDentry(AddFolderResponseBodyDentry dentry) {
        this.dentry = dentry;
        return this;
    }
    public AddFolderResponseBodyDentry getDentry() {
        return this.dentry;
    }

    public static class AddFolderResponseBodyDentryProperties extends TeaModel {
        // 文件是否只读
        @NameInMap("readOnly")
        public Boolean readOnly;

        public static AddFolderResponseBodyDentryProperties build(java.util.Map<String, ?> map) throws Exception {
            AddFolderResponseBodyDentryProperties self = new AddFolderResponseBodyDentryProperties();
            return TeaModel.build(map, self);
        }

        public AddFolderResponseBodyDentryProperties setReadOnly(Boolean readOnly) {
            this.readOnly = readOnly;
            return this;
        }
        public Boolean getReadOnly() {
            return this.readOnly;
        }

    }

    public static class AddFolderResponseBodyDentry extends TeaModel {
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
        public AddFolderResponseBodyDentryProperties properties;

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

        public static AddFolderResponseBodyDentry build(java.util.Map<String, ?> map) throws Exception {
            AddFolderResponseBodyDentry self = new AddFolderResponseBodyDentry();
            return TeaModel.build(map, self);
        }

        public AddFolderResponseBodyDentry setCreateTime(String createTime) {
            this.createTime = createTime;
            return this;
        }
        public String getCreateTime() {
            return this.createTime;
        }

        public AddFolderResponseBodyDentry setCreatorId(String creatorId) {
            this.creatorId = creatorId;
            return this;
        }
        public String getCreatorId() {
            return this.creatorId;
        }

        public AddFolderResponseBodyDentry setExtension(String extension) {
            this.extension = extension;
            return this;
        }
        public String getExtension() {
            return this.extension;
        }

        public AddFolderResponseBodyDentry setId(String id) {
            this.id = id;
            return this;
        }
        public String getId() {
            return this.id;
        }

        public AddFolderResponseBodyDentry setModifiedTime(String modifiedTime) {
            this.modifiedTime = modifiedTime;
            return this;
        }
        public String getModifiedTime() {
            return this.modifiedTime;
        }

        public AddFolderResponseBodyDentry setModifierId(String modifierId) {
            this.modifierId = modifierId;
            return this;
        }
        public String getModifierId() {
            return this.modifierId;
        }

        public AddFolderResponseBodyDentry setName(String name) {
            this.name = name;
            return this;
        }
        public String getName() {
            return this.name;
        }

        public AddFolderResponseBodyDentry setParentId(String parentId) {
            this.parentId = parentId;
            return this;
        }
        public String getParentId() {
            return this.parentId;
        }

        public AddFolderResponseBodyDentry setPartitionType(String partitionType) {
            this.partitionType = partitionType;
            return this;
        }
        public String getPartitionType() {
            return this.partitionType;
        }

        public AddFolderResponseBodyDentry setPath(String path) {
            this.path = path;
            return this;
        }
        public String getPath() {
            return this.path;
        }

        public AddFolderResponseBodyDentry setProperties(AddFolderResponseBodyDentryProperties properties) {
            this.properties = properties;
            return this;
        }
        public AddFolderResponseBodyDentryProperties getProperties() {
            return this.properties;
        }

        public AddFolderResponseBodyDentry setSize(Long size) {
            this.size = size;
            return this;
        }
        public Long getSize() {
            return this.size;
        }

        public AddFolderResponseBodyDentry setSpaceId(String spaceId) {
            this.spaceId = spaceId;
            return this;
        }
        public String getSpaceId() {
            return this.spaceId;
        }

        public AddFolderResponseBodyDentry setStatus(String status) {
            this.status = status;
            return this;
        }
        public String getStatus() {
            return this.status;
        }

        public AddFolderResponseBodyDentry setStorageDriver(String storageDriver) {
            this.storageDriver = storageDriver;
            return this;
        }
        public String getStorageDriver() {
            return this.storageDriver;
        }

        public AddFolderResponseBodyDentry setType(String type) {
            this.type = type;
            return this;
        }
        public String getType() {
            return this.type;
        }

        public AddFolderResponseBodyDentry setUuid(String uuid) {
            this.uuid = uuid;
            return this;
        }
        public String getUuid() {
            return this.uuid;
        }

        public AddFolderResponseBodyDentry setVersion(Long version) {
            this.version = version;
            return this;
        }
        public Long getVersion() {
            return this.version;
        }

    }

}