// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkyida_1_0.models;

import com.aliyun.tea.*;

public class RenewApplicationAuthorizationServiceOrderRequest extends TeaModel {
    @NameInMap("accessKey")
    public String accessKey;

    @NameInMap("callerUnionId")
    public String callerUnionId;

    @NameInMap("endTimeGMT")
    public Long endTimeGMT;

    @NameInMap("instanceId")
    public String instanceId;

    public static RenewApplicationAuthorizationServiceOrderRequest build(java.util.Map<String, ?> map) throws Exception {
        RenewApplicationAuthorizationServiceOrderRequest self = new RenewApplicationAuthorizationServiceOrderRequest();
        return TeaModel.build(map, self);
    }

    public RenewApplicationAuthorizationServiceOrderRequest setAccessKey(String accessKey) {
        this.accessKey = accessKey;
        return this;
    }
    public String getAccessKey() {
        return this.accessKey;
    }

    public RenewApplicationAuthorizationServiceOrderRequest setCallerUnionId(String callerUnionId) {
        this.callerUnionId = callerUnionId;
        return this;
    }
    public String getCallerUnionId() {
        return this.callerUnionId;
    }

    public RenewApplicationAuthorizationServiceOrderRequest setEndTimeGMT(Long endTimeGMT) {
        this.endTimeGMT = endTimeGMT;
        return this;
    }
    public Long getEndTimeGMT() {
        return this.endTimeGMT;
    }

    public RenewApplicationAuthorizationServiceOrderRequest setInstanceId(String instanceId) {
        this.instanceId = instanceId;
        return this;
    }
    public String getInstanceId() {
        return this.instanceId;
    }

}
