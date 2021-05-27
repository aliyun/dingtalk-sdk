// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkmicro_app_1_0.models;

import com.aliyun.tea.*;

public class UpdateInnerAppRequest extends TeaModel {
    // 创建人unionId
    @NameInMap("opUnionId")
    public String opUnionId;

    // 关联组织corpId
    @NameInMap("ecologicalCorpId")
    public String ecologicalCorpId;

    // 应用名称
    @NameInMap("name")
    public String name;

    // 应用描述
    @NameInMap("desc")
    public String desc;

    // 应用图标
    @NameInMap("icon")
    public String icon;

    // 应用首页地址
    @NameInMap("homepageLink")
    public String homepageLink;

    // 应用PC端地址
    @NameInMap("pcHomepageLink")
    public String pcHomepageLink;

    // 应用管理后台地址
    @NameInMap("ompLink")
    public String ompLink;

    // 服务器出口ip白名单
    @NameInMap("ipWhiteList")
    public java.util.List<String> ipWhiteList;

    public static UpdateInnerAppRequest build(java.util.Map<String, ?> map) throws Exception {
        UpdateInnerAppRequest self = new UpdateInnerAppRequest();
        return TeaModel.build(map, self);
    }

    public UpdateInnerAppRequest setOpUnionId(String opUnionId) {
        this.opUnionId = opUnionId;
        return this;
    }
    public String getOpUnionId() {
        return this.opUnionId;
    }

    public UpdateInnerAppRequest setEcologicalCorpId(String ecologicalCorpId) {
        this.ecologicalCorpId = ecologicalCorpId;
        return this;
    }
    public String getEcologicalCorpId() {
        return this.ecologicalCorpId;
    }

    public UpdateInnerAppRequest setName(String name) {
        this.name = name;
        return this;
    }
    public String getName() {
        return this.name;
    }

    public UpdateInnerAppRequest setDesc(String desc) {
        this.desc = desc;
        return this;
    }
    public String getDesc() {
        return this.desc;
    }

    public UpdateInnerAppRequest setIcon(String icon) {
        this.icon = icon;
        return this;
    }
    public String getIcon() {
        return this.icon;
    }

    public UpdateInnerAppRequest setHomepageLink(String homepageLink) {
        this.homepageLink = homepageLink;
        return this;
    }
    public String getHomepageLink() {
        return this.homepageLink;
    }

    public UpdateInnerAppRequest setPcHomepageLink(String pcHomepageLink) {
        this.pcHomepageLink = pcHomepageLink;
        return this;
    }
    public String getPcHomepageLink() {
        return this.pcHomepageLink;
    }

    public UpdateInnerAppRequest setOmpLink(String ompLink) {
        this.ompLink = ompLink;
        return this;
    }
    public String getOmpLink() {
        return this.ompLink;
    }

    public UpdateInnerAppRequest setIpWhiteList(java.util.List<String> ipWhiteList) {
        this.ipWhiteList = ipWhiteList;
        return this;
    }
    public java.util.List<String> getIpWhiteList() {
        return this.ipWhiteList;
    }

}
