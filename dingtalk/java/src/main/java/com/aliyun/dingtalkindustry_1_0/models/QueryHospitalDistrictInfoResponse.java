// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkindustry_1_0.models;

import com.aliyun.tea.*;

public class QueryHospitalDistrictInfoResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
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

    public QueryHospitalDistrictInfoResponse setBody(QueryHospitalDistrictInfoResponseBody body) {
        this.body = body;
        return this;
    }
    public QueryHospitalDistrictInfoResponseBody getBody() {
        return this.body;
    }

}
