// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkexclusive_1_0.models;

import com.aliyun.tea.*;

public class SpecialRuleBatchReceiverResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public SpecialRuleBatchReceiverResponseBody body;

    public static SpecialRuleBatchReceiverResponse build(java.util.Map<String, ?> map) throws Exception {
        SpecialRuleBatchReceiverResponse self = new SpecialRuleBatchReceiverResponse();
        return TeaModel.build(map, self);
    }

    public SpecialRuleBatchReceiverResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public SpecialRuleBatchReceiverResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public SpecialRuleBatchReceiverResponse setBody(SpecialRuleBatchReceiverResponseBody body) {
        this.body = body;
        return this;
    }
    public SpecialRuleBatchReceiverResponseBody getBody() {
        return this.body;
    }

}
