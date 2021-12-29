// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdevicemng_1_0.models;

import com.aliyun.tea.*;

public class CreateChatRoomResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
    public CreateChatRoomResponseBody body;

    public static CreateChatRoomResponse build(java.util.Map<String, ?> map) throws Exception {
        CreateChatRoomResponse self = new CreateChatRoomResponse();
        return TeaModel.build(map, self);
    }

    public CreateChatRoomResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public CreateChatRoomResponse setBody(CreateChatRoomResponseBody body) {
        this.body = body;
        return this;
    }
    public CreateChatRoomResponseBody getBody() {
        return this.body;
    }

}
