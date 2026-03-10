// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalktrip_1_0.models;

import com.aliyun.tea.*;

public class SubmitTripApprovalProcessResponseBody extends TeaModel {
    @NameInMap("instanceId")
    public String instanceId;

    public static SubmitTripApprovalProcessResponseBody build(java.util.Map<String, ?> map) throws Exception {
        SubmitTripApprovalProcessResponseBody self = new SubmitTripApprovalProcessResponseBody();
        return TeaModel.build(map, self);
    }

    public SubmitTripApprovalProcessResponseBody setInstanceId(String instanceId) {
        this.instanceId = instanceId;
        return this;
    }
    public String getInstanceId() {
        return this.instanceId;
    }

}
