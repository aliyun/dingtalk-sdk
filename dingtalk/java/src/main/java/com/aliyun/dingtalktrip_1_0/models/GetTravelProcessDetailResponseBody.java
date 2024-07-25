// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalktrip_1_0.models;

import com.aliyun.tea.*;

public class GetTravelProcessDetailResponseBody extends TeaModel {
    @NameInMap("result")
    public GetTravelProcessDetailResponseBodyResult result;

    @NameInMap("success")
    public Boolean success;

    public static GetTravelProcessDetailResponseBody build(java.util.Map<String, ?> map) throws Exception {
        GetTravelProcessDetailResponseBody self = new GetTravelProcessDetailResponseBody();
        return TeaModel.build(map, self);
    }

    public GetTravelProcessDetailResponseBody setResult(GetTravelProcessDetailResponseBodyResult result) {
        this.result = result;
        return this;
    }
    public GetTravelProcessDetailResponseBodyResult getResult() {
        return this.result;
    }

    public GetTravelProcessDetailResponseBody setSuccess(Boolean success) {
        this.success = success;
        return this;
    }
    public Boolean getSuccess() {
        return this.success;
    }

    public static class GetTravelProcessDetailResponseBodyResultExtFormComponent extends TeaModel {
        /**
         * <strong>example:</strong>
         * <p>&quot;&quot;</p>
         */
        @NameInMap("bizAlias")
        public String bizAlias;

        /**
         * <strong>example:</strong>
         * <p>MoneyField</p>
         */
        @NameInMap("componentType")
        public String componentType;

        /**
         * <strong>example:</strong>
         * <p>&quot;{&quot;upper&quot;:&quot;玖元玖角玖分&quot;,&quot;componentName&quot;:&quot;MoneyField&quot;}&quot;</p>
         */
        @NameInMap("extValue")
        public String extValue;

        /**
         * <strong>example:</strong>
         * <p>MoneyField_18PDM5K773FK0</p>
         */
        @NameInMap("id")
        public String id;

        /**
         * <strong>example:</strong>
         * <p>预估金额</p>
         */
        @NameInMap("name")
        public String name;

        /**
         * <strong>example:</strong>
         * <p>9.99</p>
         */
        @NameInMap("value")
        public String value;

        public static GetTravelProcessDetailResponseBodyResultExtFormComponent build(java.util.Map<String, ?> map) throws Exception {
            GetTravelProcessDetailResponseBodyResultExtFormComponent self = new GetTravelProcessDetailResponseBodyResultExtFormComponent();
            return TeaModel.build(map, self);
        }

        public GetTravelProcessDetailResponseBodyResultExtFormComponent setBizAlias(String bizAlias) {
            this.bizAlias = bizAlias;
            return this;
        }
        public String getBizAlias() {
            return this.bizAlias;
        }

        public GetTravelProcessDetailResponseBodyResultExtFormComponent setComponentType(String componentType) {
            this.componentType = componentType;
            return this;
        }
        public String getComponentType() {
            return this.componentType;
        }

        public GetTravelProcessDetailResponseBodyResultExtFormComponent setExtValue(String extValue) {
            this.extValue = extValue;
            return this;
        }
        public String getExtValue() {
            return this.extValue;
        }

        public GetTravelProcessDetailResponseBodyResultExtFormComponent setId(String id) {
            this.id = id;
            return this;
        }
        public String getId() {
            return this.id;
        }

        public GetTravelProcessDetailResponseBodyResultExtFormComponent setName(String name) {
            this.name = name;
            return this;
        }
        public String getName() {
            return this.name;
        }

        public GetTravelProcessDetailResponseBodyResultExtFormComponent setValue(String value) {
            this.value = value;
            return this;
        }
        public String getValue() {
            return this.value;
        }

    }

    public static class GetTravelProcessDetailResponseBodyResultJourneysArrival extends TeaModel {
        /**
         * <strong>example:</strong>
         * <p>TSN</p>
         */
        @NameInMap("code")
        public String code;

