// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcontent_1_0.models;

import com.aliyun.tea.*;

public class CreateFeedRequest extends TeaModel {
    // 课程相关信息
    @NameInMap("courseInfo")
    public CreateFeedRequestCourseInfo courseInfo;

    // 内容相关信息
    @NameInMap("feedInfo")
    public CreateFeedRequestFeedInfo feedInfo;

    // 发布者的用户Id
    @NameInMap("createUserId")
    public String createUserId;

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

    public CreateFeedRequest setFeedInfo(CreateFeedRequestFeedInfo feedInfo) {
        this.feedInfo = feedInfo;
        return this;
    }
    public CreateFeedRequestFeedInfo getFeedInfo() {
        return this.feedInfo;
    }

    public CreateFeedRequest setCreateUserId(String createUserId) {
        this.createUserId = createUserId;
        return this;
    }
    public String getCreateUserId() {
        return this.createUserId;
    }

    public static class CreateFeedRequestCourseInfoLectorUserInfo extends TeaModel {
        // 讲师头像链接
        @NameInMap("avatar")
        public String avatar;

        // 讲师用户Id
        @NameInMap("userId")
        public String userId;

        // 讲师用户名称
        @NameInMap("name")
        public String name;

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

        public CreateFeedRequestCourseInfoLectorUserInfo setUserId(String userId) {
            this.userId = userId;
            return this;
        }
        public String getUserId() {
            return this.userId;
        }

        public CreateFeedRequestCourseInfoLectorUserInfo setName(String name) {
            this.name = name;
            return this;
        }
        public String getName() {
            return this.name;
        }

    }

    public static class CreateFeedRequestCourseInfoPayInfoCsUserInfo extends TeaModel {
        // 客服头像链接
        @NameInMap("avatar")
        public String avatar;

        // 客服用户Id
        @NameInMap("userId")
        public String userId;

        // 客服用户名称
        @NameInMap("name")
        public String name;

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

        public CreateFeedRequestCourseInfoPayInfoCsUserInfo setUserId(String userId) {
            this.userId = userId;
            return this;
        }
        public String getUserId() {
            return this.userId;
        }

        public CreateFeedRequestCourseInfoPayInfoCsUserInfo setName(String name) {
            this.name = name;
            return this;
        }
        public String getName() {
            return this.name;
        }

    }

    public static class CreateFeedRequestCourseInfoPayInfoDiscountInfo extends TeaModel {
        // 打折开始的时间，时间戳精确到毫秒，时间为东八区时间
        @NameInMap("startTimeMillis")
        public Long startTimeMillis;

        // 打折时商品的价格，单位为分
        @NameInMap("price")
        public Long price;

        // 打折结束的时间，时间戳精确到毫秒，时间为东八区时间
        @NameInMap("endTimeMillis")
        public Long endTimeMillis;

        public static CreateFeedRequestCourseInfoPayInfoDiscountInfo build(java.util.Map<String, ?> map) throws Exception {
            CreateFeedRequestCourseInfoPayInfoDiscountInfo self = new CreateFeedRequestCourseInfoPayInfoDiscountInfo();
            return TeaModel.build(map, self);
        }

        public CreateFeedRequestCourseInfoPayInfoDiscountInfo setStartTimeMillis(Long startTimeMillis) {
            this.startTimeMillis = startTimeMillis;
            return this;
        }
        public Long getStartTimeMillis() {
            return this.startTimeMillis;
        }

        public CreateFeedRequestCourseInfoPayInfoDiscountInfo setPrice(Long price) {
            this.price = price;
            return this;
        }
        public Long getPrice() {
            return this.price;
        }

        public CreateFeedRequestCourseInfoPayInfoDiscountInfo setEndTimeMillis(Long endTimeMillis) {
            this.endTimeMillis = endTimeMillis;
            return this;
        }
        public Long getEndTimeMillis() {
            return this.endTimeMillis;
        }

    }

    public static class CreateFeedRequestCourseInfoPayInfo extends TeaModel {
        // 客服身份信息
        @NameInMap("csUserInfo")
        public CreateFeedRequestCourseInfoPayInfoCsUserInfo csUserInfo;

        // 商品的默认情况下非打折时的价格，单位为分
        @NameInMap("price")
        public Long price;

