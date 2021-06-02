// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkjzcrm_1_0.models;

import com.aliyun.tea.*;

public class EditGoodsResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
    public EditGoodsResponseBody body;

    public static EditGoodsResponse build(java.util.Map<String, ?> map) throws Exception {
        EditGoodsResponse self = new EditGoodsResponse();
        return TeaModel.build(map, self);
    }

    public EditGoodsResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public EditGoodsResponse setBody(EditGoodsResponseBody body) {
        this.body = body;
        return this;
    }
    public EditGoodsResponseBody getBody() {
        return this.body;
    }

}
