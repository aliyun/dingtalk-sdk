// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkexclusive_1_0.models;

import com.aliyun.tea.*;

public class FileStorageActiveStorageRequest extends TeaModel {
    // 密匙id
    @NameInMap("accessKeyId")
    public String accessKeyId;

    // 密匙密码
    @NameInMap("accessKeySecret")
    public String accessKeySecret;

    // 带bucket的oss域名
    @NameInMap("oss")
    public String oss;

    // 企业id
    @NameInMap("targetCorpId")
    public String targetCorpId;

    public static FileStorageActiveStorageRequest build(java.util.Map<String, ?> map) throws Exception {
        FileStorageActiveStorageRequest self = new FileStorageActiveStorageRequest();
        return TeaModel.build(map, self);
    }

    public FileStorageActiveStorageRequest setAccessKeyId(String accessKeyId) {
        this.accessKeyId = accessKeyId;
        return this;
    }
    public String getAccessKeyId() {
        return this.accessKeyId;
    }

    public FileStorageActiveStorageRequest setAccessKeySecret(String accessKeySecret) {
        this.accessKeySecret = accessKeySecret;
        return this;
    }
    public String getAccessKeySecret() {
        return this.accessKeySecret;
    }

    public FileStorageActiveStorageRequest setOss(String oss) {
        this.oss = oss;
        return this;
    }
    public String getOss() {
        return this.oss;
    }

    public FileStorageActiveStorageRequest setTargetCorpId(String targetCorpId) {
        this.targetCorpId = targetCorpId;
        return this;
    }
    public String getTargetCorpId() {
        return this.targetCorpId;
    }

}
