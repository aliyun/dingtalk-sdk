// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkexclusive_1_0.models;

import com.aliyun.tea.*;

public class GetVirusScanResultResponseBody extends TeaModel {
    @NameInMap("reason")
    public String reason;

    @NameInMap("status")
    public Integer status;

    public static GetVirusScanResultResponseBody build(java.util.Map<String, ?> map) throws Exception {
        GetVirusScanResultResponseBody self = new GetVirusScanResultResponseBody();
        return TeaModel.build(map, self);
    }

    public GetVirusScanResultResponseBody setReason(String reason) {
        this.reason = reason;
        return this;
    }
    public String getReason() {
        return this.reason;
    }

    public GetVirusScanResultResponseBody setStatus(Integer status) {
        this.status = status;
        return this;
    }
    public Integer getStatus() {
        return this.status;
    }

}
