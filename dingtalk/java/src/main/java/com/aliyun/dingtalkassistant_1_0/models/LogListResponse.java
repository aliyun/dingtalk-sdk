// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkassistant_1_0.models;

import com.aliyun.tea.*;

public class LogListResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public LogListResponseBody body;

    public static LogListResponse build(java.util.Map<String, ?> map) throws Exception {
        LogListResponse self = new LogListResponse();
        return TeaModel.build(map, self);
    }

    public LogListResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public LogListResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public LogListResponse setBody(LogListResponseBody body) {
        this.body = body;
        return this;
    }
    public LogListResponseBody getBody() {
        return this.body;
    }

}
