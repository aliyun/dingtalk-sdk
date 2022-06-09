// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkindustry_1_0.models;

import com.aliyun.tea.*;

public class IndustryManufactureCommonEventResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
    public IndustryManufactureCommonEventResponseBody body;

    public static IndustryManufactureCommonEventResponse build(java.util.Map<String, ?> map) throws Exception {
        IndustryManufactureCommonEventResponse self = new IndustryManufactureCommonEventResponse();
        return TeaModel.build(map, self);
    }

    public IndustryManufactureCommonEventResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public IndustryManufactureCommonEventResponse setBody(IndustryManufactureCommonEventResponseBody body) {
        this.body = body;
        return this;
    }
    public IndustryManufactureCommonEventResponseBody getBody() {
        return this.body;
    }

}
