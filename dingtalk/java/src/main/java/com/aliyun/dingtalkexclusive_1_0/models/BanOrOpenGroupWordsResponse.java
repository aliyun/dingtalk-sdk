// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkexclusive_1_0.models;

import com.aliyun.tea.*;

public class BanOrOpenGroupWordsResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
    public BanOrOpenGroupWordsResponseBody body;

    public static BanOrOpenGroupWordsResponse build(java.util.Map<String, ?> map) throws Exception {
        BanOrOpenGroupWordsResponse self = new BanOrOpenGroupWordsResponse();
        return TeaModel.build(map, self);
    }

    public BanOrOpenGroupWordsResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public BanOrOpenGroupWordsResponse setBody(BanOrOpenGroupWordsResponseBody body) {
        this.body = body;
        return this;
    }
    public BanOrOpenGroupWordsResponseBody getBody() {
        return this.body;
    }

}
