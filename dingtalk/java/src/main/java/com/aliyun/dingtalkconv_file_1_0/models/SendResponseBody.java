// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkconv_file_1_0.models;

import com.aliyun.tea.*;

public class SendResponseBody extends TeaModel {
    // 发送到目标会话的文件信息
    @NameInMap("file")
    public SendResponseBodyFile file;

    public static SendResponseBody build(java.util.Map<String, ?> map) throws Exception {
        SendResponseBody self = new SendResponseBody();
        return TeaModel.build(map, self);
    }

    public SendResponseBody setFile(SendResponseBodyFile file) {
        this.file = file;
        return this;
    }
    public SendResponseBodyFile getFile() {
        return this.file;
    }

    public static class SendResponseBodyFile extends TeaModel {
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

        public static SendResponseBodyFile build(java.util.Map<String, ?> map) throws Exception {
            SendResponseBodyFile self = new SendResponseBodyFile();
            return TeaModel.build(map, self);
        }

        public SendResponseBodyFile setConversationId(String conversationId) {
            this.conversationId = conversationId;
            return this;
        }
        public String getConversationId() {
            return this.conversationId;
        }

        public SendResponseBodyFile setCreateTime(String createTime) {
            this.createTime = createTime;
            return this;
        }
        public String getCreateTime() {
            return this.createTime;
        }

        public SendResponseBodyFile setCreatorId(String creatorId) {
            this.creatorId = creatorId;
            return this;
        }
        public String getCreatorId() {
            return this.creatorId;
        }

        public SendResponseBodyFile setExtension(String extension) {
            this.extension = extension;
            return this;
        }
        public String getExtension() {
            return this.extension;
        }

        public SendResponseBodyFile setId(String id) {
            this.id = id;
            return this;
        }
        public String getId() {
            return this.id;
        }

        public SendResponseBodyFile setModifiedTime(String modifiedTime) {
            this.modifiedTime = modifiedTime;
            return this;
        }
        public String getModifiedTime() {
            return this.modifiedTime;
        }

        public SendResponseBodyFile setModifierId(String modifierId) {
            this.modifierId = modifierId;
            return this;
        }
        public String getModifierId() {
            return this.modifierId;
        }

        public SendResponseBodyFile setName(String name) {
            this.name = name;
            return this;
        }
        public String getName() {
            return this.name;
        }

        public SendResponseBodyFile setParentId(String parentId) {
            this.parentId = parentId;
            return this;
        }
        public String getParentId() {
            return this.parentId;
        }

        public SendResponseBodyFile setPath(String path) {
            this.path = path;
            return this;
        }
        public String getPath() {
            return this.path;
        }

        public SendResponseBodyFile setSize(Long size) {
            this.size = size;
            return this;
        }
        public Long getSize() {
            return this.size;
        }

        public SendResponseBodyFile setSpaceId(String spaceId) {
            this.spaceId = spaceId;
            return this;
        }
        public String getSpaceId() {
            return this.spaceId;
        }

        public SendResponseBodyFile setStatus(String status) {
            this.status = status;
            return this;
        }
        public String getStatus() {
            return this.status;
        }

        public SendResponseBodyFile setType(String type) {
            this.type = type;
            return this;
        }
        public String getType() {
            return this.type;
        }

        public SendResponseBodyFile setUuid(String uuid) {
            this.uuid = uuid;
            return this;
        }
        public String getUuid() {
            return this.uuid;
        }

        public SendResponseBodyFile setVersion(Long version) {
            this.version = version;
            return this;
        }
        public Long getVersion() {
            return this.version;
        }

    }

}
