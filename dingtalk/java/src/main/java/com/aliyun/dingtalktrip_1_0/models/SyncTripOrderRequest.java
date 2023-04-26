// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalktrip_1_0.models;

import com.aliyun.tea.*;

public class SyncTripOrderRequest extends TeaModel {
    @NameInMap("channelType")
    public String channelType;

    @NameInMap("currency")
    public String currency;

    @NameInMap("dingUserId")
    public String dingUserId;

    @NameInMap("discountAmount")
    public String discountAmount;

    @NameInMap("endorseFlag")
    public Boolean endorseFlag;

    @NameInMap("event")
    public SyncTripOrderRequestEvent event;

    @NameInMap("gmtOrder")
    public String gmtOrder;

    @NameInMap("gmtPay")
    public String gmtPay;

    @NameInMap("gmtRefund")
    public String gmtRefund;

    @NameInMap("invoiceApplyUrl")
    public String invoiceApplyUrl;

    @NameInMap("journeyBizNo")
    public String journeyBizNo;

    @NameInMap("orderDetails")
    public java.util.List<SyncTripOrderRequestOrderDetails> orderDetails;

    @NameInMap("orderNo")
    public String orderNo;

    @NameInMap("orderUrl")
    public String orderUrl;

    @NameInMap("realAmount")
    public String realAmount;

    @NameInMap("refundAmount")
    public String refundAmount;

    @NameInMap("relativeOrderNo")
    public String relativeOrderNo;

    @NameInMap("source")
    public String source;

    @NameInMap("targetCorpId")
    public String targetCorpId;

    @NameInMap("totalAmount")
    public String totalAmount;

    @NameInMap("type")
    public String type;

    public static SyncTripOrderRequest build(java.util.Map<String, ?> map) throws Exception {
        SyncTripOrderRequest self = new SyncTripOrderRequest();
        return TeaModel.build(map, self);
    }

    public SyncTripOrderRequest setChannelType(String channelType) {
        this.channelType = channelType;
        return this;
    }
    public String getChannelType() {
        return this.channelType;
    }

    public SyncTripOrderRequest setCurrency(String currency) {
        this.currency = currency;
        return this;
    }
    public String getCurrency() {
        return this.currency;
    }

    public SyncTripOrderRequest setDingUserId(String dingUserId) {
        this.dingUserId = dingUserId;
        return this;
    }
    public String getDingUserId() {
        return this.dingUserId;
    }

    public SyncTripOrderRequest setDiscountAmount(String discountAmount) {
        this.discountAmount = discountAmount;
        return this;
    }
    public String getDiscountAmount() {
        return this.discountAmount;
    }

    public SyncTripOrderRequest setEndorseFlag(Boolean endorseFlag) {
        this.endorseFlag = endorseFlag;
        return this;
    }
    public Boolean getEndorseFlag() {
        return this.endorseFlag;
    }

    public SyncTripOrderRequest setEvent(SyncTripOrderRequestEvent event) {
        this.event = event;
        return this;
    }
    public SyncTripOrderRequestEvent getEvent() {
        return this.event;
    }

    public SyncTripOrderRequest setGmtOrder(String gmtOrder) {
        this.gmtOrder = gmtOrder;
        return this;
    }
    public String getGmtOrder() {
        return this.gmtOrder;
    }

    public SyncTripOrderRequest setGmtPay(String gmtPay) {
        this.gmtPay = gmtPay;
        return this;
    }
    public String getGmtPay() {
        return this.gmtPay;
    }

    public SyncTripOrderRequest setGmtRefund(String gmtRefund) {
        this.gmtRefund = gmtRefund;
        return this;
    }
    public String getGmtRefund() {
        return this.gmtRefund;
    }

    public SyncTripOrderRequest setInvoiceApplyUrl(String invoiceApplyUrl) {
        this.invoiceApplyUrl = invoiceApplyUrl;
        return this;
    }
    public String getInvoiceApplyUrl() {
        return this.invoiceApplyUrl;
    }

