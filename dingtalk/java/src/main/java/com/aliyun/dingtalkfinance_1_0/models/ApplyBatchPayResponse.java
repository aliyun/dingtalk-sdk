// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkfinance_1_0.models;

import com.aliyun.tea.*;

public class ApplyBatchPayResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
    public ApplyBatchPayResponseBody body;

    public static ApplyBatchPayResponse build(java.util.Map<String, ?> map) throws Exception {
        ApplyBatchPayResponse self = new ApplyBatchPayResponse();
        return TeaModel.build(map, self);
    }

    public ApplyBatchPayResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public ApplyBatchPayResponse setBody(ApplyBatchPayResponseBody body) {
        this.body = body;
        return this;
    }
    public ApplyBatchPayResponseBody getBody() {
        return this.body;
    }

}
