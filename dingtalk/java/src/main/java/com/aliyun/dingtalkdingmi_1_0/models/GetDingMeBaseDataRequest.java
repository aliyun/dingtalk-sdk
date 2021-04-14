// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdingmi_1_0.models;

import com.aliyun.tea.*;

public class GetDingMeBaseDataRequest extends TeaModel {
    // 机器人ID
    @NameInMap("appKey")
    public String appKey;

    // 开始时间
    @NameInMap("startDay")
    public String startDay;

    // 结束时间
    @NameInMap("endDay")
    public String endDay;

    // 是否按天分组
    @NameInMap("byDay")
    public Boolean byDay;

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

    public GetDingMeBaseDataRequest setStartDay(String startDay) {
        this.startDay = startDay;
        return this;
    }
    public String getStartDay() {
        return this.startDay;
    }

    public GetDingMeBaseDataRequest setEndDay(String endDay) {
        this.endDay = endDay;
        return this;
    }
    public String getEndDay() {
        return this.endDay;
    }

    public GetDingMeBaseDataRequest setByDay(Boolean byDay) {
        this.byDay = byDay;
        return this;
    }
    public Boolean getByDay() {
        return this.byDay;
    }

}
