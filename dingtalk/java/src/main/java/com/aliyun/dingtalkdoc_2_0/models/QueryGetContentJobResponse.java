// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdoc_2_0.models;

import com.aliyun.tea.*;

public class QueryGetContentJobResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public QueryGetContentJobResponseBody body;

    public static QueryGetContentJobResponse build(java.util.Map<String, ?> map) throws Exception {
        QueryGetContentJobResponse self = new QueryGetContentJobResponse();
        return TeaModel.build(map, self);
    }

    public QueryGetContentJobResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public QueryGetContentJobResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public QueryGetContentJobResponse setBody(QueryGetContentJobResponseBody body) {
        this.body = body;
        return this;
    }
    public QueryGetContentJobResponseBody getBody() {
        return this.body;
    }

}
