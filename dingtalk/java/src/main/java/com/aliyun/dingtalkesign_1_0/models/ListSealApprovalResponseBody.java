// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkesign_1_0.models;

import com.aliyun.tea.*;

public class ListSealApprovalResponseBody extends TeaModel {
    @NameInMap("data")
    public java.util.List<ListSealApprovalResponseBodyData> data;

    @NameInMap("code")
    public Integer code;

    @NameInMap("message")
    public String message;

    public static ListSealApprovalResponseBody build(java.util.Map<String, ?> map) throws Exception {
        ListSealApprovalResponseBody self = new ListSealApprovalResponseBody();
        return TeaModel.build(map, self);
    }

    public ListSealApprovalResponseBody setData(java.util.List<ListSealApprovalResponseBodyData> data) {
        this.data = data;
        return this;
    }
    public java.util.List<ListSealApprovalResponseBodyData> getData() {
        return this.data;
    }

    public ListSealApprovalResponseBody setCode(Integer code) {
        this.code = code;
        return this;
    }
    public Integer getCode() {
        return this.code;
    }

    public ListSealApprovalResponseBody setMessage(String message) {
        this.message = message;
        return this;
    }
    public String getMessage() {
        return this.message;
    }

    public static class ListSealApprovalResponseBodyDataApprovalNodes extends TeaModel {
        @NameInMap("approverName")
        public String approverName;

        @NameInMap("status")
        public String status;

        @NameInMap("startTime")
        public Long startTime;

        @NameInMap("approvalTime")
        public Long approvalTime;

        public static ListSealApprovalResponseBodyDataApprovalNodes build(java.util.Map<String, ?> map) throws Exception {
            ListSealApprovalResponseBodyDataApprovalNodes self = new ListSealApprovalResponseBodyDataApprovalNodes();
            return TeaModel.build(map, self);
        }

        public ListSealApprovalResponseBodyDataApprovalNodes setApproverName(String approverName) {
            this.approverName = approverName;
            return this;
        }
        public String getApproverName() {
            return this.approverName;
        }

        public ListSealApprovalResponseBodyDataApprovalNodes setStatus(String status) {
            this.status = status;
            return this;
        }
        public String getStatus() {
            return this.status;
        }

        public ListSealApprovalResponseBodyDataApprovalNodes setStartTime(Long startTime) {
            this.startTime = startTime;
            return this;
        }
        public Long getStartTime() {
            return this.startTime;
        }

        public ListSealApprovalResponseBodyDataApprovalNodes setApprovalTime(Long approvalTime) {
            this.approvalTime = approvalTime;
            return this;
        }
        public Long getApprovalTime() {
            return this.approvalTime;
        }

    }

    public static class ListSealApprovalResponseBodyData extends TeaModel {
        @NameInMap("approvalName")
        public String approvalName;

        @NameInMap("status")
        public String status;

        @NameInMap("refuseReason")
        public String refuseReason;

        @NameInMap("sponsorAccountName")
        public String sponsorAccountName;

        @NameInMap("startTime")
        public Long startTime;

        @NameInMap("endTime")
        public Long endTime;

        @NameInMap("sealIdImg")
        public String sealIdImg;

        @NameInMap("approvalNodes")
        public java.util.List<ListSealApprovalResponseBodyDataApprovalNodes> approvalNodes;

        public static ListSealApprovalResponseBodyData build(java.util.Map<String, ?> map) throws Exception {
            ListSealApprovalResponseBodyData self = new ListSealApprovalResponseBodyData();
            return TeaModel.build(map, self);
        }

        public ListSealApprovalResponseBodyData setApprovalName(String approvalName) {
            this.approvalName = approvalName;
            return this;
        }
        public String getApprovalName() {
            return this.approvalName;
        }

        public ListSealApprovalResponseBodyData setStatus(String status) {
            this.status = status;
            return this;
        }
        public String getStatus() {
            return this.status;
        }

        public ListSealApprovalResponseBodyData setRefuseReason(String refuseReason) {
            this.refuseReason = refuseReason;
            return this;
        }
        public String getRefuseReason() {
            return this.refuseReason;
        }

        public ListSealApprovalResponseBodyData setSponsorAccountName(String sponsorAccountName) {
            this.sponsorAccountName = sponsorAccountName;
            return this;
        }
        public String getSponsorAccountName() {
            return this.sponsorAccountName;
        }

        public ListSealApprovalResponseBodyData setStartTime(Long startTime) {
            this.startTime = startTime;
            return this;
        }
        public Long getStartTime() {
            return this.startTime;
        }

        public ListSealApprovalResponseBodyData setEndTime(Long endTime) {
            this.endTime = endTime;
            return this;
        }
        public Long getEndTime() {
            return this.endTime;
        }

        public ListSealApprovalResponseBodyData setSealIdImg(String sealIdImg) {
            this.sealIdImg = sealIdImg;
            return this;
        }
        public String getSealIdImg() {
            return this.sealIdImg;
        }

        public ListSealApprovalResponseBodyData setApprovalNodes(java.util.List<ListSealApprovalResponseBodyDataApprovalNodes> approvalNodes) {
            this.approvalNodes = approvalNodes;
            return this;
        }
        public java.util.List<ListSealApprovalResponseBodyDataApprovalNodes> getApprovalNodes() {
            return this.approvalNodes;
        }

    }

}