        /**
         * <strong>example:</strong>
         * <p>CN</p>
         */
        @NameInMap("countryCode")
        public String countryCode;

        /**
         * <strong>example:</strong>
         * <p>中国</p>
         */
        @NameInMap("countryName")
        public String countryName;

        /**
         * <strong>example:</strong>
         * <p>天津市</p>
         */
        @NameInMap("name")
        public String name;

        /**
         * <strong>example:</strong>
         * <p>120000</p>
         */
        @NameInMap("nationalCityCode")
        public String nationalCityCode;

        public static GetTravelProcessDetailResponseBodyResultJourneysArrival build(java.util.Map<String, ?> map) throws Exception {
            GetTravelProcessDetailResponseBodyResultJourneysArrival self = new GetTravelProcessDetailResponseBodyResultJourneysArrival();
            return TeaModel.build(map, self);
        }

        public GetTravelProcessDetailResponseBodyResultJourneysArrival setCode(String code) {
            this.code = code;
            return this;
        }
        public String getCode() {
            return this.code;
        }

        public GetTravelProcessDetailResponseBodyResultJourneysArrival setCountryCode(String countryCode) {
            this.countryCode = countryCode;
            return this;
        }
        public String getCountryCode() {
            return this.countryCode;
        }

        public GetTravelProcessDetailResponseBodyResultJourneysArrival setCountryName(String countryName) {
            this.countryName = countryName;
            return this;
        }
        public String getCountryName() {
            return this.countryName;
        }

        public GetTravelProcessDetailResponseBodyResultJourneysArrival setName(String name) {
            this.name = name;
            return this;
        }
        public String getName() {
            return this.name;
        }

        public GetTravelProcessDetailResponseBodyResultJourneysArrival setNationalCityCode(String nationalCityCode) {
            this.nationalCityCode = nationalCityCode;
            return this;
        }
        public String getNationalCityCode() {
            return this.nationalCityCode;
        }

    }

    public static class GetTravelProcessDetailResponseBodyResultJourneysDeparture extends TeaModel {
        /**
         * <strong>example:</strong>
         * <p>BJK</p>
         */
        @NameInMap("code")
        public String code;

        /**
         * <strong>example:</strong>
         * <p>CN</p>
         */
        @NameInMap("countryCode")
        public String countryCode;

        /**
         * <strong>example:</strong>
         * <p>中国</p>
         */
        @NameInMap("countryName")
        public String countryName;

        /**
         * <strong>example:</strong>
         * <p>北京市</p>
         */
        @NameInMap("name")
        public String name;

        /**
         * <strong>example:</strong>
         * <p>110000</p>
         */
        @NameInMap("nationalCityCode")
        public String nationalCityCode;

        public static GetTravelProcessDetailResponseBodyResultJourneysDeparture build(java.util.Map<String, ?> map) throws Exception {
            GetTravelProcessDetailResponseBodyResultJourneysDeparture self = new GetTravelProcessDetailResponseBodyResultJourneysDeparture();
            return TeaModel.build(map, self);
        }

        public GetTravelProcessDetailResponseBodyResultJourneysDeparture setCode(String code) {
            this.code = code;
            return this;
        }
        public String getCode() {
            return this.code;
        }

        public GetTravelProcessDetailResponseBodyResultJourneysDeparture setCountryCode(String countryCode) {
            this.countryCode = countryCode;
            return this;
        }
        public String getCountryCode() {
            return this.countryCode;
        }

        public GetTravelProcessDetailResponseBodyResultJourneysDeparture setCountryName(String countryName) {
            this.countryName = countryName;
            return this;
        }
        public String getCountryName() {
            return this.countryName;
        }

        public GetTravelProcessDetailResponseBodyResultJourneysDeparture setName(String name) {
            this.name = name;
            return this;
        }
        public String getName() {
            return this.name;
        }

        public GetTravelProcessDetailResponseBodyResultJourneysDeparture setNationalCityCode(String nationalCityCode) {
            this.nationalCityCode = nationalCityCode;
            return this;
        }
        public String getNationalCityCode() {
            return this.nationalCityCode;
        }

    }

