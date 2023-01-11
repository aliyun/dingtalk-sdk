// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkmicro_app_1_0.models;

import com.aliyun.tea.*;

public class UpdateInnerAppRequest extends TeaModel {
    /**
     * <p>应用描述</p>
     */
    @NameInMap("desc")
    public String desc;

    /**
     * <p>应用首页地址</p>
     */
    @NameInMap("homepageLink")
    public String homepageLink;

    /**
     * <p>应用图标</p>
     */
    @NameInMap("icon")
    public String icon;

    /**
     * <p>服务器出口ip白名单</p>
     */
    @NameInMap("ipWhiteList")
    public java.util.List<String> ipWhiteList;

    /**
     * <p>应用名称</p>
     */
    @NameInMap("name")
    public String name;

    /**
     * <p>应用管理后台地址</p>
     */
    @NameInMap("ompLink")
    public String ompLink;

    /**
     * <p>创建人unionId</p>
     */
    @NameInMap("opUnionId")
    public String opUnionId;

    /**
     * <p>应用PC端地址</p>
     */
    @NameInMap("pcHomepageLink")
    public String pcHomepageLink;

    public static UpdateInnerAppRequest build(java.util.Map<String, ?> map) throws Exception {
        UpdateInnerAppRequest self = new UpdateInnerAppRequest();
        return TeaModel.build(map, self);
    }

    public UpdateInnerAppRequest setDesc(String desc) {
        this.desc = desc;
        return this;
    }
    public String getDesc() {
        return this.desc;
    }

    public UpdateInnerAppRequest setHomepageLink(String homepageLink) {
        this.homepageLink = homepageLink;
        return this;
    }
    public String getHomepageLink() {
        return this.homepageLink;
    }

    public UpdateInnerAppRequest setIcon(String icon) {
        this.icon = icon;
        return this;
    }
    public String getIcon() {
        return this.icon;
    }

    public UpdateInnerAppRequest setIpWhiteList(java.util.List<String> ipWhiteList) {
        this.ipWhiteList = ipWhiteList;
        return this;
    }
    public java.util.List<String> getIpWhiteList() {
        return this.ipWhiteList;
    }

    public UpdateInnerAppRequest setName(String name) {
        this.name = name;
        return this;
    }
    public String getName() {
        return this.name;
    }

    public UpdateInnerAppRequest setOmpLink(String ompLink) {
        this.ompLink = ompLink;
        return this;
    }
    public String getOmpLink() {
        return this.ompLink;
    }

    public UpdateInnerAppRequest setOpUnionId(String opUnionId) {
        this.opUnionId = opUnionId;
        return this;
    }
    public String getOpUnionId() {
        return this.opUnionId;
    }

    public UpdateInnerAppRequest setPcHomepageLink(String pcHomepageLink) {
        this.pcHomepageLink = pcHomepageLink;
        return this;
    }
    public String getPcHomepageLink() {
        return this.pcHomepageLink;
    }

}
