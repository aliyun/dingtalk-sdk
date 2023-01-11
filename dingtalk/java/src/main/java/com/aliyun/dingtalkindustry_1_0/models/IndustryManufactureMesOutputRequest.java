// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkindustry_1_0.models;

import com.aliyun.tea.*;

public class IndustryManufactureMesOutputRequest extends TeaModel {
    /**
     * <p>本次操作的行为</p>
     */
    @NameInMap("action")
    public String action;

    /**
     * <p>生态唯一标识, 需要注册</p>
     */
    @NameInMap("appKey")
    public String appKey;

    /**
     * <p>审批状态</p>
     */
    @NameInMap("approveStatus")
    public String approveStatus;

    /**
     * <p>主数据名称</p>
     */
    @NameInMap("baseDataName")
    public String baseDataName;

    /**
     * <p>不良品总数(多次报工)</p>
     */
    @NameInMap("defectsAmount")
    public String defectsAmount;

    /**
     * <p>不良品原因</p>
     */
    @NameInMap("defectsReason")
    public String defectsReason;

    /**
     * <p>良品总数(多次报工)</p>
     */
    @NameInMap("fineAmount")
    public String fineAmount;

    /**
     * <p>是否已质检</p>
     */
    @NameInMap("hasQualityTest")
    public String hasQualityTest;

    /**
     * <p>任务逾期</p>
     */
    @NameInMap("overdue")
    public Integer overdue;

    /**
     * <p>派工(总)数</p>
     */
    @NameInMap("planQuantity")
    public Long planQuantity;

    /**
     * <p>是否加急</p>
     */
    @NameInMap("priority")
    public Integer priority;

    /**
     * <p>工序名称</p>
     */
    @NameInMap("processName")
    public String processName;

    /**
     * <p>工序业务唯一标识</p>
     */
    @NameInMap("processUuid")
    public String processUuid;

    /**
     * <p>产品编号(物料编号)</p>
     */
    @NameInMap("productCode")
    public String productCode;

    /**
     * <p>产品名称</p>
     */
    @NameInMap("productName")
    public String productName;

    /**
     * <p>产品(物料)规格</p>
     */
    @NameInMap("productSpecification")
    public String productSpecification;

    /**
     * <p>工单编号(生产任务单)</p>
     */
    @NameInMap("projectCode")
    public String projectCode;

    /**
     * <p>工单(生产计划单)</p>
     */
    @NameInMap("projectId")
    public String projectId;

    /**
     * <p>工单状态</p>
     */
    @NameInMap("projectStatus")
    public String projectStatus;

    /**
     * <p>检验状态</p>
     */
    @NameInMap("qualityTestStatus")
    public String qualityTestStatus;

    /**
     * <p>任务计划结束(完成)时间</p>
     */
    @NameInMap("taskPlanEndTime")
    public String taskPlanEndTime;

    /**
     * <p>任务计划开始时间</p>
     */
    @NameInMap("taskPlanStartTime")
    public String taskPlanStartTime;

    /**
     * <p>派工任务状态</p>
     */
    @NameInMap("taskStatus")
    public String taskStatus;

    /**
     * <p>报工类型(正常,委外)</p>
     */
    @NameInMap("taskType")
    public String taskType;

    /**
     * <p>派工任务唯一标识</p>
     */
    @NameInMap("taskUuid")
    public String taskUuid;

    /**
     * <p>负责班组id</p>
     */
    @NameInMap("teamId")
    public String teamId;

    /**
     * <p>报工人staffNo(生产人员)</p>
     */
    @NameInMap("userId")
    public String userId;

    /**
     * <p>派工人名称</p>
     */
    @NameInMap("userName")
    public String userName;

    /**
     * <p>本次记录唯一标识</p>
     */
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
