// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkyida_2_0.models;

import com.aliyun.tea.*;

public class GetFormComponentAliasListResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public GetFormComponentAliasListResponseBody body;

    public static GetFormComponentAliasListResponse build(java.util.Map<String, ?> map) throws Exception {
        GetFormComponentAliasListResponse self = new GetFormComponentAliasListResponse();
        return TeaModel.build(map, self);
    }

    public GetFormComponentAliasListResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public GetFormComponentAliasListResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public GetFormComponentAliasListResponse setBody(GetFormComponentAliasListResponseBody body) {
        this.body = body;
        return this;
    }
    public GetFormComponentAliasListResponseBody getBody() {
        return this.body;
    }

}
