// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkexclusive_1_0.models;

import com.aliyun.tea.*;

public class DeleteTrustedDeviceRequest extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>false</p>
     */
    @NameInMap("kickOff")
    public Boolean kickOff;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>88:92:5a:1f:e8:24</p>
     */
    @NameInMap("macAddress")
    public String macAddress;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>0119194439361061403</p>
     */
    @NameInMap("userId")
    public String userId;

    public static DeleteTrustedDeviceRequest build(java.util.Map<String, ?> map) throws Exception {
        DeleteTrustedDeviceRequest self = new DeleteTrustedDeviceRequest();
        return TeaModel.build(map, self);
    }

    public DeleteTrustedDeviceRequest setKickOff(Boolean kickOff) {
        this.kickOff = kickOff;
        return this;
    }
    public Boolean getKickOff() {
        return this.kickOff;
    }

    public DeleteTrustedDeviceRequest setMacAddress(String macAddress) {
        this.macAddress = macAddress;
        return this;
    }
    public String getMacAddress() {
        return this.macAddress;
    }

    public DeleteTrustedDeviceRequest setUserId(String userId) {
        this.userId = userId;
        return this;
    }
    public String getUserId() {
        return this.userId;
    }

}
