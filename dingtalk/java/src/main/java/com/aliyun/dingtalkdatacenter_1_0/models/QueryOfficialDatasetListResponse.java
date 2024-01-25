// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdatacenter_1_0.models;

import com.aliyun.tea.*;

public class QueryOfficialDatasetListResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public QueryOfficialDatasetListResponseBody body;

    public static QueryOfficialDatasetListResponse build(java.util.Map<String, ?> map) throws Exception {
        QueryOfficialDatasetListResponse self = new QueryOfficialDatasetListResponse();
        return TeaModel.build(map, self);
    }

    public QueryOfficialDatasetListResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public QueryOfficialDatasetListResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public QueryOfficialDatasetListResponse setBody(QueryOfficialDatasetListResponseBody body) {
        this.body = body;
        return this;
    }
    public QueryOfficialDatasetListResponseBody getBody() {
        return this.body;
    }

}
