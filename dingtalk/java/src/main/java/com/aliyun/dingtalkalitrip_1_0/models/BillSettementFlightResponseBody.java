// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkalitrip_1_0.models;

import com.aliyun.tea.*;

public class BillSettementFlightResponseBody extends TeaModel {
    /**
     * <p>module</p>
     */
    @NameInMap("module")
    public BillSettementFlightResponseBodyModule module;

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

    public static BillSettementFlightResponseBody build(java.util.Map<String, ?> map) throws Exception {
        BillSettementFlightResponseBody self = new BillSettementFlightResponseBody();
        return TeaModel.build(map, self);
    }

    public BillSettementFlightResponseBody setModule(BillSettementFlightResponseBodyModule module) {
        this.module = module;
        return this;
    }
    public BillSettementFlightResponseBodyModule getModule() {
        return this.module;
    }

    public BillSettementFlightResponseBody setResultCode(Long resultCode) {
        this.resultCode = resultCode;
        return this;
    }
    public Long getResultCode() {
        return this.resultCode;
    }

    public BillSettementFlightResponseBody setResultMsg(String resultMsg) {
        this.resultMsg = resultMsg;
        return this;
    }
    public String getResultMsg() {
        return this.resultMsg;
    }

    public BillSettementFlightResponseBody setSuccess(Boolean success) {
        this.success = success;
        return this;
    }
    public Boolean getSuccess() {
        return this.success;
    }

    public static class BillSettementFlightResponseBodyModuleDataList extends TeaModel {
        /**
         * <p>提前预定天数</p>
         */
        @NameInMap("advanceDay")
        public Long advanceDay;

        /**
         * <p>航司三字码</p>
         */
        @NameInMap("airlineCorpCode")
        public String airlineCorpCode;

        /**
         * <p>航司名称</p>
         */
        @NameInMap("airlineCorpName")
        public String airlineCorpName;

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
         * <p>到达机场二字码</p>
         */
        @NameInMap("arrAirportCode")
        public String arrAirportCode;

        /**
         * <p>到达城市</p>
         */
        @NameInMap("arrCity")
        public String arrCity;

        /**
         * <p>到达日期</p>
         */
        @NameInMap("arrDate")
        public String arrDate;

        /**
         * <p>到达机场</p>
         */
        @NameInMap("arrStation")
        public String arrStation;

        /**
         * <p>到达时间</p>
         */
        @NameInMap("arrTime")
        public String arrTime;

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
         * <p>预订人use id</p>
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
         * <p>商旅优惠金额</p>
         */
        @NameInMap("btripCouponFee")
        public Double btripCouponFee;

        /**
         * <p>基建费</p>
         */
        @NameInMap("buildFee")
        public Double buildFee;

        /**
         * <p>舱位</p>
         */
        @NameInMap("cabin")
        public String cabin;

        /**
         * <p>舱位码</p>
         */
        @NameInMap("cabinClass")
        public String cabinClass;

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
         * <p>改签费用</p>
         */
        @NameInMap("changeFee")
        public Double changeFee;

        /**
         * <p>订单金额</p>
         */
        @NameInMap("corpPayOrderFee")
        public Double corpPayOrderFee;

        /**
         * <p>成本中心名称</p>
         */
        @NameInMap("costCenter")
        public String costCenter;

        /**
         * <p>成本中心编号</p>
         */
        @NameInMap("costCenterNumber")
        public String costCenterNumber;

        /**
         * <p>优惠券</p>
         */
        @NameInMap("coupon")
        public Double coupon;

        /**
         * <p>起飞机场二字码</p>
         */
        @NameInMap("depAirportCode")
        public String depAirportCode;

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
         * <p>起飞城市</p>
         */
        @NameInMap("deptCity")
        public String deptCity;

        /**
         * <p>起飞日期</p>
         */
        @NameInMap("deptDate")
        public String deptDate;

        /**
         * <p>起飞机场</p>
         */
        @NameInMap("deptStation")
        public String deptStation;

        /**
         * <p>起飞时间</p>
         */
        @NameInMap("deptTime")
        public String deptTime;

        /**
         * <p>折扣率</p>
         */
        @NameInMap("discount")
        public String discount;

        /**
         * <p>费用类型</p>
         */
        @NameInMap("feeType")
        public String feeType;

        /**
         * <p>航班号</p>
         */
        @NameInMap("flightNo")
        public String flightNo;

