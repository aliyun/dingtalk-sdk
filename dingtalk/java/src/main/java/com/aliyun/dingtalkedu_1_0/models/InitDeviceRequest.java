// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkedu_1_0.models;

import com.aliyun.tea.*;

public class InitDeviceRequest extends TeaModel {
    // 公钥密文
    @NameInMap("encryptPubKey")
    public String encryptPubKey;

    // 签名
    @NameInMap("signature")
    public String signature;

    // 设备sn号
    @NameInMap("sn")
    public String sn;

    // 时间戳，utc时间
    @NameInMap("timestamp")
    public Long timestamp;

    // 版本号
    @NameInMap("version")
    public String version;

    public static InitDeviceRequest build(java.util.Map<String, ?> map) throws Exception {
        InitDeviceRequest self = new InitDeviceRequest();
        return TeaModel.build(map, self);
    }

    public InitDeviceRequest setEncryptPubKey(String encryptPubKey) {
        this.encryptPubKey = encryptPubKey;
        return this;
    }
    public String getEncryptPubKey() {
        return this.encryptPubKey;
    }

    public InitDeviceRequest setSignature(String signature) {
        this.signature = signature;
        return this;
    }
    public String getSignature() {
        return this.signature;
    }

    public InitDeviceRequest setSn(String sn) {
        this.sn = sn;
        return this;
    }
    public String getSn() {
        return this.sn;
    }

    public InitDeviceRequest setTimestamp(Long timestamp) {
        this.timestamp = timestamp;
        return this;
    }
    public Long getTimestamp() {
        return this.timestamp;
    }

    public InitDeviceRequest setVersion(String version) {
        this.version = version;
        return this;
    }
    public String getVersion() {
        return this.version;
    }

}
