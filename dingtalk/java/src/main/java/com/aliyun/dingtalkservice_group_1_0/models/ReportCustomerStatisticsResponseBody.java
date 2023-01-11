// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkservice_group_1_0.models;

import com.aliyun.tea.*;

public class ReportCustomerStatisticsResponseBody extends TeaModel {
    /**
     * <p>页码</p>
     */
    @NameInMap("currentPage")
    public Long currentPage;

    /**
     * <p>每页大小</p>
     */
    @NameInMap("pageSize")
    public Long pageSize;

    /**
     * <p>数据列表</p>
     */
    @NameInMap("records")
    public java.util.List<ReportCustomerStatisticsResponseBodyRecords> records;

    /**
     * <p>总数目</p>
     */
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
        /**
         * <p>at机器人消息数</p>
         */
        @NameInMap("atRobotCnt")
        public Long atRobotCnt;

        /**
         * <p>业务ID</p>
         */
        @NameInMap("bizId")
        public String bizId;

        /**
         * <p>客户数</p>
         */
        @NameInMap("customerCnt")
        public Long customerCnt;

        /**
         * <p>群名称</p>
         */
        @NameInMap("groupName")
        public String groupName;

        /**
         * <p>群分组名称</p>
         */
        @NameInMap("groupSetName")
        public String groupSetName;

        /**
         * <p>打开钉钉客户数</p>
         */
        @NameInMap("loginCnt")
        public Long loginCnt;

        /**
         * <p>打开群客户数</p>
         */
        @NameInMap("openConvCnt")
        public Long openConvCnt;

        /**
         * <p>开放群ID</p>
         */
        @NameInMap("openConversationId")
        public String openConversationId;

        /**
         * <p>开放群分组ID</p>
         */
        @NameInMap("openGroupSetId")
        public String openGroupSetId;

        /**
         * <p>发送消息数</p>
         */
        @NameInMap("sendMsgCnt")
        public Long sendMsgCnt;

        /**
         * <p>发消息的客户数</p>
         */
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
