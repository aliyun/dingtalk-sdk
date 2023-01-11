// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkconference_1_0.models;

import com.aliyun.tea.*;

public class QueryCloudRecordVideoPlayInfoResponseBody extends TeaModel {
    /**
     * <p>时长</p>
     */
    @NameInMap("duration")
    public Long duration;

    /**
     * <p>大小</p>
     */
    @NameInMap("fileSize")
    public Long fileSize;

    /**
     * <p>MP4格式下载链接</p>
     */
    @NameInMap("mp4FileUrl")
    public String mp4FileUrl;

    /**
     * <p>在线播放链接</p>
     */
    @NameInMap("playUrl")
    public String playUrl;

    /**
     * <p>状态</p>
     */
    @NameInMap("status")
    public Long status;

    public static QueryCloudRecordVideoPlayInfoResponseBody build(java.util.Map<String, ?> map) throws Exception {
        QueryCloudRecordVideoPlayInfoResponseBody self = new QueryCloudRecordVideoPlayInfoResponseBody();
        return TeaModel.build(map, self);
    }

    public QueryCloudRecordVideoPlayInfoResponseBody setDuration(Long duration) {
        this.duration = duration;
        return this;
    }
    public Long getDuration() {
        return this.duration;
    }

    public QueryCloudRecordVideoPlayInfoResponseBody setFileSize(Long fileSize) {
        this.fileSize = fileSize;
        return this;
    }
    public Long getFileSize() {
        return this.fileSize;
    }

    public QueryCloudRecordVideoPlayInfoResponseBody setMp4FileUrl(String mp4FileUrl) {
        this.mp4FileUrl = mp4FileUrl;
        return this;
    }
    public String getMp4FileUrl() {
        return this.mp4FileUrl;
    }

    public QueryCloudRecordVideoPlayInfoResponseBody setPlayUrl(String playUrl) {
        this.playUrl = playUrl;
        return this;
    }
    public String getPlayUrl() {
        return this.playUrl;
    }

    public QueryCloudRecordVideoPlayInfoResponseBody setStatus(Long status) {
        this.status = status;
        return this;
    }
    public Long getStatus() {
        return this.status;
    }

}