    public static class GetTravelProcessDetailResponseBodyResultJourneys extends TeaModel {
        @NameInMap("arrival")
        public GetTravelProcessDetailResponseBodyResultJourneysArrival arrival;

        /**
         * <strong>example:</strong>
         * <p>成本中心一</p>
         */
        @NameInMap("costCenter")
        public String costCenter;

        /**
         * <strong>example:</strong>
         * <p>123</p>
         */
        @NameInMap("costCenterId")
        public String costCenterId;

        /**
         * <strong>example:</strong>
         * <p>c00001</p>
         */
        @NameInMap("costCenterThirdPartyId")
        public String costCenterThirdPartyId;

        @NameInMap("departure")
        public GetTravelProcessDetailResponseBodyResultJourneysDeparture departure;

        /**
         * <strong>example:</strong>
         * <p>2023-10-25</p>
         */
        @NameInMap("endTime")
        public String endTime;

        /**
         * <strong>example:</strong>
         * <p>2024-03-12 10:54:00</p>
         */
        @NameInMap("endTimeAcc")
        public String endTimeAcc;

        /**
         * <strong>example:</strong>
         * <p>发票抬头一</p>
         */
        @NameInMap("invoiceTitle")
        public String invoiceTitle;

        /**
         * <strong>example:</strong>
         * <p>123</p>
         */
        @NameInMap("invoiceTitleId")
        public String invoiceTitleId;

        /**
         * <strong>example:</strong>
         * <p>i0001</p>
         */
        @NameInMap("invoiceTitleThirdPartyId")
        public String invoiceTitleThirdPartyId;

        /**
         * <strong>example:</strong>
         * <p>费用归属项目一</p>
         */
        @NameInMap("itineraryProject")
        public String itineraryProject;

        /**
         * <strong>example:</strong>
         * <p>123</p>
         */
        @NameInMap("itineraryProjectId")
        public String itineraryProjectId;

        /**
         * <strong>example:</strong>
         * <p>y00001</p>
         */
        @NameInMap("itineraryProjectThirdPartyId")
        public String itineraryProjectThirdPartyId;

        /**
         * <strong>example:</strong>
         * <p>123455xxxxxxxx</p>
         */
        @NameInMap("journeyBizNo")
        public String journeyBizNo;

        /**
         * <strong>example:</strong>
         * <p>2023-10-20</p>
         */
        @NameInMap("startTime")
        public String startTime;

        /**
         * <strong>example:</strong>
         * <p>2024-03-12 10:54:00</p>
         */
        @NameInMap("startTimeAcc")
        public String startTimeAcc;

        /**
         * <strong>example:</strong>
         * <p>天</p>
         */
        @NameInMap("timeUnit")
        public String timeUnit;

        /**
         * <strong>example:</strong>
         * <p>飞机</p>
         */
        @NameInMap("travelType")
        public String travelType;

        /**
         * <strong>example:</strong>
         * <p>单程</p>
         */
        @NameInMap("tripWay")
        public String tripWay;

        public static GetTravelProcessDetailResponseBodyResultJourneys build(java.util.Map<String, ?> map) throws Exception {
            GetTravelProcessDetailResponseBodyResultJourneys self = new GetTravelProcessDetailResponseBodyResultJourneys();
            return TeaModel.build(map, self);
        }

        public GetTravelProcessDetailResponseBodyResultJourneys setArrival(GetTravelProcessDetailResponseBodyResultJourneysArrival arrival) {
            this.arrival = arrival;
            return this;
        }
        public GetTravelProcessDetailResponseBodyResultJourneysArrival getArrival() {
            return this.arrival;
        }

        public GetTravelProcessDetailResponseBodyResultJourneys setCostCenter(String costCenter) {
            this.costCenter = costCenter;
            return this;
        }
        public String getCostCenter() {
            return this.costCenter;
        }

