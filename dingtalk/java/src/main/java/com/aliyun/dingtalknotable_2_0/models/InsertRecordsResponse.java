// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalknotable_2_0.models;

import com.aliyun.tea.*;

public class InsertRecordsResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public InsertRecordsResponseBody body;

    public static InsertRecordsResponse build(java.util.Map<String, ?> map) throws Exception {
        InsertRecordsResponse self = new InsertRecordsResponse();
        return TeaModel.build(map, self);
    }

    public InsertRecordsResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public InsertRecordsResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public InsertRecordsResponse setBody(InsertRecordsResponseBody body) {
        this.body = body;
        return this;
    }
    public InsertRecordsResponseBody getBody() {
        return this.body;
    }

}
