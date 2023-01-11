// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkalitrip_1_0.models;

import com.aliyun.tea.*;

public class BillSettementHotelResponseBody extends TeaModel {
    /**
     * <p>module</p>
     */
    @NameInMap("module")
    public BillSettementHotelResponseBodyModule module;

    /**
     * <p>结果code</p>
     */
    @NameInMap("resultCode")
    public Long resultCode;

    /**
     * <p>结果msg</p>
     */
    @NameInMap("resultMsg")
    public String resultMsg;

    /**
     * <p>是否成功</p>
     */
    @NameInMap("success")
    public Boolean success;

    public static BillSettementHotelResponseBody build(java.util.Map<String, ?> map) throws Exception {
        BillSettementHotelResponseBody self = new BillSettementHotelResponseBody();
        return TeaModel.build(map, self);
    }

    public BillSettementHotelResponseBody setModule(BillSettementHotelResponseBodyModule module) {
        this.module = module;
        return this;
    }
    public BillSettementHotelResponseBodyModule getModule() {
        return this.module;
    }

    public BillSettementHotelResponseBody setResultCode(Long resultCode) {
        this.resultCode = resultCode;
        return this;
    }
    public Long getResultCode() {
        return this.resultCode;
    }

    public BillSettementHotelResponseBody setResultMsg(String resultMsg) {
        this.resultMsg = resultMsg;
        return this;
    }
    public String getResultMsg() {
        return this.resultMsg;
    }

    public BillSettementHotelResponseBody setSuccess(Boolean success) {
        this.success = success;
        return this;
    }
    public Boolean getSuccess() {
        return this.success;
    }

    public static class BillSettementHotelResponseBodyModuleDataList extends TeaModel {
        /**
         * <p>交易流水号</p>
         */
        @NameInMap("alipayTradeNo")
        public String alipayTradeNo;

        /**
         * <p>审批单号</p>
         */
        @NameInMap("applyId")
        public String applyId;

        /**
         * <p>入账时间</p>
         */
        @NameInMap("billRecordTime")
        public String billRecordTime;

        /**
         * <p>预定时间</p>
         */
        @NameInMap("bookTime")
        public String bookTime;

        /**
         * <p>预定人use id</p>
         */
        @NameInMap("bookerId")
        public String bookerId;

        /**
         * <p>预订人工号</p>
         */
        @NameInMap("bookerJobNo")
        public String bookerJobNo;

        /**
         * <p>预订人名称</p>
         */
        @NameInMap("bookerName")
        public String bookerName;

        /**
         * <p>资金方向</p>
         */
        @NameInMap("capitalDirection")
        public String capitalDirection;

        /**
         * <p>级联部门</p>
         */
        @NameInMap("cascadeDepartment")
        public String cascadeDepartment;

        /**
         * <p>入住时间</p>
         */
        @NameInMap("checkInDate")
        public String checkInDate;

        /**
         * <p>离店时间</p>
         */
        @NameInMap("checkoutDate")
        public String checkoutDate;

        /**
         * <p>入住城市</p>
         */
        @NameInMap("city")
        public String city;

        /**
         * <p>城市编码</p>
         */
        @NameInMap("cityCode")
        public String cityCode;

        /**
         * <p>企业退款金额</p>
         */
        @NameInMap("corpRefundFee")
        public Double corpRefundFee;

        /**
         * <p>企业支付金额</p>
         */
        @NameInMap("corpTotalFee")
        public Double corpTotalFee;

        /**
         * <p>成本中心名称</p>
         */
        @NameInMap("costCenter")
        public String costCenter;

        /**
         * <p>成本中心编码</p>
         */
        @NameInMap("costCenterNumber")
        public String costCenterNumber;

        /**
         * <p>末级部门</p>
         */
        @NameInMap("department")
        public String department;

        /**
         * <p>部门id</p>
         */
        @NameInMap("departmentId")
        public String departmentId;

        /**
         * <p>费用类型</p>
         */
        @NameInMap("feeType")
        public String feeType;

        /**
         * <p>杂费</p>
         */
        @NameInMap("fees")
        public Double fees;

        /**
         * <p>福豆支付</p>
         */
        @NameInMap("fuPointFee")
        public Double fuPointFee;

        /**
         * <p>酒店名称</p>
         */
        @NameInMap("hotelName")
        public String hotelName;

        /**
         * <p>序号</p>
         */
        @NameInMap("index")
        public String index;

