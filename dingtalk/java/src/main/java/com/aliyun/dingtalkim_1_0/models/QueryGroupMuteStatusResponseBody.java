// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkim_1_0.models;

import com.aliyun.tea.*;

public class QueryGroupMuteStatusResponseBody extends TeaModel {
    @NameInMap("groupMuteMode")
    public Boolean groupMuteMode;

    @NameInMap("userMuteResult")
    public QueryGroupMuteStatusResponseBodyUserMuteResult userMuteResult;

    public static QueryGroupMuteStatusResponseBody build(java.util.Map<String, ?> map) throws Exception {
        QueryGroupMuteStatusResponseBody self = new QueryGroupMuteStatusResponseBody();
        return TeaModel.build(map, self);
    }

    public QueryGroupMuteStatusResponseBody setGroupMuteMode(Boolean groupMuteMode) {
        this.groupMuteMode = groupMuteMode;
        return this;
    }
    public Boolean getGroupMuteMode() {
        return this.groupMuteMode;
    }

    public QueryGroupMuteStatusResponseBody setUserMuteResult(QueryGroupMuteStatusResponseBodyUserMuteResult userMuteResult) {
        this.userMuteResult = userMuteResult;
        return this;
    }
    public QueryGroupMuteStatusResponseBodyUserMuteResult getUserMuteResult() {
        return this.userMuteResult;
    }

    public static class QueryGroupMuteStatusResponseBodyUserMuteResult extends TeaModel {
        @NameInMap("muteEndTime")
        public Long muteEndTime;

        @NameInMap("muteStartTime")
        public Long muteStartTime;

        @NameInMap("userMuteMode")
        public Boolean userMuteMode;

        public static QueryGroupMuteStatusResponseBodyUserMuteResult build(java.util.Map<String, ?> map) throws Exception {
            QueryGroupMuteStatusResponseBodyUserMuteResult self = new QueryGroupMuteStatusResponseBodyUserMuteResult();
            return TeaModel.build(map, self);
        }

        public QueryGroupMuteStatusResponseBodyUserMuteResult setMuteEndTime(Long muteEndTime) {
            this.muteEndTime = muteEndTime;
            return this;
        }
        public Long getMuteEndTime() {
            return this.muteEndTime;
        }

        public QueryGroupMuteStatusResponseBodyUserMuteResult setMuteStartTime(Long muteStartTime) {
            this.muteStartTime = muteStartTime;
            return this;
        }
        public Long getMuteStartTime() {
            return this.muteStartTime;
        }

        public QueryGroupMuteStatusResponseBodyUserMuteResult setUserMuteMode(Boolean userMuteMode) {
            this.userMuteMode = userMuteMode;
            return this;
        }
        public Boolean getUserMuteMode() {
            return this.userMuteMode;
        }

    }

}
