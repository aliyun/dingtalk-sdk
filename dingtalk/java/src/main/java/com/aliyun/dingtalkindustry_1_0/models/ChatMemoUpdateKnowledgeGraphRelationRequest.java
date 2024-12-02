// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkindustry_1_0.models;

import com.aliyun.tea.*;

public class ChatMemoUpdateKnowledgeGraphRelationRequest extends TeaModel {
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
    @NameInMap("relationInfo")
    public ChatMemoUpdateKnowledgeGraphRelationRequestRelationInfo relationInfo;

    public static ChatMemoUpdateKnowledgeGraphRelationRequest build(java.util.Map<String, ?> map) throws Exception {
        ChatMemoUpdateKnowledgeGraphRelationRequest self = new ChatMemoUpdateKnowledgeGraphRelationRequest();
        return TeaModel.build(map, self);
    }

    public ChatMemoUpdateKnowledgeGraphRelationRequest setBizId(String bizId) {
        this.bizId = bizId;
        return this;
    }
    public String getBizId() {
        return this.bizId;
    }

    public ChatMemoUpdateKnowledgeGraphRelationRequest setDatasetId(Long datasetId) {
        this.datasetId = datasetId;
        return this;
    }
    public Long getDatasetId() {
        return this.datasetId;
    }

    public ChatMemoUpdateKnowledgeGraphRelationRequest setRelationInfo(ChatMemoUpdateKnowledgeGraphRelationRequestRelationInfo relationInfo) {
        this.relationInfo = relationInfo;
        return this;
    }
    public ChatMemoUpdateKnowledgeGraphRelationRequestRelationInfo getRelationInfo() {
        return this.relationInfo;
    }

    public static class ChatMemoUpdateKnowledgeGraphRelationRequestRelationInfo extends TeaModel {
        /**
         * <p>This parameter is required.</p>
         * 
         * <strong>example:</strong>
         * <p>xxxxx</p>
         */
        @NameInMap("mediaId")
        public String mediaId;

        /**
         * <strong>example:</strong>
         * <p>{&quot;年龄&quot;：43}</p>
         */
        @NameInMap("propertiesString")
        public String propertiesString;

        public static ChatMemoUpdateKnowledgeGraphRelationRequestRelationInfo build(java.util.Map<String, ?> map) throws Exception {
            ChatMemoUpdateKnowledgeGraphRelationRequestRelationInfo self = new ChatMemoUpdateKnowledgeGraphRelationRequestRelationInfo();
            return TeaModel.build(map, self);
        }

        public ChatMemoUpdateKnowledgeGraphRelationRequestRelationInfo setMediaId(String mediaId) {
            this.mediaId = mediaId;
            return this;
        }
        public String getMediaId() {
            return this.mediaId;
        }

        public ChatMemoUpdateKnowledgeGraphRelationRequestRelationInfo setPropertiesString(String propertiesString) {
            this.propertiesString = propertiesString;
            return this;
        }
        public String getPropertiesString() {
            return this.propertiesString;
        }

    }

}
