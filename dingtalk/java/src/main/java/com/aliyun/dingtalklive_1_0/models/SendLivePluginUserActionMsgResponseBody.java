// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalklive_1_0.models;

import com.aliyun.tea.*;

public class SendLivePluginUserActionMsgResponseBody extends TeaModel {
    @NameInMap("success")
    public Boolean success;

    public static SendLivePluginUserActionMsgResponseBody build(java.util.Map<String, ?> map) throws Exception {
        SendLivePluginUserActionMsgResponseBody self = new SendLivePluginUserActionMsgResponseBody();
        return TeaModel.build(map, self);
    }

    public SendLivePluginUserActionMsgResponseBody setSuccess(Boolean success) {
        this.success = success;
        return this;
    }
    public Boolean getSuccess() {
        return this.success;
    }

}
