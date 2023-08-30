// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkflashmsg_1_0.models;

import com.aliyun.tea.*;

public class SendDingTipResponseBody extends TeaModel {
    @NameInMap("success")
    public Boolean success;

    public static SendDingTipResponseBody build(java.util.Map<String, ?> map) throws Exception {
        SendDingTipResponseBody self = new SendDingTipResponseBody();
        return TeaModel.build(map, self);
    }

    public SendDingTipResponseBody setSuccess(Boolean success) {
        this.success = success;
        return this;
    }
    public Boolean getSuccess() {
        return this.success;
    }

}
