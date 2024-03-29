// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkindustry_1_0.models;

import com.aliyun.tea.*;

public class QueryHospitalDistrictInfoResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public QueryHospitalDistrictInfoResponseBody body;

    public static QueryHospitalDistrictInfoResponse build(java.util.Map<String, ?> map) throws Exception {
        QueryHospitalDistrictInfoResponse self = new QueryHospitalDistrictInfoResponse();
        return TeaModel.build(map, self);
    }

    public QueryHospitalDistrictInfoResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public QueryHospitalDistrictInfoResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public QueryHospitalDistrictInfoResponse setBody(QueryHospitalDistrictInfoResponseBody body) {
        this.body = body;
        return this;
    }
    public QueryHospitalDistrictInfoResponseBody getBody() {
        return this.body;
    }

}
