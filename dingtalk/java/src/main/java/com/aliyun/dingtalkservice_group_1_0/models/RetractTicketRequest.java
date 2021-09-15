// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkservice_group_1_0.models;

import com.aliyun.tea.*;

public class RetractTicketRequest extends TeaModel {
    @NameInMap("dingIsvOrgId")
    public Long dingIsvOrgId;

    @NameInMap("dingOrgId")
    public Long dingOrgId;

    @NameInMap("dingTokenGrantType")
    public Long dingTokenGrantType;

    @NameInMap("dingSuiteKey")
    public String dingSuiteKey;

    @NameInMap("openTeamId")
    public String openTeamId;

    // 工单开放ID
    @NameInMap("openTicketId")
    public String openTicketId;

    // 操作人ID
    @NameInMap("operatorUnionId")
    public String operatorUnionId;

    @NameInMap("ticketMemo")
    public RetractTicketRequestTicketMemo ticketMemo;

    @NameInMap("notify")
    public RetractTicketRequestNotify notify;

    public static RetractTicketRequest build(java.util.Map<String, ?> map) throws Exception {
        RetractTicketRequest self = new RetractTicketRequest();
        return TeaModel.build(map, self);
    }

    public RetractTicketRequest setDingIsvOrgId(Long dingIsvOrgId) {
        this.dingIsvOrgId = dingIsvOrgId;
        return this;
    }
    public Long getDingIsvOrgId() {
        return this.dingIsvOrgId;
    }

    public RetractTicketRequest setDingOrgId(Long dingOrgId) {
        this.dingOrgId = dingOrgId;
        return this;
    }
    public Long getDingOrgId() {
        return this.dingOrgId;
    }

    public RetractTicketRequest setDingTokenGrantType(Long dingTokenGrantType) {
        this.dingTokenGrantType = dingTokenGrantType;
        return this;
    }
    public Long getDingTokenGrantType() {
        return this.dingTokenGrantType;
    }

    public RetractTicketRequest setDingSuiteKey(String dingSuiteKey) {
        this.dingSuiteKey = dingSuiteKey;
        return this;
    }
    public String getDingSuiteKey() {
        return this.dingSuiteKey;
    }

    public RetractTicketRequest setOpenTeamId(String openTeamId) {
        this.openTeamId = openTeamId;
        return this;
    }
    public String getOpenTeamId() {
        return this.openTeamId;
    }

    public RetractTicketRequest setOpenTicketId(String openTicketId) {
        this.openTicketId = openTicketId;
        return this;
    }
    public String getOpenTicketId() {
        return this.openTicketId;
    }

    public RetractTicketRequest setOperatorUnionId(String operatorUnionId) {
        this.operatorUnionId = operatorUnionId;
        return this;
    }
    public String getOperatorUnionId() {
        return this.operatorUnionId;
    }

    public RetractTicketRequest setTicketMemo(RetractTicketRequestTicketMemo ticketMemo) {
        this.ticketMemo = ticketMemo;
        return this;
    }
    public RetractTicketRequestTicketMemo getTicketMemo() {
        return this.ticketMemo;
    }

    public RetractTicketRequest setNotify(RetractTicketRequestNotify notify) {
        this.notify = notify;
        return this;
    }
    public RetractTicketRequestNotify getNotify() {
        return this.notify;
    }

    public static class RetractTicketRequestTicketMemoAttachments extends TeaModel {
        @NameInMap("fileName")
        public String fileName;

        @NameInMap("key")
        public String key;

        public static RetractTicketRequestTicketMemoAttachments build(java.util.Map<String, ?> map) throws Exception {
            RetractTicketRequestTicketMemoAttachments self = new RetractTicketRequestTicketMemoAttachments();
            return TeaModel.build(map, self);
        }

        public RetractTicketRequestTicketMemoAttachments setFileName(String fileName) {
            this.fileName = fileName;
            return this;
        }
        public String getFileName() {
            return this.fileName;
        }

        public RetractTicketRequestTicketMemoAttachments setKey(String key) {
            this.key = key;
            return this;
        }
        public String getKey() {
            return this.key;
        }

    }

    public static class RetractTicketRequestTicketMemo extends TeaModel {
        @NameInMap("memo")
        public String memo;

        @NameInMap("attachments")
        public java.util.List<RetractTicketRequestTicketMemoAttachments> attachments;

        public static RetractTicketRequestTicketMemo build(java.util.Map<String, ?> map) throws Exception {
            RetractTicketRequestTicketMemo self = new RetractTicketRequestTicketMemo();
            return TeaModel.build(map, self);
        }

        public RetractTicketRequestTicketMemo setMemo(String memo) {
            this.memo = memo;
            return this;
        }
        public String getMemo() {
            return this.memo;
        }

        public RetractTicketRequestTicketMemo setAttachments(java.util.List<RetractTicketRequestTicketMemoAttachments> attachments) {
            this.attachments = attachments;
            return this;
        }
        public java.util.List<RetractTicketRequestTicketMemoAttachments> getAttachments() {
            return this.attachments;
        }

    }

    public static class RetractTicketRequestNotify extends TeaModel {
        @NameInMap("workNoticeReceiverUnionIds")
        public java.util.List<String> workNoticeReceiverUnionIds;

        @NameInMap("groupNoticeReceiverUnionIds")
        public java.util.List<String> groupNoticeReceiverUnionIds;

        // 是否向群内推送一个全员可见工单通知卡片
        @NameInMap("noticeAllGroupMember")
        public Boolean noticeAllGroupMember;

        public static RetractTicketRequestNotify build(java.util.Map<String, ?> map) throws Exception {
            RetractTicketRequestNotify self = new RetractTicketRequestNotify();
            return TeaModel.build(map, self);
        }

        public RetractTicketRequestNotify setWorkNoticeReceiverUnionIds(java.util.List<String> workNoticeReceiverUnionIds) {
            this.workNoticeReceiverUnionIds = workNoticeReceiverUnionIds;
            return this;
        }
        public java.util.List<String> getWorkNoticeReceiverUnionIds() {
            return this.workNoticeReceiverUnionIds;
        }

        public RetractTicketRequestNotify setGroupNoticeReceiverUnionIds(java.util.List<String> groupNoticeReceiverUnionIds) {
            this.groupNoticeReceiverUnionIds = groupNoticeReceiverUnionIds;
            return this;
        }
        public java.util.List<String> getGroupNoticeReceiverUnionIds() {
            return this.groupNoticeReceiverUnionIds;
        }

        public RetractTicketRequestNotify setNoticeAllGroupMember(Boolean noticeAllGroupMember) {
            this.noticeAllGroupMember = noticeAllGroupMember;
            return this;
        }
        public Boolean getNoticeAllGroupMember() {
            return this.noticeAllGroupMember;
        }

    }

}
