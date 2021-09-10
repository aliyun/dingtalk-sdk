// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkconference_1_0.models;

import com.aliyun.tea.*;

public class QueryCloudRecordVideoPlayInfoResponseBody extends TeaModel {
    // 在线播放链接
    @NameInMap("playUrl")
    public String playUrl;

    // MP4格式下载链接
    @NameInMap("mp4FileUrl")
    public String mp4FileUrl;

    // 大小
    @NameInMap("fileSize")
    public Long fileSize;

    // 时长
    @NameInMap("duration")
    public Long duration;

    // 状态
    @NameInMap("status")
    public Long status;

    public static QueryCloudRecordVideoPlayInfoResponseBody build(java.util.Map<String, ?> map) throws Exception {
        QueryCloudRecordVideoPlayInfoResponseBody self = new QueryCloudRecordVideoPlayInfoResponseBody();
        return TeaModel.build(map, self);
    }

    public QueryCloudRecordVideoPlayInfoResponseBody setPlayUrl(String playUrl) {
        this.playUrl = playUrl;
        return this;
    }
    public String getPlayUrl() {
        return this.playUrl;
    }

    public QueryCloudRecordVideoPlayInfoResponseBody setMp4FileUrl(String mp4FileUrl) {
        this.mp4FileUrl = mp4FileUrl;
        return this;
    }
    public String getMp4FileUrl() {
        return this.mp4FileUrl;
    }

    public QueryCloudRecordVideoPlayInfoResponseBody setFileSize(Long fileSize) {
        this.fileSize = fileSize;
        return this;
    }
    public Long getFileSize() {
        return this.fileSize;
    }

    public QueryCloudRecordVideoPlayInfoResponseBody setDuration(Long duration) {
        this.duration = duration;
        return this;
    }
    public Long getDuration() {
        return this.duration;
    }

    public QueryCloudRecordVideoPlayInfoResponseBody setStatus(Long status) {
        this.status = status;
        return this;
    }
    public Long getStatus() {
        return this.status;
    }

}
