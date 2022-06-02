// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkservice_group_1_0.models;

import com.aliyun.tea.*;

public class GetInstancesByIdsResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
    public GetInstancesByIdsResponseBody body;

    public static GetInstancesByIdsResponse build(java.util.Map<String, ?> map) throws Exception {
        GetInstancesByIdsResponse self = new GetInstancesByIdsResponse();
        return TeaModel.build(map, self);
    }

    public GetInstancesByIdsResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public GetInstancesByIdsResponse setBody(GetInstancesByIdsResponseBody body) {
        this.body = body;
        return this;
    }
    public GetInstancesByIdsResponseBody getBody() {
        return this.body;
    }

}
