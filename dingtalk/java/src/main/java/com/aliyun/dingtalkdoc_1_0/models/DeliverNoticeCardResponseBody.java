// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdoc_1_0.models;

import com.aliyun.tea.*;

public class DeliverNoticeCardResponseBody extends TeaModel {
    @NameInMap("result")
    public java.util.Map<String, ?> result;

    @NameInMap("success")
    public Boolean success;

    public static DeliverNoticeCardResponseBody build(java.util.Map<String, ?> map) throws Exception {
        DeliverNoticeCardResponseBody self = new DeliverNoticeCardResponseBody();
        return TeaModel.build(map, self);
    }

    public DeliverNoticeCardResponseBody setResult(java.util.Map<String, ?> result) {
        this.result = result;
        return this;
    }
    public java.util.Map<String, ?> getResult() {
        return this.result;
    }

    public DeliverNoticeCardResponseBody setSuccess(Boolean success) {
        this.success = success;
        return this;
    }
    public Boolean getSuccess() {
        return this.success;
    }

}
