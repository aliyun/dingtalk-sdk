// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkindustry_1_0.models;

import com.aliyun.tea.*;

public class IndustryManufactureMesProductionPlanRequest extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>add</p>
     */
    @NameInMap("action")
    public String action;

    /**
     * <strong>example:</strong>
     * <p>2021-03-12 00:00:00</p>
     */
    @NameInMap("actualEndTime")
    public String actualEndTime;

    /**
     * <strong>example:</strong>
     * <p>2021-03-12 00:00:00</p>
     */
    @NameInMap("actualStartTime")
    public String actualStartTime;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>opsoft</p>
     */
    @NameInMap("appKey")
    public String appKey;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>productionplan</p>
     */
    @NameInMap("baseDataName")
    public String baseDataName;

    /**
     * <strong>example:</strong>
     * <p>39C1E213-86B2-706B-9615-5B957DF8C15D</p>
     */
    @NameInMap("bomUuid")
    public String bomUuid;

    @NameInMap("events")
    public java.util.List<String> events;

    @NameInMap("extendData")
    public java.util.List<IndustryManufactureMesProductionPlanRequestExtendData> extendData;

    /**
     * <strong>example:</strong>
     * <p>20220509034</p>
     */
    @NameInMap("no")
    public String no;

    /**
     * <strong>example:</strong>
     * <p>0</p>
     */
    @NameInMap("overdue")
    public String overdue;

    /**
     * <strong>example:</strong>
     * <p>2021-03-12 00:00:00</p>
     */
    @NameInMap("planEndTime")
    public String planEndTime;

    /**
     * <strong>example:</strong>
     * <p>321</p>
     */
    @NameInMap("planQuantity")
    public String planQuantity;

    /**
     * <strong>example:</strong>
     * <p>2021-03-12 00:00:00</p>
     */
    @NameInMap("planStartTime")
    public String planStartTime;

    /**
     * <strong>example:</strong>
     * <p>{ TODO       &quot;uuid&quot;: &quot;1543878029722550273&quot;,       &quot;name&quot;: &quot;YF-钣金&quot;,       &quot;preProcess&quot;: &quot;&quot;     }</p>
     */
    @NameInMap("processUuids")
    public String processUuids;

    /**
     * <strong>example:</strong>
     * <p>011351</p>
     */
    @NameInMap("productCode")
    public String productCode;

    /**
     * <strong>example:</strong>
     * <p>毛坯KM50三级盖</p>
     */
    @NameInMap("productName")
    public String productName;

    /**
     * <strong>example:</strong>
     * <p>KM50</p>
     */
    @NameInMap("productSpecification")
    public String productSpecification;

    /**
     * <strong>example:</strong>
     * <p>300</p>
     */
    @NameInMap("qualifiedQuantity")
    public String qualifiedQuantity;

    /**
     * <strong>example:</strong>
     * <p>sell20220509034</p>
     */
    @NameInMap("sellOrderNo")
    public String sellOrderNo;

    /**
     * <strong>example:</strong>
     * <p>WORKING</p>
     */
    @NameInMap("status")
    public String status;

    /**
     * <strong>example:</strong>
     * <p>{     &quot;processId1&quot;: [&quot;teamId11&quot;, &quot;teamId12&quot;, &quot;teamId13&quot;],     &quot;processId2&quot;: [&quot;teamId21&quot;, &quot;teamId22&quot;, &quot;teamId23&quot;] }</p>
     */
    @NameInMap("teamList")
    public String teamList;

    /**
     * <strong>example:</strong>
     * <p>毛坯KM50三级盖</p>
     */
    @NameInMap("title")
    public String title;

    /**
     * <strong>example:</strong>
     * <p>NORMAL</p>
     */
    @NameInMap("type")
    public String type;

    /**
     * <strong>example:</strong>
     * <p>个</p>
     */
    @NameInMap("unit")
    public String unit;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>39C1E213-86B2-706B-9615-5B957DF8C15D</p>
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
         * <strong>example:</strong>
         * <p>staffName</p>
         */
        @NameInMap("code")
        public String code;

        /**
         * <strong>example:</strong>
         * <p>生产人员</p>
         */
        @NameInMap("name")
        public String name;

        /**
         * <strong>example:</strong>
         * <p>张三</p>
         */
        @NameInMap("value")
        public String value;

        /**
         * <strong>example:</strong>
         * <p>string</p>
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