        /**
         * <p>发票抬头</p>
         */
        @NameInMap("invoiceTitle")
        public String invoiceTitle;

        /**
         * <p>是否协议价</p>
         */
        @NameInMap("isNegotiation")
        public Boolean isNegotiation;

        /**
         * <p>是否合住</p>
         */
        @NameInMap("isShareStr")
        public String isShareStr;

        /**
         * <p>入住天数</p>
         */
        @NameInMap("nights")
        public Long nights;

        /**
         * <p>订单号</p>
         */
        @NameInMap("orderId")
        public String orderId;

        /**
         * <p>订单金额</p>
         */
        @NameInMap("orderPrice")
        public Double orderPrice;

        /**
         * <p>订单类型</p>
         */
        @NameInMap("orderType")
        public String orderType;

        /**
         * <p>超标审批单号</p>
         */
        @NameInMap("overApplyId")
        public String overApplyId;

        /**
         * <p>个人退款金额</p>
         */
        @NameInMap("personRefundFee")
        public Double personRefundFee;

        /**
         * <p>个人支付金额</p>
         */
        @NameInMap("personSettlePrice")
        public Double personSettlePrice;

        /**
         * <p>主键id</p>
         */
        @NameInMap("primaryId")
        public Long primaryId;

        /**
         * <p>项目编码</p>
         */
        @NameInMap("projectCode")
        public String projectCode;

        /**
         * <p>项目名称</p>
         */
        @NameInMap("projectName")
        public String projectName;

        /**
         * <p>优惠券</p>
         */
        @NameInMap("promotionFee")
        public Double promotionFee;

        /**
         * <p>备注</p>
         */
        @NameInMap("remark")
        public String remark;

        /**
         * <p>房间数</p>
         */
        @NameInMap("roomNumber")
        public Long roomNumber;

        /**
         * <p>房价</p>
         */
        @NameInMap("roomPrice")
        public Double roomPrice;

        /**
         * <p>房间类型</p>
         */
        @NameInMap("roomType")
        public String roomType;

        /**
         * <p>服务费,仅在 feeType 20111、20112中展示</p>
         */
        @NameInMap("serviceFee")
        public Double serviceFee;

        /**
         * <p>结算金额</p>
         */
        @NameInMap("settlementFee")
        public Double settlementFee;

        /**
         * <p>预存赠送金额消费</p>
         */
        @NameInMap("settlementGrantFee")
        public Double settlementGrantFee;

        /**
         * <p>结算时间</p>
         */
        @NameInMap("settlementTime")
        public String settlementTime;

        /**
         * <p>结算类型</p>
         */
        @NameInMap("settlementType")
        public String settlementType;

        /**
         * <p>入账状态</p>
         */
        @NameInMap("status")
        public Long status;

        /**
         * <p>总间夜数</p>
         */
        @NameInMap("totalNights")
        public Long totalNights;

        /**
         * <p>出行人use id</p>
         */
        @NameInMap("travelerId")
        public String travelerId;

        /**
         * <p>出行人工号</p>
         */
        @NameInMap("travelerJobNo")
        public String travelerJobNo;

        /**
         * <p>出行人名称</p>
         */
        @NameInMap("travelerName")
        public String travelerName;

        /**
         * <p>发票类型</p>
         */
        @NameInMap("voucherType")
        public Long voucherType;

        public static BillSettementHotelResponseBodyModuleDataList build(java.util.Map<String, ?> map) throws Exception {
            BillSettementHotelResponseBodyModuleDataList self = new BillSettementHotelResponseBodyModuleDataList();
            return TeaModel.build(map, self);
        }

        public BillSettementHotelResponseBodyModuleDataList setAlipayTradeNo(String alipayTradeNo) {
            this.alipayTradeNo = alipayTradeNo;
            return this;
        }
        public String getAlipayTradeNo() {
            return this.alipayTradeNo;
        }

        public BillSettementHotelResponseBodyModuleDataList setApplyId(String applyId) {
            this.applyId = applyId;
            return this;
        }
        public String getApplyId() {
            return this.applyId;
        }

        public BillSettementHotelResponseBodyModuleDataList setBillRecordTime(String billRecordTime) {
            this.billRecordTime = billRecordTime;
            return this;
        }
        public String getBillRecordTime() {
            return this.billRecordTime;
        }

        public BillSettementHotelResponseBodyModuleDataList setBookTime(String bookTime) {
            this.bookTime = bookTime;
            return this;
        }
        public String getBookTime() {
            return this.bookTime;
        }

