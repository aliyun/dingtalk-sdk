// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcontract_1_0.models;

import com.aliyun.tea.*;

public class QueryAdvancedContractVersionResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public QueryAdvancedContractVersionResponseBody body;

    public static QueryAdvancedContractVersionResponse build(java.util.Map<String, ?> map) throws Exception {
        QueryAdvancedContractVersionResponse self = new QueryAdvancedContractVersionResponse();
        return TeaModel.build(map, self);
    }

    public QueryAdvancedContractVersionResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public QueryAdvancedContractVersionResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public QueryAdvancedContractVersionResponse setBody(QueryAdvancedContractVersionResponseBody body) {
        this.body = body;
        return this;
    }
    public QueryAdvancedContractVersionResponseBody getBody() {
        return this.body;
    }

}
