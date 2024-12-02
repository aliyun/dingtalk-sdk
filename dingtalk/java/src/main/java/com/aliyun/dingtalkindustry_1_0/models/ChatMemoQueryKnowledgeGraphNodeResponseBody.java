// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkindustry_1_0.models;

import com.aliyun.tea.*;

public class ChatMemoQueryKnowledgeGraphNodeResponseBody extends TeaModel {
    /**
     * <strong>example:</strong>
     * <p>xxxxx</p>
     */
    @NameInMap("bizId")
    public String bizId;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("nodeInfo")
    public ChatMemoQueryKnowledgeGraphNodeResponseBodyNodeInfo nodeInfo;

    public static ChatMemoQueryKnowledgeGraphNodeResponseBody build(java.util.Map<String, ?> map) throws Exception {
        ChatMemoQueryKnowledgeGraphNodeResponseBody self = new ChatMemoQueryKnowledgeGraphNodeResponseBody();
        return TeaModel.build(map, self);
    }

    public ChatMemoQueryKnowledgeGraphNodeResponseBody setBizId(String bizId) {
        this.bizId = bizId;
        return this;
    }
    public String getBizId() {
        return this.bizId;
    }

    public ChatMemoQueryKnowledgeGraphNodeResponseBody setNodeInfo(ChatMemoQueryKnowledgeGraphNodeResponseBodyNodeInfo nodeInfo) {
        this.nodeInfo = nodeInfo;
        return this;
    }
    public ChatMemoQueryKnowledgeGraphNodeResponseBodyNodeInfo getNodeInfo() {
        return this.nodeInfo;
    }

    public static class ChatMemoQueryKnowledgeGraphNodeResponseBodyNodeInfo extends TeaModel {
        /**
         * <strong>example:</strong>
         * <p>xxxxxx</p>
         */
        @NameInMap("mediaId")
        public String mediaId;

        /**
         * <p>This parameter is required.</p>
         * 
         * <strong>example:</strong>
         * <p>人物</p>
         */
        @NameInMap("nodeLabel")
        public String nodeLabel;

        /**
         * <p>This parameter is required.</p>
         * 
         * <strong>example:</strong>
         * <p>刘备</p>
         */
        @NameInMap("nodeName")
        public String nodeName;

        /**
         * <strong>example:</strong>
         * <p>{&quot;年龄&quot;：43}</p>
         */
        @NameInMap("propertiesString")
        public String propertiesString;

        public static ChatMemoQueryKnowledgeGraphNodeResponseBodyNodeInfo build(java.util.Map<String, ?> map) throws Exception {
            ChatMemoQueryKnowledgeGraphNodeResponseBodyNodeInfo self = new ChatMemoQueryKnowledgeGraphNodeResponseBodyNodeInfo();
            return TeaModel.build(map, self);
        }

        public ChatMemoQueryKnowledgeGraphNodeResponseBodyNodeInfo setMediaId(String mediaId) {
            this.mediaId = mediaId;
            return this;
        }
        public String getMediaId() {
            return this.mediaId;
        }

        public ChatMemoQueryKnowledgeGraphNodeResponseBodyNodeInfo setNodeLabel(String nodeLabel) {
            this.nodeLabel = nodeLabel;
            return this;
        }
        public String getNodeLabel() {
            return this.nodeLabel;
        }

        public ChatMemoQueryKnowledgeGraphNodeResponseBodyNodeInfo setNodeName(String nodeName) {
            this.nodeName = nodeName;
            return this;
        }
        public String getNodeName() {
            return this.nodeName;
        }

        public ChatMemoQueryKnowledgeGraphNodeResponseBodyNodeInfo setPropertiesString(String propertiesString) {
            this.propertiesString = propertiesString;
            return this;
        }
        public String getPropertiesString() {
            return this.propertiesString;
        }

    }

}
