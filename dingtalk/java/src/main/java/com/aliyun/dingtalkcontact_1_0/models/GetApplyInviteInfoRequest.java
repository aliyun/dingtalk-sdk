// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcontact_1_0.models;

import com.aliyun.tea.*;

public class GetApplyInviteInfoRequest extends TeaModel {
    // 邀请者userId
    @NameInMap("inviterUserId")
    public String inviterUserId;

    // 获取部门邀请链接的部门ID
    @NameInMap("deptId")
    public Long deptId;

    public static GetApplyInviteInfoRequest build(java.util.Map<String, ?> map) throws Exception {
        GetApplyInviteInfoRequest self = new GetApplyInviteInfoRequest();
        return TeaModel.build(map, self);
    }

    public GetApplyInviteInfoRequest setInviterUserId(String inviterUserId) {
        this.inviterUserId = inviterUserId;
        return this;
    }
    public String getInviterUserId() {
        return this.inviterUserId;
    }

    public GetApplyInviteInfoRequest setDeptId(Long deptId) {
        this.deptId = deptId;
        return this;
    }
    public Long getDeptId() {
        return this.deptId;
    }

}