        public GetTravelProcessDetailResponseBodyResultJourneys setCostCenterId(String costCenterId) {
            this.costCenterId = costCenterId;
            return this;
        }
        public String getCostCenterId() {
            return this.costCenterId;
        }

        public GetTravelProcessDetailResponseBodyResultJourneys setCostCenterThirdPartyId(String costCenterThirdPartyId) {
            this.costCenterThirdPartyId = costCenterThirdPartyId;
            return this;
        }
        public String getCostCenterThirdPartyId() {
            return this.costCenterThirdPartyId;
        }

        public GetTravelProcessDetailResponseBodyResultJourneys setDeparture(GetTravelProcessDetailResponseBodyResultJourneysDeparture departure) {
            this.departure = departure;
            return this;
        }
        public GetTravelProcessDetailResponseBodyResultJourneysDeparture getDeparture() {
            return this.departure;
        }

        public GetTravelProcessDetailResponseBodyResultJourneys setEndTime(String endTime) {
            this.endTime = endTime;
            return this;
        }
        public String getEndTime() {
            return this.endTime;
        }

        public GetTravelProcessDetailResponseBodyResultJourneys setEndTimeAcc(String endTimeAcc) {
            this.endTimeAcc = endTimeAcc;
            return this;
        }
        public String getEndTimeAcc() {
            return this.endTimeAcc;
        }

        public GetTravelProcessDetailResponseBodyResultJourneys setInvoiceTitle(String invoiceTitle) {
            this.invoiceTitle = invoiceTitle;
            return this;
        }
        public String getInvoiceTitle() {
            return this.invoiceTitle;
        }

        public GetTravelProcessDetailResponseBodyResultJourneys setInvoiceTitleId(String invoiceTitleId) {
            this.invoiceTitleId = invoiceTitleId;
            return this;
        }
        public String getInvoiceTitleId() {
            return this.invoiceTitleId;
        }

        public GetTravelProcessDetailResponseBodyResultJourneys setInvoiceTitleThirdPartyId(String invoiceTitleThirdPartyId) {
            this.invoiceTitleThirdPartyId = invoiceTitleThirdPartyId;
            return this;
        }
        public String getInvoiceTitleThirdPartyId() {
            return this.invoiceTitleThirdPartyId;
        }

        public GetTravelProcessDetailResponseBodyResultJourneys setItineraryProject(String itineraryProject) {
            this.itineraryProject = itineraryProject;
            return this;
        }
        public String getItineraryProject() {
            return this.itineraryProject;
        }

        public GetTravelProcessDetailResponseBodyResultJourneys setItineraryProjectId(String itineraryProjectId) {
            this.itineraryProjectId = itineraryProjectId;
            return this;
        }
        public String getItineraryProjectId() {
            return this.itineraryProjectId;
        }

        public GetTravelProcessDetailResponseBodyResultJourneys setItineraryProjectThirdPartyId(String itineraryProjectThirdPartyId) {
            this.itineraryProjectThirdPartyId = itineraryProjectThirdPartyId;
            return this;
        }
        public String getItineraryProjectThirdPartyId() {
            return this.itineraryProjectThirdPartyId;
        }

        public GetTravelProcessDetailResponseBodyResultJourneys setJourneyBizNo(String journeyBizNo) {
            this.journeyBizNo = journeyBizNo;
            return this;
        }
        public String getJourneyBizNo() {
            return this.journeyBizNo;
        }

        public GetTravelProcessDetailResponseBodyResultJourneys setStartTime(String startTime) {
            this.startTime = startTime;
            return this;
        }
        public String getStartTime() {
            return this.startTime;
        }

        public GetTravelProcessDetailResponseBodyResultJourneys setStartTimeAcc(String startTimeAcc) {
            this.startTimeAcc = startTimeAcc;
            return this;
        }
        public String getStartTimeAcc() {
            return this.startTimeAcc;
        }

        public GetTravelProcessDetailResponseBodyResultJourneys setTimeUnit(String timeUnit) {
            this.timeUnit = timeUnit;
            return this;
        }
        public String getTimeUnit() {
            return this.timeUnit;
        }

