// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkim_1_0.models;

import com.aliyun.tea.*;

public class GetSceneGroupTemplateMessageOpenStatusResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public GetSceneGroupTemplateMessageOpenStatusResponseBody body;

    public static GetSceneGroupTemplateMessageOpenStatusResponse build(java.util.Map<String, ?> map) throws Exception {
        GetSceneGroupTemplateMessageOpenStatusResponse self = new GetSceneGroupTemplateMessageOpenStatusResponse();
        return TeaModel.build(map, self);
    }

    public GetSceneGroupTemplateMessageOpenStatusResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public GetSceneGroupTemplateMessageOpenStatusResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public GetSceneGroupTemplateMessageOpenStatusResponse setBody(GetSceneGroupTemplateMessageOpenStatusResponseBody body) {
        this.body = body;
        return this;
    }
    public GetSceneGroupTemplateMessageOpenStatusResponseBody getBody() {
        return this.body;
    }

}
