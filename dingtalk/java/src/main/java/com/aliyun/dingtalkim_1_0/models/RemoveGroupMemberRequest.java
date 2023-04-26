// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkim_1_0.models;

import com.aliyun.tea.*;

public class RemoveGroupMemberRequest extends TeaModel {
    @NameInMap("appUserIds")
    public java.util.List<String> appUserIds;

    @NameInMap("openConversationId")
    public String openConversationId;

    @NameInMap("operatorId")
    public String operatorId;

    @NameInMap("userIds")
    public java.util.List<String> userIds;

    public static RemoveGroupMemberRequest build(java.util.Map<String, ?> map) throws Exception {
        RemoveGroupMemberRequest self = new RemoveGroupMemberRequest();
        return TeaModel.build(map, self);
    }

    public RemoveGroupMemberRequest setAppUserIds(java.util.List<String> appUserIds) {
        this.appUserIds = appUserIds;
        return this;
    }
    public java.util.List<String> getAppUserIds() {
        return this.appUserIds;
    }

    public RemoveGroupMemberRequest setOpenConversationId(String openConversationId) {
        this.openConversationId = openConversationId;
        return this;
    }
    public String getOpenConversationId() {
        return this.openConversationId;
    }

    public RemoveGroupMemberRequest setOperatorId(String operatorId) {
        this.operatorId = operatorId;
        return this;
    }
    public String getOperatorId() {
        return this.operatorId;
    }

    public RemoveGroupMemberRequest setUserIds(java.util.List<String> userIds) {
        this.userIds = userIds;
        return this;
    }
    public java.util.List<String> getUserIds() {
        return this.userIds;
    }

}