        public GetTravelProcessDetailResponseBodyResultJourneys setTravelType(String travelType) {
            this.travelType = travelType;
            return this;
        }
        public String getTravelType() {
            return this.travelType;
        }

        public GetTravelProcessDetailResponseBodyResultJourneys setTripWay(String tripWay) {
            this.tripWay = tripWay;
            return this;
        }
        public String getTripWay() {
            return this.tripWay;
        }

    }

    public static class GetTravelProcessDetailResponseBodyResultTasks extends TeaModel {
        /**
         * <strong>example:</strong>
         * <p>1918_5cd3</p>
         */
        @NameInMap("activityId")
        public String activityId;

        /**
         * <strong>example:</strong>
         * <p>2024-07-01 00:00:00</p>
         */
        @NameInMap("createTime")
        public String createTime;

        /**
         * <strong>example:</strong>
         * <p>2024-07-01 01:00:00</p>
         */
        @NameInMap("finishTime")
        public String finishTime;

        /**
         * <strong>example:</strong>
         * <p>12374</p>
         */
        @NameInMap("originUserId")
        public String originUserId;

        /**
         * <strong>example:</strong>
         * <p>e7fh112WTTawy6dLtiIlqQ10051721014983</p>
         */
        @NameInMap("processInstanceId")
        public String processInstanceId;

        /**
         * <strong>example:</strong>
         * <p>AGREE</p>
         */
        @NameInMap("result")
        public String result;

        /**
         * <strong>example:</strong>
         * <p>COMPLETED</p>
         */
        @NameInMap("status")
        public String status;

        /**
         * <strong>example:</strong>
         * <p>87882310449</p>
         */
        @NameInMap("taskId")
        public Long taskId;

        /**
         * <strong>example:</strong>
         * <p>aflow.dingtalk.com?procInsId=xxx&amp;taskId=yyy&amp;businessId=zzz</p>
         */
        @NameInMap("url")
        public String url;

        /**
         * <strong>example:</strong>
         * <p>2220314</p>
         */
        @NameInMap("userId")
        public String userId;

        public static GetTravelProcessDetailResponseBodyResultTasks build(java.util.Map<String, ?> map) throws Exception {
            GetTravelProcessDetailResponseBodyResultTasks self = new GetTravelProcessDetailResponseBodyResultTasks();
            return TeaModel.build(map, self);
        }

        public GetTravelProcessDetailResponseBodyResultTasks setActivityId(String activityId) {
            this.activityId = activityId;
            return this;
        }
        public String getActivityId() {
            return this.activityId;
        }

        public GetTravelProcessDetailResponseBodyResultTasks setCreateTime(String createTime) {
            this.createTime = createTime;
            return this;
        }
        public String getCreateTime() {
            return this.createTime;
        }

        public GetTravelProcessDetailResponseBodyResultTasks setFinishTime(String finishTime) {
            this.finishTime = finishTime;
            return this;
        }
        public String getFinishTime() {
            return this.finishTime;
        }

        public GetTravelProcessDetailResponseBodyResultTasks setOriginUserId(String originUserId) {
            this.originUserId = originUserId;
            return this;
        }
        public String getOriginUserId() {
            return this.originUserId;
        }

        public GetTravelProcessDetailResponseBodyResultTasks setProcessInstanceId(String processInstanceId) {
            this.processInstanceId = processInstanceId;
            return this;
        }
        public String getProcessInstanceId() {
            return this.processInstanceId;
        }

        public GetTravelProcessDetailResponseBodyResultTasks setResult(String result) {
            this.result = result;
            return this;
        }
        public String getResult() {
            return this.result;
        }

        public GetTravelProcessDetailResponseBodyResultTasks setStatus(String status) {
            this.status = status;
            return this;
        }
        public String getStatus() {
            return this.status;
        }

        public GetTravelProcessDetailResponseBodyResultTasks setTaskId(Long taskId) {
            this.taskId = taskId;
            return this;
        }
        public Long getTaskId() {
            return this.taskId;
        }