        public BillSettementHotelResponseBodyModuleDataList setBookerId(String bookerId) {
            this.bookerId = bookerId;
            return this;
        }
        public String getBookerId() {
            return this.bookerId;
        }

        public BillSettementHotelResponseBodyModuleDataList setBookerJobNo(String bookerJobNo) {
            this.bookerJobNo = bookerJobNo;
            return this;
        }
        public String getBookerJobNo() {
            return this.bookerJobNo;
        }

        public BillSettementHotelResponseBodyModuleDataList setBookerName(String bookerName) {
            this.bookerName = bookerName;
            return this;
        }
        public String getBookerName() {
            return this.bookerName;
        }

        public BillSettementHotelResponseBodyModuleDataList setCapitalDirection(String capitalDirection) {
            this.capitalDirection = capitalDirection;
            return this;
        }
        public String getCapitalDirection() {
            return this.capitalDirection;
        }

        public BillSettementHotelResponseBodyModuleDataList setCascadeDepartment(String cascadeDepartment) {
            this.cascadeDepartment = cascadeDepartment;
            return this;
        }
        public String getCascadeDepartment() {
            return this.cascadeDepartment;
        }

        public BillSettementHotelResponseBodyModuleDataList setCheckInDate(String checkInDate) {
            this.checkInDate = checkInDate;
            return this;
        }
        public String getCheckInDate() {
            return this.checkInDate;
        }

        public BillSettementHotelResponseBodyModuleDataList setCheckoutDate(String checkoutDate) {
            this.checkoutDate = checkoutDate;
            return this;
        }
        public String getCheckoutDate() {
            return this.checkoutDate;
        }

        public BillSettementHotelResponseBodyModuleDataList setCity(String city) {
            this.city = city;
            return this;
        }
        public String getCity() {
            return this.city;
        }

        public BillSettementHotelResponseBodyModuleDataList setCityCode(String cityCode) {
            this.cityCode = cityCode;
            return this;
        }
        public String getCityCode() {
            return this.cityCode;
        }

        public BillSettementHotelResponseBodyModuleDataList setCorpRefundFee(Double corpRefundFee) {
            this.corpRefundFee = corpRefundFee;
            return this;
        }
        public Double getCorpRefundFee() {
            return this.corpRefundFee;
        }

        public BillSettementHotelResponseBodyModuleDataList setCorpTotalFee(Double corpTotalFee) {
            this.corpTotalFee = corpTotalFee;
            return this;
        }
        public Double getCorpTotalFee() {
            return this.corpTotalFee;
        }

        public BillSettementHotelResponseBodyModuleDataList setCostCenter(String costCenter) {
            this.costCenter = costCenter;
            return this;
        }
        public String getCostCenter() {
            return this.costCenter;
        }

        public BillSettementHotelResponseBodyModuleDataList setCostCenterNumber(String costCenterNumber) {
            this.costCenterNumber = costCenterNumber;
            return this;
        }
        public String getCostCenterNumber() {
            return this.costCenterNumber;
        }

        public BillSettementHotelResponseBodyModuleDataList setDepartment(String department) {
            this.department = department;
            return this;
        }
        public String getDepartment() {
            return this.department;
        }

        public BillSettementHotelResponseBodyModuleDataList setDepartmentId(String departmentId) {
            this.departmentId = departmentId;
            return this;
        }
        public String getDepartmentId() {
            return this.departmentId;
        }

        public BillSettementHotelResponseBodyModuleDataList setFeeType(String feeType) {
            this.feeType = feeType;
            return this;
        }
        public String getFeeType() {
            return this.feeType;
        }

        public BillSettementHotelResponseBodyModuleDataList setFees(Double fees) {
            this.fees = fees;
            return this;
        }
        public Double getFees() {
            return this.fees;
        }

        public BillSettementHotelResponseBodyModuleDataList setFuPointFee(Double fuPointFee) {
            this.fuPointFee = fuPointFee;
            return this;
        }
        public Double getFuPointFee() {
            return this.fuPointFee;
        }

        public BillSettementHotelResponseBodyModuleDataList setHotelName(String hotelName) {
            this.hotelName = hotelName;
            return this;
        }
        public String getHotelName() {
            return this.hotelName;
        }

        public BillSettementHotelResponseBodyModuleDataList setIndex(String index) {
            this.index = index;
            return this;
        }
        public String getIndex() {
            return this.index;
        }

