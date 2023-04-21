// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcontact_1_0.models;

import com.aliyun.tea.*;

public class GetCardInfoResponseBody extends TeaModel {
    /**
     * <p>用户角色</p>
     */
    @NameInMap("adminRole")
    public Long adminRole;

    /**
     * <p>头像</p>
     */
    @NameInMap("avatarUrl")
    public String avatarUrl;

    /**
     * <p>名片ID</p>
     */
    @NameInMap("cardId")
    public String cardId;

    /**
     * <p>扩展信息</p>
     */
    @NameInMap("extension")
    public GetCardInfoResponseBodyExtension extension;

    /**
     * <p>行业</p>
     */
    @NameInMap("industryName")
    public String industryName;

    /**
     * <p>个人介绍</p>
     */
    @NameInMap("introduce")
    public java.util.Map<String, ?> introduce;

    /**
     * <p>名字</p>
     */
    @NameInMap("name")
    public String name;

    /**
     * <p>组织名称</p>
     */
    @NameInMap("orgName")
    public String orgName;

    /**
     * <p>用户名片信息设置</p>
     */
    @NameInMap("settings")
    public java.util.Map<String, ?> settings;

    /**
     * <p>模板ID</p>
     */
    @NameInMap("templateId")
    public String templateId;

    /**
     * <p>职位</p>
     */
    @NameInMap("title")
    public String title;

    public static GetCardInfoResponseBody build(java.util.Map<String, ?> map) throws Exception {
        GetCardInfoResponseBody self = new GetCardInfoResponseBody();
        return TeaModel.build(map, self);
    }

    public GetCardInfoResponseBody setAdminRole(Long adminRole) {
        this.adminRole = adminRole;
        return this;
    }
    public Long getAdminRole() {
        return this.adminRole;
    }

    public GetCardInfoResponseBody setAvatarUrl(String avatarUrl) {
        this.avatarUrl = avatarUrl;
        return this;
    }
    public String getAvatarUrl() {
        return this.avatarUrl;
    }

    public GetCardInfoResponseBody setCardId(String cardId) {
        this.cardId = cardId;
        return this;
    }
    public String getCardId() {
        return this.cardId;
    }

    public GetCardInfoResponseBody setExtension(GetCardInfoResponseBodyExtension extension) {
        this.extension = extension;
        return this;
    }
    public GetCardInfoResponseBodyExtension getExtension() {
        return this.extension;
    }

    public GetCardInfoResponseBody setIndustryName(String industryName) {
        this.industryName = industryName;
        return this;
    }
    public String getIndustryName() {
        return this.industryName;
    }

    public GetCardInfoResponseBody setIntroduce(java.util.Map<String, ?> introduce) {
        this.introduce = introduce;
        return this;
    }
    public java.util.Map<String, ?> getIntroduce() {
        return this.introduce;
    }

    public GetCardInfoResponseBody setName(String name) {
        this.name = name;
        return this;
    }
    public String getName() {
        return this.name;
    }

    public GetCardInfoResponseBody setOrgName(String orgName) {
        this.orgName = orgName;
        return this;
    }
    public String getOrgName() {
        return this.orgName;
    }

    public GetCardInfoResponseBody setSettings(java.util.Map<String, ?> settings) {
        this.settings = settings;
        return this;
    }
    public java.util.Map<String, ?> getSettings() {
        return this.settings;
    }

    public GetCardInfoResponseBody setTemplateId(String templateId) {
        this.templateId = templateId;
        return this;
    }
    public String getTemplateId() {
        return this.templateId;
    }

    public GetCardInfoResponseBody setTitle(String title) {
        this.title = title;
        return this;
    }
    public String getTitle() {
        return this.title;
    }

    public static class GetCardInfoResponseBodyExtensionCardContactInfoAddressArea extends TeaModel {
        /**
         * <p>地区</p>
         */
        @NameInMap("region")
        public String region;

        /**
         * <p>地区详细数据</p>
         */
        @NameInMap("regionFullName")
        public String regionFullName;

        public static GetCardInfoResponseBodyExtensionCardContactInfoAddressArea build(java.util.Map<String, ?> map) throws Exception {
            GetCardInfoResponseBodyExtensionCardContactInfoAddressArea self = new GetCardInfoResponseBodyExtensionCardContactInfoAddressArea();
            return TeaModel.build(map, self);
        }

