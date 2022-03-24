// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcontact_1_0.models;

import com.aliyun.tea.*;

public class GetCardInfoResponseBody extends TeaModel {
    // 用户角色
    @NameInMap("adminRole")
    public Long adminRole;

    // 头像
    @NameInMap("avatarUrl")
    public String avatarUrl;

    // 名片ID
    @NameInMap("cardId")
    public String cardId;

    // 扩展信息
    @NameInMap("extension")
    public GetCardInfoResponseBodyExtension extension;

    // 行业
    @NameInMap("industryName")
    public String industryName;

    // 个人介绍
    @NameInMap("introduce")
    public java.util.Map<String, ?> introduce;

    // 名字
    @NameInMap("name")
    public String name;

    // 组织名称
    @NameInMap("orgName")
    public String orgName;

    // 用户名片信息设置
    @NameInMap("settings")
    public java.util.Map<String, ?> settings;

    // 模板ID
    @NameInMap("templateId")
    public String templateId;

    // 职位
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
        // 地区
        @NameInMap("region")
        public String region;

        // 地区详细数据
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
        // 区域
        @NameInMap("area")
        public GetCardInfoResponseBodyExtensionCardContactInfoAddressArea area;

        // 详细地址
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

    public static class GetCardInfoResponseBodyExtensionCardContactInfoWechat extends TeaModel {
        @NameInMap("label")
        public String label;

        @NameInMap("value")
        public String value;

        public static GetCardInfoResponseBodyExtensionCardContactInfoWechat build(java.util.Map<String, ?> map) throws Exception {
            GetCardInfoResponseBodyExtensionCardContactInfoWechat self = new GetCardInfoResponseBodyExtensionCardContactInfoWechat();
            return TeaModel.build(map, self);
        }

        public GetCardInfoResponseBodyExtensionCardContactInfoWechat setLabel(String label) {
            this.label = label;
            return this;
        }
        public String getLabel() {
            return this.label;
        }

        public GetCardInfoResponseBodyExtensionCardContactInfoWechat setValue(String value) {
            this.value = value;
            return this;
        }
        public String getValue() {
            return this.value;
        }

    }

    public static class GetCardInfoResponseBodyExtensionCardContactInfo extends TeaModel {
        // 地址
        @NameInMap("address")
        public java.util.List<GetCardInfoResponseBodyExtensionCardContactInfoAddress> address;

        // 邮箱
        @NameInMap("email")
        public java.util.List<GetCardInfoResponseBodyExtensionCardContactInfoEmail> email;

        // 电话
        @NameInMap("telephone")
        public java.util.List<GetCardInfoResponseBodyExtensionCardContactInfoTelephone> telephone;

        // 微信
        @NameInMap("wechat")
        public java.util.List<GetCardInfoResponseBodyExtensionCardContactInfoWechat> wechat;

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

        public GetCardInfoResponseBodyExtensionCardContactInfo setTelephone(java.util.List<GetCardInfoResponseBodyExtensionCardContactInfoTelephone> telephone) {
            this.telephone = telephone;
            return this;
        }
        public java.util.List<GetCardInfoResponseBodyExtensionCardContactInfoTelephone> getTelephone() {
            return this.telephone;
        }

        public GetCardInfoResponseBodyExtensionCardContactInfo setWechat(java.util.List<GetCardInfoResponseBodyExtensionCardContactInfoWechat> wechat) {
            this.wechat = wechat;
            return this;
        }
        public java.util.List<GetCardInfoResponseBodyExtensionCardContactInfoWechat> getWechat() {
            return this.wechat;
        }

    }

    public static class GetCardInfoResponseBodyExtension extends TeaModel {
        // 联系信息
        @NameInMap("cardContactInfo")
        public GetCardInfoResponseBodyExtensionCardContactInfo cardContactInfo;

        // 企业corpId
        @NameInMap("corpId")
        public String corpId;

        // 拍名片部门
        @NameInMap("department")
        public String department;

        // 企业认证等级
        @NameInMap("orgAuthLevel")
        public Long orgAuthLevel;

        // 企业是否认证
        @NameInMap("orgAuthed")
        public Boolean orgAuthed;

        // 企业LOGO
        @NameInMap("orgLogo")
        public String orgLogo;

        // 拍名片图片链接
        @NameInMap("originCardUrl")
        public String originCardUrl;

        // 分享文案
        @NameInMap("shareContent")
        public String shareContent;

        // 视频缩略图
        @NameInMap("thumbnailUrl")
        public String thumbnailUrl;

        // 视频文件名称
        @NameInMap("videoFileName")
        public String videoFileName;

        // 视频标题
        @NameInMap("videoTitle")
        public String videoTitle;

        // 视频链接
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

        public GetCardInfoResponseBodyExtension setOrgAuthLevel(Long orgAuthLevel) {
            this.orgAuthLevel = orgAuthLevel;
            return this;
        }
        public Long getOrgAuthLevel() {
            return this.orgAuthLevel;
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