        // 课程打折信息
        @NameInMap("discountInfo")
        public CreateFeedRequestCourseInfoPayInfoDiscountInfo discountInfo;

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

        public CreateFeedRequestCourseInfoPayInfo setPrice(Long price) {
            this.price = price;
            return this;
        }
        public Long getPrice() {
            return this.price;
        }

        public CreateFeedRequestCourseInfoPayInfo setDiscountInfo(CreateFeedRequestCourseInfoPayInfoDiscountInfo discountInfo) {
            this.discountInfo = discountInfo;
            return this;
        }
        public CreateFeedRequestCourseInfoPayInfoDiscountInfo getDiscountInfo() {
            return this.discountInfo;
        }

    }

    public static class CreateFeedRequestCourseInfo extends TeaModel {
        // 创建一个和该课程绑定的学习群和圈子
        @NameInMap("studyGroupName")
        public String studyGroupName;

        // 讲师身份信息
        @NameInMap("lectorUserInfo")
        public CreateFeedRequestCourseInfoLectorUserInfo lectorUserInfo;

        // 支付信息
        @NameInMap("payInfo")
        public CreateFeedRequestCourseInfoPayInfo payInfo;

        public static CreateFeedRequestCourseInfo build(java.util.Map<String, ?> map) throws Exception {
            CreateFeedRequestCourseInfo self = new CreateFeedRequestCourseInfo();
            return TeaModel.build(map, self);
        }

        public CreateFeedRequestCourseInfo setStudyGroupName(String studyGroupName) {
            this.studyGroupName = studyGroupName;
            return this;
        }
        public String getStudyGroupName() {
            return this.studyGroupName;
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

    }

    public static class CreateFeedRequestFeedInfoMediaContents extends TeaModel {
        // 媒体的类型，当前该接口只支持video和audio,2:视频,3:音频
        @NameInMap("type")
        public Integer type;

        // 媒体的mediaId，唯一对应oss中的一个视频或者音频
        @NameInMap("mediaId")
        public String mediaId;

        // 媒体的标题
        @NameInMap("title")
        public String title;

        public static CreateFeedRequestFeedInfoMediaContents build(java.util.Map<String, ?> map) throws Exception {
            CreateFeedRequestFeedInfoMediaContents self = new CreateFeedRequestFeedInfoMediaContents();
            return TeaModel.build(map, self);
        }

        public CreateFeedRequestFeedInfoMediaContents setType(Integer type) {
            this.type = type;
            return this;
        }
        public Integer getType() {
            return this.type;
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

    }

    public static class CreateFeedRequestFeedInfoRecommends extends TeaModel {
        // 推荐物品的类别,0:课程,1:微应用
        @NameInMap("type")
        public Integer type;

        // 推荐物品的id，可以时feedId或者是微应用Id
        @NameInMap("objectId")
        public String objectId;

        public static CreateFeedRequestFeedInfoRecommends build(java.util.Map<String, ?> map) throws Exception {
            CreateFeedRequestFeedInfoRecommends self = new CreateFeedRequestFeedInfoRecommends();
            return TeaModel.build(map, self);
        }

        public CreateFeedRequestFeedInfoRecommends setType(Integer type) {
            this.type = type;
            return this;
        }
        public Integer getType() {
            return this.type;
        }

        public CreateFeedRequestFeedInfoRecommends setObjectId(String objectId) {
            this.objectId = objectId;
            return this;
        }
        public String getObjectId() {
            return this.objectId;
        }

    }

    public static class CreateFeedRequestFeedInfo extends TeaModel {
        // 请求的行为，是保存还是发布,1为save，2为publish，是修改还是新建取决于feedId是否为空
        @NameInMap("actionType")
        public Integer actionType;

        // 一个课程下可以有多个视频或音频教程
        @NameInMap("mediaContents")
        public java.util.List<CreateFeedRequestFeedInfoMediaContents> mediaContents;

        // 内容分类，课程分类列表详情请见附录中的列表
        @NameInMap("feedCategory")
        public Long feedCategory;

        // 版权所属:1：自有， 2.代理， 3.钉钉
        @NameInMap("belongsTo")
        public Integer belongsTo;

