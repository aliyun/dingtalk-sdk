// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdoc_2_0.models;

import com.aliyun.tea.*;

public class GetOrgOrWebOpenDocContentResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public GetOrgOrWebOpenDocContentResponseBody body;

    public static GetOrgOrWebOpenDocContentResponse build(java.util.Map<String, ?> map) throws Exception {
        GetOrgOrWebOpenDocContentResponse self = new GetOrgOrWebOpenDocContentResponse();
        return TeaModel.build(map, self);
    }

    public GetOrgOrWebOpenDocContentResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public GetOrgOrWebOpenDocContentResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public GetOrgOrWebOpenDocContentResponse setBody(GetOrgOrWebOpenDocContentResponseBody body) {
        this.body = body;
        return this;
    }
    public GetOrgOrWebOpenDocContentResponseBody getBody() {
        return this.body;
    }

}
