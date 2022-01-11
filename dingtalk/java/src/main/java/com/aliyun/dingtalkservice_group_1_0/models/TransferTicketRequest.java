// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkservice_group_1_0.models;

import com.aliyun.tea.*;

public class TransferTicketRequest extends TeaModel {
    @NameInMap("notify")
    public TransferTicketRequestNotify notify;

    // 开放团队ID
    @NameInMap("openTeamId")
    public String openTeamId;

    // 工单开放ID
    @NameInMap("openTicketId")
    public String openTicketId;

    // 工单处理人
    @NameInMap("processorUnionId")
    public String processorUnionId;

    // 被转单人UnionId列表
    @NameInMap("processorUnionIds")
    public java.util.List<String> processorUnionIds;

    // 工单备注
    @NameInMap("ticketMemo")
    public TransferTicketRequestTicketMemo ticketMemo;

    public static TransferTicketRequest build(java.util.Map<String, ?> map) throws Exception {
        TransferTicketRequest self = new TransferTicketRequest();
        return TeaModel.build(map, self);
    }

    public TransferTicketRequest setNotify(TransferTicketRequestNotify notify) {
        this.notify = notify;
        return this;
    }
    public TransferTicketRequestNotify getNotify() {
        return this.notify;
    }

    public TransferTicketRequest setOpenTeamId(String openTeamId) {
        this.openTeamId = openTeamId;
        return this;
    }
    public String getOpenTeamId() {
        return this.openTeamId;
    }

    public TransferTicketRequest setOpenTicketId(String openTicketId) {
        this.openTicketId = openTicketId;
        return this;
    }
    public String getOpenTicketId() {
        return this.openTicketId;
    }

    public TransferTicketRequest setProcessorUnionId(String processorUnionId) {
        this.processorUnionId = processorUnionId;
        return this;
    }
    public String getProcessorUnionId() {
        return this.processorUnionId;
    }

    public TransferTicketRequest setProcessorUnionIds(java.util.List<String> processorUnionIds) {
        this.processorUnionIds = processorUnionIds;
        return this;
    }
    public java.util.List<String> getProcessorUnionIds() {
        return this.processorUnionIds;
    }

    public TransferTicketRequest setTicketMemo(TransferTicketRequestTicketMemo ticketMemo) {
        this.ticketMemo = ticketMemo;
        return this;
    }
    public TransferTicketRequestTicketMemo getTicketMemo() {
        return this.ticketMemo;
    }

    public static class TransferTicketRequestNotify extends TeaModel {
        // 群中通知接收人（钉钉UnionId）
        @NameInMap("groupNoticeReceiverUnionIds")
        public java.util.List<String> groupNoticeReceiverUnionIds;

        // 是否向群内推送一个全员可见工单通知卡片
        @NameInMap("noticeAllGroupMember")
        public Boolean noticeAllGroupMember;

        // 企业工作通知接收人（钉钉UnionId）
        @NameInMap("workNoticeReceiverUnionIds")
        public java.util.List<String> workNoticeReceiverUnionIds;

        public static TransferTicketRequestNotify build(java.util.Map<String, ?> map) throws Exception {
            TransferTicketRequestNotify self = new TransferTicketRequestNotify();
            return TeaModel.build(map, self);
        }

        public TransferTicketRequestNotify setGroupNoticeReceiverUnionIds(java.util.List<String> groupNoticeReceiverUnionIds) {
            this.groupNoticeReceiverUnionIds = groupNoticeReceiverUnionIds;
            return this;
        }
        public java.util.List<String> getGroupNoticeReceiverUnionIds() {
            return this.groupNoticeReceiverUnionIds;
        }

        public TransferTicketRequestNotify setNoticeAllGroupMember(Boolean noticeAllGroupMember) {
            this.noticeAllGroupMember = noticeAllGroupMember;
            return this;
        }
        public Boolean getNoticeAllGroupMember() {
            return this.noticeAllGroupMember;
        }

        public TransferTicketRequestNotify setWorkNoticeReceiverUnionIds(java.util.List<String> workNoticeReceiverUnionIds) {
            this.workNoticeReceiverUnionIds = workNoticeReceiverUnionIds;
            return this;
        }
        public java.util.List<String> getWorkNoticeReceiverUnionIds() {
            return this.workNoticeReceiverUnionIds;
        }

    }

    public static class TransferTicketRequestTicketMemoAttachments extends TeaModel {
        @NameInMap("fileName")
        public String fileName;

        @NameInMap("key")
        public String key;

        public static TransferTicketRequestTicketMemoAttachments build(java.util.Map<String, ?> map) throws Exception {
            TransferTicketRequestTicketMemoAttachments self = new TransferTicketRequestTicketMemoAttachments();
            return TeaModel.build(map, self);
        }

        public TransferTicketRequestTicketMemoAttachments setFileName(String fileName) {
            this.fileName = fileName;
            return this;
        }
        public String getFileName() {
            return this.fileName;
        }

        public TransferTicketRequestTicketMemoAttachments setKey(String key) {
            this.key = key;
            return this;
        }
        public String getKey() {
            return this.key;
        }

    }

    public static class TransferTicketRequestTicketMemo extends TeaModel {
        // 备注相关的附件
        @NameInMap("attachments")
        public java.util.List<TransferTicketRequestTicketMemoAttachments> attachments;

        // 文字备注
        @NameInMap("memo")
        public String memo;

        public static TransferTicketRequestTicketMemo build(java.util.Map<String, ?> map) throws Exception {
            TransferTicketRequestTicketMemo self = new TransferTicketRequestTicketMemo();
            return TeaModel.build(map, self);
        }

        public TransferTicketRequestTicketMemo setAttachments(java.util.List<TransferTicketRequestTicketMemoAttachments> attachments) {
            this.attachments = attachments;
            return this;
        }
        public java.util.List<TransferTicketRequestTicketMemoAttachments> getAttachments() {
            return this.attachments;
        }

        public TransferTicketRequestTicketMemo setMemo(String memo) {
            this.memo = memo;
            return this;
        }
        public String getMemo() {
            return this.memo;
        }

    }

}
