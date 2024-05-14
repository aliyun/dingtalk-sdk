// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkimpaas_1_0.models;

import com.aliyun.tea.*;

public class UpdateGroupOwnerRequest extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("conversationId")
    public String conversationId;

    @NameInMap("operatorUid")
    public String operatorUid;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("ownerUid")
    public String ownerUid;

    public static UpdateGroupOwnerRequest build(java.util.Map<String, ?> map) throws Exception {
        UpdateGroupOwnerRequest self = new UpdateGroupOwnerRequest();
        return TeaModel.build(map, self);
    }

    public UpdateGroupOwnerRequest setConversationId(String conversationId) {
        this.conversationId = conversationId;
        return this;
    }
    public String getConversationId() {
        return this.conversationId;
    }

    public UpdateGroupOwnerRequest setOperatorUid(String operatorUid) {
        this.operatorUid = operatorUid;
        return this;
    }
    public String getOperatorUid() {
        return this.operatorUid;
    }

    public UpdateGroupOwnerRequest setOwnerUid(String ownerUid) {
        this.ownerUid = ownerUid;
        return this;
    }
    public String getOwnerUid() {
        return this.ownerUid;
    }

}
