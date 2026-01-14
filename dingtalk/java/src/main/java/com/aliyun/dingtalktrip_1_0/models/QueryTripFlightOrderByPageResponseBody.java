// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalktrip_1_0.models;

import com.aliyun.tea.*;

public class QueryTripFlightOrderByPageResponseBody extends TeaModel {
    @NameInMap("hasMore")
    public Boolean hasMore;

    @NameInMap("list")
    public java.util.List<QueryTripFlightOrderByPageResponseBodyList> list;

    @NameInMap("nextCursor")
    public Long nextCursor;

    @NameInMap("totalCount")
    public Long totalCount;

    public static QueryTripFlightOrderByPageResponseBody build(java.util.Map<String, ?> map) throws Exception {
        QueryTripFlightOrderByPageResponseBody self = new QueryTripFlightOrderByPageResponseBody();
        return TeaModel.build(map, self);
    }

    public QueryTripFlightOrderByPageResponseBody setHasMore(Boolean hasMore) {
        this.hasMore = hasMore;
        return this;
    }
    public Boolean getHasMore() {
        return this.hasMore;
    }

    public QueryTripFlightOrderByPageResponseBody setList(java.util.List<QueryTripFlightOrderByPageResponseBodyList> list) {
        this.list = list;
        return this;
    }
    public java.util.List<QueryTripFlightOrderByPageResponseBodyList> getList() {
        return this.list;
    }

    public QueryTripFlightOrderByPageResponseBody setNextCursor(Long nextCursor) {
        this.nextCursor = nextCursor;
        return this;
    }
    public Long getNextCursor() {
        return this.nextCursor;
    }

    public QueryTripFlightOrderByPageResponseBody setTotalCount(Long totalCount) {
        this.totalCount = totalCount;
        return this;
    }
    public Long getTotalCount() {
        return this.totalCount;
    }

    public static class QueryTripFlightOrderByPageResponseBodyListConsumerInfos extends TeaModel {
        @NameInMap("name")
        public String name;

        @NameInMap("staffFlag")
        public Boolean staffFlag;

        @NameInMap("userId")
        public String userId;

        public static QueryTripFlightOrderByPageResponseBodyListConsumerInfos build(java.util.Map<String, ?> map) throws Exception {
            QueryTripFlightOrderByPageResponseBodyListConsumerInfos self = new QueryTripFlightOrderByPageResponseBodyListConsumerInfos();
            return TeaModel.build(map, self);
        }

        public QueryTripFlightOrderByPageResponseBodyListConsumerInfos setName(String name) {
            this.name = name;
            return this;
        }
        public String getName() {
            return this.name;
        }

        public QueryTripFlightOrderByPageResponseBodyListConsumerInfos setStaffFlag(Boolean staffFlag) {
            this.staffFlag = staffFlag;
            return this;
        }
        public Boolean getStaffFlag() {
            return this.staffFlag;
        }

        public QueryTripFlightOrderByPageResponseBodyListConsumerInfos setUserId(String userId) {
            this.userId = userId;
            return this;
        }
        public String getUserId() {
            return this.userId;
        }

    }

    public static class QueryTripFlightOrderByPageResponseBodyList extends TeaModel {
        @NameInMap("arrivalTime")
        public String arrivalTime;

        @NameInMap("consumerInfos")
        public java.util.List<QueryTripFlightOrderByPageResponseBodyListConsumerInfos> consumerInfos;

        @NameInMap("contactName")
        public String contactName;

        @NameInMap("costCenter")
        public String costCenter;

        @NameInMap("costCenterCode")
        public String costCenterCode;

        @NameInMap("createTime")
        public Long createTime;

        @NameInMap("departTime")
        public String departTime;

        @NameInMap("departmentId")
        public String departmentId;

        @NameInMap("departmentName")
        public String departmentName;

        @NameInMap("destinationCity")
        public String destinationCity;

        @NameInMap("destinationStation")
        public String destinationStation;

        @NameInMap("flightOrderStatus")
        public Integer flightOrderStatus;

        @NameInMap("flightOrderStatusDesc")
        public String flightOrderStatusDesc;

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

