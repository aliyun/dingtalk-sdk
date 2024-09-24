// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkhrm_1_0.models;

import com.aliyun.tea.*;

public class InvalidSignRecordsResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public InvalidSignRecordsResponseBody body;

    public static InvalidSignRecordsResponse build(java.util.Map<String, ?> map) throws Exception {
        InvalidSignRecordsResponse self = new InvalidSignRecordsResponse();
        return TeaModel.build(map, self);
    }

    public InvalidSignRecordsResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public InvalidSignRecordsResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public InvalidSignRecordsResponse setBody(InvalidSignRecordsResponseBody body) {
        this.body = body;
        return this;
    }
    public InvalidSignRecordsResponseBody getBody() {
        return this.body;
    }

}
