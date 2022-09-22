// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkproject_1_0.models;

import com.aliyun.tea.*;

public class CreateWorkTimeRequest extends TeaModel {
    // 结束时间
    @NameInMap("endDate")
    public String endDate;

    // 执行者userid
    @NameInMap("executorId")
    public String executorId;

    // 是否包含节假日
    @NameInMap("includesHolidays")
    public Boolean includesHolidays;

    // 是否连续
    @NameInMap("isDuration")
    public Boolean isDuration;

    // 对象 ID，比如 任务 ID
    @NameInMap("objectId")
    public String objectId;

    // 对象类型，默认为 task
    @NameInMap("objectType")
    public String objectType;

    // 开始时间
    @NameInMap("startDate")
    public String startDate;

    // 工时所属人员userid
    @NameInMap("submitterId")
    public String submitterId;

    // 实际工时数（单位毫秒，1小时即为3600000）
    @NameInMap("workTime")
    public Long workTime;

    // 接口校验类型，当前默认organization
    @NameInMap("tenantType")
    public String tenantType;

    public static CreateWorkTimeRequest build(java.util.Map<String, ?> map) throws Exception {
        CreateWorkTimeRequest self = new CreateWorkTimeRequest();
        return TeaModel.build(map, self);
    }

    public CreateWorkTimeRequest setEndDate(String endDate) {
        this.endDate = endDate;
        return this;
    }
    public String getEndDate() {
        return this.endDate;
    }

    public CreateWorkTimeRequest setExecutorId(String executorId) {
        this.executorId = executorId;
        return this;
    }
    public String getExecutorId() {
        return this.executorId;
    }

    public CreateWorkTimeRequest setIncludesHolidays(Boolean includesHolidays) {
        this.includesHolidays = includesHolidays;
        return this;
    }
    public Boolean getIncludesHolidays() {
        return this.includesHolidays;
    }

    public CreateWorkTimeRequest setIsDuration(Boolean isDuration) {
        this.isDuration = isDuration;
        return this;
    }
    public Boolean getIsDuration() {
        return this.isDuration;
    }

    public CreateWorkTimeRequest setObjectId(String objectId) {
        this.objectId = objectId;
        return this;
    }
    public String getObjectId() {
        return this.objectId;
    }

    public CreateWorkTimeRequest setObjectType(String objectType) {
        this.objectType = objectType;
        return this;
    }
    public String getObjectType() {
        return this.objectType;
    }

    public CreateWorkTimeRequest setStartDate(String startDate) {
        this.startDate = startDate;
        return this;
    }
    public String getStartDate() {
        return this.startDate;
    }

    public CreateWorkTimeRequest setSubmitterId(String submitterId) {
        this.submitterId = submitterId;
        return this;
    }
    public String getSubmitterId() {
        return this.submitterId;
    }

    public CreateWorkTimeRequest setWorkTime(Long workTime) {
        this.workTime = workTime;
        return this;
    }
    public Long getWorkTime() {
        return this.workTime;
    }

    public CreateWorkTimeRequest setTenantType(String tenantType) {
        this.tenantType = tenantType;
        return this;
    }
    public String getTenantType() {
        return this.tenantType;
    }

}
