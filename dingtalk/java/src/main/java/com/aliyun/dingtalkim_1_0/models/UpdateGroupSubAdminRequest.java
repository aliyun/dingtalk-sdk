// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkim_1_0.models;

import com.aliyun.tea.*;

public class UpdateGroupSubAdminRequest extends TeaModel {
    // 开放群ID
    @NameInMap("openConversationId")
    public String openConversationId;

    // 2-群管理员 3-普通群成员
    @NameInMap("role")
    public Long role;

    // 用户ID清单
    @NameInMap("userIds")
    public java.util.List<String> userIds;

    public static UpdateGroupSubAdminRequest build(java.util.Map<String, ?> map) throws Exception {
        UpdateGroupSubAdminRequest self = new UpdateGroupSubAdminRequest();
        return TeaModel.build(map, self);
    }

    public UpdateGroupSubAdminRequest setOpenConversationId(String openConversationId) {
        this.openConversationId = openConversationId;
        return this;
    }
    public String getOpenConversationId() {
        return this.openConversationId;
    }

    public UpdateGroupSubAdminRequest setRole(Long role) {
        this.role = role;
        return this;
    }
    public Long getRole() {
        return this.role;
    }

    public UpdateGroupSubAdminRequest setUserIds(java.util.List<String> userIds) {
        this.userIds = userIds;
        return this;
    }
    public java.util.List<String> getUserIds() {
        return this.userIds;
    }

}
