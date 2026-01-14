// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdoc_1_0.models;

import com.aliyun.tea.*;

public class DocElementsResponseBody extends TeaModel {
    @NameInMap("result")
    public DocElementsResponseBodyResult result;

    @NameInMap("success")
    public Boolean success;

    public static DocElementsResponseBody build(java.util.Map<String, ?> map) throws Exception {
        DocElementsResponseBody self = new DocElementsResponseBody();
        return TeaModel.build(map, self);
    }

    public DocElementsResponseBody setResult(DocElementsResponseBodyResult result) {
        this.result = result;
        return this;
    }
    public DocElementsResponseBodyResult getResult() {
        return this.result;
    }

    public DocElementsResponseBody setSuccess(Boolean success) {
        this.success = success;
        return this;
    }
    public Boolean getSuccess() {
        return this.success;
    }

    public static class DocElementsResponseBodyResult extends TeaModel {
        @NameInMap("elements")
        public java.util.List<String> elements;

        @NameInMap("hasMore")
        public Boolean hasMore;

        @NameInMap("nextCursor")
        public String nextCursor;

        public static DocElementsResponseBodyResult build(java.util.Map<String, ?> map) throws Exception {
            DocElementsResponseBodyResult self = new DocElementsResponseBodyResult();
            return TeaModel.build(map, self);
        }

        public DocElementsResponseBodyResult setElements(java.util.List<String> elements) {
            this.elements = elements;
            return this;
        }
        public java.util.List<String> getElements() {
            return this.elements;
        }

        public DocElementsResponseBodyResult setHasMore(Boolean hasMore) {
            this.hasMore = hasMore;
            return this;
        }
        public Boolean getHasMore() {
            return this.hasMore;
        }

        public DocElementsResponseBodyResult setNextCursor(String nextCursor) {
            this.nextCursor = nextCursor;
            return this;
        }
        public String getNextCursor() {
            return this.nextCursor;
        }

    }

}
