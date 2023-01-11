// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalktrip_1_0.models;

import com.aliyun.tea.*;

public class SyncTripOrderRequest extends TeaModel {
    /**
     * <p>订单渠道，枚举值：BUSINESS、CUSTOMER</p>
     */
    @NameInMap("channelType")
    public String channelType;

    /**
     * <p>币种</p>
     */
    @NameInMap("currency")
    public String currency;

    /**
     * <p>钉钉用户id</p>
     */
    @NameInMap("dingUserId")
    public String dingUserId;

    /**
     * <p>优惠金额</p>
     */
    @NameInMap("discountAmount")
    public String discountAmount;

    /**
     * <p>是否是改签单</p>
     */
    @NameInMap("endorseFlag")
    public Boolean endorseFlag;

    @NameInMap("event")
    public SyncTripOrderRequestEvent event;

    /**
     * <p>下单时间</p>
     */
    @NameInMap("gmtOrder")
    public String gmtOrder;

    /**
     * <p>付款时间</p>
     */
    @NameInMap("gmtPay")
    public String gmtPay;

    /**
     * <p>退款时间</p>
     */
    @NameInMap("gmtRefund")
    public String gmtRefund;

    /**
     * <p>发票申请链接</p>
     */
    @NameInMap("invoiceApplyUrl")
    public String invoiceApplyUrl;

    /**
     * <p>行程单号</p>
     */
    @NameInMap("journeyBizNo")
    public String journeyBizNo;

    /**
     * <p>订单详情列表</p>
     */
    @NameInMap("orderDetails")
    public java.util.List<SyncTripOrderRequestOrderDetails> orderDetails;

    /**
     * <p>供应商订单号</p>
     */
    @NameInMap("orderNo")
    public String orderNo;

    /**
     * <p>订单详情链接</p>
     */
    @NameInMap("orderUrl")
    public String orderUrl;

    /**
     * <p>实付金额</p>
     */
    @NameInMap("realAmount")
    public String realAmount;

    /**
     * <p>退款金额</p>
     */
    @NameInMap("refundAmount")
    public String refundAmount;

    /**
     * <p>供应商关联订单号</p>
     */
    @NameInMap("relativeOrderNo")
    public String relativeOrderNo;

    /**
     * <p>来源埋点</p>
     */
    @NameInMap("source")
    public String source;

    /**
     * <p>用户组织id</p>
     */
    @NameInMap("targetCorpId")
    public String targetCorpId;

    /**
     * <p>总金额</p>
     */
    @NameInMap("totalAmount")
    public String totalAmount;

    /**
     * <p>订单类型</p>
     */
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
        /**
         * <p>订单事件</p>
         */
        @NameInMap("action")
        public String action;

        /**
         * <p>事件时间</p>
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
         * <p>纬度</p>
         */
        @NameInMap("lat")
        public String lat;

        /**
         * <p>经度</p>
         */
        @NameInMap("lon")
        public String lon;

        /**
         * <p>坐标数据源</p>
         * <p>- BD09：来自百度地图的经纬坐标</p>
         * <p>- GCJ02: 来自高德地图，腾讯地图，Apple地图的坐标</p>
         * <p>- WGS84: 来自GPS的坐标</p>
         */
        @NameInMap("source")
        public String source;

        /**
         * <p>定位url</p>
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

    public static class SyncTripOrderRequestOrderDetails extends TeaModel {
        /**
         * <p>到达时间</p>
         */
        @NameInMap("arrivalTime")
        public String arrivalTime;

        /**
         * <p>车辆颜色</p>
         */
        @NameInMap("carColor")
        public String carColor;

        /**
         * <p>车辆型号</p>
         */
        @NameInMap("carModel")
        public String carModel;

        /**
         * <p>车牌号</p>
         */
        @NameInMap("carNumber")
        public String carNumber;

        /**
         * <p>餐食描述</p>
         */
        @NameInMap("cateringType")
        public String cateringType;

        /**
         * <p>入住时间</p>
         */
        @NameInMap("checkInTime")
        public String checkInTime;

        /**
         * <p>离店时间</p>
         */
        @NameInMap("checkOutTime")
        public String checkOutTime;

        /**
         * <p>出发时间</p>
         */
        @NameInMap("departTime")
        public String departTime;

        /**
         * <p>目的地城市</p>
         */
        @NameInMap("destinationCity")
        public String destinationCity;

        /**
         * <p>目的地城市码</p>
         */
        @NameInMap("destinationCityCode")
        public String destinationCityCode;

        /**
         * <p>目的站名称</p>
         */
        @NameInMap("destinationStation")
        public String destinationStation;

        /**
         * <p>酒店地址</p>
         */
        @NameInMap("hotelAddress")
        public String hotelAddress;

        @NameInMap("hotelCity")
        public String hotelCity;

        /**
         * <p>酒店定位信息</p>
         */
        @NameInMap("hotelLocation")
        public SyncTripOrderRequestOrderDetailsHotelLocation hotelLocation;

        /**
         * <p>酒店名称</p>
         */
        @NameInMap("hotelName")
        public String hotelName;

        /**
         * <p>出发地城市</p>
         */
        @NameInMap("originCity")
        public String originCity;

        /**
         * <p>出发地城市码</p>
         */
        @NameInMap("originCityCode")
        public String originCityCode;

        /**
         * <p>出发站名称</p>
         */
        @NameInMap("originStation")
        public String originStation;

        /**
         * <p>房间数</p>
         */
        @NameInMap("roomCount")
        public Integer roomCount;

        /**
         * <p>舱位</p>
         */
        @NameInMap("seatInfo")
        public String seatInfo;

        /**
         * <p>“服务类型”</p>
         */
        @NameInMap("serviceType")
        public String serviceType;

        /**
         * <p>下游供应商logo</p>
         */
        @NameInMap("subSupplyLogo")
        public String subSupplyLogo;

        /**
         * <p>下游供应商名称</p>
         */
        @NameInMap("subSupplyName")
        public String subSupplyName;

        /**
         * <p>专车类型</p>
         */
        @NameInMap("taxiType")
        public String taxiType;

        /**
         * <p>联系方式</p>
         */
        @NameInMap("telephone")
        public String telephone;

        /**
         * <p>火车/航班班次</p>
         */
        @NameInMap("transportNumber")
        public String transportNumber;

        /**
         * <p>房型描述</p>
         */
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
