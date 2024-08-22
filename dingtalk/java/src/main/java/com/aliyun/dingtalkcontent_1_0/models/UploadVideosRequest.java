// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcontent_1_0.models;

import com.aliyun.tea.*;

public class UploadVideosRequest extends TeaModel {
    @NameInMap("body")
    public java.util.List<UploadVideosRequestBody> body;

    public static UploadVideosRequest build(java.util.Map<String, ?> map) throws Exception {
        UploadVideosRequest self = new UploadVideosRequest();
        return TeaModel.build(map, self);
    }

    public UploadVideosRequest setBody(java.util.List<UploadVideosRequestBody> body) {
        this.body = body;
        return this;
    }
    public java.util.List<UploadVideosRequestBody> getBody() {
        return this.body;
    }

    public static class UploadVideosRequestBody extends TeaModel {
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

        public static UploadVideosRequestBody build(java.util.Map<String, ?> map) throws Exception {
            UploadVideosRequestBody self = new UploadVideosRequestBody();
            return TeaModel.build(map, self);
        }

        public UploadVideosRequestBody setAuthorIconUrl(String authorIconUrl) {
            this.authorIconUrl = authorIconUrl;
            return this;
        }
        public String getAuthorIconUrl() {
            return this.authorIconUrl;
        }

        public UploadVideosRequestBody setAuthorId(String authorId) {
            this.authorId = authorId;
            return this;
        }
        public String getAuthorId() {
            return this.authorId;
        }

        public UploadVideosRequestBody setAuthorName(String authorName) {
            this.authorName = authorName;
            return this;
        }
        public String getAuthorName() {
            return this.authorName;
        }

        public UploadVideosRequestBody setCoverUrl(String coverUrl) {
            this.coverUrl = coverUrl;
            return this;
        }
        public String getCoverUrl() {
            return this.coverUrl;
        }

        public UploadVideosRequestBody setJumpIconUrl(String jumpIconUrl) {
            this.jumpIconUrl = jumpIconUrl;
            return this;
        }
        public String getJumpIconUrl() {
            return this.jumpIconUrl;
        }

        public UploadVideosRequestBody setJumpTitle(String jumpTitle) {
            this.jumpTitle = jumpTitle;
            return this;
        }
        public String getJumpTitle() {
            return this.jumpTitle;
        }

        public UploadVideosRequestBody setJumpUrl(String jumpUrl) {
            this.jumpUrl = jumpUrl;
            return this;
        }
        public String getJumpUrl() {
            return this.jumpUrl;
        }

        public UploadVideosRequestBody setVideoDuration(String videoDuration) {
            this.videoDuration = videoDuration;
            return this;
        }
        public String getVideoDuration() {
            return this.videoDuration;
        }

        public UploadVideosRequestBody setVideoHeight(String videoHeight) {
            this.videoHeight = videoHeight;
            return this;
        }
        public String getVideoHeight() {
            return this.videoHeight;
        }

        public UploadVideosRequestBody setVideoId(String videoId) {
            this.videoId = videoId;
            return this;
        }
        public String getVideoId() {
            return this.videoId;
        }

        public UploadVideosRequestBody setVideoTitle(String videoTitle) {
            this.videoTitle = videoTitle;
            return this;
        }
        public String getVideoTitle() {
            return this.videoTitle;
        }

        public UploadVideosRequestBody setVideoWidth(String videoWidth) {
            this.videoWidth = videoWidth;
            return this;
        }
        public String getVideoWidth() {
            return this.videoWidth;
        }

        public UploadVideosRequestBody setWebpUrl(String webpUrl) {
            this.webpUrl = webpUrl;
            return this;
        }
        public String getWebpUrl() {
            return this.webpUrl;
        }

    }

}
