// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkgateway_1_0.models;

import com.aliyun.tea.*;

public class OpenConnectionResponseBody extends TeaModel {
    @NameInMap("endpoint")
    public String endpoint;

    @NameInMap("ticket")
    public String ticket;

    public static OpenConnectionResponseBody build(java.util.Map<String, ?> map) throws Exception {
        OpenConnectionResponseBody self = new OpenConnectionResponseBody();
        return TeaModel.build(map, self);
    }

    public OpenConnectionResponseBody setEndpoint(String endpoint) {
        this.endpoint = endpoint;
        return this;
    }
    public String getEndpoint() {
        return this.endpoint;
    }

    public OpenConnectionResponseBody setTicket(String ticket) {
        this.ticket = ticket;
        return this;
    }
    public String getTicket() {
        return this.ticket;
    }

}