        public GetTravelProcessDetailResponseBodyResultTasks setUrl(String url) {
            this.url = url;
            return this;
        }
        public String getUrl() {
            return this.url;
        }

        public GetTravelProcessDetailResponseBodyResultTasks setUserId(String userId) {
            this.userId = userId;
            return this;
        }
        public String getUserId() {
            return this.userId;
        }

    }

    public static class GetTravelProcessDetailResponseBodyResult extends TeaModel {
        /**
         * <strong>example:</strong>
         * <p>2024-07-18 00:00:00</p>
         */
        @NameInMap("archiveTime")
        public String archiveTime;

        /**
         * <strong>example:</strong>
         * <p>alitrip.business</p>
         */
        @NameInMap("bizCategoryId")
        public String bizCategoryId;

        /**
         * <strong>example:</strong>
         * <p>202310231720000276784</p>
         */
        @NameInMap("businessId")
        public String businessId;

        /**
         * <strong>example:</strong>
         * <p>ding123456xxxx</p>
         */
        @NameInMap("corpId")
        public String corpId;

        /**
         * <strong>example:</strong>
         * <p>it成本中心</p>
         */
        @NameInMap("costCenter")
        public String costCenter;

        /**
         * <strong>example:</strong>
         * <p>成本中心id</p>
         */
        @NameInMap("costCenterId")
        public String costCenterId;

        /**
         * <strong>example:</strong>
         * <p>c00001</p>
         */
        @NameInMap("costCenterThirdPartyId")
        public String costCenterThirdPartyId;

        /**
         * <strong>example:</strong>
         * <p>2024-03-18 17:07:00</p>
         */
        @NameInMap("createTime")
        public String createTime;

        @NameInMap("extFormComponent")
        public java.util.List<GetTravelProcessDetailResponseBodyResultExtFormComponent> extFormComponent;

        /**
         * <strong>example:</strong>
         * <p>部门费用</p>
         */
        @NameInMap("feeType")
        public String feeType;

        /**
         * <strong>example:</strong>
         * <p>发票抬头</p>
         */
        @NameInMap("invoiceTitle")
        public String invoiceTitle;

        /**
         * <strong>example:</strong>
         * <p>发票抬头id</p>
         */
        @NameInMap("invoiceTitleId")
        public String invoiceTitleId;

        /**
         * <strong>example:</strong>
         * <p>i0001</p>
         */
        @NameInMap("invoiceTitleThirdPartyId")
        public String invoiceTitleThirdPartyId;

        /**
         * <strong>example:</strong>
         * <p>电商对接项目</p>
         */
        @NameInMap("itineraryProject")
        public String itineraryProject;

        /**
         * <strong>example:</strong>
         * <p>y00001</p>
         */
        @NameInMap("itineraryProjectThirdPartyId")
        public String itineraryProjectThirdPartyId;

        @NameInMap("journeys")
        public java.util.List<GetTravelProcessDetailResponseBodyResultJourneys> journeys;

        /**
         * <strong>example:</strong>
         * <p>AG3WERxWRFex63xxxxx</p>
         */
        @NameInMap("mainProcessInstanceId")
        public String mainProcessInstanceId;

        /**
         * <strong>example:</strong>
         * <p>坐飞机出差</p>
         */
        @NameInMap("memo")
        public String memo;

        /**
         * <strong>example:</strong>
         * <p>staffidxxxxx</p>
         */
        @NameInMap("originatorId")
        public String originatorId;

        /**
         * <strong>example:</strong>
         * <p>staffIdxyy</p>
         */
        @NameInMap("originatorIdOnBehalf")
        public String originatorIdOnBehalf;

        /**
         * <strong>example:</strong>
         * <p>AG3U12xWRFex63hxxxxx</p>
         */
        @NameInMap("processInstanceId")
        public String processInstanceId;

        /**
         * <strong>example:</strong>
         * <p>agree</p>
         */
        @NameInMap("processResult")
        public String processResult;

