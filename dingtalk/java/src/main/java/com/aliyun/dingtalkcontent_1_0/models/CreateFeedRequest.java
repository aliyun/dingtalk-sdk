// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcontent_1_0.models;

import com.aliyun.tea.*;

public class CreateFeedRequest extends TeaModel {
    /**
     * <p>课程相关信息</p>
     */
    @NameInMap("courseInfo")
    public CreateFeedRequestCourseInfo courseInfo;

    /**
     * <p>发布者的用户Id</p>
     */
    @NameInMap("createUserId")
    public String createUserId;

    /**
     * <p>内容相关信息</p>
     */
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
        /**
         * <p>讲师头像链接</p>
         */
        @NameInMap("avatar")
        public String avatar;

        /**
         * <p>讲师用户名称</p>
         */
        @NameInMap("name")
        public String name;

        /**
         * <p>讲师用户Id</p>
         */
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
        /**
         * <p>客服头像链接</p>
         */
        @NameInMap("avatar")
        public String avatar;

        /**
         * <p>客服用户名称</p>
         */
        @NameInMap("name")
        public String name;

        /**
         * <p>客服用户Id</p>
         */
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
        /**
         * <p>打折结束的时间，时间戳精确到毫秒，时间为东八区时间</p>
         */
        @NameInMap("endTimeMillis")
        public Long endTimeMillis;

        /**
         * <p>打折时商品的价格，单位为分</p>
         */
        @NameInMap("price")
        public Long price;

        /**
         * <p>打折开始的时间，时间戳精确到毫秒，时间为东八区时间</p>
         */
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
        /**
         * <p>客服身份信息</p>
         */
        @NameInMap("csUserInfo")
        public CreateFeedRequestCourseInfoPayInfoCsUserInfo csUserInfo;

        /**
         * <p>课程打折信息</p>
         */
        @NameInMap("discountInfo")
        public CreateFeedRequestCourseInfoPayInfoDiscountInfo discountInfo;

        /**
         * <p>商品的默认情况下非打折时的价格，单位为分</p>
         */
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
        /**
         * <p>讲师身份信息</p>
         */
        @NameInMap("lectorUserInfo")
        public CreateFeedRequestCourseInfoLectorUserInfo lectorUserInfo;

        /**
         * <p>支付信息</p>
         */
        @NameInMap("payInfo")
        public CreateFeedRequestCourseInfoPayInfo payInfo;

        /**
         * <p>创建一个和该课程绑定的学习群和圈子</p>
         */
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
        /**
         * <p>媒体的mediaId，唯一对应oss中的一个视频或者音频</p>
         */
        @NameInMap("mediaId")
        public String mediaId;

        /**
         * <p>媒体的标题</p>
         */
        @NameInMap("title")
        public String title;

        /**
         * <p>媒体的类型，当前该接口只支持video和audio,2:视频,3:音频</p>
         */
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
        /**
         * <p>推荐物品的id，可以时feedId或者是微应用Id</p>
         */
        @NameInMap("objectId")
        public String objectId;

        /**
         * <p>推荐物品的类别,0:课程,1:微应用</p>
         */
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
        /**
         * <p>请求的行为，是保存还是发布,1为save，2为publish，是修改还是新建取决于feedId是否为空</p>
         */
        @NameInMap("actionType")
        public Integer actionType;

        /**
         * <p>版权所属:1：自有， 2.代理， 3.钉钉</p>
         */
        @NameInMap("belongsTo")
        public Integer belongsTo;

        /**
         * <p>内容分类，课程分类列表详情请见附录中的列表</p>
         */
        @NameInMap("feedCategory")
        public Long feedCategory;

        /**
         * <p>可选参数，当feedId不为null时，表示对当前课程进行修改，否则为新建一个课程</p>
         */
        @NameInMap("feedId")
        public String feedId;

        /**
         * <p>课程的文字标签</p>
         */
        @NameInMap("feedTag")
        public String feedTag;

        /**
         * <p>内容类别,限制只能使用4种类型：0：免费 4：平价 5：专栏 6：训练营</p>
         */
        @NameInMap("feedType")
        public Integer feedType;

        /**
         * <p>行业划分，决定了展示的页面的不同，例如学习中心下的职场、教育、商学院的划分,目前支持的行业id有：10001：职场学堂，10008：K12教育，10023：新职业，10024：钉钉培训</p>
         */
        @NameInMap("industryId")
        public Long industryId;

        /**
         * <p>课程的描述</p>
         */
        @NameInMap("introduction")
        public String introduction;

        /**
         * <p>课程简介用的图片</p>
         */
        @NameInMap("introductionPicUrl")
        public String introductionPicUrl;

        /**
         * <p>入驻账号Id(请联系钉钉接口同学获取)</p>
         */
        @NameInMap("mcnId")
        public String mcnId;

        /**
         * <p>一个课程下可以有多个视频或音频教程</p>
         */
        @NameInMap("mediaContents")
        public java.util.List<CreateFeedRequestFeedInfoMediaContents> mediaContents;

        /**
         * <p>推荐内容集合</p>
         */
        @NameInMap("recommends")
        public java.util.List<CreateFeedRequestFeedInfoRecommends> recommends;

        /**
         * <p>课程的封面Url</p>
         */
        @NameInMap("thumbUrl")
        public String thumbUrl;

        /**
         * <p>内容的标题（标题不能重复）</p>
         */
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
