// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkservice_group_1_0.models;

import com.aliyun.tea.*;

public class CancelTicketRequest extends TeaModel {
    @NameInMap("notify")
    public CancelTicketRequestNotify notify;

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
     * <p>a8iS4X94TgtgiE</p>
     */
    @NameInMap("openTicketId")
    public String openTicketId;

    /**
     * <strong>example:</strong>
     * <p>Dq9hP8Sk2v6vQ6l05nCe5wiEiE</p>
     */
    @NameInMap("operatorUnionId")
    public String operatorUnionId;

    @NameInMap("ticketMemo")
    public CancelTicketRequestTicketMemo ticketMemo;

    public static CancelTicketRequest build(java.util.Map<String, ?> map) throws Exception {
        CancelTicketRequest self = new CancelTicketRequest();
        return TeaModel.build(map, self);
    }

    public CancelTicketRequest setNotify(CancelTicketRequestNotify notify) {
        this.notify = notify;
        return this;
    }
    public CancelTicketRequestNotify getNotify() {
        return this.notify;
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

    public static class CancelTicketRequestNotify extends TeaModel {
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

        public static CancelTicketRequestNotify build(java.util.Map<String, ?> map) throws Exception {
            CancelTicketRequestNotify self = new CancelTicketRequestNotify();
            return TeaModel.build(map, self);
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

        public CancelTicketRequestNotify setWorkNoticeReceiverUnionIds(java.util.List<String> workNoticeReceiverUnionIds) {
            this.workNoticeReceiverUnionIds = workNoticeReceiverUnionIds;
            return this;
        }
        public java.util.List<String> getWorkNoticeReceiverUnionIds() {
            return this.workNoticeReceiverUnionIds;
        }

    }

    public static class CancelTicketRequestTicketMemoAttachments extends TeaModel {
        /**
         * <strong>example:</strong>
         * <p>wahaha.txt</p>
         */
        @NameInMap("fileName")
        public String fileName;

        /**
         * <strong>example:</strong>
         * <p>ticket/image/44708069/43003/e27204b382c04832aec4243e940a1367_1625831640499.txt</p>
         */
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
        @NameInMap("attachments")
        public java.util.List<CancelTicketRequestTicketMemoAttachments> attachments;

        /**
         * <strong>example:</strong>
         * <p>备注</p>
         */
        @NameInMap("memo")
        public String memo;

        public static CancelTicketRequestTicketMemo build(java.util.Map<String, ?> map) throws Exception {
            CancelTicketRequestTicketMemo self = new CancelTicketRequestTicketMemo();
            return TeaModel.build(map, self);
        }

        public CancelTicketRequestTicketMemo setAttachments(java.util.List<CancelTicketRequestTicketMemoAttachments> attachments) {
            this.attachments = attachments;
            return this;
        }
        public java.util.List<CancelTicketRequestTicketMemoAttachments> getAttachments() {
            return this.attachments;
        }

        public CancelTicketRequestTicketMemo setMemo(String memo) {
            this.memo = memo;
            return this;
        }
        public String getMemo() {
            return this.memo;
        }

    }

}
