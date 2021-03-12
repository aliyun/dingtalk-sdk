// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalklive_1_0.models;

import com.aliyun.tea.*;

public class AddShareCidListResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
    public AddShareCidListResponseBody body;

    public static AddShareCidListResponse build(java.util.Map<String, ?> map) throws Exception {
        AddShareCidListResponse self = new AddShareCidListResponse();
        return TeaModel.build(map, self);
    }

    public AddShareCidListResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public AddShareCidListResponse setBody(AddShareCidListResponseBody body) {
        this.body = body;
        return this;
    }
    public AddShareCidListResponseBody getBody() {
        return this.body;
    }

}
