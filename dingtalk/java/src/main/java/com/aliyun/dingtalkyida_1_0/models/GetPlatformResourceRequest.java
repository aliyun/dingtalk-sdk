// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkyida_1_0.models;

import com.aliyun.tea.*;

public class GetPlatformResourceRequest extends TeaModel {
    @NameInMap("instanceId")
    public String instanceId;

    @NameInMap("accessKey")
    public String accessKey;

    @NameInMap("callerUid")
    public String callerUid;

    public static GetPlatformResourceRequest build(java.util.Map<String, ?> map) throws Exception {
        GetPlatformResourceRequest self = new GetPlatformResourceRequest();
        return TeaModel.build(map, self);
    }

    public GetPlatformResourceRequest setInstanceId(String instanceId) {
        this.instanceId = instanceId;
        return this;
    }
    public String getInstanceId() {
        return this.instanceId;
    }

    public GetPlatformResourceRequest setAccessKey(String accessKey) {
        this.accessKey = accessKey;
        return this;
    }
    public String getAccessKey() {
        return this.accessKey;
    }

    public GetPlatformResourceRequest setCallerUid(String callerUid) {
        this.callerUid = callerUid;
        return this;
    }
    public String getCallerUid() {
        return this.callerUid;
    }

}
