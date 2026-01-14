// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalktrip_1_0.models;

import com.aliyun.tea.*;

public class SyncTripOrderRequest extends TeaModel {
    /**
     * <strong>if can be null:</strong>
     * <p>true</p>
     */
    @NameInMap("bizExtension")
    public String bizExtension;

    /**
     * <strong>example:</strong>
     * <p>BUSSINESS</p>
     */
    @NameInMap("channelType")
    public String channelType;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>CNY</p>
     */
    @NameInMap("currency")
    public String currency;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>20881001829000</p>
     */
    @NameInMap("dingUserId")
    public String dingUserId;

    /**
     * <strong>example:</strong>
     * <p>0</p>
     */
    @NameInMap("discountAmount")
    public String discountAmount;

    @NameInMap("endorseFlag")
    public Boolean endorseFlag;

    /**
     * <strong>example:</strong>
     * <p>100.00</p>
     */
    @NameInMap("enterprisePayAmount")
    public String enterprisePayAmount;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("event")
    public SyncTripOrderRequestEvent event;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>2022-05-15 10:10:10</p>
     */
    @NameInMap("gmtOrder")
    public String gmtOrder;

    /**
     * <strong>example:</strong>
     * <p>2022-05-15 10:10:10</p>
     */
    @NameInMap("gmtPay")
    public String gmtPay;

    /**
     * <strong>example:</strong>
     * <p>2022-05-15 10:10:10</p>
     */
    @NameInMap("gmtRefund")
    public String gmtRefund;

    @NameInMap("hasInvoice")
    public Boolean hasInvoice;

    /**
     * <strong>example:</strong>
     * <p>亚朵酒店</p>
     */
    @NameInMap("invoiceApplyRole")
    public String invoiceApplyRole;

    /**
     * <strong>example:</strong>
     * <p>PLAIN</p>
     */
    @NameInMap("invoiceApplyType")
    public String invoiceApplyType;

    @NameInMap("invoiceApplyUrl")
    public String invoiceApplyUrl;

    @NameInMap("invoiceParty")
    public Integer invoiceParty;

    @NameInMap("invoiceType")
    public Integer invoiceType;

    /**
     * <strong>example:</strong>
     * <p>20220510170058192311</p>
     */
    @NameInMap("journeyBizNo")
    public String journeyBizNo;

    /**
     * <strong>example:</strong>
     * <p>0219514246531048123</p>
     */
    @NameInMap("journeySubmitUserId")
    public String journeySubmitUserId;

    @NameInMap("orderDetails")
    public java.util.List<SyncTripOrderRequestOrderDetails> orderDetails;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>20881001829000</p>
     */
    @NameInMap("orderNo")
    public String orderNo;

    @NameInMap("orderPaymentType")
    public String orderPaymentType;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>https:dingtalk.com/tripOrder/20220510170058192311</p>
     */
    @NameInMap("orderUrl")
    public String orderUrl;

    /**
     * <strong>example:</strong>
     * <p>100.00</p>
     */
    @NameInMap("personalPayAmount")
    public String personalPayAmount;

    @NameInMap("processId")
    public String processId;

    /**
     * <strong>example:</strong>
     * <p>100.00</p>
     */
    @NameInMap("realAmount")
    public String realAmount;

    /**
     * <strong>example:</strong>
     * <p>0</p>
     */
    @NameInMap("refundAmount")
    public String refundAmount;

    /**
     * <strong>example:</strong>
     * <p>20881001829000</p>
     */
    @NameInMap("relativeOrderNo")
    public String relativeOrderNo;

    @NameInMap("source")
    public String source;

    @NameInMap("supplyLogo")
    public String supplyLogo;

    @NameInMap("supplyName")
    public String supplyName;

    /**
     * <strong>example:</strong>
     * <p>ding32fff839a3e0105d</p>
     */
    @NameInMap("targetCorpId")
    public String targetCorpId;

    @NameInMap("tmcCorpId")
    public String tmcCorpId;

    /**
     * <strong>example:</strong>
     * <p>100.00</p>
     */
    @NameInMap("totalAmount")
    public String totalAmount;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>FLIGHT</p>
     */
    @NameInMap("type")
    public String type;

