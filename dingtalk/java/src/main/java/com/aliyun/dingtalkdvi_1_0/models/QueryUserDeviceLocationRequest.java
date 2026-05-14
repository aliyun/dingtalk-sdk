// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdvi_1_0.models;

import com.aliyun.tea.*;

public class QueryUserDeviceLocationRequest extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("endTime")
    public Long endTime;

    @NameInMap("sn")
    public String sn;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("startTime")
    public Long startTime;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("userId")
    public String userId;

    public static QueryUserDeviceLocationRequest build(java.util.Map<String, ?> map) throws Exception {
        QueryUserDeviceLocationRequest self = new QueryUserDeviceLocationRequest();
        return TeaModel.build(map, self);
    }

    public QueryUserDeviceLocationRequest setEndTime(Long endTime) {
        this.endTime = endTime;
        return this;
    }
    public Long getEndTime() {
        return this.endTime;
    }

    public QueryUserDeviceLocationRequest setSn(String sn) {
        this.sn = sn;
        return this;
    }
    public String getSn() {
        return this.sn;
    }

    public QueryUserDeviceLocationRequest setStartTime(Long startTime) {
        this.startTime = startTime;
        return this;
    }
    public Long getStartTime() {
        return this.startTime;
    }

    public QueryUserDeviceLocationRequest setUserId(String userId) {
        this.userId = userId;
        return this;
    }
    public String getUserId() {
        return this.userId;
    }

}