        public BillSettementHotelResponseBodyModuleDataList setInvoiceTitle(String invoiceTitle) {
            this.invoiceTitle = invoiceTitle;
            return this;
        }
        public String getInvoiceTitle() {
            return this.invoiceTitle;
        }

        public BillSettementHotelResponseBodyModuleDataList setIsNegotiation(Boolean isNegotiation) {
            this.isNegotiation = isNegotiation;
            return this;
        }
        public Boolean getIsNegotiation() {
            return this.isNegotiation;
        }

        public BillSettementHotelResponseBodyModuleDataList setIsShareStr(String isShareStr) {
            this.isShareStr = isShareStr;
            return this;
        }
        public String getIsShareStr() {
            return this.isShareStr;
        }

        public BillSettementHotelResponseBodyModuleDataList setNights(Long nights) {
            this.nights = nights;
            return this;
        }
        public Long getNights() {
            return this.nights;
        }

        public BillSettementHotelResponseBodyModuleDataList setOrderId(String orderId) {
            this.orderId = orderId;
            return this;
        }
        public String getOrderId() {
            return this.orderId;
        }

        public BillSettementHotelResponseBodyModuleDataList setOrderPrice(Double orderPrice) {
            this.orderPrice = orderPrice;
            return this;
        }
        public Double getOrderPrice() {
            return this.orderPrice;
        }

        public BillSettementHotelResponseBodyModuleDataList setOrderType(String orderType) {
            this.orderType = orderType;
            return this;
        }
        public String getOrderType() {
            return this.orderType;
        }

        public BillSettementHotelResponseBodyModuleDataList setOverApplyId(String overApplyId) {
            this.overApplyId = overApplyId;
            return this;
        }
        public String getOverApplyId() {
            return this.overApplyId;
        }

        public BillSettementHotelResponseBodyModuleDataList setPersonRefundFee(Double personRefundFee) {
            this.personRefundFee = personRefundFee;
            return this;
        }
        public Double getPersonRefundFee() {
            return this.personRefundFee;
        }

        public BillSettementHotelResponseBodyModuleDataList setPersonSettlePrice(Double personSettlePrice) {
            this.personSettlePrice = personSettlePrice;
            return this;
        }
        public Double getPersonSettlePrice() {
            return this.personSettlePrice;
        }

        public BillSettementHotelResponseBodyModuleDataList setPrimaryId(Long primaryId) {
            this.primaryId = primaryId;
            return this;
        }
        public Long getPrimaryId() {
            return this.primaryId;
        }

        public BillSettementHotelResponseBodyModuleDataList setProjectCode(String projectCode) {
            this.projectCode = projectCode;
            return this;
        }
        public String getProjectCode() {
            return this.projectCode;
        }

        public BillSettementHotelResponseBodyModuleDataList setProjectName(String projectName) {
            this.projectName = projectName;
            return this;
        }
        public String getProjectName() {
            return this.projectName;
        }

        public BillSettementHotelResponseBodyModuleDataList setPromotionFee(Double promotionFee) {
            this.promotionFee = promotionFee;
            return this;
        }
        public Double getPromotionFee() {
            return this.promotionFee;
        }

        public BillSettementHotelResponseBodyModuleDataList setRemark(String remark) {
            this.remark = remark;
            return this;
        }
        public String getRemark() {
            return this.remark;
        }

        public BillSettementHotelResponseBodyModuleDataList setRoomNumber(Long roomNumber) {
            this.roomNumber = roomNumber;
            return this;
        }
        public Long getRoomNumber() {
            return this.roomNumber;
        }

        public BillSettementHotelResponseBodyModuleDataList setRoomPrice(Double roomPrice) {
            this.roomPrice = roomPrice;
            return this;
        }
        public Double getRoomPrice() {
            return this.roomPrice;
        }

        public BillSettementHotelResponseBodyModuleDataList setRoomType(String roomType) {
            this.roomType = roomType;
            return this;
        }
        public String getRoomType() {
            return this.roomType;
        }

        public BillSettementHotelResponseBodyModuleDataList setServiceFee(Double serviceFee) {
            this.serviceFee = serviceFee;
            return this;
        }
        public Double getServiceFee() {
            return this.serviceFee;
        }

        public BillSettementHotelResponseBodyModuleDataList setSettlementFee(Double settlementFee) {
            this.settlementFee = settlementFee;
            return this;
        }
        public Double getSettlementFee() {
            return this.settlementFee;
        }

