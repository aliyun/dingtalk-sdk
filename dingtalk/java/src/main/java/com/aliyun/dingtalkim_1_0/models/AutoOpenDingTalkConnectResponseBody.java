// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkim_1_0.models;

import com.aliyun.tea.*;

public class AutoOpenDingTalkConnectResponseBody extends TeaModel {
    @NameInMap("message")
    public String message;

    public static AutoOpenDingTalkConnectResponseBody build(java.util.Map<String, ?> map) throws Exception {
        AutoOpenDingTalkConnectResponseBody self = new AutoOpenDingTalkConnectResponseBody();
        return TeaModel.build(map, self);
    }

    public AutoOpenDingTalkConnectResponseBody setMessage(String message) {
        this.message = message;
        return this;
    }
    public String getMessage() {
        return this.message;
    }

}
