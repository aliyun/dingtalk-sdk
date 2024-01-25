// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkindustry_1_0.models;

import com.aliyun.tea.*;

public class QueryAllDoctorsResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public QueryAllDoctorsResponseBody body;

    public static QueryAllDoctorsResponse build(java.util.Map<String, ?> map) throws Exception {
        QueryAllDoctorsResponse self = new QueryAllDoctorsResponse();
        return TeaModel.build(map, self);
    }

    public QueryAllDoctorsResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public QueryAllDoctorsResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public QueryAllDoctorsResponse setBody(QueryAllDoctorsResponseBody body) {
        this.body = body;
        return this;
    }
    public QueryAllDoctorsResponseBody getBody() {
        return this.body;
    }

}
