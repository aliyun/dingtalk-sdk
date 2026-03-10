// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkconference_1_0.models;

import com.aliyun.tea.*;

public class OptRecordWhiteAccountResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public OptRecordWhiteAccountResponseBody body;

    public static OptRecordWhiteAccountResponse build(java.util.Map<String, ?> map) throws Exception {
        OptRecordWhiteAccountResponse self = new OptRecordWhiteAccountResponse();
        return TeaModel.build(map, self);
    }

    public OptRecordWhiteAccountResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public OptRecordWhiteAccountResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public OptRecordWhiteAccountResponse setBody(OptRecordWhiteAccountResponseBody body) {
        this.body = body;
        return this;
    }
    public OptRecordWhiteAccountResponseBody getBody() {
        return this.body;
    }

}
