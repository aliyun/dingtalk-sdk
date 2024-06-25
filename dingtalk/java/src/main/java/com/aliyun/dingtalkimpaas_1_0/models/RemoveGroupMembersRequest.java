// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkimpaas_1_0.models;

import com.aliyun.tea.*;

public class RemoveGroupMembersRequest extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("conversationId")
    public String conversationId;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>if can be null:</strong>
     * <p>true</p>
     */
    @NameInMap("memberUids")
    public java.util.List<String> memberUids;

    @NameInMap("operatorUid")
    public String operatorUid;

    public static RemoveGroupMembersRequest build(java.util.Map<String, ?> map) throws Exception {
        RemoveGroupMembersRequest self = new RemoveGroupMembersRequest();
        return TeaModel.build(map, self);
    }

    public RemoveGroupMembersRequest setConversationId(String conversationId) {
        this.conversationId = conversationId;
        return this;
    }
    public String getConversationId() {
        return this.conversationId;
    }

    public RemoveGroupMembersRequest setMemberUids(java.util.List<String> memberUids) {
        this.memberUids = memberUids;
        return this;
    }
    public java.util.List<String> getMemberUids() {
        return this.memberUids;
    }

    public RemoveGroupMembersRequest setOperatorUid(String operatorUid) {
        this.operatorUid = operatorUid;
        return this;
    }
    public String getOperatorUid() {
        return this.operatorUid;
    }

}
