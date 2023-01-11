// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkalitrip_1_0.models;

import com.aliyun.tea.*;

public class BillSettementCarResponseBody extends TeaModel {
    /**
     * <p>module</p>
     */
    @NameInMap("module")
    public BillSettementCarResponseBodyModule module;

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
        /**
         * <p>支付交易流水号</p>
         */
        @NameInMap("alipayTradeNo")
        public String alipayTradeNo;

        /**
         * <p>审批单号</p>
         */
        @NameInMap("applyId")
        public String applyId;

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
         * <p>到达地</p>
         */
        @NameInMap("arrLocation")
        public String arrLocation;

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
         * <p>用车事由</p>
         */
        @NameInMap("businessCategory")
        public String businessCategory;

        /**
         * <p>资金方向</p>
         */
        @NameInMap("capitalDirection")
        public String capitalDirection;

        /**
         * <p>车型</p>
         */
        @NameInMap("carLevel")
        public String carLevel;

        /**
         * <p>级联部门</p>
         */
        @NameInMap("cascadeDepartment")
        public String cascadeDepartment;

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
         * <p>优惠金额</p>
         */
        @NameInMap("couponPrice")
        public Double couponPrice;

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
         * <p>出发城市</p>
         */
        @NameInMap("deptCity")
        public String deptCity;

        /**
         * <p>出发日期</p>
         */
        @NameInMap("deptDate")
        public String deptDate;

        /**
         * <p>出发地</p>
         */
        @NameInMap("deptLocation")
        public String deptLocation;

        /**
         * <p>出发时间</p>
         */
        @NameInMap("deptTime")
        public String deptTime;

        /**
         * <p>预估行驶距离</p>
         */
        @NameInMap("estimateDriveDistance")
        public String estimateDriveDistance;

        /**
         * <p>预估金额</p>
         */
        @NameInMap("estimatePrice")
        public Double estimatePrice;

        /**
         * <p>费用类型</p>
         */
        @NameInMap("feeType")
        public String feeType;

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
         * <p>用车事由</p>
         */
        @NameInMap("memo")
        public String memo;

        /**
         * <p>订单id</p>
         */
        @NameInMap("orderId")
        public String orderId;

        /**
         * <p>订单金额</p>
         */
        @NameInMap("orderPrice")
        public Double orderPrice;

        /**
         * <p>超标审批单号</p>
         */
        @NameInMap("overApplyId")
        public String overApplyId;

        /**
         * <p>个人支付金额</p>
         */
        @NameInMap("personSettleFee")
        public Double personSettleFee;

        @NameInMap("primaryId")
        public String primaryId;

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
         * <p>供应商</p>
         */
        @NameInMap("providerName")
        public String providerName;

        /**
         * <p>实际行驶距离</p>
         */
        @NameInMap("realDriveDistance")
        public String realDriveDistance;

        /**
         * <p>实际上车点</p>
         */
        @NameInMap("realFromAddr")
        public String realFromAddr;

        /**
         * <p>实际下车点</p>
         */
        @NameInMap("realToAddr")
        public String realToAddr;

        /**
         * <p>备注</p>
         */
        @NameInMap("remark")
        public String remark;

        /**
         * <p>服务费，仅在feeType 40111 中展示</p>
         */
        @NameInMap("serviceFee")
        public String serviceFee;

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
         * <p>特别关注订单</p>
         */
        @NameInMap("specialOrder")
        public String specialOrder;

        /**
         * <p>特别关注原因</p>
         */
        @NameInMap("specialReason")
        public String specialReason;

        /**
         * <p>入账状态</p>
         */
        @NameInMap("status")
        public Long status;

        /**
         * <p>子订单号</p>
         */
        @NameInMap("subOrderId")
        public String subOrderId;

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
         * <p>员工是否认可</p>
         */
        @NameInMap("userConfirmDesc")
        public String userConfirmDesc;

        /**
         * <p>发票类型</p>
         */
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
        public java.util.List<BillSettementCarResponseBodyModuleDataList> dataList;

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
         * <p>总数量</p>
         */
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
