// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcontent_1_0.models;

import com.aliyun.tea.*;

public class PageFeedResponseBody extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("feedList")
    public java.util.List<PageFeedResponseBodyFeedList> feedList;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>true</p>
     */
    @NameInMap("hasNext")
    public Boolean hasNext;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>20</p>
     */
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
        /**
         * <p>This parameter is required.</p>
         * 
         * <strong>example:</strong>
         * <p>200000257</p>
         */
        @NameInMap("feedCategory")
        public String feedCategory;

        /**
         * <p>This parameter is required.</p>
         * 
         * <strong>example:</strong>
         * <p>3d******-1cd2-<strong><strong>-ba1d-8</strong></strong>**3c6dc</p>
         */
        @NameInMap("feedId")
        public String feedId;

        /**
         * <p>This parameter is required.</p>
         * 
         * <strong>example:</strong>
         * <p>4</p>
         */
        @NameInMap("feedType")
        public Integer feedType;

        /**
         * <p>This parameter is required.</p>
         * 
         * <strong>example:</strong>
         * <p>名称</p>
         */
        @NameInMap("name")
        public String name;

        /**
         * <p>This parameter is required.</p>
         * 
         * <strong>example:</strong>
         * <p><a href="https://static.dingtalk.com/media/**************NAlg_600_337.jpg">https://static.dingtalk.com/media/**************NAlg_600_337.jpg</a></p>
         */
        @NameInMap("thumbUrl")
        public String thumbUrl;

        /**
         * <p>This parameter is required.</p>
         * 
         * <strong>example:</strong>
         * <p><a href="https://h5.dingtalk.com/live/video_lesson.htm?spm=a1zdd.*******.0.0.3e9617129vSDL8&feedId=5e*****-17ec-45f1-8cc0-e******4a3&mcnId=183206*******06173&feedProperty=1&itemId=5ef7*****-17ec-45f1-8cc0-e64*****954a3&dd_nav_bgcolor=FF2****F#/video">https://h5.dingtalk.com/live/video_lesson.htm?spm=a1zdd.*******.0.0.3e9617129vSDL8&amp;feedId=5e*****-17ec-45f1-8cc0-e******4a3&amp;mcnId=183206*******06173&amp;feedProperty=1&amp;itemId=5ef7*****-17ec-45f1-8cc0-e64*****954a3&amp;dd_nav_bgcolor=FF2****F#/video</a></p>
         */
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
