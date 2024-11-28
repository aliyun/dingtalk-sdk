// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkexclusive_1_0.models;

import com.aliyun.tea.*;

public class GetGroupInfoByCidResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public GetGroupInfoByCidResponseBody body;

    public static GetGroupInfoByCidResponse build(java.util.Map<String, ?> map) throws Exception {
        GetGroupInfoByCidResponse self = new GetGroupInfoByCidResponse();
        return TeaModel.build(map, self);
    }

    public GetGroupInfoByCidResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public GetGroupInfoByCidResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public GetGroupInfoByCidResponse setBody(GetGroupInfoByCidResponseBody body) {
        this.body = body;
        return this;
    }
    public GetGroupInfoByCidResponseBody getBody() {
        return this.body;
    }

}
