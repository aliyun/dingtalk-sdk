// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkvillage_1_0.models;

import com.aliyun.tea.*;

public class GetDeptResponseBody extends TeaModel {
    /**
     * <p>下属组织的部门ID</p>
     */
    @NameInMap("departmentId")
    public Long departmentId;

    /**
     * <p>部门名称</p>
     */
    @NameInMap("departmentName")
    public String departmentName;

    /**
     * <p>部门是否来自关联组织</p>
     */
    @NameInMap("fromUnionOrg")
    public Boolean fromUnionOrg;

    /**
     * <p>在父部门中的次序值</p>
     */
    @NameInMap("order")
    public Long order;

    /**
     * <p>父部门id</p>
     */
    @NameInMap("parentDepartmentId")
    public Long parentDepartmentId;

    public static GetDeptResponseBody build(java.util.Map<String, ?> map) throws Exception {
        GetDeptResponseBody self = new GetDeptResponseBody();
        return TeaModel.build(map, self);
    }

    public GetDeptResponseBody setDepartmentId(Long departmentId) {
        this.departmentId = departmentId;
        return this;
    }
    public Long getDepartmentId() {
        return this.departmentId;
    }

    public GetDeptResponseBody setDepartmentName(String departmentName) {
        this.departmentName = departmentName;
        return this;
    }
    public String getDepartmentName() {
        return this.departmentName;
    }

    public GetDeptResponseBody setFromUnionOrg(Boolean fromUnionOrg) {
        this.fromUnionOrg = fromUnionOrg;
        return this;
    }
    public Boolean getFromUnionOrg() {
        return this.fromUnionOrg;
    }

    public GetDeptResponseBody setOrder(Long order) {
        this.order = order;
        return this;
    }
    public Long getOrder() {
        return this.order;
    }

    public GetDeptResponseBody setParentDepartmentId(Long parentDepartmentId) {
        this.parentDepartmentId = parentDepartmentId;
        return this;
    }
    public Long getParentDepartmentId() {
        return this.parentDepartmentId;
    }

}
