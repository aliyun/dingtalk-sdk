// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkalitrip_1_0.models;

import com.aliyun.tea.*;

public class BillSettementBtripTrainResponseBody extends TeaModel {
    // module
    @NameInMap("module")
    public BillSettementBtripTrainResponseBodyModule module;

    // 结果code
    @NameInMap("resultCode")
    public Long resultCode;

    // 结果msg
    @NameInMap("resultMsg")
    public String resultMsg;

    // 是否成功
    @NameInMap("success")
    public Boolean success;

    public static BillSettementBtripTrainResponseBody build(java.util.Map<String, ?> map) throws Exception {
        BillSettementBtripTrainResponseBody self = new BillSettementBtripTrainResponseBody();
        return TeaModel.build(map, self);
    }

    public BillSettementBtripTrainResponseBody setModule(BillSettementBtripTrainResponseBodyModule module) {
        this.module = module;
        return this;
    }
    public BillSettementBtripTrainResponseBodyModule getModule() {
        return this.module;
    }

    public BillSettementBtripTrainResponseBody setResultCode(Long resultCode) {
        this.resultCode = resultCode;
        return this;
    }
    public Long getResultCode() {
        return this.resultCode;
    }

    public BillSettementBtripTrainResponseBody setResultMsg(String resultMsg) {
        this.resultMsg = resultMsg;
        return this;
    }
    public String getResultMsg() {
        return this.resultMsg;
    }

    public BillSettementBtripTrainResponseBody setSuccess(Boolean success) {
        this.success = success;
        return this;
    }
    public Boolean getSuccess() {
        return this.success;
    }

    public static class BillSettementBtripTrainResponseBodyModuleDataList extends TeaModel {
        // 交易流水号
        @NameInMap("alipayTradeNo")
        public String alipayTradeNo;

        // 审批单号
        @NameInMap("applyId")
        public String applyId;

        // 到达日期
        @NameInMap("arrDate")
        public String arrDate;

        // 到达站点
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

        // 预定人use id
        @NameInMap("bookerId")
        public String bookerId;

        // 预订人工号
        @NameInMap("bookerJobNo")
        public String bookerJobNo;

        // 预订人名称
        @NameInMap("bookerName")
        public String bookerName;

        // 资金方向
        @NameInMap("capitalDirection")
        public String capitalDirection;

        // 级联部门
        @NameInMap("cascadeDepartment")
        public String cascadeDepartment;

        // 改签手续费
        @NameInMap("changeFee")
        public Double changeFee;

        // 成本中心名称
        @NameInMap("costCenter")
        public String costCenter;

        // 成本中心编码
        @NameInMap("costCenterNumber")
        public String costCenterNumber;

        // 折扣率
        @NameInMap("coupon")
        public Double coupon;

        // 末级部门
        @NameInMap("department")
        public String department;

        // 部门id
        @NameInMap("departmentId")
        public String departmentId;

        // 出发日期
        @NameInMap("deptDate")
        public String deptDate;

        // 出发站
        @NameInMap("deptStation")
        public String deptStation;

        // 出发时间
        @NameInMap("deptTime")
        public String deptTime;

        // 费用类型
        @NameInMap("feeType")
        public String feeType;

        // 序号
        @NameInMap("index")
        public String index;

        // 发票抬头
        @NameInMap("invoiceTitle")
        public String invoiceTitle;

        // 订单号
        @NameInMap("orderId")
        public String orderId;

        // 订单金额
        @NameInMap("orderPrice")
        public Double orderPrice;

        // 超标审批单号
        @NameInMap("overApplyId")
        public String overApplyId;

        // 主键id
        @NameInMap("primaryId")
        public Long primaryId;

        // 项目编号
        @NameInMap("projectCode")
        public String projectCode;

        // 项目名称
        @NameInMap("projectName")
        public String projectName;

        // 退款手续费
        @NameInMap("refundFee")
        public Double refundFee;

        // 备注
        @NameInMap("remark")
        public String remark;

        // 运行时长
        @NameInMap("runTime")
        public String runTime;

        // 座位号
        @NameInMap("seatNo")
        public String seatNo;

        // 坐席
        @NameInMap("seatType")
        public String seatType;

        // 服务费，仅在feeType 6007、6008中展示
        @NameInMap("serviceFee")
        public Double serviceFee;

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

        // 入账状态
        @NameInMap("status")
        public Long status;

        // 票面票号
        @NameInMap("ticketNo")
        public String ticketNo;

        // 票价
        @NameInMap("ticketPrice")
        public Double ticketPrice;

        // 车次号
        @NameInMap("trainNo")
        public String trainNo;

