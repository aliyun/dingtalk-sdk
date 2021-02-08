// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkim_1_0.models;

import com.aliyun.tea.*;

public class SendInteractiveCardResponseBody extends TeaModel {
    // 结果
    @NameInMap("success")
    public Boolean success;

    public static SendInteractiveCardResponseBody build(java.util.Map<String, ?> map) throws Exception {
        SendInteractiveCardResponseBody self = new SendInteractiveCardResponseBody();
        return TeaModel.build(map, self);
    }

    public SendInteractiveCardResponseBody setSuccess(Boolean success) {
        this.success = success;
        return this;
    }
    public Boolean getSuccess() {
        return this.success;
    }

}
