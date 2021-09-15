// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkresident_1_0.models;

import com.aliyun.tea.*;

public class AddResidentDepartmentRequest extends TeaModel {
    // 是否为组
    @NameInMap("isResidenceGroup")
    public Boolean isResidenceGroup;

    // 部门名字
    @NameInMap("name")
    public String name;

    // 父部门id
    @NameInMap("parentDepartmentId")
    public Long parentDepartmentId;

    public static AddResidentDepartmentRequest build(java.util.Map<String, ?> map) throws Exception {
        AddResidentDepartmentRequest self = new AddResidentDepartmentRequest();
        return TeaModel.build(map, self);
    }

    public AddResidentDepartmentRequest setIsResidenceGroup(Boolean isResidenceGroup) {
        this.isResidenceGroup = isResidenceGroup;
        return this;
    }
    public Boolean getIsResidenceGroup() {
        return this.isResidenceGroup;
    }

    public AddResidentDepartmentRequest setName(String name) {
        this.name = name;
        return this;
    }
    public String getName() {
        return this.name;
    }

    public AddResidentDepartmentRequest setParentDepartmentId(Long parentDepartmentId) {
        this.parentDepartmentId = parentDepartmentId;
        return this;
    }
    public Long getParentDepartmentId() {
        return this.parentDepartmentId;
    }

}
