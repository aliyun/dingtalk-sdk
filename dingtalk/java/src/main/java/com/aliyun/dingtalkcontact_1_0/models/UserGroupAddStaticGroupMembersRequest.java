// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcontact_1_0.models;

import com.aliyun.tea.*;

public class UserGroupAddStaticGroupMembersRequest extends TeaModel {
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

    public static UserGroupAddStaticGroupMembersRequest build(java.util.Map<String, ?> map) throws Exception {
        UserGroupAddStaticGroupMembersRequest self = new UserGroupAddStaticGroupMembersRequest();
        return TeaModel.build(map, self);
    }

    public UserGroupAddStaticGroupMembersRequest setGroupCode(String groupCode) {
        this.groupCode = groupCode;
        return this;
    }
    public String getGroupCode() {
        return this.groupCode;
    }

    public UserGroupAddStaticGroupMembersRequest setUserIds(java.util.List<String> userIds) {
        this.userIds = userIds;
        return this;
    }
    public java.util.List<String> getUserIds() {
        return this.userIds;
    }

}