    public SyncTripOrderRequest setJourneyBizNo(String journeyBizNo) {
        this.journeyBizNo = journeyBizNo;
        return this;
    }
    public String getJourneyBizNo() {
        return this.journeyBizNo;
    }

    public SyncTripOrderRequest setOrderDetails(java.util.List<SyncTripOrderRequestOrderDetails> orderDetails) {
        this.orderDetails = orderDetails;
        return this;
    }
    public java.util.List<SyncTripOrderRequestOrderDetails> getOrderDetails() {
        return this.orderDetails;
    }

    public SyncTripOrderRequest setOrderNo(String orderNo) {
        this.orderNo = orderNo;
        return this;
    }
    public String getOrderNo() {
        return this.orderNo;
    }

    public SyncTripOrderRequest setOrderUrl(String orderUrl) {
        this.orderUrl = orderUrl;
        return this;
    }
    public String getOrderUrl() {
        return this.orderUrl;
    }

    public SyncTripOrderRequest setRealAmount(String realAmount) {
        this.realAmount = realAmount;
        return this;
    }
    public String getRealAmount() {
        return this.realAmount;
    }

    public SyncTripOrderRequest setRefundAmount(String refundAmount) {
        this.refundAmount = refundAmount;
        return this;
    }
    public String getRefundAmount() {
        return this.refundAmount;
    }

    public SyncTripOrderRequest setRelativeOrderNo(String relativeOrderNo) {
        this.relativeOrderNo = relativeOrderNo;
        return this;
    }
    public String getRelativeOrderNo() {
        return this.relativeOrderNo;
    }

    public SyncTripOrderRequest setSource(String source) {
        this.source = source;
        return this;
    }
    public String getSource() {
        return this.source;
    }

    public SyncTripOrderRequest setTargetCorpId(String targetCorpId) {
        this.targetCorpId = targetCorpId;
        return this;
    }
    public String getTargetCorpId() {
        return this.targetCorpId;
    }

    public SyncTripOrderRequest setTotalAmount(String totalAmount) {
        this.totalAmount = totalAmount;
        return this;
    }
    public String getTotalAmount() {
        return this.totalAmount;
    }

    public SyncTripOrderRequest setType(String type) {
        this.type = type;
        return this;
    }
    public String getType() {
        return this.type;
    }

    public static class SyncTripOrderRequestEvent extends TeaModel {
        @NameInMap("action")
        public String action;

        @NameInMap("gmtAction")
        public String gmtAction;

        public static SyncTripOrderRequestEvent build(java.util.Map<String, ?> map) throws Exception {
            SyncTripOrderRequestEvent self = new SyncTripOrderRequestEvent();
            return TeaModel.build(map, self);
        }

        public SyncTripOrderRequestEvent setAction(String action) {
            this.action = action;
            return this;
        }
        public String getAction() {
            return this.action;
        }

        public SyncTripOrderRequestEvent setGmtAction(String gmtAction) {
            this.gmtAction = gmtAction;
            return this;
        }
        public String getGmtAction() {
            return this.gmtAction;
        }

    }

    public static class SyncTripOrderRequestOrderDetailsHotelLocation extends TeaModel {
        @NameInMap("lat")
        public String lat;

        @NameInMap("lon")
        public String lon;

        @NameInMap("source")
        public String source;

        @NameInMap("url")
        public String url;

        public static SyncTripOrderRequestOrderDetailsHotelLocation build(java.util.Map<String, ?> map) throws Exception {
            SyncTripOrderRequestOrderDetailsHotelLocation self = new SyncTripOrderRequestOrderDetailsHotelLocation();
            return TeaModel.build(map, self);
        }

        public SyncTripOrderRequestOrderDetailsHotelLocation setLat(String lat) {
            this.lat = lat;
            return this;
        }
        public String getLat() {
            return this.lat;
        }

        public SyncTripOrderRequestOrderDetailsHotelLocation setLon(String lon) {
            this.lon = lon;
            return this;
        }
        public String getLon() {
            return this.lon;
        }

        public SyncTripOrderRequestOrderDetailsHotelLocation setSource(String source) {
            this.source = source;
            return this;
        }
        public String getSource() {
            return this.source;
        }

