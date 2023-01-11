// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkproject_1_0.models;

import com.aliyun.tea.*;

public class AddProjectMemberRequest extends TeaModel {
    /**
     * <p>用户ID列表，建议一次不超过10个</p>
     */
    @NameInMap("userIds")
    public java.util.List<String> userIds;

    public static AddProjectMemberRequest build(java.util.Map<String, ?> map) throws Exception {
        AddProjectMemberRequest self = new AddProjectMemberRequest();
        return TeaModel.build(map, self);
    }

    public AddProjectMemberRequest setUserIds(java.util.List<String> userIds) {
        this.userIds = userIds;
        return this;
    }
    public java.util.List<String> getUserIds() {
        return this.userIds;
    }

}
