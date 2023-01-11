// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkedu_1_0.models;

import com.aliyun.tea.*;

public class DeleteTeacherResponseBody extends TeaModel {
    /**
     * <p>success</p>
     */
    @NameInMap("success")
    public Boolean success;

    public static DeleteTeacherResponseBody build(java.util.Map<String, ?> map) throws Exception {
        DeleteTeacherResponseBody self = new DeleteTeacherResponseBody();
        return TeaModel.build(map, self);
    }

    public DeleteTeacherResponseBody setSuccess(Boolean success) {
        this.success = success;
        return this;
    }
    public Boolean getSuccess() {
        return this.success;
    }

}
