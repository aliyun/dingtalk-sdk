// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcontent_1_0.models;

import com.aliyun.tea.*;

public class PageFeedResponseBody extends TeaModel {
    @NameInMap("feedList")
    public java.util.List<PageFeedResponseBodyFeedList> feedList;

    @NameInMap("hasNext")
    public Boolean hasNext;

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
        @NameInMap("feedCategory")
        public String feedCategory;

        @NameInMap("feedId")
        public String feedId;

        @NameInMap("feedType")
        public Integer feedType;

        @NameInMap("name")
        public String name;

        @NameInMap("thumbUrl")
        public String thumbUrl;

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
