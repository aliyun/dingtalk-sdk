// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkbadge_1_0.models;

import com.aliyun.tea.*;

public class NotifyBadgeCodePayResultResponseBody extends TeaModel {
    // 处理结果
    @NameInMap("result")
    public String result;

    public static NotifyBadgeCodePayResultResponseBody build(java.util.Map<String, ?> map) throws Exception {
        NotifyBadgeCodePayResultResponseBody self = new NotifyBadgeCodePayResultResponseBody();
        return TeaModel.build(map, self);
    }

    public NotifyBadgeCodePayResultResponseBody setResult(String result) {
        this.result = result;
        return this;
    }
    public String getResult() {
        return this.result;
    }

}
