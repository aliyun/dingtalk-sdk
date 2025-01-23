// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkminutes_1_0.models;

import com.aliyun.tea.*;

public class QueryUploadVideoPlayInfoResponseBody extends TeaModel {
    @NameInMap("playInfo")
    public QueryUploadVideoPlayInfoResponseBodyPlayInfo playInfo;

    public static QueryUploadVideoPlayInfoResponseBody build(java.util.Map<String, ?> map) throws Exception {
        QueryUploadVideoPlayInfoResponseBody self = new QueryUploadVideoPlayInfoResponseBody();
        return TeaModel.build(map, self);
    }

    public QueryUploadVideoPlayInfoResponseBody setPlayInfo(QueryUploadVideoPlayInfoResponseBodyPlayInfo playInfo) {
        this.playInfo = playInfo;
        return this;
    }
    public QueryUploadVideoPlayInfoResponseBodyPlayInfo getPlayInfo() {
        return this.playInfo;
    }

    public static class QueryUploadVideoPlayInfoResponseBodyPlayInfo extends TeaModel {
        @NameInMap("duration")
        public Long duration;

        @NameInMap("playUrl")
        public String playUrl;

        @NameInMap("size")
        public Long size;

        @NameInMap("status")
        public String status;

        public static QueryUploadVideoPlayInfoResponseBodyPlayInfo build(java.util.Map<String, ?> map) throws Exception {
            QueryUploadVideoPlayInfoResponseBodyPlayInfo self = new QueryUploadVideoPlayInfoResponseBodyPlayInfo();
            return TeaModel.build(map, self);
        }

        public QueryUploadVideoPlayInfoResponseBodyPlayInfo setDuration(Long duration) {
            this.duration = duration;
            return this;
        }
        public Long getDuration() {
            return this.duration;
        }

        public QueryUploadVideoPlayInfoResponseBodyPlayInfo setPlayUrl(String playUrl) {
            this.playUrl = playUrl;
            return this;
        }
        public String getPlayUrl() {
            return this.playUrl;
        }

        public QueryUploadVideoPlayInfoResponseBodyPlayInfo setSize(Long size) {
            this.size = size;
            return this;
        }
        public Long getSize() {
            return this.size;
        }

        public QueryUploadVideoPlayInfoResponseBodyPlayInfo setStatus(String status) {
            this.status = status;
            return this;
        }
        public String getStatus() {
            return this.status;
        }

    }

}
