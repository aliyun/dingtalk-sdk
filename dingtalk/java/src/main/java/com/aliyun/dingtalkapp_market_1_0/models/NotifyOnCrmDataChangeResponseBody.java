// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkapp_market_1_0.models;

import com.aliyun.tea.*;

public class NotifyOnCrmDataChangeResponseBody extends TeaModel {
    @NameInMap("success")
    public Boolean success;

    public static NotifyOnCrmDataChangeResponseBody build(java.util.Map<String, ?> map) throws Exception {
        NotifyOnCrmDataChangeResponseBody self = new NotifyOnCrmDataChangeResponseBody();
        return TeaModel.build(map, self);
    }

    public NotifyOnCrmDataChangeResponseBody setSuccess(Boolean success) {
        this.success = success;
        return this;
    }
    public Boolean getSuccess() {
        return this.success;
    }

}
