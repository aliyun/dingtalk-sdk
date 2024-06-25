// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkexclusive_1_0.models;

import com.aliyun.tea.*;

public class GetAppDispatchInfoRequest extends TeaModel {
    /**
     * <strong>example:</strong>
     * <p>1655709383307</p>
     */
    @NameInMap("endTime")
    public Long endTime;

    /**
     * <strong>example:</strong>
     * <p>1655709383307</p>
     */
    @NameInMap("startTime")
    public Long startTime;

    public static GetAppDispatchInfoRequest build(java.util.Map<String, ?> map) throws Exception {
        GetAppDispatchInfoRequest self = new GetAppDispatchInfoRequest();
        return TeaModel.build(map, self);
    }

    public GetAppDispatchInfoRequest setEndTime(Long endTime) {
        this.endTime = endTime;
        return this;
    }
    public Long getEndTime() {
        return this.endTime;
    }

    public GetAppDispatchInfoRequest setStartTime(Long startTime) {
        this.startTime = startTime;
        return this;
    }
    public Long getStartTime() {
        return this.startTime;
    }

}
