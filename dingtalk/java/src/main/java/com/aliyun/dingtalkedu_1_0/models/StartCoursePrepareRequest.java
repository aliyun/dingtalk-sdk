// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkedu_1_0.models;

import com.aliyun.tea.*;

public class StartCoursePrepareRequest extends TeaModel {
    /**
     * <strong>example:</strong>
     * <p>2021-11-16</p>
     */
    @NameInMap("courseDate")
    public String courseDate;

    /**
     * <strong>example:</strong>
     * <p>course1</p>
     */
    @NameInMap("courseGroupCode")
    public String courseGroupCode;

    /**
     * <strong>example:</strong>
     * <p>device1</p>
     */
    @NameInMap("deviceId")
    public String deviceId;

    /**
     * <strong>example:</strong>
     * <p>extNumber</p>
     */
    @NameInMap("ext")
    public String ext;

    /**
     * <strong>example:</strong>
     * <p>DDISV</p>
     */
    @NameInMap("isvCode")
    public String isvCode;

    /**
     * <strong>example:</strong>
     * <p>&quot;&quot;</p>
     */
    @NameInMap("liveCoverImage")
    public String liveCoverImage;

    @NameInMap("sectionIndex")
    public java.util.List<Integer> sectionIndex;

    /**
     * <strong>example:</strong>
     * <p>manger1234</p>
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
