// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkvillage_1_0.models;

import com.aliyun.tea.*;

public class ListParentByUserResponseBody extends TeaModel {
    // 上级部门id链
    @NameInMap("parentDeptIdList")
    public java.util.List<Long> parentDeptIdList;

    public static ListParentByUserResponseBody build(java.util.Map<String, ?> map) throws Exception {
        ListParentByUserResponseBody self = new ListParentByUserResponseBody();
        return TeaModel.build(map, self);
    }

    public ListParentByUserResponseBody setParentDeptIdList(java.util.List<Long> parentDeptIdList) {
        this.parentDeptIdList = parentDeptIdList;
        return this;
    }
    public java.util.List<Long> getParentDeptIdList() {
        return this.parentDeptIdList;
    }

}
