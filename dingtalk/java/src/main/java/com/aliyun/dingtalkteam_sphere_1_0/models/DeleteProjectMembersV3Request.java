// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkteam_sphere_1_0.models;

import com.aliyun.tea.*;

public class DeleteProjectMembersV3Request extends TeaModel {
    @NameInMap("userIds")
    public java.util.List<String> userIds;

    public static DeleteProjectMembersV3Request build(java.util.Map<String, ?> map) throws Exception {
        DeleteProjectMembersV3Request self = new DeleteProjectMembersV3Request();
        return TeaModel.build(map, self);
    }

    public DeleteProjectMembersV3Request setUserIds(java.util.List<String> userIds) {
        this.userIds = userIds;
        return this;
    }
    public java.util.List<String> getUserIds() {
        return this.userIds;
    }

}
