// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkresident_1_0.models;

import com.aliyun.tea.*;

public class RemoveResidentMemberRequest extends TeaModel {
    // 空位标识
    @NameInMap("deptId")
    public Long deptId;

    // 人员标识
    @NameInMap("userId")
    public String userId;

    public static RemoveResidentMemberRequest build(java.util.Map<String, ?> map) throws Exception {
        RemoveResidentMemberRequest self = new RemoveResidentMemberRequest();
        return TeaModel.build(map, self);
    }

    public RemoveResidentMemberRequest setDeptId(Long deptId) {
        this.deptId = deptId;
        return this;
    }
    public Long getDeptId() {
        return this.deptId;
    }

    public RemoveResidentMemberRequest setUserId(String userId) {
        this.userId = userId;
        return this;
    }
    public String getUserId() {
        return this.userId;
    }

}
