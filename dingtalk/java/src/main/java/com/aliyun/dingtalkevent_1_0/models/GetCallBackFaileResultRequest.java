// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkevent_1_0.models;

import com.aliyun.tea.*;

public class GetCallBackFaileResultRequest extends TeaModel {
    /**
     * <strong>example:</strong>
     * <p>1606126433000</p>
     */
    @NameInMap("beginTime")
    public Long beginTime;

    /**
     * <strong>example:</strong>
     * <p>1606126493000</p>
     */
    @NameInMap("endTime")
    public Long endTime;

    public static GetCallBackFaileResultRequest build(java.util.Map<String, ?> map) throws Exception {
        GetCallBackFaileResultRequest self = new GetCallBackFaileResultRequest();
        return TeaModel.build(map, self);
    }

    public GetCallBackFaileResultRequest setBeginTime(Long beginTime) {
        this.beginTime = beginTime;
        return this;
    }
    public Long getBeginTime() {
        return this.beginTime;
    }

    public GetCallBackFaileResultRequest setEndTime(Long endTime) {
        this.endTime = endTime;
        return this;
    }
    public Long getEndTime() {
        return this.endTime;
    }

}
