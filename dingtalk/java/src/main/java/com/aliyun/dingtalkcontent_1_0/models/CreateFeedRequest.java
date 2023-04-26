// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcontent_1_0.models;

import com.aliyun.tea.*;

public class CreateFeedRequest extends TeaModel {
    @NameInMap("courseInfo")
    public CreateFeedRequestCourseInfo courseInfo;

    @NameInMap("createUserId")
    public String createUserId;

    @NameInMap("feedInfo")
    public CreateFeedRequestFeedInfo feedInfo;

    public static CreateFeedRequest build(java.util.Map<String, ?> map) throws Exception {
        CreateFeedRequest self = new CreateFeedRequest();
        return TeaModel.build(map, self);
    }

    public CreateFeedRequest setCourseInfo(CreateFeedRequestCourseInfo courseInfo) {
        this.courseInfo = courseInfo;
        return this;
    }
    public CreateFeedRequestCourseInfo getCourseInfo() {
        return this.courseInfo;
    }

    public CreateFeedRequest setCreateUserId(String createUserId) {
        this.createUserId = createUserId;
        return this;
    }
    public String getCreateUserId() {
        return this.createUserId;
    }

    public CreateFeedRequest setFeedInfo(CreateFeedRequestFeedInfo feedInfo) {
        this.feedInfo = feedInfo;
        return this;
    }
    public CreateFeedRequestFeedInfo getFeedInfo() {
        return this.feedInfo;
    }

    public static class CreateFeedRequestCourseInfoLectorUserInfo extends TeaModel {
        @NameInMap("avatar")
        public String avatar;

        @NameInMap("name")
        public String name;

        @NameInMap("userId")
        public String userId;

        public static CreateFeedRequestCourseInfoLectorUserInfo build(java.util.Map<String, ?> map) throws Exception {
            CreateFeedRequestCourseInfoLectorUserInfo self = new CreateFeedRequestCourseInfoLectorUserInfo();
            return TeaModel.build(map, self);
        }

        public CreateFeedRequestCourseInfoLectorUserInfo setAvatar(String avatar) {
            this.avatar = avatar;
            return this;
        }
        public String getAvatar() {
            return this.avatar;
        }

        public CreateFeedRequestCourseInfoLectorUserInfo setName(String name) {
            this.name = name;
            return this;
        }
        public String getName() {
            return this.name;
        }

        public CreateFeedRequestCourseInfoLectorUserInfo setUserId(String userId) {
            this.userId = userId;
            return this;
        }
        public String getUserId() {
            return this.userId;
        }

    }

    public static class CreateFeedRequestCourseInfoPayInfoCsUserInfo extends TeaModel {
        @NameInMap("avatar")
        public String avatar;

        @NameInMap("name")
        public String name;

        @NameInMap("userId")
        public String userId;

        public static CreateFeedRequestCourseInfoPayInfoCsUserInfo build(java.util.Map<String, ?> map) throws Exception {
            CreateFeedRequestCourseInfoPayInfoCsUserInfo self = new CreateFeedRequestCourseInfoPayInfoCsUserInfo();
            return TeaModel.build(map, self);
        }

        public CreateFeedRequestCourseInfoPayInfoCsUserInfo setAvatar(String avatar) {
            this.avatar = avatar;
            return this;
        }
        public String getAvatar() {
            return this.avatar;
        }

        public CreateFeedRequestCourseInfoPayInfoCsUserInfo setName(String name) {
            this.name = name;
            return this;
        }
        public String getName() {
            return this.name;
        }

        public CreateFeedRequestCourseInfoPayInfoCsUserInfo setUserId(String userId) {
            this.userId = userId;
            return this;
        }
        public String getUserId() {
            return this.userId;
        }

    }

    public static class CreateFeedRequestCourseInfoPayInfoDiscountInfo extends TeaModel {
        @NameInMap("endTimeMillis")
        public Long endTimeMillis;

        @NameInMap("price")
        public Long price;

        @NameInMap("startTimeMillis")
        public Long startTimeMillis;

        public static CreateFeedRequestCourseInfoPayInfoDiscountInfo build(java.util.Map<String, ?> map) throws Exception {
            CreateFeedRequestCourseInfoPayInfoDiscountInfo self = new CreateFeedRequestCourseInfoPayInfoDiscountInfo();
            return TeaModel.build(map, self);
        }

        public CreateFeedRequestCourseInfoPayInfoDiscountInfo setEndTimeMillis(Long endTimeMillis) {
            this.endTimeMillis = endTimeMillis;
            return this;
        }
        public Long getEndTimeMillis() {
            return this.endTimeMillis;
        }

        public CreateFeedRequestCourseInfoPayInfoDiscountInfo setPrice(Long price) {
            this.price = price;
            return this;
        }
        public Long getPrice() {
            return this.price;
        }

