// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcontract_1_0.models;

import com.aliyun.tea.*;

public class QueryContractCompareListResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public QueryContractCompareListResponseBody body;

    public static QueryContractCompareListResponse build(java.util.Map<String, ?> map) throws Exception {
        QueryContractCompareListResponse self = new QueryContractCompareListResponse();
        return TeaModel.build(map, self);
    }

    public QueryContractCompareListResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public QueryContractCompareListResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public QueryContractCompareListResponse setBody(QueryContractCompareListResponseBody body) {
        this.body = body;
        return this;
    }
    public QueryContractCompareListResponseBody getBody() {
        return this.body;
    }

}
