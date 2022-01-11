// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkservice_group_1_0.models;

import com.aliyun.tea.*;

public class GetStoragePolicyResponseBody extends TeaModel {
    @NameInMap("accessKeyId")
    public String accessKeyId;

    @NameInMap("endpoint")
    public String endpoint;

    // Id of the request
    @NameInMap("key")
    public String key;

    @NameInMap("policy")
    public String policy;

    @NameInMap("signature")
    public String signature;

    public static GetStoragePolicyResponseBody build(java.util.Map<String, ?> map) throws Exception {
        GetStoragePolicyResponseBody self = new GetStoragePolicyResponseBody();
        return TeaModel.build(map, self);
    }

    public GetStoragePolicyResponseBody setAccessKeyId(String accessKeyId) {
        this.accessKeyId = accessKeyId;
        return this;
    }
    public String getAccessKeyId() {
        return this.accessKeyId;
    }

    public GetStoragePolicyResponseBody setEndpoint(String endpoint) {
        this.endpoint = endpoint;
        return this;
    }
    public String getEndpoint() {
        return this.endpoint;
    }

    public GetStoragePolicyResponseBody setKey(String key) {
        this.key = key;
        return this;
    }
    public String getKey() {
        return this.key;
    }

    public GetStoragePolicyResponseBody setPolicy(String policy) {
        this.policy = policy;
        return this;
    }
    public String getPolicy() {
        return this.policy;
    }

    public GetStoragePolicyResponseBody setSignature(String signature) {
        this.signature = signature;
        return this;
    }
    public String getSignature() {
        return this.signature;
    }

}
