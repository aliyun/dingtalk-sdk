// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkalitrip_1_0.models;

import com.aliyun.tea.*;

public class BillSettementCarResponseBody extends TeaModel {
    @NameInMap("module")
    public BillSettementCarResponseBodyModule module;

    @NameInMap("resultCode")
    public Long resultCode;

    @NameInMap("resultMsg")
    public String resultMsg;

    @NameInMap("success")
    public Boolean success;

    public static BillSettementCarResponseBody build(java.util.Map<String, ?> map) throws Exception {
        BillSettementCarResponseBody self = new BillSettementCarResponseBody();
        return TeaModel.build(map, self);
    }

    public BillSettementCarResponseBody setModule(BillSettementCarResponseBodyModule module) {
        this.module = module;
        return this;
    }
    public BillSettementCarResponseBodyModule getModule() {
        return this.module;
    }

    public BillSettementCarResponseBody setResultCode(Long resultCode) {
        this.resultCode = resultCode;
        return this;
    }
    public Long getResultCode() {
        return this.resultCode;
    }

    public BillSettementCarResponseBody setResultMsg(String resultMsg) {
        this.resultMsg = resultMsg;
        return this;
    }
    public String getResultMsg() {
        return this.resultMsg;
    }

    public BillSettementCarResponseBody setSuccess(Boolean success) {
        this.success = success;
        return this;
    }
    public Boolean getSuccess() {
        return this.success;
    }

    public static class BillSettementCarResponseBodyModuleDataList extends TeaModel {
        @NameInMap("alipayTradeNo")
        public String alipayTradeNo;

        @NameInMap("applyId")
        public String applyId;

        @NameInMap("arrCity")
        public String arrCity;

        @NameInMap("arrDate")
        public String arrDate;

        @NameInMap("arrLocation")
        public String arrLocation;

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

        @NameInMap("businessCategory")
        public String businessCategory;

        @NameInMap("capitalDirection")
        public String capitalDirection;

        @NameInMap("carLevel")
        public String carLevel;

        @NameInMap("cascadeDepartment")
        public String cascadeDepartment;

        @NameInMap("costCenter")
        public String costCenter;

        @NameInMap("costCenterNumber")
        public String costCenterNumber;

        @NameInMap("coupon")
        public Double coupon;

        @NameInMap("couponPrice")
        public Double couponPrice;

        @NameInMap("department")
        public String department;

        @NameInMap("departmentId")
        public String departmentId;

        @NameInMap("deptCity")
        public String deptCity;

        @NameInMap("deptDate")
        public String deptDate;

        @NameInMap("deptLocation")
        public String deptLocation;

        @NameInMap("deptTime")
        public String deptTime;

        @NameInMap("estimateDriveDistance")
        public String estimateDriveDistance;

        @NameInMap("estimatePrice")
        public Double estimatePrice;

        @NameInMap("feeType")
        public String feeType;

        @NameInMap("index")
        public String index;

        @NameInMap("invoiceTitle")
        public String invoiceTitle;

        @NameInMap("memo")
        public String memo;

        @NameInMap("orderId")
        public String orderId;

        @NameInMap("orderPrice")
        public Double orderPrice;

        @NameInMap("overApplyId")
        public String overApplyId;

        @NameInMap("personSettleFee")
        public Double personSettleFee;

        @NameInMap("primaryId")
        public String primaryId;

        @NameInMap("projectCode")
        public String projectCode;

        @NameInMap("projectName")
        public String projectName;

        @NameInMap("providerName")
        public String providerName;

        @NameInMap("realDriveDistance")
        public String realDriveDistance;

        @NameInMap("realFromAddr")
        public String realFromAddr;

        @NameInMap("realToAddr")
        public String realToAddr;

        @NameInMap("remark")
        public String remark;

        @NameInMap("serviceFee")
        public String serviceFee;

        @NameInMap("settlementFee")
        public Double settlementFee;

