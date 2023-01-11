// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkservice_group_1_0.models;

import com.aliyun.tea.*;

public class AssignTicketRequest extends TeaModel {
    @NameInMap("notify")
    public AssignTicketRequestNotify notify;

    /**
     * <p>开放团队ID</p>
     */
    @NameInMap("openTeamId")
    public String openTeamId;

    /**
     * <p>工单开放ID</p>
     */
    @NameInMap("openTicketId")
    public String openTicketId;

    /**
     * <p>操作人unionId（管理员）</p>
     */
    @NameInMap("operatorUnionId")
    public String operatorUnionId;

    @NameInMap("processorUnionIds")
    public java.util.List<String> processorUnionIds;

    /**
     * <p>备注</p>
     */
    @NameInMap("ticketMemo")
    public AssignTicketRequestTicketMemo ticketMemo;

    public static AssignTicketRequest build(java.util.Map<String, ?> map) throws Exception {
        AssignTicketRequest self = new AssignTicketRequest();
        return TeaModel.build(map, self);
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

    public AssignTicketRequest setOpenTicketId(String openTicketId) {
        this.openTicketId = openTicketId;
        return this;
    }
    public String getOpenTicketId() {
        return this.openTicketId;
    }

    public AssignTicketRequest setOperatorUnionId(String operatorUnionId) {
        this.operatorUnionId = operatorUnionId;
        return this;
    }
    public String getOperatorUnionId() {
        return this.operatorUnionId;
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

    public static class AssignTicketRequestNotify extends TeaModel {
        @NameInMap("groupNoticeReceiverUnionIds")
        public java.util.List<String> groupNoticeReceiverUnionIds;

        /**
         * <p>是否向群内推送一个全员可见工单通知卡片</p>
         */
        @NameInMap("noticeAllGroupMember")
        public Boolean noticeAllGroupMember;

        @NameInMap("workNoticeReceiverUnionIds")
        public java.util.List<String> workNoticeReceiverUnionIds;

        public static AssignTicketRequestNotify build(java.util.Map<String, ?> map) throws Exception {
            AssignTicketRequestNotify self = new AssignTicketRequestNotify();
            return TeaModel.build(map, self);
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

        public AssignTicketRequestNotify setWorkNoticeReceiverUnionIds(java.util.List<String> workNoticeReceiverUnionIds) {
            this.workNoticeReceiverUnionIds = workNoticeReceiverUnionIds;
            return this;
        }
        public java.util.List<String> getWorkNoticeReceiverUnionIds() {
            return this.workNoticeReceiverUnionIds;
        }

    }

    public static class AssignTicketRequestTicketMemoAttachments extends TeaModel {
        /**
         * <p>文件名</p>
         */
        @NameInMap("fileName")
        public String fileName;

        /**
         * <p>文件key</p>
         */
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
        /**
         * <p>备注相关的附件</p>
         */
        @NameInMap("attachments")
        public java.util.List<AssignTicketRequestTicketMemoAttachments> attachments;

        /**
         * <p>备注文字</p>
         */
        @NameInMap("memo")
        public String memo;

        public static AssignTicketRequestTicketMemo build(java.util.Map<String, ?> map) throws Exception {
            AssignTicketRequestTicketMemo self = new AssignTicketRequestTicketMemo();
            return TeaModel.build(map, self);
        }

        public AssignTicketRequestTicketMemo setAttachments(java.util.List<AssignTicketRequestTicketMemoAttachments> attachments) {
            this.attachments = attachments;
            return this;
        }
        public java.util.List<AssignTicketRequestTicketMemoAttachments> getAttachments() {
            return this.attachments;
        }

        public AssignTicketRequestTicketMemo setMemo(String memo) {
            this.memo = memo;
            return this;
        }
        public String getMemo() {
            return this.memo;
        }

    }

}
