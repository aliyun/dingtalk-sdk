// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkedu_1_0.models;

import com.aliyun.tea.*;

public class StartCourseRequest extends TeaModel {
    // opUserId
    @NameInMap("opUserId")
    public String opUserId;

    // 拓展字段
    @NameInMap("ext")
    public String ext;

    // 课程编码
    @NameInMap("courseCode")
    public String courseCode;

    // livePlayInfoList
    @NameInMap("livePlayInfoList")
    public java.util.List<StartCourseRequestLivePlayInfoList> livePlayInfoList;

    // isvCode
    @NameInMap("isvCode")
    public String isvCode;

    public static StartCourseRequest build(java.util.Map<String, ?> map) throws Exception {
        StartCourseRequest self = new StartCourseRequest();
        return TeaModel.build(map, self);
    }

    public StartCourseRequest setOpUserId(String opUserId) {
        this.opUserId = opUserId;
        return this;
    }
    public String getOpUserId() {
        return this.opUserId;
    }

    public StartCourseRequest setExt(String ext) {
        this.ext = ext;
        return this;
    }
    public String getExt() {
        return this.ext;
    }

    public StartCourseRequest setCourseCode(String courseCode) {
        this.courseCode = courseCode;
        return this;
    }
    public String getCourseCode() {
        return this.courseCode;
    }

    public StartCourseRequest setLivePlayInfoList(java.util.List<StartCourseRequestLivePlayInfoList> livePlayInfoList) {
        this.livePlayInfoList = livePlayInfoList;
        return this;
    }
    public java.util.List<StartCourseRequestLivePlayInfoList> getLivePlayInfoList() {
        return this.livePlayInfoList;
    }

    public StartCourseRequest setIsvCode(String isvCode) {
        this.isvCode = isvCode;
        return this;
    }
    public String getIsvCode() {
        return this.isvCode;
    }

    public static class StartCourseRequestLivePlayInfoList extends TeaModel {
        // 直播拉流地址
        @NameInMap("liveOutputUrl")
        public String liveOutputUrl;

        // 直播流类型
        @NameInMap("liveType")
        public Integer liveType;

        // 直播推流地址
        @NameInMap("liveInputUrl")
        public String liveInputUrl;

        // 视频回放地址
        @NameInMap("replayUrl")
        public String replayUrl;

        public static StartCourseRequestLivePlayInfoList build(java.util.Map<String, ?> map) throws Exception {
            StartCourseRequestLivePlayInfoList self = new StartCourseRequestLivePlayInfoList();
            return TeaModel.build(map, self);
        }

        public StartCourseRequestLivePlayInfoList setLiveOutputUrl(String liveOutputUrl) {
            this.liveOutputUrl = liveOutputUrl;
            return this;
        }
        public String getLiveOutputUrl() {
            return this.liveOutputUrl;
        }

        public StartCourseRequestLivePlayInfoList setLiveType(Integer liveType) {
            this.liveType = liveType;
            return this;
        }
        public Integer getLiveType() {
            return this.liveType;
        }

        public StartCourseRequestLivePlayInfoList setLiveInputUrl(String liveInputUrl) {
            this.liveInputUrl = liveInputUrl;
            return this;
        }
        public String getLiveInputUrl() {
            return this.liveInputUrl;
        }

        public StartCourseRequestLivePlayInfoList setReplayUrl(String replayUrl) {
            this.replayUrl = replayUrl;
            return this;
        }
        public String getReplayUrl() {
            return this.replayUrl;
        }

    }

}
