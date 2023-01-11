// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkservice_group_1_0.models;

import com.aliyun.tea.*;

public class ReportCustomerDetailResponseBody extends TeaModel {
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
    public java.util.List<ReportCustomerDetailResponseBodyRecords> records;

    /**
     * <p>总数目</p>
     */
    @NameInMap("totalCount")
    public Long totalCount;

    public static ReportCustomerDetailResponseBody build(java.util.Map<String, ?> map) throws Exception {
        ReportCustomerDetailResponseBody self = new ReportCustomerDetailResponseBody();
        return TeaModel.build(map, self);
    }

    public ReportCustomerDetailResponseBody setCurrentPage(Long currentPage) {
        this.currentPage = currentPage;
        return this;
    }
    public Long getCurrentPage() {
        return this.currentPage;
    }

    public ReportCustomerDetailResponseBody setPageSize(Long pageSize) {
        this.pageSize = pageSize;
        return this;
    }
    public Long getPageSize() {
        return this.pageSize;
    }

    public ReportCustomerDetailResponseBody setRecords(java.util.List<ReportCustomerDetailResponseBodyRecords> records) {
        this.records = records;
        return this;
    }
    public java.util.List<ReportCustomerDetailResponseBodyRecords> getRecords() {
        return this.records;
    }

    public ReportCustomerDetailResponseBody setTotalCount(Long totalCount) {
        this.totalCount = totalCount;
        return this;
    }
    public Long getTotalCount() {
        return this.totalCount;
    }

    public static class ReportCustomerDetailResponseBodyRecords extends TeaModel {
        /**
         * <p>at机器人消息数</p>
         */
        @NameInMap("atRobotCnt")
        public Long atRobotCnt;

        /**
         * <p>客户名称</p>
         */
        @NameInMap("customerName")
        public String customerName;

        /**
         * <p>群名称</p>
         */
        @NameInMap("groupName")
        public String groupName;

        /**
         * <p>是否登录钉钉</p>
         */
        @NameInMap("hasLogin")
        public Boolean hasLogin;

        /**
         * <p>是否打开群</p>
         */
        @NameInMap("hasOpenConv")
        public Boolean hasOpenConv;

        /**
         * <p>发送消息数</p>
         */
        @NameInMap("sendMsgCnt")
        public Long sendMsgCnt;

        /**
         * <p>开放用户ID</p>
         */
        @NameInMap("unionId")
        public String unionId;

        /**
         * <p>用户ID</p>
         */
        @NameInMap("userId")
        public String userId;

        public static ReportCustomerDetailResponseBodyRecords build(java.util.Map<String, ?> map) throws Exception {
            ReportCustomerDetailResponseBodyRecords self = new ReportCustomerDetailResponseBodyRecords();
            return TeaModel.build(map, self);
        }

        public ReportCustomerDetailResponseBodyRecords setAtRobotCnt(Long atRobotCnt) {
            this.atRobotCnt = atRobotCnt;
            return this;
        }
        public Long getAtRobotCnt() {
            return this.atRobotCnt;
        }

        public ReportCustomerDetailResponseBodyRecords setCustomerName(String customerName) {
            this.customerName = customerName;
            return this;
        }
        public String getCustomerName() {
            return this.customerName;
        }

        public ReportCustomerDetailResponseBodyRecords setGroupName(String groupName) {
            this.groupName = groupName;
            return this;
        }
        public String getGroupName() {
            return this.groupName;
        }

        public ReportCustomerDetailResponseBodyRecords setHasLogin(Boolean hasLogin) {
            this.hasLogin = hasLogin;
            return this;
        }
        public Boolean getHasLogin() {
            return this.hasLogin;
        }

        public ReportCustomerDetailResponseBodyRecords setHasOpenConv(Boolean hasOpenConv) {
            this.hasOpenConv = hasOpenConv;
            return this;
        }
        public Boolean getHasOpenConv() {
            return this.hasOpenConv;
        }

        public ReportCustomerDetailResponseBodyRecords setSendMsgCnt(Long sendMsgCnt) {
            this.sendMsgCnt = sendMsgCnt;
            return this;
        }
        public Long getSendMsgCnt() {
            return this.sendMsgCnt;
        }

        public ReportCustomerDetailResponseBodyRecords setUnionId(String unionId) {
            this.unionId = unionId;
            return this;
        }
        public String getUnionId() {
            return this.unionId;
        }

        public ReportCustomerDetailResponseBodyRecords setUserId(String userId) {
            this.userId = userId;
            return this;
        }
        public String getUserId() {
            return this.userId;
        }

    }

}
