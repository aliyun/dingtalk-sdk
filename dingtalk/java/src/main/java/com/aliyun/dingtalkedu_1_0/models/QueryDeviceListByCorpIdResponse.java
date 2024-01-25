// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkedu_1_0.models;

import com.aliyun.tea.*;

public class QueryDeviceListByCorpIdResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public QueryDeviceListByCorpIdResponseBody body;

    public static QueryDeviceListByCorpIdResponse build(java.util.Map<String, ?> map) throws Exception {
        QueryDeviceListByCorpIdResponse self = new QueryDeviceListByCorpIdResponse();
        return TeaModel.build(map, self);
    }

    public QueryDeviceListByCorpIdResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public QueryDeviceListByCorpIdResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public QueryDeviceListByCorpIdResponse setBody(QueryDeviceListByCorpIdResponseBody body) {
        this.body = body;
        return this;
    }
    public QueryDeviceListByCorpIdResponseBody getBody() {
        return this.body;
    }

}
