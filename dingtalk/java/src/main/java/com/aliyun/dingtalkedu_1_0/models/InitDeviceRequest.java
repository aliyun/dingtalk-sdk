// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkedu_1_0.models;

import com.aliyun.tea.*;

public class InitDeviceRequest extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>sdf34DFf2344</p>
     */
    @NameInMap("encryptPubKey")
    public String encryptPubKey;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>sdf34DFfffdf2344</p>
     */
    @NameInMap("signature")
    public String signature;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>SN123456</p>
     */
    @NameInMap("sn")
    public String sn;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>1231245511</p>
     */
    @NameInMap("timestamp")
    public Long timestamp;

    /**
     * <strong>example:</strong>
     * <p>1.0</p>
     */
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
