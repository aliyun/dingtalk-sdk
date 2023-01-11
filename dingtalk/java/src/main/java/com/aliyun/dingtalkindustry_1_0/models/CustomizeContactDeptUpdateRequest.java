// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkindustry_1_0.models;

import com.aliyun.tea.*;

public class CustomizeContactDeptUpdateRequest extends TeaModel {
    /**
     * <p>自定义通讯录Code</p>
     */
    @NameInMap("code")
    public String code;

    /**
     * <p>部门Id</p>
     */
    @NameInMap("deptId")
    public Long deptId;

    /**
     * <p>部门主管列表</p>
     */
    @NameInMap("managerIdList")
    public java.util.List<String> managerIdList;

    /**
     * <p>部门名称</p>
     */
    @NameInMap("name")
    public String name;

    /**
     * <p>部门排序</p>
     */
    @NameInMap("order")
    public Long order;

    /**
     * <p>上级部门Id</p>
     */
    @NameInMap("parentDeptId")
    public Long parentDeptId;

    public static CustomizeContactDeptUpdateRequest build(java.util.Map<String, ?> map) throws Exception {
        CustomizeContactDeptUpdateRequest self = new CustomizeContactDeptUpdateRequest();
        return TeaModel.build(map, self);
    }

    public CustomizeContactDeptUpdateRequest setCode(String code) {
        this.code = code;
        return this;
    }
    public String getCode() {
        return this.code;
    }

    public CustomizeContactDeptUpdateRequest setDeptId(Long deptId) {
        this.deptId = deptId;
        return this;
    }
    public Long getDeptId() {
        return this.deptId;
    }

    public CustomizeContactDeptUpdateRequest setManagerIdList(java.util.List<String> managerIdList) {
        this.managerIdList = managerIdList;
        return this;
    }
    public java.util.List<String> getManagerIdList() {
        return this.managerIdList;
    }

    public CustomizeContactDeptUpdateRequest setName(String name) {
        this.name = name;
        return this;
    }
    public String getName() {
        return this.name;
    }

    public CustomizeContactDeptUpdateRequest setOrder(Long order) {
        this.order = order;
        return this;
    }
    public Long getOrder() {
        return this.order;
    }

    public CustomizeContactDeptUpdateRequest setParentDeptId(Long parentDeptId) {
        this.parentDeptId = parentDeptId;
        return this;
    }
    public Long getParentDeptId() {
        return this.parentDeptId;
    }

}
