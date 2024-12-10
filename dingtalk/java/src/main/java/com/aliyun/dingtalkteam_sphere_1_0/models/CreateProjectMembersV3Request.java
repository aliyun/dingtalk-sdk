// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkteam_sphere_1_0.models;

import com.aliyun.tea.*;

public class CreateProjectMembersV3Request extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("userIds")
    public java.util.List<String> userIds;

    public static CreateProjectMembersV3Request build(java.util.Map<String, ?> map) throws Exception {
        CreateProjectMembersV3Request self = new CreateProjectMembersV3Request();
        return TeaModel.build(map, self);
    }

    public CreateProjectMembersV3Request setUserIds(java.util.List<String> userIds) {
        this.userIds = userIds;
        return this;
    }
    public java.util.List<String> getUserIds() {
        return this.userIds;
    }

}
