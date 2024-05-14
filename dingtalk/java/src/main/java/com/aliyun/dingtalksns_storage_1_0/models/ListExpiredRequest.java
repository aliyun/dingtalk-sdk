// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalksns_storage_1_0.models;

import com.aliyun.tea.*;

public class ListExpiredRequest extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("openConversationId")
    public String openConversationId;

    @NameInMap("option")
    public ListExpiredRequestOption option;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("unionId")
    public String unionId;

    public static ListExpiredRequest build(java.util.Map<String, ?> map) throws Exception {
        ListExpiredRequest self = new ListExpiredRequest();
        return TeaModel.build(map, self);
    }

    public ListExpiredRequest setOpenConversationId(String openConversationId) {
        this.openConversationId = openConversationId;
        return this;
    }
    public String getOpenConversationId() {
        return this.openConversationId;
    }

    public ListExpiredRequest setOption(ListExpiredRequestOption option) {
        this.option = option;
        return this;
    }
    public ListExpiredRequestOption getOption() {
        return this.option;
    }

    public ListExpiredRequest setUnionId(String unionId) {
        this.unionId = unionId;
        return this;
    }
    public String getUnionId() {
        return this.unionId;
    }

    public static class ListExpiredRequestOption extends TeaModel {
        @NameInMap("maxResults")
        public Integer maxResults;

        @NameInMap("nextToken")
        public String nextToken;

        public static ListExpiredRequestOption build(java.util.Map<String, ?> map) throws Exception {
            ListExpiredRequestOption self = new ListExpiredRequestOption();
            return TeaModel.build(map, self);
        }

        public ListExpiredRequestOption setMaxResults(Integer maxResults) {
            this.maxResults = maxResults;
            return this;
        }
        public Integer getMaxResults() {
            return this.maxResults;
        }

        public ListExpiredRequestOption setNextToken(String nextToken) {
            this.nextToken = nextToken;
            return this;
        }
        public String getNextToken() {
            return this.nextToken;
        }

    }

}
