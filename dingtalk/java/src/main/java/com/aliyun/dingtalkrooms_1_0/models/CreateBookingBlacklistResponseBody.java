// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkrooms_1_0.models;

import com.aliyun.tea.*;

public class CreateBookingBlacklistResponseBody extends TeaModel {
    @NameInMap("result")
    public Boolean result;

    public static CreateBookingBlacklistResponseBody build(java.util.Map<String, ?> map) throws Exception {
        CreateBookingBlacklistResponseBody self = new CreateBookingBlacklistResponseBody();
        return TeaModel.build(map, self);
    }

    public CreateBookingBlacklistResponseBody setResult(Boolean result) {
        this.result = result;
        return this;
    }
    public Boolean getResult() {
        return this.result;
    }

}
