// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkh3yun_1_0.models;

import com.aliyun.tea.*;

public class LoadBizFieldsResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
    public LoadBizFieldsResponseBody body;

    public static LoadBizFieldsResponse build(java.util.Map<String, ?> map) throws Exception {
        LoadBizFieldsResponse self = new LoadBizFieldsResponse();
        return TeaModel.build(map, self);
    }

    public LoadBizFieldsResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public LoadBizFieldsResponse setBody(LoadBizFieldsResponseBody body) {
        this.body = body;
        return this;
    }
    public LoadBizFieldsResponseBody getBody() {
        return this.body;
    }

}
