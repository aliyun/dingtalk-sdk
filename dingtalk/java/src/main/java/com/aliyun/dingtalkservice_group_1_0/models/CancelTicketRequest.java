// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkservice_group_1_0.models;

import com.aliyun.tea.*;

public class CancelTicketRequest extends TeaModel {
    @NameInMap("dingIsvOrgId")
    public Long dingIsvOrgId;

    @NameInMap("dingOrgId")
    public Long dingOrgId;

    @NameInMap("dingSuiteKey")
    public String dingSuiteKey;

    @NameInMap("dingTokenGrantType")
    public Long dingTokenGrantType;

    // 开放团队ID
    @NameInMap("openTeamId")
    public String openTeamId;

    // 工单开放ID
    @NameInMap("openTicketId")
    public String openTicketId;

    // 操作人unionId
    @NameInMap("operatorUnionId")
    public String operatorUnionId;

    @NameInMap("ticketMemo")
    public CancelTicketRequestTicketMemo ticketMemo;

    @NameInMap("notify")
    public CancelTicketRequestNotify notify;

    public static CancelTicketRequest build(java.util.Map<String, ?> map) throws Exception {
        CancelTicketRequest self = new CancelTicketRequest();
        return TeaModel.build(map, self);
    }

    public CancelTicketRequest setDingIsvOrgId(Long dingIsvOrgId) {
        this.dingIsvOrgId = dingIsvOrgId;
        return this;
    }
    public Long getDingIsvOrgId() {
        return this.dingIsvOrgId;
    }

    public CancelTicketRequest setDingOrgId(Long dingOrgId) {
        this.dingOrgId = dingOrgId;
        return this;
    }
    public Long getDingOrgId() {
        return this.dingOrgId;
    }

    public CancelTicketRequest setDingSuiteKey(String dingSuiteKey) {
        this.dingSuiteKey = dingSuiteKey;
        return this;
    }
    public String getDingSuiteKey() {
        return this.dingSuiteKey;
    }

    public CancelTicketRequest setDingTokenGrantType(Long dingTokenGrantType) {
        this.dingTokenGrantType = dingTokenGrantType;
        return this;
    }
    public Long getDingTokenGrantType() {
        return this.dingTokenGrantType;
    }

    public CancelTicketRequest setOpenTeamId(String openTeamId) {
        this.openTeamId = openTeamId;
        return this;
    }
    public String getOpenTeamId() {
        return this.openTeamId;
    }

    public CancelTicketRequest setOpenTicketId(String openTicketId) {
        this.openTicketId = openTicketId;
        return this;
    }
    public String getOpenTicketId() {
        return this.openTicketId;
    }

    public CancelTicketRequest setOperatorUnionId(String operatorUnionId) {
        this.operatorUnionId = operatorUnionId;
        return this;
    }
    public String getOperatorUnionId() {
        return this.operatorUnionId;
    }

    public CancelTicketRequest setTicketMemo(CancelTicketRequestTicketMemo ticketMemo) {
        this.ticketMemo = ticketMemo;
        return this;
    }
    public CancelTicketRequestTicketMemo getTicketMemo() {
        return this.ticketMemo;
    }

    public CancelTicketRequest setNotify(CancelTicketRequestNotify notify) {
        this.notify = notify;
        return this;
    }
    public CancelTicketRequestNotify getNotify() {
        return this.notify;
    }

    public static class CancelTicketRequestTicketMemoAttachments extends TeaModel {
        // 文件名
        @NameInMap("fileName")
        public String fileName;

        // 文件key
        @NameInMap("key")
        public String key;

        public static CancelTicketRequestTicketMemoAttachments build(java.util.Map<String, ?> map) throws Exception {
            CancelTicketRequestTicketMemoAttachments self = new CancelTicketRequestTicketMemoAttachments();
            return TeaModel.build(map, self);
        }

        public CancelTicketRequestTicketMemoAttachments setFileName(String fileName) {
            this.fileName = fileName;
            return this;
        }
        public String getFileName() {
            return this.fileName;
        }

        public CancelTicketRequestTicketMemoAttachments setKey(String key) {
            this.key = key;
            return this;
        }
        public String getKey() {
            return this.key;
        }

    }

    public static class CancelTicketRequestTicketMemo extends TeaModel {
        // 备注
        @NameInMap("memo")
        public String memo;

        @NameInMap("attachments")
        public java.util.List<CancelTicketRequestTicketMemoAttachments> attachments;

        public static CancelTicketRequestTicketMemo build(java.util.Map<String, ?> map) throws Exception {
            CancelTicketRequestTicketMemo self = new CancelTicketRequestTicketMemo();
            return TeaModel.build(map, self);
        }

        public CancelTicketRequestTicketMemo setMemo(String memo) {
            this.memo = memo;
            return this;
        }
        public String getMemo() {
            return this.memo;
        }

        public CancelTicketRequestTicketMemo setAttachments(java.util.List<CancelTicketRequestTicketMemoAttachments> attachments) {
            this.attachments = attachments;
            return this;
        }
        public java.util.List<CancelTicketRequestTicketMemoAttachments> getAttachments() {
            return this.attachments;
        }

    }

    public static class CancelTicketRequestNotify extends TeaModel {
        @NameInMap("workNoticeReceiverUnionIds")
        public java.util.List<String> workNoticeReceiverUnionIds;

        @NameInMap("groupNoticeReceiverUnionIds")
        public java.util.List<String> groupNoticeReceiverUnionIds;

        // 是否向群内推送一个全员可见工单通知卡片
        @NameInMap("noticeAllGroupMember")
        public Boolean noticeAllGroupMember;

        public static CancelTicketRequestNotify build(java.util.Map<String, ?> map) throws Exception {
            CancelTicketRequestNotify self = new CancelTicketRequestNotify();
            return TeaModel.build(map, self);
        }

        public CancelTicketRequestNotify setWorkNoticeReceiverUnionIds(java.util.List<String> workNoticeReceiverUnionIds) {
            this.workNoticeReceiverUnionIds = workNoticeReceiverUnionIds;
            return this;
        }
        public java.util.List<String> getWorkNoticeReceiverUnionIds() {
            return this.workNoticeReceiverUnionIds;
        }

        public CancelTicketRequestNotify setGroupNoticeReceiverUnionIds(java.util.List<String> groupNoticeReceiverUnionIds) {
            this.groupNoticeReceiverUnionIds = groupNoticeReceiverUnionIds;
            return this;
        }
        public java.util.List<String> getGroupNoticeReceiverUnionIds() {
            return this.groupNoticeReceiverUnionIds;
        }

        public CancelTicketRequestNotify setNoticeAllGroupMember(Boolean noticeAllGroupMember) {
            this.noticeAllGroupMember = noticeAllGroupMember;
            return this;
        }
        public Boolean getNoticeAllGroupMember() {
            return this.noticeAllGroupMember;
        }

    }

}
