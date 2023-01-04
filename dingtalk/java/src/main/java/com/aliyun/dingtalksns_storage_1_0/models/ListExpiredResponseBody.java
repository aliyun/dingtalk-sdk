// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalksns_storage_1_0.models;

import com.aliyun.tea.*;

public class ListExpiredResponseBody extends TeaModel {
    // 过期文件列表
    // 最大size:
    // 	50
    @NameInMap("files")
    public java.util.List<ListExpiredResponseBodyFiles> files;

    // 分页游标
    // 不为空表示有更多数据
    @NameInMap("nextToken")
    public String nextToken;

    public static ListExpiredResponseBody build(java.util.Map<String, ?> map) throws Exception {
        ListExpiredResponseBody self = new ListExpiredResponseBody();
        return TeaModel.build(map, self);
    }

    public ListExpiredResponseBody setFiles(java.util.List<ListExpiredResponseBodyFiles> files) {
        this.files = files;
        return this;
    }
    public java.util.List<ListExpiredResponseBodyFiles> getFiles() {
        return this.files;
    }

    public ListExpiredResponseBody setNextToken(String nextToken) {
        this.nextToken = nextToken;
        return this;
    }
    public String getNextToken() {
        return this.nextToken;
    }

    public static class ListExpiredResponseBodyFiles extends TeaModel {
        // 文件所在会话id
        @NameInMap("conversationId")
        public String conversationId;

        // 创建时间
        @NameInMap("createTime")
        public String createTime;

        // 创建者id
        @NameInMap("creatorId")
        public String creatorId;

        // 文件后缀
        @NameInMap("extension")
        public String extension;

        // 文件id
        @NameInMap("id")
        public String id;

        // 修改时间
        @NameInMap("modifiedTime")
        public String modifiedTime;

        // 修改者id
        @NameInMap("modifierId")
        public String modifierId;

        // 文件(夹)名称
        @NameInMap("name")
        public String name;

        // 文件所在的父目录id, 根目录id值为0
        @NameInMap("parentId")
        public String parentId;

        // 文件路径
        @NameInMap("path")
        public String path;

        // 文件大小, 单位:Byte
        @NameInMap("size")
        public Long size;

        // 文件所在空间id
        @NameInMap("spaceId")
        public String spaceId;

        // 文件状态
        // 枚举值:
        // 	NORMAL: 正常
        // 	DELETED: 已删除
        // 	EXPIRED: 已过期
        @NameInMap("status")
        public String status;

        // 文件类型：文件、文件夹
        // 枚举值:
        // 	FILE: 文件
        // 	FOLDER: 文件夹
        @NameInMap("type")
        public String type;

        // uuid，如移动文件，此字段不变
        @NameInMap("uuid")
        public String uuid;

        // 文件版本
        @NameInMap("version")
        public Long version;

        public static ListExpiredResponseBodyFiles build(java.util.Map<String, ?> map) throws Exception {
            ListExpiredResponseBodyFiles self = new ListExpiredResponseBodyFiles();
            return TeaModel.build(map, self);
        }

        public ListExpiredResponseBodyFiles setConversationId(String conversationId) {
            this.conversationId = conversationId;
            return this;
        }
        public String getConversationId() {
            return this.conversationId;
        }

        public ListExpiredResponseBodyFiles setCreateTime(String createTime) {
            this.createTime = createTime;
            return this;
        }
        public String getCreateTime() {
            return this.createTime;
        }

        public ListExpiredResponseBodyFiles setCreatorId(String creatorId) {
            this.creatorId = creatorId;
            return this;
        }
        public String getCreatorId() {
            return this.creatorId;
        }

        public ListExpiredResponseBodyFiles setExtension(String extension) {
            this.extension = extension;
            return this;
        }
        public String getExtension() {
            return this.extension;
        }

        public ListExpiredResponseBodyFiles setId(String id) {
            this.id = id;
            return this;
        }
        public String getId() {
            return this.id;
        }

        public ListExpiredResponseBodyFiles setModifiedTime(String modifiedTime) {
            this.modifiedTime = modifiedTime;
            return this;
        }
        public String getModifiedTime() {
            return this.modifiedTime;
        }

        public ListExpiredResponseBodyFiles setModifierId(String modifierId) {
            this.modifierId = modifierId;
            return this;
        }
        public String getModifierId() {
            return this.modifierId;
        }

        public ListExpiredResponseBodyFiles setName(String name) {
            this.name = name;
            return this;
        }
        public String getName() {
            return this.name;
        }

        public ListExpiredResponseBodyFiles setParentId(String parentId) {
            this.parentId = parentId;
            return this;
        }
        public String getParentId() {
            return this.parentId;
        }

        public ListExpiredResponseBodyFiles setPath(String path) {
            this.path = path;
            return this;
        }
        public String getPath() {
            return this.path;
        }

        public ListExpiredResponseBodyFiles setSize(Long size) {
            this.size = size;
            return this;
        }
        public Long getSize() {
            return this.size;
        }

        public ListExpiredResponseBodyFiles setSpaceId(String spaceId) {
            this.spaceId = spaceId;
            return this;
        }
        public String getSpaceId() {
            return this.spaceId;
        }

        public ListExpiredResponseBodyFiles setStatus(String status) {
            this.status = status;
            return this;
        }
        public String getStatus() {
            return this.status;
        }

        public ListExpiredResponseBodyFiles setType(String type) {
            this.type = type;
            return this;
        }
        public String getType() {
            return this.type;
        }

        public ListExpiredResponseBodyFiles setUuid(String uuid) {
            this.uuid = uuid;
            return this;
        }
        public String getUuid() {
            return this.uuid;
        }

        public ListExpiredResponseBodyFiles setVersion(Long version) {
            this.version = version;
            return this;
        }
        public Long getVersion() {
            return this.version;
        }

    }

}
