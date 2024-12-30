// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalktodo_e_e_1_0.models;

import com.aliyun.tea.*;

public class GetTemplateListResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public GetTemplateListResponseBody body;

    public static GetTemplateListResponse build(java.util.Map<String, ?> map) throws Exception {
        GetTemplateListResponse self = new GetTemplateListResponse();
        return TeaModel.build(map, self);
    }

    public GetTemplateListResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public GetTemplateListResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public GetTemplateListResponse setBody(GetTemplateListResponseBody body) {
        this.body = body;
        return this;
    }
    public GetTemplateListResponseBody getBody() {
        return this.body;
    }

}
