// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcontract_1_0.models;

import com.aliyun.tea.*;

public class QueryContractAppsTermsExtractResultResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public QueryContractAppsTermsExtractResultResponseBody body;

    public static QueryContractAppsTermsExtractResultResponse build(java.util.Map<String, ?> map) throws Exception {
        QueryContractAppsTermsExtractResultResponse self = new QueryContractAppsTermsExtractResultResponse();
        return TeaModel.build(map, self);
    }

    public QueryContractAppsTermsExtractResultResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public QueryContractAppsTermsExtractResultResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public QueryContractAppsTermsExtractResultResponse setBody(QueryContractAppsTermsExtractResultResponseBody body) {
        this.body = body;
        return this;
    }
    public QueryContractAppsTermsExtractResultResponseBody getBody() {
        return this.body;
    }

}