        @NameInMap("settlementGrantFee")
        public Double settlementGrantFee;

        @NameInMap("settlementTime")
        public String settlementTime;

        @NameInMap("settlementType")
        public String settlementType;

        @NameInMap("specialOrder")
        public String specialOrder;

        @NameInMap("specialReason")
        public String specialReason;

        @NameInMap("status")
        public Long status;

        @NameInMap("subOrderId")
        public String subOrderId;

        @NameInMap("travelerId")
        public String travelerId;

        @NameInMap("travelerJobNo")
        public String travelerJobNo;

        @NameInMap("travelerName")
        public String travelerName;

        @NameInMap("userConfirmDesc")
        public String userConfirmDesc;

        @NameInMap("voucherType")
        public Long voucherType;

        public static BillSettementCarResponseBodyModuleDataList build(java.util.Map<String, ?> map) throws Exception {
            BillSettementCarResponseBodyModuleDataList self = new BillSettementCarResponseBodyModuleDataList();
            return TeaModel.build(map, self);
        }

        public BillSettementCarResponseBodyModuleDataList setAlipayTradeNo(String alipayTradeNo) {
            this.alipayTradeNo = alipayTradeNo;
            return this;
        }
        public String getAlipayTradeNo() {
            return this.alipayTradeNo;
        }

        public BillSettementCarResponseBodyModuleDataList setApplyId(String applyId) {
            this.applyId = applyId;
            return this;
        }
        public String getApplyId() {
            return this.applyId;
        }

        public BillSettementCarResponseBodyModuleDataList setArrCity(String arrCity) {
            this.arrCity = arrCity;
            return this;
        }
        public String getArrCity() {
            return this.arrCity;
        }

        public BillSettementCarResponseBodyModuleDataList setArrDate(String arrDate) {
            this.arrDate = arrDate;
            return this;
        }
        public String getArrDate() {
            return this.arrDate;
        }

        public BillSettementCarResponseBodyModuleDataList setArrLocation(String arrLocation) {
            this.arrLocation = arrLocation;
            return this;
        }
        public String getArrLocation() {
            return this.arrLocation;
        }

        public BillSettementCarResponseBodyModuleDataList setArrTime(String arrTime) {
            this.arrTime = arrTime;
            return this;
        }
        public String getArrTime() {
            return this.arrTime;
        }

        public BillSettementCarResponseBodyModuleDataList setBillRecordTime(String billRecordTime) {
            this.billRecordTime = billRecordTime;
            return this;
        }
        public String getBillRecordTime() {
            return this.billRecordTime;
        }

        public BillSettementCarResponseBodyModuleDataList setBookTime(String bookTime) {
            this.bookTime = bookTime;
            return this;
        }
        public String getBookTime() {
            return this.bookTime;
        }

        public BillSettementCarResponseBodyModuleDataList setBookerId(String bookerId) {
            this.bookerId = bookerId;
            return this;
        }
        public String getBookerId() {
            return this.bookerId;
        }

        public BillSettementCarResponseBodyModuleDataList setBookerJobNo(String bookerJobNo) {
            this.bookerJobNo = bookerJobNo;
            return this;
        }
        public String getBookerJobNo() {
            return this.bookerJobNo;
        }

        public BillSettementCarResponseBodyModuleDataList setBookerName(String bookerName) {
            this.bookerName = bookerName;
            return this;
        }
        public String getBookerName() {
            return this.bookerName;
        }

        public BillSettementCarResponseBodyModuleDataList setBusinessCategory(String businessCategory) {
            this.businessCategory = businessCategory;
            return this;
        }
        public String getBusinessCategory() {
            return this.businessCategory;
        }

        public BillSettementCarResponseBodyModuleDataList setCapitalDirection(String capitalDirection) {
            this.capitalDirection = capitalDirection;
            return this;
        }
        public String getCapitalDirection() {
            return this.capitalDirection;
        }

