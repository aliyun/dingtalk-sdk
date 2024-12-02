// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkindustry_1_0.models;

import com.aliyun.tea.*;

public class ChatMemoDeleteKnowledgeGraphNodeResponseBody extends TeaModel {
    /**
     * <strong>example:</strong>
     * <p>xxxxx</p>
     */
    @NameInMap("bizId")
    public String bizId;

    @NameInMap("success")
    public Boolean success;

    public static ChatMemoDeleteKnowledgeGraphNodeResponseBody build(java.util.Map<String, ?> map) throws Exception {
        ChatMemoDeleteKnowledgeGraphNodeResponseBody self = new ChatMemoDeleteKnowledgeGraphNodeResponseBody();
        return TeaModel.build(map, self);
    }

    public ChatMemoDeleteKnowledgeGraphNodeResponseBody setBizId(String bizId) {
        this.bizId = bizId;
        return this;
    }
    public String getBizId() {
        return this.bizId;
    }

    public ChatMemoDeleteKnowledgeGraphNodeResponseBody setSuccess(Boolean success) {
        this.success = success;
        return this;
    }
    public Boolean getSuccess() {
        return this.success;
    }

}
