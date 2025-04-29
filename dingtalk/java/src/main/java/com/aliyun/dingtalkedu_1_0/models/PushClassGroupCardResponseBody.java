// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkedu_1_0.models;

import com.aliyun.tea.*;

public class PushClassGroupCardResponseBody extends TeaModel {
    @NameInMap("result")
    public String result;

    @NameInMap("success")
    public Boolean success;

    public static PushClassGroupCardResponseBody build(java.util.Map<String, ?> map) throws Exception {
        PushClassGroupCardResponseBody self = new PushClassGroupCardResponseBody();
        return TeaModel.build(map, self);
    }

    public PushClassGroupCardResponseBody setResult(String result) {
        this.result = result;
        return this;
    }
    public String getResult() {
        return this.result;
    }

    public PushClassGroupCardResponseBody setSuccess(Boolean success) {
        this.success = success;
        return this;
    }
    public Boolean getSuccess() {
        return this.success;
    }

}
