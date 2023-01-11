// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkindustry_1_0.models;

import com.aliyun.tea.*;

public class IndustryManufactureMesProductionPlanRequest extends TeaModel {
    /**
     * <p>本次操作的行为</p>
     */
    @NameInMap("action")
    public String action;

    /**
     * <p>actualEndTime</p>
     */
    @NameInMap("actualEndTime")
    public String actualEndTime;

    /**
     * <p>actualStartTime</p>
     */
    @NameInMap("actualStartTime")
    public String actualStartTime;

    /**
     * <p>生态唯一标识,枚举:opsoft， 需要注册</p>
     */
    @NameInMap("appKey")
    public String appKey;

    /**
     * <p>主数据名称</p>
     */
    @NameInMap("baseDataName")
    public String baseDataName;

    /**
     * <p>BOM业务唯一标识</p>
     */
    @NameInMap("bomUuid")
    public String bomUuid;

    /**
     * <p>事件列表</p>
     */
    @NameInMap("events")
    public java.util.List<String> events;

    /**
     * <p>扩展字段</p>
     */
    @NameInMap("extendData")
    public java.util.List<IndustryManufactureMesProductionPlanRequestExtendData> extendData;

    /**
     * <p>工单编号(生产订单号)</p>
     */
    @NameInMap("no")
    public String no;

    /**
     * <p>任务逾期</p>
     */
    @NameInMap("overdue")
    public String overdue;

    /**
     * <p>计划结束时间</p>
     */
    @NameInMap("planEndTime")
    public String planEndTime;

    /**
     * <p>工单计划数</p>
     */
    @NameInMap("planQuantity")
    public String planQuantity;

    /**
     * <p>计划开始时间</p>
     */
    @NameInMap("planStartTime")
    public String planStartTime;

    /**
     * <p>工序列表(有序) 主体</p>
     */
    @NameInMap("processUuids")
    public String processUuids;

    /**
     * <p>产品代码(物料编号)</p>
     */
    @NameInMap("productCode")
    public String productCode;

    /**
     * <p>产品名称</p>
     */
    @NameInMap("productName")
    public String productName;

    /**
     * <p>规格型号</p>
     */
    @NameInMap("productSpecification")
    public String productSpecification;

    /**
     * <p>最后一道工序完成数量</p>
     */
    @NameInMap("qualifiedQuantity")
    public String qualifiedQuantity;

    /**
     * <p>销售订单</p>
     */
    @NameInMap("sellOrderNo")
    public String sellOrderNo;

    /**
     * <p>工单状态</p>
     */
    @NameInMap("status")
    public String status;

    /**
     * <p>班组信息(有序)</p>
     */
    @NameInMap("teamList")
    public String teamList;

    /**
     * <p>工单标题</p>
     */
    @NameInMap("title")
    public String title;

    /**
     * <p>工单类型,["NORMAL"(普通),"返工","样品"],默认"NORMAL"</p>
     */
    @NameInMap("type")
    public String type;

    /**
     * <p>单位</p>
     */
    @NameInMap("unit")
    public String unit;

    /**
     * <p>工单实例的唯一Id</p>
     */
    @NameInMap("uuid")
    public String uuid;

    public static IndustryManufactureMesProductionPlanRequest build(java.util.Map<String, ?> map) throws Exception {
        IndustryManufactureMesProductionPlanRequest self = new IndustryManufactureMesProductionPlanRequest();
        return TeaModel.build(map, self);
    }

    public IndustryManufactureMesProductionPlanRequest setAction(String action) {
        this.action = action;
        return this;
    }
    public String getAction() {
        return this.action;
    }

    public IndustryManufactureMesProductionPlanRequest setActualEndTime(String actualEndTime) {
        this.actualEndTime = actualEndTime;
        return this;
    }
    public String getActualEndTime() {
        return this.actualEndTime;
    }

    public IndustryManufactureMesProductionPlanRequest setActualStartTime(String actualStartTime) {
        this.actualStartTime = actualStartTime;
        return this;
    }
    public String getActualStartTime() {
        return this.actualStartTime;
    }

    public IndustryManufactureMesProductionPlanRequest setAppKey(String appKey) {
        this.appKey = appKey;
        return this;
    }
    public String getAppKey() {
        return this.appKey;
    }

    public IndustryManufactureMesProductionPlanRequest setBaseDataName(String baseDataName) {
        this.baseDataName = baseDataName;
        return this;
    }
    public String getBaseDataName() {
        return this.baseDataName;
    }

    public IndustryManufactureMesProductionPlanRequest setBomUuid(String bomUuid) {
        this.bomUuid = bomUuid;
        return this;
    }
    public String getBomUuid() {
        return this.bomUuid;
    }

    public IndustryManufactureMesProductionPlanRequest setEvents(java.util.List<String> events) {
        this.events = events;
        return this;
    }
    public java.util.List<String> getEvents() {
        return this.events;
    }

    public IndustryManufactureMesProductionPlanRequest setExtendData(java.util.List<IndustryManufactureMesProductionPlanRequestExtendData> extendData) {
        this.extendData = extendData;
        return this;
    }
    public java.util.List<IndustryManufactureMesProductionPlanRequestExtendData> getExtendData() {
        return this.extendData;
    }

