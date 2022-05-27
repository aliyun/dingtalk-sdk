// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalktrip_1_0.models;

import com.aliyun.tea.*;

public class SyncTripOrderRequest extends TeaModel {
    // 币种
    @NameInMap("currency")
    public String currency;

    // 钉钉用户id
    @NameInMap("dingUserId")
    public String dingUserId;

    // 优惠金额
    @NameInMap("discountAmount")
    public String discountAmount;

    // 是否是改签单
    @NameInMap("endorseFlag")
    public Boolean endorseFlag;

    @NameInMap("event")
    public SyncTripOrderRequestEvent event;

    // 下单时间
    @NameInMap("gmtOrder")
    public String gmtOrder;

    // 付款时间
    @NameInMap("gmtPay")
    public String gmtPay;

    // 退款时间
    @NameInMap("gmtRefund")
    public String gmtRefund;

    // 发票申请链接
    @NameInMap("invoiceApplyUrl")
    public String invoiceApplyUrl;

    // 行程单号
    @NameInMap("journeyBizNo")
    public String journeyBizNo;

    // 订单详情列表
    @NameInMap("orderDetails")
    public java.util.List<SyncTripOrderRequestOrderDetails> orderDetails;

    // 供应商订单号
    @NameInMap("orderNo")
    public String orderNo;

    // 订单详情链接
    @NameInMap("orderUrl")
    public String orderUrl;

    // 实付金额
    @NameInMap("realAmount")
    public String realAmount;

    // 退款金额
    @NameInMap("refundAmount")
    public String refundAmount;

    // 供应商关联订单号
    @NameInMap("relativeOrderNo")
    public String relativeOrderNo;

    // 用户组织id
    @NameInMap("targetCorpId")
    public String targetCorpId;

    // 总金额
    @NameInMap("totalAmount")
    public String totalAmount;

    // 订单类型
    @NameInMap("type")
    public String type;

    public static SyncTripOrderRequest build(java.util.Map<String, ?> map) throws Exception {
        SyncTripOrderRequest self = new SyncTripOrderRequest();
        return TeaModel.build(map, self);
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
        // 订单事件
        @NameInMap("action")
        public String action;

        // 事件时间
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
        // 纬度
        @NameInMap("lat")
        public String lat;

        // 经度
        @NameInMap("lon")
        public String lon;

        // 坐标数据源
        // - BD09：来自百度地图的经纬坐标
        // - GCJ02: 来自高德地图，腾讯地图，Apple地图的坐标
        // - WGS84: 来自GPS的坐标
        @NameInMap("source")
        public String source;

        // 定位url
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
        // 到达时间
        @NameInMap("arrivalTime")
        public String arrivalTime;

        // 车牌号
        @NameInMap("carNumber")
        public String carNumber;

        // 餐食描述
        @NameInMap("cateringType")
        public String cateringType;

        // 入住时间
        @NameInMap("checkInTime")
        public String checkInTime;

        // 离店时间
        @NameInMap("checkOutTime")
        public String checkOutTime;

        // 出发时间
        @NameInMap("departTime")
        public String departTime;

        // 目的地城市码
        @NameInMap("destinationCityCode")
        public String destinationCityCode;

        // 目的站名称
        @NameInMap("destinationStation")
        public String destinationStation;

        // 酒店地址
        @NameInMap("hotelAddress")
        public String hotelAddress;

        // 酒店定位信息
        @NameInMap("hotelLocation")
        public SyncTripOrderRequestOrderDetailsHotelLocation hotelLocation;

        // 酒店名称
        @NameInMap("hotelName")
        public String hotelName;

        // 出发地城市码
        @NameInMap("originCityCode")
        public String originCityCode;

        // 出发站名称
        @NameInMap("originStation")
        public String originStation;

        // 房间数
        @NameInMap("roomCount")
        public Integer roomCount;

        // 舱位
        @NameInMap("seatInfo")
        public String seatInfo;

        // 下游供应商logo
        @NameInMap("subSupplyLogo")
        public String subSupplyLogo;

        // 下游供应商名称
        @NameInMap("subSupplyName")
        public String subSupplyName;

        // 专车类型
        @NameInMap("taxiType")
        public String taxiType;

        // 联系方式
        @NameInMap("telephone")
        public String telephone;

        // 火车/航班班次
        @NameInMap("transportNumber")
        public String transportNumber;

        // 房型描述
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
