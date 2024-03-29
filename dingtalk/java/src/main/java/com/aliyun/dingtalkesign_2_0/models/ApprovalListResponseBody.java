// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkesign_2_0.models;

import com.aliyun.tea.*;

public class ApprovalListResponseBody extends TeaModel {
    @NameInMap("data")
    public java.util.List<ApprovalListResponseBodyData> data;

    public static ApprovalListResponseBody build(java.util.Map<String, ?> map) throws Exception {
        ApprovalListResponseBody self = new ApprovalListResponseBody();
        return TeaModel.build(map, self);
    }

    public ApprovalListResponseBody setData(java.util.List<ApprovalListResponseBodyData> data) {
        this.data = data;
        return this;
    }
    public java.util.List<ApprovalListResponseBodyData> getData() {
        return this.data;
    }

    public static class ApprovalListResponseBodyDataApprovalNodes extends TeaModel {
        @NameInMap("approvalTime")
        public String approvalTime;

        @NameInMap("approverName")
        public String approverName;

        @NameInMap("startTime")
        public Float startTime;

        @NameInMap("status")
        public String status;

        public static ApprovalListResponseBodyDataApprovalNodes build(java.util.Map<String, ?> map) throws Exception {
            ApprovalListResponseBodyDataApprovalNodes self = new ApprovalListResponseBodyDataApprovalNodes();
            return TeaModel.build(map, self);
        }

        public ApprovalListResponseBodyDataApprovalNodes setApprovalTime(String approvalTime) {
            this.approvalTime = approvalTime;
            return this;
        }
        public String getApprovalTime() {
            return this.approvalTime;
        }

        public ApprovalListResponseBodyDataApprovalNodes setApproverName(String approverName) {
            this.approverName = approverName;
            return this;
        }
        public String getApproverName() {
            return this.approverName;
        }

        public ApprovalListResponseBodyDataApprovalNodes setStartTime(Float startTime) {
            this.startTime = startTime;
            return this;
        }
        public Float getStartTime() {
            return this.startTime;
        }

        public ApprovalListResponseBodyDataApprovalNodes setStatus(String status) {
            this.status = status;
            return this;
        }
        public String getStatus() {
            return this.status;
        }

    }

    public static class ApprovalListResponseBodyData extends TeaModel {
        @NameInMap("approvalName")
        public String approvalName;

        @NameInMap("approvalNodes")
        public java.util.List<ApprovalListResponseBodyDataApprovalNodes> approvalNodes;

        @NameInMap("endTime")
        public Float endTime;

        @NameInMap("refuseReason")
        public String refuseReason;

        @NameInMap("sealIdImg")
        public String sealIdImg;

        @NameInMap("sponsorAccountName")
        public String sponsorAccountName;

        @NameInMap("startTime")
        public Float startTime;

        @NameInMap("status")
        public String status;

        public static ApprovalListResponseBodyData build(java.util.Map<String, ?> map) throws Exception {
            ApprovalListResponseBodyData self = new ApprovalListResponseBodyData();
            return TeaModel.build(map, self);
        }

        public ApprovalListResponseBodyData setApprovalName(String approvalName) {
            this.approvalName = approvalName;
            return this;
        }
        public String getApprovalName() {
            return this.approvalName;
        }

        public ApprovalListResponseBodyData setApprovalNodes(java.util.List<ApprovalListResponseBodyDataApprovalNodes> approvalNodes) {
            this.approvalNodes = approvalNodes;
            return this;
        }
        public java.util.List<ApprovalListResponseBodyDataApprovalNodes> getApprovalNodes() {
            return this.approvalNodes;
        }

        public ApprovalListResponseBodyData setEndTime(Float endTime) {
            this.endTime = endTime;
            return this;
        }
        public Float getEndTime() {
            return this.endTime;
        }

        public ApprovalListResponseBodyData setRefuseReason(String refuseReason) {
            this.refuseReason = refuseReason;
            return this;
        }
        public String getRefuseReason() {
            return this.refuseReason;
        }

        public ApprovalListResponseBodyData setSealIdImg(String sealIdImg) {
            this.sealIdImg = sealIdImg;
            return this;
        }
        public String getSealIdImg() {
            return this.sealIdImg;
        }

        public ApprovalListResponseBodyData setSponsorAccountName(String sponsorAccountName) {
            this.sponsorAccountName = sponsorAccountName;
            return this;
        }
        public String getSponsorAccountName() {
            return this.sponsorAccountName;
        }

        public ApprovalListResponseBodyData setStartTime(Float startTime) {
            this.startTime = startTime;
            return this;
        }
        public Float getStartTime() {
            return this.startTime;
        }

        public ApprovalListResponseBodyData setStatus(String status) {
            this.status = status;
            return this;
        }
        public String getStatus() {
            return this.status;
        }

    }

}
