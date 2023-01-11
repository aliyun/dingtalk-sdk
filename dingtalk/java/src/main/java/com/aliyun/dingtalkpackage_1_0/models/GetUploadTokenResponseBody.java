// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkpackage_1_0.models;

import com.aliyun.tea.*;

public class GetUploadTokenResponseBody extends TeaModel {
    /**
     * <p>阿里云OSS SDK初始化配置项</p>
     */
    @NameInMap("accessKeyId")
    public String accessKeyId;

    /**
     * <p>阿里云OSS SDK初始化配置项</p>
     */
    @NameInMap("accessKeySecret")
    public String accessKeySecret;

    /**
     * <p>阿里云OSS SDK初始化配置项</p>
     */
    @NameInMap("bucket")
    public String bucket;

    /**
     * <p>阿里云OSS SDK初始化配置项</p>
     */
    @NameInMap("endpoint")
    public String endpoint;

    /**
     * <p>阿里云OSS SDK初始化配置项</p>
     */
    @NameInMap("expiration")
    public String expiration;

    /**
     * <p>阿里云OSS SDK初始化配置项</p>
     */
    @NameInMap("name")
    public String name;

    /**
     * <p>阿里云OSS SDK初始化配置项</p>
     */
    @NameInMap("region")
    public String region;

    /**
     * <p>阿里云OSS SDK初始化配置项</p>
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