        // 车次类型
        @NameInMap("trainType")
        public String trainType;

        // 出行人useId
        @NameInMap("travelerId")
        public String travelerId;

        // 出行人工号
        @NameInMap("travelerJobNo")
        public String travelerJobNo;

        // 出行人名称
        @NameInMap("travelerName")
        public String travelerName;

        // 发票类型
        @NameInMap("voucherType")
        public Long voucherType;

        public static BillSettementBtripTrainResponseBodyModuleDataList build(java.util.Map<String, ?> map) throws Exception {
            BillSettementBtripTrainResponseBodyModuleDataList self = new BillSettementBtripTrainResponseBodyModuleDataList();
            return TeaModel.build(map, self);
        }

        public BillSettementBtripTrainResponseBodyModuleDataList setAlipayTradeNo(String alipayTradeNo) {
            this.alipayTradeNo = alipayTradeNo;
            return this;
        }
        public String getAlipayTradeNo() {
            return this.alipayTradeNo;
        }

        public BillSettementBtripTrainResponseBodyModuleDataList setApplyId(String applyId) {
            this.applyId = applyId;
            return this;
        }
        public String getApplyId() {
            return this.applyId;
        }

        public BillSettementBtripTrainResponseBodyModuleDataList setArrDate(String arrDate) {
            this.arrDate = arrDate;
            return this;
        }
        public String getArrDate() {
            return this.arrDate;
        }

        public BillSettementBtripTrainResponseBodyModuleDataList setArrStation(String arrStation) {
            this.arrStation = arrStation;
            return this;
        }
        public String getArrStation() {
            return this.arrStation;
        }

        public BillSettementBtripTrainResponseBodyModuleDataList setArrTime(String arrTime) {
            this.arrTime = arrTime;
            return this;
        }
        public String getArrTime() {
            return this.arrTime;
        }

        public BillSettementBtripTrainResponseBodyModuleDataList setBillRecordTime(String billRecordTime) {
            this.billRecordTime = billRecordTime;
            return this;
        }
        public String getBillRecordTime() {
            return this.billRecordTime;
        }

        public BillSettementBtripTrainResponseBodyModuleDataList setBookTime(String bookTime) {
            this.bookTime = bookTime;
            return this;
        }
        public String getBookTime() {
            return this.bookTime;
        }

        public BillSettementBtripTrainResponseBodyModuleDataList setBookerId(String bookerId) {
            this.bookerId = bookerId;
            return this;
        }
        public String getBookerId() {
            return this.bookerId;
        }

        public BillSettementBtripTrainResponseBodyModuleDataList setBookerJobNo(String bookerJobNo) {
            this.bookerJobNo = bookerJobNo;
            return this;
        }
        public String getBookerJobNo() {
            return this.bookerJobNo;
        }

        public BillSettementBtripTrainResponseBodyModuleDataList setBookerName(String bookerName) {
            this.bookerName = bookerName;
            return this;
        }
        public String getBookerName() {
            return this.bookerName;
        }

        public BillSettementBtripTrainResponseBodyModuleDataList setCapitalDirection(String capitalDirection) {
            this.capitalDirection = capitalDirection;
            return this;
        }
        public String getCapitalDirection() {
            return this.capitalDirection;
        }

        public BillSettementBtripTrainResponseBodyModuleDataList setCascadeDepartment(String cascadeDepartment) {
            this.cascadeDepartment = cascadeDepartment;
            return this;
        }
        public String getCascadeDepartment() {
            return this.cascadeDepartment;
        }

        public BillSettementBtripTrainResponseBodyModuleDataList setChangeFee(Double changeFee) {
            this.changeFee = changeFee;
            return this;
        }
        public Double getChangeFee() {
            return this.changeFee;
        }

        public BillSettementBtripTrainResponseBodyModuleDataList setCostCenter(String costCenter) {
            this.costCenter = costCenter;
            return this;
        }
        public String getCostCenter() {
            return this.costCenter;
        }

        public BillSettementBtripTrainResponseBodyModuleDataList setCostCenterNumber(String costCenterNumber) {
            this.costCenterNumber = costCenterNumber;
            return this;
        }
        public String getCostCenterNumber() {
            return this.costCenterNumber;
        }

        public BillSettementBtripTrainResponseBodyModuleDataList setCoupon(Double coupon) {
            this.coupon = coupon;
            return this;
        }
        public Double getCoupon() {
            return this.coupon;
        }

        public BillSettementBtripTrainResponseBodyModuleDataList setDepartment(String department) {
            this.department = department;
            return this;
        }
        public String getDepartment() {
            return this.department;
        }

