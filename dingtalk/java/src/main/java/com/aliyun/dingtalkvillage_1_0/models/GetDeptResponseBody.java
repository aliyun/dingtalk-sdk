// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkvillage_1_0.models;

import com.aliyun.tea.*;

public class GetDeptResponseBody extends TeaModel {
    // 在父部门中的次序值
    @NameInMap("order")
    public Long order;

    // 部门id
    @NameInMap("deptId")
    public Long deptId;

    // 部门名称
    @NameInMap("name")
    public String name;

    // 父部门id
    @NameInMap("parentId")
    public Long parentId;

    // 部门是否来自关联组织
    @NameInMap("fromUnionOrg")
    public Boolean fromUnionOrg;

    public static GetDeptResponseBody build(java.util.Map<String, ?> map) throws Exception {
        GetDeptResponseBody self = new GetDeptResponseBody();
        return TeaModel.build(map, self);
    }

    public GetDeptResponseBody setOrder(Long order) {
        this.order = order;
        return this;
    }
    public Long getOrder() {
        return this.order;
    }

    public GetDeptResponseBody setDeptId(Long deptId) {
        this.deptId = deptId;
        return this;
    }
    public Long getDeptId() {
        return this.deptId;
    }

    public GetDeptResponseBody setName(String name) {
        this.name = name;
        return this;
    }
    public String getName() {
        return this.name;
    }

    public GetDeptResponseBody setParentId(Long parentId) {
        this.parentId = parentId;
        return this;
    }
    public Long getParentId() {
        return this.parentId;
    }

    public GetDeptResponseBody setFromUnionOrg(Boolean fromUnionOrg) {
        this.fromUnionOrg = fromUnionOrg;
        return this;
    }
    public Boolean getFromUnionOrg() {
        return this.fromUnionOrg;
    }

}
