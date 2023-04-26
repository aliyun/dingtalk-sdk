// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdatacenter_1_0.models;

import com.aliyun.tea.*;

public class QueryOfficialDataResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    @Validation(required = true)
    public Integer statusCode;

    @NameInMap("body")
    @Validation(required = true)
    public QueryOfficialDataResponseBody body;

    public static QueryOfficialDataResponse build(java.util.Map<String, ?> map) throws Exception {
        QueryOfficialDataResponse self = new QueryOfficialDataResponse();
        return TeaModel.build(map, self);
    }

    public QueryOfficialDataResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public QueryOfficialDataResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public QueryOfficialDataResponse setBody(QueryOfficialDataResponseBody body) {
        this.body = body;
        return this;
    }
    public QueryOfficialDataResponseBody getBody() {
        return this.body;
    }

}
