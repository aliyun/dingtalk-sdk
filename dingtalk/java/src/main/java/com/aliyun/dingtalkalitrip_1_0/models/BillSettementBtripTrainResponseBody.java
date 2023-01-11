// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkalitrip_1_0.models;

import com.aliyun.tea.*;

public class BillSettementBtripTrainResponseBody extends TeaModel {
    /**
     * <p>module</p>
     */
    @NameInMap("module")
    public BillSettementBtripTrainResponseBodyModule module;

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
         * <p>到达日期</p>
         */
        @NameInMap("arrDate")
        public String arrDate;

        /**
         * <p>到达站点</p>
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
         * <p>改签手续费</p>
         */
        @NameInMap("changeFee")
        public Double changeFee;

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
         * <p>折扣率</p>
         */
        @NameInMap("coupon")
        public Double coupon;

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
         * <p>出发日期</p>
         */
        @NameInMap("deptDate")
        public String deptDate;

        /**
         * <p>出发站</p>
         */
        @NameInMap("deptStation")
        public String deptStation;

        /**
         * <p>出发时间</p>
         */
        @NameInMap("deptTime")
        public String deptTime;

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
         * <p>项目编号</p>
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
         * <p>备注</p>
         */
        @NameInMap("remark")
        public String remark;

        /**
         * <p>运行时长</p>
         */
        @NameInMap("runTime")
        public String runTime;

        /**
         * <p>座位号</p>
         */
        @NameInMap("seatNo")
        public String seatNo;

        /**
         * <p>坐席</p>
         */
        @NameInMap("seatType")
        public String seatType;

        /**
         * <p>服务费，仅在feeType 6007、6008中展示</p>
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
         * <p>票面票号</p>
         */
        @NameInMap("ticketNo")
        public String ticketNo;

        /**
         * <p>票价</p>
         */
        @NameInMap("ticketPrice")
        public Double ticketPrice;

        /**
         * <p>车次号</p>
         */
        @NameInMap("trainNo")
        public String trainNo;

        /**
         * <p>车次类型</p>
         */
        @NameInMap("trainType")
        public String trainType;

        /**
         * <p>出行人useId</p>
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
        public java.util.List<BillSettementBtripTrainResponseBodyModuleDataList> dataList;

        /**
         * <p>记账更新开始时间</p>
         */
        @NameInMap("periodEnd")
        public String periodEnd;

        /**
         * <p>记账更新结束时间</p>
         */
        @NameInMap("periodStart")
        public String periodStart;

        /**
         * <p>总数据量</p>
         */
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
