// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkbadge_1_0.models;

import com.aliyun.tea.*;

public class NotifyBadgeCodeRefundResultResponseBody extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>SUCCESS</p>
     */
    @NameInMap("result")
    public String result;

    public static NotifyBadgeCodeRefundResultResponseBody build(java.util.Map<String, ?> map) throws Exception {
        NotifyBadgeCodeRefundResultResponseBody self = new NotifyBadgeCodeRefundResultResponseBody();
        return TeaModel.build(map, self);
    }

    public NotifyBadgeCodeRefundResultResponseBody setResult(String result) {
        this.result = result;
        return this;
    }
    public String getResult() {
        return this.result;
    }

}
