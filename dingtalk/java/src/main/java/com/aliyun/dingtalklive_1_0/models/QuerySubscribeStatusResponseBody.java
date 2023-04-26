// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalklive_1_0.models;

import com.aliyun.tea.*;

public class QuerySubscribeStatusResponseBody extends TeaModel {
    @NameInMap("result")
    public QuerySubscribeStatusResponseBodyResult result;

    public static QuerySubscribeStatusResponseBody build(java.util.Map<String, ?> map) throws Exception {
        QuerySubscribeStatusResponseBody self = new QuerySubscribeStatusResponseBody();
        return TeaModel.build(map, self);
    }

    public QuerySubscribeStatusResponseBody setResult(QuerySubscribeStatusResponseBodyResult result) {
        this.result = result;
        return this;
    }
    public QuerySubscribeStatusResponseBodyResult getResult() {
        return this.result;
    }

    public static class QuerySubscribeStatusResponseBodyResultSubscribeStatusDTOS extends TeaModel {
        @NameInMap("liveId")
        public String liveId;

        @NameInMap("subscribe")
        public Boolean subscribe;

        public static QuerySubscribeStatusResponseBodyResultSubscribeStatusDTOS build(java.util.Map<String, ?> map) throws Exception {
            QuerySubscribeStatusResponseBodyResultSubscribeStatusDTOS self = new QuerySubscribeStatusResponseBodyResultSubscribeStatusDTOS();
            return TeaModel.build(map, self);
        }

        public QuerySubscribeStatusResponseBodyResultSubscribeStatusDTOS setLiveId(String liveId) {
            this.liveId = liveId;
            return this;
        }
        public String getLiveId() {
            return this.liveId;
        }

        public QuerySubscribeStatusResponseBodyResultSubscribeStatusDTOS setSubscribe(Boolean subscribe) {
            this.subscribe = subscribe;
            return this;
        }
        public Boolean getSubscribe() {
            return this.subscribe;
        }

    }

    public static class QuerySubscribeStatusResponseBodyResult extends TeaModel {
        @NameInMap("subscribeStatusDTOS")
        public java.util.List<QuerySubscribeStatusResponseBodyResultSubscribeStatusDTOS> subscribeStatusDTOS;

        public static QuerySubscribeStatusResponseBodyResult build(java.util.Map<String, ?> map) throws Exception {
            QuerySubscribeStatusResponseBodyResult self = new QuerySubscribeStatusResponseBodyResult();
            return TeaModel.build(map, self);
        }

        public QuerySubscribeStatusResponseBodyResult setSubscribeStatusDTOS(java.util.List<QuerySubscribeStatusResponseBodyResultSubscribeStatusDTOS> subscribeStatusDTOS) {
            this.subscribeStatusDTOS = subscribeStatusDTOS;
            return this;
        }
        public java.util.List<QuerySubscribeStatusResponseBodyResultSubscribeStatusDTOS> getSubscribeStatusDTOS() {
            return this.subscribeStatusDTOS;
        }

    }

}
