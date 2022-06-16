// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkindustry_1_0.models;

import com.aliyun.tea.*;

public class QueryDepartmentExtendInfoResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
    public QueryDepartmentExtendInfoResponseBody body;

    public static QueryDepartmentExtendInfoResponse build(java.util.Map<String, ?> map) throws Exception {
        QueryDepartmentExtendInfoResponse self = new QueryDepartmentExtendInfoResponse();
        return TeaModel.build(map, self);
    }

    public QueryDepartmentExtendInfoResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public QueryDepartmentExtendInfoResponse setBody(QueryDepartmentExtendInfoResponseBody body) {
        this.body = body;
        return this;
    }
    public QueryDepartmentExtendInfoResponseBody getBody() {
        return this.body;
    }

}
