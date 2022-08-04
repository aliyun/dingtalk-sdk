// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdevicemng_1_0.models;

import com.aliyun.tea.*;

public class ConnectorEventPushResponseBody extends TeaModel {
    @NameInMap("success")
    public Boolean success;

    public static ConnectorEventPushResponseBody build(java.util.Map<String, ?> map) throws Exception {
        ConnectorEventPushResponseBody self = new ConnectorEventPushResponseBody();
        return TeaModel.build(map, self);
    }

    public ConnectorEventPushResponseBody setSuccess(Boolean success) {
        this.success = success;
        return this;
    }
    public Boolean getSuccess() {
        return this.success;
    }

}
