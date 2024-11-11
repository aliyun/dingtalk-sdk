// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkedu_1_0.models;

import com.aliyun.tea.*;

public class AdjustKitResponseBody extends TeaModel {
    @NameInMap("result")
    public Long result;

    @NameInMap("success")
    public Boolean success;

    public static AdjustKitResponseBody build(java.util.Map<String, ?> map) throws Exception {
        AdjustKitResponseBody self = new AdjustKitResponseBody();
        return TeaModel.build(map, self);
    }

    public AdjustKitResponseBody setResult(Long result) {
        this.result = result;
        return this;
    }
    public Long getResult() {
        return this.result;
    }

    public AdjustKitResponseBody setSuccess(Boolean success) {
        this.success = success;
        return this;
    }
    public Boolean getSuccess() {
        return this.success;
    }

}
