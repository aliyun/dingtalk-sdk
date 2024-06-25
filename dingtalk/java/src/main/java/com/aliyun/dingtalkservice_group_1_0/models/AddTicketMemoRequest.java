// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkservice_group_1_0.models;

import com.aliyun.tea.*;

public class AddTicketMemoRequest extends TeaModel {
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
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>Dq9hP8Sk2v6vQ6l05nCe5wiEiE</p>
     */
    @NameInMap("processorUnionId")
    public String processorUnionId;

    @NameInMap("ticketMemo")
    public AddTicketMemoRequestTicketMemo ticketMemo;

    public static AddTicketMemoRequest build(java.util.Map<String, ?> map) throws Exception {
        AddTicketMemoRequest self = new AddTicketMemoRequest();
        return TeaModel.build(map, self);
    }

    public AddTicketMemoRequest setOpenTeamId(String openTeamId) {
        this.openTeamId = openTeamId;
        return this;
    }
    public String getOpenTeamId() {
        return this.openTeamId;
    }

    public AddTicketMemoRequest setOpenTicketId(String openTicketId) {
        this.openTicketId = openTicketId;
        return this;
    }
    public String getOpenTicketId() {
        return this.openTicketId;
    }

    public AddTicketMemoRequest setProcessorUnionId(String processorUnionId) {
        this.processorUnionId = processorUnionId;
        return this;
    }
    public String getProcessorUnionId() {
        return this.processorUnionId;
    }

    public AddTicketMemoRequest setTicketMemo(AddTicketMemoRequestTicketMemo ticketMemo) {
        this.ticketMemo = ticketMemo;
        return this;
    }
    public AddTicketMemoRequestTicketMemo getTicketMemo() {
        return this.ticketMemo;
    }

    public static class AddTicketMemoRequestTicketMemoAttachments extends TeaModel {
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

        public static AddTicketMemoRequestTicketMemoAttachments build(java.util.Map<String, ?> map) throws Exception {
            AddTicketMemoRequestTicketMemoAttachments self = new AddTicketMemoRequestTicketMemoAttachments();
            return TeaModel.build(map, self);
        }

        public AddTicketMemoRequestTicketMemoAttachments setFileName(String fileName) {
            this.fileName = fileName;
            return this;
        }
        public String getFileName() {
            return this.fileName;
        }

        public AddTicketMemoRequestTicketMemoAttachments setKey(String key) {
            this.key = key;
            return this;
        }
        public String getKey() {
            return this.key;
        }

    }

    public static class AddTicketMemoRequestTicketMemo extends TeaModel {
        @NameInMap("attachments")
        public java.util.List<AddTicketMemoRequestTicketMemoAttachments> attachments;

        /**
         * <p>This parameter is required.</p>
         * 
         * <strong>example:</strong>
         * <p>备注</p>
         */
        @NameInMap("memo")
        public String memo;

        public static AddTicketMemoRequestTicketMemo build(java.util.Map<String, ?> map) throws Exception {
            AddTicketMemoRequestTicketMemo self = new AddTicketMemoRequestTicketMemo();
            return TeaModel.build(map, self);
        }

        public AddTicketMemoRequestTicketMemo setAttachments(java.util.List<AddTicketMemoRequestTicketMemoAttachments> attachments) {
            this.attachments = attachments;
            return this;
        }
        public java.util.List<AddTicketMemoRequestTicketMemoAttachments> getAttachments() {
            return this.attachments;
        }

        public AddTicketMemoRequestTicketMemo setMemo(String memo) {
            this.memo = memo;
            return this;
        }
        public String getMemo() {
            return this.memo;
        }

    }

}
