// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkconference_1_0.models;

import com.aliyun.tea.*;

public class CohostsResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    @Validation(required = true)
    public Integer statusCode;

    @NameInMap("body")
    @Validation(required = true)
    public CohostsResponseBody body;

    public static CohostsResponse build(java.util.Map<String, ?> map) throws Exception {
        CohostsResponse self = new CohostsResponse();
        return TeaModel.build(map, self);
    }

    public CohostsResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public CohostsResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public CohostsResponse setBody(CohostsResponseBody body) {
        this.body = body;
        return this;
    }
    public CohostsResponseBody getBody() {
        return this.body;
    }

}