    public static SyncTripOrderRequest build(java.util.Map<String, ?> map) throws Exception {
        SyncTripOrderRequest self = new SyncTripOrderRequest();
        return TeaModel.build(map, self);
    }

    public SyncTripOrderRequest setBizExtension(String bizExtension) {
        this.bizExtension = bizExtension;
        return this;
    }
    public String getBizExtension() {
        return this.bizExtension;
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

    public SyncTripOrderRequest setEnterprisePayAmount(String enterprisePayAmount) {
        this.enterprisePayAmount = enterprisePayAmount;
        return this;
    }
    public String getEnterprisePayAmount() {
        return this.enterprisePayAmount;
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

    public SyncTripOrderRequest setHasInvoice(Boolean hasInvoice) {
        this.hasInvoice = hasInvoice;
        return this;
    }
    public Boolean getHasInvoice() {
        return this.hasInvoice;
    }

    public SyncTripOrderRequest setInvoiceApplyRole(String invoiceApplyRole) {
        this.invoiceApplyRole = invoiceApplyRole;
        return this;
    }
    public String getInvoiceApplyRole() {
        return this.invoiceApplyRole;
    }

    public SyncTripOrderRequest setInvoiceApplyType(String invoiceApplyType) {
        this.invoiceApplyType = invoiceApplyType;
        return this;
    }
    public String getInvoiceApplyType() {
        return this.invoiceApplyType;
    }

    public SyncTripOrderRequest setInvoiceApplyUrl(String invoiceApplyUrl) {
        this.invoiceApplyUrl = invoiceApplyUrl;
        return this;
    }
    public String getInvoiceApplyUrl() {
        return this.invoiceApplyUrl;
    }

    public SyncTripOrderRequest setInvoiceParty(Integer invoiceParty) {
        this.invoiceParty = invoiceParty;
        return this;
    }
    public Integer getInvoiceParty() {
        return this.invoiceParty;
    }

    public SyncTripOrderRequest setInvoiceType(Integer invoiceType) {
        this.invoiceType = invoiceType;
        return this;
    }
    public Integer getInvoiceType() {
        return this.invoiceType;
    }

    public SyncTripOrderRequest setJourneyBizNo(String journeyBizNo) {
        this.journeyBizNo = journeyBizNo;
        return this;
    }
    public String getJourneyBizNo() {
        return this.journeyBizNo;
    }

    public SyncTripOrderRequest setJourneySubmitUserId(String journeySubmitUserId) {
        this.journeySubmitUserId = journeySubmitUserId;
        return this;
    }
    public String getJourneySubmitUserId() {
        return this.journeySubmitUserId;
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

    public SyncTripOrderRequest setOrderPaymentType(String orderPaymentType) {
        this.orderPaymentType = orderPaymentType;
        return this;
    }
    public String getOrderPaymentType() {
        return this.orderPaymentType;
    }

    public SyncTripOrderRequest setOrderUrl(String orderUrl) {
        this.orderUrl = orderUrl;
        return this;
    }
    public String getOrderUrl() {
        return this.orderUrl;
    }

    public SyncTripOrderRequest setPersonalPayAmount(String personalPayAmount) {
        this.personalPayAmount = personalPayAmount;
        return this;
    }
    public String getPersonalPayAmount() {
        return this.personalPayAmount;
    }

    public SyncTripOrderRequest setProcessId(String processId) {
        this.processId = processId;
        return this;
    }
    public String getProcessId() {
        return this.processId;
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

    public SyncTripOrderRequest setSupplyLogo(String supplyLogo) {
        this.supplyLogo = supplyLogo;
        return this;
    }
    public String getSupplyLogo() {
        return this.supplyLogo;
    }

    public SyncTripOrderRequest setSupplyName(String supplyName) {
        this.supplyName = supplyName;
        return this;
    }
    public String getSupplyName() {
        return this.supplyName;
    }

    public SyncTripOrderRequest setTargetCorpId(String targetCorpId) {
        this.targetCorpId = targetCorpId;
        return this;
    }
    public String getTargetCorpId() {
        return this.targetCorpId;
    }

    public SyncTripOrderRequest setTmcCorpId(String tmcCorpId) {
        this.tmcCorpId = tmcCorpId;
        return this;
    }
    public String getTmcCorpId() {
        return this.tmcCorpId;
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
        /**
         * <p>This parameter is required.</p>
         * 
         * <strong>example:</strong>
         * <p>INIT</p>
         */
        @NameInMap("action")
        public String action;

        /**
         * <p>This parameter is required.</p>
         * 
         * <strong>example:</strong>
         * <p>2022-05-15 10:10:10</p>
         */
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
        /**
         * <strong>example:</strong>
         * <p>30.278569</p>
         */
        @NameInMap("lat")
        public String lat;

        /**
         * <strong>example:</strong>
         * <p>120.023458</p>
         */
        @NameInMap("lon")
        public String lon;

        /**
         * <strong>example:</strong>
         * <p>GCJ02</p>
         */
        @NameInMap("source")
        public String source;

        /**
         * <strong>example:</strong>
         * <p><a href="https://ditu.amap.com/place/B0FFIYYAIA">https://ditu.amap.com/place/B0FFIYYAIA</a></p>
         */
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

    public static class SyncTripOrderRequestOrderDetailsOpenConsumerInfo extends TeaModel {
        @NameInMap("corpId")
        public String corpId;

        /**
         * <strong>example:</strong>
         * <p>350622200101152876</p>
         */
        @NameInMap("identityNumber")
        public String identityNumber;

        /**
         * <strong>example:</strong>
         * <p>CITIZEN_ID</p>
         */
        @NameInMap("identityType")
        public String identityType;

        @NameInMap("name")
        public String name;

        @NameInMap("staffFlag")
        public Boolean staffFlag;

        @NameInMap("status")
        public String status;

        @NameInMap("ticketAmount")
        public String ticketAmount;

        @NameInMap("ticketNo")
        public String ticketNo;

        @NameInMap("userId")
        public String userId;

        public static SyncTripOrderRequestOrderDetailsOpenConsumerInfo build(java.util.Map<String, ?> map) throws Exception {
            SyncTripOrderRequestOrderDetailsOpenConsumerInfo self = new SyncTripOrderRequestOrderDetailsOpenConsumerInfo();
            return TeaModel.build(map, self);
        }

        public SyncTripOrderRequestOrderDetailsOpenConsumerInfo setCorpId(String corpId) {
            this.corpId = corpId;
            return this;
        }
        public String getCorpId() {
            return this.corpId;
        }

        public SyncTripOrderRequestOrderDetailsOpenConsumerInfo setIdentityNumber(String identityNumber) {
            this.identityNumber = identityNumber;
            return this;
        }
        public String getIdentityNumber() {
            return this.identityNumber;
        }

        public SyncTripOrderRequestOrderDetailsOpenConsumerInfo setIdentityType(String identityType) {
            this.identityType = identityType;
            return this;
        }
        public String getIdentityType() {
            return this.identityType;
        }

        public SyncTripOrderRequestOrderDetailsOpenConsumerInfo setName(String name) {
            this.name = name;
            return this;
        }
        public String getName() {
            return this.name;
        }

        public SyncTripOrderRequestOrderDetailsOpenConsumerInfo setStaffFlag(Boolean staffFlag) {
            this.staffFlag = staffFlag;
            return this;
        }
        public Boolean getStaffFlag() {
            return this.staffFlag;
        }

        public SyncTripOrderRequestOrderDetailsOpenConsumerInfo setStatus(String status) {
            this.status = status;
            return this;
        }
        public String getStatus() {
            return this.status;
        }

        public SyncTripOrderRequestOrderDetailsOpenConsumerInfo setTicketAmount(String ticketAmount) {
            this.ticketAmount = ticketAmount;
            return this;
        }
        public String getTicketAmount() {
            return this.ticketAmount;
        }

        public SyncTripOrderRequestOrderDetailsOpenConsumerInfo setTicketNo(String ticketNo) {
            this.ticketNo = ticketNo;
            return this;
        }
        public String getTicketNo() {
            return this.ticketNo;
        }

        public SyncTripOrderRequestOrderDetailsOpenConsumerInfo setUserId(String userId) {
            this.userId = userId;
            return this;
        }
        public String getUserId() {
            return this.userId;
        }

    }

    public static class SyncTripOrderRequestOrderDetails extends TeaModel {
        /**
         * <strong>example:</strong>
         * <p>首都机场</p>
         */
        @NameInMap("airport")
        public String airport;

        /**
         * <strong>example:</strong>
         * <p>2022-05-20 12:20:00</p>
         */
        @NameInMap("arrivalTime")
        public String arrivalTime;

        /**
         * <strong>example:</strong>
         * <p>红色</p>
         */
        @NameInMap("carColor")
        public String carColor;

        /**
         * <strong>example:</strong>
         * <p>帕萨特</p>
         */
        @NameInMap("carModel")
        public String carModel;

        /**
         * <strong>example:</strong>
         * <p>浙A0Z***7</p>
         */
        @NameInMap("carNumber")
        public String carNumber;

        /**
         * <strong>example:</strong>
         * <p>单早</p>
         */
        @NameInMap("cateringType")
        public String cateringType;

        /**
         * <strong>example:</strong>
         * <p>2022-05-20 14:00:00</p>
         */
        @NameInMap("checkInTime")
        public String checkInTime;

        /**
         * <strong>example:</strong>
         * <p>2022-05-21 12:00:00</p>
         */
        @NameInMap("checkOutTime")
        public String checkOutTime;

        /**
         * <strong>example:</strong>
         * <p>2022-05-20 10:00:00</p>
         */
        @NameInMap("departTime")
        public String departTime;

        @NameInMap("destinationAirport")
        public String destinationAirport;

        @NameInMap("destinationAirportCode")
        public String destinationAirportCode;

        /**
         * <strong>example:</strong>
         * <p>杭州</p>
         */
        @NameInMap("destinationCity")
        public String destinationCity;

        /**
         * <strong>example:</strong>
         * <p>151</p>
         */
        @NameInMap("destinationCityCode")
        public String destinationCityCode;

        /**
         * <strong>example:</strong>
         * <p>杭州</p>
         */
        @NameInMap("destinationStation")
        public String destinationStation;

        /**
         * <strong>example:</strong>
         * <p>T3</p>
         */
        @NameInMap("destinationTerminalBuilding")
        public String destinationTerminalBuilding;

        @NameInMap("detailAmount")
        public String detailAmount;

        /**
         * <strong>example:</strong>
         * <p>浙江省杭州市余杭区聚橙路文昌路</p>
         */
        @NameInMap("hotelAddress")
        public String hotelAddress;

        /**
         * <strong>example:</strong>
         * <p>杭州</p>
         */
        @NameInMap("hotelCity")
        public String hotelCity;

        @NameInMap("hotelLocation")
        public SyncTripOrderRequestOrderDetailsHotelLocation hotelLocation;

        /**
         * <strong>example:</strong>
         * <p>亲橙客栈</p>
         */
        @NameInMap("hotelName")
        public String hotelName;

        @NameInMap("openConsumerInfo")
        public java.util.List<SyncTripOrderRequestOrderDetailsOpenConsumerInfo> openConsumerInfo;

        @NameInMap("orderDetailStatus")
        public String orderDetailStatus;

        @NameInMap("originAirport")
        public String originAirport;

        @NameInMap("originAirportCode")
        public String originAirportCode;

        /**
         * <strong>example:</strong>
         * <p>北京</p>
         */
        @NameInMap("originCity")
        public String originCity;

        /**
         * <strong>example:</strong>
         * <p>150</p>
         */
        @NameInMap("originCityCode")
        public String originCityCode;

        /**
         * <strong>example:</strong>
         * <p>北京</p>
         */
        @NameInMap("originStation")
        public String originStation;

        /**
         * <strong>example:</strong>
         * <p>T3</p>
         */
        @NameInMap("originTerminalBuilding")
        public String originTerminalBuilding;

        @NameInMap("roomCount")
        public Integer roomCount;

        @NameInMap("roundTripType")
        public String roundTripType;

        /**
         * <strong>example:</strong>
         * <p>经济舱/7车12A</p>
         */
        @NameInMap("seatInfo")
        public String seatInfo;

        /**
         * <strong>example:</strong>
         * <p>REALTIME</p>
         */
        @NameInMap("serviceType")
        public String serviceType;

        /**
         * <strong>example:</strong>
         * <p><a href="http://dingtalk.com/static/logo.png">http://dingtalk.com/static/logo.png</a></p>
         */
        @NameInMap("subSupplyLogo")
        public String subSupplyLogo;

        /**
         * <strong>example:</strong>
         * <p>国航</p>
         */
        @NameInMap("subSupplyName")
        public String subSupplyName;

        /**
         * <strong>example:</strong>
         * <p>专车</p>
         */
        @NameInMap("taxiType")
        public String taxiType;

        /**
         * <strong>example:</strong>
         * <p>2022-05-20 14:00:00</p>
         */
        @NameInMap("telephone")
        public String telephone;

        /**
         * <strong>example:</strong>
         * <p>CA1762</p>
         */
        @NameInMap("transportNumber")
        public String transportNumber;

        /**
         * <strong>example:</strong>
         * <p>商务标准间</p>
         */
        @NameInMap("typeDescription")
        public String typeDescription;

        public static SyncTripOrderRequestOrderDetails build(java.util.Map<String, ?> map) throws Exception {
            SyncTripOrderRequestOrderDetails self = new SyncTripOrderRequestOrderDetails();
            return TeaModel.build(map, self);
        }

        public SyncTripOrderRequestOrderDetails setAirport(String airport) {
            this.airport = airport;
            return this;
        }
        public String getAirport() {
            return this.airport;
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

        public SyncTripOrderRequestOrderDetails setDestinationAirport(String destinationAirport) {
            this.destinationAirport = destinationAirport;
            return this;
        }
        public String getDestinationAirport() {
            return this.destinationAirport;
        }

        public SyncTripOrderRequestOrderDetails setDestinationAirportCode(String destinationAirportCode) {
            this.destinationAirportCode = destinationAirportCode;
            return this;
        }
        public String getDestinationAirportCode() {
            return this.destinationAirportCode;
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

        public SyncTripOrderRequestOrderDetails setDestinationTerminalBuilding(String destinationTerminalBuilding) {
            this.destinationTerminalBuilding = destinationTerminalBuilding;
            return this;
        }
        public String getDestinationTerminalBuilding() {
            return this.destinationTerminalBuilding;
        }

        public SyncTripOrderRequestOrderDetails setDetailAmount(String detailAmount) {
            this.detailAmount = detailAmount;
            return this;
        }
        public String getDetailAmount() {
            return this.detailAmount;
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

        public SyncTripOrderRequestOrderDetails setOpenConsumerInfo(java.util.List<SyncTripOrderRequestOrderDetailsOpenConsumerInfo> openConsumerInfo) {
            this.openConsumerInfo = openConsumerInfo;
            return this;
        }
        public java.util.List<SyncTripOrderRequestOrderDetailsOpenConsumerInfo> getOpenConsumerInfo() {
            return this.openConsumerInfo;
        }

        public SyncTripOrderRequestOrderDetails setOrderDetailStatus(String orderDetailStatus) {
            this.orderDetailStatus = orderDetailStatus;
            return this;
        }
        public String getOrderDetailStatus() {
            return this.orderDetailStatus;
        }

        public SyncTripOrderRequestOrderDetails setOriginAirport(String originAirport) {
            this.originAirport = originAirport;
            return this;
        }
        public String getOriginAirport() {
            return this.originAirport;
        }

        public SyncTripOrderRequestOrderDetails setOriginAirportCode(String originAirportCode) {
            this.originAirportCode = originAirportCode;
            return this;
        }
        public String getOriginAirportCode() {
            return this.originAirportCode;
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

        public SyncTripOrderRequestOrderDetails setOriginTerminalBuilding(String originTerminalBuilding) {
            this.originTerminalBuilding = originTerminalBuilding;
            return this;
        }
        public String getOriginTerminalBuilding() {
            return this.originTerminalBuilding;
        }

        public SyncTripOrderRequestOrderDetails setRoomCount(Integer roomCount) {
            this.roomCount = roomCount;
            return this;
        }
        public Integer getRoomCount() {
            return this.roomCount;
        }

        public SyncTripOrderRequestOrderDetails setRoundTripType(String roundTripType) {
            this.roundTripType = roundTripType;
            return this;
        }
        public String getRoundTripType() {
            return this.roundTripType;
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
