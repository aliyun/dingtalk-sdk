// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkservice_group_1_0.models;

import com.aliyun.tea.*;

public class ListTicketOperateRecordResponseBody extends TeaModel {
    // Id of the request
    @NameInMap("records")
    public java.util.List<ListTicketOperateRecordResponseBodyRecords> records;

    public static ListTicketOperateRecordResponseBody build(java.util.Map<String, ?> map) throws Exception {
        ListTicketOperateRecordResponseBody self = new ListTicketOperateRecordResponseBody();
        return TeaModel.build(map, self);
    }

    public ListTicketOperateRecordResponseBody setRecords(java.util.List<ListTicketOperateRecordResponseBodyRecords> records) {
        this.records = records;
        return this;
    }
    public java.util.List<ListTicketOperateRecordResponseBodyRecords> getRecords() {
        return this.records;
    }

    public static class ListTicketOperateRecordResponseBodyRecordsOperator extends TeaModel {
        @NameInMap("unionId")
        public String unionId;

        @NameInMap("nickName")
        public String nickName;

        public static ListTicketOperateRecordResponseBodyRecordsOperator build(java.util.Map<String, ?> map) throws Exception {
            ListTicketOperateRecordResponseBodyRecordsOperator self = new ListTicketOperateRecordResponseBodyRecordsOperator();
            return TeaModel.build(map, self);
        }

        public ListTicketOperateRecordResponseBodyRecordsOperator setUnionId(String unionId) {
            this.unionId = unionId;
            return this;
        }
        public String getUnionId() {
            return this.unionId;
        }

        public ListTicketOperateRecordResponseBodyRecordsOperator setNickName(String nickName) {
            this.nickName = nickName;
            return this;
        }
        public String getNickName() {
            return this.nickName;
        }

    }

    public static class ListTicketOperateRecordResponseBodyRecordsTicketMemoAttachments extends TeaModel {
        @NameInMap("fileName")
        public String fileName;

        @NameInMap("key")
        public String key;

        public static ListTicketOperateRecordResponseBodyRecordsTicketMemoAttachments build(java.util.Map<String, ?> map) throws Exception {
            ListTicketOperateRecordResponseBodyRecordsTicketMemoAttachments self = new ListTicketOperateRecordResponseBodyRecordsTicketMemoAttachments();
            return TeaModel.build(map, self);
        }

        public ListTicketOperateRecordResponseBodyRecordsTicketMemoAttachments setFileName(String fileName) {
            this.fileName = fileName;
            return this;
        }
        public String getFileName() {
            return this.fileName;
        }

        public ListTicketOperateRecordResponseBodyRecordsTicketMemoAttachments setKey(String key) {
            this.key = key;
            return this;
        }
        public String getKey() {
            return this.key;
        }

    }

    public static class ListTicketOperateRecordResponseBodyRecordsTicketMemo extends TeaModel {
        @NameInMap("memo")
        public String memo;

        @NameInMap("attachments")
        public java.util.List<ListTicketOperateRecordResponseBodyRecordsTicketMemoAttachments> attachments;

        public static ListTicketOperateRecordResponseBodyRecordsTicketMemo build(java.util.Map<String, ?> map) throws Exception {
            ListTicketOperateRecordResponseBodyRecordsTicketMemo self = new ListTicketOperateRecordResponseBodyRecordsTicketMemo();
            return TeaModel.build(map, self);
        }

        public ListTicketOperateRecordResponseBodyRecordsTicketMemo setMemo(String memo) {
            this.memo = memo;
            return this;
        }
        public String getMemo() {
            return this.memo;
        }

        public ListTicketOperateRecordResponseBodyRecordsTicketMemo setAttachments(java.util.List<ListTicketOperateRecordResponseBodyRecordsTicketMemoAttachments> attachments) {
            this.attachments = attachments;
            return this;
        }
        public java.util.List<ListTicketOperateRecordResponseBodyRecordsTicketMemoAttachments> getAttachments() {
            return this.attachments;
        }

    }

    public static class ListTicketOperateRecordResponseBodyRecords extends TeaModel {
        // 工单开放ID
        @NameInMap("openTicketId")
        public String openTicketId;

        // 操作时间
        @NameInMap("operateTime")
        public String operateTime;

        // 动作
        @NameInMap("operation")
        public String operation;

        // 动作展示名
        @NameInMap("operationDisplayName")
        public String operationDisplayName;

        @NameInMap("operator")
        public ListTicketOperateRecordResponseBodyRecordsOperator operator;

        @NameInMap("ticketMemo")
        public ListTicketOperateRecordResponseBodyRecordsTicketMemo ticketMemo;

        @NameInMap("operateData")
        public String operateData;

        public static ListTicketOperateRecordResponseBodyRecords build(java.util.Map<String, ?> map) throws Exception {
            ListTicketOperateRecordResponseBodyRecords self = new ListTicketOperateRecordResponseBodyRecords();
            return TeaModel.build(map, self);
        }

        public ListTicketOperateRecordResponseBodyRecords setOpenTicketId(String openTicketId) {
            this.openTicketId = openTicketId;
            return this;
        }
        public String getOpenTicketId() {
            return this.openTicketId;
        }

        public ListTicketOperateRecordResponseBodyRecords setOperateTime(String operateTime) {
            this.operateTime = operateTime;
            return this;
        }
        public String getOperateTime() {
            return this.operateTime;
        }

        public ListTicketOperateRecordResponseBodyRecords setOperation(String operation) {
            this.operation = operation;
            return this;
        }
        public String getOperation() {
            return this.operation;
        }

        public ListTicketOperateRecordResponseBodyRecords setOperationDisplayName(String operationDisplayName) {
            this.operationDisplayName = operationDisplayName;
            return this;
        }
        public String getOperationDisplayName() {
            return this.operationDisplayName;
        }

        public ListTicketOperateRecordResponseBodyRecords setOperator(ListTicketOperateRecordResponseBodyRecordsOperator operator) {
            this.operator = operator;
            return this;
        }
        public ListTicketOperateRecordResponseBodyRecordsOperator getOperator() {
            return this.operator;
        }

        public ListTicketOperateRecordResponseBodyRecords setTicketMemo(ListTicketOperateRecordResponseBodyRecordsTicketMemo ticketMemo) {
            this.ticketMemo = ticketMemo;
            return this;
        }
        public ListTicketOperateRecordResponseBodyRecordsTicketMemo getTicketMemo() {
            return this.ticketMemo;
        }

        public ListTicketOperateRecordResponseBodyRecords setOperateData(String operateData) {
            this.operateData = operateData;
            return this;
        }
        public String getOperateData() {
            return this.operateData;
        }

    }

}
