// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkindustry_1_0.models;

import com.aliyun.tea.*;

public class ChatMemoAddKnowledgeGraphNodeRequest extends TeaModel {
    /**
     * <strong>example:</strong>
     * <p>xxxxxx</p>
     */
    @NameInMap("bizId")
    public String bizId;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>111111</p>
     */
    @NameInMap("datasetId")
    public Long datasetId;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("nodeInfo")
    public ChatMemoAddKnowledgeGraphNodeRequestNodeInfo nodeInfo;

    public static ChatMemoAddKnowledgeGraphNodeRequest build(java.util.Map<String, ?> map) throws Exception {
        ChatMemoAddKnowledgeGraphNodeRequest self = new ChatMemoAddKnowledgeGraphNodeRequest();
        return TeaModel.build(map, self);
    }

    public ChatMemoAddKnowledgeGraphNodeRequest setBizId(String bizId) {
        this.bizId = bizId;
        return this;
    }
    public String getBizId() {
        return this.bizId;
    }

    public ChatMemoAddKnowledgeGraphNodeRequest setDatasetId(Long datasetId) {
        this.datasetId = datasetId;
        return this;
    }
    public Long getDatasetId() {
        return this.datasetId;
    }

    public ChatMemoAddKnowledgeGraphNodeRequest setNodeInfo(ChatMemoAddKnowledgeGraphNodeRequestNodeInfo nodeInfo) {
        this.nodeInfo = nodeInfo;
        return this;
    }
    public ChatMemoAddKnowledgeGraphNodeRequestNodeInfo getNodeInfo() {
        return this.nodeInfo;
    }

    public static class ChatMemoAddKnowledgeGraphNodeRequestNodeInfo extends TeaModel {
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

        public static ChatMemoAddKnowledgeGraphNodeRequestNodeInfo build(java.util.Map<String, ?> map) throws Exception {
            ChatMemoAddKnowledgeGraphNodeRequestNodeInfo self = new ChatMemoAddKnowledgeGraphNodeRequestNodeInfo();
            return TeaModel.build(map, self);
        }

        public ChatMemoAddKnowledgeGraphNodeRequestNodeInfo setNodeLabel(String nodeLabel) {
            this.nodeLabel = nodeLabel;
            return this;
        }
        public String getNodeLabel() {
            return this.nodeLabel;
        }

        public ChatMemoAddKnowledgeGraphNodeRequestNodeInfo setNodeName(String nodeName) {
            this.nodeName = nodeName;
            return this;
        }
        public String getNodeName() {
            return this.nodeName;
        }

        public ChatMemoAddKnowledgeGraphNodeRequestNodeInfo setPropertiesString(String propertiesString) {
            this.propertiesString = propertiesString;
            return this;
        }
        public String getPropertiesString() {
            return this.propertiesString;
        }

    }

}
