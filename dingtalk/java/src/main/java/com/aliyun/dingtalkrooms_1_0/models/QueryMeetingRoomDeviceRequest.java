// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkrooms_1_0.models;

import com.aliyun.tea.*;

public class QueryMeetingRoomDeviceRequest extends TeaModel {
    /**
     * <p>查询设备id</p>
     */
    @NameInMap("deviceId")
    public String deviceId;

    /**
     * <p>查询设备unionId</p>
     */
    @NameInMap("deviceUnionId")
    public String deviceUnionId;

    /**
     * <p>查询人unionId</p>
     */
    @NameInMap("operatorUnionId")
    public String operatorUnionId;

    public static QueryMeetingRoomDeviceRequest build(java.util.Map<String, ?> map) throws Exception {
        QueryMeetingRoomDeviceRequest self = new QueryMeetingRoomDeviceRequest();
        return TeaModel.build(map, self);
    }

    public QueryMeetingRoomDeviceRequest setDeviceId(String deviceId) {
        this.deviceId = deviceId;
        return this;
    }
    public String getDeviceId() {
        return this.deviceId;
    }

    public QueryMeetingRoomDeviceRequest setDeviceUnionId(String deviceUnionId) {
        this.deviceUnionId = deviceUnionId;
        return this;
    }
    public String getDeviceUnionId() {
        return this.deviceUnionId;
    }

    public QueryMeetingRoomDeviceRequest setOperatorUnionId(String operatorUnionId) {
        this.operatorUnionId = operatorUnionId;
        return this;
    }
    public String getOperatorUnionId() {
        return this.operatorUnionId;
    }

}
