// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkservice_group_1_0.models;

import com.aliyun.tea.*;

public class TransferTicketRequest extends TeaModel {
    @NameInMap("notify")
    public TransferTicketRequestNotify notify;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("openTeamId")
    public String openTeamId;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("openTicketId")
    public String openTicketId;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("processorUnionId")
    public String processorUnionId;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("processorUnionIds")
    public java.util.List<String> processorUnionIds;

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
        @NameInMap("groupNoticeReceiverUnionIds")
        public java.util.List<String> groupNoticeReceiverUnionIds;

        @NameInMap("noticeAllGroupMember")
        public Boolean noticeAllGroupMember;

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
        @NameInMap("attachments")
        public java.util.List<TransferTicketRequestTicketMemoAttachments> attachments;

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
