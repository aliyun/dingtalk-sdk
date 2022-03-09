// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkokr_1_0.models;

import com.aliyun.tea.*;

public class UpdateKROfWeightResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
    public UpdateKROfWeightResponseBody body;

    public static UpdateKROfWeightResponse build(java.util.Map<String, ?> map) throws Exception {
        UpdateKROfWeightResponse self = new UpdateKROfWeightResponse();
        return TeaModel.build(map, self);
    }

    public UpdateKROfWeightResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public UpdateKROfWeightResponse setBody(UpdateKROfWeightResponseBody body) {
        this.body = body;
        return this;
    }
    public UpdateKROfWeightResponseBody getBody() {
        return this.body;
    }

}
