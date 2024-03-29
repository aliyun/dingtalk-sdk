// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkoauth2_1_0.models;

import com.aliyun.tea.*;

public class CreateJsapiTicketResponseBody extends TeaModel {
    @NameInMap("expireIn")
    public Long expireIn;

    @NameInMap("jsapiTicket")
    public String jsapiTicket;

    public static CreateJsapiTicketResponseBody build(java.util.Map<String, ?> map) throws Exception {
        CreateJsapiTicketResponseBody self = new CreateJsapiTicketResponseBody();
        return TeaModel.build(map, self);
    }

    public CreateJsapiTicketResponseBody setExpireIn(Long expireIn) {
        this.expireIn = expireIn;
        return this;
    }
    public Long getExpireIn() {
        return this.expireIn;
    }

    public CreateJsapiTicketResponseBody setJsapiTicket(String jsapiTicket) {
        this.jsapiTicket = jsapiTicket;
        return this;
    }
    public String getJsapiTicket() {
        return this.jsapiTicket;
    }

}