        public BillSettementBtripTrainResponseBodyModuleDataList setDepartmentId(String departmentId) {
            this.departmentId = departmentId;
            return this;
        }
        public String getDepartmentId() {
            return this.departmentId;
        }

        public BillSettementBtripTrainResponseBodyModuleDataList setDeptDate(String deptDate) {
            this.deptDate = deptDate;
            return this;
        }
        public String getDeptDate() {
            return this.deptDate;
        }

        public BillSettementBtripTrainResponseBodyModuleDataList setDeptStation(String deptStation) {
            this.deptStation = deptStation;
            return this;
        }
        public String getDeptStation() {
            return this.deptStation;
        }

        public BillSettementBtripTrainResponseBodyModuleDataList setDeptTime(String deptTime) {
            this.deptTime = deptTime;
            return this;
        }
        public String getDeptTime() {
            return this.deptTime;
        }

        public BillSettementBtripTrainResponseBodyModuleDataList setFeeType(String feeType) {
            this.feeType = feeType;
            return this;
        }
        public String getFeeType() {
            return this.feeType;
        }

        public BillSettementBtripTrainResponseBodyModuleDataList setIndex(String index) {
            this.index = index;
            return this;
        }
        public String getIndex() {
            return this.index;
        }

        public BillSettementBtripTrainResponseBodyModuleDataList setInvoiceTitle(String invoiceTitle) {
            this.invoiceTitle = invoiceTitle;
            return this;
        }
        public String getInvoiceTitle() {
            return this.invoiceTitle;
        }

        public BillSettementBtripTrainResponseBodyModuleDataList setOrderId(String orderId) {
            this.orderId = orderId;
            return this;
        }
        public String getOrderId() {
            return this.orderId;
        }

        public BillSettementBtripTrainResponseBodyModuleDataList setOrderPrice(Double orderPrice) {
            this.orderPrice = orderPrice;
            return this;
        }
        public Double getOrderPrice() {
            return this.orderPrice;
        }

        public BillSettementBtripTrainResponseBodyModuleDataList setOverApplyId(String overApplyId) {
            this.overApplyId = overApplyId;
            return this;
        }
        public String getOverApplyId() {
            return this.overApplyId;
        }

        public BillSettementBtripTrainResponseBodyModuleDataList setPrimaryId(Long primaryId) {
            this.primaryId = primaryId;
            return this;
        }
        public Long getPrimaryId() {
            return this.primaryId;
        }

        public BillSettementBtripTrainResponseBodyModuleDataList setProjectCode(String projectCode) {
            this.projectCode = projectCode;
            return this;
        }
        public String getProjectCode() {
            return this.projectCode;
        }

        public BillSettementBtripTrainResponseBodyModuleDataList setProjectName(String projectName) {
            this.projectName = projectName;
            return this;
        }
        public String getProjectName() {
            return this.projectName;
        }

        public BillSettementBtripTrainResponseBodyModuleDataList setRefundFee(Double refundFee) {
            this.refundFee = refundFee;
            return this;
        }
        public Double getRefundFee() {
            return this.refundFee;
        }

        public BillSettementBtripTrainResponseBodyModuleDataList setRemark(String remark) {
            this.remark = remark;
            return this;
        }
        public String getRemark() {
            return this.remark;
        }

        public BillSettementBtripTrainResponseBodyModuleDataList setRunTime(String runTime) {
            this.runTime = runTime;
            return this;
        }
        public String getRunTime() {
            return this.runTime;
        }

        public BillSettementBtripTrainResponseBodyModuleDataList setSeatNo(String seatNo) {
            this.seatNo = seatNo;
            return this;
        }
        public String getSeatNo() {
            return this.seatNo;
        }

        public BillSettementBtripTrainResponseBodyModuleDataList setSeatType(String seatType) {
            this.seatType = seatType;
            return this;
        }
        public String getSeatType() {
            return this.seatType;
        }

        public BillSettementBtripTrainResponseBodyModuleDataList setServiceFee(Double serviceFee) {
            this.serviceFee = serviceFee;
            return this;
        }
        public Double getServiceFee() {
            return this.serviceFee;
        }

        public BillSettementBtripTrainResponseBodyModuleDataList setSettlementFee(Double settlementFee) {
            this.settlementFee = settlementFee;
            return this;
        }
        public Double getSettlementFee() {
            return this.settlementFee;
        }

        public BillSettementBtripTrainResponseBodyModuleDataList setSettlementGrantFee(Double settlementGrantFee) {
            this.settlementGrantFee = settlementGrantFee;
            return this;
        }
        public Double getSettlementGrantFee() {
            return this.settlementGrantFee;
        }

