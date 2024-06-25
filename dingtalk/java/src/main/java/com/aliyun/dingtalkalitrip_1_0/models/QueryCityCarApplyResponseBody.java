// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkalitrip_1_0.models;

import com.aliyun.tea.*;

public class QueryCityCarApplyResponseBody extends TeaModel {
    @NameInMap("applyList")
    public java.util.List<QueryCityCarApplyResponseBodyApplyList> applyList;

    /**
     * <strong>example:</strong>
     * <p>10</p>
     */
    @NameInMap("total")
    public Long total;

    public static QueryCityCarApplyResponseBody build(java.util.Map<String, ?> map) throws Exception {
        QueryCityCarApplyResponseBody self = new QueryCityCarApplyResponseBody();
        return TeaModel.build(map, self);
    }

    public QueryCityCarApplyResponseBody setApplyList(java.util.List<QueryCityCarApplyResponseBodyApplyList> applyList) {
        this.applyList = applyList;
        return this;
    }
    public java.util.List<QueryCityCarApplyResponseBodyApplyList> getApplyList() {
        return this.applyList;
    }

    public QueryCityCarApplyResponseBody setTotal(Long total) {
        this.total = total;
        return this;
    }
    public Long getTotal() {
        return this.total;
    }

    public static class QueryCityCarApplyResponseBodyApplyListApproverList extends TeaModel {
        /**
         * <strong>example:</strong>
         * <p>同意</p>
         */
        @NameInMap("note")
        public String note;

        /**
         * <strong>example:</strong>
         * <p>2021-03-18 20:26:56</p>
         */
        @NameInMap("operateTime")
        public String operateTime;

        /**
         * <strong>example:</strong>
         * <p>1</p>
         */
        @NameInMap("order")
        public Long order;

        /**
         * <strong>example:</strong>
         * <p>1</p>
         */
        @NameInMap("status")
        public Long status;

        /**
         * <strong>example:</strong>
         * <p>同意</p>
         */
        @NameInMap("statusDesc")
        public String statusDesc;

        /**
         * <strong>example:</strong>
         * <p>user1</p>
         */
        @NameInMap("userId")
        public String userId;

        /**
         * <strong>example:</strong>
         * <p>员工1</p>
         */
        @NameInMap("userName")
        public String userName;

        public static QueryCityCarApplyResponseBodyApplyListApproverList build(java.util.Map<String, ?> map) throws Exception {
            QueryCityCarApplyResponseBodyApplyListApproverList self = new QueryCityCarApplyResponseBodyApplyListApproverList();
            return TeaModel.build(map, self);
        }

        public QueryCityCarApplyResponseBodyApplyListApproverList setNote(String note) {
            this.note = note;
            return this;
        }
        public String getNote() {
            return this.note;
        }

        public QueryCityCarApplyResponseBodyApplyListApproverList setOperateTime(String operateTime) {
            this.operateTime = operateTime;
            return this;
        }
        public String getOperateTime() {
            return this.operateTime;
        }

        public QueryCityCarApplyResponseBodyApplyListApproverList setOrder(Long order) {
            this.order = order;
            return this;
        }
        public Long getOrder() {
            return this.order;
        }

        public QueryCityCarApplyResponseBodyApplyListApproverList setStatus(Long status) {
            this.status = status;
            return this;
        }
        public Long getStatus() {
            return this.status;
        }

        public QueryCityCarApplyResponseBodyApplyListApproverList setStatusDesc(String statusDesc) {
            this.statusDesc = statusDesc;
            return this;
        }
        public String getStatusDesc() {
            return this.statusDesc;
        }

        public QueryCityCarApplyResponseBodyApplyListApproverList setUserId(String userId) {
            this.userId = userId;
            return this;
        }
        public String getUserId() {
            return this.userId;
        }

        public QueryCityCarApplyResponseBodyApplyListApproverList setUserName(String userName) {
            this.userName = userName;
            return this;
        }
        public String getUserName() {
            return this.userName;
        }

    }

    public static class QueryCityCarApplyResponseBodyApplyListItineraryList extends TeaModel {
        /**
         * <strong>example:</strong>
         * <p>杭州</p>
         */
        @NameInMap("arrCity")
        public String arrCity;

        /**
         * <strong>example:</strong>
         * <p>HGH</p>
         */
        @NameInMap("arrCityCode")
        public String arrCityCode;

        /**
         * <strong>example:</strong>
         * <p>2021-03-18 20:26:56</p>
         */
        @NameInMap("arrDate")
        public String arrDate;

        /**
         * <strong>example:</strong>
         * <p>1</p>
         */
        @NameInMap("costCenterId")
        public Long costCenterId;

        /**
         * <strong>example:</strong>
         * <p>成本中心1</p>
         */
        @NameInMap("costCenterName")
        public String costCenterName;

        /**
         * <strong>example:</strong>
         * <p>杭州</p>
         */
        @NameInMap("depCity")
        public String depCity;

