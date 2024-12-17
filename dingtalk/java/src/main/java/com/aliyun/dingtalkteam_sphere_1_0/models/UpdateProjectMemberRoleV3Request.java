// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkteam_sphere_1_0.models;

import com.aliyun.tea.*;

public class UpdateProjectMemberRoleV3Request extends TeaModel {
    @NameInMap("roleIds")
    public java.util.List<String> roleIds;

    @NameInMap("userIds")
    public java.util.List<String> userIds;

    public static UpdateProjectMemberRoleV3Request build(java.util.Map<String, ?> map) throws Exception {
        UpdateProjectMemberRoleV3Request self = new UpdateProjectMemberRoleV3Request();
        return TeaModel.build(map, self);
    }

    public UpdateProjectMemberRoleV3Request setRoleIds(java.util.List<String> roleIds) {
        this.roleIds = roleIds;
        return this;
    }
    public java.util.List<String> getRoleIds() {
        return this.roleIds;
    }

    public UpdateProjectMemberRoleV3Request setUserIds(java.util.List<String> userIds) {
        this.userIds = userIds;
        return this;
    }
    public java.util.List<String> getUserIds() {
        return this.userIds;
    }

}
