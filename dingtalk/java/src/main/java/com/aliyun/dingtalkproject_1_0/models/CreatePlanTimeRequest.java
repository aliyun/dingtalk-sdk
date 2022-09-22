// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkproject_1_0.models;

import com.aliyun.tea.*;

public class CreatePlanTimeRequest extends TeaModel {
    // 结束时间
    @NameInMap("endDate")
    public String endDate;

    // 执行者userid
    @NameInMap("executorId")
    public String executorId;

    // 是否包含假期
    @NameInMap("includesHolidays")
    public Boolean includesHolidays;

    // 是否连续
    @NameInMap("isDuration")
    public Boolean isDuration;

    // 对象id，比如任务id
    @NameInMap("objectId")
    public String objectId;

    // 对象类型，默认为task
    @NameInMap("objectType")
    public String objectType;

    // 计划工时数（单位：毫秒，1小时即为 3600000）
    @NameInMap("planTime")
    public Long planTime;

    // 开始时间
    @NameInMap("startDate")
    public String startDate;

    // 工时所属人员userid
    @NameInMap("submitterId")
    public String submitterId;

    // 接口校验类型，当前默认organization
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