        @NameInMap("originCity")
        public String originCity;

        @NameInMap("originStation")
        public String originStation;

        @NameInMap("passengerCount")
        public Integer passengerCount;

        @NameInMap("passengerName")
        public String passengerName;

        @NameInMap("processInstanceId")
        public String processInstanceId;

        @NameInMap("seatType")
        public String seatType;

        @NameInMap("totalAmount")
        public Long totalAmount;

        @NameInMap("transportNumber")
        public String transportNumber;

        @NameInMap("tripType")
        public String tripType;

        @NameInMap("updateTime")
        public Long updateTime;

        @NameInMap("userId")
        public String userId;

        @NameInMap("userName")
        public String userName;

        public static QueryTripFlightOrderByPageResponseBodyList build(java.util.Map<String, ?> map) throws Exception {
            QueryTripFlightOrderByPageResponseBodyList self = new QueryTripFlightOrderByPageResponseBodyList();
            return TeaModel.build(map, self);
        }

        public QueryTripFlightOrderByPageResponseBodyList setArrivalTime(String arrivalTime) {
            this.arrivalTime = arrivalTime;
            return this;
        }
        public String getArrivalTime() {
            return this.arrivalTime;
        }

        public QueryTripFlightOrderByPageResponseBodyList setConsumerInfos(java.util.List<QueryTripFlightOrderByPageResponseBodyListConsumerInfos> consumerInfos) {
            this.consumerInfos = consumerInfos;
            return this;
        }
        public java.util.List<QueryTripFlightOrderByPageResponseBodyListConsumerInfos> getConsumerInfos() {
            return this.consumerInfos;
        }

        public QueryTripFlightOrderByPageResponseBodyList setContactName(String contactName) {
            this.contactName = contactName;
            return this;
        }
        public String getContactName() {
            return this.contactName;
        }

        public QueryTripFlightOrderByPageResponseBodyList setCostCenter(String costCenter) {
            this.costCenter = costCenter;
            return this;
        }
        public String getCostCenter() {
            return this.costCenter;
        }

        public QueryTripFlightOrderByPageResponseBodyList setCostCenterCode(String costCenterCode) {
            this.costCenterCode = costCenterCode;
            return this;
        }
        public String getCostCenterCode() {
            return this.costCenterCode;
        }

        public QueryTripFlightOrderByPageResponseBodyList setCreateTime(Long createTime) {
            this.createTime = createTime;
            return this;
        }
        public Long getCreateTime() {
            return this.createTime;
        }

        public QueryTripFlightOrderByPageResponseBodyList setDepartTime(String departTime) {
            this.departTime = departTime;
            return this;
        }
        public String getDepartTime() {
            return this.departTime;
        }

        public QueryTripFlightOrderByPageResponseBodyList setDepartmentId(String departmentId) {
            this.departmentId = departmentId;
            return this;
        }
        public String getDepartmentId() {
            return this.departmentId;
        }

        public QueryTripFlightOrderByPageResponseBodyList setDepartmentName(String departmentName) {
            this.departmentName = departmentName;
            return this;
        }
        public String getDepartmentName() {
            return this.departmentName;
        }

        public QueryTripFlightOrderByPageResponseBodyList setDestinationCity(String destinationCity) {
            this.destinationCity = destinationCity;
            return this;
        }
        public String getDestinationCity() {
            return this.destinationCity;
        }

        public QueryTripFlightOrderByPageResponseBodyList setDestinationStation(String destinationStation) {
            this.destinationStation = destinationStation;
            return this;
        }
        public String getDestinationStation() {
            return this.destinationStation;
        }

        public QueryTripFlightOrderByPageResponseBodyList setFlightOrderStatus(Integer flightOrderStatus) {
            this.flightOrderStatus = flightOrderStatus;
            return this;
        }
        public Integer getFlightOrderStatus() {
            return this.flightOrderStatus;
        }

        public QueryTripFlightOrderByPageResponseBodyList setFlightOrderStatusDesc(String flightOrderStatusDesc) {
            this.flightOrderStatusDesc = flightOrderStatusDesc;
            return this;
        }
        public String getFlightOrderStatusDesc() {
            return this.flightOrderStatusDesc;
        }

