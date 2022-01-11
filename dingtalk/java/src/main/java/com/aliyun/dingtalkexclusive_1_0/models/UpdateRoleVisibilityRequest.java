// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkexclusive_1_0.models;

import com.aliyun.tea.*;

public class UpdateRoleVisibilityRequest extends TeaModel {
    // 可见的部门id
    @NameInMap("deptIds")
    public java.util.List<Long> deptIds;

    // 标签id
    @NameInMap("labelId")
    public Long labelId;

    // 可见的员工id
    @NameInMap("userIds")
    public java.util.List<String> userIds;

    public static UpdateRoleVisibilityRequest build(java.util.Map<String, ?> map) throws Exception {
        UpdateRoleVisibilityRequest self = new UpdateRoleVisibilityRequest();
        return TeaModel.build(map, self);
    }

    public UpdateRoleVisibilityRequest setDeptIds(java.util.List<Long> deptIds) {
        this.deptIds = deptIds;
        return this;
    }
    public java.util.List<Long> getDeptIds() {
        return this.deptIds;
    }

    public UpdateRoleVisibilityRequest setLabelId(Long labelId) {
        this.labelId = labelId;
        return this;
    }
    public Long getLabelId() {
        return this.labelId;
    }

    public UpdateRoleVisibilityRequest setUserIds(java.util.List<String> userIds) {
        this.userIds = userIds;
        return this;
    }
    public java.util.List<String> getUserIds() {
        return this.userIds;
    }

}