        /**
         * <p>序号</p>
         */
        @NameInMap("index")
        public String index;

        /**
         * <p>保险费</p>
         */
        @NameInMap("insuranceFee")
        public Double insuranceFee;

        /**
         * <p>发票抬头</p>
         */
        @NameInMap("invoiceTitle")
        public String invoiceTitle;

        /**
         * <p>行程单打印序号</p>
         */
        @NameInMap("itineraryNum")
        public String itineraryNum;

        /**
         * <p>行程单金额</p>
         */
        @NameInMap("itineraryPrice")
        public Double itineraryPrice;

        /**
         * <p>低价提醒（起飞时间）</p>
         */
        @NameInMap("mostDifferenceDeptTime")
        public String mostDifferenceDeptTime;

        /**
         * <p>低价提醒（折扣）</p>
         */
        @NameInMap("mostDifferenceDiscount")
        public String mostDifferenceDiscount;

        /**
         * <p>低价提醒(航班号)</p>
         */
        @NameInMap("mostDifferenceFlightNo")
        public String mostDifferenceFlightNo;

        /**
         * <p>低价提醒(与最低价差额)</p>
         */
        @NameInMap("mostDifferencePrice")
        public Double mostDifferencePrice;

        /**
         * <p>不选低价原因</p>
         */
        @NameInMap("mostDifferenceReason")
        public String mostDifferenceReason;

        /**
         * <p>低价航班价格</p>
         */
        @NameInMap("mostPrice")
        public Double mostPrice;

        /**
         * <p>协议价优惠金额</p>
         */
        @NameInMap("negotiationCouponFee")
        public Double negotiationCouponFee;

        /**
         * <p>燃油费</p>
         */
        @NameInMap("oilFee")
        public Double oilFee;

        /**
         * <p>订单号</p>
         */
        @NameInMap("orderId")
        public String orderId;

        /**
         * <p>超标审批单号</p>
         */
        @NameInMap("overApplyId")
        public String overApplyId;

        /**
         * <p>主键id</p>
         */
        @NameInMap("primaryId")
        public Long primaryId;

        /**
         * <p>项目代码</p>
         */
        @NameInMap("projectCode")
        public String projectCode;

        /**
         * <p>项目名称</p>
         */
        @NameInMap("projectName")
        public String projectName;

        /**
         * <p>退款手续费</p>
         */
        @NameInMap("refundFee")
        public Double refundFee;

        /**
         * <p>改签退票手续费</p>
         */
        @NameInMap("refundUpgradeCost")
        public Double refundUpgradeCost;

        /**
         * <p>备注</p>
         */
        @NameInMap("remark")
        public String remark;

        /**
         * <p>是否重复退</p>
         */
        @NameInMap("repeatRefund")
        public String repeatRefund;

        /**
         * <p>销售价</p>
         */
        @NameInMap("sealPrice")
        public Double sealPrice;

        /**
         * <p>服务费，仅在feeType  11001、11002中展示</p>
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
         * <p>行程单号</p>
         */
        @NameInMap("ticketId")
        public String ticketId;

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
         * <p>改签差价</p>
         */
        @NameInMap("upgradeCost")
        public Double upgradeCost;

        /**
         * <p>发票类型</p>
         */
        @NameInMap("voucherType")
        public Long voucherType;

        public static BillSettementFlightResponseBodyModuleDataList build(java.util.Map<String, ?> map) throws Exception {
            BillSettementFlightResponseBodyModuleDataList self = new BillSettementFlightResponseBodyModuleDataList();
            return TeaModel.build(map, self);
        }

        public BillSettementFlightResponseBodyModuleDataList setAdvanceDay(Long advanceDay) {
            this.advanceDay = advanceDay;
            return this;
        }
        public Long getAdvanceDay() {
            return this.advanceDay;
        }

        public BillSettementFlightResponseBodyModuleDataList setAirlineCorpCode(String airlineCorpCode) {
            this.airlineCorpCode = airlineCorpCode;
            return this;
        }
        public String getAirlineCorpCode() {
            return this.airlineCorpCode;
        }

        public BillSettementFlightResponseBodyModuleDataList setAirlineCorpName(String airlineCorpName) {
            this.airlineCorpName = airlineCorpName;
            return this;
        }
        public String getAirlineCorpName() {
            return this.airlineCorpName;
        }

