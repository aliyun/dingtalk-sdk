// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkedu_1_0.models;

import com.aliyun.tea.*;

public class UpdateRemoteClassDeviceRequest extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("authCode")
    public String authCode;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("deviceCode")
    public String deviceCode;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("deviceName")
    public String deviceName;

    public static UpdateRemoteClassDeviceRequest build(java.util.Map<String, ?> map) throws Exception {
        UpdateRemoteClassDeviceRequest self = new UpdateRemoteClassDeviceRequest();
        return TeaModel.build(map, self);
    }

    public UpdateRemoteClassDeviceRequest setAuthCode(String authCode) {
        this.authCode = authCode;
        return this;
    }
    public String getAuthCode() {
        return this.authCode;
    }

    public UpdateRemoteClassDeviceRequest setDeviceCode(String deviceCode) {
        this.deviceCode = deviceCode;
        return this;
    }
    public String getDeviceCode() {
        return this.deviceCode;
    }

    public UpdateRemoteClassDeviceRequest setDeviceName(String deviceName) {
        this.deviceName = deviceName;
        return this;
    }
    public String getDeviceName() {
        return this.deviceName;
    }

}
