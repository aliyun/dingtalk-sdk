// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdvi_1_0.models;

import com.aliyun.tea.*;

public class GetServiceChapterSummaryResponseBody extends TeaModel {
    @NameInMap("nextToken")
    public String nextToken;

    @NameInMap("result")
    public java.util.List<GetServiceChapterSummaryResponseBodyResult> result;

    @NameInMap("totalCount")
    public Integer totalCount;

    public static GetServiceChapterSummaryResponseBody build(java.util.Map<String, ?> map) throws Exception {
        GetServiceChapterSummaryResponseBody self = new GetServiceChapterSummaryResponseBody();
        return TeaModel.build(map, self);
    }

    public GetServiceChapterSummaryResponseBody setNextToken(String nextToken) {
        this.nextToken = nextToken;
        return this;
    }
    public String getNextToken() {
        return this.nextToken;
    }

    public GetServiceChapterSummaryResponseBody setResult(java.util.List<GetServiceChapterSummaryResponseBodyResult> result) {
        this.result = result;
        return this;
    }
    public java.util.List<GetServiceChapterSummaryResponseBodyResult> getResult() {
        return this.result;
    }

    public GetServiceChapterSummaryResponseBody setTotalCount(Integer totalCount) {
        this.totalCount = totalCount;
        return this;
    }
    public Integer getTotalCount() {
        return this.totalCount;
    }

    public static class GetServiceChapterSummaryResponseBodyResult extends TeaModel {
        @NameInMap("content")
        public String content;

        @NameInMap("name")
        public String name;

        public static GetServiceChapterSummaryResponseBodyResult build(java.util.Map<String, ?> map) throws Exception {
            GetServiceChapterSummaryResponseBodyResult self = new GetServiceChapterSummaryResponseBodyResult();
            return TeaModel.build(map, self);
        }

        public GetServiceChapterSummaryResponseBodyResult setContent(String content) {
            this.content = content;
            return this;
        }
        public String getContent() {
            return this.content;
        }

        public GetServiceChapterSummaryResponseBodyResult setName(String name) {
            this.name = name;
            return this;
        }
        public String getName() {
            return this.name;
        }

    }

}