        public BillSettementCarResponseBodyModuleDataList setCarLevel(String carLevel) {
            this.carLevel = carLevel;
            return this;
        }
        public String getCarLevel() {
            return this.carLevel;
        }

        public BillSettementCarResponseBodyModuleDataList setCascadeDepartment(String cascadeDepartment) {
            this.cascadeDepartment = cascadeDepartment;
            return this;
        }
        public String getCascadeDepartment() {
            return this.cascadeDepartment;
        }

        public BillSettementCarResponseBodyModuleDataList setCostCenter(String costCenter) {
            this.costCenter = costCenter;
            return this;
        }
        public String getCostCenter() {
            return this.costCenter;
        }

        public BillSettementCarResponseBodyModuleDataList setCostCenterNumber(String costCenterNumber) {
            this.costCenterNumber = costCenterNumber;
            return this;
        }
        public String getCostCenterNumber() {
            return this.costCenterNumber;
        }

        public BillSettementCarResponseBodyModuleDataList setCoupon(Double coupon) {
            this.coupon = coupon;
            return this;
        }
        public Double getCoupon() {
            return this.coupon;
        }

        public BillSettementCarResponseBodyModuleDataList setCouponPrice(Double couponPrice) {
            this.couponPrice = couponPrice;
            return this;
        }
        public Double getCouponPrice() {
            return this.couponPrice;
        }

        public BillSettementCarResponseBodyModuleDataList setDepartment(String department) {
            this.department = department;
            return this;
        }
        public String getDepartment() {
            return this.department;
        }

        public BillSettementCarResponseBodyModuleDataList setDepartmentId(String departmentId) {
            this.departmentId = departmentId;
            return this;
        }
        public String getDepartmentId() {
            return this.departmentId;
        }

        public BillSettementCarResponseBodyModuleDataList setDeptCity(String deptCity) {
            this.deptCity = deptCity;
            return this;
        }
        public String getDeptCity() {
            return this.deptCity;
        }

        public BillSettementCarResponseBodyModuleDataList setDeptDate(String deptDate) {
            this.deptDate = deptDate;
            return this;
        }
        public String getDeptDate() {
            return this.deptDate;
        }

        public BillSettementCarResponseBodyModuleDataList setDeptLocation(String deptLocation) {
            this.deptLocation = deptLocation;
            return this;
        }
        public String getDeptLocation() {
            return this.deptLocation;
        }

        public BillSettementCarResponseBodyModuleDataList setDeptTime(String deptTime) {
            this.deptTime = deptTime;
            return this;
        }
        public String getDeptTime() {
            return this.deptTime;
        }

        public BillSettementCarResponseBodyModuleDataList setEstimateDriveDistance(String estimateDriveDistance) {
            this.estimateDriveDistance = estimateDriveDistance;
            return this;
        }
        public String getEstimateDriveDistance() {
            return this.estimateDriveDistance;
        }

        public BillSettementCarResponseBodyModuleDataList setEstimatePrice(Double estimatePrice) {
            this.estimatePrice = estimatePrice;
            return this;
        }
        public Double getEstimatePrice() {
            return this.estimatePrice;
        }

        public BillSettementCarResponseBodyModuleDataList setFeeType(String feeType) {
            this.feeType = feeType;
            return this;
        }
        public String getFeeType() {
            return this.feeType;
        }

        public BillSettementCarResponseBodyModuleDataList setIndex(String index) {
            this.index = index;
            return this;
        }
        public String getIndex() {
            return this.index;
        }

        public BillSettementCarResponseBodyModuleDataList setInvoiceTitle(String invoiceTitle) {
            this.invoiceTitle = invoiceTitle;
            return this;
        }
        public String getInvoiceTitle() {
            return this.invoiceTitle;
        }

        public BillSettementCarResponseBodyModuleDataList setMemo(String memo) {
            this.memo = memo;
            return this;
        }
        public String getMemo() {
            return this.memo;
        }

