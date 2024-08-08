// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcrm_1_0.models;

import com.aliyun.tea.*;

public class GetRelatedViewTabDataResponseBody extends TeaModel {
    @NameInMap("relatedViewTabDataResponse")
    public GetRelatedViewTabDataResponseBodyRelatedViewTabDataResponse relatedViewTabDataResponse;

    public static GetRelatedViewTabDataResponseBody build(java.util.Map<String, ?> map) throws Exception {
        GetRelatedViewTabDataResponseBody self = new GetRelatedViewTabDataResponseBody();
        return TeaModel.build(map, self);
    }

    public GetRelatedViewTabDataResponseBody setRelatedViewTabDataResponse(GetRelatedViewTabDataResponseBodyRelatedViewTabDataResponse relatedViewTabDataResponse) {
        this.relatedViewTabDataResponse = relatedViewTabDataResponse;
        return this;
    }
    public GetRelatedViewTabDataResponseBodyRelatedViewTabDataResponse getRelatedViewTabDataResponse() {
        return this.relatedViewTabDataResponse;
    }

    public static class GetRelatedViewTabDataResponseBodyRelatedViewTabDataResponseRelatedViewTabPageDataList extends TeaModel {
        /**
         * <strong>example:</strong>
         * <p>西游四人组:孙悟空</p>
         */
        @NameInMap("abstractMessage")
        public String abstractMessage;

        /**
         * <strong>example:</strong>
         * <p>1722059884000</p>
         */
        @NameInMap("createTime")
        public String createTime;

        /**
         * <strong>example:</strong>
         * <p>王凯提交的楚衣的流程表单2</p>
         */
        @NameInMap("title")
        public String title;

        public static GetRelatedViewTabDataResponseBodyRelatedViewTabDataResponseRelatedViewTabPageDataList build(java.util.Map<String, ?> map) throws Exception {
            GetRelatedViewTabDataResponseBodyRelatedViewTabDataResponseRelatedViewTabPageDataList self = new GetRelatedViewTabDataResponseBodyRelatedViewTabDataResponseRelatedViewTabPageDataList();
            return TeaModel.build(map, self);
        }

        public GetRelatedViewTabDataResponseBodyRelatedViewTabDataResponseRelatedViewTabPageDataList setAbstractMessage(String abstractMessage) {
            this.abstractMessage = abstractMessage;
            return this;
        }
        public String getAbstractMessage() {
            return this.abstractMessage;
        }

        public GetRelatedViewTabDataResponseBodyRelatedViewTabDataResponseRelatedViewTabPageDataList setCreateTime(String createTime) {
            this.createTime = createTime;
            return this;
        }
        public String getCreateTime() {
            return this.createTime;
        }

        public GetRelatedViewTabDataResponseBodyRelatedViewTabDataResponseRelatedViewTabPageDataList setTitle(String title) {
            this.title = title;
            return this;
        }
        public String getTitle() {
            return this.title;
        }

    }

    public static class GetRelatedViewTabDataResponseBodyRelatedViewTabDataResponseRelatedViewTabPageData extends TeaModel {
        @NameInMap("hasMore")
        public Boolean hasMore;

        @NameInMap("list")
        public java.util.List<GetRelatedViewTabDataResponseBodyRelatedViewTabDataResponseRelatedViewTabPageDataList> list;

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

        public static GetRelatedViewTabDataResponseBodyRelatedViewTabDataResponseRelatedViewTabPageData build(java.util.Map<String, ?> map) throws Exception {
            GetRelatedViewTabDataResponseBodyRelatedViewTabDataResponseRelatedViewTabPageData self = new GetRelatedViewTabDataResponseBodyRelatedViewTabDataResponseRelatedViewTabPageData();
            return TeaModel.build(map, self);
        }

        public GetRelatedViewTabDataResponseBodyRelatedViewTabDataResponseRelatedViewTabPageData setHasMore(Boolean hasMore) {
            this.hasMore = hasMore;
            return this;
        }
        public Boolean getHasMore() {
            return this.hasMore;
        }

        public GetRelatedViewTabDataResponseBodyRelatedViewTabDataResponseRelatedViewTabPageData setList(java.util.List<GetRelatedViewTabDataResponseBodyRelatedViewTabDataResponseRelatedViewTabPageDataList> list) {
            this.list = list;
            return this;
        }
        public java.util.List<GetRelatedViewTabDataResponseBodyRelatedViewTabDataResponseRelatedViewTabPageDataList> getList() {
            return this.list;
        }

        public GetRelatedViewTabDataResponseBodyRelatedViewTabDataResponseRelatedViewTabPageData setNextToken(Long nextToken) {
            this.nextToken = nextToken;
            return this;
        }
        public Long getNextToken() {
            return this.nextToken;
        }

        public GetRelatedViewTabDataResponseBodyRelatedViewTabDataResponseRelatedViewTabPageData setTotalCount(Long totalCount) {
            this.totalCount = totalCount;
            return this;
        }
        public Long getTotalCount() {
            return this.totalCount;
        }

    }

    public static class GetRelatedViewTabDataResponseBodyRelatedViewTabDataResponse extends TeaModel {
        @NameInMap("relatedViewTabPageData")
        public GetRelatedViewTabDataResponseBodyRelatedViewTabDataResponseRelatedViewTabPageData relatedViewTabPageData;

        public static GetRelatedViewTabDataResponseBodyRelatedViewTabDataResponse build(java.util.Map<String, ?> map) throws Exception {
            GetRelatedViewTabDataResponseBodyRelatedViewTabDataResponse self = new GetRelatedViewTabDataResponseBodyRelatedViewTabDataResponse();
            return TeaModel.build(map, self);
        }

        public GetRelatedViewTabDataResponseBodyRelatedViewTabDataResponse setRelatedViewTabPageData(GetRelatedViewTabDataResponseBodyRelatedViewTabDataResponseRelatedViewTabPageData relatedViewTabPageData) {
            this.relatedViewTabPageData = relatedViewTabPageData;
            return this;
        }
        public GetRelatedViewTabDataResponseBodyRelatedViewTabDataResponseRelatedViewTabPageData getRelatedViewTabPageData() {
            return this.relatedViewTabPageData;
        }

    }

}
