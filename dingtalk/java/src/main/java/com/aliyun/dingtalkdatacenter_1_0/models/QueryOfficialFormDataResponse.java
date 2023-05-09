// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdatacenter_1_0.models;

import com.aliyun.tea.*;

public class QueryOfficialFormDataResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    @Validation(required = true)
    public Integer statusCode;

    @NameInMap("body")
    @Validation(required = true)
    public QueryOfficialFormDataResponseBody body;

    public static QueryOfficialFormDataResponse build(java.util.Map<String, ?> map) throws Exception {
        QueryOfficialFormDataResponse self = new QueryOfficialFormDataResponse();
        return TeaModel.build(map, self);
    }

    public QueryOfficialFormDataResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public QueryOfficialFormDataResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public QueryOfficialFormDataResponse setBody(QueryOfficialFormDataResponseBody body) {
        this.body = body;
        return this;
    }
    public QueryOfficialFormDataResponseBody getBody() {
        return this.body;
    }

}
