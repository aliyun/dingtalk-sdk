// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkim_1_0.models;

import com.aliyun.tea.*;

public class QueryPersonalMessageReadStatusResponseBody extends TeaModel {
    @NameInMap("result")
    public QueryPersonalMessageReadStatusResponseBodyResult result;

    @NameInMap("success")
    public Boolean success;

    public static QueryPersonalMessageReadStatusResponseBody build(java.util.Map<String, ?> map) throws Exception {
        QueryPersonalMessageReadStatusResponseBody self = new QueryPersonalMessageReadStatusResponseBody();
        return TeaModel.build(map, self);
    }

    public QueryPersonalMessageReadStatusResponseBody setResult(QueryPersonalMessageReadStatusResponseBodyResult result) {
        this.result = result;
        return this;
    }
    public QueryPersonalMessageReadStatusResponseBodyResult getResult() {
        return this.result;
    }

    public QueryPersonalMessageReadStatusResponseBody setSuccess(Boolean success) {
        this.success = success;
        return this;
    }
    public Boolean getSuccess() {
        return this.success;
    }

    public static class QueryPersonalMessageReadStatusResponseBodyResultMessageReadInfoList extends TeaModel {
        @NameInMap("readStatus")
        public String readStatus;

        @NameInMap("userId")
        public String userId;

        public static QueryPersonalMessageReadStatusResponseBodyResultMessageReadInfoList build(java.util.Map<String, ?> map) throws Exception {
            QueryPersonalMessageReadStatusResponseBodyResultMessageReadInfoList self = new QueryPersonalMessageReadStatusResponseBodyResultMessageReadInfoList();
            return TeaModel.build(map, self);
        }

        public QueryPersonalMessageReadStatusResponseBodyResultMessageReadInfoList setReadStatus(String readStatus) {
            this.readStatus = readStatus;
            return this;
        }
        public String getReadStatus() {
            return this.readStatus;
        }

        public QueryPersonalMessageReadStatusResponseBodyResultMessageReadInfoList setUserId(String userId) {
            this.userId = userId;
            return this;
        }
        public String getUserId() {
            return this.userId;
        }

    }

    public static class QueryPersonalMessageReadStatusResponseBodyResult extends TeaModel {
        @NameInMap("messageReadInfoList")
        public java.util.List<QueryPersonalMessageReadStatusResponseBodyResultMessageReadInfoList> messageReadInfoList;

        public static QueryPersonalMessageReadStatusResponseBodyResult build(java.util.Map<String, ?> map) throws Exception {
            QueryPersonalMessageReadStatusResponseBodyResult self = new QueryPersonalMessageReadStatusResponseBodyResult();
            return TeaModel.build(map, self);
        }

        public QueryPersonalMessageReadStatusResponseBodyResult setMessageReadInfoList(java.util.List<QueryPersonalMessageReadStatusResponseBodyResultMessageReadInfoList> messageReadInfoList) {
            this.messageReadInfoList = messageReadInfoList;
            return this;
        }
        public java.util.List<QueryPersonalMessageReadStatusResponseBodyResultMessageReadInfoList> getMessageReadInfoList() {
            return this.messageReadInfoList;
        }

    }

}
