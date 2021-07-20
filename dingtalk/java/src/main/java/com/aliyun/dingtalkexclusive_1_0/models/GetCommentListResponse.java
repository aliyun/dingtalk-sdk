// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkexclusive_1_0.models;

import com.aliyun.tea.*;

public class GetCommentListResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
    public GetCommentListResponseBody body;

    public static GetCommentListResponse build(java.util.Map<String, ?> map) throws Exception {
        GetCommentListResponse self = new GetCommentListResponse();
        return TeaModel.build(map, self);
    }

    public GetCommentListResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public GetCommentListResponse setBody(GetCommentListResponseBody body) {
        this.body = body;
        return this;
    }
    public GetCommentListResponseBody getBody() {
        return this.body;
    }

}
