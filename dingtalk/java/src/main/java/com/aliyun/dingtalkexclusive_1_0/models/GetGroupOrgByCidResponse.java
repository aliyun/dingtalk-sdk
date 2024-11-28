// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkexclusive_1_0.models;

import com.aliyun.tea.*;

public class GetGroupOrgByCidResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public GetGroupOrgByCidResponseBody body;

    public static GetGroupOrgByCidResponse build(java.util.Map<String, ?> map) throws Exception {
        GetGroupOrgByCidResponse self = new GetGroupOrgByCidResponse();
        return TeaModel.build(map, self);
    }

    public GetGroupOrgByCidResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public GetGroupOrgByCidResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public GetGroupOrgByCidResponse setBody(GetGroupOrgByCidResponseBody body) {
        this.body = body;
        return this;
    }
    public GetGroupOrgByCidResponseBody getBody() {
        return this.body;
    }

}
