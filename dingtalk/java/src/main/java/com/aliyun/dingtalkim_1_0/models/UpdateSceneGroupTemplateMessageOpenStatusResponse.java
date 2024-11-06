// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkim_1_0.models;

import com.aliyun.tea.*;

public class UpdateSceneGroupTemplateMessageOpenStatusResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public UpdateSceneGroupTemplateMessageOpenStatusResponseBody body;

    public static UpdateSceneGroupTemplateMessageOpenStatusResponse build(java.util.Map<String, ?> map) throws Exception {
        UpdateSceneGroupTemplateMessageOpenStatusResponse self = new UpdateSceneGroupTemplateMessageOpenStatusResponse();
        return TeaModel.build(map, self);
    }

    public UpdateSceneGroupTemplateMessageOpenStatusResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public UpdateSceneGroupTemplateMessageOpenStatusResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public UpdateSceneGroupTemplateMessageOpenStatusResponse setBody(UpdateSceneGroupTemplateMessageOpenStatusResponseBody body) {
        this.body = body;
        return this;
    }
    public UpdateSceneGroupTemplateMessageOpenStatusResponseBody getBody() {
        return this.body;
    }

}
