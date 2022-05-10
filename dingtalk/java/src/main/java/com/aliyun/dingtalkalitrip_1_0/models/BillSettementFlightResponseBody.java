// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkalitrip_1_0.models;

import com.aliyun.tea.*;

public class BillSettementFlightResponseBody extends TeaModel {
    // module
    @NameInMap("module")
    public BillSettementFlightResponseBodyModule module;

    // 结果code
    @NameInMap("resultCode")
    public Long resultCode;

    // 结果msg
    @NameInMap("resultMsg")
    public String resultMsg;

    // 是否成功
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
        // 提前预定天数
        @NameInMap("advanceDay")
        public Long advanceDay;

        // 航司三字码
        @NameInMap("airlineCorpCode")
        public String airlineCorpCode;

        // 航司名称
        @NameInMap("airlineCorpName")
        public String airlineCorpName;

        // 交易流水号
        @NameInMap("alipayTradeNo")
        public String alipayTradeNo;

        // 审批单号
        @NameInMap("applyId")
        public String applyId;

        // 到达机场二字码
        @NameInMap("arrAirportCode")
        public String arrAirportCode;

        // 到达城市
        @NameInMap("arrCity")
        public String arrCity;

        // 到达日期
        @NameInMap("arrDate")
        public String arrDate;

        // 到达机场
        @NameInMap("arrStation")
        public String arrStation;

        // 到达时间
        @NameInMap("arrTime")
        public String arrTime;

        // 入账时间
        @NameInMap("billRecordTime")
        public String billRecordTime;

        // 预定时间
        @NameInMap("bookTime")
        public String bookTime;

        // 预订人use id
        @NameInMap("bookerId")
        public String bookerId;

        // 预订人工号
        @NameInMap("bookerJobNo")
        public String bookerJobNo;

        // 预订人名称
        @NameInMap("bookerName")
        public String bookerName;

        // 商旅优惠金额
        @NameInMap("btripCouponFee")
        public Double btripCouponFee;

        // 基建费
        @NameInMap("buildFee")
        public Double buildFee;

        // 舱位
        @NameInMap("cabin")
        public String cabin;

        // 舱位码
        @NameInMap("cabinClass")
        public String cabinClass;

        // 资金方向
        @NameInMap("capitalDirection")
        public String capitalDirection;

        // 级联部门
        @NameInMap("cascadeDepartment")
        public String cascadeDepartment;

        // 改签费用
        @NameInMap("changeFee")
        public Double changeFee;

        // 订单金额
        @NameInMap("corpPayOrderFee")
        public Double corpPayOrderFee;

        // 成本中心名称
        @NameInMap("costCenter")
        public String costCenter;

        // 成本中心编号
        @NameInMap("costCenterNumber")
        public String costCenterNumber;

        // 优惠券
        @NameInMap("coupon")
        public Double coupon;

        // 起飞机场二字码
        @NameInMap("depAirportCode")
        public String depAirportCode;

        // 末级部门
        @NameInMap("department")
        public String department;

        // 部门id
        @NameInMap("departmentId")
        public String departmentId;

        // 起飞城市
        @NameInMap("deptCity")
        public String deptCity;

        // 起飞日期
        @NameInMap("deptDate")
        public String deptDate;

        // 起飞机场
        @NameInMap("deptStation")
        public String deptStation;

        // 起飞时间
        @NameInMap("deptTime")
        public String deptTime;

        // 折扣率
        @NameInMap("discount")
        public String discount;

        // 费用类型
        @NameInMap("feeType")
        public String feeType;

        // 航班号
        @NameInMap("flightNo")
        public String flightNo;

        // 序号
        @NameInMap("index")
        public String index;

        // 保险费
        @NameInMap("insuranceFee")
        public Double insuranceFee;

        // 发票抬头
        @NameInMap("invoiceTitle")
        public String invoiceTitle;

        // 行程单打印序号
        @NameInMap("itineraryNum")
        public String itineraryNum;

        // 行程单金额
        @NameInMap("itineraryPrice")
        public Double itineraryPrice;

        // 低价提醒（起飞时间）
        @NameInMap("mostDifferenceDeptTime")
        public String mostDifferenceDeptTime;

        // 低价提醒（折扣）
        @NameInMap("mostDifferenceDiscount")
        public String mostDifferenceDiscount;

        // 低价提醒(航班号)
        @NameInMap("mostDifferenceFlightNo")
        public String mostDifferenceFlightNo;

        // 低价提醒(与最低价差额)
        @NameInMap("mostDifferencePrice")
        public Double mostDifferencePrice;

        // 不选低价原因
        @NameInMap("mostDifferenceReason")
        public String mostDifferenceReason;

        // 低价航班价格
        @NameInMap("mostPrice")
        public Double mostPrice;

        // 协议价优惠金额
        @NameInMap("negotiationCouponFee")
        public Double negotiationCouponFee;

        // 燃油费
        @NameInMap("oilFee")
        public Double oilFee;

        // 订单号
        @NameInMap("orderId")
        public String orderId;

        // 超标审批单号
        @NameInMap("overApplyId")
        public String overApplyId;

        // 主键id
        @NameInMap("primaryId")
        public Long primaryId;

        // 项目代码
        @NameInMap("projectCode")
        public String projectCode;

        // 项目名称
        @NameInMap("projectName")
        public String projectName;

        // 退款手续费
        @NameInMap("refundFee")
        public Double refundFee;

        // 改签退票手续费
        @NameInMap("refundUpgradeCost")
        public Double refundUpgradeCost;

        // 是否重复退
        @NameInMap("repeatRefund")
        public String repeatRefund;

        // 销售价
        @NameInMap("sealPrice")
        public Double sealPrice;

        // 服务费，仅在feeType  11001、11002中展示
        @NameInMap("serviceFee")
        public Double serviceFee;

        // 结算金额
        @NameInMap("settlementFee")
        public Double settlementFee;

        // 结算时间
        @NameInMap("settlementTime")
        public String settlementTime;

        // 结算类型
        @NameInMap("settlementType")
        public String settlementType;

        // 入账状态
        @NameInMap("status")
        public Long status;

        // 行程单号
        @NameInMap("ticketId")
        public String ticketId;

        // 出行人use id
        @NameInMap("travelerId")
        public String travelerId;

        // 出行人工号
        @NameInMap("travelerJobNo")
        public String travelerJobNo;

        // 出行人名称
        @NameInMap("travelerName")
        public String travelerName;

        // 改签差价
        @NameInMap("upgradeCost")
        public Double upgradeCost;

        // 发票类型
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
        // 类目
        @NameInMap("category")
        public Long category;

        // 企业id
        @NameInMap("corpId")
        public String corpId;

        // 数据集合
        @NameInMap("dataList")
        public java.util.List<BillSettementFlightResponseBodyModuleDataList> dataList;

        // 记账更新开始日期
        @NameInMap("periodEnd")
        public String periodEnd;

        // 记账更新结束日期
        @NameInMap("periodStart")
        public String periodStart;

        // 总数据量
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
