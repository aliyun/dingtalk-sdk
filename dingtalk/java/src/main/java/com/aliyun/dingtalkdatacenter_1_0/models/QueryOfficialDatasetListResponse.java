// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdatacenter_1_0.models;

import com.aliyun.tea.*;

public class QueryOfficialDatasetListResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
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

    public QueryOfficialDatasetListResponse setBody(QueryOfficialDatasetListResponseBody body) {
        this.body = body;
        return this;
    }
    public QueryOfficialDatasetListResponseBody getBody() {
        return this.body;
    }

}
