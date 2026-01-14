// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalktrip_1_0.models;

import com.aliyun.tea.*;

public class QueryTripTrainOrderByPageResponseBody extends TeaModel {
    @NameInMap("hasMore")
    public Boolean hasMore;

    @NameInMap("list")
    public java.util.List<QueryTripTrainOrderByPageResponseBodyList> list;

    @NameInMap("nextCursor")
    public Long nextCursor;

    @NameInMap("totalCount")
    public Long totalCount;

    public static QueryTripTrainOrderByPageResponseBody build(java.util.Map<String, ?> map) throws Exception {
        QueryTripTrainOrderByPageResponseBody self = new QueryTripTrainOrderByPageResponseBody();
        return TeaModel.build(map, self);
    }

    public QueryTripTrainOrderByPageResponseBody setHasMore(Boolean hasMore) {
        this.hasMore = hasMore;
        return this;
    }
    public Boolean getHasMore() {
        return this.hasMore;
    }

    public QueryTripTrainOrderByPageResponseBody setList(java.util.List<QueryTripTrainOrderByPageResponseBodyList> list) {
        this.list = list;
        return this;
    }
    public java.util.List<QueryTripTrainOrderByPageResponseBodyList> getList() {
        return this.list;
    }

    public QueryTripTrainOrderByPageResponseBody setNextCursor(Long nextCursor) {
        this.nextCursor = nextCursor;
        return this;
    }
    public Long getNextCursor() {
        return this.nextCursor;
    }

    public QueryTripTrainOrderByPageResponseBody setTotalCount(Long totalCount) {
        this.totalCount = totalCount;
        return this;
    }
    public Long getTotalCount() {
        return this.totalCount;
    }

    public static class QueryTripTrainOrderByPageResponseBodyListConsumerInfos extends TeaModel {
        @NameInMap("name")
        public String name;

        @NameInMap("staffFlag")
        public Boolean staffFlag;

        @NameInMap("userId")
        public String userId;

        public static QueryTripTrainOrderByPageResponseBodyListConsumerInfos build(java.util.Map<String, ?> map) throws Exception {
            QueryTripTrainOrderByPageResponseBodyListConsumerInfos self = new QueryTripTrainOrderByPageResponseBodyListConsumerInfos();
            return TeaModel.build(map, self);
        }

        public QueryTripTrainOrderByPageResponseBodyListConsumerInfos setName(String name) {
            this.name = name;
            return this;
        }
        public String getName() {
            return this.name;
        }

        public QueryTripTrainOrderByPageResponseBodyListConsumerInfos setStaffFlag(Boolean staffFlag) {
            this.staffFlag = staffFlag;
            return this;
        }
        public Boolean getStaffFlag() {
            return this.staffFlag;
        }

        public QueryTripTrainOrderByPageResponseBodyListConsumerInfos setUserId(String userId) {
            this.userId = userId;
            return this;
        }
        public String getUserId() {
            return this.userId;
        }

    }

    public static class QueryTripTrainOrderByPageResponseBodyList extends TeaModel {
        @NameInMap("arrivalCity")
        public String arrivalCity;

        @NameInMap("arrivalStation")
        public String arrivalStation;

        @NameInMap("arrivalTime")
        public String arrivalTime;

        @NameInMap("consumerInfos")
        public java.util.List<QueryTripTrainOrderByPageResponseBodyListConsumerInfos> consumerInfos;

        @NameInMap("contactName")
        public String contactName;

        @NameInMap("costCenter")
        public String costCenter;

        @NameInMap("costCenterCode")
        public String costCenterCode;

        @NameInMap("createTime")
        public Long createTime;

        @NameInMap("departmentId")
        public String departmentId;

        @NameInMap("departmentName")
        public String departmentName;

        @NameInMap("departureCity")
        public String departureCity;

        @NameInMap("departureStation")
        public String departureStation;

        @NameInMap("departureTime")
        public String departureTime;

        @NameInMap("gmtOrder")
        public Long gmtOrder;

        @NameInMap("gmtPay")
        public Long gmtPay;

        @NameInMap("invoiceId")
        public String invoiceId;

        @NameInMap("invoiceTitle")
        public String invoiceTitle;

