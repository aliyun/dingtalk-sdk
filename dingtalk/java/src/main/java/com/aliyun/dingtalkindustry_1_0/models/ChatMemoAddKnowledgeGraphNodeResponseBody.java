// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkindustry_1_0.models;

import com.aliyun.tea.*;

public class ChatMemoAddKnowledgeGraphNodeResponseBody extends TeaModel {
    /**
     * <strong>example:</strong>
     * <p>xxxxx</p>
     */
    @NameInMap("bizId")
    public String bizId;

    /**
     * <strong>example:</strong>
     * <p>aaaa.doc</p>
     */
    @NameInMap("mediaId")
    public String mediaId;

    public static ChatMemoAddKnowledgeGraphNodeResponseBody build(java.util.Map<String, ?> map) throws Exception {
        ChatMemoAddKnowledgeGraphNodeResponseBody self = new ChatMemoAddKnowledgeGraphNodeResponseBody();
        return TeaModel.build(map, self);
    }

    public ChatMemoAddKnowledgeGraphNodeResponseBody setBizId(String bizId) {
        this.bizId = bizId;
        return this;
    }
    public String getBizId() {
        return this.bizId;
    }

    public ChatMemoAddKnowledgeGraphNodeResponseBody setMediaId(String mediaId) {
        this.mediaId = mediaId;
        return this;
    }
    public String getMediaId() {
        return this.mediaId;
    }

}