        public BillSettementCarResponseBodyModuleDataList setOrderId(String orderId) {
            this.orderId = orderId;
            return this;
        }
        public String getOrderId() {
            return this.orderId;
        }

        public BillSettementCarResponseBodyModuleDataList setOrderPrice(Double orderPrice) {
            this.orderPrice = orderPrice;
            return this;
        }
        public Double getOrderPrice() {
            return this.orderPrice;
        }

        public BillSettementCarResponseBodyModuleDataList setOverApplyId(String overApplyId) {
            this.overApplyId = overApplyId;
            return this;
        }
        public String getOverApplyId() {
            return this.overApplyId;
        }

        public BillSettementCarResponseBodyModuleDataList setPersonSettleFee(Double personSettleFee) {
            this.personSettleFee = personSettleFee;
            return this;
        }
        public Double getPersonSettleFee() {
            return this.personSettleFee;
        }

        public BillSettementCarResponseBodyModuleDataList setPrimaryId(String primaryId) {
            this.primaryId = primaryId;
            return this;
        }
        public String getPrimaryId() {
            return this.primaryId;
        }

        public BillSettementCarResponseBodyModuleDataList setProjectCode(String projectCode) {
            this.projectCode = projectCode;
            return this;
        }
        public String getProjectCode() {
            return this.projectCode;
        }

        public BillSettementCarResponseBodyModuleDataList setProjectName(String projectName) {
            this.projectName = projectName;
            return this;
        }
        public String getProjectName() {
            return this.projectName;
        }

        public BillSettementCarResponseBodyModuleDataList setProviderName(String providerName) {
            this.providerName = providerName;
            return this;
        }
        public String getProviderName() {
            return this.providerName;
        }

        public BillSettementCarResponseBodyModuleDataList setRealDriveDistance(String realDriveDistance) {
            this.realDriveDistance = realDriveDistance;
            return this;
        }
        public String getRealDriveDistance() {
            return this.realDriveDistance;
        }

        public BillSettementCarResponseBodyModuleDataList setRealFromAddr(String realFromAddr) {
            this.realFromAddr = realFromAddr;
            return this;
        }
        public String getRealFromAddr() {
            return this.realFromAddr;
        }

        public BillSettementCarResponseBodyModuleDataList setRealToAddr(String realToAddr) {
            this.realToAddr = realToAddr;
            return this;
        }
        public String getRealToAddr() {
            return this.realToAddr;
        }

        public BillSettementCarResponseBodyModuleDataList setRemark(String remark) {
            this.remark = remark;
            return this;
        }
        public String getRemark() {
            return this.remark;
        }

        public BillSettementCarResponseBodyModuleDataList setServiceFee(String serviceFee) {
            this.serviceFee = serviceFee;
            return this;
        }
        public String getServiceFee() {
            return this.serviceFee;
        }

        public BillSettementCarResponseBodyModuleDataList setSettlementFee(Double settlementFee) {
            this.settlementFee = settlementFee;
            return this;
        }
        public Double getSettlementFee() {
            return this.settlementFee;
        }

        public BillSettementCarResponseBodyModuleDataList setSettlementGrantFee(Double settlementGrantFee) {
            this.settlementGrantFee = settlementGrantFee;
            return this;
        }
        public Double getSettlementGrantFee() {
            return this.settlementGrantFee;
        }

        public BillSettementCarResponseBodyModuleDataList setSettlementTime(String settlementTime) {
            this.settlementTime = settlementTime;
            return this;
        }
        public String getSettlementTime() {
            return this.settlementTime;
        }

        public BillSettementCarResponseBodyModuleDataList setSettlementType(String settlementType) {
            this.settlementType = settlementType;
            return this;
        }
        public String getSettlementType() {
            return this.settlementType;
        }

