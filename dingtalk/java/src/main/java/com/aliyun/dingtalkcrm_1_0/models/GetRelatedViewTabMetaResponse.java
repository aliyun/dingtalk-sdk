// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcrm_1_0.models;

import com.aliyun.tea.*;

public class GetRelatedViewTabMetaResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public GetRelatedViewTabMetaResponseBody body;

    public static GetRelatedViewTabMetaResponse build(java.util.Map<String, ?> map) throws Exception {
        GetRelatedViewTabMetaResponse self = new GetRelatedViewTabMetaResponse();
        return TeaModel.build(map, self);
    }

    public GetRelatedViewTabMetaResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public GetRelatedViewTabMetaResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public GetRelatedViewTabMetaResponse setBody(GetRelatedViewTabMetaResponseBody body) {
        this.body = body;
        return this;
    }
    public GetRelatedViewTabMetaResponseBody getBody() {
        return this.body;
    }

}
