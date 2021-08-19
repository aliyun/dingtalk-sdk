// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdatacenter_1_0.models;

import com.aliyun.tea.*;

public class QueryDriveStatisticalDataResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
    public QueryDriveStatisticalDataResponseBody body;

    public static QueryDriveStatisticalDataResponse build(java.util.Map<String, ?> map) throws Exception {
        QueryDriveStatisticalDataResponse self = new QueryDriveStatisticalDataResponse();
        return TeaModel.build(map, self);
    }

    public QueryDriveStatisticalDataResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public QueryDriveStatisticalDataResponse setBody(QueryDriveStatisticalDataResponseBody body) {
        this.body = body;
        return this;
    }
    public QueryDriveStatisticalDataResponseBody getBody() {
        return this.body;
    }

}