        // 行业划分，决定了展示的页面的不同，例如学习中心下的职场、教育、商学院的划分,目前支持的行业id有：10001：职场学堂，10008：K12教育，10023：新职业，10024：钉钉培训
        @NameInMap("industryId")
        public Long industryId;

        // 课程的封面Url
        @NameInMap("thumbUrl")
        public String thumbUrl;

        // 推荐内容集合
        @NameInMap("recommends")
        public java.util.List<CreateFeedRequestFeedInfoRecommends> recommends;

        // 可选参数，当feedId不为null时，表示对当前课程进行修改，否则为新建一个课程
        @NameInMap("feedId")
        public String feedId;

        // 内容的标题（标题不能重复）
        @NameInMap("title")
        public String title;

        // 内容类别,限制只能使用4种类型：0：免费 4：平价 5：专栏 6：训练营
        @NameInMap("feedType")
        public Integer feedType;

        // 课程的描述
        @NameInMap("introduction")
        public String introduction;

        // 课程的文字标签
        @NameInMap("feedTag")
        public String feedTag;

        // 入驻账号Id(请联系钉钉接口同学获取)
        @NameInMap("mcnId")
        public String mcnId;

        // 课程简介用的图片
        @NameInMap("introductionPicUrl")
        public String introductionPicUrl;

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

        public CreateFeedRequestFeedInfo setMediaContents(java.util.List<CreateFeedRequestFeedInfoMediaContents> mediaContents) {
            this.mediaContents = mediaContents;
            return this;
        }
        public java.util.List<CreateFeedRequestFeedInfoMediaContents> getMediaContents() {
            return this.mediaContents;
        }

        public CreateFeedRequestFeedInfo setFeedCategory(Long feedCategory) {
            this.feedCategory = feedCategory;
            return this;
        }
        public Long getFeedCategory() {
            return this.feedCategory;
        }

        public CreateFeedRequestFeedInfo setBelongsTo(Integer belongsTo) {
            this.belongsTo = belongsTo;
            return this;
        }
        public Integer getBelongsTo() {
            return this.belongsTo;
        }

        public CreateFeedRequestFeedInfo setIndustryId(Long industryId) {
            this.industryId = industryId;
            return this;
        }
        public Long getIndustryId() {
            return this.industryId;
        }

        public CreateFeedRequestFeedInfo setThumbUrl(String thumbUrl) {
            this.thumbUrl = thumbUrl;
            return this;
        }
        public String getThumbUrl() {
            return this.thumbUrl;
        }

        public CreateFeedRequestFeedInfo setRecommends(java.util.List<CreateFeedRequestFeedInfoRecommends> recommends) {
            this.recommends = recommends;
            return this;
        }
        public java.util.List<CreateFeedRequestFeedInfoRecommends> getRecommends() {
            return this.recommends;
        }

        public CreateFeedRequestFeedInfo setFeedId(String feedId) {
            this.feedId = feedId;
            return this;
        }
        public String getFeedId() {
            return this.feedId;
        }

        public CreateFeedRequestFeedInfo setTitle(String title) {
            this.title = title;
            return this;
        }
        public String getTitle() {
            return this.title;
        }

        public CreateFeedRequestFeedInfo setFeedType(Integer feedType) {
            this.feedType = feedType;
            return this;
        }
        public Integer getFeedType() {
            return this.feedType;
        }

        public CreateFeedRequestFeedInfo setIntroduction(String introduction) {
            this.introduction = introduction;
            return this;
        }
        public String getIntroduction() {
            return this.introduction;
        }

        public CreateFeedRequestFeedInfo setFeedTag(String feedTag) {
            this.feedTag = feedTag;
            return this;
        }
        public String getFeedTag() {
            return this.feedTag;
        }

        public CreateFeedRequestFeedInfo setMcnId(String mcnId) {
            this.mcnId = mcnId;
            return this;
        }
        public String getMcnId() {
            return this.mcnId;
        }

        public CreateFeedRequestFeedInfo setIntroductionPicUrl(String introductionPicUrl) {
            this.introductionPicUrl = introductionPicUrl;
            return this;
        }
        public String getIntroductionPicUrl() {
            return this.introductionPicUrl;
        }

    }

}
