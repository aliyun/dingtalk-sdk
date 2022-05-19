// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkresident_1_0.models;

import com.aliyun.tea.*;

public class DeleteSpaceRequest extends TeaModel {
    // 部门id
    @NameInMap("deptIds")
    public java.util.List<Long> deptIds;

    public static DeleteSpaceRequest build(java.util.Map<String, ?> map) throws Exception {
        DeleteSpaceRequest self = new DeleteSpaceRequest();
        return TeaModel.build(map, self);
    }

    public DeleteSpaceRequest setDeptIds(java.util.List<Long> deptIds) {
        this.deptIds = deptIds;
        return this;
    }
    public java.util.List<Long> getDeptIds() {
        return this.deptIds;
    }

}
