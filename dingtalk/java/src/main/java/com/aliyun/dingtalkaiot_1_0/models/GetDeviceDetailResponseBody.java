// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkaiot_1_0.models;

import com.aliyun.tea.*;

public class GetDeviceDetailResponseBody extends TeaModel {
    @NameInMap("activatedAt")
    public String activatedAt;

    @NameInMap("connectivity")
    public String connectivity;

    @NameInMap("lastOfflineTime")
    public String lastOfflineTime;

    @NameInMap("lastOnlineTime")
    public String lastOnlineTime;

    @NameInMap("status")
    public String status;

    public static GetDeviceDetailResponseBody build(java.util.Map<String, ?> map) throws Exception {
        GetDeviceDetailResponseBody self = new GetDeviceDetailResponseBody();
        return TeaModel.build(map, self);
    }

    public GetDeviceDetailResponseBody setActivatedAt(String activatedAt) {
        this.activatedAt = activatedAt;
        return this;
    }
    public String getActivatedAt() {
        return this.activatedAt;
    }

    public GetDeviceDetailResponseBody setConnectivity(String connectivity) {
        this.connectivity = connectivity;
        return this;
    }
    public String getConnectivity() {
        return this.connectivity;
    }

    public GetDeviceDetailResponseBody setLastOfflineTime(String lastOfflineTime) {
        this.lastOfflineTime = lastOfflineTime;
        return this;
    }
    public String getLastOfflineTime() {
        return this.lastOfflineTime;
    }

    public GetDeviceDetailResponseBody setLastOnlineTime(String lastOnlineTime) {
        this.lastOnlineTime = lastOnlineTime;
        return this;
    }
    public String getLastOnlineTime() {
        return this.lastOnlineTime;
    }

    public GetDeviceDetailResponseBody setStatus(String status) {
        this.status = status;
        return this;
    }
    public String getStatus() {
        return this.status;
    }

}
