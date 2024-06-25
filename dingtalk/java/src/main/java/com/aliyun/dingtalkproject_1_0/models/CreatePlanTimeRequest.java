// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkproject_1_0.models;

import com.aliyun.tea.*;

public class CreatePlanTimeRequest extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>2022-09-05</p>
     */
    @NameInMap("endDate")
    public String endDate;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>123456</p>
     */
    @NameInMap("executorId")
    public String executorId;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("includesHolidays")
    public Boolean includesHolidays;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("isDuration")
    public Boolean isDuration;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>63186e54e07f18003fea6b90</p>
     */
    @NameInMap("objectId")
    public String objectId;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>task</p>
     */
    @NameInMap("objectType")
    public String objectType;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>3600000</p>
     */
    @NameInMap("planTime")
    public Long planTime;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>2022-09-05</p>
     */
    @NameInMap("startDate")
    public String startDate;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>123456</p>
     */
    @NameInMap("submitterId")
    public String submitterId;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>organization</p>
     */
    @NameInMap("tenantType")
    public String tenantType;

    public static CreatePlanTimeRequest build(java.util.Map<String, ?> map) throws Exception {
        CreatePlanTimeRequest self = new CreatePlanTimeRequest();
        return TeaModel.build(map, self);
    }

    public CreatePlanTimeRequest setEndDate(String endDate) {
        this.endDate = endDate;
        return this;
    }
    public String getEndDate() {
        return this.endDate;
    }

    public CreatePlanTimeRequest setExecutorId(String executorId) {
        this.executorId = executorId;
        return this;
    }
    public String getExecutorId() {
        return this.executorId;
    }

    public CreatePlanTimeRequest setIncludesHolidays(Boolean includesHolidays) {
        this.includesHolidays = includesHolidays;
        return this;
    }
    public Boolean getIncludesHolidays() {
        return this.includesHolidays;
    }

    public CreatePlanTimeRequest setIsDuration(Boolean isDuration) {
        this.isDuration = isDuration;
        return this;
    }
    public Boolean getIsDuration() {
        return this.isDuration;
    }

    public CreatePlanTimeRequest setObjectId(String objectId) {
        this.objectId = objectId;
        return this;
    }
    public String getObjectId() {
        return this.objectId;
    }

    public CreatePlanTimeRequest setObjectType(String objectType) {
        this.objectType = objectType;
        return this;
    }
    public String getObjectType() {
        return this.objectType;
    }

    public CreatePlanTimeRequest setPlanTime(Long planTime) {
        this.planTime = planTime;
        return this;
    }
    public Long getPlanTime() {
        return this.planTime;
    }

    public CreatePlanTimeRequest setStartDate(String startDate) {
        this.startDate = startDate;
        return this;
    }
    public String getStartDate() {
        return this.startDate;
    }

    public CreatePlanTimeRequest setSubmitterId(String submitterId) {
        this.submitterId = submitterId;
        return this;
    }
    public String getSubmitterId() {
        return this.submitterId;
    }

    public CreatePlanTimeRequest setTenantType(String tenantType) {
        this.tenantType = tenantType;
        return this;
    }
    public String getTenantType() {
        return this.tenantType;
    }

}
