// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalktrip_1_0.models;

import com.aliyun.tea.*;

public class QueryTripHotelOrderByPageResponseBody extends TeaModel {
    @NameInMap("hasMore")
    public Boolean hasMore;

    @NameInMap("list")
    public java.util.List<QueryTripHotelOrderByPageResponseBodyList> list;

    @NameInMap("nextCursor")
    public Long nextCursor;

    @NameInMap("totalCount")
    public Long totalCount;

    public static QueryTripHotelOrderByPageResponseBody build(java.util.Map<String, ?> map) throws Exception {
        QueryTripHotelOrderByPageResponseBody self = new QueryTripHotelOrderByPageResponseBody();
        return TeaModel.build(map, self);
    }

    public QueryTripHotelOrderByPageResponseBody setHasMore(Boolean hasMore) {
        this.hasMore = hasMore;
        return this;
    }
    public Boolean getHasMore() {
        return this.hasMore;
    }

    public QueryTripHotelOrderByPageResponseBody setList(java.util.List<QueryTripHotelOrderByPageResponseBodyList> list) {
        this.list = list;
        return this;
    }
    public java.util.List<QueryTripHotelOrderByPageResponseBodyList> getList() {
        return this.list;
    }

    public QueryTripHotelOrderByPageResponseBody setNextCursor(Long nextCursor) {
        this.nextCursor = nextCursor;
        return this;
    }
    public Long getNextCursor() {
        return this.nextCursor;
    }

    public QueryTripHotelOrderByPageResponseBody setTotalCount(Long totalCount) {
        this.totalCount = totalCount;
        return this;
    }
    public Long getTotalCount() {
        return this.totalCount;
    }

    public static class QueryTripHotelOrderByPageResponseBodyListConsumerInfos extends TeaModel {
        @NameInMap("name")
        public String name;

        @NameInMap("staffFlag")
        public Boolean staffFlag;

        @NameInMap("userId")
        public String userId;

        public static QueryTripHotelOrderByPageResponseBodyListConsumerInfos build(java.util.Map<String, ?> map) throws Exception {
            QueryTripHotelOrderByPageResponseBodyListConsumerInfos self = new QueryTripHotelOrderByPageResponseBodyListConsumerInfos();
            return TeaModel.build(map, self);
        }

        public QueryTripHotelOrderByPageResponseBodyListConsumerInfos setName(String name) {
            this.name = name;
            return this;
        }
        public String getName() {
            return this.name;
        }

        public QueryTripHotelOrderByPageResponseBodyListConsumerInfos setStaffFlag(Boolean staffFlag) {
            this.staffFlag = staffFlag;
            return this;
        }
        public Boolean getStaffFlag() {
            return this.staffFlag;
        }

        public QueryTripHotelOrderByPageResponseBodyListConsumerInfos setUserId(String userId) {
            this.userId = userId;
            return this;
        }
        public String getUserId() {
            return this.userId;
        }

    }

    public static class QueryTripHotelOrderByPageResponseBodyList extends TeaModel {
        @NameInMap("checkInTime")
        public String checkInTime;

        @NameInMap("checkOutTime")
        public String checkOutTime;

        @NameInMap("city")
        public String city;

        @NameInMap("consumerInfos")
        public java.util.List<QueryTripHotelOrderByPageResponseBodyListConsumerInfos> consumerInfos;

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

        @NameInMap("gmtOrder")
        public Long gmtOrder;

        @NameInMap("gmtPay")
        public Long gmtPay;

        @NameInMap("guest")
        public String guest;

        @NameInMap("hotelName")
        public String hotelName;

        @NameInMap("hotelOrderStatus")
        public String hotelOrderStatus;

        @NameInMap("hotelOrderStatusDesc")
        public String hotelOrderStatusDesc;

        @NameInMap("invoiceId")
        public String invoiceId;

        @NameInMap("invoiceTitle")
        public String invoiceTitle;

        @NameInMap("night")
        public Integer night;

        @NameInMap("orderDetails")
        public String orderDetails;

        @NameInMap("orderNo")
        public String orderNo;

        @NameInMap("payType")
        public String payType;

        @NameInMap("processInstanceId")
        public String processInstanceId;

        @NameInMap("roomNum")
        public Integer roomNum;

        @NameInMap("roomType")
        public String roomType;

        @NameInMap("totalAmount")
        public Long totalAmount;

        @NameInMap("updateTime")
        public Long updateTime;

        @NameInMap("userId")
        public String userId;

        @NameInMap("userName")
        public String userName;

        public static QueryTripHotelOrderByPageResponseBodyList build(java.util.Map<String, ?> map) throws Exception {
            QueryTripHotelOrderByPageResponseBodyList self = new QueryTripHotelOrderByPageResponseBodyList();
            return TeaModel.build(map, self);
        }

        public QueryTripHotelOrderByPageResponseBodyList setCheckInTime(String checkInTime) {
            this.checkInTime = checkInTime;
            return this;
        }
        public String getCheckInTime() {
            return this.checkInTime;
        }

        public QueryTripHotelOrderByPageResponseBodyList setCheckOutTime(String checkOutTime) {
            this.checkOutTime = checkOutTime;
            return this;
        }
        public String getCheckOutTime() {
            return this.checkOutTime;
        }

        public QueryTripHotelOrderByPageResponseBodyList setCity(String city) {
            this.city = city;
            return this;
        }
        public String getCity() {
            return this.city;
        }

        public QueryTripHotelOrderByPageResponseBodyList setConsumerInfos(java.util.List<QueryTripHotelOrderByPageResponseBodyListConsumerInfos> consumerInfos) {
            this.consumerInfos = consumerInfos;
            return this;
        }
        public java.util.List<QueryTripHotelOrderByPageResponseBodyListConsumerInfos> getConsumerInfos() {
            return this.consumerInfos;
        }

