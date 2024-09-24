// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkhrm_1_0.models;

import com.aliyun.tea.*;

public class RevokeSignRecordsResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public RevokeSignRecordsResponseBody body;

    public static RevokeSignRecordsResponse build(java.util.Map<String, ?> map) throws Exception {
        RevokeSignRecordsResponse self = new RevokeSignRecordsResponse();
        return TeaModel.build(map, self);
    }

    public RevokeSignRecordsResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public RevokeSignRecordsResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public RevokeSignRecordsResponse setBody(RevokeSignRecordsResponseBody body) {
        this.body = body;
        return this;
    }
    public RevokeSignRecordsResponseBody getBody() {
        return this.body;
    }

}
