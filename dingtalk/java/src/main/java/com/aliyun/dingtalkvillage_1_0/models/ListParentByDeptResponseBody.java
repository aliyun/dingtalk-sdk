// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkvillage_1_0.models;

import com.aliyun.tea.*;

public class ListParentByDeptResponseBody extends TeaModel {
    @NameInMap("departmentIdList")
    public java.util.List<Long> departmentIdList;

    public static ListParentByDeptResponseBody build(java.util.Map<String, ?> map) throws Exception {
        ListParentByDeptResponseBody self = new ListParentByDeptResponseBody();
        return TeaModel.build(map, self);
    }

    public ListParentByDeptResponseBody setDepartmentIdList(java.util.List<Long> departmentIdList) {
        this.departmentIdList = departmentIdList;
        return this;
    }
    public java.util.List<Long> getDepartmentIdList() {
        return this.departmentIdList;
    }

}
