// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkalitrip_1_0.models;

import com.aliyun.tea.*;

public class BillSettementCarResponseBody extends TeaModel {
    // module
    @NameInMap("module")
    public BillSettementCarResponseBodyModule module;

    // 结果code
    @NameInMap("resultCode")
    public Long resultCode;

    // 结果msg
    @NameInMap("resultMsg")
    public String resultMsg;

    // 是否成功
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
        // 支付交易流水号
        @NameInMap("alipayTradeNo")
        public String alipayTradeNo;

        // 审批单号
        @NameInMap("applyId")
        public String applyId;

        // 到达城市
        @NameInMap("arrCity")
        public String arrCity;

        // 到达日期
        @NameInMap("arrDate")
        public String arrDate;

        // 到达地
        @NameInMap("arrLocation")
        public String arrLocation;

        // 到达时间
        @NameInMap("arrTime")
        public String arrTime;

        // 入账时间
        @NameInMap("billRecordTime")
        public String billRecordTime;

        // 预定时间
        @NameInMap("bookTime")
        public String bookTime;

        // 预定人use id
        @NameInMap("bookerId")
        public String bookerId;

        // 预订人工号
        @NameInMap("bookerJobNo")
        public String bookerJobNo;

        // 预订人名称
        @NameInMap("bookerName")
        public String bookerName;

        // 用车事由
        @NameInMap("businessCategory")
        public String businessCategory;

        // 资金方向
        @NameInMap("capitalDirection")
        public String capitalDirection;

        // 车型
        @NameInMap("carLevel")
        public String carLevel;

        // 级联部门
        @NameInMap("cascadeDepartment")
        public String cascadeDepartment;

        // 成本中心名称
        @NameInMap("costCenter")
        public String costCenter;

        // 成本中心编号
        @NameInMap("costCenterNumber")
        public String costCenterNumber;

        // 优惠券
        @NameInMap("coupon")
        public Double coupon;

        // 优惠金额
        @NameInMap("couponPrice")
        public Double couponPrice;

        // 末级部门
        @NameInMap("department")
        public String department;

        // 部门id
        @NameInMap("departmentId")
        public String departmentId;

        // 出发城市
        @NameInMap("deptCity")
        public String deptCity;

        // 出发日期
        @NameInMap("deptDate")
        public String deptDate;

        // 出发地
        @NameInMap("deptLocation")
        public String deptLocation;

        // 出发时间
        @NameInMap("deptTime")
        public String deptTime;

        // 预估行驶距离
        @NameInMap("estimateDriveDistance")
        public String estimateDriveDistance;

        // 预估金额
        @NameInMap("estimatePrice")
        public Double estimatePrice;

        // 费用类型
        @NameInMap("feeType")
        public String feeType;

        // 序号
        @NameInMap("index")
        public String index;

        // 发票抬头
        @NameInMap("invoiceTitle")
        public String invoiceTitle;

        // 用车事由
        @NameInMap("memo")
        public String memo;

        // 订单id
        @NameInMap("orderId")
        public String orderId;

        // 订单金额
        @NameInMap("orderPrice")
        public Double orderPrice;

        // 超标审批单号
        @NameInMap("overApplyId")
        public String overApplyId;

        // 个人支付金额
        @NameInMap("personSettleFee")
        public Double personSettleFee;

        @NameInMap("primaryId")
        public String primaryId;

        // 项目编码
        @NameInMap("projectCode")
        public String projectCode;

        // 项目名称
        @NameInMap("projectName")
        public String projectName;

        // 供应商
        @NameInMap("providerName")
        public String providerName;

        // 实际行驶距离
        @NameInMap("realDriveDistance")
        public String realDriveDistance;

        // 实际上车点
        @NameInMap("realFromAddr")
        public String realFromAddr;

        // 实际下车点
        @NameInMap("realToAddr")
        public String realToAddr;

        // 备注
        @NameInMap("remark")
        public String remark;

        // 服务费，仅在feeType 40111 中展示
        @NameInMap("serviceFee")
        public String serviceFee;

        // 结算金额
        @NameInMap("settlementFee")
        public Double settlementFee;

        // 预存赠送金额消费
        @NameInMap("settlementGrantFee")
        public Double settlementGrantFee;

        // 结算时间
        @NameInMap("settlementTime")
        public String settlementTime;

        // 结算类型
        @NameInMap("settlementType")
        public String settlementType;

        // 特别关注订单
        @NameInMap("specialOrder")
        public String specialOrder;

        // 特别关注原因
        @NameInMap("specialReason")
        public String specialReason;

        // 入账状态
        @NameInMap("status")
        public Long status;

        // 子订单号
        @NameInMap("subOrderId")
        public String subOrderId;

        // 出行人use id
        @NameInMap("travelerId")
        public String travelerId;

        // 出行人工号
        @NameInMap("travelerJobNo")
        public String travelerJobNo;

        // 出行人名称
        @NameInMap("travelerName")
        public String travelerName;

        // 员工是否认可
        @NameInMap("userConfirmDesc")
        public String userConfirmDesc;

        // 发票类型
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
        // 类目
        @NameInMap("category")
        public Long category;

        // 企业id
        @NameInMap("corpId")
        public String corpId;

        // 数据集合
        @NameInMap("dataList")
        public java.util.List<BillSettementCarResponseBodyModuleDataList> dataList;

        // 记账更新开始日期
        @NameInMap("periodEnd")
        public String periodEnd;

        // 记账更新结束日期
        @NameInMap("periodStart")
        public String periodStart;

        // 总数量
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
