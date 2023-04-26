// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkworkflow_1_0.models;

import com.aliyun.tea.*;

public class QueryFormByBizTypeResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    @Validation(required = true)
    public Integer statusCode;

    @NameInMap("body")
    @Validation(required = true)
    public QueryFormByBizTypeResponseBody body;

    public static QueryFormByBizTypeResponse build(java.util.Map<String, ?> map) throws Exception {
        QueryFormByBizTypeResponse self = new QueryFormByBizTypeResponse();
        return TeaModel.build(map, self);
    }

    public QueryFormByBizTypeResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public QueryFormByBizTypeResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public QueryFormByBizTypeResponse setBody(QueryFormByBizTypeResponseBody body) {
        this.body = body;
        return this;
    }
    public QueryFormByBizTypeResponseBody getBody() {
        return this.body;
    }

}
