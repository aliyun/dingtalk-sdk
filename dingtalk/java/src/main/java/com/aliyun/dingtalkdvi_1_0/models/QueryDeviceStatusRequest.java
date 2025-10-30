// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdvi_1_0.models;

import com.aliyun.tea.*;

public class QueryDeviceStatusRequest extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>A1</p>
     */
    @NameInMap("deviceType")
    public String deviceType;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("snList")
    public java.util.List<String> snList;

    public static QueryDeviceStatusRequest build(java.util.Map<String, ?> map) throws Exception {
        QueryDeviceStatusRequest self = new QueryDeviceStatusRequest();
        return TeaModel.build(map, self);
    }

    public QueryDeviceStatusRequest setDeviceType(String deviceType) {
        this.deviceType = deviceType;
        return this;
    }
    public String getDeviceType() {
        return this.deviceType;
    }

    public QueryDeviceStatusRequest setSnList(java.util.List<String> snList) {
        this.snList = snList;
        return this;
    }
    public java.util.List<String> getSnList() {
        return this.snList;
    }

}
