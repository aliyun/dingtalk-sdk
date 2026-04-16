// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdvi_1_0.models;

import com.aliyun.tea.*;

public class QueryFileInfoByMinutesIdResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public QueryFileInfoByMinutesIdResponseBody body;

    public static QueryFileInfoByMinutesIdResponse build(java.util.Map<String, ?> map) throws Exception {
        QueryFileInfoByMinutesIdResponse self = new QueryFileInfoByMinutesIdResponse();
        return TeaModel.build(map, self);
    }

    public QueryFileInfoByMinutesIdResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public QueryFileInfoByMinutesIdResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public QueryFileInfoByMinutesIdResponse setBody(QueryFileInfoByMinutesIdResponseBody body) {
        this.body = body;
        return this;
    }
    public QueryFileInfoByMinutesIdResponseBody getBody() {
        return this.body;
    }

}
