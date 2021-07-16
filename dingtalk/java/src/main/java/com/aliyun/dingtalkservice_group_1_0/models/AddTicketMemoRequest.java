// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkservice_group_1_0.models;

import com.aliyun.tea.*;

public class AddTicketMemoRequest extends TeaModel {
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

    // 当前工单处理人
    @NameInMap("processorUnionId")
    public String processorUnionId;

    // 工单开放ID
    @NameInMap("openTicketId")
    public String openTicketId;

    // 备注
    @NameInMap("ticketMemo")
    public AddTicketMemoRequestTicketMemo ticketMemo;

    public static AddTicketMemoRequest build(java.util.Map<String, ?> map) throws Exception {
        AddTicketMemoRequest self = new AddTicketMemoRequest();
        return TeaModel.build(map, self);
    }

    public AddTicketMemoRequest setDingIsvOrgId(Long dingIsvOrgId) {
        this.dingIsvOrgId = dingIsvOrgId;
        return this;
    }
    public Long getDingIsvOrgId() {
        return this.dingIsvOrgId;
    }

    public AddTicketMemoRequest setDingOrgId(Long dingOrgId) {
        this.dingOrgId = dingOrgId;
        return this;
    }
    public Long getDingOrgId() {
        return this.dingOrgId;
    }

    public AddTicketMemoRequest setDingSuiteKey(String dingSuiteKey) {
        this.dingSuiteKey = dingSuiteKey;
        return this;
    }
    public String getDingSuiteKey() {
        return this.dingSuiteKey;
    }

    public AddTicketMemoRequest setDingTokenGrantType(Long dingTokenGrantType) {
        this.dingTokenGrantType = dingTokenGrantType;
        return this;
    }
    public Long getDingTokenGrantType() {
        return this.dingTokenGrantType;
    }

    public AddTicketMemoRequest setOpenTeamId(String openTeamId) {
        this.openTeamId = openTeamId;
        return this;
    }
    public String getOpenTeamId() {
        return this.openTeamId;
    }

    public AddTicketMemoRequest setProcessorUnionId(String processorUnionId) {
        this.processorUnionId = processorUnionId;
        return this;
    }
    public String getProcessorUnionId() {
        return this.processorUnionId;
    }

    public AddTicketMemoRequest setOpenTicketId(String openTicketId) {
        this.openTicketId = openTicketId;
        return this;
    }
    public String getOpenTicketId() {
        return this.openTicketId;
    }

    public AddTicketMemoRequest setTicketMemo(AddTicketMemoRequestTicketMemo ticketMemo) {
        this.ticketMemo = ticketMemo;
        return this;
    }
    public AddTicketMemoRequestTicketMemo getTicketMemo() {
        return this.ticketMemo;
    }

    public static class AddTicketMemoRequestTicketMemoAttachments extends TeaModel {
        // 文件名
        @NameInMap("fileName")
        public String fileName;

        // 文件key
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
        // 文字备注
        @NameInMap("memo")
        public String memo;

        // 备注相关的附件
        @NameInMap("attachments")
        public java.util.List<AddTicketMemoRequestTicketMemoAttachments> attachments;

        public static AddTicketMemoRequestTicketMemo build(java.util.Map<String, ?> map) throws Exception {
            AddTicketMemoRequestTicketMemo self = new AddTicketMemoRequestTicketMemo();
            return TeaModel.build(map, self);
        }

        public AddTicketMemoRequestTicketMemo setMemo(String memo) {
            this.memo = memo;
            return this;
        }
        public String getMemo() {
            return this.memo;
        }

        public AddTicketMemoRequestTicketMemo setAttachments(java.util.List<AddTicketMemoRequestTicketMemoAttachments> attachments) {
            this.attachments = attachments;
            return this;
        }
        public java.util.List<AddTicketMemoRequestTicketMemoAttachments> getAttachments() {
            return this.attachments;
        }

    }

}
