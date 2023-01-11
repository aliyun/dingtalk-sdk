// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkbadge_1_0.models;

import com.aliyun.tea.*;

public class DecodeBadgeCodeRequest extends TeaModel {
    /**
     * <p>码值</p>
     */
    @NameInMap("payCode")
    public String payCode;

    /**
     * <p>请求ID</p>
     */
    @NameInMap("requestId")
    public String requestId;

    public static DecodeBadgeCodeRequest build(java.util.Map<String, ?> map) throws Exception {
        DecodeBadgeCodeRequest self = new DecodeBadgeCodeRequest();
        return TeaModel.build(map, self);
    }

    public DecodeBadgeCodeRequest setPayCode(String payCode) {
        this.payCode = payCode;
        return this;
    }
    public String getPayCode() {
        return this.payCode;
    }

    public DecodeBadgeCodeRequest setRequestId(String requestId) {
        this.requestId = requestId;
        return this;
    }
    public String getRequestId() {
        return this.requestId;
    }

}
