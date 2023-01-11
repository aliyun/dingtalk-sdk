// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkh3yun_1_0.models;

import com.aliyun.tea.*;

public class GetOrganizationsRequest extends TeaModel {
    /**
     * <p>18f923a7-5a5e-426d-94ae-a55ad1a4b240</p>
     */
    @NameInMap("departmentId")
    public String departmentId;

    public static GetOrganizationsRequest build(java.util.Map<String, ?> map) throws Exception {
        GetOrganizationsRequest self = new GetOrganizationsRequest();
        return TeaModel.build(map, self);
    }

    public GetOrganizationsRequest setDepartmentId(String departmentId) {
        this.departmentId = departmentId;
        return this;
    }
    public String getDepartmentId() {
        return this.departmentId;
    }

}
