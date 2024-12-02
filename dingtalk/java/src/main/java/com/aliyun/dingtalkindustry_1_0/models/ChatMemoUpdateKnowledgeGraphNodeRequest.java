// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkindustry_1_0.models;

import com.aliyun.tea.*;

public class ChatMemoUpdateKnowledgeGraphNodeRequest extends TeaModel {
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
    public ChatMemoUpdateKnowledgeGraphNodeRequestNodeInfo nodeInfo;

    public static ChatMemoUpdateKnowledgeGraphNodeRequest build(java.util.Map<String, ?> map) throws Exception {
        ChatMemoUpdateKnowledgeGraphNodeRequest self = new ChatMemoUpdateKnowledgeGraphNodeRequest();
        return TeaModel.build(map, self);
    }

    public ChatMemoUpdateKnowledgeGraphNodeRequest setBizId(String bizId) {
        this.bizId = bizId;
        return this;
    }
    public String getBizId() {
        return this.bizId;
    }

    public ChatMemoUpdateKnowledgeGraphNodeRequest setDatasetId(Long datasetId) {
        this.datasetId = datasetId;
        return this;
    }
    public Long getDatasetId() {
        return this.datasetId;
    }

    public ChatMemoUpdateKnowledgeGraphNodeRequest setNodeInfo(ChatMemoUpdateKnowledgeGraphNodeRequestNodeInfo nodeInfo) {
        this.nodeInfo = nodeInfo;
        return this;
    }
    public ChatMemoUpdateKnowledgeGraphNodeRequestNodeInfo getNodeInfo() {
        return this.nodeInfo;
    }

    public static class ChatMemoUpdateKnowledgeGraphNodeRequestNodeInfo extends TeaModel {
        /**
         * <p>This parameter is required.</p>
         * 
         * <strong>example:</strong>
         * <p>xxxxxxx</p>
         */
        @NameInMap("mediaId")
        public String mediaId;

        /**
         * <strong>example:</strong>
         * <p>{&quot;年龄&quot;：43}</p>
         */
        @NameInMap("propertiesString")
        public String propertiesString;

        public static ChatMemoUpdateKnowledgeGraphNodeRequestNodeInfo build(java.util.Map<String, ?> map) throws Exception {
            ChatMemoUpdateKnowledgeGraphNodeRequestNodeInfo self = new ChatMemoUpdateKnowledgeGraphNodeRequestNodeInfo();
            return TeaModel.build(map, self);
        }

        public ChatMemoUpdateKnowledgeGraphNodeRequestNodeInfo setMediaId(String mediaId) {
            this.mediaId = mediaId;
            return this;
        }
        public String getMediaId() {
            return this.mediaId;
        }

        public ChatMemoUpdateKnowledgeGraphNodeRequestNodeInfo setPropertiesString(String propertiesString) {
            this.propertiesString = propertiesString;
            return this;
        }
        public String getPropertiesString() {
            return this.propertiesString;
        }

    }

}
