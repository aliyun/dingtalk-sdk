// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkapp_market_1_0.models;

import com.aliyun.tea.*;

public class GetCoolAppAccessStatusResponseBody extends TeaModel {
    @NameInMap("status")
    public String status;

    public static GetCoolAppAccessStatusResponseBody build(java.util.Map<String, ?> map) throws Exception {
        GetCoolAppAccessStatusResponseBody self = new GetCoolAppAccessStatusResponseBody();
        return TeaModel.build(map, self);
    }

    public GetCoolAppAccessStatusResponseBody setStatus(String status) {
        this.status = status;
        return this;
    }
    public String getStatus() {
        return this.status;
    }

}
