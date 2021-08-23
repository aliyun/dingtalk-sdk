// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkvillage_1_0.models;

import com.aliyun.tea.*;

public class ListParentByDeptResponseBody extends TeaModel {
    // 父部门列表
    @NameInMap("parentIdList")
    public java.util.List<Long> parentIdList;

    public static ListParentByDeptResponseBody build(java.util.Map<String, ?> map) throws Exception {
        ListParentByDeptResponseBody self = new ListParentByDeptResponseBody();
        return TeaModel.build(map, self);
    }

    public ListParentByDeptResponseBody setParentIdList(java.util.List<Long> parentIdList) {
        this.parentIdList = parentIdList;
        return this;
    }
    public java.util.List<Long> getParentIdList() {
        return this.parentIdList;
    }

}
