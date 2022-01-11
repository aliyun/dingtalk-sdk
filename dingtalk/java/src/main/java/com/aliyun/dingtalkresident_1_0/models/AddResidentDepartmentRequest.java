// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkresident_1_0.models;

import com.aliyun.tea.*;

public class AddResidentDepartmentRequest extends TeaModel {
    // 部门名字
    @NameInMap("departmentName")
    public String departmentName;

    // 是否为组
    @NameInMap("isResidenceGroup")
    public Boolean isResidenceGroup;

    // 父部门id
    @NameInMap("parentDepartmentId")
    public Long parentDepartmentId;

    public static AddResidentDepartmentRequest build(java.util.Map<String, ?> map) throws Exception {
        AddResidentDepartmentRequest self = new AddResidentDepartmentRequest();
        return TeaModel.build(map, self);
    }

    public AddResidentDepartmentRequest setDepartmentName(String departmentName) {
        this.departmentName = departmentName;
        return this;
    }
    public String getDepartmentName() {
        return this.departmentName;
    }

    public AddResidentDepartmentRequest setIsResidenceGroup(Boolean isResidenceGroup) {
        this.isResidenceGroup = isResidenceGroup;
        return this;
    }
    public Boolean getIsResidenceGroup() {
        return this.isResidenceGroup;
    }

    public AddResidentDepartmentRequest setParentDepartmentId(Long parentDepartmentId) {
        this.parentDepartmentId = parentDepartmentId;
        return this;
    }
    public Long getParentDepartmentId() {
        return this.parentDepartmentId;
    }

}
