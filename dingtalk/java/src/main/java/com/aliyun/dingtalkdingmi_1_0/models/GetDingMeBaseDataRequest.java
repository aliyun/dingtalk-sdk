// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdingmi_1_0.models;

import com.aliyun.tea.*;

public class GetDingMeBaseDataRequest extends TeaModel {
    /**
     * <p>机器人ID</p>
     */
    @NameInMap("appKey")
    public String appKey;

    /**
     * <p>是否按天分组</p>
     */
    @NameInMap("byDay")
    public Boolean byDay;

    /**
     * <p>结束时间</p>
     */
    @NameInMap("endDay")
    public String endDay;

    /**
     * <p>开始时间</p>
     */
    @NameInMap("startDay")
    public String startDay;

    public static GetDingMeBaseDataRequest build(java.util.Map<String, ?> map) throws Exception {
        GetDingMeBaseDataRequest self = new GetDingMeBaseDataRequest();
        return TeaModel.build(map, self);
    }

    public GetDingMeBaseDataRequest setAppKey(String appKey) {
        this.appKey = appKey;
        return this;
    }
    public String getAppKey() {
        return this.appKey;
    }

    public GetDingMeBaseDataRequest setByDay(Boolean byDay) {
        this.byDay = byDay;
        return this;
    }
    public Boolean getByDay() {
        return this.byDay;
    }

    public GetDingMeBaseDataRequest setEndDay(String endDay) {
        this.endDay = endDay;
        return this;
    }
    public String getEndDay() {
        return this.endDay;
    }

    public GetDingMeBaseDataRequest setStartDay(String startDay) {
        this.startDay = startDay;
        return this;
    }
    public String getStartDay() {
        return this.startDay;
    }

}
