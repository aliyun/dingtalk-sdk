// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkvip_member_1_0.models;

import com.aliyun.tea.*;

public class QueryRedeemVipMemberResponseBody extends TeaModel {
    @NameInMap("errorCode")
    public String errorCode;

    @NameInMap("errorMsg")
    public String errorMsg;

    @NameInMap("queryResults")
    public java.util.List<QueryRedeemVipMemberResponseBodyQueryResults> queryResults;

    @NameInMap("result")
    public Boolean result;

    public static QueryRedeemVipMemberResponseBody build(java.util.Map<String, ?> map) throws Exception {
        QueryRedeemVipMemberResponseBody self = new QueryRedeemVipMemberResponseBody();
        return TeaModel.build(map, self);
    }

    public QueryRedeemVipMemberResponseBody setErrorCode(String errorCode) {
        this.errorCode = errorCode;
        return this;
    }
    public String getErrorCode() {
        return this.errorCode;
    }

    public QueryRedeemVipMemberResponseBody setErrorMsg(String errorMsg) {
        this.errorMsg = errorMsg;
        return this;
    }
    public String getErrorMsg() {
        return this.errorMsg;
    }

    public QueryRedeemVipMemberResponseBody setQueryResults(java.util.List<QueryRedeemVipMemberResponseBodyQueryResults> queryResults) {
        this.queryResults = queryResults;
        return this;
    }
    public java.util.List<QueryRedeemVipMemberResponseBodyQueryResults> getQueryResults() {
        return this.queryResults;
    }

    public QueryRedeemVipMemberResponseBody setResult(Boolean result) {
        this.result = result;
        return this;
    }
    public Boolean getResult() {
        return this.result;
    }

    public static class QueryRedeemVipMemberResponseBodyQueryResults extends TeaModel {
        @NameInMap("action")
        public String action;

        @NameInMap("actionTime")
        public String actionTime;

        @NameInMap("dingtalkId")
        public String dingtalkId;

        @NameInMap("duration")
        public Long duration;

        @NameInMap("expireDate")
        public String expireDate;

        @NameInMap("nick")
        public String nick;

        public static QueryRedeemVipMemberResponseBodyQueryResults build(java.util.Map<String, ?> map) throws Exception {
            QueryRedeemVipMemberResponseBodyQueryResults self = new QueryRedeemVipMemberResponseBodyQueryResults();
            return TeaModel.build(map, self);
        }

        public QueryRedeemVipMemberResponseBodyQueryResults setAction(String action) {
            this.action = action;
            return this;
        }
        public String getAction() {
            return this.action;
        }

        public QueryRedeemVipMemberResponseBodyQueryResults setActionTime(String actionTime) {
            this.actionTime = actionTime;
            return this;
        }
        public String getActionTime() {
            return this.actionTime;
        }

        public QueryRedeemVipMemberResponseBodyQueryResults setDingtalkId(String dingtalkId) {
            this.dingtalkId = dingtalkId;
            return this;
        }
        public String getDingtalkId() {
            return this.dingtalkId;
        }

        public QueryRedeemVipMemberResponseBodyQueryResults setDuration(Long duration) {
            this.duration = duration;
            return this;
        }
        public Long getDuration() {
            return this.duration;
        }

        public QueryRedeemVipMemberResponseBodyQueryResults setExpireDate(String expireDate) {
            this.expireDate = expireDate;
            return this;
        }
        public String getExpireDate() {
            return this.expireDate;
        }

        public QueryRedeemVipMemberResponseBodyQueryResults setNick(String nick) {
            this.nick = nick;
            return this;
        }
        public String getNick() {
            return this.nick;
        }

    }

}
