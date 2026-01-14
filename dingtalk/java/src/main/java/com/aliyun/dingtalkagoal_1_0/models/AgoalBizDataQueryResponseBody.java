// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkagoal_1_0.models;

import com.aliyun.tea.*;

public class AgoalBizDataQueryResponseBody extends TeaModel {
    @NameInMap("content")
    public AgoalBizDataQueryResponseBodyContent content;

    @NameInMap("requestId")
    public String requestId;

    @NameInMap("result")
    public Boolean result;

    @NameInMap("success")
    public Boolean success;

    public static AgoalBizDataQueryResponseBody build(java.util.Map<String, ?> map) throws Exception {
        AgoalBizDataQueryResponseBody self = new AgoalBizDataQueryResponseBody();
        return TeaModel.build(map, self);
    }

    public AgoalBizDataQueryResponseBody setContent(AgoalBizDataQueryResponseBodyContent content) {
        this.content = content;
        return this;
    }
    public AgoalBizDataQueryResponseBodyContent getContent() {
        return this.content;
    }

    public AgoalBizDataQueryResponseBody setRequestId(String requestId) {
        this.requestId = requestId;
        return this;
    }
    public String getRequestId() {
        return this.requestId;
    }

    public AgoalBizDataQueryResponseBody setResult(Boolean result) {
        this.result = result;
        return this;
    }
    public Boolean getResult() {
        return this.result;
    }

    public AgoalBizDataQueryResponseBody setSuccess(Boolean success) {
        this.success = success;
        return this;
    }
    public Boolean getSuccess() {
        return this.success;
    }

    public static class AgoalBizDataQueryResponseBodyContent extends TeaModel {
        @NameInMap("bizInfos")
        public java.util.List<java.util.Map<String, ?>> bizInfos;

        @NameInMap("maxResults")
        public Long maxResults;

        @NameInMap("nextToken")
        public String nextToken;

        public static AgoalBizDataQueryResponseBodyContent build(java.util.Map<String, ?> map) throws Exception {
            AgoalBizDataQueryResponseBodyContent self = new AgoalBizDataQueryResponseBodyContent();
            return TeaModel.build(map, self);
        }

        public AgoalBizDataQueryResponseBodyContent setBizInfos(java.util.List<java.util.Map<String, ?>> bizInfos) {
            this.bizInfos = bizInfos;
            return this;
        }
        public java.util.List<java.util.Map<String, ?>> getBizInfos() {
            return this.bizInfos;
        }

        public AgoalBizDataQueryResponseBodyContent setMaxResults(Long maxResults) {
            this.maxResults = maxResults;
            return this;
        }
        public Long getMaxResults() {
            return this.maxResults;
        }

        public AgoalBizDataQueryResponseBodyContent setNextToken(String nextToken) {
            this.nextToken = nextToken;
            return this;
        }
        public String getNextToken() {
            return this.nextToken;
        }

    }

}
