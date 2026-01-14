// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkim_1_0.models;

import com.aliyun.tea.*;

public class RecallMessagesResponseBody extends TeaModel {
    @NameInMap("success")
    public String success;

    public static RecallMessagesResponseBody build(java.util.Map<String, ?> map) throws Exception {
        RecallMessagesResponseBody self = new RecallMessagesResponseBody();
        return TeaModel.build(map, self);
    }

    public RecallMessagesResponseBody setSuccess(String success) {
        this.success = success;
        return this;
    }
    public String getSuccess() {
        return this.success;
    }

}