        public BillSettementFlightResponseBodyModuleDataList setAlipayTradeNo(String alipayTradeNo) {
            this.alipayTradeNo = alipayTradeNo;
            return this;
        }
        public String getAlipayTradeNo() {
            return this.alipayTradeNo;
        }

        public BillSettementFlightResponseBodyModuleDataList setApplyId(String applyId) {
            this.applyId = applyId;
            return this;
        }
        public String getApplyId() {
            return this.applyId;
        }

        public BillSettementFlightResponseBodyModuleDataList setArrAirportCode(String arrAirportCode) {
            this.arrAirportCode = arrAirportCode;
            return this;
        }
        public String getArrAirportCode() {
            return this.arrAirportCode;
        }

        public BillSettementFlightResponseBodyModuleDataList setArrCity(String arrCity) {
            this.arrCity = arrCity;
            return this;
        }
        public String getArrCity() {
            return this.arrCity;
        }

        public BillSettementFlightResponseBodyModuleDataList setArrDate(String arrDate) {
            this.arrDate = arrDate;
            return this;
        }
        public String getArrDate() {
            return this.arrDate;
        }

        public BillSettementFlightResponseBodyModuleDataList setArrStation(String arrStation) {
            this.arrStation = arrStation;
            return this;
        }
        public String getArrStation() {
            return this.arrStation;
        }

        public BillSettementFlightResponseBodyModuleDataList setArrTime(String arrTime) {
            this.arrTime = arrTime;
            return this;
        }
        public String getArrTime() {
            return this.arrTime;
        }

        public BillSettementFlightResponseBodyModuleDataList setBillRecordTime(String billRecordTime) {
            this.billRecordTime = billRecordTime;
            return this;
        }
        public String getBillRecordTime() {
            return this.billRecordTime;
        }

        public BillSettementFlightResponseBodyModuleDataList setBookTime(String bookTime) {
            this.bookTime = bookTime;
            return this;
        }
        public String getBookTime() {
            return this.bookTime;
        }

        public BillSettementFlightResponseBodyModuleDataList setBookerId(String bookerId) {
            this.bookerId = bookerId;
            return this;
        }
        public String getBookerId() {
            return this.bookerId;
        }

        public BillSettementFlightResponseBodyModuleDataList setBookerJobNo(String bookerJobNo) {
            this.bookerJobNo = bookerJobNo;
            return this;
        }
        public String getBookerJobNo() {
            return this.bookerJobNo;
        }

        public BillSettementFlightResponseBodyModuleDataList setBookerName(String bookerName) {
            this.bookerName = bookerName;
            return this;
        }
        public String getBookerName() {
            return this.bookerName;
        }

        public BillSettementFlightResponseBodyModuleDataList setBtripCouponFee(Double btripCouponFee) {
            this.btripCouponFee = btripCouponFee;
            return this;
        }
        public Double getBtripCouponFee() {
            return this.btripCouponFee;
        }

        public BillSettementFlightResponseBodyModuleDataList setBuildFee(Double buildFee) {
            this.buildFee = buildFee;
            return this;
        }
        public Double getBuildFee() {
            return this.buildFee;
        }

        public BillSettementFlightResponseBodyModuleDataList setCabin(String cabin) {
            this.cabin = cabin;
            return this;
        }
        public String getCabin() {
            return this.cabin;
        }

        public BillSettementFlightResponseBodyModuleDataList setCabinClass(String cabinClass) {
            this.cabinClass = cabinClass;
            return this;
        }
        public String getCabinClass() {
            return this.cabinClass;
        }

        public BillSettementFlightResponseBodyModuleDataList setCapitalDirection(String capitalDirection) {
            this.capitalDirection = capitalDirection;
            return this;
        }
        public String getCapitalDirection() {
            return this.capitalDirection;
        }

        public BillSettementFlightResponseBodyModuleDataList setCascadeDepartment(String cascadeDepartment) {
            this.cascadeDepartment = cascadeDepartment;
            return this;
        }
        public String getCascadeDepartment() {
            return this.cascadeDepartment;
        }

        public BillSettementFlightResponseBodyModuleDataList setChangeFee(Double changeFee) {
            this.changeFee = changeFee;
            return this;
        }
        public Double getChangeFee() {
            return this.changeFee;
        }

        public BillSettementFlightResponseBodyModuleDataList setCorpPayOrderFee(Double corpPayOrderFee) {
            this.corpPayOrderFee = corpPayOrderFee;
            return this;
        }
        public Double getCorpPayOrderFee() {
            return this.corpPayOrderFee;
        }

