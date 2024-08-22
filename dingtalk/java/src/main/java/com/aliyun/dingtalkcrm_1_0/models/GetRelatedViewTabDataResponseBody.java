// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcrm_1_0.models;

import com.aliyun.tea.*;

public class GetRelatedViewTabDataResponseBody extends TeaModel {
    @NameInMap("result")
    public GetRelatedViewTabDataResponseBodyResult result;

    public static GetRelatedViewTabDataResponseBody build(java.util.Map<String, ?> map) throws Exception {
        GetRelatedViewTabDataResponseBody self = new GetRelatedViewTabDataResponseBody();
        return TeaModel.build(map, self);
    }

    public GetRelatedViewTabDataResponseBody setResult(GetRelatedViewTabDataResponseBodyResult result) {
        this.result = result;
        return this;
    }
    public GetRelatedViewTabDataResponseBodyResult getResult() {
        return this.result;
    }

    public static class GetRelatedViewTabDataResponseBodyResultPageList extends TeaModel {
        /**
         * <strong>example:</strong>
         * <p>西游四人组:孙悟空</p>
         */
        @NameInMap("abstractMessage")
        public String abstractMessage;

        @NameInMap("createTime")
        public Long createTime;

        /**
         * <strong>example:</strong>
         * <p>王凯提交的楚衣的流程表单2</p>
         */
        @NameInMap("title")
        public String title;

        public static GetRelatedViewTabDataResponseBodyResultPageList build(java.util.Map<String, ?> map) throws Exception {
            GetRelatedViewTabDataResponseBodyResultPageList self = new GetRelatedViewTabDataResponseBodyResultPageList();
            return TeaModel.build(map, self);
        }

        public GetRelatedViewTabDataResponseBodyResultPageList setAbstractMessage(String abstractMessage) {
            this.abstractMessage = abstractMessage;
            return this;
        }
        public String getAbstractMessage() {
            return this.abstractMessage;
        }

        public GetRelatedViewTabDataResponseBodyResultPageList setCreateTime(Long createTime) {
            this.createTime = createTime;
            return this;
        }
        public Long getCreateTime() {
            return this.createTime;
        }

        public GetRelatedViewTabDataResponseBodyResultPageList setTitle(String title) {
            this.title = title;
            return this;
        }
        public String getTitle() {
            return this.title;
        }

    }

    public static class GetRelatedViewTabDataResponseBodyResultPage extends TeaModel {
        @NameInMap("hasMore")
        public Boolean hasMore;

        @NameInMap("list")
        public java.util.List<GetRelatedViewTabDataResponseBodyResultPageList> list;

        /**
         * <strong>example:</strong>
         * <p>10</p>
         */
        @NameInMap("nextToken")
        public Long nextToken;

        /**
         * <strong>example:</strong>
         * <p>5</p>
         */
        @NameInMap("totalCount")
        public Long totalCount;

        public static GetRelatedViewTabDataResponseBodyResultPage build(java.util.Map<String, ?> map) throws Exception {
            GetRelatedViewTabDataResponseBodyResultPage self = new GetRelatedViewTabDataResponseBodyResultPage();
            return TeaModel.build(map, self);
        }

        public GetRelatedViewTabDataResponseBodyResultPage setHasMore(Boolean hasMore) {
            this.hasMore = hasMore;
            return this;
        }
        public Boolean getHasMore() {
            return this.hasMore;
        }

        public GetRelatedViewTabDataResponseBodyResultPage setList(java.util.List<GetRelatedViewTabDataResponseBodyResultPageList> list) {
            this.list = list;
            return this;
        }
        public java.util.List<GetRelatedViewTabDataResponseBodyResultPageList> getList() {
            return this.list;
        }

        public GetRelatedViewTabDataResponseBodyResultPage setNextToken(Long nextToken) {
            this.nextToken = nextToken;
            return this;
        }
        public Long getNextToken() {
            return this.nextToken;
        }

        public GetRelatedViewTabDataResponseBodyResultPage setTotalCount(Long totalCount) {
            this.totalCount = totalCount;
            return this;
        }
        public Long getTotalCount() {
            return this.totalCount;
        }

    }

    public static class GetRelatedViewTabDataResponseBodyResult extends TeaModel {
        @NameInMap("page")
        public GetRelatedViewTabDataResponseBodyResultPage page;

        public static GetRelatedViewTabDataResponseBodyResult build(java.util.Map<String, ?> map) throws Exception {
            GetRelatedViewTabDataResponseBodyResult self = new GetRelatedViewTabDataResponseBodyResult();
            return TeaModel.build(map, self);
        }

        public GetRelatedViewTabDataResponseBodyResult setPage(GetRelatedViewTabDataResponseBodyResultPage page) {
            this.page = page;
            return this;
        }
        public GetRelatedViewTabDataResponseBodyResultPage getPage() {
            return this.page;
        }

    }

}
