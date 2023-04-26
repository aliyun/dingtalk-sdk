// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkresident_1_0.models;

import com.aliyun.tea.*;

public class RemoveResidentUserRequest extends TeaModel {
    @NameInMap("departmentId")
    public Long departmentId;

    @NameInMap("userId")
    public String userId;

    public static RemoveResidentUserRequest build(java.util.Map<String, ?> map) throws Exception {
        RemoveResidentUserRequest self = new RemoveResidentUserRequest();
        return TeaModel.build(map, self);
    }

    public RemoveResidentUserRequest setDepartmentId(Long departmentId) {
        this.departmentId = departmentId;
        return this;
    }
    public Long getDepartmentId() {
        return this.departmentId;
    }

    public RemoveResidentUserRequest setUserId(String userId) {
        this.userId = userId;
        return this;
    }
    public String getUserId() {
        return this.userId;
    }

}
