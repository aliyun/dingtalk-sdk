// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcrm_1_0.models;

import com.aliyun.tea.*;

public class GetCrmGroupChatSingleResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
    public GetCrmGroupChatSingleResponseBody body;

    public static GetCrmGroupChatSingleResponse build(java.util.Map<String, ?> map) throws Exception {
        GetCrmGroupChatSingleResponse self = new GetCrmGroupChatSingleResponse();
        return TeaModel.build(map, self);
    }

    public GetCrmGroupChatSingleResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public GetCrmGroupChatSingleResponse setBody(GetCrmGroupChatSingleResponseBody body) {
        this.body = body;
        return this;
    }
    public GetCrmGroupChatSingleResponseBody getBody() {
        return this.body;
    }

}
