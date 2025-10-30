// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcontract_1_0.models;

import com.aliyun.tea.*;

public class QueryContractSignInfoResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public QueryContractSignInfoResponseBody body;

    public static QueryContractSignInfoResponse build(java.util.Map<String, ?> map) throws Exception {
        QueryContractSignInfoResponse self = new QueryContractSignInfoResponse();
        return TeaModel.build(map, self);
    }

    public QueryContractSignInfoResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public QueryContractSignInfoResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public QueryContractSignInfoResponse setBody(QueryContractSignInfoResponseBody body) {
        this.body = body;
        return this;
    }
    public QueryContractSignInfoResponseBody getBody() {
        return this.body;
    }

}
