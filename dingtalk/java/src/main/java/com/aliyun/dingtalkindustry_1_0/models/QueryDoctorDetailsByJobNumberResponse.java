// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkindustry_1_0.models;

import com.aliyun.tea.*;

public class QueryDoctorDetailsByJobNumberResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
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

    public QueryDoctorDetailsByJobNumberResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public QueryDoctorDetailsByJobNumberResponse setBody(QueryDoctorDetailsByJobNumberResponseBody body) {
        this.body = body;
        return this;
    }
    public QueryDoctorDetailsByJobNumberResponseBody getBody() {
        return this.body;
    }

}
