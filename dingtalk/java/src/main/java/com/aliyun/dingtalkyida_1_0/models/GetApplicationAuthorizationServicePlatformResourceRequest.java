// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkyida_1_0.models;

import com.aliyun.tea.*;

public class GetApplicationAuthorizationServicePlatformResourceRequest extends TeaModel {
    @NameInMap("instanceId")
    public String instanceId;

    @NameInMap("accessKey")
    public String accessKey;

    @NameInMap("callerUid")
    public String callerUid;

    public static GetApplicationAuthorizationServicePlatformResourceRequest build(java.util.Map<String, ?> map) throws Exception {
        GetApplicationAuthorizationServicePlatformResourceRequest self = new GetApplicationAuthorizationServicePlatformResourceRequest();
        return TeaModel.build(map, self);
    }

    public GetApplicationAuthorizationServicePlatformResourceRequest setInstanceId(String instanceId) {
        this.instanceId = instanceId;
        return this;
    }
    public String getInstanceId() {
        return this.instanceId;
    }

    public GetApplicationAuthorizationServicePlatformResourceRequest setAccessKey(String accessKey) {
        this.accessKey = accessKey;
        return this;
    }
    public String getAccessKey() {
        return this.accessKey;
    }

    public GetApplicationAuthorizationServicePlatformResourceRequest setCallerUid(String callerUid) {
        this.callerUid = callerUid;
        return this;
    }
    public String getCallerUid() {
        return this.callerUid;
    }

}
