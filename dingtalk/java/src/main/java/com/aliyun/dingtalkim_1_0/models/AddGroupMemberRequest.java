// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkim_1_0.models;

import com.aliyun.tea.*;

public class AddGroupMemberRequest extends TeaModel {
    /**
     * <p>钉外成员列表。</p>
     */
    @NameInMap("appUserIds")
    public java.util.List<String> appUserIds;

    /**
     * <p>群会话Id。</p>
     */
    @NameInMap("openConversationId")
    public String openConversationId;

    /**
     * <p>操作者在业务系统内的唯一标识。</p>
     */
    @NameInMap("operatorId")
    public String operatorId;

    /**
     * <p>钉内成员列表。</p>
     */
    @NameInMap("userIds")
    public java.util.List<String> userIds;

    public static AddGroupMemberRequest build(java.util.Map<String, ?> map) throws Exception {
        AddGroupMemberRequest self = new AddGroupMemberRequest();
        return TeaModel.build(map, self);
    }

    public AddGroupMemberRequest setAppUserIds(java.util.List<String> appUserIds) {
        this.appUserIds = appUserIds;
        return this;
    }
    public java.util.List<String> getAppUserIds() {
        return this.appUserIds;
    }

    public AddGroupMemberRequest setOpenConversationId(String openConversationId) {
        this.openConversationId = openConversationId;
        return this;
    }
    public String getOpenConversationId() {
        return this.openConversationId;
    }

    public AddGroupMemberRequest setOperatorId(String operatorId) {
        this.operatorId = operatorId;
        return this;
    }
    public String getOperatorId() {
        return this.operatorId;
    }

    public AddGroupMemberRequest setUserIds(java.util.List<String> userIds) {
        this.userIds = userIds;
        return this;
    }
    public java.util.List<String> getUserIds() {
        return this.userIds;
    }

}
