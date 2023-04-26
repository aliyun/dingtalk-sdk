// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkalitrip_1_0.models;

import com.aliyun.tea.*;

public class BillSettementFlightResponseBody extends TeaModel {
    @NameInMap("module")
    public BillSettementFlightResponseBodyModule module;

    @NameInMap("resultCode")
    public Long resultCode;

    @NameInMap("resultMsg")
    public String resultMsg;

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
        @NameInMap("advanceDay")
        public Long advanceDay;

        @NameInMap("airlineCorpCode")
        public String airlineCorpCode;

        @NameInMap("airlineCorpName")
        public String airlineCorpName;

        @NameInMap("alipayTradeNo")
        public String alipayTradeNo;

        @NameInMap("applyId")
        public String applyId;

        @NameInMap("arrAirportCode")
        public String arrAirportCode;

        @NameInMap("arrCity")
        public String arrCity;

        @NameInMap("arrDate")
        public String arrDate;

        @NameInMap("arrStation")
        public String arrStation;

        @NameInMap("arrTime")
        public String arrTime;

        @NameInMap("billRecordTime")
        public String billRecordTime;

        @NameInMap("bookTime")
        public String bookTime;

        @NameInMap("bookerId")
        public String bookerId;

        @NameInMap("bookerJobNo")
        public String bookerJobNo;

        @NameInMap("bookerName")
        public String bookerName;

        @NameInMap("btripCouponFee")
        public Double btripCouponFee;

        @NameInMap("buildFee")
        public Double buildFee;

        @NameInMap("cabin")
        public String cabin;

        @NameInMap("cabinClass")
        public String cabinClass;

        @NameInMap("capitalDirection")
        public String capitalDirection;

        @NameInMap("cascadeDepartment")
        public String cascadeDepartment;

        @NameInMap("changeFee")
        public Double changeFee;

        @NameInMap("corpPayOrderFee")
        public Double corpPayOrderFee;

        @NameInMap("costCenter")
        public String costCenter;

        @NameInMap("costCenterNumber")
        public String costCenterNumber;

        @NameInMap("coupon")
        public Double coupon;

        @NameInMap("depAirportCode")
        public String depAirportCode;

        @NameInMap("department")
        public String department;

        @NameInMap("departmentId")
        public String departmentId;

        @NameInMap("deptCity")
        public String deptCity;

        @NameInMap("deptDate")
        public String deptDate;

        @NameInMap("deptStation")
        public String deptStation;

        @NameInMap("deptTime")
        public String deptTime;

        @NameInMap("discount")
        public String discount;

        @NameInMap("feeType")
        public String feeType;

        @NameInMap("flightNo")
        public String flightNo;

        @NameInMap("index")
        public String index;

        @NameInMap("insuranceFee")
        public Double insuranceFee;

        @NameInMap("invoiceTitle")
        public String invoiceTitle;

        @NameInMap("itineraryNum")
        public String itineraryNum;

        @NameInMap("itineraryPrice")
        public Double itineraryPrice;

        @NameInMap("mostDifferenceDeptTime")
        public String mostDifferenceDeptTime;

        @NameInMap("mostDifferenceDiscount")
        public String mostDifferenceDiscount;

        @NameInMap("mostDifferenceFlightNo")
        public String mostDifferenceFlightNo;

        @NameInMap("mostDifferencePrice")
        public Double mostDifferencePrice;

        @NameInMap("mostDifferenceReason")
        public String mostDifferenceReason;

        @NameInMap("mostPrice")
        public Double mostPrice;

        @NameInMap("negotiationCouponFee")
        public Double negotiationCouponFee;

        @NameInMap("oilFee")
        public Double oilFee;

        @NameInMap("orderId")
        public String orderId;

        @NameInMap("overApplyId")
        public String overApplyId;

        @NameInMap("primaryId")
        public Long primaryId;

        @NameInMap("projectCode")
        public String projectCode;

        @NameInMap("projectName")
        public String projectName;

        @NameInMap("refundFee")
        public Double refundFee;

        @NameInMap("refundUpgradeCost")
        public Double refundUpgradeCost;

        @NameInMap("remark")
        public String remark;

        @NameInMap("repeatRefund")
        public String repeatRefund;

        @NameInMap("sealPrice")
        public Double sealPrice;

        @NameInMap("serviceFee")
        public Double serviceFee;

        @NameInMap("settlementFee")
        public Double settlementFee;

        @NameInMap("settlementGrantFee")
        public Double settlementGrantFee;

        @NameInMap("settlementTime")
        public String settlementTime;

        @NameInMap("settlementType")
        public String settlementType;

        @NameInMap("status")
        public Long status;

        @NameInMap("ticketId")
        public String ticketId;

        @NameInMap("travelerId")
        public String travelerId;

        @NameInMap("travelerJobNo")
        public String travelerJobNo;

        @NameInMap("travelerName")
        public String travelerName;

        @NameInMap("upgradeCost")
        public Double upgradeCost;

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
        @NameInMap("category")
        public Long category;

        @NameInMap("corpId")
        public String corpId;

        @NameInMap("dataList")
        public java.util.List<BillSettementFlightResponseBodyModuleDataList> dataList;

        @NameInMap("periodEnd")
        public String periodEnd;

        @NameInMap("periodStart")
        public String periodStart;

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
