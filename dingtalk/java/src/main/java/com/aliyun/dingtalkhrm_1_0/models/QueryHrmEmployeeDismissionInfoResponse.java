// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkhrm_1_0.models;

import com.aliyun.tea.*;

public class QueryHrmEmployeeDismissionInfoResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
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

    public QueryHrmEmployeeDismissionInfoResponse setBody(QueryHrmEmployeeDismissionInfoResponseBody body) {
        this.body = body;
        return this;
    }
    public QueryHrmEmployeeDismissionInfoResponseBody getBody() {
        return this.body;
    }

}
