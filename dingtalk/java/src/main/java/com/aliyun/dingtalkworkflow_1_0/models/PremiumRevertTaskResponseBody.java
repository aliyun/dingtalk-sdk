// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkworkflow_1_0.models;

import com.aliyun.tea.*;

public class PremiumRevertTaskResponseBody extends TeaModel {
    @NameInMap("result")
    public Boolean result;

    public static PremiumRevertTaskResponseBody build(java.util.Map<String, ?> map) throws Exception {
        PremiumRevertTaskResponseBody self = new PremiumRevertTaskResponseBody();
        return TeaModel.build(map, self);
    }

    public PremiumRevertTaskResponseBody setResult(Boolean result) {
        this.result = result;
        return this;
    }
    public Boolean getResult() {
        return this.result;
    }

}
