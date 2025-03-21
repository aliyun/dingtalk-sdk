// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcontract_1_0.models;

import com.aliyun.tea.*;

public class QueryContractAppsCompareResultResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public QueryContractAppsCompareResultResponseBody body;

    public static QueryContractAppsCompareResultResponse build(java.util.Map<String, ?> map) throws Exception {
        QueryContractAppsCompareResultResponse self = new QueryContractAppsCompareResultResponse();
        return TeaModel.build(map, self);
    }

    public QueryContractAppsCompareResultResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public QueryContractAppsCompareResultResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public QueryContractAppsCompareResultResponse setBody(QueryContractAppsCompareResultResponseBody body) {
        this.body = body;
        return this;
    }
    public QueryContractAppsCompareResultResponseBody getBody() {
        return this.body;
    }

}
