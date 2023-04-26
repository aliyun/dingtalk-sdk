// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkstorage_1_0.models;

import com.aliyun.tea.*;

public class ListAllDentriesRequest extends TeaModel {
    @NameInMap("option")
    public ListAllDentriesRequestOption option;

    @NameInMap("unionId")
    public String unionId;

    public static ListAllDentriesRequest build(java.util.Map<String, ?> map) throws Exception {
        ListAllDentriesRequest self = new ListAllDentriesRequest();
        return TeaModel.build(map, self);
    }

    public ListAllDentriesRequest setOption(ListAllDentriesRequestOption option) {
        this.option = option;
        return this;
    }
    public ListAllDentriesRequestOption getOption() {
        return this.option;
    }

    public ListAllDentriesRequest setUnionId(String unionId) {
        this.unionId = unionId;
        return this;
    }
    public String getUnionId() {
        return this.unionId;
    }

    public static class ListAllDentriesRequestOption extends TeaModel {
        @NameInMap("maxResults")
        public Integer maxResults;

        @NameInMap("nextToken")
        public String nextToken;

        @NameInMap("order")
        public String order;

        @NameInMap("withThumbnail")
        public Boolean withThumbnail;

        public static ListAllDentriesRequestOption build(java.util.Map<String, ?> map) throws Exception {
            ListAllDentriesRequestOption self = new ListAllDentriesRequestOption();
            return TeaModel.build(map, self);
        }

        public ListAllDentriesRequestOption setMaxResults(Integer maxResults) {
            this.maxResults = maxResults;
            return this;
        }
        public Integer getMaxResults() {
            return this.maxResults;
        }

        public ListAllDentriesRequestOption setNextToken(String nextToken) {
            this.nextToken = nextToken;
            return this;
        }
        public String getNextToken() {
            return this.nextToken;
        }

        public ListAllDentriesRequestOption setOrder(String order) {
            this.order = order;
            return this;
        }
        public String getOrder() {
            return this.order;
        }

        public ListAllDentriesRequestOption setWithThumbnail(Boolean withThumbnail) {
            this.withThumbnail = withThumbnail;
            return this;
        }
        public Boolean getWithThumbnail() {
            return this.withThumbnail;
        }

    }

}