        public BillSettementHotelResponseBodyModuleDataList setSettlementGrantFee(Double settlementGrantFee) {
            this.settlementGrantFee = settlementGrantFee;
            return this;
        }
        public Double getSettlementGrantFee() {
            return this.settlementGrantFee;
        }

        public BillSettementHotelResponseBodyModuleDataList setSettlementTime(String settlementTime) {
            this.settlementTime = settlementTime;
            return this;
        }
        public String getSettlementTime() {
            return this.settlementTime;
        }

        public BillSettementHotelResponseBodyModuleDataList setSettlementType(String settlementType) {
            this.settlementType = settlementType;
            return this;
        }
        public String getSettlementType() {
            return this.settlementType;
        }

        public BillSettementHotelResponseBodyModuleDataList setStatus(Long status) {
            this.status = status;
            return this;
        }
        public Long getStatus() {
            return this.status;
        }

        public BillSettementHotelResponseBodyModuleDataList setTotalNights(Long totalNights) {
            this.totalNights = totalNights;
            return this;
        }
        public Long getTotalNights() {
            return this.totalNights;
        }

        public BillSettementHotelResponseBodyModuleDataList setTravelerId(String travelerId) {
            this.travelerId = travelerId;
            return this;
        }
        public String getTravelerId() {
            return this.travelerId;
        }

        public BillSettementHotelResponseBodyModuleDataList setTravelerJobNo(String travelerJobNo) {
            this.travelerJobNo = travelerJobNo;
            return this;
        }
        public String getTravelerJobNo() {
            return this.travelerJobNo;
        }

        public BillSettementHotelResponseBodyModuleDataList setTravelerName(String travelerName) {
            this.travelerName = travelerName;
            return this;
        }
        public String getTravelerName() {
            return this.travelerName;
        }

        public BillSettementHotelResponseBodyModuleDataList setVoucherType(Long voucherType) {
            this.voucherType = voucherType;
            return this;
        }
        public Long getVoucherType() {
            return this.voucherType;
        }

    }

    public static class BillSettementHotelResponseBodyModule extends TeaModel {
        /**
         * <p>类目</p>
         */
        @NameInMap("category")
        public Long category;

        /**
         * <p>企业id</p>
         */
        @NameInMap("corpId")
        public String corpId;

        /**
         * <p>数据集合</p>
         */
        @NameInMap("dataList")
        public java.util.List<BillSettementHotelResponseBodyModuleDataList> dataList;

        /**
         * <p>记账更新结束日期</p>
         */
        @NameInMap("periodEnd")
        public String periodEnd;

        /**
         * <p>记账更新开始日期</p>
         */
        @NameInMap("periodStart")
        public String periodStart;

        /**
         * <p>总数据量</p>
         */
        @NameInMap("totalNum")
        public Long totalNum;

        public static BillSettementHotelResponseBodyModule build(java.util.Map<String, ?> map) throws Exception {
            BillSettementHotelResponseBodyModule self = new BillSettementHotelResponseBodyModule();
            return TeaModel.build(map, self);
        }

        public BillSettementHotelResponseBodyModule setCategory(Long category) {
            this.category = category;
            return this;
        }
        public Long getCategory() {
            return this.category;
        }

        public BillSettementHotelResponseBodyModule setCorpId(String corpId) {
            this.corpId = corpId;
            return this;
        }
        public String getCorpId() {
            return this.corpId;
        }

        public BillSettementHotelResponseBodyModule setDataList(java.util.List<BillSettementHotelResponseBodyModuleDataList> dataList) {
            this.dataList = dataList;
            return this;
        }
        public java.util.List<BillSettementHotelResponseBodyModuleDataList> getDataList() {
            return this.dataList;
        }

        public BillSettementHotelResponseBodyModule setPeriodEnd(String periodEnd) {
            this.periodEnd = periodEnd;
            return this;
        }
        public String getPeriodEnd() {
            return this.periodEnd;
        }

        public BillSettementHotelResponseBodyModule setPeriodStart(String periodStart) {
            this.periodStart = periodStart;
            return this;
        }
        public String getPeriodStart() {
            return this.periodStart;
        }

        public BillSettementHotelResponseBodyModule setTotalNum(Long totalNum) {
            this.totalNum = totalNum;
            return this;
        }
        public Long getTotalNum() {
            return this.totalNum;
        }

    }

}
