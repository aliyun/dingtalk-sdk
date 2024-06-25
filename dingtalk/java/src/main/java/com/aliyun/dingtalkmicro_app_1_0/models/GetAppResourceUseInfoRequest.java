// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkmicro_app_1_0.models;

import com.aliyun.tea.*;

public class GetAppResourceUseInfoRequest extends TeaModel {
    /**
     * <strong>example:</strong>
     * <p>api_count</p>
     */
    @NameInMap("benefitCode")
    public String benefitCode;

    /**
     * <strong>example:</strong>
     * <p>202302</p>
     */
    @NameInMap("endTime")
    public String endTime;

    /**
     * <strong>example:</strong>
     * <p>month</p>
     */
    @NameInMap("periodType")
    public String periodType;

    /**
     * <strong>example:</strong>
     * <p>202301</p>
     */
    @NameInMap("startTime")
    public String startTime;

    public static GetAppResourceUseInfoRequest build(java.util.Map<String, ?> map) throws Exception {
        GetAppResourceUseInfoRequest self = new GetAppResourceUseInfoRequest();
        return TeaModel.build(map, self);
    }

    public GetAppResourceUseInfoRequest setBenefitCode(String benefitCode) {
        this.benefitCode = benefitCode;
        return this;
    }
    public String getBenefitCode() {
        return this.benefitCode;
    }

    public GetAppResourceUseInfoRequest setEndTime(String endTime) {
        this.endTime = endTime;
        return this;
    }
    public String getEndTime() {
        return this.endTime;
    }

    public GetAppResourceUseInfoRequest setPeriodType(String periodType) {
        this.periodType = periodType;
        return this;
    }
    public String getPeriodType() {
        return this.periodType;
    }

    public GetAppResourceUseInfoRequest setStartTime(String startTime) {
        this.startTime = startTime;
        return this;
    }
    public String getStartTime() {
        return this.startTime;
    }

}
