// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkbadge_1_0.models;

import com.aliyun.tea.*;

public class NotifyBadgeCodeVerifyResultResponseBody extends TeaModel {
    // 结果
    @NameInMap("result")
    public String result;

    public static NotifyBadgeCodeVerifyResultResponseBody build(java.util.Map<String, ?> map) throws Exception {
        NotifyBadgeCodeVerifyResultResponseBody self = new NotifyBadgeCodeVerifyResultResponseBody();
        return TeaModel.build(map, self);
    }

    public NotifyBadgeCodeVerifyResultResponseBody setResult(String result) {
        this.result = result;
        return this;
    }
    public String getResult() {
        return this.result;
    }

}