    public IndustryManufactureMesProductionPlanRequest setNo(String no) {
        this.no = no;
        return this;
    }
    public String getNo() {
        return this.no;
    }

    public IndustryManufactureMesProductionPlanRequest setOverdue(String overdue) {
        this.overdue = overdue;
        return this;
    }
    public String getOverdue() {
        return this.overdue;
    }

    public IndustryManufactureMesProductionPlanRequest setPlanEndTime(String planEndTime) {
        this.planEndTime = planEndTime;
        return this;
    }
    public String getPlanEndTime() {
        return this.planEndTime;
    }

    public IndustryManufactureMesProductionPlanRequest setPlanQuantity(String planQuantity) {
        this.planQuantity = planQuantity;
        return this;
    }
    public String getPlanQuantity() {
        return this.planQuantity;
    }

    public IndustryManufactureMesProductionPlanRequest setPlanStartTime(String planStartTime) {
        this.planStartTime = planStartTime;
        return this;
    }
    public String getPlanStartTime() {
        return this.planStartTime;
    }

    public IndustryManufactureMesProductionPlanRequest setProcessUuids(String processUuids) {
        this.processUuids = processUuids;
        return this;
    }
    public String getProcessUuids() {
        return this.processUuids;
    }

    public IndustryManufactureMesProductionPlanRequest setProductCode(String productCode) {
        this.productCode = productCode;
        return this;
    }
    public String getProductCode() {
        return this.productCode;
    }

    public IndustryManufactureMesProductionPlanRequest setProductName(String productName) {
        this.productName = productName;
        return this;
    }
    public String getProductName() {
        return this.productName;
    }

    public IndustryManufactureMesProductionPlanRequest setProductSpecification(String productSpecification) {
        this.productSpecification = productSpecification;
        return this;
    }
    public String getProductSpecification() {
        return this.productSpecification;
    }

    public IndustryManufactureMesProductionPlanRequest setQualifiedQuantity(String qualifiedQuantity) {
        this.qualifiedQuantity = qualifiedQuantity;
        return this;
    }
    public String getQualifiedQuantity() {
        return this.qualifiedQuantity;
    }

    public IndustryManufactureMesProductionPlanRequest setSellOrderNo(String sellOrderNo) {
        this.sellOrderNo = sellOrderNo;
        return this;
    }
    public String getSellOrderNo() {
        return this.sellOrderNo;
    }

    public IndustryManufactureMesProductionPlanRequest setStatus(String status) {
        this.status = status;
        return this;
    }
    public String getStatus() {
        return this.status;
    }

    public IndustryManufactureMesProductionPlanRequest setTeamList(String teamList) {
        this.teamList = teamList;
        return this;
    }
    public String getTeamList() {
        return this.teamList;
    }

    public IndustryManufactureMesProductionPlanRequest setTitle(String title) {
        this.title = title;
        return this;
    }
    public String getTitle() {
        return this.title;
    }

    public IndustryManufactureMesProductionPlanRequest setType(String type) {
        this.type = type;
        return this;
    }
    public String getType() {
        return this.type;
    }

    public IndustryManufactureMesProductionPlanRequest setUnit(String unit) {
        this.unit = unit;
        return this;
    }
    public String getUnit() {
        return this.unit;
    }

    public IndustryManufactureMesProductionPlanRequest setUuid(String uuid) {
        this.uuid = uuid;
        return this;
    }
    public String getUuid() {
        return this.uuid;
    }

    public static class IndustryManufactureMesProductionPlanRequestExtendData extends TeaModel {
        /**
         * <p>字段唯一标识(英文)</p>
         */
        @NameInMap("code")
        public String code;

        /**
         * <p>字段中文描述</p>
         */
        @NameInMap("name")
        public String name;

        /**
         * <p>当时取值(活的)</p>
         */
        @NameInMap("value")
        public String value;

        /**
         * <p>字段类型</p>
         */
        @NameInMap("valueType")
        public String valueType;

        public static IndustryManufactureMesProductionPlanRequestExtendData build(java.util.Map<String, ?> map) throws Exception {
            IndustryManufactureMesProductionPlanRequestExtendData self = new IndustryManufactureMesProductionPlanRequestExtendData();
            return TeaModel.build(map, self);
        }

        public IndustryManufactureMesProductionPlanRequestExtendData setCode(String code) {
            this.code = code;
            return this;
        }
        public String getCode() {
            return this.code;
        }

        public IndustryManufactureMesProductionPlanRequestExtendData setName(String name) {
            this.name = name;
            return this;
        }
        public String getName() {
            return this.name;
        }

        public IndustryManufactureMesProductionPlanRequestExtendData setValue(String value) {
            this.value = value;
            return this;
        }
        public String getValue() {
            return this.value;
        }

        public IndustryManufactureMesProductionPlanRequestExtendData setValueType(String valueType) {
            this.valueType = valueType;
            return this;
        }
        public String getValueType() {
            return this.valueType;
        }

    }

}
