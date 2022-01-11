// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkimpaas_1_0.models;

import com.aliyun.tea.*;

public class UpdateGroupNameRequest extends TeaModel {
    @NameInMap("conversationId")
    public String conversationId;

    @NameInMap("name")
    public String name;

    @NameInMap("operatorUid")
    public String operatorUid;

    public static UpdateGroupNameRequest build(java.util.Map<String, ?> map) throws Exception {
        UpdateGroupNameRequest self = new UpdateGroupNameRequest();
        return TeaModel.build(map, self);
    }

    public UpdateGroupNameRequest setConversationId(String conversationId) {
        this.conversationId = conversationId;
        return this;
    }
    public String getConversationId() {
        return this.conversationId;
    }

    public UpdateGroupNameRequest setName(String name) {
        this.name = name;
        return this;
    }
    public String getName() {
        return this.name;
    }

    public UpdateGroupNameRequest setOperatorUid(String operatorUid) {
        this.operatorUid = operatorUid;
        return this;
    }
    public String getOperatorUid() {
        return this.operatorUid;
    }

}
