// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkyida_1_0.models;

import com.aliyun.tea.*;

public class GetApplicationAuthorizationServicePlatformResourceRequest extends TeaModel {
    @NameInMap("accessKey")
    public String accessKey;

    @NameInMap("callerUid")
    public String callerUid;

    @NameInMap("instanceId")
    public String instanceId;

    public static GetApplicationAuthorizationServicePlatformResourceRequest build(java.util.Map<String, ?> map) throws Exception {
        GetApplicationAuthorizationServicePlatformResourceRequest self = new GetApplicationAuthorizationServicePlatformResourceRequest();
        return TeaModel.build(map, self);
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

    public GetApplicationAuthorizationServicePlatformResourceRequest setInstanceId(String instanceId) {
        this.instanceId = instanceId;
        return this;
    }
    public String getInstanceId() {
        return this.instanceId;
    }

}
