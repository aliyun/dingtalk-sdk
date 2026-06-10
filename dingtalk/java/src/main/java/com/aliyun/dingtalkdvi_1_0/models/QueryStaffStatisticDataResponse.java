// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdvi_1_0.models;

import com.aliyun.tea.*;

public class QueryStaffStatisticDataResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public QueryStaffStatisticDataResponseBody body;

    public static QueryStaffStatisticDataResponse build(java.util.Map<String, ?> map) throws Exception {
        QueryStaffStatisticDataResponse self = new QueryStaffStatisticDataResponse();
        return TeaModel.build(map, self);
    }

    public QueryStaffStatisticDataResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public QueryStaffStatisticDataResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public QueryStaffStatisticDataResponse setBody(QueryStaffStatisticDataResponseBody body) {
        this.body = body;
        return this;
    }
    public QueryStaffStatisticDataResponseBody getBody() {
        return this.body;
    }

}
