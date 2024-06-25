// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkresident_1_0.models;

import com.aliyun.tea.*;

public class AddResidentDepartmentRequest extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>第一网格组</p>
     */
    @NameInMap("departmentName")
    public String departmentName;

    /**
     * <strong>example:</strong>
     * <p>true</p>
     */
    @NameInMap("isResidenceGroup")
    public Boolean isResidenceGroup;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>12345</p>
     */
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