        @NameInMap("orderDetails")
        public String orderDetails;

        @NameInMap("orderNo")
        public String orderNo;

        @NameInMap("payType")
        public String payType;

        @NameInMap("processInstanceId")
        public String processInstanceId;

        @NameInMap("runTime")
        public String runTime;

        @NameInMap("seatType")
        public String seatType;

        @NameInMap("ticketCount")
        public String ticketCount;

        @NameInMap("totalAmount")
        public Long totalAmount;

        @NameInMap("trainNumber")
        public String trainNumber;

        @NameInMap("trainOrderStatus")
        public String trainOrderStatus;

        @NameInMap("trainOrderStatusDesc")
        public String trainOrderStatusDesc;

        @NameInMap("updateTime")
        public Long updateTime;

        @NameInMap("userId")
        public String userId;

        @NameInMap("userName")
        public String userName;

        public static QueryTripTrainOrderByPageResponseBodyList build(java.util.Map<String, ?> map) throws Exception {
            QueryTripTrainOrderByPageResponseBodyList self = new QueryTripTrainOrderByPageResponseBodyList();
            return TeaModel.build(map, self);
        }

        public QueryTripTrainOrderByPageResponseBodyList setArrivalCity(String arrivalCity) {
            this.arrivalCity = arrivalCity;
            return this;
        }
        public String getArrivalCity() {
            return this.arrivalCity;
        }

        public QueryTripTrainOrderByPageResponseBodyList setArrivalStation(String arrivalStation) {
            this.arrivalStation = arrivalStation;
            return this;
        }
        public String getArrivalStation() {
            return this.arrivalStation;
        }

        public QueryTripTrainOrderByPageResponseBodyList setArrivalTime(String arrivalTime) {
            this.arrivalTime = arrivalTime;
            return this;
        }
        public String getArrivalTime() {
            return this.arrivalTime;
        }

        public QueryTripTrainOrderByPageResponseBodyList setConsumerInfos(java.util.List<QueryTripTrainOrderByPageResponseBodyListConsumerInfos> consumerInfos) {
            this.consumerInfos = consumerInfos;
            return this;
        }
        public java.util.List<QueryTripTrainOrderByPageResponseBodyListConsumerInfos> getConsumerInfos() {
            return this.consumerInfos;
        }

        public QueryTripTrainOrderByPageResponseBodyList setContactName(String contactName) {
            this.contactName = contactName;
            return this;
        }
        public String getContactName() {
            return this.contactName;
        }

        public QueryTripTrainOrderByPageResponseBodyList setCostCenter(String costCenter) {
            this.costCenter = costCenter;
            return this;
        }
        public String getCostCenter() {
            return this.costCenter;
        }

        public QueryTripTrainOrderByPageResponseBodyList setCostCenterCode(String costCenterCode) {
            this.costCenterCode = costCenterCode;
            return this;
        }
        public String getCostCenterCode() {
            return this.costCenterCode;
        }

        public QueryTripTrainOrderByPageResponseBodyList setCreateTime(Long createTime) {
            this.createTime = createTime;
            return this;
        }
        public Long getCreateTime() {
            return this.createTime;
        }

        public QueryTripTrainOrderByPageResponseBodyList setDepartmentId(String departmentId) {
            this.departmentId = departmentId;
            return this;
        }
        public String getDepartmentId() {
            return this.departmentId;
        }

        public QueryTripTrainOrderByPageResponseBodyList setDepartmentName(String departmentName) {
            this.departmentName = departmentName;
            return this;
        }
        public String getDepartmentName() {
            return this.departmentName;
        }

        public QueryTripTrainOrderByPageResponseBodyList setDepartureCity(String departureCity) {
            this.departureCity = departureCity;
            return this;
        }
        public String getDepartureCity() {
            return this.departureCity;
        }

        public QueryTripTrainOrderByPageResponseBodyList setDepartureStation(String departureStation) {
            this.departureStation = departureStation;
            return this;
        }
        public String getDepartureStation() {
            return this.departureStation;
        }

        public QueryTripTrainOrderByPageResponseBodyList setDepartureTime(String departureTime) {
            this.departureTime = departureTime;
            return this;
        }
        public String getDepartureTime() {
            return this.departureTime;
        }

