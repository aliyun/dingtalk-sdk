// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkexclusive_1_0.models;

import com.aliyun.tea.*;

public class BusinessEventUpdateResponseBody extends TeaModel {
    @NameInMap("result")
    public Boolean result;

    @NameInMap("success")
    public Boolean success;

    public static BusinessEventUpdateResponseBody build(java.util.Map<String, ?> map) throws Exception {
        BusinessEventUpdateResponseBody self = new BusinessEventUpdateResponseBody();
        return TeaModel.build(map, self);
    }

    public BusinessEventUpdateResponseBody setResult(Boolean result) {
        this.result = result;
        return this;
    }
    public Boolean getResult() {
        return this.result;
    }

    public BusinessEventUpdateResponseBody setSuccess(Boolean success) {
        this.success = success;
        return this;
    }
    public Boolean getSuccess() {
        return this.success;
    }

}
