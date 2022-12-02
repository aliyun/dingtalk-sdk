// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkindustry_1_0.models;

import com.aliyun.tea.*;

public class QueryDoctorDetailsByJobNumberResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
    public QueryDoctorDetailsByJobNumberResponseBody body;

    public static QueryDoctorDetailsByJobNumberResponse build(java.util.Map<String, ?> map) throws Exception {
        QueryDoctorDetailsByJobNumberResponse self = new QueryDoctorDetailsByJobNumberResponse();
        return TeaModel.build(map, self);
    }

    public QueryDoctorDetailsByJobNumberResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public QueryDoctorDetailsByJobNumberResponse setBody(QueryDoctorDetailsByJobNumberResponseBody body) {
        this.body = body;
        return this;
    }
    public QueryDoctorDetailsByJobNumberResponseBody getBody() {
        return this.body;
    }

}