        public GetCardInfoResponseBodyExtensionCardContactInfoAddressArea setRegion(String region) {
            this.region = region;
            return this;
        }
        public String getRegion() {
            return this.region;
        }

        public GetCardInfoResponseBodyExtensionCardContactInfoAddressArea setRegionFullName(String regionFullName) {
            this.regionFullName = regionFullName;
            return this;
        }
        public String getRegionFullName() {
            return this.regionFullName;
        }

    }

    public static class GetCardInfoResponseBodyExtensionCardContactInfoAddress extends TeaModel {
        /**
         * <p>区域</p>
         */
        @NameInMap("area")
        public GetCardInfoResponseBodyExtensionCardContactInfoAddressArea area;

        /**
         * <p>详细地址</p>
         */
        @NameInMap("detail")
        public String detail;

        public static GetCardInfoResponseBodyExtensionCardContactInfoAddress build(java.util.Map<String, ?> map) throws Exception {
            GetCardInfoResponseBodyExtensionCardContactInfoAddress self = new GetCardInfoResponseBodyExtensionCardContactInfoAddress();
            return TeaModel.build(map, self);
        }

        public GetCardInfoResponseBodyExtensionCardContactInfoAddress setArea(GetCardInfoResponseBodyExtensionCardContactInfoAddressArea area) {
            this.area = area;
            return this;
        }
        public GetCardInfoResponseBodyExtensionCardContactInfoAddressArea getArea() {
            return this.area;
        }

        public GetCardInfoResponseBodyExtensionCardContactInfoAddress setDetail(String detail) {
            this.detail = detail;
            return this;
        }
        public String getDetail() {
            return this.detail;
        }

    }

    public static class GetCardInfoResponseBodyExtensionCardContactInfoEmail extends TeaModel {
        @NameInMap("label")
        public String label;

        @NameInMap("value")
        public String value;

        public static GetCardInfoResponseBodyExtensionCardContactInfoEmail build(java.util.Map<String, ?> map) throws Exception {
            GetCardInfoResponseBodyExtensionCardContactInfoEmail self = new GetCardInfoResponseBodyExtensionCardContactInfoEmail();
            return TeaModel.build(map, self);
        }

        public GetCardInfoResponseBodyExtensionCardContactInfoEmail setLabel(String label) {
            this.label = label;
            return this;
        }
        public String getLabel() {
            return this.label;
        }

        public GetCardInfoResponseBodyExtensionCardContactInfoEmail setValue(String value) {
            this.value = value;
            return this;
        }
        public String getValue() {
            return this.value;
        }

    }

    public static class GetCardInfoResponseBodyExtensionCardContactInfoLink extends TeaModel {
        @NameInMap("label")
        public String label;

        @NameInMap("value")
        public String value;

        public static GetCardInfoResponseBodyExtensionCardContactInfoLink build(java.util.Map<String, ?> map) throws Exception {
            GetCardInfoResponseBodyExtensionCardContactInfoLink self = new GetCardInfoResponseBodyExtensionCardContactInfoLink();
            return TeaModel.build(map, self);
        }

        public GetCardInfoResponseBodyExtensionCardContactInfoLink setLabel(String label) {
            this.label = label;
            return this;
        }
        public String getLabel() {
            return this.label;
        }

        public GetCardInfoResponseBodyExtensionCardContactInfoLink setValue(String value) {
            this.value = value;
            return this;
        }
        public String getValue() {
            return this.value;
        }

    }

    public static class GetCardInfoResponseBodyExtensionCardContactInfoTelephone extends TeaModel {
        @NameInMap("label")
        public String label;

        @NameInMap("value")
        public String value;

        public static GetCardInfoResponseBodyExtensionCardContactInfoTelephone build(java.util.Map<String, ?> map) throws Exception {
            GetCardInfoResponseBodyExtensionCardContactInfoTelephone self = new GetCardInfoResponseBodyExtensionCardContactInfoTelephone();
            return TeaModel.build(map, self);
        }

        public GetCardInfoResponseBodyExtensionCardContactInfoTelephone setLabel(String label) {
            this.label = label;
            return this;
        }
        public String getLabel() {
            return this.label;
        }

