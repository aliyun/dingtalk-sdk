// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkservice_group_1_0.models;

import com.aliyun.tea.*;

public class ReportCustomerStatisticsResponseBody extends TeaModel {
    // 页码
    @NameInMap("currentPage")
    public Long currentPage;

    // 每页大小
    @NameInMap("pageSize")
    public Long pageSize;

    // 数据列表
    @NameInMap("records")
    public java.util.List<ReportCustomerStatisticsResponseBodyRecords> records;

    // 总数目
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
        // at机器人消息数
        @NameInMap("atRobotCnt")
        public Long atRobotCnt;

        // 业务ID
        @NameInMap("bizId")
        public String bizId;

        // 客户数
        @NameInMap("customerCnt")
        public Long customerCnt;

        // 群名称
        @NameInMap("groupName")
        public String groupName;

        // 群分组名称
        @NameInMap("groupSetName")
        public String groupSetName;

        // 打开钉钉客户数
        @NameInMap("loginCnt")
        public Long loginCnt;

        // 打开群客户数
        @NameInMap("openConvCnt")
        public Long openConvCnt;

        // 开放群ID
        @NameInMap("openConversationId")
        public String openConversationId;

        // 开放群分组ID
        @NameInMap("openGroupSetId")
        public String openGroupSetId;

        // 发送消息数
        @NameInMap("sendMsgCnt")
        public Long sendMsgCnt;

        // 发消息的客户数
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
