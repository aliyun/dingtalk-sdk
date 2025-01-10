// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkbizfinance_2_0.models;

import com.aliyun.tea.*;

public class CheckVoucherStatusResponseBody extends TeaModel {
    @NameInMap("result")
    public Boolean result;

    @NameInMap("success")
    public Boolean success;

    public static CheckVoucherStatusResponseBody build(java.util.Map<String, ?> map) throws Exception {
        CheckVoucherStatusResponseBody self = new CheckVoucherStatusResponseBody();
        return TeaModel.build(map, self);
    }

    public CheckVoucherStatusResponseBody setResult(Boolean result) {
        this.result = result;
        return this;
    }
    public Boolean getResult() {
        return this.result;
    }

    public CheckVoucherStatusResponseBody setSuccess(Boolean success) {
        this.success = success;
        return this;
    }
    public Boolean getSuccess() {
        return this.success;
    }

}
