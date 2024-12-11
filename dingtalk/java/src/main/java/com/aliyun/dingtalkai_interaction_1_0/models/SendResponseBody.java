// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkai_interaction_1_0.models;

import com.aliyun.tea.*;

public class SendResponseBody extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("success")
    public Boolean success;

    public static SendResponseBody build(java.util.Map<String, ?> map) throws Exception {
        SendResponseBody self = new SendResponseBody();
        return TeaModel.build(map, self);
    }

    public SendResponseBody setSuccess(Boolean success) {
        this.success = success;
        return this;
    }
    public Boolean getSuccess() {
        return this.success;
    }

}
