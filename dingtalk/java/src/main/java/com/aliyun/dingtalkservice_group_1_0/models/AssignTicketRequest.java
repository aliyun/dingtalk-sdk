// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkservice_group_1_0.models;

import com.aliyun.tea.*;

public class AssignTicketRequest extends TeaModel {
    @NameInMap("notify")
    public AssignTicketRequestNotify notify;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>eKWh3GBwsKEiE</p>
     */
    @NameInMap("openTeamId")
    public String openTeamId;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>hNiPO2OVktNMiE</p>
     */
    @NameInMap("openTicketId")
    public String openTicketId;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("operatorUnionId")
    public String operatorUnionId;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("processorUnionIds")
    public java.util.List<String> processorUnionIds;

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
         * <strong>example:</strong>
         * <p>true</p>
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
         * <strong>example:</strong>
         * <p>ticket/image/44708069/43003/e27204b382c04832aec4243e940a1367_1625831640499.txt</p>
         */
        @NameInMap("fileName")
        public String fileName;

        /**
         * <strong>example:</strong>
         * <p>wahaha.txt</p>
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
        @NameInMap("attachments")
        public java.util.List<AssignTicketRequestTicketMemoAttachments> attachments;

        /**
         * <p>This parameter is required.</p>
         * 
         * <strong>example:</strong>
         * <p>备注</p>
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