        public SyncTripOrderRequestOrderDetailsHotelLocation setUrl(String url) {
            this.url = url;
            return this;
        }
        public String getUrl() {
            return this.url;
        }

    }

    public static class SyncTripOrderRequestOrderDetails extends TeaModel {
        @NameInMap("arrivalTime")
        public String arrivalTime;

        @NameInMap("carColor")
        public String carColor;

        @NameInMap("carModel")
        public String carModel;

        @NameInMap("carNumber")
        public String carNumber;

        @NameInMap("cateringType")
        public String cateringType;

        @NameInMap("checkInTime")
        public String checkInTime;

        @NameInMap("checkOutTime")
        public String checkOutTime;

        @NameInMap("departTime")
        public String departTime;

        @NameInMap("destinationCity")
        public String destinationCity;

        @NameInMap("destinationCityCode")
        public String destinationCityCode;

        @NameInMap("destinationStation")
        public String destinationStation;

        @NameInMap("hotelAddress")
        public String hotelAddress;

        @NameInMap("hotelCity")
        public String hotelCity;

        @NameInMap("hotelLocation")
        public SyncTripOrderRequestOrderDetailsHotelLocation hotelLocation;

        @NameInMap("hotelName")
        public String hotelName;

        @NameInMap("originCity")
        public String originCity;

        @NameInMap("originCityCode")
        public String originCityCode;

        @NameInMap("originStation")
        public String originStation;

        @NameInMap("roomCount")
        public Integer roomCount;

        @NameInMap("seatInfo")
        public String seatInfo;

        @NameInMap("serviceType")
        public String serviceType;

        @NameInMap("subSupplyLogo")
        public String subSupplyLogo;

        @NameInMap("subSupplyName")
        public String subSupplyName;

        @NameInMap("taxiType")
        public String taxiType;

        @NameInMap("telephone")
        public String telephone;

        @NameInMap("transportNumber")
        public String transportNumber;

        @NameInMap("typeDescription")
        public String typeDescription;

        public static SyncTripOrderRequestOrderDetails build(java.util.Map<String, ?> map) throws Exception {
            SyncTripOrderRequestOrderDetails self = new SyncTripOrderRequestOrderDetails();
            return TeaModel.build(map, self);
        }

        public SyncTripOrderRequestOrderDetails setArrivalTime(String arrivalTime) {
            this.arrivalTime = arrivalTime;
            return this;
        }
        public String getArrivalTime() {
            return this.arrivalTime;
        }

        public SyncTripOrderRequestOrderDetails setCarColor(String carColor) {
            this.carColor = carColor;
            return this;
        }
        public String getCarColor() {
            return this.carColor;
        }

        public SyncTripOrderRequestOrderDetails setCarModel(String carModel) {
            this.carModel = carModel;
            return this;
        }
        public String getCarModel() {
            return this.carModel;
        }

        public SyncTripOrderRequestOrderDetails setCarNumber(String carNumber) {
            this.carNumber = carNumber;
            return this;
        }
        public String getCarNumber() {
            return this.carNumber;
        }

        public SyncTripOrderRequestOrderDetails setCateringType(String cateringType) {
            this.cateringType = cateringType;
            return this;
        }
        public String getCateringType() {
            return this.cateringType;
        }

        public SyncTripOrderRequestOrderDetails setCheckInTime(String checkInTime) {
            this.checkInTime = checkInTime;
            return this;
        }
        public String getCheckInTime() {
            return this.checkInTime;
        }

        public SyncTripOrderRequestOrderDetails setCheckOutTime(String checkOutTime) {
            this.checkOutTime = checkOutTime;
            return this;
        }
        public String getCheckOutTime() {
            return this.checkOutTime;
        }

        public SyncTripOrderRequestOrderDetails setDepartTime(String departTime) {
            this.departTime = departTime;
            return this;
        }
        public String getDepartTime() {
            return this.departTime;
        }

        public SyncTripOrderRequestOrderDetails setDestinationCity(String destinationCity) {
            this.destinationCity = destinationCity;
            return this;
        }
        public String getDestinationCity() {
            return this.destinationCity;
        }

