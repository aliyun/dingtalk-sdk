// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkhrbrain_1_0.models;

import com.aliyun.tea.*;

public class HrbrainBizDataQueryResponseBody extends TeaModel {
    @NameInMap("content")
    public HrbrainBizDataQueryResponseBodyContent content;

    @NameInMap("requestId")
    public String requestId;

    @NameInMap("result")
    public Boolean result;

    @NameInMap("success")
    public Boolean success;

    public static HrbrainBizDataQueryResponseBody build(java.util.Map<String, ?> map) throws Exception {
        HrbrainBizDataQueryResponseBody self = new HrbrainBizDataQueryResponseBody();
        return TeaModel.build(map, self);
    }

    public HrbrainBizDataQueryResponseBody setContent(HrbrainBizDataQueryResponseBodyContent content) {
        this.content = content;
        return this;
    }
    public HrbrainBizDataQueryResponseBodyContent getContent() {
        return this.content;
    }

    public HrbrainBizDataQueryResponseBody setRequestId(String requestId) {
        this.requestId = requestId;
        return this;
    }
    public String getRequestId() {
        return this.requestId;
    }

    public HrbrainBizDataQueryResponseBody setResult(Boolean result) {
        this.result = result;
        return this;
    }
    public Boolean getResult() {
        return this.result;
    }

    public HrbrainBizDataQueryResponseBody setSuccess(Boolean success) {
        this.success = success;
        return this;
    }
    public Boolean getSuccess() {
        return this.success;
    }

    public static class HrbrainBizDataQueryResponseBodyContent extends TeaModel {
        @NameInMap("bizInfos")
        public java.util.List<java.util.Map<String, ?>> bizInfos;

        @NameInMap("maxResults")
        public Long maxResults;

        @NameInMap("nextToken")
        public String nextToken;

        public static HrbrainBizDataQueryResponseBodyContent build(java.util.Map<String, ?> map) throws Exception {
            HrbrainBizDataQueryResponseBodyContent self = new HrbrainBizDataQueryResponseBodyContent();
            return TeaModel.build(map, self);
        }

        public HrbrainBizDataQueryResponseBodyContent setBizInfos(java.util.List<java.util.Map<String, ?>> bizInfos) {
            this.bizInfos = bizInfos;
            return this;
        }
        public java.util.List<java.util.Map<String, ?>> getBizInfos() {
            return this.bizInfos;
        }

        public HrbrainBizDataQueryResponseBodyContent setMaxResults(Long maxResults) {
            this.maxResults = maxResults;
            return this;
        }
        public Long getMaxResults() {
            return this.maxResults;
        }

        public HrbrainBizDataQueryResponseBodyContent setNextToken(String nextToken) {
            this.nextToken = nextToken;
            return this;
        }
        public String getNextToken() {
            return this.nextToken;
        }

    }

}
