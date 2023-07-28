// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkedu_1_0.models;

import com.aliyun.tea.*;

public class AssignClassResponseBody extends TeaModel {
    @NameInMap("success")
    public Boolean success;

    public static AssignClassResponseBody build(java.util.Map<String, ?> map) throws Exception {
        AssignClassResponseBody self = new AssignClassResponseBody();
        return TeaModel.build(map, self);
    }

    public AssignClassResponseBody setSuccess(Boolean success) {
        this.success = success;
        return this;
    }
    public Boolean getSuccess() {
        return this.success;
    }

}
