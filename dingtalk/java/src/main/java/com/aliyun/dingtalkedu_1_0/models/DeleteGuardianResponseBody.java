// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkedu_1_0.models;

import com.aliyun.tea.*;

public class DeleteGuardianResponseBody extends TeaModel {
    // success
    @NameInMap("success")
    public Boolean success;

    public static DeleteGuardianResponseBody build(java.util.Map<String, ?> map) throws Exception {
        DeleteGuardianResponseBody self = new DeleteGuardianResponseBody();
        return TeaModel.build(map, self);
    }

    public DeleteGuardianResponseBody setSuccess(Boolean success) {
        this.success = success;
        return this;
    }
    public Boolean getSuccess() {
        return this.success;
    }

}
