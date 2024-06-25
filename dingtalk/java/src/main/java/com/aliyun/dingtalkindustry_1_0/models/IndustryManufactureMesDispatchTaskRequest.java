// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkindustry_1_0.models;

import com.aliyun.tea.*;

public class IndustryManufactureMesDispatchTaskRequest extends TeaModel {
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
     * <p>task</p>
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
     * <p>张三</p>
     */
    @NameInMap("dispatchStaffName")
    public String dispatchStaffName;

    /**
     * <strong>example:</strong>
     * <p>170000000332</p>
     */
    @NameInMap("dispatchStaffNo")
    public String dispatchStaffNo;

    /**
     * <strong>example:</strong>
     * <p>20</p>
     */
    @NameInMap("fineAmount")
    public String fineAmount;

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
     * <p>[{&quot;userId&quot;:&quot;123&quot;,&quot;name&quot;:&quot;汉俊&quot;,&quot;planQuantity&quot;:30}]</p>
     */
    @NameInMap("taskOperators")
    public String taskOperators;

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
     * <p>dfsdfs3fsd2234wds</p>
     */
    @NameInMap("teamId")
    public String teamId;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>fsdfs3fsd2234wds</p>
     */
    @NameInMap("uuid")
    public String uuid;

    public static IndustryManufactureMesDispatchTaskRequest build(java.util.Map<String, ?> map) throws Exception {
        IndustryManufactureMesDispatchTaskRequest self = new IndustryManufactureMesDispatchTaskRequest();
        return TeaModel.build(map, self);
    }

    public IndustryManufactureMesDispatchTaskRequest setAction(String action) {
        this.action = action;
        return this;
    }
    public String getAction() {
        return this.action;
    }

    public IndustryManufactureMesDispatchTaskRequest setAppKey(String appKey) {
        this.appKey = appKey;
        return this;
    }
    public String getAppKey() {
        return this.appKey;
    }

    public IndustryManufactureMesDispatchTaskRequest setBaseDataName(String baseDataName) {
        this.baseDataName = baseDataName;
        return this;
    }
    public String getBaseDataName() {
        return this.baseDataName;
    }

    public IndustryManufactureMesDispatchTaskRequest setDefectsAmount(String defectsAmount) {
        this.defectsAmount = defectsAmount;
        return this;
    }
    public String getDefectsAmount() {
        return this.defectsAmount;
    }

    public IndustryManufactureMesDispatchTaskRequest setDispatchStaffName(String dispatchStaffName) {
        this.dispatchStaffName = dispatchStaffName;
        return this;
    }
    public String getDispatchStaffName() {
        return this.dispatchStaffName;
    }

    public IndustryManufactureMesDispatchTaskRequest setDispatchStaffNo(String dispatchStaffNo) {
        this.dispatchStaffNo = dispatchStaffNo;
        return this;
    }
    public String getDispatchStaffNo() {
        return this.dispatchStaffNo;
    }

    public IndustryManufactureMesDispatchTaskRequest setFineAmount(String fineAmount) {
        this.fineAmount = fineAmount;
        return this;
    }
    public String getFineAmount() {
        return this.fineAmount;
    }

    public IndustryManufactureMesDispatchTaskRequest setOverdue(Integer overdue) {
        this.overdue = overdue;
        return this;
    }
    public Integer getOverdue() {
        return this.overdue;
    }

    public IndustryManufactureMesDispatchTaskRequest setPlanQuantity(Long planQuantity) {
        this.planQuantity = planQuantity;
        return this;
    }
    public Long getPlanQuantity() {
        return this.planQuantity;
    }

    public IndustryManufactureMesDispatchTaskRequest setPriority(Integer priority) {
        this.priority = priority;
        return this;
    }
    public Integer getPriority() {
        return this.priority;
    }

    public IndustryManufactureMesDispatchTaskRequest setProcessName(String processName) {
        this.processName = processName;
        return this;
    }
    public String getProcessName() {
        return this.processName;
    }

    public IndustryManufactureMesDispatchTaskRequest setProcessUuid(String processUuid) {
        this.processUuid = processUuid;
        return this;
    }
    public String getProcessUuid() {
        return this.processUuid;
    }

    public IndustryManufactureMesDispatchTaskRequest setProductCode(String productCode) {
        this.productCode = productCode;
        return this;
    }
    public String getProductCode() {
        return this.productCode;
    }

    public IndustryManufactureMesDispatchTaskRequest setProductName(String productName) {
        this.productName = productName;
        return this;
    }
    public String getProductName() {
        return this.productName;
    }

    public IndustryManufactureMesDispatchTaskRequest setProductSpecification(String productSpecification) {
        this.productSpecification = productSpecification;
        return this;
    }
    public String getProductSpecification() {
        return this.productSpecification;
    }

    public IndustryManufactureMesDispatchTaskRequest setProjectCode(String projectCode) {
        this.projectCode = projectCode;
        return this;
    }
    public String getProjectCode() {
        return this.projectCode;
    }

    public IndustryManufactureMesDispatchTaskRequest setProjectId(String projectId) {
        this.projectId = projectId;
        return this;
    }
    public String getProjectId() {
        return this.projectId;
    }

    public IndustryManufactureMesDispatchTaskRequest setProjectStatus(String projectStatus) {
        this.projectStatus = projectStatus;
        return this;
    }
    public String getProjectStatus() {
        return this.projectStatus;
    }

    public IndustryManufactureMesDispatchTaskRequest setTaskOperators(String taskOperators) {
        this.taskOperators = taskOperators;
        return this;
    }
    public String getTaskOperators() {
        return this.taskOperators;
    }

    public IndustryManufactureMesDispatchTaskRequest setTaskPlanEndTime(String taskPlanEndTime) {
        this.taskPlanEndTime = taskPlanEndTime;
        return this;
    }
    public String getTaskPlanEndTime() {
        return this.taskPlanEndTime;
    }

    public IndustryManufactureMesDispatchTaskRequest setTaskPlanStartTime(String taskPlanStartTime) {
        this.taskPlanStartTime = taskPlanStartTime;
        return this;
    }
    public String getTaskPlanStartTime() {
        return this.taskPlanStartTime;
    }

    public IndustryManufactureMesDispatchTaskRequest setTaskStatus(String taskStatus) {
        this.taskStatus = taskStatus;
        return this;
    }
    public String getTaskStatus() {
        return this.taskStatus;
    }

    public IndustryManufactureMesDispatchTaskRequest setTaskType(String taskType) {
        this.taskType = taskType;
        return this;
    }
    public String getTaskType() {
        return this.taskType;
    }

    public IndustryManufactureMesDispatchTaskRequest setTeamId(String teamId) {
        this.teamId = teamId;
        return this;
    }
    public String getTeamId() {
        return this.teamId;
    }

    public IndustryManufactureMesDispatchTaskRequest setUuid(String uuid) {
        this.uuid = uuid;
        return this;
    }
    public String getUuid() {
        return this.uuid;
    }

}
