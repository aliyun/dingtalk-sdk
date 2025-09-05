// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkexclusive_1_0.models;

import com.aliyun.tea.*;

public class CreateTrustedDeviceRequest extends TeaModel {
    /**
     * <strong>example:</strong>
     * <p>CV11z5d2bdbb2260d1576000b4a9955fa</p>
     */
    @NameInMap("did")
    public String did;

    /**
     * <strong>example:</strong>
     * <p>88:92:5a:1f:e8:24</p>
     */
    @NameInMap("macAddress")
    public String macAddress;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>Mac</p>
     */
    @NameInMap("platform")
    public String platform;

    /**
     * <strong>example:</strong>
     * <p>11-22-33-44-55</p>
     */
    @NameInMap("serialNumber")
    public String serialNumber;

    /**
     * <strong>example:</strong>
     * <p>2</p>
     */
    @NameInMap("status")
    public Integer status;

    /**
     * <strong>example:</strong>
     * <p>设备名称</p>
     */
    @NameInMap("title")
    public String title;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>65224157501039784</p>
     */
    @NameInMap("userId")
    public String userId;

    public static CreateTrustedDeviceRequest build(java.util.Map<String, ?> map) throws Exception {
        CreateTrustedDeviceRequest self = new CreateTrustedDeviceRequest();
        return TeaModel.build(map, self);
    }

    public CreateTrustedDeviceRequest setDid(String did) {
        this.did = did;
        return this;
    }
    public String getDid() {
        return this.did;
    }

    public CreateTrustedDeviceRequest setMacAddress(String macAddress) {
        this.macAddress = macAddress;
        return this;
    }
    public String getMacAddress() {
        return this.macAddress;
    }

    public CreateTrustedDeviceRequest setPlatform(String platform) {
        this.platform = platform;
        return this;
    }
    public String getPlatform() {
        return this.platform;
    }

    public CreateTrustedDeviceRequest setSerialNumber(String serialNumber) {
        this.serialNumber = serialNumber;
        return this;
    }
    public String getSerialNumber() {
        return this.serialNumber;
    }

    public CreateTrustedDeviceRequest setStatus(Integer status) {
        this.status = status;
        return this;
    }
    public Integer getStatus() {
        return this.status;
    }

    public CreateTrustedDeviceRequest setTitle(String title) {
        this.title = title;
        return this;
    }
    public String getTitle() {
        return this.title;
    }

    public CreateTrustedDeviceRequest setUserId(String userId) {
        this.userId = userId;
        return this;
    }
    public String getUserId() {
        return this.userId;
    }

}
