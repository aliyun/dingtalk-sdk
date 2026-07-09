// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcontract_1_0.models;

import com.aliyun.tea.*;

public class QuerySignFlowDetailResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public QuerySignFlowDetailResponseBody body;

    public static QuerySignFlowDetailResponse build(java.util.Map<String, ?> map) throws Exception {
        QuerySignFlowDetailResponse self = new QuerySignFlowDetailResponse();
        return TeaModel.build(map, self);
    }

    public QuerySignFlowDetailResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public QuerySignFlowDetailResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public QuerySignFlowDetailResponse setBody(QuerySignFlowDetailResponseBody body) {
        this.body = body;
        return this;
    }
    public QuerySignFlowDetailResponseBody getBody() {
        return this.body;
    }

}
