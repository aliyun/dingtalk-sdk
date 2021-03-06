// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcontent_1_0.models;

import com.aliyun.tea.*;

public class GetFeedResponseBody extends TeaModel {
    // 内容Id
    @NameInMap("feedId")
    public String feedId;

    // 子内容
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
        // 子内容Id
        @NameInMap("itemId")
        public String itemId;

        // 子内容标题
        @NameInMap("title")
        public String title;

        // 内容类型，0表示直播，1表示图文，2表示视频，3表示音频
        @NameInMap("feedContentType")
        public Integer feedContentType;

        // 子内容的持续时长，单位为毫秒
        @NameInMap("durationMillis")
        public Long durationMillis;

        // 子内容的跳转链接
        @NameInMap("url")
        public String url;

        public static GetFeedResponseBodyFeedItem build(java.util.Map<String, ?> map) throws Exception {
            GetFeedResponseBodyFeedItem self = new GetFeedResponseBodyFeedItem();
            return TeaModel.build(map, self);
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

        public GetFeedResponseBodyFeedItem setFeedContentType(Integer feedContentType) {
            this.feedContentType = feedContentType;
            return this;
        }
        public Integer getFeedContentType() {
            return this.feedContentType;
        }

        public GetFeedResponseBodyFeedItem setDurationMillis(Long durationMillis) {
            this.durationMillis = durationMillis;
            return this;
        }
        public Long getDurationMillis() {
            return this.durationMillis;
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