        public BillSettementCarResponseBodyModuleDataList setSpecialOrder(String specialOrder) {
            this.specialOrder = specialOrder;
            return this;
        }
        public String getSpecialOrder() {
            return this.specialOrder;
        }

        public BillSettementCarResponseBodyModuleDataList setSpecialReason(String specialReason) {
            this.specialReason = specialReason;
            return this;
        }
        public String getSpecialReason() {
            return this.specialReason;
        }

        public BillSettementCarResponseBodyModuleDataList setStatus(Long status) {
            this.status = status;
            return this;
        }
        public Long getStatus() {
            return this.status;
        }

        public BillSettementCarResponseBodyModuleDataList setSubOrderId(String subOrderId) {
            this.subOrderId = subOrderId;
            return this;
        }
        public String getSubOrderId() {
            return this.subOrderId;
        }

        public BillSettementCarResponseBodyModuleDataList setTravelerId(String travelerId) {
            this.travelerId = travelerId;
            return this;
        }
        public String getTravelerId() {
            return this.travelerId;
        }

        public BillSettementCarResponseBodyModuleDataList setTravelerJobNo(String travelerJobNo) {
            this.travelerJobNo = travelerJobNo;
            return this;
        }
        public String getTravelerJobNo() {
            return this.travelerJobNo;
        }

        public BillSettementCarResponseBodyModuleDataList setTravelerName(String travelerName) {
            this.travelerName = travelerName;
            return this;
        }
        public String getTravelerName() {
            return this.travelerName;
        }

        public BillSettementCarResponseBodyModuleDataList setUserConfirmDesc(String userConfirmDesc) {
            this.userConfirmDesc = userConfirmDesc;
            return this;
        }
        public String getUserConfirmDesc() {
            return this.userConfirmDesc;
        }

        public BillSettementCarResponseBodyModuleDataList setVoucherType(Long voucherType) {
            this.voucherType = voucherType;
            return this;
        }
        public Long getVoucherType() {
            return this.voucherType;
        }

    }

    public static class BillSettementCarResponseBodyModule extends TeaModel {
        @NameInMap("category")
        public Long category;

        @NameInMap("corpId")
        public String corpId;

        @NameInMap("dataList")
        public java.util.List<BillSettementCarResponseBodyModuleDataList> dataList;

        @NameInMap("periodEnd")
        public String periodEnd;

        @NameInMap("periodStart")
        public String periodStart;

        @NameInMap("totalNum")
        public Long totalNum;

        public static BillSettementCarResponseBodyModule build(java.util.Map<String, ?> map) throws Exception {
            BillSettementCarResponseBodyModule self = new BillSettementCarResponseBodyModule();
            return TeaModel.build(map, self);
        }

        public BillSettementCarResponseBodyModule setCategory(Long category) {
            this.category = category;
            return this;
        }
        public Long getCategory() {
            return this.category;
        }

        public BillSettementCarResponseBodyModule setCorpId(String corpId) {
            this.corpId = corpId;
            return this;
        }
        public String getCorpId() {
            return this.corpId;
        }

        public BillSettementCarResponseBodyModule setDataList(java.util.List<BillSettementCarResponseBodyModuleDataList> dataList) {
            this.dataList = dataList;
            return this;
        }
        public java.util.List<BillSettementCarResponseBodyModuleDataList> getDataList() {
            return this.dataList;
        }

        public BillSettementCarResponseBodyModule setPeriodEnd(String periodEnd) {
            this.periodEnd = periodEnd;
            return this;
        }
        public String getPeriodEnd() {
            return this.periodEnd;
        }

        public BillSettementCarResponseBodyModule setPeriodStart(String periodStart) {
            this.periodStart = periodStart;
            return this;
        }
        public String getPeriodStart() {
            return this.periodStart;
        }

        public BillSettementCarResponseBodyModule setTotalNum(Long totalNum) {
            this.totalNum = totalNum;
            return this;
        }
        public Long getTotalNum() {
            return this.totalNum;
        }

    }

}
