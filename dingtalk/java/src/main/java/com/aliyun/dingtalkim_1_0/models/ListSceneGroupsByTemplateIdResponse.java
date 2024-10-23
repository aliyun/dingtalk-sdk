// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkim_1_0.models;

import com.aliyun.tea.*;

public class ListSceneGroupsByTemplateIdResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public ListSceneGroupsByTemplateIdResponseBody body;

    public static ListSceneGroupsByTemplateIdResponse build(java.util.Map<String, ?> map) throws Exception {
        ListSceneGroupsByTemplateIdResponse self = new ListSceneGroupsByTemplateIdResponse();
        return TeaModel.build(map, self);
    }

    public ListSceneGroupsByTemplateIdResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public ListSceneGroupsByTemplateIdResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public ListSceneGroupsByTemplateIdResponse setBody(ListSceneGroupsByTemplateIdResponseBody body) {
        this.body = body;
        return this;
    }
    public ListSceneGroupsByTemplateIdResponseBody getBody() {
        return this.body;
    }

}