        public CreateFeedRequestCourseInfoPayInfoDiscountInfo setStartTimeMillis(Long startTimeMillis) {
            this.startTimeMillis = startTimeMillis;
            return this;
        }
        public Long getStartTimeMillis() {
            return this.startTimeMillis;
        }

    }

    public static class CreateFeedRequestCourseInfoPayInfo extends TeaModel {
        @NameInMap("csUserInfo")
        public CreateFeedRequestCourseInfoPayInfoCsUserInfo csUserInfo;

        @NameInMap("discountInfo")
        public CreateFeedRequestCourseInfoPayInfoDiscountInfo discountInfo;

        @NameInMap("price")
        public Long price;

        public static CreateFeedRequestCourseInfoPayInfo build(java.util.Map<String, ?> map) throws Exception {
            CreateFeedRequestCourseInfoPayInfo self = new CreateFeedRequestCourseInfoPayInfo();
            return TeaModel.build(map, self);
        }

        public CreateFeedRequestCourseInfoPayInfo setCsUserInfo(CreateFeedRequestCourseInfoPayInfoCsUserInfo csUserInfo) {
            this.csUserInfo = csUserInfo;
            return this;
        }
        public CreateFeedRequestCourseInfoPayInfoCsUserInfo getCsUserInfo() {
            return this.csUserInfo;
        }

        public CreateFeedRequestCourseInfoPayInfo setDiscountInfo(CreateFeedRequestCourseInfoPayInfoDiscountInfo discountInfo) {
            this.discountInfo = discountInfo;
            return this;
        }
        public CreateFeedRequestCourseInfoPayInfoDiscountInfo getDiscountInfo() {
            return this.discountInfo;
        }

        public CreateFeedRequestCourseInfoPayInfo setPrice(Long price) {
            this.price = price;
            return this;
        }
        public Long getPrice() {
            return this.price;
        }

    }

    public static class CreateFeedRequestCourseInfo extends TeaModel {
        @NameInMap("lectorUserInfo")
        public CreateFeedRequestCourseInfoLectorUserInfo lectorUserInfo;

        @NameInMap("payInfo")
        public CreateFeedRequestCourseInfoPayInfo payInfo;

        @NameInMap("studyGroupName")
        public String studyGroupName;

        public static CreateFeedRequestCourseInfo build(java.util.Map<String, ?> map) throws Exception {
            CreateFeedRequestCourseInfo self = new CreateFeedRequestCourseInfo();
            return TeaModel.build(map, self);
        }

        public CreateFeedRequestCourseInfo setLectorUserInfo(CreateFeedRequestCourseInfoLectorUserInfo lectorUserInfo) {
            this.lectorUserInfo = lectorUserInfo;
            return this;
        }
        public CreateFeedRequestCourseInfoLectorUserInfo getLectorUserInfo() {
            return this.lectorUserInfo;
        }

        public CreateFeedRequestCourseInfo setPayInfo(CreateFeedRequestCourseInfoPayInfo payInfo) {
            this.payInfo = payInfo;
            return this;
        }
        public CreateFeedRequestCourseInfoPayInfo getPayInfo() {
            return this.payInfo;
        }

        public CreateFeedRequestCourseInfo setStudyGroupName(String studyGroupName) {
            this.studyGroupName = studyGroupName;
            return this;
        }
        public String getStudyGroupName() {
            return this.studyGroupName;
        }

    }

    public static class CreateFeedRequestFeedInfoMediaContents extends TeaModel {
        @NameInMap("mediaId")
        public String mediaId;

        @NameInMap("title")
        public String title;

        @NameInMap("type")
        public Integer type;

        public static CreateFeedRequestFeedInfoMediaContents build(java.util.Map<String, ?> map) throws Exception {
            CreateFeedRequestFeedInfoMediaContents self = new CreateFeedRequestFeedInfoMediaContents();
            return TeaModel.build(map, self);
        }

        public CreateFeedRequestFeedInfoMediaContents setMediaId(String mediaId) {
            this.mediaId = mediaId;
            return this;
        }
        public String getMediaId() {
            return this.mediaId;
        }

        public CreateFeedRequestFeedInfoMediaContents setTitle(String title) {
            this.title = title;
            return this;
        }
        public String getTitle() {
            return this.title;
        }

        public CreateFeedRequestFeedInfoMediaContents setType(Integer type) {
            this.type = type;
            return this;
        }
        public Integer getType() {
            return this.type;
        }

    }

    public static class CreateFeedRequestFeedInfoRecommends extends TeaModel {
        @NameInMap("objectId")
        public String objectId;

        @NameInMap("type")
        public Integer type;

        public static CreateFeedRequestFeedInfoRecommends build(java.util.Map<String, ?> map) throws Exception {
            CreateFeedRequestFeedInfoRecommends self = new CreateFeedRequestFeedInfoRecommends();
            return TeaModel.build(map, self);
        }

