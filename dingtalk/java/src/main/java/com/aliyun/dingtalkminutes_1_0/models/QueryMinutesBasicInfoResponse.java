// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkminutes_1_0.models;

import com.aliyun.tea.*;

public class QueryMinutesBasicInfoResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public QueryMinutesBasicInfoResponseBody body;

    public static QueryMinutesBasicInfoResponse build(java.util.Map<String, ?> map) throws Exception {
        QueryMinutesBasicInfoResponse self = new QueryMinutesBasicInfoResponse();
        return TeaModel.build(map, self);
    }

    public QueryMinutesBasicInfoResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public QueryMinutesBasicInfoResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public QueryMinutesBasicInfoResponse setBody(QueryMinutesBasicInfoResponseBody body) {
        this.body = body;
        return this;
    }
    public QueryMinutesBasicInfoResponseBody getBody() {
        return this.body;
    }

}
