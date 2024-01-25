// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkhrm_1_0.models;

import com.aliyun.tea.*;

public class SolutionTaskInitResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public SolutionTaskInitResponseBody body;

    public static SolutionTaskInitResponse build(java.util.Map<String, ?> map) throws Exception {
        SolutionTaskInitResponse self = new SolutionTaskInitResponse();
        return TeaModel.build(map, self);
    }

    public SolutionTaskInitResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public SolutionTaskInitResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public SolutionTaskInitResponse setBody(SolutionTaskInitResponseBody body) {
        this.body = body;
        return this;
    }
    public SolutionTaskInitResponseBody getBody() {
        return this.body;
    }

}
