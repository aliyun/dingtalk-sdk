// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcontent_1_0.models;

import com.aliyun.tea.*;

public class PageFeedResponseBody extends TeaModel {
    // 课程列表
    @NameInMap("feedList")
    public java.util.List<PageFeedResponseBodyFeedList> feedList;

    // 分页参数：是否还有下一页，false表示没有下一页
    @NameInMap("hasNext")
    public Boolean hasNext;

    // 分页参数：下一页的起始位置
    @NameInMap("nextCursor")
    public Integer nextCursor;

    public static PageFeedResponseBody build(java.util.Map<String, ?> map) throws Exception {
        PageFeedResponseBody self = new PageFeedResponseBody();
        return TeaModel.build(map, self);
    }

    public PageFeedResponseBody setFeedList(java.util.List<PageFeedResponseBodyFeedList> feedList) {
        this.feedList = feedList;
        return this;
    }
    public java.util.List<PageFeedResponseBodyFeedList> getFeedList() {
        return this.feedList;
    }

    public PageFeedResponseBody setHasNext(Boolean hasNext) {
        this.hasNext = hasNext;
        return this;
    }
    public Boolean getHasNext() {
        return this.hasNext;
    }

    public PageFeedResponseBody setNextCursor(Integer nextCursor) {
        this.nextCursor = nextCursor;
        return this;
    }
    public Integer getNextCursor() {
        return this.nextCursor;
    }

    public static class PageFeedResponseBodyFeedList extends TeaModel {
        // 内容分类，请见https://developers.dingtalk.com/document/app/appendix-content
        @NameInMap("feedCategory")
        public String feedCategory;

        // 内容Id
        @NameInMap("feedId")
        public String feedId;

        // 内容类型，0：免费内容 4：平价内容 5：专栏内容 6：训练营内容
        @NameInMap("feedType")
        public Integer feedType;

        // 内容名称
        @NameInMap("name")
        public String name;

        // 封面URL
        @NameInMap("thumbUrl")
        public String thumbUrl;

        // 跳转Url，跳转到职场学堂后台页面
        @NameInMap("url")
        public String url;

        public static PageFeedResponseBodyFeedList build(java.util.Map<String, ?> map) throws Exception {
            PageFeedResponseBodyFeedList self = new PageFeedResponseBodyFeedList();
            return TeaModel.build(map, self);
        }

        public PageFeedResponseBodyFeedList setFeedCategory(String feedCategory) {
            this.feedCategory = feedCategory;
            return this;
        }
        public String getFeedCategory() {
            return this.feedCategory;
        }

        public PageFeedResponseBodyFeedList setFeedId(String feedId) {
            this.feedId = feedId;
            return this;
        }
        public String getFeedId() {
            return this.feedId;
        }

        public PageFeedResponseBodyFeedList setFeedType(Integer feedType) {
            this.feedType = feedType;
            return this;
        }
        public Integer getFeedType() {
            return this.feedType;
        }

        public PageFeedResponseBodyFeedList setName(String name) {
            this.name = name;
            return this;
        }
        public String getName() {
            return this.name;
        }

        public PageFeedResponseBodyFeedList setThumbUrl(String thumbUrl) {
            this.thumbUrl = thumbUrl;
            return this;
        }
        public String getThumbUrl() {
            return this.thumbUrl;
        }

        public PageFeedResponseBodyFeedList setUrl(String url) {
            this.url = url;
            return this;
        }
        public String getUrl() {
            return this.url;
        }

    }

}
