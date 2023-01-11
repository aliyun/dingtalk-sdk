// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkstorage_1_0.models;

import com.aliyun.tea.*;

public class AddFolderResponseBody extends TeaModel {
    /**
     * <p>文件夹信息</p>
     * <p>dentry.type等于FOLDER表示是文件夹</p>
     */
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
        /**
         * <p>文件是否只读</p>
         */
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
        /**
         * <p>在特定应用上的属性。key是微应用Id, value是属性列表。</p>
         * <p>可以通过修改DentryAppProperty里的scope来设置属性的可见性</p>
         * <p>最大size:</p>
         * <p>	10</p>
         */
        @NameInMap("appProperties")
        public java.util.Map<String, java.util.List<DentryAppPropertiesValue>> appProperties;

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
        public AddFolderResponseBodyDentryProperties properties;

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

        public static AddFolderResponseBodyDentry build(java.util.Map<String, ?> map) throws Exception {
            AddFolderResponseBodyDentry self = new AddFolderResponseBodyDentry();
            return TeaModel.build(map, self);
        }

        public AddFolderResponseBodyDentry setAppProperties(java.util.Map<String, java.util.List<DentryAppPropertiesValue>> appProperties) {
            this.appProperties = appProperties;
            return this;
        }
        public java.util.Map<String, java.util.List<DentryAppPropertiesValue>> getAppProperties() {
            return this.appProperties;
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
