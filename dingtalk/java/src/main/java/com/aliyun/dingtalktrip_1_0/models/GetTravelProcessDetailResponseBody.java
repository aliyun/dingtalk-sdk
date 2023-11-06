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

    public static class GetTravelProcessDetailResponseBodyResultJourneysArrival extends TeaModel {
        @NameInMap("code")
        public String code;

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

        @NameInMap("departure")
        public GetTravelProcessDetailResponseBodyResultJourneysDeparture departure;

        @NameInMap("endTime")
        public String endTime;

        @NameInMap("journeyBizNo")
        public String journeyBizNo;

        @NameInMap("startTime")
        public String startTime;

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
        @NameInMap("businessId")
        public String businessId;

        @NameInMap("corpId")
        public String corpId;

        @NameInMap("costCenter")
        public String costCenter;

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
