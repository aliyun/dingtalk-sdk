// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkexclusive_1_0.models;

import com.aliyun.tea.*;

public class QueryChannelStaffInfoByMobileResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public QueryChannelStaffInfoByMobileResponseBody body;

    public static QueryChannelStaffInfoByMobileResponse build(java.util.Map<String, ?> map) throws Exception {
        QueryChannelStaffInfoByMobileResponse self = new QueryChannelStaffInfoByMobileResponse();
        return TeaModel.build(map, self);
    }

    public QueryChannelStaffInfoByMobileResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public QueryChannelStaffInfoByMobileResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public QueryChannelStaffInfoByMobileResponse setBody(QueryChannelStaffInfoByMobileResponseBody body) {
        this.body = body;
        return this;
    }
    public QueryChannelStaffInfoByMobileResponseBody getBody() {
        return this.body;
    }

}
