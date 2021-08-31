// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkvillage_1_0.models;

import com.aliyun.tea.*;

public class ListSubDeptIdsResponseBody extends TeaModel {
    // 下属组织的子部门 ID 列表
    @NameInMap("departmentIdList")
    public java.util.List<Long> departmentIdList;

    public static ListSubDeptIdsResponseBody build(java.util.Map<String, ?> map) throws Exception {
        ListSubDeptIdsResponseBody self = new ListSubDeptIdsResponseBody();
        return TeaModel.build(map, self);
    }

    public ListSubDeptIdsResponseBody setDepartmentIdList(java.util.List<Long> departmentIdList) {
        this.departmentIdList = departmentIdList;
        return this;
    }
    public java.util.List<Long> getDepartmentIdList() {
        return this.departmentIdList;
    }

}
