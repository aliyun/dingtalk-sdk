// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkexclusive_1_0.models;

import com.aliyun.tea.*;

public class FileStorageUpdateStorageRequest extends TeaModel {
    // 密匙id
    @NameInMap("accessKeyId")
    public String accessKeyId;

    // 密匙密码
    @NameInMap("accessKeySecret")
    public String accessKeySecret;

    // 企业id
    @NameInMap("targetCorpId")
    public String targetCorpId;

    public static FileStorageUpdateStorageRequest build(java.util.Map<String, ?> map) throws Exception {
        FileStorageUpdateStorageRequest self = new FileStorageUpdateStorageRequest();
        return TeaModel.build(map, self);
    }

    public FileStorageUpdateStorageRequest setAccessKeyId(String accessKeyId) {
        this.accessKeyId = accessKeyId;
        return this;
    }
    public String getAccessKeyId() {
        return this.accessKeyId;
    }

    public FileStorageUpdateStorageRequest setAccessKeySecret(String accessKeySecret) {
        this.accessKeySecret = accessKeySecret;
        return this;
    }
    public String getAccessKeySecret() {
        return this.accessKeySecret;
    }

    public FileStorageUpdateStorageRequest setTargetCorpId(String targetCorpId) {
        this.targetCorpId = targetCorpId;
        return this;
    }
    public String getTargetCorpId() {
        return this.targetCorpId;
    }

}
