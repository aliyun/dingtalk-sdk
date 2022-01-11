// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkservice_group_1_0.models;

import com.aliyun.tea.*;

public class FinishTicketRequest extends TeaModel {
    // 工单通知
    @NameInMap("notify")
    public FinishTicketRequestNotify notify;

    @NameInMap("openTeamId")
    public String openTeamId;

    // 工单开放id
    @NameInMap("openTicketId")
    public String openTicketId;

    // 当前工单处理人
    @NameInMap("processorUnionId")
    public String processorUnionId;

    // 备注
    @NameInMap("ticketMemo")
    public FinishTicketRequestTicketMemo ticketMemo;

    public static FinishTicketRequest build(java.util.Map<String, ?> map) throws Exception {
        FinishTicketRequest self = new FinishTicketRequest();
        return TeaModel.build(map, self);
    }

    public FinishTicketRequest setNotify(FinishTicketRequestNotify notify) {
        this.notify = notify;
        return this;
    }
    public FinishTicketRequestNotify getNotify() {
        return this.notify;
    }

    public FinishTicketRequest setOpenTeamId(String openTeamId) {
        this.openTeamId = openTeamId;
        return this;
    }
    public String getOpenTeamId() {
        return this.openTeamId;
    }

    public FinishTicketRequest setOpenTicketId(String openTicketId) {
        this.openTicketId = openTicketId;
        return this;
    }
    public String getOpenTicketId() {
        return this.openTicketId;
    }

    public FinishTicketRequest setProcessorUnionId(String processorUnionId) {
        this.processorUnionId = processorUnionId;
        return this;
    }
    public String getProcessorUnionId() {
        return this.processorUnionId;
    }

    public FinishTicketRequest setTicketMemo(FinishTicketRequestTicketMemo ticketMemo) {
        this.ticketMemo = ticketMemo;
        return this;
    }
    public FinishTicketRequestTicketMemo getTicketMemo() {
        return this.ticketMemo;
    }

    public static class FinishTicketRequestNotify extends TeaModel {
        // 群中通知接收人（钉钉UnionId）
        @NameInMap("groupNoticeReceiverUnionIds")
        public java.util.List<String> groupNoticeReceiverUnionIds;

        // 是否向群内推送一个全员可见工单通知卡片
        @NameInMap("noticeAllGroupMember")
        public Boolean noticeAllGroupMember;

        // 企业工作通知接收人（钉钉UnionId）
        @NameInMap("workNoticeReceiverUnionIds")
        public java.util.List<String> workNoticeReceiverUnionIds;

        public static FinishTicketRequestNotify build(java.util.Map<String, ?> map) throws Exception {
            FinishTicketRequestNotify self = new FinishTicketRequestNotify();
            return TeaModel.build(map, self);
        }

        public FinishTicketRequestNotify setGroupNoticeReceiverUnionIds(java.util.List<String> groupNoticeReceiverUnionIds) {
            this.groupNoticeReceiverUnionIds = groupNoticeReceiverUnionIds;
            return this;
        }
        public java.util.List<String> getGroupNoticeReceiverUnionIds() {
            return this.groupNoticeReceiverUnionIds;
        }

        public FinishTicketRequestNotify setNoticeAllGroupMember(Boolean noticeAllGroupMember) {
            this.noticeAllGroupMember = noticeAllGroupMember;
            return this;
        }
        public Boolean getNoticeAllGroupMember() {
            return this.noticeAllGroupMember;
        }

        public FinishTicketRequestNotify setWorkNoticeReceiverUnionIds(java.util.List<String> workNoticeReceiverUnionIds) {
            this.workNoticeReceiverUnionIds = workNoticeReceiverUnionIds;
            return this;
        }
        public java.util.List<String> getWorkNoticeReceiverUnionIds() {
            return this.workNoticeReceiverUnionIds;
        }

    }

    public static class FinishTicketRequestTicketMemoAttachments extends TeaModel {
        // 文件名
        @NameInMap("fileName")
        public String fileName;

        // 文件key
        @NameInMap("key")
        public String key;

        public static FinishTicketRequestTicketMemoAttachments build(java.util.Map<String, ?> map) throws Exception {
            FinishTicketRequestTicketMemoAttachments self = new FinishTicketRequestTicketMemoAttachments();
            return TeaModel.build(map, self);
        }

        public FinishTicketRequestTicketMemoAttachments setFileName(String fileName) {
            this.fileName = fileName;
            return this;
        }
        public String getFileName() {
            return this.fileName;
        }

        public FinishTicketRequestTicketMemoAttachments setKey(String key) {
            this.key = key;
            return this;
        }
        public String getKey() {
            return this.key;
        }

    }

    public static class FinishTicketRequestTicketMemo extends TeaModel {
        // 备注相关的附件
        @NameInMap("attachments")
        public java.util.List<FinishTicketRequestTicketMemoAttachments> attachments;

        // 备注文字
        @NameInMap("memo")
        public String memo;

        public static FinishTicketRequestTicketMemo build(java.util.Map<String, ?> map) throws Exception {
            FinishTicketRequestTicketMemo self = new FinishTicketRequestTicketMemo();
            return TeaModel.build(map, self);
        }

        public FinishTicketRequestTicketMemo setAttachments(java.util.List<FinishTicketRequestTicketMemoAttachments> attachments) {
            this.attachments = attachments;
            return this;
        }
        public java.util.List<FinishTicketRequestTicketMemoAttachments> getAttachments() {
            return this.attachments;
        }

        public FinishTicketRequestTicketMemo setMemo(String memo) {
            this.memo = memo;
            return this;
        }
        public String getMemo() {
            return this.memo;
        }

    }

}