        /**
         * <strong>example:</strong>
         * <p>COMPLETED</p>
         */
        @NameInMap("processStatus")
        public String processStatus;

        /**
         * <strong>example:</strong>
         * <p>因公出差</p>
         */
        @NameInMap("remark")
        public String remark;

        @NameInMap("tasks")
        public java.util.List<GetTravelProcessDetailResponseBodyResultTasks> tasks;

        /**
         * <strong>example:</strong>
         * <p>费用归属部门</p>
         */
        @NameInMap("travelCategory")
        public String travelCategory;

        @NameInMap("travelers")
        public java.util.List<String> travelers;

        /**
         * <strong>example:</strong>
         * <p>2</p>
         */
        @NameInMap("tripDays")
        public String tripDays;

        public static GetTravelProcessDetailResponseBodyResult build(java.util.Map<String, ?> map) throws Exception {
            GetTravelProcessDetailResponseBodyResult self = new GetTravelProcessDetailResponseBodyResult();
            return TeaModel.build(map, self);
        }

        public GetTravelProcessDetailResponseBodyResult setArchiveTime(String archiveTime) {
            this.archiveTime = archiveTime;
            return this;
        }
        public String getArchiveTime() {
            return this.archiveTime;
        }

        public GetTravelProcessDetailResponseBodyResult setBizCategoryId(String bizCategoryId) {
            this.bizCategoryId = bizCategoryId;
            return this;
        }
        public String getBizCategoryId() {
            return this.bizCategoryId;
        }

        public GetTravelProcessDetailResponseBodyResult setBusinessId(String businessId) {
            this.businessId = businessId;
            return this;
        }
        public String getBusinessId() {
            return this.businessId;
        }

        public GetTravelProcessDetailResponseBodyResult setCorpId(String corpId) {
            this.corpId = corpId;
            return this;
        }
        public String getCorpId() {
            return this.corpId;
        }

        public GetTravelProcessDetailResponseBodyResult setCostCenter(String costCenter) {
            this.costCenter = costCenter;
            return this;
        }
        public String getCostCenter() {
            return this.costCenter;
        }

        public GetTravelProcessDetailResponseBodyResult setCostCenterId(String costCenterId) {
            this.costCenterId = costCenterId;
            return this;
        }
        public String getCostCenterId() {
            return this.costCenterId;
        }

        public GetTravelProcessDetailResponseBodyResult setCostCenterThirdPartyId(String costCenterThirdPartyId) {
            this.costCenterThirdPartyId = costCenterThirdPartyId;
            return this;
        }
        public String getCostCenterThirdPartyId() {
            return this.costCenterThirdPartyId;
        }

        public GetTravelProcessDetailResponseBodyResult setCreateTime(String createTime) {
            this.createTime = createTime;
            return this;
        }
        public String getCreateTime() {
            return this.createTime;
        }

        public GetTravelProcessDetailResponseBodyResult setExtFormComponent(java.util.List<GetTravelProcessDetailResponseBodyResultExtFormComponent> extFormComponent) {
            this.extFormComponent = extFormComponent;
            return this;
        }
        public java.util.List<GetTravelProcessDetailResponseBodyResultExtFormComponent> getExtFormComponent() {
            return this.extFormComponent;
        }

        public GetTravelProcessDetailResponseBodyResult setFeeType(String feeType) {
            this.feeType = feeType;
            return this;
        }
        public String getFeeType() {
            return this.feeType;
        }

        public GetTravelProcessDetailResponseBodyResult setInvoiceTitle(String invoiceTitle) {
            this.invoiceTitle = invoiceTitle;
            return this;
        }
        public String getInvoiceTitle() {
            return this.invoiceTitle;
        }

        public GetTravelProcessDetailResponseBodyResult setInvoiceTitleId(String invoiceTitleId) {
            this.invoiceTitleId = invoiceTitleId;
            return this;
        }
        public String getInvoiceTitleId() {
            return this.invoiceTitleId;
        }

