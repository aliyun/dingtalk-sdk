// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkindustry_1_0.models;

import com.aliyun.tea.*;

public class ChatMemoUpdateKnowledgeGraphNodeResponseBody extends TeaModel {
    /**
     * <strong>example:</strong>
     * <p>xxxxx</p>
     */
    @NameInMap("bizId")
    public String bizId;

    @NameInMap("success")
    public Boolean success;

    public static ChatMemoUpdateKnowledgeGraphNodeResponseBody build(java.util.Map<String, ?> map) throws Exception {
        ChatMemoUpdateKnowledgeGraphNodeResponseBody self = new ChatMemoUpdateKnowledgeGraphNodeResponseBody();
        return TeaModel.build(map, self);
    }

    public ChatMemoUpdateKnowledgeGraphNodeResponseBody setBizId(String bizId) {
        this.bizId = bizId;
        return this;
    }
    public String getBizId() {
        return this.bizId;
    }

    public ChatMemoUpdateKnowledgeGraphNodeResponseBody setSuccess(Boolean success) {
        this.success = success;
        return this;
    }
    public Boolean getSuccess() {
        return this.success;
    }

}
