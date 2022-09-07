// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkworkflow_1_0.models;

import com.aliyun.tea.*;

public class GetAttachmentSpaceResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
    public GetAttachmentSpaceResponseBody body;

    public static GetAttachmentSpaceResponse build(java.util.Map<String, ?> map) throws Exception {
        GetAttachmentSpaceResponse self = new GetAttachmentSpaceResponse();
        return TeaModel.build(map, self);
    }

    public GetAttachmentSpaceResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public GetAttachmentSpaceResponse setBody(GetAttachmentSpaceResponseBody body) {
        this.body = body;
        return this;
    }
    public GetAttachmentSpaceResponseBody getBody() {
        return this.body;
    }

}
