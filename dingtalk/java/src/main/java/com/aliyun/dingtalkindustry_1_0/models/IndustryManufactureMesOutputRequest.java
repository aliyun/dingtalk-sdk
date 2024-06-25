// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkindustry_1_0.models;

import com.aliyun.tea.*;

public class IndustryManufactureMesOutputRequest extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>add</p>
     */
    @NameInMap("action")
    public String action;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>opsoft</p>
     */
    @NameInMap("appKey")
    public String appKey;

    /**
     * <strong>example:</strong>
     * <p>AGREE</p>
     */
    @NameInMap("approveStatus")
    public String approveStatus;

    /**
     * <strong>example:</strong>
     * <p>output</p>
     */
    @NameInMap("baseDataName")
    public String baseDataName;

    /**
     * <strong>example:</strong>
     * <p>3</p>
     */
    @NameInMap("defectsAmount")
    public String defectsAmount;

    /**
     * <strong>example:</strong>
     * <p>[{&quot;count&quot;:10,&quot;reason&quot;:&quot;工废&quot;},{&quot;count&quot;:20,&quot;reason&quot;:&quot;料废&quot;}]</p>
     */
    @NameInMap("defectsReason")
    public String defectsReason;

    /**
     * <strong>example:</strong>
     * <p>20</p>
     */
    @NameInMap("fineAmount")
    public String fineAmount;

    /**
     * <strong>example:</strong>
     * <p>y</p>
     */
    @NameInMap("hasQualityTest")
    public String hasQualityTest;

    /**
     * <strong>example:</strong>
     * <p>1</p>
     */
    @NameInMap("overdue")
    public Integer overdue;

    /**
     * <strong>example:</strong>
     * <p>321</p>
     */
    @NameInMap("planQuantity")
    public Long planQuantity;

    /**
     * <strong>example:</strong>
     * <p>1</p>
     */
    @NameInMap("priority")
    public Integer priority;

    /**
     * <strong>example:</strong>
     * <p>打磨</p>
     */
    @NameInMap("processName")
    public String processName;

    /**
     * <strong>example:</strong>
     * <p>fsdfs3fsd2234wds</p>
     */
    @NameInMap("processUuid")
    public String processUuid;

    /**
     * <strong>example:</strong>
     * <p>dingfsdfs3fsd2234wds</p>
     */
    @NameInMap("productCode")
    public String productCode;

    /**
     * <strong>example:</strong>
     * <p>毛坯KM50二级盖</p>
     */
    @NameInMap("productName")
    public String productName;

    /**
     * <strong>example:</strong>
     * <p>20<em>20</em>3</p>
     */
    @NameInMap("productSpecification")
    public String productSpecification;

    /**
     * <strong>example:</strong>
     * <p>dingfsdfs3fsd2234wds</p>
     */
    @NameInMap("projectCode")
    public String projectCode;

    /**
     * <strong>example:</strong>
     * <p>0220423001</p>
     */
    @NameInMap("projectId")
    public String projectId;

    /**
     * <strong>example:</strong>
     * <p>WORKING</p>
     */
    @NameInMap("projectStatus")
    public String projectStatus;

    /**
     * <strong>example:</strong>
     * <p>VERIFIED</p>
     */
    @NameInMap("qualityTestStatus")
    public String qualityTestStatus;

    /**
     * <strong>example:</strong>
     * <p>2021-03-12 23:59:59</p>
     */
    @NameInMap("taskPlanEndTime")
    public String taskPlanEndTime;

    /**
     * <strong>example:</strong>
     * <p>2021-03-12 23:59:59</p>
     */
    @NameInMap("taskPlanStartTime")
    public String taskPlanStartTime;

    /**
     * <strong>example:</strong>
     * <p>WORKING</p>
     */
    @NameInMap("taskStatus")
    public String taskStatus;

    /**
     * <strong>example:</strong>
     * <p>NORMAL</p>
     */
    @NameInMap("taskType")
    public String taskType;

    /**
     * <strong>example:</strong>
     * <p>C1E213-86B2-706B-9615-5B957DF8C15D</p>
     */
    @NameInMap("taskUuid")
    public String taskUuid;

    /**
     * <strong>example:</strong>
     * <p>dfsdfs3fsd2234wds</p>
     */
    @NameInMap("teamId")
    public String teamId;

    /**
     * <strong>example:</strong>
     * <p>170000000332</p>
     */
    @NameInMap("userId")
    public String userId;

    /**
     * <strong>example:</strong>
     * <p>张三</p>
     */
    @NameInMap("userName")
    public String userName;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>fsdfs3fsd2234wds</p>
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
