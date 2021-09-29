// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkyida_1_0.models;

import com.aliyun.tea.*;

public class GetFormComponentDefinitionListResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
    public GetFormComponentDefinitionListResponseBody body;

    public static GetFormComponentDefinitionListResponse build(java.util.Map<String, ?> map) throws Exception {
        GetFormComponentDefinitionListResponse self = new GetFormComponentDefinitionListResponse();
        return TeaModel.build(map, self);
    }

    public GetFormComponentDefinitionListResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public GetFormComponentDefinitionListResponse setBody(GetFormComponentDefinitionListResponseBody body) {
        this.body = body;
        return this;
    }
    public GetFormComponentDefinitionListResponseBody getBody() {
        return this.body;
    }

}