        public SyncTripOrderRequestOrderDetails setDestinationCityCode(String destinationCityCode) {
            this.destinationCityCode = destinationCityCode;
            return this;
        }
        public String getDestinationCityCode() {
            return this.destinationCityCode;
        }

        public SyncTripOrderRequestOrderDetails setDestinationStation(String destinationStation) {
            this.destinationStation = destinationStation;
            return this;
        }
        public String getDestinationStation() {
            return this.destinationStation;
        }

        public SyncTripOrderRequestOrderDetails setHotelAddress(String hotelAddress) {
            this.hotelAddress = hotelAddress;
            return this;
        }
        public String getHotelAddress() {
            return this.hotelAddress;
        }

        public SyncTripOrderRequestOrderDetails setHotelCity(String hotelCity) {
            this.hotelCity = hotelCity;
            return this;
        }
        public String getHotelCity() {
            return this.hotelCity;
        }

        public SyncTripOrderRequestOrderDetails setHotelLocation(SyncTripOrderRequestOrderDetailsHotelLocation hotelLocation) {
            this.hotelLocation = hotelLocation;
            return this;
        }
        public SyncTripOrderRequestOrderDetailsHotelLocation getHotelLocation() {
            return this.hotelLocation;
        }

        public SyncTripOrderRequestOrderDetails setHotelName(String hotelName) {
            this.hotelName = hotelName;
            return this;
        }
        public String getHotelName() {
            return this.hotelName;
        }

        public SyncTripOrderRequestOrderDetails setOriginCity(String originCity) {
            this.originCity = originCity;
            return this;
        }
        public String getOriginCity() {
            return this.originCity;
        }

        public SyncTripOrderRequestOrderDetails setOriginCityCode(String originCityCode) {
            this.originCityCode = originCityCode;
            return this;
        }
        public String getOriginCityCode() {
            return this.originCityCode;
        }

        public SyncTripOrderRequestOrderDetails setOriginStation(String originStation) {
            this.originStation = originStation;
            return this;
        }
        public String getOriginStation() {
            return this.originStation;
        }

        public SyncTripOrderRequestOrderDetails setRoomCount(Integer roomCount) {
            this.roomCount = roomCount;
            return this;
        }
        public Integer getRoomCount() {
            return this.roomCount;
        }

        public SyncTripOrderRequestOrderDetails setSeatInfo(String seatInfo) {
            this.seatInfo = seatInfo;
            return this;
        }
        public String getSeatInfo() {
            return this.seatInfo;
        }

        public SyncTripOrderRequestOrderDetails setServiceType(String serviceType) {
            this.serviceType = serviceType;
            return this;
        }
        public String getServiceType() {
            return this.serviceType;
        }

        public SyncTripOrderRequestOrderDetails setSubSupplyLogo(String subSupplyLogo) {
            this.subSupplyLogo = subSupplyLogo;
            return this;
        }
        public String getSubSupplyLogo() {
            return this.subSupplyLogo;
        }

        public SyncTripOrderRequestOrderDetails setSubSupplyName(String subSupplyName) {
            this.subSupplyName = subSupplyName;
            return this;
        }
        public String getSubSupplyName() {
            return this.subSupplyName;
        }

        public SyncTripOrderRequestOrderDetails setTaxiType(String taxiType) {
            this.taxiType = taxiType;
            return this;
        }
        public String getTaxiType() {
            return this.taxiType;
        }

        public SyncTripOrderRequestOrderDetails setTelephone(String telephone) {
            this.telephone = telephone;
            return this;
        }
        public String getTelephone() {
            return this.telephone;
        }

        public SyncTripOrderRequestOrderDetails setTransportNumber(String transportNumber) {
            this.transportNumber = transportNumber;
            return this;
        }
        public String getTransportNumber() {
            return this.transportNumber;
        }

        public SyncTripOrderRequestOrderDetails setTypeDescription(String typeDescription) {
            this.typeDescription = typeDescription;
            return this;
        }
        public String getTypeDescription() {
            return this.typeDescription;
        }

    }

}
