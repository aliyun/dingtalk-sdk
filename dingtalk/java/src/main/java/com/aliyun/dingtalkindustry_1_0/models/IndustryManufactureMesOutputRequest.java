// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkindustry_1_0.models;

import com.aliyun.tea.*;

public class IndustryManufactureMesOutputRequest extends TeaModel {
    // 本次操作的行为
    @NameInMap("action")
    public String action;

    // 生态唯一标识, 需要注册
    @NameInMap("appKey")
    public String appKey;

    // 审批状态
    @NameInMap("approveStatus")
    public String approveStatus;

    // 主数据名称
    @NameInMap("baseDataName")
    public String baseDataName;

    // 不良品总数(多次报工)
    @NameInMap("defectsAmount")
    public String defectsAmount;

    // 不良品原因
    @NameInMap("defectsReason")
    public String defectsReason;

    // 良品总数(多次报工)
    @NameInMap("fineAmount")
    public String fineAmount;

    // 是否已质检
    @NameInMap("hasQualityTest")
    public String hasQualityTest;

    // 任务逾期
    @NameInMap("overdue")
    public Integer overdue;

    // 派工(总)数
    @NameInMap("planQuantity")
    public Long planQuantity;

    // 是否加急
    @NameInMap("priority")
    public Integer priority;

    // 工序名称
    @NameInMap("processName")
    public String processName;

    // 工序业务唯一标识
    @NameInMap("processUuid")
    public String processUuid;

    // 产品编号(物料编号)
    @NameInMap("productCode")
    public String productCode;

    // 产品名称
    @NameInMap("productName")
    public String productName;

    // 产品(物料)规格
    @NameInMap("productSpecification")
    public String productSpecification;

    // 工单编号(生产任务单)
    @NameInMap("projectCode")
    public String projectCode;

    // 工单(生产计划单)
    @NameInMap("projectId")
    public String projectId;

    // 工单状态
    @NameInMap("projectStatus")
    public String projectStatus;

    // 检验状态
    @NameInMap("qualityTestStatus")
    public String qualityTestStatus;

    // 任务计划结束(完成)时间
    @NameInMap("taskPlanEndTime")
    public String taskPlanEndTime;

    // 任务计划开始时间
    @NameInMap("taskPlanStartTime")
    public String taskPlanStartTime;

    // 派工任务状态
    @NameInMap("taskStatus")
    public String taskStatus;

    // 报工类型(正常,委外)
    @NameInMap("taskType")
    public String taskType;

    // 派工任务唯一标识
    @NameInMap("taskUuid")
    public String taskUuid;

    // 负责班组id
    @NameInMap("teamId")
    public String teamId;

    // 报工人staffNo(生产人员)
    @NameInMap("userId")
    public String userId;

    // 派工人名称
    @NameInMap("userName")
    public String userName;

    // 本次记录唯一标识
    @NameInMap("uuid")
    public String uuid;

    public static IndustryManufactureMesOutputRequest build(java.util.Map<String, ?> map) throws Exception {
        IndustryManufactureMesOutputRequest self = new IndustryManufactureMesOutputRequest();
        return TeaModel.build(map, self);
    }

    public IndustryManufactureMesOutputRequest setAction(String action) {
        this.action = action;
        return this;
    }
    public String getAction() {
        return this.action;
    }

    public IndustryManufactureMesOutputRequest setAppKey(String appKey) {
        this.appKey = appKey;
        return this;
    }
    public String getAppKey() {
        return this.appKey;
    }

    public IndustryManufactureMesOutputRequest setApproveStatus(String approveStatus) {
        this.approveStatus = approveStatus;
        return this;
    }
    public String getApproveStatus() {
        return this.approveStatus;
    }

    public IndustryManufactureMesOutputRequest setBaseDataName(String baseDataName) {
        this.baseDataName = baseDataName;
        return this;
    }
    public String getBaseDataName() {
        return this.baseDataName;
    }

    public IndustryManufactureMesOutputRequest setDefectsAmount(String defectsAmount) {
        this.defectsAmount = defectsAmount;
        return this;
    }
    public String getDefectsAmount() {
        return this.defectsAmount;
    }

    public IndustryManufactureMesOutputRequest setDefectsReason(String defectsReason) {
        this.defectsReason = defectsReason;
        return this;
    }
    public String getDefectsReason() {
        return this.defectsReason;
    }

    public IndustryManufactureMesOutputRequest setFineAmount(String fineAmount) {
        this.fineAmount = fineAmount;
        return this;
    }
    public String getFineAmount() {
        return this.fineAmount;
    }

