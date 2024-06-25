// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcontact_1_0.models;

import com.aliyun.tea.*;

public class GetApplyInviteInfoRequest extends TeaModel {
    @NameInMap("deptId")
    public Long deptId;

    /**
     * <strong>if can be null:</strong>
     * <p>true</p>
     */
    @NameInMap("inviterUserId")
    public String inviterUserId;

    public static GetApplyInviteInfoRequest build(java.util.Map<String, ?> map) throws Exception {
        GetApplyInviteInfoRequest self = new GetApplyInviteInfoRequest();
        return TeaModel.build(map, self);
    }

    public GetApplyInviteInfoRequest setDeptId(Long deptId) {
        this.deptId = deptId;
        return this;
    }
    public Long getDeptId() {
        return this.deptId;
    }

    public GetApplyInviteInfoRequest setInviterUserId(String inviterUserId) {
        this.inviterUserId = inviterUserId;
        return this;
    }
    public String getInviterUserId() {
        return this.inviterUserId;
    }

}
