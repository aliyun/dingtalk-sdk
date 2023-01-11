// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkedu_1_0.models;

import com.aliyun.tea.*;

public class StartCoursePrepareRequest extends TeaModel {
    /**
     * <p>上课日期</p>
     */
    @NameInMap("courseDate")
    public String courseDate;

    /**
     * <p>课程组编号</p>
     */
    @NameInMap("courseGroupCode")
    public String courseGroupCode;

    /**
     * <p>设备id</p>
     */
    @NameInMap("deviceId")
    public String deviceId;

    /**
     * <p>拓展信息</p>
     */
    @NameInMap("ext")
    public String ext;

    /**
     * <p>isv编号</p>
     */
    @NameInMap("isvCode")
    public String isvCode;

    /**
     * <p>封面url</p>
     */
    @NameInMap("liveCoverImage")
    public String liveCoverImage;

    /**
     * <p>课节信息</p>
     */
    @NameInMap("sectionIndex")
    public java.util.List<Integer> sectionIndex;

    /**
     * <p>操作人</p>
     */
    @NameInMap("opUserId")
    public String opUserId;

    public static StartCoursePrepareRequest build(java.util.Map<String, ?> map) throws Exception {
        StartCoursePrepareRequest self = new StartCoursePrepareRequest();
        return TeaModel.build(map, self);
    }

    public StartCoursePrepareRequest setCourseDate(String courseDate) {
        this.courseDate = courseDate;
        return this;
    }
    public String getCourseDate() {
        return this.courseDate;
    }

    public StartCoursePrepareRequest setCourseGroupCode(String courseGroupCode) {
        this.courseGroupCode = courseGroupCode;
        return this;
    }
    public String getCourseGroupCode() {
        return this.courseGroupCode;
    }

    public StartCoursePrepareRequest setDeviceId(String deviceId) {
        this.deviceId = deviceId;
        return this;
    }
    public String getDeviceId() {
        return this.deviceId;
    }

    public StartCoursePrepareRequest setExt(String ext) {
        this.ext = ext;
        return this;
    }
    public String getExt() {
        return this.ext;
    }

    public StartCoursePrepareRequest setIsvCode(String isvCode) {
        this.isvCode = isvCode;
        return this;
    }
    public String getIsvCode() {
        return this.isvCode;
    }

    public StartCoursePrepareRequest setLiveCoverImage(String liveCoverImage) {
        this.liveCoverImage = liveCoverImage;
        return this;
    }
    public String getLiveCoverImage() {
        return this.liveCoverImage;
    }

    public StartCoursePrepareRequest setSectionIndex(java.util.List<Integer> sectionIndex) {
        this.sectionIndex = sectionIndex;
        return this;
    }
    public java.util.List<Integer> getSectionIndex() {
        return this.sectionIndex;
    }

    public StartCoursePrepareRequest setOpUserId(String opUserId) {
        this.opUserId = opUserId;
        return this;
    }
    public String getOpUserId() {
        return this.opUserId;
    }

}
