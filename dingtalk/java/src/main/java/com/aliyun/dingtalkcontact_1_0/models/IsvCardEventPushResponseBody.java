// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcontact_1_0.models;

import com.aliyun.tea.*;

public class IsvCardEventPushResponseBody extends TeaModel {
    // 执行结果
    @NameInMap("success")
    public Boolean success;

    public static IsvCardEventPushResponseBody build(java.util.Map<String, ?> map) throws Exception {
        IsvCardEventPushResponseBody self = new IsvCardEventPushResponseBody();
        return TeaModel.build(map, self);
    }

    public IsvCardEventPushResponseBody setSuccess(Boolean success) {
        this.success = success;
        return this;
    }
    public Boolean getSuccess() {
        return this.success;
    }

}