        public QueryTripHotelOrderByPageResponseBodyList setContactName(String contactName) {
            this.contactName = contactName;
            return this;
        }
        public String getContactName() {
            return this.contactName;
        }

        public QueryTripHotelOrderByPageResponseBodyList setCostCenter(String costCenter) {
            this.costCenter = costCenter;
            return this;
        }
        public String getCostCenter() {
            return this.costCenter;
        }

        public QueryTripHotelOrderByPageResponseBodyList setCostCenterCode(String costCenterCode) {
            this.costCenterCode = costCenterCode;
            return this;
        }
        public String getCostCenterCode() {
            return this.costCenterCode;
        }

        public QueryTripHotelOrderByPageResponseBodyList setCreateTime(Long createTime) {
            this.createTime = createTime;
            return this;
        }
        public Long getCreateTime() {
            return this.createTime;
        }

        public QueryTripHotelOrderByPageResponseBodyList setDepartmentId(String departmentId) {
            this.departmentId = departmentId;
            return this;
        }
        public String getDepartmentId() {
            return this.departmentId;
        }

        public QueryTripHotelOrderByPageResponseBodyList setDepartmentName(String departmentName) {
            this.departmentName = departmentName;
            return this;
        }
        public String getDepartmentName() {
            return this.departmentName;
        }

        public QueryTripHotelOrderByPageResponseBodyList setGmtOrder(Long gmtOrder) {
            this.gmtOrder = gmtOrder;
            return this;
        }
        public Long getGmtOrder() {
            return this.gmtOrder;
        }

        public QueryTripHotelOrderByPageResponseBodyList setGmtPay(Long gmtPay) {
            this.gmtPay = gmtPay;
            return this;
        }
        public Long getGmtPay() {
            return this.gmtPay;
        }

        public QueryTripHotelOrderByPageResponseBodyList setGuest(String guest) {
            this.guest = guest;
            return this;
        }
        public String getGuest() {
            return this.guest;
        }

        public QueryTripHotelOrderByPageResponseBodyList setHotelName(String hotelName) {
            this.hotelName = hotelName;
            return this;
        }
        public String getHotelName() {
            return this.hotelName;
        }

        public QueryTripHotelOrderByPageResponseBodyList setHotelOrderStatus(String hotelOrderStatus) {
            this.hotelOrderStatus = hotelOrderStatus;
            return this;
        }
        public String getHotelOrderStatus() {
            return this.hotelOrderStatus;
        }

        public QueryTripHotelOrderByPageResponseBodyList setHotelOrderStatusDesc(String hotelOrderStatusDesc) {
            this.hotelOrderStatusDesc = hotelOrderStatusDesc;
            return this;
        }
        public String getHotelOrderStatusDesc() {
            return this.hotelOrderStatusDesc;
        }

        public QueryTripHotelOrderByPageResponseBodyList setInvoiceId(String invoiceId) {
            this.invoiceId = invoiceId;
            return this;
        }
        public String getInvoiceId() {
            return this.invoiceId;
        }

        public QueryTripHotelOrderByPageResponseBodyList setInvoiceTitle(String invoiceTitle) {
            this.invoiceTitle = invoiceTitle;
            return this;
        }
        public String getInvoiceTitle() {
            return this.invoiceTitle;
        }

        public QueryTripHotelOrderByPageResponseBodyList setNight(Integer night) {
            this.night = night;
            return this;
        }
        public Integer getNight() {
            return this.night;
        }

        public QueryTripHotelOrderByPageResponseBodyList setOrderDetails(String orderDetails) {
            this.orderDetails = orderDetails;
            return this;
        }
        public String getOrderDetails() {
            return this.orderDetails;
        }

        public QueryTripHotelOrderByPageResponseBodyList setOrderNo(String orderNo) {
            this.orderNo = orderNo;
            return this;
        }
        public String getOrderNo() {
            return this.orderNo;
        }

        public QueryTripHotelOrderByPageResponseBodyList setPayType(String payType) {
            this.payType = payType;
            return this;
        }
        public String getPayType() {
            return this.payType;
        }

        public QueryTripHotelOrderByPageResponseBodyList setProcessInstanceId(String processInstanceId) {
            this.processInstanceId = processInstanceId;
            return this;
        }
        public String getProcessInstanceId() {
            return this.processInstanceId;
        }

        public QueryTripHotelOrderByPageResponseBodyList setRoomNum(Integer roomNum) {
            this.roomNum = roomNum;
            return this;
        }
        public Integer getRoomNum() {
            return this.roomNum;
        }

        public QueryTripHotelOrderByPageResponseBodyList setRoomType(String roomType) {
            this.roomType = roomType;
            return this;
        }
        public String getRoomType() {
            return this.roomType;
        }

        public QueryTripHotelOrderByPageResponseBodyList setTotalAmount(Long totalAmount) {
            this.totalAmount = totalAmount;
            return this;
        }
        public Long getTotalAmount() {
            return this.totalAmount;
        }

        public QueryTripHotelOrderByPageResponseBodyList setUpdateTime(Long updateTime) {
            this.updateTime = updateTime;
            return this;
        }
        public Long getUpdateTime() {
            return this.updateTime;
        }

        public QueryTripHotelOrderByPageResponseBodyList setUserId(String userId) {
            this.userId = userId;
            return this;
        }
        public String getUserId() {
            return this.userId;
        }

        public QueryTripHotelOrderByPageResponseBodyList setUserName(String userName) {
            this.userName = userName;
            return this;
        }
        public String getUserName() {
            return this.userName;
        }

    }

}
