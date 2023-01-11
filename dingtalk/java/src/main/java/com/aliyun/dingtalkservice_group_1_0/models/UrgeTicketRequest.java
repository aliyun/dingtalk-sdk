// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkservice_group_1_0.models;

import com.aliyun.tea.*;

public class UrgeTicketRequest extends TeaModel {
    /**
     * <p>开放团队ID</p>
     */
    @NameInMap("openTeamId")
    public String openTeamId;

    /**
     * <p>工单开放id</p>
     */
    @NameInMap("openTicketId")
    public String openTicketId;

    /**
     * <p>工单催单操作人UnionId</p>
     */
    @NameInMap("operatorUnionId")
    public String operatorUnionId;

    /**
     * <p>备注</p>
     */
    @NameInMap("ticketMemo")
    public UrgeTicketRequestTicketMemo ticketMemo;

    public static UrgeTicketRequest build(java.util.Map<String, ?> map) throws Exception {
        UrgeTicketRequest self = new UrgeTicketRequest();
        return TeaModel.build(map, self);
    }

    public UrgeTicketRequest setOpenTeamId(String openTeamId) {
        this.openTeamId = openTeamId;
        return this;
    }
    public String getOpenTeamId() {
        return this.openTeamId;
    }

    public UrgeTicketRequest setOpenTicketId(String openTicketId) {
        this.openTicketId = openTicketId;
        return this;
    }
    public String getOpenTicketId() {
        return this.openTicketId;
    }

    public UrgeTicketRequest setOperatorUnionId(String operatorUnionId) {
        this.operatorUnionId = operatorUnionId;
        return this;
    }
    public String getOperatorUnionId() {
        return this.operatorUnionId;
    }

    public UrgeTicketRequest setTicketMemo(UrgeTicketRequestTicketMemo ticketMemo) {
        this.ticketMemo = ticketMemo;
        return this;
    }
    public UrgeTicketRequestTicketMemo getTicketMemo() {
        return this.ticketMemo;
    }

    public static class UrgeTicketRequestTicketMemoAttachments extends TeaModel {
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

        public static UrgeTicketRequestTicketMemoAttachments build(java.util.Map<String, ?> map) throws Exception {
            UrgeTicketRequestTicketMemoAttachments self = new UrgeTicketRequestTicketMemoAttachments();
            return TeaModel.build(map, self);
        }

        public UrgeTicketRequestTicketMemoAttachments setFileName(String fileName) {
            this.fileName = fileName;
            return this;
        }
        public String getFileName() {
            return this.fileName;
        }

        public UrgeTicketRequestTicketMemoAttachments setKey(String key) {
            this.key = key;
            return this;
        }
        public String getKey() {
            return this.key;
        }

    }

    public static class UrgeTicketRequestTicketMemo extends TeaModel {
        /**
         * <p>备注相关的附件</p>
         */
        @NameInMap("attachments")
        public java.util.List<UrgeTicketRequestTicketMemoAttachments> attachments;

        /**
         * <p>备注文字</p>
         */
        @NameInMap("memo")
        public String memo;

        public static UrgeTicketRequestTicketMemo build(java.util.Map<String, ?> map) throws Exception {
            UrgeTicketRequestTicketMemo self = new UrgeTicketRequestTicketMemo();
            return TeaModel.build(map, self);
        }

        public UrgeTicketRequestTicketMemo setAttachments(java.util.List<UrgeTicketRequestTicketMemoAttachments> attachments) {
            this.attachments = attachments;
            return this;
        }
        public java.util.List<UrgeTicketRequestTicketMemoAttachments> getAttachments() {
            return this.attachments;
        }

        public UrgeTicketRequestTicketMemo setMemo(String memo) {
            this.memo = memo;
            return this;
        }
        public String getMemo() {
            return this.memo;
        }

    }

}
