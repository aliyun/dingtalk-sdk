// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkindustry_1_0.models;

import com.aliyun.tea.*;

public class CampusDeleteRenterResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    public static CampusDeleteRenterResponse build(java.util.Map<String, ?> map) throws Exception {
        CampusDeleteRenterResponse self = new CampusDeleteRenterResponse();
        return TeaModel.build(map, self);
    }

    public CampusDeleteRenterResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

}
