// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkh5package_1_0.models;

import com.aliyun.tea.*;

public class GetAccessTokenResponseBody extends TeaModel {
    // 阿里云OSS SDK初始化配置项
    @NameInMap("accessKeyId")
    public String accessKeyId;

    // 阿里云OSS SDK初始化配置项
    @NameInMap("accessKeySecret")
    public String accessKeySecret;

    // 阿里云OSS SDK初始化配置项
    @NameInMap("bucket")
    public String bucket;

    // 阿里云OSS SDK初始化配置项
    @NameInMap("endpoint")
    public String endpoint;

    // 阿里云OSS SDK初始化配置项
    @NameInMap("expiration")
    public String expiration;

    // 可上传的阿里云OSS文件地址
    @NameInMap("name")
    public String name;

    // 阿里云OSS SDK初始化配置项
    @NameInMap("region")
    public String region;

    // 阿里云OSS SDK初始化配置项
    @NameInMap("stsToken")
    public String stsToken;

    public static GetAccessTokenResponseBody build(java.util.Map<String, ?> map) throws Exception {
        GetAccessTokenResponseBody self = new GetAccessTokenResponseBody();
        return TeaModel.build(map, self);
    }

    public GetAccessTokenResponseBody setAccessKeyId(String accessKeyId) {
        this.accessKeyId = accessKeyId;
        return this;
    }
    public String getAccessKeyId() {
        return this.accessKeyId;
    }

    public GetAccessTokenResponseBody setAccessKeySecret(String accessKeySecret) {
        this.accessKeySecret = accessKeySecret;
        return this;
    }
    public String getAccessKeySecret() {
        return this.accessKeySecret;
    }

    public GetAccessTokenResponseBody setBucket(String bucket) {
        this.bucket = bucket;
        return this;
    }
    public String getBucket() {
        return this.bucket;
    }

    public GetAccessTokenResponseBody setEndpoint(String endpoint) {
        this.endpoint = endpoint;
        return this;
    }
    public String getEndpoint() {
        return this.endpoint;
    }

    public GetAccessTokenResponseBody setExpiration(String expiration) {
        this.expiration = expiration;
        return this;
    }
    public String getExpiration() {
        return this.expiration;
    }

    public GetAccessTokenResponseBody setName(String name) {
        this.name = name;
        return this;
    }
    public String getName() {
        return this.name;
    }

    public GetAccessTokenResponseBody setRegion(String region) {
        this.region = region;
        return this;
    }
    public String getRegion() {
        return this.region;
    }

    public GetAccessTokenResponseBody setStsToken(String stsToken) {
        this.stsToken = stsToken;
        return this;
    }
    public String getStsToken() {
        return this.stsToken;
    }

}
