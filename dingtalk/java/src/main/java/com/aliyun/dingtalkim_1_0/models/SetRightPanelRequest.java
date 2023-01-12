// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkim_1_0.models;

import com.aliyun.tea.*;

public class SetRightPanelRequest extends TeaModel {
    /**
     * <p>场景群的openConversationId</p>
     */
    @NameInMap("openConversationId")
    public String openConversationId;

    /**
     * <p>是否允许群成员关闭侧边栏 true-允许 false-不允许</p>
     */
    @NameInMap("rightPanelClosePermitted")
    public Boolean rightPanelClosePermitted;

    /**
     * <p>侧边栏打开状态 1-开启 0-关闭</p>
     */
    @NameInMap("rightPanelOpenStatus")
    public Integer rightPanelOpenStatus;

    /**
     * <p>标题栏文案</p>
     */
    @NameInMap("title")
    public String title;

    /**
     * <p>网页侧边栏属性配置</p>
     */
    @NameInMap("webWndParams")
    public SetRightPanelRequestWebWndParams webWndParams;

    /**
     * <p>侧边栏</p>
     */
    @NameInMap("width")
    public Integer width;

    public static SetRightPanelRequest build(java.util.Map<String, ?> map) throws Exception {
        SetRightPanelRequest self = new SetRightPanelRequest();
        return TeaModel.build(map, self);
    }

    public SetRightPanelRequest setOpenConversationId(String openConversationId) {
        this.openConversationId = openConversationId;
        return this;
    }
    public String getOpenConversationId() {
        return this.openConversationId;
    }

    public SetRightPanelRequest setRightPanelClosePermitted(Boolean rightPanelClosePermitted) {
        this.rightPanelClosePermitted = rightPanelClosePermitted;
        return this;
    }
    public Boolean getRightPanelClosePermitted() {
        return this.rightPanelClosePermitted;
    }

    public SetRightPanelRequest setRightPanelOpenStatus(Integer rightPanelOpenStatus) {
        this.rightPanelOpenStatus = rightPanelOpenStatus;
        return this;
    }
    public Integer getRightPanelOpenStatus() {
        return this.rightPanelOpenStatus;
    }

    public SetRightPanelRequest setTitle(String title) {
        this.title = title;
        return this;
    }
    public String getTitle() {
        return this.title;
    }

    public SetRightPanelRequest setWebWndParams(SetRightPanelRequestWebWndParams webWndParams) {
        this.webWndParams = webWndParams;
        return this;
    }
    public SetRightPanelRequestWebWndParams getWebWndParams() {
        return this.webWndParams;
    }

    public SetRightPanelRequest setWidth(Integer width) {
        this.width = width;
        return this;
    }
    public Integer getWidth() {
        return this.width;
    }

    public static class SetRightPanelRequestWebWndParams extends TeaModel {
        /**
         * <p>侧边栏URL</p>
         */
        @NameInMap("targetURL")
        public String targetURL;

        public static SetRightPanelRequestWebWndParams build(java.util.Map<String, ?> map) throws Exception {
            SetRightPanelRequestWebWndParams self = new SetRightPanelRequestWebWndParams();
            return TeaModel.build(map, self);
        }

        public SetRightPanelRequestWebWndParams setTargetURL(String targetURL) {
            this.targetURL = targetURL;
            return this;
        }
        public String getTargetURL() {
            return this.targetURL;
        }

    }

}