        public QueryTripFlightOrderByPageResponseBodyList setGmtOrder(Long gmtOrder) {
            this.gmtOrder = gmtOrder;
            return this;
        }
        public Long getGmtOrder() {
            return this.gmtOrder;
        }

        public QueryTripFlightOrderByPageResponseBodyList setGmtPay(Long gmtPay) {
            this.gmtPay = gmtPay;
            return this;
        }
        public Long getGmtPay() {
            return this.gmtPay;
        }

        public QueryTripFlightOrderByPageResponseBodyList setInvoiceId(String invoiceId) {
            this.invoiceId = invoiceId;
            return this;
        }
        public String getInvoiceId() {
            return this.invoiceId;
        }

        public QueryTripFlightOrderByPageResponseBodyList setInvoiceTitle(String invoiceTitle) {
            this.invoiceTitle = invoiceTitle;
            return this;
        }
        public String getInvoiceTitle() {
            return this.invoiceTitle;
        }

        public QueryTripFlightOrderByPageResponseBodyList setOrderDetails(String orderDetails) {
            this.orderDetails = orderDetails;
            return this;
        }
        public String getOrderDetails() {
            return this.orderDetails;
        }

        public QueryTripFlightOrderByPageResponseBodyList setOrderNo(String orderNo) {
            this.orderNo = orderNo;
            return this;
        }
        public String getOrderNo() {
            return this.orderNo;
        }

        public QueryTripFlightOrderByPageResponseBodyList setOriginCity(String originCity) {
            this.originCity = originCity;
            return this;
        }
        public String getOriginCity() {
            return this.originCity;
        }

        public QueryTripFlightOrderByPageResponseBodyList setOriginStation(String originStation) {
            this.originStation = originStation;
            return this;
        }
        public String getOriginStation() {
            return this.originStation;
        }

        public QueryTripFlightOrderByPageResponseBodyList setPassengerCount(Integer passengerCount) {
            this.passengerCount = passengerCount;
            return this;
        }
        public Integer getPassengerCount() {
            return this.passengerCount;
        }

        public QueryTripFlightOrderByPageResponseBodyList setPassengerName(String passengerName) {
            this.passengerName = passengerName;
            return this;
        }
        public String getPassengerName() {
            return this.passengerName;
        }

        public QueryTripFlightOrderByPageResponseBodyList setProcessInstanceId(String processInstanceId) {
            this.processInstanceId = processInstanceId;
            return this;
        }
        public String getProcessInstanceId() {
            return this.processInstanceId;
        }

        public QueryTripFlightOrderByPageResponseBodyList setSeatType(String seatType) {
            this.seatType = seatType;
            return this;
        }
        public String getSeatType() {
            return this.seatType;
        }

        public QueryTripFlightOrderByPageResponseBodyList setTotalAmount(Long totalAmount) {
            this.totalAmount = totalAmount;
            return this;
        }
        public Long getTotalAmount() {
            return this.totalAmount;
        }

        public QueryTripFlightOrderByPageResponseBodyList setTransportNumber(String transportNumber) {
            this.transportNumber = transportNumber;
            return this;
        }
        public String getTransportNumber() {
            return this.transportNumber;
        }

        public QueryTripFlightOrderByPageResponseBodyList setTripType(String tripType) {
            this.tripType = tripType;
            return this;
        }
        public String getTripType() {
            return this.tripType;
        }

        public QueryTripFlightOrderByPageResponseBodyList setUpdateTime(Long updateTime) {
            this.updateTime = updateTime;
            return this;
        }
        public Long getUpdateTime() {
            return this.updateTime;
        }

        public QueryTripFlightOrderByPageResponseBodyList setUserId(String userId) {
            this.userId = userId;
            return this;
        }
        public String getUserId() {
            return this.userId;
        }

        public QueryTripFlightOrderByPageResponseBodyList setUserName(String userName) {
            this.userName = userName;
            return this;
        }
        public String getUserName() {
            return this.userName;
        }

    }

}
