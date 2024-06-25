// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkpackage_1_0.models;

import com.aliyun.tea.*;

public class GetUploadTokenResponseBody extends TeaModel {
    /**
     * <strong>example:</strong>
     * <p>STS.NUPjgnMhCVWvo1HSxfftf</p>
     */
    @NameInMap("accessKeyId")
    public String accessKeyId;

    /**
     * <strong>example:</strong>
     * <p>ASviryNDy9tTuS5KiYMA6fCYf81vHg4KdoX7CVHz4CSx</p>
     */
    @NameInMap("accessKeySecret")
    public String accessKeySecret;

    /**
     * <strong>example:</strong>
     * <p>dingtalk-bucket</p>
     */
    @NameInMap("bucket")
    public String bucket;

    /**
     * <strong>example:</strong>
     * <p>oss-cn-shanghai.aliyuncs.com</p>
     */
    @NameInMap("endpoint")
    public String endpoint;

    /**
     * <strong>example:</strong>
     * <p>2022-09-21T09:32:16Z</p>
     */
    @NameInMap("expiration")
    public String expiration;

    /**
     * <strong>example:</strong>
     * <p>5000000002761167/1663751835956</p>
     */
    @NameInMap("name")
    public String name;

    /**
     * <strong>example:</strong>
     * <p>oss-cn-shanghai</p>
     */
    @NameInMap("region")
    public String region;

    /**
     * <strong>example:</strong>
     * <p>CAIS0QJ1q6Ft5B2yfSjIr5blId3aoLdi4ZWdbRf5t3gzavt...</p>
     */
    @NameInMap("stsToken")
    public String stsToken;

    public static GetUploadTokenResponseBody build(java.util.Map<String, ?> map) throws Exception {
        GetUploadTokenResponseBody self = new GetUploadTokenResponseBody();
        return TeaModel.build(map, self);
    }

    public GetUploadTokenResponseBody setAccessKeyId(String accessKeyId) {
        this.accessKeyId = accessKeyId;
        return this;
    }
    public String getAccessKeyId() {
        return this.accessKeyId;
    }

    public GetUploadTokenResponseBody setAccessKeySecret(String accessKeySecret) {
        this.accessKeySecret = accessKeySecret;
        return this;
    }
    public String getAccessKeySecret() {
        return this.accessKeySecret;
    }

    public GetUploadTokenResponseBody setBucket(String bucket) {
        this.bucket = bucket;
        return this;
    }
    public String getBucket() {
        return this.bucket;
    }

    public GetUploadTokenResponseBody setEndpoint(String endpoint) {
        this.endpoint = endpoint;
        return this;
    }
    public String getEndpoint() {
        return this.endpoint;
    }

    public GetUploadTokenResponseBody setExpiration(String expiration) {
        this.expiration = expiration;
        return this;
    }
    public String getExpiration() {
        return this.expiration;
    }

    public GetUploadTokenResponseBody setName(String name) {
        this.name = name;
        return this;
    }
    public String getName() {
        return this.name;
    }

    public GetUploadTokenResponseBody setRegion(String region) {
        this.region = region;
        return this;
    }
    public String getRegion() {
        return this.region;
    }

    public GetUploadTokenResponseBody setStsToken(String stsToken) {
        this.stsToken = stsToken;
        return this;
    }
    public String getStsToken() {
        return this.stsToken;
    }

}
