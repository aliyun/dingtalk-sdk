// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkworkflow_1_0.models;

import com.aliyun.tea.*;

public class PremiumAddApproveDentryAuthResponseBody extends TeaModel {
    /**
     * <strong>example:</strong>
     * <p>true</p>
     */
    @NameInMap("result")
    public Boolean result;

    /**
     * <strong>example:</strong>
     * <p>true</p>
     */
    @NameInMap("success")
    public Boolean success;

    public static PremiumAddApproveDentryAuthResponseBody build(java.util.Map<String, ?> map) throws Exception {
        PremiumAddApproveDentryAuthResponseBody self = new PremiumAddApproveDentryAuthResponseBody();
        return TeaModel.build(map, self);
    }

    public PremiumAddApproveDentryAuthResponseBody setResult(Boolean result) {
        this.result = result;
        return this;
    }
    public Boolean getResult() {
        return this.result;
    }

    public PremiumAddApproveDentryAuthResponseBody setSuccess(Boolean success) {
        this.success = success;
        return this;
    }
    public Boolean getSuccess() {
        return this.success;
    }

}
