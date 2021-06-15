// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkindustry_1_0.models;

import com.aliyun.tea.*;

public class QueryAllDoctorsResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
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

    public QueryAllDoctorsResponse setBody(QueryAllDoctorsResponseBody body) {
        this.body = body;
        return this;
    }
    public QueryAllDoctorsResponseBody getBody() {
        return this.body;
    }

}
