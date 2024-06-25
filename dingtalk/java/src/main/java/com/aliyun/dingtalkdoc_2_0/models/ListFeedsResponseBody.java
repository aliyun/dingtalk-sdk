// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdoc_2_0.models;

import com.aliyun.tea.*;

public class ListFeedsResponseBody extends TeaModel {
    @NameInMap("hasMore")
    public Boolean hasMore;

    @NameInMap("items")
    public java.util.List<ListFeedsResponseBodyItems> items;

    /**
     * <strong>example:</strong>
     * <p>abcdef</p>
     */
    @NameInMap("nextToken")
    public String nextToken;

    public static ListFeedsResponseBody build(java.util.Map<String, ?> map) throws Exception {
        ListFeedsResponseBody self = new ListFeedsResponseBody();
        return TeaModel.build(map, self);
    }

    public ListFeedsResponseBody setHasMore(Boolean hasMore) {
        this.hasMore = hasMore;
        return this;
    }
    public Boolean getHasMore() {
        return this.hasMore;
    }

    public ListFeedsResponseBody setItems(java.util.List<ListFeedsResponseBodyItems> items) {
        this.items = items;
        return this;
    }
    public java.util.List<ListFeedsResponseBodyItems> getItems() {
        return this.items;
    }

    public ListFeedsResponseBody setNextToken(String nextToken) {
        this.nextToken = nextToken;
        return this;
    }
    public String getNextToken() {
        return this.nextToken;
    }

    public static class ListFeedsResponseBodyItems extends TeaModel {
        /**
         * <strong>example:</strong>
         * <p>&quot;{}&quot;</p>
         */
        @NameInMap("content")
        public String content;

        /**
         * <strong>example:</strong>
         * <p>12340000</p>
         */
        @NameInMap("time")
        public Long time;

        /**
         * <strong>example:</strong>
         * <p>1</p>
         */
        @NameInMap("type")
        public Integer type;

        public static ListFeedsResponseBodyItems build(java.util.Map<String, ?> map) throws Exception {
            ListFeedsResponseBodyItems self = new ListFeedsResponseBodyItems();
            return TeaModel.build(map, self);
        }

        public ListFeedsResponseBodyItems setContent(String content) {
            this.content = content;
            return this;
        }
        public String getContent() {
            return this.content;
        }

        public ListFeedsResponseBodyItems setTime(Long time) {
            this.time = time;
            return this;
        }
        public Long getTime() {
            return this.time;
        }

        public ListFeedsResponseBodyItems setType(Integer type) {
            this.type = type;
            return this;
        }
        public Integer getType() {
            return this.type;
        }

    }

}
