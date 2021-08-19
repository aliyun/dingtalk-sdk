// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdatacenter_1_0.models;

import com.aliyun.tea.*;

public class QueryDocumentStatisticalDataResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
    public QueryDocumentStatisticalDataResponseBody body;

    public static QueryDocumentStatisticalDataResponse build(java.util.Map<String, ?> map) throws Exception {
        QueryDocumentStatisticalDataResponse self = new QueryDocumentStatisticalDataResponse();
        return TeaModel.build(map, self);
    }

    public QueryDocumentStatisticalDataResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public QueryDocumentStatisticalDataResponse setBody(QueryDocumentStatisticalDataResponseBody body) {
        this.body = body;
        return this;
    }
    public QueryDocumentStatisticalDataResponseBody getBody() {
        return this.body;
    }

}
