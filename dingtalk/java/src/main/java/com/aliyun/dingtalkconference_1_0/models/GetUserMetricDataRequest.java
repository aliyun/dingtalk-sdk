// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkconference_1_0.models;

import com.aliyun.tea.*;

public class GetUserMetricDataRequest extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>1682524800000</p>
     */
    @NameInMap("beginTime")
    public Long beginTime;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>1682611199000</p>
     */
    @NameInMap("endTime")
    public Long endTime;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>njMTqKo9iiyxxxxxxxxiEiE</p>
     */
    @NameInMap("unionId")
    public String unionId;

    public static GetUserMetricDataRequest build(java.util.Map<String, ?> map) throws Exception {
        GetUserMetricDataRequest self = new GetUserMetricDataRequest();
        return TeaModel.build(map, self);
    }

    public GetUserMetricDataRequest setBeginTime(Long beginTime) {
        this.beginTime = beginTime;
        return this;
    }
    public Long getBeginTime() {
        return this.beginTime;
    }

    public GetUserMetricDataRequest setEndTime(Long endTime) {
        this.endTime = endTime;
        return this;
    }
    public Long getEndTime() {
        return this.endTime;
    }

    public GetUserMetricDataRequest setUnionId(String unionId) {
        this.unionId = unionId;
        return this;
    }
    public String getUnionId() {
        return this.unionId;
    }

}
