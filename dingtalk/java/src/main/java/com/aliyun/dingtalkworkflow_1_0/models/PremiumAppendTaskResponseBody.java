// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkworkflow_1_0.models;

import com.aliyun.tea.*;

public class PremiumAppendTaskResponseBody extends TeaModel {
    @NameInMap("result")
    public Boolean result;

    public static PremiumAppendTaskResponseBody build(java.util.Map<String, ?> map) throws Exception {
        PremiumAppendTaskResponseBody self = new PremiumAppendTaskResponseBody();
        return TeaModel.build(map, self);
    }

    public PremiumAppendTaskResponseBody setResult(Boolean result) {
        this.result = result;
        return this;
    }
    public Boolean getResult() {
        return this.result;
    }

}
