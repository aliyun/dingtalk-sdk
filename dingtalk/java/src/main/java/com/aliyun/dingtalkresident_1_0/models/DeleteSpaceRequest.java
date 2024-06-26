// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkresident_1_0.models;

import com.aliyun.tea.*;

public class DeleteSpaceRequest extends TeaModel {
    /**
     * <strong>example:</strong>
     * <p>忘川路1号</p>
     */
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
