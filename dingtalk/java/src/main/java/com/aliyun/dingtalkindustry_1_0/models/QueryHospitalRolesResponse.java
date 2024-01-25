// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkindustry_1_0.models;

import com.aliyun.tea.*;

public class QueryHospitalRolesResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public QueryHospitalRolesResponseBody body;

    public static QueryHospitalRolesResponse build(java.util.Map<String, ?> map) throws Exception {
        QueryHospitalRolesResponse self = new QueryHospitalRolesResponse();
        return TeaModel.build(map, self);
    }

    public QueryHospitalRolesResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public QueryHospitalRolesResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public QueryHospitalRolesResponse setBody(QueryHospitalRolesResponseBody body) {
        this.body = body;
        return this;
    }
    public QueryHospitalRolesResponseBody getBody() {
        return this.body;
    }

}
