// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkindustry_1_0.models;

import com.aliyun.tea.*;

public class QueryHospitalRoleUserInfoResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    @Validation(required = true)
    public Integer statusCode;

    @NameInMap("body")
    @Validation(required = true)
    public QueryHospitalRoleUserInfoResponseBody body;

    public static QueryHospitalRoleUserInfoResponse build(java.util.Map<String, ?> map) throws Exception {
        QueryHospitalRoleUserInfoResponse self = new QueryHospitalRoleUserInfoResponse();
        return TeaModel.build(map, self);
    }

    public QueryHospitalRoleUserInfoResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public QueryHospitalRoleUserInfoResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public QueryHospitalRoleUserInfoResponse setBody(QueryHospitalRoleUserInfoResponseBody body) {
        this.body = body;
        return this;
    }
    public QueryHospitalRoleUserInfoResponseBody getBody() {
        return this.body;
    }

}
