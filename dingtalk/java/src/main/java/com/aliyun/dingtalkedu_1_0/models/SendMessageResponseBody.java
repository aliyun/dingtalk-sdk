// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkedu_1_0.models;

import com.aliyun.tea.*;

public class SendMessageResponseBody extends TeaModel {
    @NameInMap("successInfo")
    public String successInfo;

    public static SendMessageResponseBody build(java.util.Map<String, ?> map) throws Exception {
        SendMessageResponseBody self = new SendMessageResponseBody();
        return TeaModel.build(map, self);
    }

    public SendMessageResponseBody setSuccessInfo(String successInfo) {
        this.successInfo = successInfo;
        return this;
    }
    public String getSuccessInfo() {
        return this.successInfo;
    }

}