        public CreateFeedRequestFeedInfoRecommends setObjectId(String objectId) {
            this.objectId = objectId;
            return this;
        }
        public String getObjectId() {
            return this.objectId;
        }

        public CreateFeedRequestFeedInfoRecommends setType(Integer type) {
            this.type = type;
            return this;
        }
        public Integer getType() {
            return this.type;
        }

    }

    public static class CreateFeedRequestFeedInfo extends TeaModel {
        @NameInMap("actionType")
        public Integer actionType;

        @NameInMap("belongsTo")
        public Integer belongsTo;

        @NameInMap("feedCategory")
        public Long feedCategory;

        @NameInMap("feedId")
        public String feedId;

        @NameInMap("feedTag")
        public String feedTag;

        @NameInMap("feedType")
        public Integer feedType;

        @NameInMap("industryId")
        public Long industryId;

        @NameInMap("introduction")
        public String introduction;

        @NameInMap("introductionPicUrl")
        public String introductionPicUrl;

        @NameInMap("mcnId")
        public String mcnId;

        @NameInMap("mediaContents")
        public java.util.List<CreateFeedRequestFeedInfoMediaContents> mediaContents;

        @NameInMap("recommends")
        public java.util.List<CreateFeedRequestFeedInfoRecommends> recommends;

        @NameInMap("thumbUrl")
        public String thumbUrl;

        @NameInMap("title")
        public String title;

        public static CreateFeedRequestFeedInfo build(java.util.Map<String, ?> map) throws Exception {
            CreateFeedRequestFeedInfo self = new CreateFeedRequestFeedInfo();
            return TeaModel.build(map, self);
        }

        public CreateFeedRequestFeedInfo setActionType(Integer actionType) {
            this.actionType = actionType;
            return this;
        }
        public Integer getActionType() {
            return this.actionType;
        }

        public CreateFeedRequestFeedInfo setBelongsTo(Integer belongsTo) {
            this.belongsTo = belongsTo;
            return this;
        }
        public Integer getBelongsTo() {
            return this.belongsTo;
        }

        public CreateFeedRequestFeedInfo setFeedCategory(Long feedCategory) {
            this.feedCategory = feedCategory;
            return this;
        }
        public Long getFeedCategory() {
            return this.feedCategory;
        }

        public CreateFeedRequestFeedInfo setFeedId(String feedId) {
            this.feedId = feedId;
            return this;
        }
        public String getFeedId() {
            return this.feedId;
        }

        public CreateFeedRequestFeedInfo setFeedTag(String feedTag) {
            this.feedTag = feedTag;
            return this;
        }
        public String getFeedTag() {
            return this.feedTag;
        }

        public CreateFeedRequestFeedInfo setFeedType(Integer feedType) {
            this.feedType = feedType;
            return this;
        }
        public Integer getFeedType() {
            return this.feedType;
        }

        public CreateFeedRequestFeedInfo setIndustryId(Long industryId) {
            this.industryId = industryId;
            return this;
        }
        public Long getIndustryId() {
            return this.industryId;
        }

        public CreateFeedRequestFeedInfo setIntroduction(String introduction) {
            this.introduction = introduction;
            return this;
        }
        public String getIntroduction() {
            return this.introduction;
        }

        public CreateFeedRequestFeedInfo setIntroductionPicUrl(String introductionPicUrl) {
            this.introductionPicUrl = introductionPicUrl;
            return this;
        }
        public String getIntroductionPicUrl() {
            return this.introductionPicUrl;
        }

        public CreateFeedRequestFeedInfo setMcnId(String mcnId) {
            this.mcnId = mcnId;
            return this;
        }
        public String getMcnId() {
            return this.mcnId;
        }

        public CreateFeedRequestFeedInfo setMediaContents(java.util.List<CreateFeedRequestFeedInfoMediaContents> mediaContents) {
            this.mediaContents = mediaContents;
            return this;
        }
        public java.util.List<CreateFeedRequestFeedInfoMediaContents> getMediaContents() {
            return this.mediaContents;
        }

        public CreateFeedRequestFeedInfo setRecommends(java.util.List<CreateFeedRequestFeedInfoRecommends> recommends) {
            this.recommends = recommends;
            return this;
        }
        public java.util.List<CreateFeedRequestFeedInfoRecommends> getRecommends() {
            return this.recommends;
        }

        public CreateFeedRequestFeedInfo setThumbUrl(String thumbUrl) {
            this.thumbUrl = thumbUrl;
            return this;
        }
        public String getThumbUrl() {
            return this.thumbUrl;
        }

        public CreateFeedRequestFeedInfo setTitle(String title) {
            this.title = title;
            return this;
        }
        public String getTitle() {
            return this.title;
        }

    }

}
