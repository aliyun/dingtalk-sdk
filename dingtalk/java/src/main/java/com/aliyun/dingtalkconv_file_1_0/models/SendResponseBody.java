// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkconv_file_1_0.models;

import com.aliyun.tea.*;

public class SendResponseBody extends TeaModel {
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
        /**
         * <strong>example:</strong>
         * <p>open_conversation_id</p>
         */
        @NameInMap("conversationId")
        public String conversationId;

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
         * <p>file_id</p>
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
         * <p>modified_id</p>
         */
        @NameInMap("modifierId")
        public String modifierId;

        /**
         * <strong>example:</strong>
         * <p>file_name</p>
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
         * <p>file_path</p>
         */
        @NameInMap("path")
        public String path;

        /**
         * <strong>example:</strong>
         * <p>256</p>
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
