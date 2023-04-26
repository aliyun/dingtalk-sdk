// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkyida_1_0.models;

import com.aliyun.tea.*;

public class RenewTenantOrderRequest extends TeaModel {
    @NameInMap("accessKey")
    public String accessKey;

    @NameInMap("callerUnionId")
    public String callerUnionId;

    @NameInMap("endTimeGMT")
    public Long endTimeGMT;

    public static RenewTenantOrderRequest build(java.util.Map<String, ?> map) throws Exception {
        RenewTenantOrderRequest self = new RenewTenantOrderRequest();
        return TeaModel.build(map, self);
    }

    public RenewTenantOrderRequest setAccessKey(String accessKey) {
        this.accessKey = accessKey;
        return this;
    }
    public String getAccessKey() {
        return this.accessKey;
    }

    public RenewTenantOrderRequest setCallerUnionId(String callerUnionId) {
        this.callerUnionId = callerUnionId;
        return this;
    }
    public String getCallerUnionId() {
        return this.callerUnionId;
    }

    public RenewTenantOrderRequest setEndTimeGMT(Long endTimeGMT) {
        this.endTimeGMT = endTimeGMT;
        return this;
    }
    public Long getEndTimeGMT() {
        return this.endTimeGMT;
    }

}
