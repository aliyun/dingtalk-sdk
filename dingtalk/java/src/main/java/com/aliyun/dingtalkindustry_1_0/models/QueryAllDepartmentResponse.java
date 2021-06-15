// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkindustry_1_0.models;

import com.aliyun.tea.*;

public class QueryAllDepartmentResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
    public QueryAllDepartmentResponseBody body;

    public static QueryAllDepartmentResponse build(java.util.Map<String, ?> map) throws Exception {
        QueryAllDepartmentResponse self = new QueryAllDepartmentResponse();
        return TeaModel.build(map, self);
    }

    public QueryAllDepartmentResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public QueryAllDepartmentResponse setBody(QueryAllDepartmentResponseBody body) {
        this.body = body;
        return this;
    }
    public QueryAllDepartmentResponseBody getBody() {
        return this.body;
    }

}
