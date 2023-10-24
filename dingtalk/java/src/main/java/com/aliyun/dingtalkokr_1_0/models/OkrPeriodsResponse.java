// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkokr_1_0.models;

import com.aliyun.tea.*;

public class OkrPeriodsResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    @Validation(required = true)
    public Integer statusCode;

    @NameInMap("body")
    @Validation(required = true)
    public OkrPeriodsResponseBody body;

    public static OkrPeriodsResponse build(java.util.Map<String, ?> map) throws Exception {
        OkrPeriodsResponse self = new OkrPeriodsResponse();
        return TeaModel.build(map, self);
    }

    public OkrPeriodsResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public OkrPeriodsResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public OkrPeriodsResponse setBody(OkrPeriodsResponseBody body) {
        this.body = body;
        return this;
    }
    public OkrPeriodsResponseBody getBody() {
        return this.body;
    }

}
