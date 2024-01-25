// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkhrm_1_0.models;

import com.aliyun.tea.*;

public class QueryHrmEmployeeDismissionInfoResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public QueryHrmEmployeeDismissionInfoResponseBody body;

    public static QueryHrmEmployeeDismissionInfoResponse build(java.util.Map<String, ?> map) throws Exception {
        QueryHrmEmployeeDismissionInfoResponse self = new QueryHrmEmployeeDismissionInfoResponse();
        return TeaModel.build(map, self);
    }

    public QueryHrmEmployeeDismissionInfoResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public QueryHrmEmployeeDismissionInfoResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public QueryHrmEmployeeDismissionInfoResponse setBody(QueryHrmEmployeeDismissionInfoResponseBody body) {
        this.body = body;
        return this;
    }
    public QueryHrmEmployeeDismissionInfoResponseBody getBody() {
        return this.body;
    }

}
