// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkservice_group_1_0.models;

import com.aliyun.tea.*;

public class AssignTicketRequest extends TeaModel {
    @NameInMap("dingIsvOrgId")
    public Long dingIsvOrgId;

    @NameInMap("dingOrgId")
    public Long dingOrgId;

    @NameInMap("dingSuiteKey")
    public String dingSuiteKey;

    @NameInMap("dingTokenGrantType")
    public Long dingTokenGrantType;

    // 操作人unionId（管理员）
    @NameInMap("operatorUnionId")
    public String operatorUnionId;

    // 工单开放ID
    @NameInMap("openTicketId")
    public String openTicketId;

    @NameInMap("processorUnionIds")
    public java.util.List<String> processorUnionIds;

    // 备注
    @NameInMap("ticketMemo")
    public AssignTicketRequestTicketMemo ticketMemo;

    @NameInMap("notify")
    public AssignTicketRequestNotify notify;

    // 开放团队ID
    @NameInMap("openTeamId")
    public String openTeamId;

    public static AssignTicketRequest build(java.util.Map<String, ?> map) throws Exception {
        AssignTicketRequest self = new AssignTicketRequest();
        return TeaModel.build(map, self);
    }

    public AssignTicketRequest setDingIsvOrgId(Long dingIsvOrgId) {
        this.dingIsvOrgId = dingIsvOrgId;
        return this;
    }
    public Long getDingIsvOrgId() {
        return this.dingIsvOrgId;
    }

    public AssignTicketRequest setDingOrgId(Long dingOrgId) {
        this.dingOrgId = dingOrgId;
        return this;
    }
    public Long getDingOrgId() {
        return this.dingOrgId;
    }

    public AssignTicketRequest setDingSuiteKey(String dingSuiteKey) {
        this.dingSuiteKey = dingSuiteKey;
        return this;
    }
    public String getDingSuiteKey() {
        return this.dingSuiteKey;
    }

    public AssignTicketRequest setDingTokenGrantType(Long dingTokenGrantType) {
        this.dingTokenGrantType = dingTokenGrantType;
        return this;
    }
    public Long getDingTokenGrantType() {
        return this.dingTokenGrantType;
    }

    public AssignTicketRequest setOperatorUnionId(String operatorUnionId) {
        this.operatorUnionId = operatorUnionId;
        return this;
    }
    public String getOperatorUnionId() {
        return this.operatorUnionId;
    }

    public AssignTicketRequest setOpenTicketId(String openTicketId) {
        this.openTicketId = openTicketId;
        return this;
    }
    public String getOpenTicketId() {
        return this.openTicketId;
    }

    public AssignTicketRequest setProcessorUnionIds(java.util.List<String> processorUnionIds) {
        this.processorUnionIds = processorUnionIds;
        return this;
    }
    public java.util.List<String> getProcessorUnionIds() {
        return this.processorUnionIds;
    }

    public AssignTicketRequest setTicketMemo(AssignTicketRequestTicketMemo ticketMemo) {
        this.ticketMemo = ticketMemo;
        return this;
    }
    public AssignTicketRequestTicketMemo getTicketMemo() {
        return this.ticketMemo;
    }

    public AssignTicketRequest setNotify(AssignTicketRequestNotify notify) {
        this.notify = notify;
        return this;
    }
    public AssignTicketRequestNotify getNotify() {
        return this.notify;
    }

    public AssignTicketRequest setOpenTeamId(String openTeamId) {
        this.openTeamId = openTeamId;
        return this;
    }
    public String getOpenTeamId() {
        return this.openTeamId;
    }

    public static class AssignTicketRequestTicketMemoAttachments extends TeaModel {
        // 文件名
        @NameInMap("fileName")
        public String fileName;

        // 文件key
        @NameInMap("key")
        public String key;

        public static AssignTicketRequestTicketMemoAttachments build(java.util.Map<String, ?> map) throws Exception {
            AssignTicketRequestTicketMemoAttachments self = new AssignTicketRequestTicketMemoAttachments();
            return TeaModel.build(map, self);
        }

        public AssignTicketRequestTicketMemoAttachments setFileName(String fileName) {
            this.fileName = fileName;
            return this;
        }
        public String getFileName() {
            return this.fileName;
        }

        public AssignTicketRequestTicketMemoAttachments setKey(String key) {
            this.key = key;
            return this;
        }
        public String getKey() {
            return this.key;
        }

    }

    public static class AssignTicketRequestTicketMemo extends TeaModel {
        // 备注文字
        @NameInMap("memo")
        public String memo;

        // 备注相关的附件
        @NameInMap("attachments")
        public java.util.List<AssignTicketRequestTicketMemoAttachments> attachments;

        public static AssignTicketRequestTicketMemo build(java.util.Map<String, ?> map) throws Exception {
            AssignTicketRequestTicketMemo self = new AssignTicketRequestTicketMemo();
            return TeaModel.build(map, self);
        }

        public AssignTicketRequestTicketMemo setMemo(String memo) {
            this.memo = memo;
            return this;
        }
        public String getMemo() {
            return this.memo;
        }

        public AssignTicketRequestTicketMemo setAttachments(java.util.List<AssignTicketRequestTicketMemoAttachments> attachments) {
            this.attachments = attachments;
            return this;
        }
        public java.util.List<AssignTicketRequestTicketMemoAttachments> getAttachments() {
            return this.attachments;
        }

    }

    public static class AssignTicketRequestNotify extends TeaModel {
        @NameInMap("workNoticeReceiverUnionIds")
        public java.util.List<String> workNoticeReceiverUnionIds;

        @NameInMap("groupNoticeReceiverUnionIds")
        public java.util.List<String> groupNoticeReceiverUnionIds;

        // 是否向群内推送一个全员可见工单通知卡片
        @NameInMap("noticeAllGroupMember")
        public Boolean noticeAllGroupMember;

        public static AssignTicketRequestNotify build(java.util.Map<String, ?> map) throws Exception {
            AssignTicketRequestNotify self = new AssignTicketRequestNotify();
            return TeaModel.build(map, self);
        }

        public AssignTicketRequestNotify setWorkNoticeReceiverUnionIds(java.util.List<String> workNoticeReceiverUnionIds) {
            this.workNoticeReceiverUnionIds = workNoticeReceiverUnionIds;
            return this;
        }
        public java.util.List<String> getWorkNoticeReceiverUnionIds() {
            return this.workNoticeReceiverUnionIds;
        }

        public AssignTicketRequestNotify setGroupNoticeReceiverUnionIds(java.util.List<String> groupNoticeReceiverUnionIds) {
            this.groupNoticeReceiverUnionIds = groupNoticeReceiverUnionIds;
            return this;
        }
        public java.util.List<String> getGroupNoticeReceiverUnionIds() {
            return this.groupNoticeReceiverUnionIds;
        }

        public AssignTicketRequestNotify setNoticeAllGroupMember(Boolean noticeAllGroupMember) {
            this.noticeAllGroupMember = noticeAllGroupMember;
            return this;
        }
        public Boolean getNoticeAllGroupMember() {
            return this.noticeAllGroupMember;
        }

    }

}
