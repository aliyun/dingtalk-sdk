// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkindustry_1_0.models;

import com.aliyun.tea.*;

public class IndustryManufactureMesProductionPlanRequest extends TeaModel {
    // 本次操作的行为
    @NameInMap("action")
    public String action;

    // actualEndTime
    @NameInMap("actualEndTime")
    public String actualEndTime;

    // actualStartTime
    @NameInMap("actualStartTime")
    public String actualStartTime;

    // 生态唯一标识,枚举:opsoft， 需要注册
    @NameInMap("appKey")
    public String appKey;

    // 主数据名称
    @NameInMap("baseDataName")
    public String baseDataName;

    // BOM业务唯一标识
    @NameInMap("bomUuid")
    public String bomUuid;

    // 事件列表
    @NameInMap("events")
    public java.util.List<String> events;

    // 扩展字段
    @NameInMap("extendData")
    public java.util.List<IndustryManufactureMesProductionPlanRequestExtendData> extendData;

    // 工单编号(生产订单号)
    @NameInMap("no")
    public String no;

    // 任务逾期
    @NameInMap("overdue")
    public String overdue;

    // 计划结束时间
    @NameInMap("planEndTime")
    public String planEndTime;

    // 工单计划数
    @NameInMap("planQuantity")
    public String planQuantity;

    // 计划开始时间
    @NameInMap("planStartTime")
    public String planStartTime;

    // 工序列表(有序) 主体
    @NameInMap("processUuids")
    public String processUuids;

    // 产品代码(物料编号)
    @NameInMap("productCode")
    public String productCode;

    // 产品名称
    @NameInMap("productName")
    public String productName;

    // 规格型号
    @NameInMap("productSpecification")
    public String productSpecification;

    // 最后一道工序完成数量
    @NameInMap("qualifiedQuantity")
    public String qualifiedQuantity;

    // 销售订单
    @NameInMap("sellOrderNo")
    public String sellOrderNo;

    // 工单状态
    @NameInMap("status")
    public String status;

    // 班组信息(有序)
    @NameInMap("teamList")
    public String teamList;

    // 工单标题
    @NameInMap("title")
    public String title;

    // 工单类型,["NORMAL"(普通),"返工","样品"],默认"NORMAL"
    @NameInMap("type")
    public String type;

    // 单位
    @NameInMap("unit")
    public String unit;

    // 工单实例的唯一Id
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
        // 字段唯一标识(英文)
        @NameInMap("code")
        public String code;

        // 字段中文描述
        @NameInMap("name")
        public String name;

        // 当时取值(活的)
        @NameInMap("value")
        public String value;

        // 字段类型
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
