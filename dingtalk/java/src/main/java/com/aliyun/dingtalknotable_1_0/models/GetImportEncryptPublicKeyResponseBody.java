// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalknotable_1_0.models;

import com.aliyun.tea.*;

public class GetImportEncryptPublicKeyResponseBody extends TeaModel {
    @NameInMap("algorithm")
    public String algorithm;

    @NameInMap("expireAt")
    public Long expireAt;

    @NameInMap("keyVersion")
    public String keyVersion;

    @NameInMap("publicKeyPem")
    public String publicKeyPem;

    public static GetImportEncryptPublicKeyResponseBody build(java.util.Map<String, ?> map) throws Exception {
        GetImportEncryptPublicKeyResponseBody self = new GetImportEncryptPublicKeyResponseBody();
        return TeaModel.build(map, self);
    }

    public GetImportEncryptPublicKeyResponseBody setAlgorithm(String algorithm) {
        this.algorithm = algorithm;
        return this;
    }
    public String getAlgorithm() {
        return this.algorithm;
    }

    public GetImportEncryptPublicKeyResponseBody setExpireAt(Long expireAt) {
        this.expireAt = expireAt;
        return this;
    }
    public Long getExpireAt() {
        return this.expireAt;
    }

    public GetImportEncryptPublicKeyResponseBody setKeyVersion(String keyVersion) {
        this.keyVersion = keyVersion;
        return this;
    }
    public String getKeyVersion() {
        return this.keyVersion;
    }

    public GetImportEncryptPublicKeyResponseBody setPublicKeyPem(String publicKeyPem) {
        this.publicKeyPem = publicKeyPem;
        return this;
    }
    public String getPublicKeyPem() {
        return this.publicKeyPem;
    }

}
