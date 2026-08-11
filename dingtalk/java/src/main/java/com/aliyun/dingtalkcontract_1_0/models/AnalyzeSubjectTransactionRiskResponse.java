// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcontract_1_0.models;

import com.aliyun.tea.*;

public class AnalyzeSubjectTransactionRiskResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public AnalyzeSubjectTransactionRiskResponseBody body;

    public static AnalyzeSubjectTransactionRiskResponse build(java.util.Map<String, ?> map) throws Exception {
        AnalyzeSubjectTransactionRiskResponse self = new AnalyzeSubjectTransactionRiskResponse();
        return TeaModel.build(map, self);
    }

    public AnalyzeSubjectTransactionRiskResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public AnalyzeSubjectTransactionRiskResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public AnalyzeSubjectTransactionRiskResponse setBody(AnalyzeSubjectTransactionRiskResponseBody body) {
        this.body = body;
        return this;
    }
    public AnalyzeSubjectTransactionRiskResponseBody getBody() {
        return this.body;
    }

}
