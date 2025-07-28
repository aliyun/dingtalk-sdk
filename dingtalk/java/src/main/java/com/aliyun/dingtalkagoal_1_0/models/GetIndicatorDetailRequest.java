// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkagoal_1_0.models;

import com.aliyun.tea.*;

public class GetIndicatorDetailRequest extends TeaModel {
    @NameInMap("indicatorId")
    public String indicatorId;

    @NameInMap("monthNum")
    public Long monthNum;

    public static GetIndicatorDetailRequest build(java.util.Map<String, ?> map) throws Exception {
        GetIndicatorDetailRequest self = new GetIndicatorDetailRequest();
        return TeaModel.build(map, self);
    }

    public GetIndicatorDetailRequest setIndicatorId(String indicatorId) {
        this.indicatorId = indicatorId;
        return this;
    }
    public String getIndicatorId() {
        return this.indicatorId;
    }

    public GetIndicatorDetailRequest setMonthNum(Long monthNum) {
        this.monthNum = monthNum;
        return this;
    }
    public Long getMonthNum() {
        return this.monthNum;
    }

}
