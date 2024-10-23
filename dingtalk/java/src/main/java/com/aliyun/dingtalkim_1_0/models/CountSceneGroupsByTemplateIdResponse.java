// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkim_1_0.models;

import com.aliyun.tea.*;

public class CountSceneGroupsByTemplateIdResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public CountSceneGroupsByTemplateIdResponseBody body;

    public static CountSceneGroupsByTemplateIdResponse build(java.util.Map<String, ?> map) throws Exception {
        CountSceneGroupsByTemplateIdResponse self = new CountSceneGroupsByTemplateIdResponse();
        return TeaModel.build(map, self);
    }

    public CountSceneGroupsByTemplateIdResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public CountSceneGroupsByTemplateIdResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public CountSceneGroupsByTemplateIdResponse setBody(CountSceneGroupsByTemplateIdResponseBody body) {
        this.body = body;
        return this;
    }
    public CountSceneGroupsByTemplateIdResponseBody getBody() {
        return this.body;
    }

}
