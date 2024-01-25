// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdatacenter_1_0.models;

import com.aliyun.tea.*;

public class QueryOfficialDatasetFieldsResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public QueryOfficialDatasetFieldsResponseBody body;

    public static QueryOfficialDatasetFieldsResponse build(java.util.Map<String, ?> map) throws Exception {
        QueryOfficialDatasetFieldsResponse self = new QueryOfficialDatasetFieldsResponse();
        return TeaModel.build(map, self);
    }

    public QueryOfficialDatasetFieldsResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public QueryOfficialDatasetFieldsResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public QueryOfficialDatasetFieldsResponse setBody(QueryOfficialDatasetFieldsResponseBody body) {
        this.body = body;
        return this;
    }
    public QueryOfficialDatasetFieldsResponseBody getBody() {
        return this.body;
    }

}
