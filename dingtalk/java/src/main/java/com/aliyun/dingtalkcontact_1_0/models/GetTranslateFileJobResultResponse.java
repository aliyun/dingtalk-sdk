// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcontact_1_0.models;

import com.aliyun.tea.*;

public class GetTranslateFileJobResultResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
    public GetTranslateFileJobResultResponseBody body;

    public static GetTranslateFileJobResultResponse build(java.util.Map<String, ?> map) throws Exception {
        GetTranslateFileJobResultResponse self = new GetTranslateFileJobResultResponse();
        return TeaModel.build(map, self);
    }

    public GetTranslateFileJobResultResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public GetTranslateFileJobResultResponse setBody(GetTranslateFileJobResultResponseBody body) {
        this.body = body;
        return this;
    }
    public GetTranslateFileJobResultResponseBody getBody() {
        return this.body;
    }

}
