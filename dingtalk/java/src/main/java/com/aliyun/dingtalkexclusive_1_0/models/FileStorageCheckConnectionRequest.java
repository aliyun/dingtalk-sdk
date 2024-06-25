// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkexclusive_1_0.models;

import com.aliyun.tea.*;

public class FileStorageCheckConnectionRequest extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>sampleKeyId1234</p>
     */
    @NameInMap("accessKeyId")
    public String accessKeyId;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>sampleSecretId1234</p>
     */
    @NameInMap("accessKeySecret")
    public String accessKeySecret;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p><a href="https://oss.aliyuncs.com/bucket-name/">https://oss.aliyuncs.com/bucket-name/</a></p>
     */
    @NameInMap("oss")
    public String oss;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>dingxxxxxxxxxxxx</p>
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
