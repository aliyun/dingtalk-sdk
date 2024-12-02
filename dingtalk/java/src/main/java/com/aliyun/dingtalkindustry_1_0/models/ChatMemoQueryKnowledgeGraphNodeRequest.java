// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkindustry_1_0.models;

import com.aliyun.tea.*;

public class ChatMemoQueryKnowledgeGraphNodeRequest extends TeaModel {
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
     * 
     * <strong>example:</strong>
     * <p>xxxxx</p>
     */
    @NameInMap("mediaId")
    public String mediaId;

    public static ChatMemoQueryKnowledgeGraphNodeRequest build(java.util.Map<String, ?> map) throws Exception {
        ChatMemoQueryKnowledgeGraphNodeRequest self = new ChatMemoQueryKnowledgeGraphNodeRequest();
        return TeaModel.build(map, self);
    }

    public ChatMemoQueryKnowledgeGraphNodeRequest setBizId(String bizId) {
        this.bizId = bizId;
        return this;
    }
    public String getBizId() {
        return this.bizId;
    }

    public ChatMemoQueryKnowledgeGraphNodeRequest setDatasetId(Long datasetId) {
        this.datasetId = datasetId;
        return this;
    }
    public Long getDatasetId() {
        return this.datasetId;
    }

    public ChatMemoQueryKnowledgeGraphNodeRequest setMediaId(String mediaId) {
        this.mediaId = mediaId;
        return this;
    }
    public String getMediaId() {
        return this.mediaId;
    }

}
