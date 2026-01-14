// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkim_1_0.models;

import com.aliyun.tea.*;

public class QueryMsgReadStatusResponseBody extends TeaModel {
    @NameInMap("result")
    public QueryMsgReadStatusResponseBodyResult result;

    @NameInMap("success")
    public String success;

    public static QueryMsgReadStatusResponseBody build(java.util.Map<String, ?> map) throws Exception {
        QueryMsgReadStatusResponseBody self = new QueryMsgReadStatusResponseBody();
        return TeaModel.build(map, self);
    }

    public QueryMsgReadStatusResponseBody setResult(QueryMsgReadStatusResponseBodyResult result) {
        this.result = result;
        return this;
    }
    public QueryMsgReadStatusResponseBodyResult getResult() {
        return this.result;
    }

    public QueryMsgReadStatusResponseBody setSuccess(String success) {
        this.success = success;
        return this;
    }
    public String getSuccess() {
        return this.success;
    }

    public static class QueryMsgReadStatusResponseBodyResult extends TeaModel {
        @NameInMap("hasMore")
        public Boolean hasMore;

        @NameInMap("nextCursor")
        public Long nextCursor;

        @NameInMap("openMessageId")
        public String openMessageId;

        @NameInMap("readUnionIds")
        public java.util.List<String> readUnionIds;

        @NameInMap("readUserIds")
        public java.util.List<String> readUserIds;

        @NameInMap("status")
        public String status;

        public static QueryMsgReadStatusResponseBodyResult build(java.util.Map<String, ?> map) throws Exception {
            QueryMsgReadStatusResponseBodyResult self = new QueryMsgReadStatusResponseBodyResult();
            return TeaModel.build(map, self);
        }

        public QueryMsgReadStatusResponseBodyResult setHasMore(Boolean hasMore) {
            this.hasMore = hasMore;
            return this;
        }
        public Boolean getHasMore() {
            return this.hasMore;
        }

        public QueryMsgReadStatusResponseBodyResult setNextCursor(Long nextCursor) {
            this.nextCursor = nextCursor;
            return this;
        }
        public Long getNextCursor() {
            return this.nextCursor;
        }

        public QueryMsgReadStatusResponseBodyResult setOpenMessageId(String openMessageId) {
            this.openMessageId = openMessageId;
            return this;
        }
        public String getOpenMessageId() {
            return this.openMessageId;
        }

        public QueryMsgReadStatusResponseBodyResult setReadUnionIds(java.util.List<String> readUnionIds) {
            this.readUnionIds = readUnionIds;
            return this;
        }
        public java.util.List<String> getReadUnionIds() {
            return this.readUnionIds;
        }

        public QueryMsgReadStatusResponseBodyResult setReadUserIds(java.util.List<String> readUserIds) {
            this.readUserIds = readUserIds;
            return this;
        }
        public java.util.List<String> getReadUserIds() {
            return this.readUserIds;
        }

        public QueryMsgReadStatusResponseBodyResult setStatus(String status) {
            this.status = status;
            return this;
        }
        public String getStatus() {
            return this.status;
        }

    }

}
