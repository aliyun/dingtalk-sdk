// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkindustry_1_0.models;

import com.aliyun.tea.*;

public class ChatMemoUpdateKnowledgeGraphRelationResponseBody extends TeaModel {
    /**
     * <strong>example:</strong>
     * <p>xxxxx</p>
     */
    @NameInMap("bizId")
    public String bizId;

    @NameInMap("success")
    public Boolean success;

    public static ChatMemoUpdateKnowledgeGraphRelationResponseBody build(java.util.Map<String, ?> map) throws Exception {
        ChatMemoUpdateKnowledgeGraphRelationResponseBody self = new ChatMemoUpdateKnowledgeGraphRelationResponseBody();
        return TeaModel.build(map, self);
    }

    public ChatMemoUpdateKnowledgeGraphRelationResponseBody setBizId(String bizId) {
        this.bizId = bizId;
        return this;
    }
    public String getBizId() {
        return this.bizId;
    }

    public ChatMemoUpdateKnowledgeGraphRelationResponseBody setSuccess(Boolean success) {
        this.success = success;
        return this;
    }
    public Boolean getSuccess() {
        return this.success;
    }

}
