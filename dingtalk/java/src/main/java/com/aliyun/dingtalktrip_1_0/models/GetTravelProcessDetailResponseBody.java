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
        @NameInMap("bizAlias")
        public String bizAlias;

        @NameInMap("componentType")
        public String componentType;

        @NameInMap("extValue")
        public String extValue;

        @NameInMap("id")
        public String id;

        @NameInMap("name")
        public String name;

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
        @NameInMap("code")
        public String code;

        @NameInMap("countryCode")
        public String countryCode;

        @NameInMap("countryName")
        public String countryName;

        @NameInMap("name")
        public String name;

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
        @NameInMap("code")
        public String code;

        @NameInMap("countryCode")
        public String countryCode;

        @NameInMap("countryName")
        public String countryName;

        @NameInMap("name")
        public String name;

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

        @NameInMap("costCenter")
        public String costCenter;

        @NameInMap("costCenterId")
        public String costCenterId;

        @NameInMap("departure")
        public GetTravelProcessDetailResponseBodyResultJourneysDeparture departure;

        @NameInMap("endTime")
        public String endTime;

        @NameInMap("endTimeAcc")
        public String endTimeAcc;

        @NameInMap("invoiceTitle")
        public String invoiceTitle;

        @NameInMap("invoiceTitleId")
        public String invoiceTitleId;

        @NameInMap("itineraryProject")
        public String itineraryProject;

        @NameInMap("itineraryProjectId")
        public String itineraryProjectId;

        @NameInMap("journeyBizNo")
        public String journeyBizNo;

        @NameInMap("startTime")
        public String startTime;

        @NameInMap("startTimeAcc")
        public String startTimeAcc;

        @NameInMap("timeUnit")
        public String timeUnit;

        @NameInMap("travelType")
        public String travelType;

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

    public static class GetTravelProcessDetailResponseBodyResult extends TeaModel {
        @NameInMap("bizCategoryId")
        public String bizCategoryId;

        @NameInMap("businessId")
        public String businessId;

        @NameInMap("corpId")
        public String corpId;

        @NameInMap("costCenter")
        public String costCenter;

        @NameInMap("costCenterId")
        public String costCenterId;

        @NameInMap("extFormComponent")
        public java.util.List<GetTravelProcessDetailResponseBodyResultExtFormComponent> extFormComponent;

        @NameInMap("feeType")
        public String feeType;

        @NameInMap("invoiceTitle")
        public String invoiceTitle;

        @NameInMap("invoiceTitleId")
        public String invoiceTitleId;

        @NameInMap("itineraryProject")
        public String itineraryProject;

        @NameInMap("journeys")
        public java.util.List<GetTravelProcessDetailResponseBodyResultJourneys> journeys;

        @NameInMap("mainProcessInstanceId")
        public String mainProcessInstanceId;

        @NameInMap("memo")
        public String memo;

        @NameInMap("originatorId")
        public String originatorId;

        @NameInMap("processInstanceId")
        public String processInstanceId;

        @NameInMap("processResult")
        public String processResult;

        @NameInMap("processStatus")
        public String processStatus;

        @NameInMap("remark")
        public String remark;

        @NameInMap("travelCategory")
        public String travelCategory;

        @NameInMap("travelers")
        public java.util.List<String> travelers;

        public static GetTravelProcessDetailResponseBodyResult build(java.util.Map<String, ?> map) throws Exception {
            GetTravelProcessDetailResponseBodyResult self = new GetTravelProcessDetailResponseBodyResult();
            return TeaModel.build(map, self);
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

        public GetTravelProcessDetailResponseBodyResult setItineraryProject(String itineraryProject) {
            this.itineraryProject = itineraryProject;
            return this;
        }
        public String getItineraryProject() {
            return this.itineraryProject;
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

    }

}
