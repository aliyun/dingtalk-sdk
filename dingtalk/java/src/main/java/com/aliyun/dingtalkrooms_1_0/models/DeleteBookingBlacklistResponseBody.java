// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkrooms_1_0.models;

import com.aliyun.tea.*;

public class DeleteBookingBlacklistResponseBody extends TeaModel {
    @NameInMap("result")
    public Boolean result;

    public static DeleteBookingBlacklistResponseBody build(java.util.Map<String, ?> map) throws Exception {
        DeleteBookingBlacklistResponseBody self = new DeleteBookingBlacklistResponseBody();
        return TeaModel.build(map, self);
    }

    public DeleteBookingBlacklistResponseBody setResult(Boolean result) {
        this.result = result;
        return this;
    }
    public Boolean getResult() {
        return this.result;
    }

}
