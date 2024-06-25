// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkh3yun_1_0.models;

import com.aliyun.tea.*;

public class GetUsersRequest extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>18f923a7-5a5e-426d-94ae-a55ad1a4b240</p>
     */
    @NameInMap("departmentId")
    public String departmentId;

    /**
     * <strong>example:</strong>
     * <p>true</p>
     */
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
