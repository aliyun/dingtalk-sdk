// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkedu_1_0.models;

import com.aliyun.tea.*;

public class DeleteDeptResponseBody extends TeaModel {
    /**
     * <p>success</p>
     */
    @NameInMap("success")
    public Boolean success;

    public static DeleteDeptResponseBody build(java.util.Map<String, ?> map) throws Exception {
        DeleteDeptResponseBody self = new DeleteDeptResponseBody();
        return TeaModel.build(map, self);
    }

    public DeleteDeptResponseBody setSuccess(Boolean success) {
        this.success = success;
        return this;
    }
    public Boolean getSuccess() {
        return this.success;
    }

}
