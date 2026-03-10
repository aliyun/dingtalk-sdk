// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkexclusive_1_0.models;

import com.aliyun.tea.*;

public class ExclusivePcAlertResponseBody extends TeaModel {
    @NameInMap("result")
    public Boolean result;

    @NameInMap("success")
    public Boolean success;

    public static ExclusivePcAlertResponseBody build(java.util.Map<String, ?> map) throws Exception {
        ExclusivePcAlertResponseBody self = new ExclusivePcAlertResponseBody();
        return TeaModel.build(map, self);
    }

    public ExclusivePcAlertResponseBody setResult(Boolean result) {
        this.result = result;
        return this;
    }
    public Boolean getResult() {
        return this.result;
    }

    public ExclusivePcAlertResponseBody setSuccess(Boolean success) {
        this.success = success;
        return this;
    }
    public Boolean getSuccess() {
        return this.success;
    }

}