        /**
         * <strong>example:</strong>
         * <p>HGH</p>
         */
        @NameInMap("depCityCode")
        public String depCityCode;

        /**
         * <strong>example:</strong>
         * <p>2021-03-18 20:26:56</p>
         */
        @NameInMap("depDate")
        public String depDate;

        /**
         * <strong>example:</strong>
         * <p>1</p>
         */
        @NameInMap("invoiceId")
        public Long invoiceId;

        /**
         * <strong>example:</strong>
         * <p>发票抬头1</p>
         */
        @NameInMap("invoiceName")
        public String invoiceName;

        /**
         * <strong>example:</strong>
         * <p>1</p>
         */
        @NameInMap("itineraryId")
        public String itineraryId;

        /**
         * <strong>example:</strong>
         * <p>projectx</p>
         */
        @NameInMap("projectCode")
        public String projectCode;

        /**
         * <strong>example:</strong>
         * <p>项目x</p>
         */
        @NameInMap("projectTitle")
        public String projectTitle;

        /**
         * <strong>example:</strong>
         * <p>4</p>
         */
        @NameInMap("trafficType")
        public Long trafficType;

        public static QueryCityCarApplyResponseBodyApplyListItineraryList build(java.util.Map<String, ?> map) throws Exception {
            QueryCityCarApplyResponseBodyApplyListItineraryList self = new QueryCityCarApplyResponseBodyApplyListItineraryList();
            return TeaModel.build(map, self);
        }

        public QueryCityCarApplyResponseBodyApplyListItineraryList setArrCity(String arrCity) {
            this.arrCity = arrCity;
            return this;
        }
        public String getArrCity() {
            return this.arrCity;
        }

        public QueryCityCarApplyResponseBodyApplyListItineraryList setArrCityCode(String arrCityCode) {
            this.arrCityCode = arrCityCode;
            return this;
        }
        public String getArrCityCode() {
            return this.arrCityCode;
        }

        public QueryCityCarApplyResponseBodyApplyListItineraryList setArrDate(String arrDate) {
            this.arrDate = arrDate;
            return this;
        }
        public String getArrDate() {
            return this.arrDate;
        }

        public QueryCityCarApplyResponseBodyApplyListItineraryList setCostCenterId(Long costCenterId) {
            this.costCenterId = costCenterId;
            return this;
        }
        public Long getCostCenterId() {
            return this.costCenterId;
        }

        public QueryCityCarApplyResponseBodyApplyListItineraryList setCostCenterName(String costCenterName) {
            this.costCenterName = costCenterName;
            return this;
        }
        public String getCostCenterName() {
            return this.costCenterName;
        }

        public QueryCityCarApplyResponseBodyApplyListItineraryList setDepCity(String depCity) {
            this.depCity = depCity;
            return this;
        }
        public String getDepCity() {
            return this.depCity;
        }

        public QueryCityCarApplyResponseBodyApplyListItineraryList setDepCityCode(String depCityCode) {
            this.depCityCode = depCityCode;
            return this;
        }
        public String getDepCityCode() {
            return this.depCityCode;
        }

        public QueryCityCarApplyResponseBodyApplyListItineraryList setDepDate(String depDate) {
            this.depDate = depDate;
            return this;
        }
        public String getDepDate() {
            return this.depDate;
        }

        public QueryCityCarApplyResponseBodyApplyListItineraryList setInvoiceId(Long invoiceId) {
            this.invoiceId = invoiceId;
            return this;
        }
        public Long getInvoiceId() {
            return this.invoiceId;
        }

        public QueryCityCarApplyResponseBodyApplyListItineraryList setInvoiceName(String invoiceName) {
            this.invoiceName = invoiceName;
            return this;
        }
        public String getInvoiceName() {
            return this.invoiceName;
        }

        public QueryCityCarApplyResponseBodyApplyListItineraryList setItineraryId(String itineraryId) {
            this.itineraryId = itineraryId;
            return this;
        }
        public String getItineraryId() {
            return this.itineraryId;
        }

        public QueryCityCarApplyResponseBodyApplyListItineraryList setProjectCode(String projectCode) {
            this.projectCode = projectCode;
            return this;
        }
        public String getProjectCode() {
            return this.projectCode;
        }

        public QueryCityCarApplyResponseBodyApplyListItineraryList setProjectTitle(String projectTitle) {
            this.projectTitle = projectTitle;
            return this;
        }
        public String getProjectTitle() {
            return this.projectTitle;
        }

        public QueryCityCarApplyResponseBodyApplyListItineraryList setTrafficType(Long trafficType) {
            this.trafficType = trafficType;
            return this;
        }
        public Long getTrafficType() {
            return this.trafficType;
        }

    }

    public static class QueryCityCarApplyResponseBodyApplyList extends TeaModel {
        @NameInMap("approverList")
        public java.util.List<QueryCityCarApplyResponseBodyApplyListApproverList> approverList;

