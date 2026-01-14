// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkminutes_1_0.models;

import com.aliyun.tea.*;

public class GenerateSummaryResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public GenerateSummaryResponseBody body;

    public static GenerateSummaryResponse build(java.util.Map<String, ?> map) throws Exception {
        GenerateSummaryResponse self = new GenerateSummaryResponse();
        return TeaModel.build(map, self);
    }

    public GenerateSummaryResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public GenerateSummaryResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public GenerateSummaryResponse setBody(GenerateSummaryResponseBody body) {
        this.body = body;
        return this;
    }
    public GenerateSummaryResponseBody getBody() {
        return this.body;
    }

}
