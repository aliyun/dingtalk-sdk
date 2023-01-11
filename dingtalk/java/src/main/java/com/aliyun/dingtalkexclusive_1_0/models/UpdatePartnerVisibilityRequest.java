// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkexclusive_1_0.models;

import com.aliyun.tea.*;

public class UpdatePartnerVisibilityRequest extends TeaModel {
    /**
     * <p>可见的部门id</p>
     */
    @NameInMap("deptIds")
    public java.util.List<Long> deptIds;

    /**
     * <p>标签id</p>
     */
    @NameInMap("labelId")
    public Long labelId;

    /**
     * <p>可见的员工id</p>
     */
    @NameInMap("userIds")
    public java.util.List<String> userIds;

    public static UpdatePartnerVisibilityRequest build(java.util.Map<String, ?> map) throws Exception {
        UpdatePartnerVisibilityRequest self = new UpdatePartnerVisibilityRequest();
        return TeaModel.build(map, self);
    }

    public UpdatePartnerVisibilityRequest setDeptIds(java.util.List<Long> deptIds) {
        this.deptIds = deptIds;
        return this;
    }
    public java.util.List<Long> getDeptIds() {
        return this.deptIds;
    }

    public UpdatePartnerVisibilityRequest setLabelId(Long labelId) {
        this.labelId = labelId;
        return this;
    }
    public Long getLabelId() {
        return this.labelId;
    }

    public UpdatePartnerVisibilityRequest setUserIds(java.util.List<String> userIds) {
        this.userIds = userIds;
        return this;
    }
    public java.util.List<String> getUserIds() {
        return this.userIds;
    }

}
