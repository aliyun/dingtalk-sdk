// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkexclusive_1_0.models;

import com.aliyun.tea.*;

public class FileStorageCheckConnectionRequest extends TeaModel {
    /**
     * <p>密匙id</p>
     */
    @NameInMap("accessKeyId")
    public String accessKeyId;

    /**
     * <p>密匙密码</p>
     */
    @NameInMap("accessKeySecret")
    public String accessKeySecret;

    /**
     * <p>带bucket的oss域名</p>
     */
    @NameInMap("oss")
    public String oss;

    /**
     * <p>企业id</p>
     */
    @NameInMap("targetCorpId")
    public String targetCorpId;

    public static FileStorageCheckConnectionRequest build(java.util.Map<String, ?> map) throws Exception {
        FileStorageCheckConnectionRequest self = new FileStorageCheckConnectionRequest();
        return TeaModel.build(map, self);
    }

    public FileStorageCheckConnectionRequest setAccessKeyId(String accessKeyId) {
        this.accessKeyId = accessKeyId;
        return this;
    }
    public String getAccessKeyId() {
        return this.accessKeyId;
    }

    public FileStorageCheckConnectionRequest setAccessKeySecret(String accessKeySecret) {
        this.accessKeySecret = accessKeySecret;
        return this;
    }
    public String getAccessKeySecret() {
        return this.accessKeySecret;
    }

    public FileStorageCheckConnectionRequest setOss(String oss) {
        this.oss = oss;
        return this;
    }
    public String getOss() {
        return this.oss;
    }

    public FileStorageCheckConnectionRequest setTargetCorpId(String targetCorpId) {
        this.targetCorpId = targetCorpId;
        return this;
    }
    public String getTargetCorpId() {
        return this.targetCorpId;
    }

}
