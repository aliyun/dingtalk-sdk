// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkh3yun_1_0.models;

import com.aliyun.tea.*;

public class GetUsersRequest extends TeaModel {
    @NameInMap("departmentId")
    public String departmentId;

    @NameInMap("isRecursive")
    public Boolean isRecursive;

    public static GetUsersRequest build(java.util.Map<String, ?> map) throws Exception {
        GetUsersRequest self = new GetUsersRequest();
        return TeaModel.build(map, self);
    }

    public GetUsersRequest setDepartmentId(String departmentId) {
        this.departmentId = departmentId;
        return this;
    }
    public String getDepartmentId() {
        return this.departmentId;
    }

    public GetUsersRequest setIsRecursive(Boolean isRecursive) {
        this.isRecursive = isRecursive;
        return this;
    }
    public Boolean getIsRecursive() {
        return this.isRecursive;
    }

}
