// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcontract_1_0.models;

import com.aliyun.tea.*;

public class QueryContractAppsExtractResultResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public QueryContractAppsExtractResultResponseBody body;

    public static QueryContractAppsExtractResultResponse build(java.util.Map<String, ?> map) throws Exception {
        QueryContractAppsExtractResultResponse self = new QueryContractAppsExtractResultResponse();
        return TeaModel.build(map, self);
    }

    public QueryContractAppsExtractResultResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public QueryContractAppsExtractResultResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public QueryContractAppsExtractResultResponse setBody(QueryContractAppsExtractResultResponseBody body) {
        this.body = body;
        return this;
    }
    public QueryContractAppsExtractResultResponseBody getBody() {
        return this.body;
    }

}
