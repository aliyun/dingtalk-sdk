// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcontract_1_0.models;

import com.aliyun.tea.*;

public class CheckEsignFileResponseBody extends TeaModel {
    @NameInMap("result")
    public Boolean result;

    @NameInMap("success")
    public Boolean success;

    public static CheckEsignFileResponseBody build(java.util.Map<String, ?> map) throws Exception {
        CheckEsignFileResponseBody self = new CheckEsignFileResponseBody();
        return TeaModel.build(map, self);
    }

    public CheckEsignFileResponseBody setResult(Boolean result) {
        this.result = result;
        return this;
    }
    public Boolean getResult() {
        return this.result;
    }

    public CheckEsignFileResponseBody setSuccess(Boolean success) {
        this.success = success;
        return this;
    }
    public Boolean getSuccess() {
        return this.success;
    }

}