        public BillSettementBtripTrainResponseBodyModuleDataList setSettlementTime(String settlementTime) {
            this.settlementTime = settlementTime;
            return this;
        }
        public String getSettlementTime() {
            return this.settlementTime;
        }

        public BillSettementBtripTrainResponseBodyModuleDataList setSettlementType(String settlementType) {
            this.settlementType = settlementType;
            return this;
        }
        public String getSettlementType() {
            return this.settlementType;
        }

        public BillSettementBtripTrainResponseBodyModuleDataList setStatus(Long status) {
            this.status = status;
            return this;
        }
        public Long getStatus() {
            return this.status;
        }

        public BillSettementBtripTrainResponseBodyModuleDataList setTicketNo(String ticketNo) {
            this.ticketNo = ticketNo;
            return this;
        }
        public String getTicketNo() {
            return this.ticketNo;
        }

        public BillSettementBtripTrainResponseBodyModuleDataList setTicketPrice(Double ticketPrice) {
            this.ticketPrice = ticketPrice;
            return this;
        }
        public Double getTicketPrice() {
            return this.ticketPrice;
        }

        public BillSettementBtripTrainResponseBodyModuleDataList setTrainNo(String trainNo) {
            this.trainNo = trainNo;
            return this;
        }
        public String getTrainNo() {
            return this.trainNo;
        }

        public BillSettementBtripTrainResponseBodyModuleDataList setTrainType(String trainType) {
            this.trainType = trainType;
            return this;
        }
        public String getTrainType() {
            return this.trainType;
        }

        public BillSettementBtripTrainResponseBodyModuleDataList setTravelerId(String travelerId) {
            this.travelerId = travelerId;
            return this;
        }
        public String getTravelerId() {
            return this.travelerId;
        }

        public BillSettementBtripTrainResponseBodyModuleDataList setTravelerJobNo(String travelerJobNo) {
            this.travelerJobNo = travelerJobNo;
            return this;
        }
        public String getTravelerJobNo() {
            return this.travelerJobNo;
        }

        public BillSettementBtripTrainResponseBodyModuleDataList setTravelerName(String travelerName) {
            this.travelerName = travelerName;
            return this;
        }
        public String getTravelerName() {
            return this.travelerName;
        }

        public BillSettementBtripTrainResponseBodyModuleDataList setVoucherType(Long voucherType) {
            this.voucherType = voucherType;
            return this;
        }
        public Long getVoucherType() {
            return this.voucherType;
        }

    }

    public static class BillSettementBtripTrainResponseBodyModule extends TeaModel {
        // 类目
        @NameInMap("category")
        public Long category;

        // 企业id
        @NameInMap("corpId")
        public String corpId;

        // 数据集合
        @NameInMap("dataList")
        public java.util.List<BillSettementBtripTrainResponseBodyModuleDataList> dataList;

        // 记账更新开始时间
        @NameInMap("periodEnd")
        public String periodEnd;

        // 记账更新结束时间
        @NameInMap("periodStart")
        public String periodStart;

        // 总数据量
        @NameInMap("totalNum")
        public Long totalNum;

        public static BillSettementBtripTrainResponseBodyModule build(java.util.Map<String, ?> map) throws Exception {
            BillSettementBtripTrainResponseBodyModule self = new BillSettementBtripTrainResponseBodyModule();
            return TeaModel.build(map, self);
        }

        public BillSettementBtripTrainResponseBodyModule setCategory(Long category) {
            this.category = category;
            return this;
        }
        public Long getCategory() {
            return this.category;
        }

        public BillSettementBtripTrainResponseBodyModule setCorpId(String corpId) {
            this.corpId = corpId;
            return this;
        }
        public String getCorpId() {
            return this.corpId;
        }

        public BillSettementBtripTrainResponseBodyModule setDataList(java.util.List<BillSettementBtripTrainResponseBodyModuleDataList> dataList) {
            this.dataList = dataList;
            return this;
        }
        public java.util.List<BillSettementBtripTrainResponseBodyModuleDataList> getDataList() {
            return this.dataList;
        }

        public BillSettementBtripTrainResponseBodyModule setPeriodEnd(String periodEnd) {
            this.periodEnd = periodEnd;
            return this;
        }
        public String getPeriodEnd() {
            return this.periodEnd;
        }

        public BillSettementBtripTrainResponseBodyModule setPeriodStart(String periodStart) {
            this.periodStart = periodStart;
            return this;
        }
        public String getPeriodStart() {
            return this.periodStart;
        }

        public BillSettementBtripTrainResponseBodyModule setTotalNum(Long totalNum) {
            this.totalNum = totalNum;
            return this;
        }
        public Long getTotalNum() {
            return this.totalNum;
        }

    }

}
