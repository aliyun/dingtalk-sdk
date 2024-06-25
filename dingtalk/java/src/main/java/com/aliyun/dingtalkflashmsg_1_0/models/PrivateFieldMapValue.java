// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkflashmsg_1_0.models;

import com.aliyun.tea.*;

public class PrivateFieldMapValue extends TeaModel {
    /**
     * <strong>example:</strong>
     * <p>XXX发了一条闪读消息，请于今天 12:00前查看</p>
     */
    @NameInMap("tipTitle")
    public String tipTitle;

    @NameInMap("isDingSend")
    public Boolean isDingSend;

    @NameInMap("isRead")
    public Boolean isRead;

    @NameInMap("buttonStatus")
    public String buttonStatus;

    @NameInMap("extension")
    public java.util.Map<String, String> extension;

    public static PrivateFieldMapValue build(java.util.Map<String, ?> map) throws Exception {
        PrivateFieldMapValue self = new PrivateFieldMapValue();
        return TeaModel.build(map, self);
    }

    public PrivateFieldMapValue setTipTitle(String tipTitle) {
        this.tipTitle = tipTitle;
        return this;
    }
    public String getTipTitle() {
        return this.tipTitle;
    }

    public PrivateFieldMapValue setIsDingSend(Boolean isDingSend) {
        this.isDingSend = isDingSend;
        return this;
    }
    public Boolean getIsDingSend() {
        return this.isDingSend;
    }

    public PrivateFieldMapValue setIsRead(Boolean isRead) {
        this.isRead = isRead;
        return this;
    }
    public Boolean getIsRead() {
        return this.isRead;
    }

    public PrivateFieldMapValue setButtonStatus(String buttonStatus) {
        this.buttonStatus = buttonStatus;
        return this;
    }
    public String getButtonStatus() {
        return this.buttonStatus;
    }

    public PrivateFieldMapValue setExtension(java.util.Map<String, String> extension) {
        this.extension = extension;
        return this;
    }
    public java.util.Map<String, String> getExtension() {
        return this.extension;
    }

}
