// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkindustry_1_0.models;

import com.aliyun.tea.*;

public class ChatMemoQueryKnowledgeGraphRelationResponseBody extends TeaModel {
    /**
     * <strong>example:</strong>
     * <p>xxxxx</p>
     */
    @NameInMap("bizId")
    public String bizId;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("relationInfo")
    public ChatMemoQueryKnowledgeGraphRelationResponseBodyRelationInfo relationInfo;

    public static ChatMemoQueryKnowledgeGraphRelationResponseBody build(java.util.Map<String, ?> map) throws Exception {
        ChatMemoQueryKnowledgeGraphRelationResponseBody self = new ChatMemoQueryKnowledgeGraphRelationResponseBody();
        return TeaModel.build(map, self);
    }

    public ChatMemoQueryKnowledgeGraphRelationResponseBody setBizId(String bizId) {
        this.bizId = bizId;
        return this;
    }
    public String getBizId() {
        return this.bizId;
    }

    public ChatMemoQueryKnowledgeGraphRelationResponseBody setRelationInfo(ChatMemoQueryKnowledgeGraphRelationResponseBodyRelationInfo relationInfo) {
        this.relationInfo = relationInfo;
        return this;
    }
    public ChatMemoQueryKnowledgeGraphRelationResponseBodyRelationInfo getRelationInfo() {
        return this.relationInfo;
    }

    public static class ChatMemoQueryKnowledgeGraphRelationResponseBodyRelationInfo extends TeaModel {
        /**
         * <strong>example:</strong>
         * <p>xxxx</p>
         */
        @NameInMap("endId")
        public String endId;

        /**
         * <strong>example:</strong>
         * <p>xxxxxx</p>
         */
        @NameInMap("mediaId")
        public String mediaId;

        /**
         * <strong>example:</strong>
         * <p>{&quot;年龄&quot;：43}</p>
         */
        @NameInMap("propertiesString")
        public String propertiesString;

        /**
         * <p>This parameter is required.</p>
         * 
         * <strong>example:</strong>
         * <p>出生于</p>
         */
        @NameInMap("relationName")
        public String relationName;

        /**
         * <p>This parameter is required.</p>
         * 
         * <strong>example:</strong>
         * <p>xxxx</p>
         */
        @NameInMap("startId")
        public String startId;

        public static ChatMemoQueryKnowledgeGraphRelationResponseBodyRelationInfo build(java.util.Map<String, ?> map) throws Exception {
            ChatMemoQueryKnowledgeGraphRelationResponseBodyRelationInfo self = new ChatMemoQueryKnowledgeGraphRelationResponseBodyRelationInfo();
            return TeaModel.build(map, self);
        }

        public ChatMemoQueryKnowledgeGraphRelationResponseBodyRelationInfo setEndId(String endId) {
            this.endId = endId;
            return this;
        }
        public String getEndId() {
            return this.endId;
        }

        public ChatMemoQueryKnowledgeGraphRelationResponseBodyRelationInfo setMediaId(String mediaId) {
            this.mediaId = mediaId;
            return this;
        }
        public String getMediaId() {
            return this.mediaId;
        }

        public ChatMemoQueryKnowledgeGraphRelationResponseBodyRelationInfo setPropertiesString(String propertiesString) {
            this.propertiesString = propertiesString;
            return this;
        }
        public String getPropertiesString() {
            return this.propertiesString;
        }

        public ChatMemoQueryKnowledgeGraphRelationResponseBodyRelationInfo setRelationName(String relationName) {
            this.relationName = relationName;
            return this;
        }
        public String getRelationName() {
            return this.relationName;
        }

        public ChatMemoQueryKnowledgeGraphRelationResponseBodyRelationInfo setStartId(String startId) {
            this.startId = startId;
            return this;
        }
        public String getStartId() {
            return this.startId;
        }

    }

}