        public GetTravelProcessDetailResponseBodyResult setInvoiceTitleThirdPartyId(String invoiceTitleThirdPartyId) {
            this.invoiceTitleThirdPartyId = invoiceTitleThirdPartyId;
            return this;
        }
        public String getInvoiceTitleThirdPartyId() {
            return this.invoiceTitleThirdPartyId;
        }

        public GetTravelProcessDetailResponseBodyResult setItineraryProject(String itineraryProject) {
            this.itineraryProject = itineraryProject;
            return this;
        }
        public String getItineraryProject() {
            return this.itineraryProject;
        }

        public GetTravelProcessDetailResponseBodyResult setItineraryProjectThirdPartyId(String itineraryProjectThirdPartyId) {
            this.itineraryProjectThirdPartyId = itineraryProjectThirdPartyId;
            return this;
        }
        public String getItineraryProjectThirdPartyId() {
            return this.itineraryProjectThirdPartyId;
        }

        public GetTravelProcessDetailResponseBodyResult setJourneys(java.util.List<GetTravelProcessDetailResponseBodyResultJourneys> journeys) {
            this.journeys = journeys;
            return this;
        }
        public java.util.List<GetTravelProcessDetailResponseBodyResultJourneys> getJourneys() {
            return this.journeys;
        }

        public GetTravelProcessDetailResponseBodyResult setMainProcessInstanceId(String mainProcessInstanceId) {
            this.mainProcessInstanceId = mainProcessInstanceId;
            return this;
        }
        public String getMainProcessInstanceId() {
            return this.mainProcessInstanceId;
        }

        public GetTravelProcessDetailResponseBodyResult setMemo(String memo) {
            this.memo = memo;
            return this;
        }
        public String getMemo() {
            return this.memo;
        }

        public GetTravelProcessDetailResponseBodyResult setOriginatorId(String originatorId) {
            this.originatorId = originatorId;
            return this;
        }
        public String getOriginatorId() {
            return this.originatorId;
        }

        public GetTravelProcessDetailResponseBodyResult setOriginatorIdOnBehalf(String originatorIdOnBehalf) {
            this.originatorIdOnBehalf = originatorIdOnBehalf;
            return this;
        }
        public String getOriginatorIdOnBehalf() {
            return this.originatorIdOnBehalf;
        }

        public GetTravelProcessDetailResponseBodyResult setProcessInstanceId(String processInstanceId) {
            this.processInstanceId = processInstanceId;
            return this;
        }
        public String getProcessInstanceId() {
            return this.processInstanceId;
        }

        public GetTravelProcessDetailResponseBodyResult setProcessResult(String processResult) {
            this.processResult = processResult;
            return this;
        }
        public String getProcessResult() {
            return this.processResult;
        }

        public GetTravelProcessDetailResponseBodyResult setProcessStatus(String processStatus) {
            this.processStatus = processStatus;
            return this;
        }
        public String getProcessStatus() {
            return this.processStatus;
        }

        public GetTravelProcessDetailResponseBodyResult setRemark(String remark) {
            this.remark = remark;
            return this;
        }
        public String getRemark() {
            return this.remark;
        }

        public GetTravelProcessDetailResponseBodyResult setTasks(java.util.List<GetTravelProcessDetailResponseBodyResultTasks> tasks) {
            this.tasks = tasks;
            return this;
        }
        public java.util.List<GetTravelProcessDetailResponseBodyResultTasks> getTasks() {
            return this.tasks;
        }

        public GetTravelProcessDetailResponseBodyResult setTravelCategory(String travelCategory) {
            this.travelCategory = travelCategory;
            return this;
        }
        public String getTravelCategory() {
            return this.travelCategory;
        }

        public GetTravelProcessDetailResponseBodyResult setTravelers(java.util.List<String> travelers) {
            this.travelers = travelers;
            return this;
        }
        public java.util.List<String> getTravelers() {
            return this.travelers;
        }

        public GetTravelProcessDetailResponseBodyResult setTripDays(String tripDays) {
            this.tripDays = tripDays;
            return this;
        }
        public String getTripDays() {
            return this.tripDays;
        }

    }

}
