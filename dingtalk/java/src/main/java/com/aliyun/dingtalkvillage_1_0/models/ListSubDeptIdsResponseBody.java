// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkvillage_1_0.models;

import com.aliyun.tea.*;

public class ListSubDeptIdsResponseBody extends TeaModel {
    // 部门ID列表
    @NameInMap("deptIdList")
    public java.util.List<Long> deptIdList;

    public static ListSubDeptIdsResponseBody build(java.util.Map<String, ?> map) throws Exception {
        ListSubDeptIdsResponseBody self = new ListSubDeptIdsResponseBody();
        return TeaModel.build(map, self);
    }

    public ListSubDeptIdsResponseBody setDeptIdList(java.util.List<Long> deptIdList) {
        this.deptIdList = deptIdList;
        return this;
    }
    public java.util.List<Long> getDeptIdList() {
        return this.deptIdList;
    }

}
