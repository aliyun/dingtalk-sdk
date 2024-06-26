// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkexclusive_1_0.models;

import com.aliyun.tea.*;

public class SaveAcrossCloudStroageConfigsRequest extends TeaModel {
    /**
     * <strong>example:</strong>
     * <p>sampleKeyId1234</p>
     */
    @NameInMap("accessKeyId")
    public String accessKeyId;

    /**
     * <strong>example:</strong>
     * <p>sampleSecretId1234</p>
     */
    @NameInMap("accessKeySecret")
    public String accessKeySecret;

    /**
     * <strong>example:</strong>
     * <p>xxxxbucket</p>
     */
    @NameInMap("bucketName")
    public String bucketName;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>1</p>
     */
    @NameInMap("cloudType")
    public Integer cloudType;

    /**
     * <strong>example:</strong>
     * <p><a href="https://oss-cn-test.aliyuncs.com">https://oss-cn-test.aliyuncs.com</a></p>
     */
    @NameInMap("endpoint")
    public String endpoint;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>dingxxxxxxxxxxxx</p>
     */
    @NameInMap("targetCorpId")
    public String targetCorpId;

    public static SaveAcrossCloudStroageConfigsRequest build(java.util.Map<String, ?> map) throws Exception {
        SaveAcrossCloudStroageConfigsRequest self = new SaveAcrossCloudStroageConfigsRequest();
        return TeaModel.build(map, self);
    }

    public SaveAcrossCloudStroageConfigsRequest setAccessKeyId(String accessKeyId) {
        this.accessKeyId = accessKeyId;
        return this;
    }
    public String getAccessKeyId() {
        return this.accessKeyId;
    }

    public SaveAcrossCloudStroageConfigsRequest setAccessKeySecret(String accessKeySecret) {
        this.accessKeySecret = accessKeySecret;
        return this;
    }
    public String getAccessKeySecret() {
        return this.accessKeySecret;
    }

    public SaveAcrossCloudStroageConfigsRequest setBucketName(String bucketName) {
        this.bucketName = bucketName;
        return this;
    }
    public String getBucketName() {
        return this.bucketName;
    }

    public SaveAcrossCloudStroageConfigsRequest setCloudType(Integer cloudType) {
        this.cloudType = cloudType;
        return this;
    }
    public Integer getCloudType() {
        return this.cloudType;
    }

    public SaveAcrossCloudStroageConfigsRequest setEndpoint(String endpoint) {
        this.endpoint = endpoint;
        return this;
    }
    public String getEndpoint() {
        return this.endpoint;
    }

    public SaveAcrossCloudStroageConfigsRequest setTargetCorpId(String targetCorpId) {
        this.targetCorpId = targetCorpId;
        return this;
    }
    public String getTargetCorpId() {
        return this.targetCorpId;
    }

}
