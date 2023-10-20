// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkexclusive_1_0.models;

import com.aliyun.tea.*;

public class ApproveProcessCallbackResponseBody extends TeaModel {
    @NameInMap("success")
    public String success;

    public static ApproveProcessCallbackResponseBody build(java.util.Map<String, ?> map) throws Exception {
        ApproveProcessCallbackResponseBody self = new ApproveProcessCallbackResponseBody();
        return TeaModel.build(map, self);
    }

    public ApproveProcessCallbackResponseBody setSuccess(String success) {
        this.success = success;
        return this;
    }
    public String getSuccess() {
        return this.success;
    }

}
