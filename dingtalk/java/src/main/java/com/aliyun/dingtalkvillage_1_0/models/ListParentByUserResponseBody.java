// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkvillage_1_0.models;

import com.aliyun.tea.*;

public class ListParentByUserResponseBody extends TeaModel {
    /**
     * <p>上级部门ID列表</p>
     */
    @NameInMap("departmentIdList")
    public java.util.List<Long> departmentIdList;

    public static ListParentByUserResponseBody build(java.util.Map<String, ?> map) throws Exception {
        ListParentByUserResponseBody self = new ListParentByUserResponseBody();
        return TeaModel.build(map, self);
    }

    public ListParentByUserResponseBody setDepartmentIdList(java.util.List<Long> departmentIdList) {
        this.departmentIdList = departmentIdList;
        return this;
    }
    public java.util.List<Long> getDepartmentIdList() {
        return this.departmentIdList;
    }

}
