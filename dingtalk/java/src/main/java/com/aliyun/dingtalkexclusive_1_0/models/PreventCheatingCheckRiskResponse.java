// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkexclusive_1_0.models;

import com.aliyun.tea.*;

public class PreventCheatingCheckRiskResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public PreventCheatingCheckRiskResponseBody body;

    public static PreventCheatingCheckRiskResponse build(java.util.Map<String, ?> map) throws Exception {
        PreventCheatingCheckRiskResponse self = new PreventCheatingCheckRiskResponse();
        return TeaModel.build(map, self);
    }

    public PreventCheatingCheckRiskResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public PreventCheatingCheckRiskResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public PreventCheatingCheckRiskResponse setBody(PreventCheatingCheckRiskResponseBody body) {
        this.body = body;
        return this;
    }
    public PreventCheatingCheckRiskResponseBody getBody() {
        return this.body;
    }

}