        public GetCardInfoResponseBodyExtensionCardContactInfoTelephone setValue(String value) {
            this.value = value;
            return this;
        }
        public String getValue() {
            return this.value;
        }

    }

    public static class GetCardInfoResponseBodyExtensionCardContactInfoWorkPhone extends TeaModel {
        @NameInMap("label")
        public String label;

        @NameInMap("value")
        public String value;

        public static GetCardInfoResponseBodyExtensionCardContactInfoWorkPhone build(java.util.Map<String, ?> map) throws Exception {
            GetCardInfoResponseBodyExtensionCardContactInfoWorkPhone self = new GetCardInfoResponseBodyExtensionCardContactInfoWorkPhone();
            return TeaModel.build(map, self);
        }

        public GetCardInfoResponseBodyExtensionCardContactInfoWorkPhone setLabel(String label) {
            this.label = label;
            return this;
        }
        public String getLabel() {
            return this.label;
        }

        public GetCardInfoResponseBodyExtensionCardContactInfoWorkPhone setValue(String value) {
            this.value = value;
            return this;
        }
        public String getValue() {
            return this.value;
        }

    }

    public static class GetCardInfoResponseBodyExtensionCardContactInfo extends TeaModel {
        /**
         * <p>地址</p>
         */
        @NameInMap("address")
        public java.util.List<GetCardInfoResponseBodyExtensionCardContactInfoAddress> address;

        /**
         * <p>邮箱</p>
         */
        @NameInMap("email")
        public java.util.List<GetCardInfoResponseBodyExtensionCardContactInfoEmail> email;

        /**
         * <p>微信</p>
         */
        @NameInMap("link")
        public java.util.List<GetCardInfoResponseBodyExtensionCardContactInfoLink> link;

        /**
         * <p>电话</p>
         */
        @NameInMap("telephone")
        public java.util.List<GetCardInfoResponseBodyExtensionCardContactInfoTelephone> telephone;

        @NameInMap("workPhone")
        public java.util.List<GetCardInfoResponseBodyExtensionCardContactInfoWorkPhone> workPhone;

        public static GetCardInfoResponseBodyExtensionCardContactInfo build(java.util.Map<String, ?> map) throws Exception {
            GetCardInfoResponseBodyExtensionCardContactInfo self = new GetCardInfoResponseBodyExtensionCardContactInfo();
            return TeaModel.build(map, self);
        }

        public GetCardInfoResponseBodyExtensionCardContactInfo setAddress(java.util.List<GetCardInfoResponseBodyExtensionCardContactInfoAddress> address) {
            this.address = address;
            return this;
        }
        public java.util.List<GetCardInfoResponseBodyExtensionCardContactInfoAddress> getAddress() {
            return this.address;
        }

        public GetCardInfoResponseBodyExtensionCardContactInfo setEmail(java.util.List<GetCardInfoResponseBodyExtensionCardContactInfoEmail> email) {
            this.email = email;
            return this;
        }
        public java.util.List<GetCardInfoResponseBodyExtensionCardContactInfoEmail> getEmail() {
            return this.email;
        }

        public GetCardInfoResponseBodyExtensionCardContactInfo setLink(java.util.List<GetCardInfoResponseBodyExtensionCardContactInfoLink> link) {
            this.link = link;
            return this;
        }
        public java.util.List<GetCardInfoResponseBodyExtensionCardContactInfoLink> getLink() {
            return this.link;
        }

        public GetCardInfoResponseBodyExtensionCardContactInfo setTelephone(java.util.List<GetCardInfoResponseBodyExtensionCardContactInfoTelephone> telephone) {
            this.telephone = telephone;
            return this;
        }
        public java.util.List<GetCardInfoResponseBodyExtensionCardContactInfoTelephone> getTelephone() {
            return this.telephone;
        }

        public GetCardInfoResponseBodyExtensionCardContactInfo setWorkPhone(java.util.List<GetCardInfoResponseBodyExtensionCardContactInfoWorkPhone> workPhone) {
            this.workPhone = workPhone;
            return this;
        }
        public java.util.List<GetCardInfoResponseBodyExtensionCardContactInfoWorkPhone> getWorkPhone() {
            return this.workPhone;
        }

    }