    public IndustryManufactureMesOutputRequest setHasQualityTest(String hasQualityTest) {
        this.hasQualityTest = hasQualityTest;
        return this;
    }
    public String getHasQualityTest() {
        return this.hasQualityTest;
    }

    public IndustryManufactureMesOutputRequest setOverdue(Integer overdue) {
        this.overdue = overdue;
        return this;
    }
    public Integer getOverdue() {
        return this.overdue;
    }

    public IndustryManufactureMesOutputRequest setPlanQuantity(Long planQuantity) {
        this.planQuantity = planQuantity;
        return this;
    }
    public Long getPlanQuantity() {
        return this.planQuantity;
    }

    public IndustryManufactureMesOutputRequest setPriority(Integer priority) {
        this.priority = priority;
        return this;
    }
    public Integer getPriority() {
        return this.priority;
    }

    public IndustryManufactureMesOutputRequest setProcessName(String processName) {
        this.processName = processName;
        return this;
    }
    public String getProcessName() {
        return this.processName;
    }

    public IndustryManufactureMesOutputRequest setProcessUuid(String processUuid) {
        this.processUuid = processUuid;
        return this;
    }
    public String getProcessUuid() {
        return this.processUuid;
    }

    public IndustryManufactureMesOutputRequest setProductCode(String productCode) {
        this.productCode = productCode;
        return this;
    }
    public String getProductCode() {
        return this.productCode;
    }

    public IndustryManufactureMesOutputRequest setProductName(String productName) {
        this.productName = productName;
        return this;
    }
    public String getProductName() {
        return this.productName;
    }

    public IndustryManufactureMesOutputRequest setProductSpecification(String productSpecification) {
        this.productSpecification = productSpecification;
        return this;
    }
    public String getProductSpecification() {
        return this.productSpecification;
    }

    public IndustryManufactureMesOutputRequest setProjectCode(String projectCode) {
        this.projectCode = projectCode;
        return this;
    }
    public String getProjectCode() {
        return this.projectCode;
    }

    public IndustryManufactureMesOutputRequest setProjectId(String projectId) {
        this.projectId = projectId;
        return this;
    }
    public String getProjectId() {
        return this.projectId;
    }

    public IndustryManufactureMesOutputRequest setProjectStatus(String projectStatus) {
        this.projectStatus = projectStatus;
        return this;
    }
    public String getProjectStatus() {
        return this.projectStatus;
    }

    public IndustryManufactureMesOutputRequest setQualityTestStatus(String qualityTestStatus) {
        this.qualityTestStatus = qualityTestStatus;
        return this;
    }
    public String getQualityTestStatus() {
        return this.qualityTestStatus;
    }

    public IndustryManufactureMesOutputRequest setTaskPlanEndTime(String taskPlanEndTime) {
        this.taskPlanEndTime = taskPlanEndTime;
        return this;
    }
    public String getTaskPlanEndTime() {
        return this.taskPlanEndTime;
    }

    public IndustryManufactureMesOutputRequest setTaskPlanStartTime(String taskPlanStartTime) {
        this.taskPlanStartTime = taskPlanStartTime;
        return this;
    }
    public String getTaskPlanStartTime() {
        return this.taskPlanStartTime;
    }

    public IndustryManufactureMesOutputRequest setTaskStatus(String taskStatus) {
        this.taskStatus = taskStatus;
        return this;
    }
    public String getTaskStatus() {
        return this.taskStatus;
    }

    public IndustryManufactureMesOutputRequest setTaskType(String taskType) {
        this.taskType = taskType;
        return this;
    }
    public String getTaskType() {
        return this.taskType;
    }

    public IndustryManufactureMesOutputRequest setTaskUuid(String taskUuid) {
        this.taskUuid = taskUuid;
        return this;
    }
    public String getTaskUuid() {
        return this.taskUuid;
    }

    public IndustryManufactureMesOutputRequest setTeamId(String teamId) {
        this.teamId = teamId;
        return this;
    }
    public String getTeamId() {
        return this.teamId;
    }

    public IndustryManufactureMesOutputRequest setUserId(String userId) {
        this.userId = userId;
        return this;
    }
    public String getUserId() {
        return this.userId;
    }

    public IndustryManufactureMesOutputRequest setUserName(String userName) {
        this.userName = userName;
        return this;
    }
    public String getUserName() {
        return this.userName;
    }

    public IndustryManufactureMesOutputRequest setUuid(String uuid) {
        this.uuid = uuid;
        return this;
    }
    public String getUuid() {
        return this.uuid;
    }

}
