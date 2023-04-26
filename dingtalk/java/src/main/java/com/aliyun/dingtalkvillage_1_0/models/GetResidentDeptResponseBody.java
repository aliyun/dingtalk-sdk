// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkvillage_1_0.models;

import com.aliyun.tea.*;

public class GetResidentDeptResponseBody extends TeaModel {
    @NameInMap("contactType")
    public String contactType;

    @NameInMap("departmentId")
    public Long departmentId;

    @NameInMap("departmentName")
    public String departmentName;

    @NameInMap("deptType")
    public String deptType;

    @NameInMap("feature")
    public String feature;

    public static GetResidentDeptResponseBody build(java.util.Map<String, ?> map) throws Exception {
        GetResidentDeptResponseBody self = new GetResidentDeptResponseBody();
        return TeaModel.build(map, self);
    }

    public GetResidentDeptResponseBody setContactType(String contactType) {
        this.contactType = contactType;
        return this;
    }
    public String getContactType() {
        return this.contactType;
    }

    public GetResidentDeptResponseBody setDepartmentId(Long departmentId) {
        this.departmentId = departmentId;
        return this;
    }
    public Long getDepartmentId() {
        return this.departmentId;
    }

    public GetResidentDeptResponseBody setDepartmentName(String departmentName) {
        this.departmentName = departmentName;
        return this;
    }
    public String getDepartmentName() {
        return this.departmentName;
    }

    public GetResidentDeptResponseBody setDeptType(String deptType) {
        this.deptType = deptType;
        return this;
    }
    public String getDeptType() {
        return this.deptType;
    }

    public GetResidentDeptResponseBody setFeature(String feature) {
        this.feature = feature;
        return this;
    }
    public String getFeature() {
        return this.feature;
    }

}
