// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkservice_group_1_0.models;

import com.aliyun.tea.*;

public class ReportCustomerDetailResponseBody extends TeaModel {
    // 页码
    @NameInMap("currentPage")
    public Long currentPage;

    // 每页大小
    @NameInMap("pageSize")
    public Long pageSize;

    // 数据列表
    @NameInMap("records")
    public java.util.List<ReportCustomerDetailResponseBodyRecords> records;

    // 总数目
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
        // at机器人消息数
        @NameInMap("atRobotCnt")
        public Long atRobotCnt;

        // 客户名称
        @NameInMap("customerName")
        public String customerName;

        // 群名称
        @NameInMap("groupName")
        public String groupName;

        // 是否登录钉钉
        @NameInMap("hasLogin")
        public Boolean hasLogin;

        // 是否打开群
        @NameInMap("hasOpenConv")
        public Boolean hasOpenConv;

        // 发送消息数
        @NameInMap("sendMsgCnt")
        public Long sendMsgCnt;

        // 开放用户ID
        @NameInMap("unionId")
        public String unionId;

        // 用户ID
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
