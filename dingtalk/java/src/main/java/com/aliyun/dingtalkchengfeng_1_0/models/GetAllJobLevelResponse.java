// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkchengfeng_1_0.models;

import com.aliyun.tea.*;

public class GetAllJobLevelResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
    public GetAllJobLevelResponseBody body;

    public static GetAllJobLevelResponse build(java.util.Map<String, ?> map) throws Exception {
        GetAllJobLevelResponse self = new GetAllJobLevelResponse();
        return TeaModel.build(map, self);
    }

    public GetAllJobLevelResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public GetAllJobLevelResponse setBody(GetAllJobLevelResponseBody body) {
        this.body = body;
        return this;
    }
    public GetAllJobLevelResponseBody getBody() {
        return this.body;
    }

}