        /**
         * <strong>example:</strong>
         * <p>1</p>
         */
        @NameInMap("departId")
        public String departId;

        /**
         * <strong>example:</strong>
         * <p>部门1</p>
         */
        @NameInMap("departName")
        public String departName;

        /**
         * <strong>example:</strong>
         * <p>2021-03-18 20:26:56</p>
         */
        @NameInMap("gmtCreate")
        public String gmtCreate;

        /**
         * <strong>example:</strong>
         * <p>2021-03-18 20:26:56</p>
         */
        @NameInMap("gmtModified")
        public String gmtModified;

        @NameInMap("itineraryList")
        public java.util.List<QueryCityCarApplyResponseBodyApplyListItineraryList> itineraryList;

        /**
         * <strong>example:</strong>
         * <p>申请</p>
         */
        @NameInMap("status")
        public Long status;

        /**
         * <strong>example:</strong>
         * <p>0</p>
         */
        @NameInMap("statusDesc")
        public String statusDesc;

        /**
         * <strong>example:</strong>
         * <p>apply1</p>
         */
        @NameInMap("thirdPartApplyId")
        public String thirdPartApplyId;

        /**
         * <strong>example:</strong>
         * <p>杭州出差</p>
         */
        @NameInMap("tripCause")
        public String tripCause;

        /**
         * <strong>example:</strong>
         * <p>杭州出差</p>
         */
        @NameInMap("tripTitle")
        public String tripTitle;

        /**
         * <strong>example:</strong>
         * <p>user1</p>
         */
        @NameInMap("userId")
        public String userId;

        /**
         * <strong>example:</strong>
         * <p>员工1</p>
         */
        @NameInMap("userName")
        public String userName;

        public static QueryCityCarApplyResponseBodyApplyList build(java.util.Map<String, ?> map) throws Exception {
            QueryCityCarApplyResponseBodyApplyList self = new QueryCityCarApplyResponseBodyApplyList();
            return TeaModel.build(map, self);
        }

        public QueryCityCarApplyResponseBodyApplyList setApproverList(java.util.List<QueryCityCarApplyResponseBodyApplyListApproverList> approverList) {
            this.approverList = approverList;
            return this;
        }
        public java.util.List<QueryCityCarApplyResponseBodyApplyListApproverList> getApproverList() {
            return this.approverList;
        }

        public QueryCityCarApplyResponseBodyApplyList setDepartId(String departId) {
            this.departId = departId;
            return this;
        }
        public String getDepartId() {
            return this.departId;
        }

        public QueryCityCarApplyResponseBodyApplyList setDepartName(String departName) {
            this.departName = departName;
            return this;
        }
        public String getDepartName() {
            return this.departName;
        }

        public QueryCityCarApplyResponseBodyApplyList setGmtCreate(String gmtCreate) {
            this.gmtCreate = gmtCreate;
            return this;
        }
        public String getGmtCreate() {
            return this.gmtCreate;
        }

        public QueryCityCarApplyResponseBodyApplyList setGmtModified(String gmtModified) {
            this.gmtModified = gmtModified;
            return this;
        }
        public String getGmtModified() {
            return this.gmtModified;
        }

        public QueryCityCarApplyResponseBodyApplyList setItineraryList(java.util.List<QueryCityCarApplyResponseBodyApplyListItineraryList> itineraryList) {
            this.itineraryList = itineraryList;
            return this;
        }
        public java.util.List<QueryCityCarApplyResponseBodyApplyListItineraryList> getItineraryList() {
            return this.itineraryList;
        }

        public QueryCityCarApplyResponseBodyApplyList setStatus(Long status) {
            this.status = status;
            return this;
        }
        public Long getStatus() {
            return this.status;
        }

        public QueryCityCarApplyResponseBodyApplyList setStatusDesc(String statusDesc) {
            this.statusDesc = statusDesc;
            return this;
        }
        public String getStatusDesc() {
            return this.statusDesc;
        }

        public QueryCityCarApplyResponseBodyApplyList setThirdPartApplyId(String thirdPartApplyId) {
            this.thirdPartApplyId = thirdPartApplyId;
            return this;
        }
        public String getThirdPartApplyId() {
            return this.thirdPartApplyId;
        }

        public QueryCityCarApplyResponseBodyApplyList setTripCause(String tripCause) {
            this.tripCause = tripCause;
            return this;
        }
        public String getTripCause() {
            return this.tripCause;
        }

        public QueryCityCarApplyResponseBodyApplyList setTripTitle(String tripTitle) {
            this.tripTitle = tripTitle;
            return this;
        }
        public String getTripTitle() {
            return this.tripTitle;
        }

        public QueryCityCarApplyResponseBodyApplyList setUserId(String userId) {
            this.userId = userId;
            return this;
        }
        public String getUserId() {
            return this.userId;
        }

        public QueryCityCarApplyResponseBodyApplyList setUserName(String userName) {
            this.userName = userName;
            return this;
        }
        public String getUserName() {
            return this.userName;
        }

    }

}
