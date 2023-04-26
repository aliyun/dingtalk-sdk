// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkyida_1_0.models;

import com.aliyun.tea.*;

public class TerminateCloudAuthorizationRequest extends TeaModel {
    @NameInMap("accessKey")
    public String accessKey;

    @NameInMap("callerUnionId")
    public String callerUnionId;

    @NameInMap("instanceId")
    public String instanceId;

    public static TerminateCloudAuthorizationRequest build(java.util.Map<String, ?> map) throws Exception {
        TerminateCloudAuthorizationRequest self = new TerminateCloudAuthorizationRequest();
        return TeaModel.build(map, self);
    }

    public TerminateCloudAuthorizationRequest setAccessKey(String accessKey) {
        this.accessKey = accessKey;
        return this;
    }
    public String getAccessKey() {
        return this.accessKey;
    }

    public TerminateCloudAuthorizationRequest setCallerUnionId(String callerUnionId) {
        this.callerUnionId = callerUnionId;
        return this;
    }
    public String getCallerUnionId() {
        return this.callerUnionId;
    }

    public TerminateCloudAuthorizationRequest setInstanceId(String instanceId) {
        this.instanceId = instanceId;
        return this;
    }
    public String getInstanceId() {
        return this.instanceId;
    }

}
