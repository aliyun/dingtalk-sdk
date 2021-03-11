// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkattendance_1_0.models;

import com.aliyun.tea.*;

public class GetUserHolidaysShrinkRequest extends TeaModel {
    // 查询对象
    @NameInMap("topHolidayQueryParam")
    public String topHolidayQueryParamShrink;

    public static GetUserHolidaysShrinkRequest build(java.util.Map<String, ?> map) throws Exception {
        GetUserHolidaysShrinkRequest self = new GetUserHolidaysShrinkRequest();
        return TeaModel.build(map, self);
    }

    public GetUserHolidaysShrinkRequest setTopHolidayQueryParamShrink(String topHolidayQueryParamShrink) {
        this.topHolidayQueryParamShrink = topHolidayQueryParamShrink;
        return this;
    }
    public String getTopHolidayQueryParamShrink() {
        return this.topHolidayQueryParamShrink;
    }

}
