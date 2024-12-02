// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkindustry_1_0.models;

import com.aliyun.tea.*;

public class ChatMemoDeleteKnowledgeGraphRelationResponseBody extends TeaModel {
    /**
     * <strong>example:</strong>
     * <p>xxxxx</p>
     */
    @NameInMap("bizId")
    public String bizId;

    @NameInMap("success")
    public Boolean success;

    public static ChatMemoDeleteKnowledgeGraphRelationResponseBody build(java.util.Map<String, ?> map) throws Exception {
        ChatMemoDeleteKnowledgeGraphRelationResponseBody self = new ChatMemoDeleteKnowledgeGraphRelationResponseBody();
        return TeaModel.build(map, self);
    }

    public ChatMemoDeleteKnowledgeGraphRelationResponseBody setBizId(String bizId) {
        this.bizId = bizId;
        return this;
    }
    public String getBizId() {
        return this.bizId;
    }

    public ChatMemoDeleteKnowledgeGraphRelationResponseBody setSuccess(Boolean success) {
        this.success = success;
        return this;
    }
    public Boolean getSuccess() {
        return this.success;
    }

}
