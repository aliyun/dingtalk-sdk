// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkedu_1_0.models;

import com.aliyun.tea.*;

public class SendMessageResponseBody extends TeaModel {
    // 成功信息
    @NameInMap("successInfo")
    public Boolean successInfo;

    public static SendMessageResponseBody build(java.util.Map<String, ?> map) throws Exception {
        SendMessageResponseBody self = new SendMessageResponseBody();
        return TeaModel.build(map, self);
    }

    public SendMessageResponseBody setSuccessInfo(Boolean successInfo) {
        this.successInfo = successInfo;
        return this;
    }
    public Boolean getSuccessInfo() {
        return this.successInfo;
    }

}
