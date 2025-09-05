// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdoc_1_0.models;

import com.aliyun.tea.*;

public class DeliverUnifyCardResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public DeliverUnifyCardResponseBody body;

    public static DeliverUnifyCardResponse build(java.util.Map<String, ?> map) throws Exception {
        DeliverUnifyCardResponse self = new DeliverUnifyCardResponse();
        return TeaModel.build(map, self);
    }

    public DeliverUnifyCardResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public DeliverUnifyCardResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public DeliverUnifyCardResponse setBody(DeliverUnifyCardResponseBody body) {
        this.body = body;
        return this;
    }
    public DeliverUnifyCardResponseBody getBody() {
        return this.body;
    }

}