    public static class GetCardInfoResponseBodyExtension extends TeaModel {
        /**
         * <p>联系信息</p>
         */
        @NameInMap("cardContactInfo")
        public GetCardInfoResponseBodyExtensionCardContactInfo cardContactInfo;

        /**
         * <p>企业corpId</p>
         */
        @NameInMap("corpId")
        public String corpId;

        /**
         * <p>拍名片部门</p>
         */
        @NameInMap("department")
        public String department;

        /**
         * <p>企业是否认证</p>
         */
        @NameInMap("orgAuthed")
        public Boolean orgAuthed;

        /**
         * <p>企业LOGO</p>
         */
        @NameInMap("orgLogo")
        public String orgLogo;

        /**
         * <p>拍名片图片链接</p>
         */
        @NameInMap("originCardUrl")
        public String originCardUrl;

        /**
         * <p>分享文案</p>
         */
        @NameInMap("shareContent")
        public String shareContent;

        /**
         * <p>视频缩略图</p>
         */
        @NameInMap("thumbnailUrl")
        public String thumbnailUrl;

        /**
         * <p>视频文件名称</p>
         */
        @NameInMap("videoFileName")
        public String videoFileName;

        /**
         * <p>视频标题</p>
         */
        @NameInMap("videoTitle")
        public String videoTitle;

        /**
         * <p>视频链接</p>
         */
        @NameInMap("videoUrl")
        public String videoUrl;

        public static GetCardInfoResponseBodyExtension build(java.util.Map<String, ?> map) throws Exception {
            GetCardInfoResponseBodyExtension self = new GetCardInfoResponseBodyExtension();
            return TeaModel.build(map, self);
        }

        public GetCardInfoResponseBodyExtension setCardContactInfo(GetCardInfoResponseBodyExtensionCardContactInfo cardContactInfo) {
            this.cardContactInfo = cardContactInfo;
            return this;
        }
        public GetCardInfoResponseBodyExtensionCardContactInfo getCardContactInfo() {
            return this.cardContactInfo;
        }

        public GetCardInfoResponseBodyExtension setCorpId(String corpId) {
            this.corpId = corpId;
            return this;
        }
        public String getCorpId() {
            return this.corpId;
        }

        public GetCardInfoResponseBodyExtension setDepartment(String department) {
            this.department = department;
            return this;
        }
        public String getDepartment() {
            return this.department;
        }

        public GetCardInfoResponseBodyExtension setOrgAuthed(Boolean orgAuthed) {
            this.orgAuthed = orgAuthed;
            return this;
        }
        public Boolean getOrgAuthed() {
            return this.orgAuthed;
        }

        public GetCardInfoResponseBodyExtension setOrgLogo(String orgLogo) {
            this.orgLogo = orgLogo;
            return this;
        }
        public String getOrgLogo() {
            return this.orgLogo;
        }

        public GetCardInfoResponseBodyExtension setOriginCardUrl(String originCardUrl) {
            this.originCardUrl = originCardUrl;
            return this;
        }
        public String getOriginCardUrl() {
            return this.originCardUrl;
        }

        public GetCardInfoResponseBodyExtension setShareContent(String shareContent) {
            this.shareContent = shareContent;
            return this;
        }
        public String getShareContent() {
            return this.shareContent;
        }

        public GetCardInfoResponseBodyExtension setThumbnailUrl(String thumbnailUrl) {
            this.thumbnailUrl = thumbnailUrl;
            return this;
        }
        public String getThumbnailUrl() {
            return this.thumbnailUrl;
        }

        public GetCardInfoResponseBodyExtension setVideoFileName(String videoFileName) {
            this.videoFileName = videoFileName;
            return this;
        }
        public String getVideoFileName() {
            return this.videoFileName;
        }

        public GetCardInfoResponseBodyExtension setVideoTitle(String videoTitle) {
            this.videoTitle = videoTitle;
            return this;
        }
        public String getVideoTitle() {
            return this.videoTitle;
        }

        public GetCardInfoResponseBodyExtension setVideoUrl(String videoUrl) {
            this.videoUrl = videoUrl;
            return this;
        }
        public String getVideoUrl() {
            return this.videoUrl;
        }

    }

}
