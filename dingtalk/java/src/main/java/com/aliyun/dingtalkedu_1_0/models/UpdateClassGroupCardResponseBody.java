// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkedu_1_0.models;

import com.aliyun.tea.*;

public class UpdateClassGroupCardResponseBody extends TeaModel {
    @NameInMap("result")
    public Boolean result;

    @NameInMap("success")
    public Boolean success;

    public static UpdateClassGroupCardResponseBody build(java.util.Map<String, ?> map) throws Exception {
        UpdateClassGroupCardResponseBody self = new UpdateClassGroupCardResponseBody();
        return TeaModel.build(map, self);
    }

    public UpdateClassGroupCardResponseBody setResult(Boolean result) {
        this.result = result;
        return this;
    }
    public Boolean getResult() {
        return this.result;
    }

    public UpdateClassGroupCardResponseBody setSuccess(Boolean success) {
        this.success = success;
        return this;
    }
    public Boolean getSuccess() {
        return this.success;
    }

}
