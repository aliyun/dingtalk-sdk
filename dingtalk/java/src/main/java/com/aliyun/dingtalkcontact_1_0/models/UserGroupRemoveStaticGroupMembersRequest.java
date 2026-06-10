// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcontact_1_0.models;

import com.aliyun.tea.*;

public class UserGroupRemoveStaticGroupMembersRequest extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("groupCode")
    public String groupCode;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("userIds")
    public java.util.List<String> userIds;

    public static UserGroupRemoveStaticGroupMembersRequest build(java.util.Map<String, ?> map) throws Exception {
        UserGroupRemoveStaticGroupMembersRequest self = new UserGroupRemoveStaticGroupMembersRequest();
        return TeaModel.build(map, self);
    }

    public UserGroupRemoveStaticGroupMembersRequest setGroupCode(String groupCode) {
        this.groupCode = groupCode;
        return this;
    }
    public String getGroupCode() {
        return this.groupCode;
    }

    public UserGroupRemoveStaticGroupMembersRequest setUserIds(java.util.List<String> userIds) {
        this.userIds = userIds;
        return this;
    }
    public java.util.List<String> getUserIds() {
        return this.userIds;
    }

}
