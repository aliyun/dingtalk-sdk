// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkproject_1_0.models;

import com.aliyun.tea.*;

public class DeleteProjectMemberRequest extends TeaModel {
    @NameInMap("userIds")
    public java.util.List<String> userIds;

    public static DeleteProjectMemberRequest build(java.util.Map<String, ?> map) throws Exception {
        DeleteProjectMemberRequest self = new DeleteProjectMemberRequest();
        return TeaModel.build(map, self);
    }

    public DeleteProjectMemberRequest setUserIds(java.util.List<String> userIds) {
        this.userIds = userIds;
        return this;
    }
    public java.util.List<String> getUserIds() {
        return this.userIds;
    }

}
