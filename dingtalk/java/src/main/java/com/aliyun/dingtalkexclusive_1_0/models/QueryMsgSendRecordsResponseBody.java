// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkexclusive_1_0.models;

import com.aliyun.tea.*;

public class QueryMsgSendRecordsResponseBody extends TeaModel {
    @NameInMap("errmsg")
    public String errmsg;

    @NameInMap("errorcode")
    public String errorcode;

    @NameInMap("result")
    public QueryMsgSendRecordsResponseBodyResult result;

    public static QueryMsgSendRecordsResponseBody build(java.util.Map<String, ?> map) throws Exception {
        QueryMsgSendRecordsResponseBody self = new QueryMsgSendRecordsResponseBody();
        return TeaModel.build(map, self);
    }

    public QueryMsgSendRecordsResponseBody setErrmsg(String errmsg) {
        this.errmsg = errmsg;
        return this;
    }
    public String getErrmsg() {
        return this.errmsg;
    }

    public QueryMsgSendRecordsResponseBody setErrorcode(String errorcode) {
        this.errorcode = errorcode;
        return this;
    }
    public String getErrorcode() {
        return this.errorcode;
    }

    public QueryMsgSendRecordsResponseBody setResult(QueryMsgSendRecordsResponseBodyResult result) {
        this.result = result;
        return this;
    }
    public QueryMsgSendRecordsResponseBodyResult getResult() {
        return this.result;
    }

    public static class QueryMsgSendRecordsResponseBodyResultItems extends TeaModel {
        /**
         * <p>This parameter is required.</p>
         * 
         * <strong>example:</strong>
         * <p>1766028831000</p>
         */
        @NameInMap("create_time")
        public Long createTime;

        /**
         * <p>This parameter is required.</p>
         * 
         * <strong>example:</strong>
         * <p>text</p>
         */
        @NameInMap("msg_type")
        public String msgType;

        /**
         * <strong>example:</strong>
         * <p>2569131246</p>
         */
        @NameInMap("operator_user_id")
        public String operatorUserId;

        /**
         * <p>This parameter is required.</p>
         * 
         * <strong>example:</strong>
         * <p>1766028831000</p>
         */
        @NameInMap("send_time")
        public Long sendTime;

        /**
         * <p>This parameter is required.</p>
         * 
         * <strong>example:</strong>
         * <p>pushkxQ2b2DTDAb0qkTjNdKLmwiEiE</p>
         */
        @NameInMap("task_id")
        public String taskId;

        /**
         * <strong>example:</strong>
         * <p>文本消息</p>
         */
        @NameInMap("title")
        public String title;

        public static QueryMsgSendRecordsResponseBodyResultItems build(java.util.Map<String, ?> map) throws Exception {
            QueryMsgSendRecordsResponseBodyResultItems self = new QueryMsgSendRecordsResponseBodyResultItems();
            return TeaModel.build(map, self);
        }

        public QueryMsgSendRecordsResponseBodyResultItems setCreateTime(Long createTime) {
            this.createTime = createTime;
            return this;
        }
        public Long getCreateTime() {
            return this.createTime;
        }

        public QueryMsgSendRecordsResponseBodyResultItems setMsgType(String msgType) {
            this.msgType = msgType;
            return this;
        }
        public String getMsgType() {
            return this.msgType;
        }

        public QueryMsgSendRecordsResponseBodyResultItems setOperatorUserId(String operatorUserId) {
            this.operatorUserId = operatorUserId;
            return this;
        }
        public String getOperatorUserId() {
            return this.operatorUserId;
        }

        public QueryMsgSendRecordsResponseBodyResultItems setSendTime(Long sendTime) {
            this.sendTime = sendTime;
            return this;
        }
        public Long getSendTime() {
            return this.sendTime;
        }

        public QueryMsgSendRecordsResponseBodyResultItems setTaskId(String taskId) {
            this.taskId = taskId;
            return this;
        }
        public String getTaskId() {
            return this.taskId;
        }

        public QueryMsgSendRecordsResponseBodyResultItems setTitle(String title) {
            this.title = title;
            return this;
        }
        public String getTitle() {
            return this.title;
        }

    }

    public static class QueryMsgSendRecordsResponseBodyResult extends TeaModel {
        @NameInMap("item_count")
        public Integer itemCount;

        @NameInMap("items")
        public java.util.List<QueryMsgSendRecordsResponseBodyResultItems> items;

        @NameInMap("total_count")
        public Integer totalCount;

        public static QueryMsgSendRecordsResponseBodyResult build(java.util.Map<String, ?> map) throws Exception {
            QueryMsgSendRecordsResponseBodyResult self = new QueryMsgSendRecordsResponseBodyResult();
            return TeaModel.build(map, self);
        }

        public QueryMsgSendRecordsResponseBodyResult setItemCount(Integer itemCount) {
            this.itemCount = itemCount;
            return this;
        }
        public Integer getItemCount() {
            return this.itemCount;
        }

        public QueryMsgSendRecordsResponseBodyResult setItems(java.util.List<QueryMsgSendRecordsResponseBodyResultItems> items) {
            this.items = items;
            return this;
        }
        public java.util.List<QueryMsgSendRecordsResponseBodyResultItems> getItems() {
            return this.items;
        }

        public QueryMsgSendRecordsResponseBodyResult setTotalCount(Integer totalCount) {
            this.totalCount = totalCount;
            return this;
        }
        public Integer getTotalCount() {
            return this.totalCount;
        }

    }

}
