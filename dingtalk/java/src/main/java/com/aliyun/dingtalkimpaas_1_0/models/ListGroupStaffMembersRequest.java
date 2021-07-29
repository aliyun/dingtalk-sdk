// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkimpaas_1_0.models;

import com.aliyun.tea.*;

public class ListGroupStaffMembersRequest extends TeaModel {
    @NameInMap("conversationId")
    public String conversationId;

    public static ListGroupStaffMembersRequest build(java.util.Map<String, ?> map) throws Exception {
        ListGroupStaffMembersRequest self = new ListGroupStaffMembersRequest();
        return TeaModel.build(map, self);
    }

    public ListGroupStaffMembersRequest setConversationId(String conversationId) {
        this.conversationId = conversationId;
        return this;
    }
    public String getConversationId() {
        return this.conversationId;
    }

}
