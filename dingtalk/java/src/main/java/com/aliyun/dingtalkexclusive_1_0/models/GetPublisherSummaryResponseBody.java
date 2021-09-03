// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkexclusive_1_0.models;

import com.aliyun.tea.*;

public class GetPublisherSummaryResponseBody extends TeaModel {
    // 互动服务窗相关数据
    @NameInMap("data")
    public java.util.List<GetPublisherSummaryResponseBodyData> data;

    // 历史截至当日服务窗数
    @NameInMap("publisherCntStd")
    public String publisherCntStd;

    // 历史截至当日服务窗文章数
    @NameInMap("publisherArticleCntStd")
    public String publisherArticleCntStd;

    // 历史截至当日服务窗文章阅读数
    @NameInMap("publisherArticlePvCntStd")
    public String publisherArticlePvCntStd;

    // 阅读量最高的5个文章
    @NameInMap("publisherArticlePvTop5")
    public java.util.List<GetPublisherSummaryResponseBodyPublisherArticlePvTop5> publisherArticlePvTop5;

    // 下一次请求的分页游标
    @NameInMap("nextId")
    public Long nextId;

    // 是否有更多数据
    @NameInMap("hasMore")
    public Boolean hasMore;

    public static GetPublisherSummaryResponseBody build(java.util.Map<String, ?> map) throws Exception {
        GetPublisherSummaryResponseBody self = new GetPublisherSummaryResponseBody();
        return TeaModel.build(map, self);
    }

    public GetPublisherSummaryResponseBody setData(java.util.List<GetPublisherSummaryResponseBodyData> data) {
        this.data = data;
        return this;
    }
    public java.util.List<GetPublisherSummaryResponseBodyData> getData() {
        return this.data;
    }

    public GetPublisherSummaryResponseBody setPublisherCntStd(String publisherCntStd) {
        this.publisherCntStd = publisherCntStd;
        return this;
    }
    public String getPublisherCntStd() {
        return this.publisherCntStd;
    }

    public GetPublisherSummaryResponseBody setPublisherArticleCntStd(String publisherArticleCntStd) {
        this.publisherArticleCntStd = publisherArticleCntStd;
        return this;
    }
    public String getPublisherArticleCntStd() {
        return this.publisherArticleCntStd;
    }

    public GetPublisherSummaryResponseBody setPublisherArticlePvCntStd(String publisherArticlePvCntStd) {
        this.publisherArticlePvCntStd = publisherArticlePvCntStd;
        return this;
    }
    public String getPublisherArticlePvCntStd() {
        return this.publisherArticlePvCntStd;
    }

    public GetPublisherSummaryResponseBody setPublisherArticlePvTop5(java.util.List<GetPublisherSummaryResponseBodyPublisherArticlePvTop5> publisherArticlePvTop5) {
        this.publisherArticlePvTop5 = publisherArticlePvTop5;
        return this;
    }
    public java.util.List<GetPublisherSummaryResponseBodyPublisherArticlePvTop5> getPublisherArticlePvTop5() {
        return this.publisherArticlePvTop5;
    }

    public GetPublisherSummaryResponseBody setNextId(Long nextId) {
        this.nextId = nextId;
        return this;
    }
    public Long getNextId() {
        return this.nextId;
    }

    public GetPublisherSummaryResponseBody setHasMore(Boolean hasMore) {
        this.hasMore = hasMore;
        return this;
    }
    public Boolean getHasMore() {
        return this.hasMore;
    }

    public static class GetPublisherSummaryResponseBodyData extends TeaModel {
        // 服务窗unionId
        @NameInMap("unionId")
        public String unionId;

        // 服务窗名称
        @NameInMap("publisherName")
        public String publisherName;

        // 历史截至当日服务窗文章数
        @NameInMap("publisherArticleCntStd")
        public String publisherArticleCntStd;

        // 历史截至当日服务窗文章阅读数
        @NameInMap("publisherArticlePvCntStd")
        public String publisherArticlePvCntStd;

        public static GetPublisherSummaryResponseBodyData build(java.util.Map<String, ?> map) throws Exception {
            GetPublisherSummaryResponseBodyData self = new GetPublisherSummaryResponseBodyData();
            return TeaModel.build(map, self);
        }

        public GetPublisherSummaryResponseBodyData setUnionId(String unionId) {
            this.unionId = unionId;
            return this;
        }
        public String getUnionId() {
            return this.unionId;
        }

        public GetPublisherSummaryResponseBodyData setPublisherName(String publisherName) {
            this.publisherName = publisherName;
            return this;
        }
        public String getPublisherName() {
            return this.publisherName;
        }

        public GetPublisherSummaryResponseBodyData setPublisherArticleCntStd(String publisherArticleCntStd) {
            this.publisherArticleCntStd = publisherArticleCntStd;
            return this;
        }
        public String getPublisherArticleCntStd() {
            return this.publisherArticleCntStd;
        }

        public GetPublisherSummaryResponseBodyData setPublisherArticlePvCntStd(String publisherArticlePvCntStd) {
            this.publisherArticlePvCntStd = publisherArticlePvCntStd;
            return this;
        }
        public String getPublisherArticlePvCntStd() {
            return this.publisherArticlePvCntStd;
        }

    }

    public static class GetPublisherSummaryResponseBodyPublisherArticlePvTop5 extends TeaModel {
        // 文章名称
        @NameInMap("name")
        public String name;

        public static GetPublisherSummaryResponseBodyPublisherArticlePvTop5 build(java.util.Map<String, ?> map) throws Exception {
            GetPublisherSummaryResponseBodyPublisherArticlePvTop5 self = new GetPublisherSummaryResponseBodyPublisherArticlePvTop5();
            return TeaModel.build(map, self);
        }

        public GetPublisherSummaryResponseBodyPublisherArticlePvTop5 setName(String name) {
            this.name = name;
            return this;
        }
        public String getName() {
            return this.name;
        }

    }

}
