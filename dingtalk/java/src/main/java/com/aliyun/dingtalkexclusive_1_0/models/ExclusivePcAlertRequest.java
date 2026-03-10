// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkexclusive_1_0.models;

import com.aliyun.tea.*;

public class ExclusivePcAlertRequest extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("imageMediaId")
    public String imageMediaId;

    @NameInMap("openLink")
    public String openLink;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("userList")
    public java.util.List<String> userList;

    public static ExclusivePcAlertRequest build(java.util.Map<String, ?> map) throws Exception {
        ExclusivePcAlertRequest self = new ExclusivePcAlertRequest();
        return TeaModel.build(map, self);
    }

    public ExclusivePcAlertRequest setImageMediaId(String imageMediaId) {
        this.imageMediaId = imageMediaId;
        return this;
    }
    public String getImageMediaId() {
        return this.imageMediaId;
    }

    public ExclusivePcAlertRequest setOpenLink(String openLink) {
        this.openLink = openLink;
        return this;
    }
    public String getOpenLink() {
        return this.openLink;
    }

    public ExclusivePcAlertRequest setUserList(java.util.List<String> userList) {
        this.userList = userList;
        return this;
    }
    public java.util.List<String> getUserList() {
        return this.userList;
    }

}
