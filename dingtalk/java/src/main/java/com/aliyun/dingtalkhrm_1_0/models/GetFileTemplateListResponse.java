// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkhrm_1_0.models;

import com.aliyun.tea.*;

public class GetFileTemplateListResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public GetFileTemplateListResponseBody body;

    public static GetFileTemplateListResponse build(java.util.Map<String, ?> map) throws Exception {
        GetFileTemplateListResponse self = new GetFileTemplateListResponse();
        return TeaModel.build(map, self);
    }

    public GetFileTemplateListResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public GetFileTemplateListResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public GetFileTemplateListResponse setBody(GetFileTemplateListResponseBody body) {
        this.body = body;
        return this;
    }
    public GetFileTemplateListResponseBody getBody() {
        return this.body;
    }

}