        public BillSettementFlightResponseBodyModuleDataList setCostCenter(String costCenter) {
            this.costCenter = costCenter;
            return this;
        }
        public String getCostCenter() {
            return this.costCenter;
        }

        public BillSettementFlightResponseBodyModuleDataList setCostCenterNumber(String costCenterNumber) {
            this.costCenterNumber = costCenterNumber;
            return this;
        }
        public String getCostCenterNumber() {
            return this.costCenterNumber;
        }

        public BillSettementFlightResponseBodyModuleDataList setCoupon(Double coupon) {
            this.coupon = coupon;
            return this;
        }
        public Double getCoupon() {
            return this.coupon;
        }

        public BillSettementFlightResponseBodyModuleDataList setDepAirportCode(String depAirportCode) {
            this.depAirportCode = depAirportCode;
            return this;
        }
        public String getDepAirportCode() {
            return this.depAirportCode;
        }

        public BillSettementFlightResponseBodyModuleDataList setDepartment(String department) {
            this.department = department;
            return this;
        }
        public String getDepartment() {
            return this.department;
        }

        public BillSettementFlightResponseBodyModuleDataList setDepartmentId(String departmentId) {
            this.departmentId = departmentId;
            return this;
        }
        public String getDepartmentId() {
            return this.departmentId;
        }

        public BillSettementFlightResponseBodyModuleDataList setDeptCity(String deptCity) {
            this.deptCity = deptCity;
            return this;
        }
        public String getDeptCity() {
            return this.deptCity;
        }

        public BillSettementFlightResponseBodyModuleDataList setDeptDate(String deptDate) {
            this.deptDate = deptDate;
            return this;
        }
        public String getDeptDate() {
            return this.deptDate;
        }

        public BillSettementFlightResponseBodyModuleDataList setDeptStation(String deptStation) {
            this.deptStation = deptStation;
            return this;
        }
        public String getDeptStation() {
            return this.deptStation;
        }

        public BillSettementFlightResponseBodyModuleDataList setDeptTime(String deptTime) {
            this.deptTime = deptTime;
            return this;
        }
        public String getDeptTime() {
            return this.deptTime;
        }

        public BillSettementFlightResponseBodyModuleDataList setDiscount(String discount) {
            this.discount = discount;
            return this;
        }
        public String getDiscount() {
            return this.discount;
        }

        public BillSettementFlightResponseBodyModuleDataList setFeeType(String feeType) {
            this.feeType = feeType;
            return this;
        }
        public String getFeeType() {
            return this.feeType;
        }

        public BillSettementFlightResponseBodyModuleDataList setFlightNo(String flightNo) {
            this.flightNo = flightNo;
            return this;
        }
        public String getFlightNo() {
            return this.flightNo;
        }

        public BillSettementFlightResponseBodyModuleDataList setIndex(String index) {
            this.index = index;
            return this;
        }
        public String getIndex() {
            return this.index;
        }

        public BillSettementFlightResponseBodyModuleDataList setInsuranceFee(Double insuranceFee) {
            this.insuranceFee = insuranceFee;
            return this;
        }
        public Double getInsuranceFee() {
            return this.insuranceFee;
        }

        public BillSettementFlightResponseBodyModuleDataList setInvoiceTitle(String invoiceTitle) {
            this.invoiceTitle = invoiceTitle;
            return this;
        }
        public String getInvoiceTitle() {
            return this.invoiceTitle;
        }

        public BillSettementFlightResponseBodyModuleDataList setItineraryNum(String itineraryNum) {
            this.itineraryNum = itineraryNum;
            return this;
        }
        public String getItineraryNum() {
            return this.itineraryNum;
        }

        public BillSettementFlightResponseBodyModuleDataList setItineraryPrice(Double itineraryPrice) {
            this.itineraryPrice = itineraryPrice;
            return this;
        }
        public Double getItineraryPrice() {
            return this.itineraryPrice;
        }

        public BillSettementFlightResponseBodyModuleDataList setMostDifferenceDeptTime(String mostDifferenceDeptTime) {
            this.mostDifferenceDeptTime = mostDifferenceDeptTime;
            return this;
        }
        public String getMostDifferenceDeptTime() {
            return this.mostDifferenceDeptTime;
        }

