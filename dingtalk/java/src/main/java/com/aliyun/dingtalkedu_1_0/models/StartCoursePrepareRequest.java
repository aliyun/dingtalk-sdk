// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkedu_1_0.models;

import com.aliyun.tea.*;

public class StartCoursePrepareRequest extends TeaModel {
    // 拓展信息
    @NameInMap("ext")
    public String ext;

    // 课程组编号
    @NameInMap("courseGroupCode")
    public String courseGroupCode;

    // 课节信息
    @NameInMap("sectionIndex")
    public java.util.List<Integer> sectionIndex;

    // 设备id
    @NameInMap("deviceId")
    public String deviceId;

    // 封面url
    @NameInMap("liveCoverImage")
    public String liveCoverImage;

    // 上课日期
    @NameInMap("courseDate")
    public String courseDate;

    // isv编号
    @NameInMap("isvCode")
    public String isvCode;

    // 操作人
    @NameInMap("opUserId")
    public String opUserId;

    public static StartCoursePrepareRequest build(java.util.Map<String, ?> map) throws Exception {
        StartCoursePrepareRequest self = new StartCoursePrepareRequest();
        return TeaModel.build(map, self);
    }

    public StartCoursePrepareRequest setExt(String ext) {
        this.ext = ext;
        return this;
    }
    public String getExt() {
        return this.ext;
    }

    public StartCoursePrepareRequest setCourseGroupCode(String courseGroupCode) {
        this.courseGroupCode = courseGroupCode;
        return this;
    }
    public String getCourseGroupCode() {
        return this.courseGroupCode;
    }

    public StartCoursePrepareRequest setSectionIndex(java.util.List<Integer> sectionIndex) {
        this.sectionIndex = sectionIndex;
        return this;
    }
    public java.util.List<Integer> getSectionIndex() {
        return this.sectionIndex;
    }

    public StartCoursePrepareRequest setDeviceId(String deviceId) {
        this.deviceId = deviceId;
        return this;
    }
    public String getDeviceId() {
        return this.deviceId;
    }

    public StartCoursePrepareRequest setLiveCoverImage(String liveCoverImage) {
        this.liveCoverImage = liveCoverImage;
        return this;
    }
    public String getLiveCoverImage() {
        return this.liveCoverImage;
    }

    public StartCoursePrepareRequest setCourseDate(String courseDate) {
        this.courseDate = courseDate;
        return this;
    }
    public String getCourseDate() {
        return this.courseDate;
    }

    public StartCoursePrepareRequest setIsvCode(String isvCode) {
        this.isvCode = isvCode;
        return this;
    }
    public String getIsvCode() {
        return this.isvCode;
    }

    public StartCoursePrepareRequest setOpUserId(String opUserId) {
        this.opUserId = opUserId;
        return this;
    }
    public String getOpUserId() {
        return this.opUserId;
    }

}
