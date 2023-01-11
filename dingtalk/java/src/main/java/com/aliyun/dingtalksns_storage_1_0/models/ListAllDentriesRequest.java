// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalksns_storage_1_0.models;

import com.aliyun.tea.*;

public class ListAllDentriesRequest extends TeaModel {
    /**
     * <p>可选参数</p>
     */
    @NameInMap("option")
    public ListAllDentriesRequestOption option;

    /**
     * <p>用户id</p>
     */
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
        /**
         * <p>分页大小</p>
         * <p>默认值:</p>
         * <p>	50</p>
         * <p>最大值:</p>
         * <p>	50</p>
         */
        @NameInMap("maxResults")
        public Integer maxResults;

        /**
         * <p>分页游标, 首次拉取不用传</p>
         */
        @NameInMap("nextToken")
        public String nextToken;

        /**
         * <p>排序规则, 升降或降序</p>
         * <p>目前仅支持按修改时间排序,</p>
         * <p>如果是升序排序, 分页拉取过程中, 如果文件发生变化, 可能拉取到重复数据</p>
         * <p>如果是降序排序, 分页拉取过程中, 如果文件发生变化, 可能会丢失数据</p>
         * <p>枚举值:</p>
         * <p>	ASC: 升序</p>
         * <p>	DESC: 降序</p>
         * <p>默认值:</p>
         * <p>	ASC</p>
         */
        @NameInMap("order")
        public String order;

        /**
         * <p>是否获取文件缩略图临时链接</p>
         * <p>注: 按需获取, 会影响接口耗时</p>
         * <p>默认值:</p>
         * <p>	false</p>
         */
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