        public BillSettementFlightResponseBodyModuleDataList setMostDifferenceDiscount(String mostDifferenceDiscount) {
            this.mostDifferenceDiscount = mostDifferenceDiscount;
            return this;
        }
        public String getMostDifferenceDiscount() {
            return this.mostDifferenceDiscount;
        }

        public BillSettementFlightResponseBodyModuleDataList setMostDifferenceFlightNo(String mostDifferenceFlightNo) {
            this.mostDifferenceFlightNo = mostDifferenceFlightNo;
            return this;
        }
        public String getMostDifferenceFlightNo() {
            return this.mostDifferenceFlightNo;
        }

        public BillSettementFlightResponseBodyModuleDataList setMostDifferencePrice(Double mostDifferencePrice) {
            this.mostDifferencePrice = mostDifferencePrice;
            return this;
        }
        public Double getMostDifferencePrice() {
            return this.mostDifferencePrice;
        }

        public BillSettementFlightResponseBodyModuleDataList setMostDifferenceReason(String mostDifferenceReason) {
            this.mostDifferenceReason = mostDifferenceReason;
            return this;
        }
        public String getMostDifferenceReason() {
            return this.mostDifferenceReason;
        }

        public BillSettementFlightResponseBodyModuleDataList setMostPrice(Double mostPrice) {
            this.mostPrice = mostPrice;
            return this;
        }
        public Double getMostPrice() {
            return this.mostPrice;
        }

        public BillSettementFlightResponseBodyModuleDataList setNegotiationCouponFee(Double negotiationCouponFee) {
            this.negotiationCouponFee = negotiationCouponFee;
            return this;
        }
        public Double getNegotiationCouponFee() {
            return this.negotiationCouponFee;
        }

        public BillSettementFlightResponseBodyModuleDataList setOilFee(Double oilFee) {
            this.oilFee = oilFee;
            return this;
        }
        public Double getOilFee() {
            return this.oilFee;
        }

        public BillSettementFlightResponseBodyModuleDataList setOrderId(String orderId) {
            this.orderId = orderId;
            return this;
        }
        public String getOrderId() {
            return this.orderId;
        }

        public BillSettementFlightResponseBodyModuleDataList setOverApplyId(String overApplyId) {
            this.overApplyId = overApplyId;
            return this;
        }
        public String getOverApplyId() {
            return this.overApplyId;
        }

        public BillSettementFlightResponseBodyModuleDataList setPrimaryId(Long primaryId) {
            this.primaryId = primaryId;
            return this;
        }
        public Long getPrimaryId() {
            return this.primaryId;
        }

        public BillSettementFlightResponseBodyModuleDataList setProjectCode(String projectCode) {
            this.projectCode = projectCode;
            return this;
        }
        public String getProjectCode() {
            return this.projectCode;
        }

        public BillSettementFlightResponseBodyModuleDataList setProjectName(String projectName) {
            this.projectName = projectName;
            return this;
        }
        public String getProjectName() {
            return this.projectName;
        }

        public BillSettementFlightResponseBodyModuleDataList setRefundFee(Double refundFee) {
            this.refundFee = refundFee;
            return this;
        }
        public Double getRefundFee() {
            return this.refundFee;
        }

        public BillSettementFlightResponseBodyModuleDataList setRefundUpgradeCost(Double refundUpgradeCost) {
            this.refundUpgradeCost = refundUpgradeCost;
            return this;
        }
        public Double getRefundUpgradeCost() {
            return this.refundUpgradeCost;
        }

        public BillSettementFlightResponseBodyModuleDataList setRemark(String remark) {
            this.remark = remark;
            return this;
        }
        public String getRemark() {
            return this.remark;
        }

        public BillSettementFlightResponseBodyModuleDataList setRepeatRefund(String repeatRefund) {
            this.repeatRefund = repeatRefund;
            return this;
        }
        public String getRepeatRefund() {
            return this.repeatRefund;
        }

        public BillSettementFlightResponseBodyModuleDataList setSealPrice(Double sealPrice) {
            this.sealPrice = sealPrice;
            return this;
        }
        public Double getSealPrice() {
            return this.sealPrice;
        }

        public BillSettementFlightResponseBodyModuleDataList setServiceFee(Double serviceFee) {
            this.serviceFee = serviceFee;
            return this;
        }
        public Double getServiceFee() {
            return this.serviceFee;
        }

        public BillSettementFlightResponseBodyModuleDataList setSettlementFee(Double settlementFee) {
            this.settlementFee = settlementFee;
            return this;
        }
        public Double getSettlementFee() {
            return this.settlementFee;
        }

