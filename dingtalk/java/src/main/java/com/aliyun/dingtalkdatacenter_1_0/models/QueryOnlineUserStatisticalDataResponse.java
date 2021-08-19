// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdatacenter_1_0.models;

import com.aliyun.tea.*;

public class QueryOnlineUserStatisticalDataResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
    public QueryOnlineUserStatisticalDataResponseBody body;

    public static QueryOnlineUserStatisticalDataResponse build(java.util.Map<String, ?> map) throws Exception {
        QueryOnlineUserStatisticalDataResponse self = new QueryOnlineUserStatisticalDataResponse();
        return TeaModel.build(map, self);
    }

    public QueryOnlineUserStatisticalDataResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public QueryOnlineUserStatisticalDataResponse setBody(QueryOnlineUserStatisticalDataResponseBody body) {
        this.body = body;
        return this;
    }
    public QueryOnlineUserStatisticalDataResponseBody getBody() {
        return this.body;
    }

}
