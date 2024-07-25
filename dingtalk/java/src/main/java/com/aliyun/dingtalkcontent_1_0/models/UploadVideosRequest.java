// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcontent_1_0.models;

import com.aliyun.tea.*;

public class UploadVideosRequest extends TeaModel {
    @NameInMap("videoList")
    public java.util.List<UploadVideosRequestVideoList> videoList;

    public static UploadVideosRequest build(java.util.Map<String, ?> map) throws Exception {
        UploadVideosRequest self = new UploadVideosRequest();
        return TeaModel.build(map, self);
    }

    public UploadVideosRequest setVideoList(java.util.List<UploadVideosRequestVideoList> videoList) {
        this.videoList = videoList;
        return this;
    }
    public java.util.List<UploadVideosRequestVideoList> getVideoList() {
        return this.videoList;
    }

    public static class UploadVideosRequestVideoList extends TeaModel {
        @NameInMap("authorIconUrl")
        public String authorIconUrl;

        @NameInMap("authorId")
        public String authorId;

        @NameInMap("authorName")
        public String authorName;

        @NameInMap("coverUrl")
        public String coverUrl;

        @NameInMap("jumpIconUrl")
        public String jumpIconUrl;

        @NameInMap("jumpTitle")
        public String jumpTitle;

        @NameInMap("jumpUrl")
        public String jumpUrl;

        @NameInMap("videoDuration")
        public String videoDuration;

        @NameInMap("videoHeight")
        public String videoHeight;

        @NameInMap("videoId")
        public String videoId;

        @NameInMap("videoTitle")
        public String videoTitle;

        @NameInMap("videoWidth")
        public String videoWidth;

        @NameInMap("webpUrl")
        public String webpUrl;

        public static UploadVideosRequestVideoList build(java.util.Map<String, ?> map) throws Exception {
            UploadVideosRequestVideoList self = new UploadVideosRequestVideoList();
            return TeaModel.build(map, self);
        }

        public UploadVideosRequestVideoList setAuthorIconUrl(String authorIconUrl) {
            this.authorIconUrl = authorIconUrl;
            return this;
        }
        public String getAuthorIconUrl() {
            return this.authorIconUrl;
        }

        public UploadVideosRequestVideoList setAuthorId(String authorId) {
            this.authorId = authorId;
            return this;
        }
        public String getAuthorId() {
            return this.authorId;
        }

        public UploadVideosRequestVideoList setAuthorName(String authorName) {
            this.authorName = authorName;
            return this;
        }
        public String getAuthorName() {
            return this.authorName;
        }

        public UploadVideosRequestVideoList setCoverUrl(String coverUrl) {
            this.coverUrl = coverUrl;
            return this;
        }
        public String getCoverUrl() {
            return this.coverUrl;
        }

        public UploadVideosRequestVideoList setJumpIconUrl(String jumpIconUrl) {
            this.jumpIconUrl = jumpIconUrl;
            return this;
        }
        public String getJumpIconUrl() {
            return this.jumpIconUrl;
        }

        public UploadVideosRequestVideoList setJumpTitle(String jumpTitle) {
            this.jumpTitle = jumpTitle;
            return this;
        }
        public String getJumpTitle() {
            return this.jumpTitle;
        }

        public UploadVideosRequestVideoList setJumpUrl(String jumpUrl) {
            this.jumpUrl = jumpUrl;
            return this;
        }
        public String getJumpUrl() {
            return this.jumpUrl;
        }

        public UploadVideosRequestVideoList setVideoDuration(String videoDuration) {
            this.videoDuration = videoDuration;
            return this;
        }
        public String getVideoDuration() {
            return this.videoDuration;
        }

        public UploadVideosRequestVideoList setVideoHeight(String videoHeight) {
            this.videoHeight = videoHeight;
            return this;
        }
        public String getVideoHeight() {
            return this.videoHeight;
        }

        public UploadVideosRequestVideoList setVideoId(String videoId) {
            this.videoId = videoId;
            return this;
        }
        public String getVideoId() {
            return this.videoId;
        }

        public UploadVideosRequestVideoList setVideoTitle(String videoTitle) {
            this.videoTitle = videoTitle;
            return this;
        }
        public String getVideoTitle() {
            return this.videoTitle;
        }

        public UploadVideosRequestVideoList setVideoWidth(String videoWidth) {
            this.videoWidth = videoWidth;
            return this;
        }
        public String getVideoWidth() {
            return this.videoWidth;
        }

        public UploadVideosRequestVideoList setWebpUrl(String webpUrl) {
            this.webpUrl = webpUrl;
            return this;
        }
        public String getWebpUrl() {
            return this.webpUrl;
        }

    }

}
