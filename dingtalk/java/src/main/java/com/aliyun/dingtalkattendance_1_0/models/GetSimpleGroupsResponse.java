// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkattendance_1_0.models;

import com.aliyun.tea.*;

public class GetSimpleGroupsResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    @Validation(required = true)
    public Integer statusCode;

    @NameInMap("body")
    @Validation(required = true)
    public GetSimpleGroupsResponseBody body;

    public static GetSimpleGroupsResponse build(java.util.Map<String, ?> map) throws Exception {
        GetSimpleGroupsResponse self = new GetSimpleGroupsResponse();
        return TeaModel.build(map, self);
    }

    public GetSimpleGroupsResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public GetSimpleGroupsResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public GetSimpleGroupsResponse setBody(GetSimpleGroupsResponseBody body) {
        this.body = body;
        return this;
    }
    public GetSimpleGroupsResponseBody getBody() {
        return this.body;
    }

}
