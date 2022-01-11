// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkservice_group_1_0.models;

import com.aliyun.tea.*;

public class UpdateTicketRequest extends TeaModel {
    // 自定义字段值JSON格式
    @NameInMap("customFields")
    public String customFields;

    // 团队ID
    @NameInMap("openTeamId")
    public String openTeamId;

    // 工单开放id
    @NameInMap("openTicketId")
    public String openTicketId;

    // 工单处理人unionId
    @NameInMap("processorUnionId")
    public String processorUnionId;

    // 备注
    @NameInMap("ticketMemo")
    public UpdateTicketRequestTicketMemo ticketMemo;

    public static UpdateTicketRequest build(java.util.Map<String, ?> map) throws Exception {
        UpdateTicketRequest self = new UpdateTicketRequest();
        return TeaModel.build(map, self);
    }

    public UpdateTicketRequest setCustomFields(String customFields) {
        this.customFields = customFields;
        return this;
    }
    public String getCustomFields() {
        return this.customFields;
    }

    public UpdateTicketRequest setOpenTeamId(String openTeamId) {
        this.openTeamId = openTeamId;
        return this;
    }
    public String getOpenTeamId() {
        return this.openTeamId;
    }

    public UpdateTicketRequest setOpenTicketId(String openTicketId) {
        this.openTicketId = openTicketId;
        return this;
    }
    public String getOpenTicketId() {
        return this.openTicketId;
    }

    public UpdateTicketRequest setProcessorUnionId(String processorUnionId) {
        this.processorUnionId = processorUnionId;
        return this;
    }
    public String getProcessorUnionId() {
        return this.processorUnionId;
    }

    public UpdateTicketRequest setTicketMemo(UpdateTicketRequestTicketMemo ticketMemo) {
        this.ticketMemo = ticketMemo;
        return this;
    }
    public UpdateTicketRequestTicketMemo getTicketMemo() {
        return this.ticketMemo;
    }

    public static class UpdateTicketRequestTicketMemoAttachments extends TeaModel {
        // 文件名
        @NameInMap("fileName")
        public String fileName;

        // 文件key
        @NameInMap("key")
        public String key;

        public static UpdateTicketRequestTicketMemoAttachments build(java.util.Map<String, ?> map) throws Exception {
            UpdateTicketRequestTicketMemoAttachments self = new UpdateTicketRequestTicketMemoAttachments();
            return TeaModel.build(map, self);
        }

        public UpdateTicketRequestTicketMemoAttachments setFileName(String fileName) {
            this.fileName = fileName;
            return this;
        }
        public String getFileName() {
            return this.fileName;
        }

        public UpdateTicketRequestTicketMemoAttachments setKey(String key) {
            this.key = key;
            return this;
        }
        public String getKey() {
            return this.key;
        }

    }

    public static class UpdateTicketRequestTicketMemo extends TeaModel {
        // 备注相关的附件
        @NameInMap("attachments")
        public java.util.List<UpdateTicketRequestTicketMemoAttachments> attachments;

        // 备注文字
        @NameInMap("memo")
        public String memo;

        public static UpdateTicketRequestTicketMemo build(java.util.Map<String, ?> map) throws Exception {
            UpdateTicketRequestTicketMemo self = new UpdateTicketRequestTicketMemo();
            return TeaModel.build(map, self);
        }

        public UpdateTicketRequestTicketMemo setAttachments(java.util.List<UpdateTicketRequestTicketMemoAttachments> attachments) {
            this.attachments = attachments;
            return this;
        }
        public java.util.List<UpdateTicketRequestTicketMemoAttachments> getAttachments() {
            return this.attachments;
        }

        public UpdateTicketRequestTicketMemo setMemo(String memo) {
            this.memo = memo;
            return this;
        }
        public String getMemo() {
            return this.memo;
        }

    }

}
