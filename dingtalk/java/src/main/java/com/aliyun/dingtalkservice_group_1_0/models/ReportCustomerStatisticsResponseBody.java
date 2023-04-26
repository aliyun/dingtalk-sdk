// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkservice_group_1_0.models;

import com.aliyun.tea.*;

public class ReportCustomerStatisticsResponseBody extends TeaModel {
    @NameInMap("currentPage")
    public Long currentPage;

    @NameInMap("pageSize")
    public Long pageSize;

    @NameInMap("records")
    public java.util.List<ReportCustomerStatisticsResponseBodyRecords> records;

    @NameInMap("totalCount")
    public Long totalCount;

    public static ReportCustomerStatisticsResponseBody build(java.util.Map<String, ?> map) throws Exception {
        ReportCustomerStatisticsResponseBody self = new ReportCustomerStatisticsResponseBody();
        return TeaModel.build(map, self);
    }

    public ReportCustomerStatisticsResponseBody setCurrentPage(Long currentPage) {
        this.currentPage = currentPage;
        return this;
    }
    public Long getCurrentPage() {
        return this.currentPage;
    }

    public ReportCustomerStatisticsResponseBody setPageSize(Long pageSize) {
        this.pageSize = pageSize;
        return this;
    }
    public Long getPageSize() {
        return this.pageSize;
    }

    public ReportCustomerStatisticsResponseBody setRecords(java.util.List<ReportCustomerStatisticsResponseBodyRecords> records) {
        this.records = records;
        return this;
    }
    public java.util.List<ReportCustomerStatisticsResponseBodyRecords> getRecords() {
        return this.records;
    }

    public ReportCustomerStatisticsResponseBody setTotalCount(Long totalCount) {
        this.totalCount = totalCount;
        return this;
    }
    public Long getTotalCount() {
        return this.totalCount;
    }

    public static class ReportCustomerStatisticsResponseBodyRecords extends TeaModel {
        @NameInMap("atRobotCnt")
        public Long atRobotCnt;

        @NameInMap("bizId")
        public String bizId;

        @NameInMap("customerCnt")
        public Long customerCnt;

        @NameInMap("groupName")
        public String groupName;

        @NameInMap("groupSetName")
        public String groupSetName;

        @NameInMap("loginCnt")
        public Long loginCnt;

        @NameInMap("openConvCnt")
        public Long openConvCnt;

        @NameInMap("openConversationId")
        public String openConversationId;

        @NameInMap("openGroupSetId")
        public String openGroupSetId;

        @NameInMap("sendMsgCnt")
        public Long sendMsgCnt;

        @NameInMap("senderCnt")
        public Long senderCnt;

        public static ReportCustomerStatisticsResponseBodyRecords build(java.util.Map<String, ?> map) throws Exception {
            ReportCustomerStatisticsResponseBodyRecords self = new ReportCustomerStatisticsResponseBodyRecords();
            return TeaModel.build(map, self);
        }

        public ReportCustomerStatisticsResponseBodyRecords setAtRobotCnt(Long atRobotCnt) {
            this.atRobotCnt = atRobotCnt;
            return this;
        }
        public Long getAtRobotCnt() {
            return this.atRobotCnt;
        }

        public ReportCustomerStatisticsResponseBodyRecords setBizId(String bizId) {
            this.bizId = bizId;
            return this;
        }
        public String getBizId() {
            return this.bizId;
        }

        public ReportCustomerStatisticsResponseBodyRecords setCustomerCnt(Long customerCnt) {
            this.customerCnt = customerCnt;
            return this;
        }
        public Long getCustomerCnt() {
            return this.customerCnt;
        }

        public ReportCustomerStatisticsResponseBodyRecords setGroupName(String groupName) {
            this.groupName = groupName;
            return this;
        }
        public String getGroupName() {
            return this.groupName;
        }

        public ReportCustomerStatisticsResponseBodyRecords setGroupSetName(String groupSetName) {
            this.groupSetName = groupSetName;
            return this;
        }
        public String getGroupSetName() {
            return this.groupSetName;
        }

        public ReportCustomerStatisticsResponseBodyRecords setLoginCnt(Long loginCnt) {
            this.loginCnt = loginCnt;
            return this;
        }
        public Long getLoginCnt() {
            return this.loginCnt;
        }

        public ReportCustomerStatisticsResponseBodyRecords setOpenConvCnt(Long openConvCnt) {
            this.openConvCnt = openConvCnt;
            return this;
        }
        public Long getOpenConvCnt() {
            return this.openConvCnt;
        }

        public ReportCustomerStatisticsResponseBodyRecords setOpenConversationId(String openConversationId) {
            this.openConversationId = openConversationId;
            return this;
        }
        public String getOpenConversationId() {
            return this.openConversationId;
        }

        public ReportCustomerStatisticsResponseBodyRecords setOpenGroupSetId(String openGroupSetId) {
            this.openGroupSetId = openGroupSetId;
            return this;
        }
        public String getOpenGroupSetId() {
            return this.openGroupSetId;
        }

        public ReportCustomerStatisticsResponseBodyRecords setSendMsgCnt(Long sendMsgCnt) {
            this.sendMsgCnt = sendMsgCnt;
            return this;
        }
        public Long getSendMsgCnt() {
            return this.sendMsgCnt;
        }

        public ReportCustomerStatisticsResponseBodyRecords setSenderCnt(Long senderCnt) {
            this.senderCnt = senderCnt;
            return this;
        }
        public Long getSenderCnt() {
            return this.senderCnt;
        }

    }

}
