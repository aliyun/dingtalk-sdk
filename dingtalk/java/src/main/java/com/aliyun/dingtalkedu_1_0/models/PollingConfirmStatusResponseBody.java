// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkedu_1_0.models;

import com.aliyun.tea.*;

public class PollingConfirmStatusResponseBody extends TeaModel {
    @NameInMap("universityPollingCourseStatusResponse")
    public PollingConfirmStatusResponseBodyUniversityPollingCourseStatusResponse universityPollingCourseStatusResponse;

    public static PollingConfirmStatusResponseBody build(java.util.Map<String, ?> map) throws Exception {
        PollingConfirmStatusResponseBody self = new PollingConfirmStatusResponseBody();
        return TeaModel.build(map, self);
    }

    public PollingConfirmStatusResponseBody setUniversityPollingCourseStatusResponse(PollingConfirmStatusResponseBodyUniversityPollingCourseStatusResponse universityPollingCourseStatusResponse) {
        this.universityPollingCourseStatusResponse = universityPollingCourseStatusResponse;
        return this;
    }
    public PollingConfirmStatusResponseBodyUniversityPollingCourseStatusResponse getUniversityPollingCourseStatusResponse() {
        return this.universityPollingCourseStatusResponse;
    }

    public static class PollingConfirmStatusResponseBodyUniversityPollingCourseStatusResponseLivePlayInfoList extends TeaModel {
        @NameInMap("liveInputUrl")
        public String liveInputUrl;

        @NameInMap("liveOutputUrl")
        public String liveOutputUrl;

        @NameInMap("liveType")
        public Long liveType;

        @NameInMap("replayUrl")
        public String replayUrl;

        public static PollingConfirmStatusResponseBodyUniversityPollingCourseStatusResponseLivePlayInfoList build(java.util.Map<String, ?> map) throws Exception {
            PollingConfirmStatusResponseBodyUniversityPollingCourseStatusResponseLivePlayInfoList self = new PollingConfirmStatusResponseBodyUniversityPollingCourseStatusResponseLivePlayInfoList();
            return TeaModel.build(map, self);
        }

        public PollingConfirmStatusResponseBodyUniversityPollingCourseStatusResponseLivePlayInfoList setLiveInputUrl(String liveInputUrl) {
            this.liveInputUrl = liveInputUrl;
            return this;
        }
        public String getLiveInputUrl() {
            return this.liveInputUrl;
        }

        public PollingConfirmStatusResponseBodyUniversityPollingCourseStatusResponseLivePlayInfoList setLiveOutputUrl(String liveOutputUrl) {
            this.liveOutputUrl = liveOutputUrl;
            return this;
        }
        public String getLiveOutputUrl() {
            return this.liveOutputUrl;
        }

        public PollingConfirmStatusResponseBodyUniversityPollingCourseStatusResponseLivePlayInfoList setLiveType(Long liveType) {
            this.liveType = liveType;
            return this;
        }
        public Long getLiveType() {
            return this.liveType;
        }

        public PollingConfirmStatusResponseBodyUniversityPollingCourseStatusResponseLivePlayInfoList setReplayUrl(String replayUrl) {
            this.replayUrl = replayUrl;
            return this;
        }
        public String getReplayUrl() {
            return this.replayUrl;
        }

    }

    public static class PollingConfirmStatusResponseBodyUniversityPollingCourseStatusResponse extends TeaModel {
        @NameInMap("confirmStatus")
        public Boolean confirmStatus;

        @NameInMap("courseCode")
        public String courseCode;

        @NameInMap("livePlayInfoList")
        public java.util.List<PollingConfirmStatusResponseBodyUniversityPollingCourseStatusResponseLivePlayInfoList> livePlayInfoList;

        public static PollingConfirmStatusResponseBodyUniversityPollingCourseStatusResponse build(java.util.Map<String, ?> map) throws Exception {
            PollingConfirmStatusResponseBodyUniversityPollingCourseStatusResponse self = new PollingConfirmStatusResponseBodyUniversityPollingCourseStatusResponse();
            return TeaModel.build(map, self);
        }

        public PollingConfirmStatusResponseBodyUniversityPollingCourseStatusResponse setConfirmStatus(Boolean confirmStatus) {
            this.confirmStatus = confirmStatus;
            return this;
        }
        public Boolean getConfirmStatus() {
            return this.confirmStatus;
        }

        public PollingConfirmStatusResponseBodyUniversityPollingCourseStatusResponse setCourseCode(String courseCode) {
            this.courseCode = courseCode;
            return this;
        }
        public String getCourseCode() {
            return this.courseCode;
        }

        public PollingConfirmStatusResponseBodyUniversityPollingCourseStatusResponse setLivePlayInfoList(java.util.List<PollingConfirmStatusResponseBodyUniversityPollingCourseStatusResponseLivePlayInfoList> livePlayInfoList) {
            this.livePlayInfoList = livePlayInfoList;
            return this;
        }
        public java.util.List<PollingConfirmStatusResponseBodyUniversityPollingCourseStatusResponseLivePlayInfoList> getLivePlayInfoList() {
            return this.livePlayInfoList;
        }

    }

}
