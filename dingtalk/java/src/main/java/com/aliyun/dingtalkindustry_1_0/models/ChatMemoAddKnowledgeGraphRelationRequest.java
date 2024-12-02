// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkindustry_1_0.models;

import com.aliyun.tea.*;

public class ChatMemoAddKnowledgeGraphRelationRequest extends TeaModel {
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
    public ChatMemoAddKnowledgeGraphRelationRequestRelationInfo relationInfo;

    public static ChatMemoAddKnowledgeGraphRelationRequest build(java.util.Map<String, ?> map) throws Exception {
        ChatMemoAddKnowledgeGraphRelationRequest self = new ChatMemoAddKnowledgeGraphRelationRequest();
        return TeaModel.build(map, self);
    }

    public ChatMemoAddKnowledgeGraphRelationRequest setBizId(String bizId) {
        this.bizId = bizId;
        return this;
    }
    public String getBizId() {
        return this.bizId;
    }

    public ChatMemoAddKnowledgeGraphRelationRequest setDatasetId(Long datasetId) {
        this.datasetId = datasetId;
        return this;
    }
    public Long getDatasetId() {
        return this.datasetId;
    }

    public ChatMemoAddKnowledgeGraphRelationRequest setRelationInfo(ChatMemoAddKnowledgeGraphRelationRequestRelationInfo relationInfo) {
        this.relationInfo = relationInfo;
        return this;
    }
    public ChatMemoAddKnowledgeGraphRelationRequestRelationInfo getRelationInfo() {
        return this.relationInfo;
    }

    public static class ChatMemoAddKnowledgeGraphRelationRequestRelationInfo extends TeaModel {
        /**
         * <p>This parameter is required.</p>
         * 
         * <strong>example:</strong>
         * <p>xxxx</p>
         */
        @NameInMap("endId")
        public String endId;

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
         * <p>xxxxx</p>
         */
        @NameInMap("startId")
        public String startId;

        public static ChatMemoAddKnowledgeGraphRelationRequestRelationInfo build(java.util.Map<String, ?> map) throws Exception {
            ChatMemoAddKnowledgeGraphRelationRequestRelationInfo self = new ChatMemoAddKnowledgeGraphRelationRequestRelationInfo();
            return TeaModel.build(map, self);
        }

        public ChatMemoAddKnowledgeGraphRelationRequestRelationInfo setEndId(String endId) {
            this.endId = endId;
            return this;
        }
        public String getEndId() {
            return this.endId;
        }

        public ChatMemoAddKnowledgeGraphRelationRequestRelationInfo setPropertiesString(String propertiesString) {
            this.propertiesString = propertiesString;
            return this;
        }
        public String getPropertiesString() {
            return this.propertiesString;
        }

        public ChatMemoAddKnowledgeGraphRelationRequestRelationInfo setRelationName(String relationName) {
            this.relationName = relationName;
            return this;
        }
        public String getRelationName() {
            return this.relationName;
        }

        public ChatMemoAddKnowledgeGraphRelationRequestRelationInfo setStartId(String startId) {
            this.startId = startId;
            return this;
        }
        public String getStartId() {
            return this.startId;
        }

    }

}
