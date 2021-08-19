// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdatacenter_1_0.models;

import com.aliyun.tea.*;

public class QueryCheckinStatisticalDataResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
    public QueryCheckinStatisticalDataResponseBody body;

    public static QueryCheckinStatisticalDataResponse build(java.util.Map<String, ?> map) throws Exception {
        QueryCheckinStatisticalDataResponse self = new QueryCheckinStatisticalDataResponse();
        return TeaModel.build(map, self);
    }

    public QueryCheckinStatisticalDataResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public QueryCheckinStatisticalDataResponse setBody(QueryCheckinStatisticalDataResponseBody body) {
        this.body = body;
        return this;
    }
    public QueryCheckinStatisticalDataResponseBody getBody() {
        return this.body;
    }

}
