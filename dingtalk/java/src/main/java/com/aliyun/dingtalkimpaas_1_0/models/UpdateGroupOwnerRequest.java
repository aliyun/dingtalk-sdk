// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkimpaas_1_0.models;

import com.aliyun.tea.*;

public class UpdateGroupOwnerRequest extends TeaModel {
    @NameInMap("ownerId")
    public String ownerId;

    @NameInMap("operatorUid")
    public String operatorUid;

    @NameInMap("conversationId")
    public String conversationId;

    public static UpdateGroupOwnerRequest build(java.util.Map<String, ?> map) throws Exception {
        UpdateGroupOwnerRequest self = new UpdateGroupOwnerRequest();
        return TeaModel.build(map, self);
    }

    public UpdateGroupOwnerRequest setOwnerId(String ownerId) {
        this.ownerId = ownerId;
        return this;
    }
    public String getOwnerId() {
        return this.ownerId;
    }

    public UpdateGroupOwnerRequest setOperatorUid(String operatorUid) {
        this.operatorUid = operatorUid;
        return this;
    }
    public String getOperatorUid() {
        return this.operatorUid;
    }

    public UpdateGroupOwnerRequest setConversationId(String conversationId) {
        this.conversationId = conversationId;
        return this;
    }
    public String getConversationId() {
        return this.conversationId;
    }

}
