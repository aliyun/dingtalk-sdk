// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkminutes_1_0.models;

import com.aliyun.tea.*;

public class QueryMinutesPlayInfoResponseBody extends TeaModel {
    @NameInMap("playInfo")
    public QueryMinutesPlayInfoResponseBodyPlayInfo playInfo;

    public static QueryMinutesPlayInfoResponseBody build(java.util.Map<String, ?> map) throws Exception {
        QueryMinutesPlayInfoResponseBody self = new QueryMinutesPlayInfoResponseBody();
        return TeaModel.build(map, self);
    }

    public QueryMinutesPlayInfoResponseBody setPlayInfo(QueryMinutesPlayInfoResponseBodyPlayInfo playInfo) {
        this.playInfo = playInfo;
        return this;
    }
    public QueryMinutesPlayInfoResponseBodyPlayInfo getPlayInfo() {
        return this.playInfo;
    }

    public static class QueryMinutesPlayInfoResponseBodyPlayInfo extends TeaModel {
        @NameInMap("downloadUrl")
        public String downloadUrl;

        @NameInMap("duration")
        public String duration;

        @NameInMap("mediaType")
        public String mediaType;

        @NameInMap("playUrl")
        public String playUrl;

        @NameInMap("size")
        public String size;

        @NameInMap("status")
        public String status;

        public static QueryMinutesPlayInfoResponseBodyPlayInfo build(java.util.Map<String, ?> map) throws Exception {
            QueryMinutesPlayInfoResponseBodyPlayInfo self = new QueryMinutesPlayInfoResponseBodyPlayInfo();
            return TeaModel.build(map, self);
        }

        public QueryMinutesPlayInfoResponseBodyPlayInfo setDownloadUrl(String downloadUrl) {
            this.downloadUrl = downloadUrl;
            return this;
        }
        public String getDownloadUrl() {
            return this.downloadUrl;
        }

        public QueryMinutesPlayInfoResponseBodyPlayInfo setDuration(String duration) {
            this.duration = duration;
            return this;
        }
        public String getDuration() {
            return this.duration;
        }

        public QueryMinutesPlayInfoResponseBodyPlayInfo setMediaType(String mediaType) {
            this.mediaType = mediaType;
            return this;
        }
        public String getMediaType() {
            return this.mediaType;
        }

        public QueryMinutesPlayInfoResponseBodyPlayInfo setPlayUrl(String playUrl) {
            this.playUrl = playUrl;
            return this;
        }
        public String getPlayUrl() {
            return this.playUrl;
        }

        public QueryMinutesPlayInfoResponseBodyPlayInfo setSize(String size) {
            this.size = size;
            return this;
        }
        public String getSize() {
            return this.size;
        }

        public QueryMinutesPlayInfoResponseBodyPlayInfo setStatus(String status) {
            this.status = status;
            return this;
        }
        public String getStatus() {
            return this.status;
        }

    }

}