        public QueryTripTrainOrderByPageResponseBodyList setGmtOrder(Long gmtOrder) {
            this.gmtOrder = gmtOrder;
            return this;
        }
        public Long getGmtOrder() {
            return this.gmtOrder;
        }

        public QueryTripTrainOrderByPageResponseBodyList setGmtPay(Long gmtPay) {
            this.gmtPay = gmtPay;
            return this;
        }
        public Long getGmtPay() {
            return this.gmtPay;
        }

        public QueryTripTrainOrderByPageResponseBodyList setInvoiceId(String invoiceId) {
            this.invoiceId = invoiceId;
            return this;
        }
        public String getInvoiceId() {
            return this.invoiceId;
        }

        public QueryTripTrainOrderByPageResponseBodyList setInvoiceTitle(String invoiceTitle) {
            this.invoiceTitle = invoiceTitle;
            return this;
        }
        public String getInvoiceTitle() {
            return this.invoiceTitle;
        }

        public QueryTripTrainOrderByPageResponseBodyList setOrderDetails(String orderDetails) {
            this.orderDetails = orderDetails;
            return this;
        }
        public String getOrderDetails() {
            return this.orderDetails;
        }

        public QueryTripTrainOrderByPageResponseBodyList setOrderNo(String orderNo) {
            this.orderNo = orderNo;
            return this;
        }
        public String getOrderNo() {
            return this.orderNo;
        }

        public QueryTripTrainOrderByPageResponseBodyList setPayType(String payType) {
            this.payType = payType;
            return this;
        }
        public String getPayType() {
            return this.payType;
        }

        public QueryTripTrainOrderByPageResponseBodyList setProcessInstanceId(String processInstanceId) {
            this.processInstanceId = processInstanceId;
            return this;
        }
        public String getProcessInstanceId() {
            return this.processInstanceId;
        }

        public QueryTripTrainOrderByPageResponseBodyList setRunTime(String runTime) {
            this.runTime = runTime;
            return this;
        }
        public String getRunTime() {
            return this.runTime;
        }

        public QueryTripTrainOrderByPageResponseBodyList setSeatType(String seatType) {
            this.seatType = seatType;
            return this;
        }
        public String getSeatType() {
            return this.seatType;
        }

        public QueryTripTrainOrderByPageResponseBodyList setTicketCount(String ticketCount) {
            this.ticketCount = ticketCount;
            return this;
        }
        public String getTicketCount() {
            return this.ticketCount;
        }

        public QueryTripTrainOrderByPageResponseBodyList setTotalAmount(Long totalAmount) {
            this.totalAmount = totalAmount;
            return this;
        }
        public Long getTotalAmount() {
            return this.totalAmount;
        }

        public QueryTripTrainOrderByPageResponseBodyList setTrainNumber(String trainNumber) {
            this.trainNumber = trainNumber;
            return this;
        }
        public String getTrainNumber() {
            return this.trainNumber;
        }

        public QueryTripTrainOrderByPageResponseBodyList setTrainOrderStatus(String trainOrderStatus) {
            this.trainOrderStatus = trainOrderStatus;
            return this;
        }
        public String getTrainOrderStatus() {
            return this.trainOrderStatus;
        }

        public QueryTripTrainOrderByPageResponseBodyList setTrainOrderStatusDesc(String trainOrderStatusDesc) {
            this.trainOrderStatusDesc = trainOrderStatusDesc;
            return this;
        }
        public String getTrainOrderStatusDesc() {
            return this.trainOrderStatusDesc;
        }

        public QueryTripTrainOrderByPageResponseBodyList setUpdateTime(Long updateTime) {
            this.updateTime = updateTime;
            return this;
        }
        public Long getUpdateTime() {
            return this.updateTime;
        }

        public QueryTripTrainOrderByPageResponseBodyList setUserId(String userId) {
            this.userId = userId;
            return this;
        }
        public String getUserId() {
            return this.userId;
        }

        public QueryTripTrainOrderByPageResponseBodyList setUserName(String userName) {
            this.userName = userName;
            return this;
        }
        public String getUserName() {
            return this.userName;
        }

    }

}
