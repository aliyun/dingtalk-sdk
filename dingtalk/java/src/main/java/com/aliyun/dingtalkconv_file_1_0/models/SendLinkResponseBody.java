// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkconv_file_1_0.models;

import com.aliyun.tea.*;

public class SendLinkResponseBody extends TeaModel {
    /**
     * <p>发送到目标会话的文件链接信息</p>
     */
    @NameInMap("file")
    public SendLinkResponseBodyFile file;

    public static SendLinkResponseBody build(java.util.Map<String, ?> map) throws Exception {
        SendLinkResponseBody self = new SendLinkResponseBody();
        return TeaModel.build(map, self);
    }

    public SendLinkResponseBody setFile(SendLinkResponseBodyFile file) {
        this.file = file;
        return this;
    }
    public SendLinkResponseBodyFile getFile() {
        return this.file;
    }

    public static class SendLinkResponseBodyFile extends TeaModel {
        /**
         * <p>文件所在会话id</p>
         */
        @NameInMap("conversationId")
        public String conversationId;

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
         * <p>文件后缀</p>
         */
        @NameInMap("extension")
        public String extension;

        /**
         * <p>文件id</p>
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
         * <p>文件(夹)名称</p>
         */
        @NameInMap("name")
        public String name;

        /**
         * <p>文件所在的父目录id, 根目录id值为0</p>
         */
        @NameInMap("parentId")
        public String parentId;

        /**
         * <p>文件路径</p>
         */
        @NameInMap("path")
        public String path;

        /**
         * <p>文件大小, 单位:Byte</p>
         */
        @NameInMap("size")
        public Long size;

        /**
         * <p>文件所在空间id</p>
         */
        @NameInMap("spaceId")
        public String spaceId;

        /**
         * <p>文件状态</p>
         * <p>枚举值:</p>
         * <p>	NORMAL: 正常</p>
         * <p>	DELETED: 已删除</p>
         * <p>	EXPIRED: 已过期</p>
         */
        @NameInMap("status")
        public String status;

        /**
         * <p>文件类型：文件、文件夹</p>
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
         * <p>文件版本</p>
         */
        @NameInMap("version")
        public Long version;

        public static SendLinkResponseBodyFile build(java.util.Map<String, ?> map) throws Exception {
            SendLinkResponseBodyFile self = new SendLinkResponseBodyFile();
            return TeaModel.build(map, self);
        }

        public SendLinkResponseBodyFile setConversationId(String conversationId) {
            this.conversationId = conversationId;
            return this;
        }
        public String getConversationId() {
            return this.conversationId;
        }

        public SendLinkResponseBodyFile setCreateTime(String createTime) {
            this.createTime = createTime;
            return this;
        }
        public String getCreateTime() {
            return this.createTime;
        }

        public SendLinkResponseBodyFile setCreatorId(String creatorId) {
            this.creatorId = creatorId;
            return this;
        }
        public String getCreatorId() {
            return this.creatorId;
        }

        public SendLinkResponseBodyFile setExtension(String extension) {
            this.extension = extension;
            return this;
        }
        public String getExtension() {
            return this.extension;
        }

        public SendLinkResponseBodyFile setId(String id) {
            this.id = id;
            return this;
        }
        public String getId() {
            return this.id;
        }

        public SendLinkResponseBodyFile setModifiedTime(String modifiedTime) {
            this.modifiedTime = modifiedTime;
            return this;
        }
        public String getModifiedTime() {
            return this.modifiedTime;
        }

        public SendLinkResponseBodyFile setModifierId(String modifierId) {
            this.modifierId = modifierId;
            return this;
        }
        public String getModifierId() {
            return this.modifierId;
        }

        public SendLinkResponseBodyFile setName(String name) {
            this.name = name;
            return this;
        }
        public String getName() {
            return this.name;
        }

        public SendLinkResponseBodyFile setParentId(String parentId) {
            this.parentId = parentId;
            return this;
        }
        public String getParentId() {
            return this.parentId;
        }

        public SendLinkResponseBodyFile setPath(String path) {
            this.path = path;
            return this;
        }
        public String getPath() {
            return this.path;
        }

        public SendLinkResponseBodyFile setSize(Long size) {
            this.size = size;
            return this;
        }
        public Long getSize() {
            return this.size;
        }

        public SendLinkResponseBodyFile setSpaceId(String spaceId) {
            this.spaceId = spaceId;
            return this;
        }
        public String getSpaceId() {
            return this.spaceId;
        }

        public SendLinkResponseBodyFile setStatus(String status) {
            this.status = status;
            return this;
        }
        public String getStatus() {
            return this.status;
        }

        public SendLinkResponseBodyFile setType(String type) {
            this.type = type;
            return this;
        }
        public String getType() {
            return this.type;
        }

        public SendLinkResponseBodyFile setUuid(String uuid) {
            this.uuid = uuid;
            return this;
        }
        public String getUuid() {
            return this.uuid;
        }

        public SendLinkResponseBodyFile setVersion(Long version) {
            this.version = version;
            return this;
        }
        public Long getVersion() {
            return this.version;
        }

    }

}
