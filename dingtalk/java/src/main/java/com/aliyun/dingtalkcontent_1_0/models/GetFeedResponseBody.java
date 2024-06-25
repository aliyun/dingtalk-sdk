// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcontent_1_0.models;

import com.aliyun.tea.*;

public class GetFeedResponseBody extends TeaModel {
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
     */
    @NameInMap("feedItem")
    public java.util.List<GetFeedResponseBodyFeedItem> feedItem;

    public static GetFeedResponseBody build(java.util.Map<String, ?> map) throws Exception {
        GetFeedResponseBody self = new GetFeedResponseBody();
        return TeaModel.build(map, self);
    }

    public GetFeedResponseBody setFeedId(String feedId) {
        this.feedId = feedId;
        return this;
    }
    public String getFeedId() {
        return this.feedId;
    }

    public GetFeedResponseBody setFeedItem(java.util.List<GetFeedResponseBodyFeedItem> feedItem) {
        this.feedItem = feedItem;
        return this;
    }
    public java.util.List<GetFeedResponseBodyFeedItem> getFeedItem() {
        return this.feedItem;
    }

    public static class GetFeedResponseBodyFeedItem extends TeaModel {
        /**
         * <p>This parameter is required.</p>
         * 
         * <strong>example:</strong>
         * <p>9320</p>
         */
        @NameInMap("durationMillis")
        public Long durationMillis;

        /**
         * <p>This parameter is required.</p>
         * 
         * <strong>example:</strong>
         * <p>0</p>
         */
        @NameInMap("feedContentType")
        public Integer feedContentType;

        /**
         * <p>This parameter is required.</p>
         * 
         * <strong>example:</strong>
         * <p>08<strong><strong>b5-2442-</strong></strong>-bd56-99cf****8861</p>
         */
        @NameInMap("itemId")
        public String itemId;

        /**
         * <p>This parameter is required.</p>
         * 
         * <strong>example:</strong>
         * <p>子内容标题</p>
         */
        @NameInMap("title")
        public String title;

        /**
         * <p>This parameter is required.</p>
         * 
         * <strong>example:</strong>
         * <p><a href="https://h5.dingtalk.com/live/video_lesson.htm?feedId=66****03-a825-****-9501-b1eeb****a8d&mcnId=1832**********06173&feedProperty=2&itemId=08****b5-2442-****-bd56-99c*****8861&dd_nav_bgcolor=FF2C2D2F#/video">https://h5.dingtalk.com/live/video_lesson.htm?feedId=66****03-a825-****-9501-b1eeb****a8d&amp;mcnId=1832**********06173&amp;feedProperty=2&amp;itemId=08****b5-2442-****-bd56-99c*****8861&amp;dd_nav_bgcolor=FF2C2D2F#/video</a></p>
         */
        @NameInMap("url")
        public String url;

        public static GetFeedResponseBodyFeedItem build(java.util.Map<String, ?> map) throws Exception {
            GetFeedResponseBodyFeedItem self = new GetFeedResponseBodyFeedItem();
            return TeaModel.build(map, self);
        }

        public GetFeedResponseBodyFeedItem setDurationMillis(Long durationMillis) {
            this.durationMillis = durationMillis;
            return this;
        }
        public Long getDurationMillis() {
            return this.durationMillis;
        }

        public GetFeedResponseBodyFeedItem setFeedContentType(Integer feedContentType) {
            this.feedContentType = feedContentType;
            return this;
        }
        public Integer getFeedContentType() {
            return this.feedContentType;
        }

        public GetFeedResponseBodyFeedItem setItemId(String itemId) {
            this.itemId = itemId;
            return this;
        }
        public String getItemId() {
            return this.itemId;
        }

        public GetFeedResponseBodyFeedItem setTitle(String title) {
            this.title = title;
            return this;
        }
        public String getTitle() {
            return this.title;
        }

        public GetFeedResponseBodyFeedItem setUrl(String url) {
            this.url = url;
            return this;
        }
        public String getUrl() {
            return this.url;
        }

    }

}
