// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkrooms_1_0.models;

import com.aliyun.tea.*;

public class QueryMeetingRoomDeviceRequest extends TeaModel {
    @NameInMap("deviceId")
    public String deviceId;

    @NameInMap("deviceUnionId")
    public String deviceUnionId;

    /**
     * <p>This parameter is required.</p>
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