        public BillSettementFlightResponseBodyModuleDataList setSettlementGrantFee(Double settlementGrantFee) {
            this.settlementGrantFee = settlementGrantFee;
            return this;
        }
        public Double getSettlementGrantFee() {
            return this.settlementGrantFee;
        }

        public BillSettementFlightResponseBodyModuleDataList setSettlementTime(String settlementTime) {
            this.settlementTime = settlementTime;
            return this;
        }
        public String getSettlementTime() {
            return this.settlementTime;
        }

        public BillSettementFlightResponseBodyModuleDataList setSettlementType(String settlementType) {
            this.settlementType = settlementType;
            return this;
        }
        public String getSettlementType() {
            return this.settlementType;
        }

        public BillSettementFlightResponseBodyModuleDataList setStatus(Long status) {
            this.status = status;
            return this;
        }
        public Long getStatus() {
            return this.status;
        }

        public BillSettementFlightResponseBodyModuleDataList setTicketId(String ticketId) {
            this.ticketId = ticketId;
            return this;
        }
        public String getTicketId() {
            return this.ticketId;
        }

        public BillSettementFlightResponseBodyModuleDataList setTravelerId(String travelerId) {
            this.travelerId = travelerId;
            return this;
        }
        public String getTravelerId() {
            return this.travelerId;
        }

        public BillSettementFlightResponseBodyModuleDataList setTravelerJobNo(String travelerJobNo) {
            this.travelerJobNo = travelerJobNo;
            return this;
        }
        public String getTravelerJobNo() {
            return this.travelerJobNo;
        }

        public BillSettementFlightResponseBodyModuleDataList setTravelerName(String travelerName) {
            this.travelerName = travelerName;
            return this;
        }
        public String getTravelerName() {
            return this.travelerName;
        }

        public BillSettementFlightResponseBodyModuleDataList setUpgradeCost(Double upgradeCost) {
            this.upgradeCost = upgradeCost;
            return this;
        }
        public Double getUpgradeCost() {
            return this.upgradeCost;
        }

        public BillSettementFlightResponseBodyModuleDataList setVoucherType(Long voucherType) {
            this.voucherType = voucherType;
            return this;
        }
        public Long getVoucherType() {
            return this.voucherType;
        }

    }

    public static class BillSettementFlightResponseBodyModule extends TeaModel {
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
        public java.util.List<BillSettementFlightResponseBodyModuleDataList> dataList;

        /**
         * <p>记账更新开始日期</p>
         */
        @NameInMap("periodEnd")
        public String periodEnd;

        /**
         * <p>记账更新结束日期</p>
         */
        @NameInMap("periodStart")
        public String periodStart;

        /**
         * <p>总数据量</p>
         */
        @NameInMap("totalNum")
        public Long totalNum;

        public static BillSettementFlightResponseBodyModule build(java.util.Map<String, ?> map) throws Exception {
            BillSettementFlightResponseBodyModule self = new BillSettementFlightResponseBodyModule();
            return TeaModel.build(map, self);
        }

        public BillSettementFlightResponseBodyModule setCategory(Long category) {
            this.category = category;
            return this;
        }
        public Long getCategory() {
            return this.category;
        }

        public BillSettementFlightResponseBodyModule setCorpId(String corpId) {
            this.corpId = corpId;
            return this;
        }
        public String getCorpId() {
            return this.corpId;
        }

        public BillSettementFlightResponseBodyModule setDataList(java.util.List<BillSettementFlightResponseBodyModuleDataList> dataList) {
            this.dataList = dataList;
            return this;
        }
        public java.util.List<BillSettementFlightResponseBodyModuleDataList> getDataList() {
            return this.dataList;
        }

        public BillSettementFlightResponseBodyModule setPeriodEnd(String periodEnd) {
            this.periodEnd = periodEnd;
            return this;
        }
        public String getPeriodEnd() {
            return this.periodEnd;
        }

        public BillSettementFlightResponseBodyModule setPeriodStart(String periodStart) {
            this.periodStart = periodStart;
            return this;
        }
        public String getPeriodStart() {
            return this.periodStart;
        }

        public BillSettementFlightResponseBodyModule setTotalNum(Long totalNum) {
            this.totalNum = totalNum;
            return this;
        }
        public Long getTotalNum() {
            return this.totalNum;
        }

    }

}
