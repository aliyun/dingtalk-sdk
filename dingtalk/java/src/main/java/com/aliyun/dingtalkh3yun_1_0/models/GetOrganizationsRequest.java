// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkh3yun_1_0.models;

import com.aliyun.tea.*;

public class GetOrganizationsRequest extends TeaModel {
    /**
     * <strong>example:</strong>
     * <p>部门id。获取指定部门及其下的子部门（以及子部门的子部门等等，递归获取）。 如果不填，默认获取全量组织架构</p>
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
