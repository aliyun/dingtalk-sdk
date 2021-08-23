// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkvillage_1_0.models;

import com.aliyun.tea.*;

public class GetResidentDeptResponseBody extends TeaModel {
    // 部门ID
    @NameInMap("deptId")
    public Long deptId;

    // 部门名称
    @NameInMap("name")
    public String name;

    // 部门类型
    @NameInMap("deptType")
    public String deptType;

    // 通讯录架构类型
    @NameInMap("contactType")
    public String contactType;

    // 部门属性
    @NameInMap("feature")
    public String feature;

    public static GetResidentDeptResponseBody build(java.util.Map<String, ?> map) throws Exception {
        GetResidentDeptResponseBody self = new GetResidentDeptResponseBody();
        return TeaModel.build(map, self);
    }

    public GetResidentDeptResponseBody setDeptId(Long deptId) {
        this.deptId = deptId;
        return this;
    }
    public Long getDeptId() {
        return this.deptId;
    }

    public GetResidentDeptResponseBody setName(String name) {
        this.name = name;
        return this;
    }
    public String getName() {
        return this.name;
    }

    public GetResidentDeptResponseBody setDeptType(String deptType) {
        this.deptType = deptType;
        return this;
    }
    public String getDeptType() {
        return this.deptType;
    }

    public GetResidentDeptResponseBody setContactType(String contactType) {
        this.contactType = contactType;
        return this;
    }
    public String getContactType() {
        return this.contactType;
    }

    public GetResidentDeptResponseBody setFeature(String feature) {
        this.feature = feature;
        return this;
    }
    public String getFeature() {
        return this.feature;
    }

}
