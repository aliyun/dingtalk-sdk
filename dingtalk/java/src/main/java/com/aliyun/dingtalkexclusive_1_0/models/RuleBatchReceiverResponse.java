// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkexclusive_1_0.models;

import com.aliyun.tea.*;

public class RuleBatchReceiverResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public RuleBatchReceiverResponseBody body;

    public static RuleBatchReceiverResponse build(java.util.Map<String, ?> map) throws Exception {
        RuleBatchReceiverResponse self = new RuleBatchReceiverResponse();
        return TeaModel.build(map, self);
    }

    public RuleBatchReceiverResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public RuleBatchReceiverResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public RuleBatchReceiverResponse setBody(RuleBatchReceiverResponseBody body) {
        this.body = body;
        return this;
    }
    public RuleBatchReceiverResponseBody getBody() {
        return this.body;
    }

}
