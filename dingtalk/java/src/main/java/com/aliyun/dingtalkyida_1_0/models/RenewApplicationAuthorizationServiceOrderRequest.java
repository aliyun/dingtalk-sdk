// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkyida_1_0.models;

import com.aliyun.tea.*;

public class RenewApplicationAuthorizationServiceOrderRequest extends TeaModel {
    // 实例id
    @NameInMap("instanceId")
    public String instanceId;

    // 访问秘钥
    @NameInMap("accessKey")
    public String accessKey;

    // 调用者unionId
    @NameInMap("callerUnionId")
    public String callerUnionId;

    // 结束时间
    @NameInMap("endTimeGMT")
    public Long endTimeGMT;

    public static RenewApplicationAuthorizationServiceOrderRequest build(java.util.Map<String, ?> map) throws Exception {
        RenewApplicationAuthorizationServiceOrderRequest self = new RenewApplicationAuthorizationServiceOrderRequest();
        return TeaModel.build(map, self);
    }

    public RenewApplicationAuthorizationServiceOrderRequest setInstanceId(String instanceId) {
        this.instanceId = instanceId;
        return this;
    }
    public String getInstanceId() {
        return this.instanceId;
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

}
