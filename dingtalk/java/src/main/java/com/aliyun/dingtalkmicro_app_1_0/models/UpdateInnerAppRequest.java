// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkmicro_app_1_0.models;

import com.aliyun.tea.*;

public class UpdateInnerAppRequest extends TeaModel {
    /**
     * <strong>example:</strong>
     * <p>descxxx</p>
     */
    @NameInMap("desc")
    public String desc;

    /**
     * <strong>example:</strong>
     * <p><a href="https://www.dingtalk.com">https://www.dingtalk.com</a></p>
     */
    @NameInMap("homepageLink")
    public String homepageLink;

    /**
     * <strong>example:</strong>
     * <p>mediaxxx</p>
     */
    @NameInMap("icon")
    public String icon;

    @NameInMap("ipWhiteList")
    public java.util.List<String> ipWhiteList;

    /**
     * <strong>example:</strong>
     * <p>namexx</p>
     */
    @NameInMap("name")
    public String name;

    /**
     * <strong>example:</strong>
     * <p><a href="https://www.dingtalk.com">https://www.dingtalk.com</a></p>
     */
    @NameInMap("ompLink")
    public String ompLink;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>xxxx</p>
     */
    @NameInMap("opUnionId")
    public String opUnionId;

    /**
     * <strong>example:</strong>
     * <p><a href="https://www.dingtalk.com">https://www.dingtalk.com</a></p>
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
