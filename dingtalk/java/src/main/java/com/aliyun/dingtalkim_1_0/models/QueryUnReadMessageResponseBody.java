// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkim_1_0.models;

import com.aliyun.tea.*;

public class QueryUnReadMessageResponseBody extends TeaModel {
    @NameInMap("unReadCount")
    public Long unReadCount;

    @NameInMap("unReadItems")
    public java.util.List<QueryUnReadMessageResponseBodyUnReadItems> unReadItems;

    public static QueryUnReadMessageResponseBody build(java.util.Map<String, ?> map) throws Exception {
        QueryUnReadMessageResponseBody self = new QueryUnReadMessageResponseBody();
        return TeaModel.build(map, self);
    }

    public QueryUnReadMessageResponseBody setUnReadCount(Long unReadCount) {
        this.unReadCount = unReadCount;
        return this;
    }
    public Long getUnReadCount() {
        return this.unReadCount;
    }

    public QueryUnReadMessageResponseBody setUnReadItems(java.util.List<QueryUnReadMessageResponseBodyUnReadItems> unReadItems) {
        this.unReadItems = unReadItems;
        return this;
    }
    public java.util.List<QueryUnReadMessageResponseBodyUnReadItems> getUnReadItems() {
        return this.unReadItems;
    }

    public static class QueryUnReadMessageResponseBodyUnReadItems extends TeaModel {
        @NameInMap("openConversationId")
        public String openConversationId;

        @NameInMap("unReadCount")
        public Long unReadCount;

        public static QueryUnReadMessageResponseBodyUnReadItems build(java.util.Map<String, ?> map) throws Exception {
            QueryUnReadMessageResponseBodyUnReadItems self = new QueryUnReadMessageResponseBodyUnReadItems();
            return TeaModel.build(map, self);
        }

        public QueryUnReadMessageResponseBodyUnReadItems setOpenConversationId(String openConversationId) {
            this.openConversationId = openConversationId;
            return this;
        }
        public String getOpenConversationId() {
            return this.openConversationId;
        }

        public QueryUnReadMessageResponseBodyUnReadItems setUnReadCount(Long unReadCount) {
            this.unReadCount = unReadCount;
            return this;
        }
        public Long getUnReadCount() {
            return this.unReadCount;
        }

    }

}
