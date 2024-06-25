// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkconv_file_1_0.models;

import com.aliyun.tea.*;

public class SendByAppResponseBody extends TeaModel {
    @NameInMap("file")
    public SendByAppResponseBodyFile file;

    public static SendByAppResponseBody build(java.util.Map<String, ?> map) throws Exception {
        SendByAppResponseBody self = new SendByAppResponseBody();
        return TeaModel.build(map, self);
    }

    public SendByAppResponseBody setFile(SendByAppResponseBodyFile file) {
        this.file = file;
        return this;
    }
    public SendByAppResponseBodyFile getFile() {
        return this.file;
    }

    public static class SendByAppResponseBodyFile extends TeaModel {
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

        public static SendByAppResponseBodyFile build(java.util.Map<String, ?> map) throws Exception {
            SendByAppResponseBodyFile self = new SendByAppResponseBodyFile();
            return TeaModel.build(map, self);
        }

        public SendByAppResponseBodyFile setConversationId(String conversationId) {
            this.conversationId = conversationId;
            return this;
        }
        public String getConversationId() {
            return this.conversationId;
        }

        public SendByAppResponseBodyFile setCreateTime(String createTime) {
            this.createTime = createTime;
            return this;
        }
        public String getCreateTime() {
            return this.createTime;
        }

        public SendByAppResponseBodyFile setCreatorId(String creatorId) {
            this.creatorId = creatorId;
            return this;
        }
        public String getCreatorId() {
            return this.creatorId;
        }

        public SendByAppResponseBodyFile setExtension(String extension) {
            this.extension = extension;
            return this;
        }
        public String getExtension() {
            return this.extension;
        }

        public SendByAppResponseBodyFile setId(String id) {
            this.id = id;
            return this;
        }
        public String getId() {
            return this.id;
        }

        public SendByAppResponseBodyFile setModifiedTime(String modifiedTime) {
            this.modifiedTime = modifiedTime;
            return this;
        }
        public String getModifiedTime() {
            return this.modifiedTime;
        }

        public SendByAppResponseBodyFile setModifierId(String modifierId) {
            this.modifierId = modifierId;
            return this;
        }
        public String getModifierId() {
            return this.modifierId;
        }

        public SendByAppResponseBodyFile setName(String name) {
            this.name = name;
            return this;
        }
        public String getName() {
            return this.name;
        }

        public SendByAppResponseBodyFile setParentId(String parentId) {
            this.parentId = parentId;
            return this;
        }
        public String getParentId() {
            return this.parentId;
        }

        public SendByAppResponseBodyFile setPath(String path) {
            this.path = path;
            return this;
        }
        public String getPath() {
            return this.path;
        }

        public SendByAppResponseBodyFile setSize(Long size) {
            this.size = size;
            return this;
        }
        public Long getSize() {
            return this.size;
        }

        public SendByAppResponseBodyFile setSpaceId(String spaceId) {
            this.spaceId = spaceId;
            return this;
        }
        public String getSpaceId() {
            return this.spaceId;
        }

        public SendByAppResponseBodyFile setStatus(String status) {
            this.status = status;
            return this;
        }
        public String getStatus() {
            return this.status;
        }

        public SendByAppResponseBodyFile setType(String type) {
            this.type = type;
            return this;
        }
        public String getType() {
            return this.type;
        }

        public SendByAppResponseBodyFile setUuid(String uuid) {
            this.uuid = uuid;
            return this;
        }
        public String getUuid() {
            return this.uuid;
        }

        public SendByAppResponseBodyFile setVersion(Long version) {
            this.version = version;
            return this;
        }
        public Long getVersion() {
            return this.version;
        }

    }

}
