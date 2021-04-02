// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkalitrip_1_0.models;

import com.aliyun.tea.*;

public class QueryCityCarApplyResponseBody extends TeaModel {
    // 审批单列表
    @NameInMap("applyList")
    public java.util.List<QueryCityCarApplyResponseBodyApplyList> applyList;

    // 总数
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
        // 审批备注
        @NameInMap("note")
        public String note;

        // 审批时间
        @NameInMap("operateTime")
        public String operateTime;

        // 审批人排序值
        @NameInMap("order")
        public Long order;

        // 审批状态枚举：审批状态：0-审批中，1-已同意，2-已拒绝
        @NameInMap("status")
        public Long status;

        // 审批状态描述
        @NameInMap("statusDesc")
        public String statusDesc;

        // 审批员工ID
        @NameInMap("userId")
        public String userId;

        // 审批员工名
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
        // 目的地城市
        @NameInMap("arrCity")
        public String arrCity;

        // 目的地城市三字码
        @NameInMap("arrCityCode")
        public String arrCityCode;

        // 到达目的地城市时间
        @NameInMap("arrDate")
        public String arrDate;

        // 商旅内部成本中心ID
        @NameInMap("costCenterId")
        public Long costCenterId;

        // 成本中心名称
        @NameInMap("costCenterName")
        public String costCenterName;

        // 出发城市
        @NameInMap("depCity")
        public String depCity;

        // 出发城市三字码
        @NameInMap("depCityCode")
        public String depCityCode;

        // 出发时间
        @NameInMap("depDate")
        public String depDate;

        // 商旅内部发票抬头ID
        @NameInMap("invoiceId")
        public Long invoiceId;

        // 发票抬头名称
        @NameInMap("invoiceName")
        public String invoiceName;

        // 商旅内部行程单ID
        @NameInMap("itineraryId")
        public String itineraryId;

        // 项目code
        @NameInMap("projectCode")
        public String projectCode;

        // 项目名称
        @NameInMap("projectTitle")
        public String projectTitle;

        // 交通方式：4-市内交通
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
        // 审批单列表
        @NameInMap("approverList")
        public java.util.List<QueryCityCarApplyResponseBodyApplyListApproverList> approverList;

        // 员工所在部门ID
        @NameInMap("departId")
        public String departId;

        // 员工所在部门名
        @NameInMap("departName")
        public String departName;

        // 创建时间
        @NameInMap("gmtCreate")
        public String gmtCreate;

        // 最近修改时间
        @NameInMap("gmtModified")
        public String gmtModified;

        // 审批单关联的行程
        @NameInMap("itineraryList")
        public java.util.List<QueryCityCarApplyResponseBodyApplyListItineraryList> itineraryList;

        // 审批单状态：0-申请，1-同意，2-拒绝
        @NameInMap("status")
        public Long status;

        // 审批单状态：0-申请，1-同意，2-拒绝
        @NameInMap("statusDesc")
        public String statusDesc;

        // 三方审批单ID
        @NameInMap("thirdPartApplyId")
        public String thirdPartApplyId;

        // 申请事由
        @NameInMap("tripCause")
        public String tripCause;

        // 审批单标题
        @NameInMap("tripTitle")
        public String tripTitle;

        // 发起审批员工ID
        @NameInMap("userId")
        public String userId;

        // 发起审批员工名
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
