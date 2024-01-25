// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkexclusive_1_0.models;

import com.aliyun.tea.*;

public class ApproveProcessCallbackResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public ApproveProcessCallbackResponseBody body;

    public static ApproveProcessCallbackResponse build(java.util.Map<String, ?> map) throws Exception {
        ApproveProcessCallbackResponse self = new ApproveProcessCallbackResponse();
        return TeaModel.build(map, self);
    }

    public ApproveProcessCallbackResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public ApproveProcessCallbackResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public ApproveProcessCallbackResponse setBody(ApproveProcessCallbackResponseBody body) {
        this.body = body;
        return this;
    }
    public ApproveProcessCallbackResponseBody getBody() {
        return this.body;
    }

}
