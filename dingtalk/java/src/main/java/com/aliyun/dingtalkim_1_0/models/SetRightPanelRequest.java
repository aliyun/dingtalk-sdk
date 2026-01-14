// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkim_1_0.models;

import com.aliyun.tea.*;

public class SetRightPanelRequest extends TeaModel {
    @NameInMap("forceExpand")
    public Boolean forceExpand;

    @NameInMap("isQtWnd")
    public Boolean isQtWnd;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>ciddjxhgdDXSAAXXXXX</p>
     */
    @NameInMap("openConversationId")
    public String openConversationId;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("rightPanelClosePermitted")
    public Boolean rightPanelClosePermitted;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>1</p>
     */
    @NameInMap("rightPanelOpenStatus")
    public Integer rightPanelOpenStatus;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>侧边栏标题</p>
     */
    @NameInMap("title")
    public String title;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("webWndParams")
    public SetRightPanelRequestWebWndParams webWndParams;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>500</p>
     */
    @NameInMap("width")
    public Integer width;

    public static SetRightPanelRequest build(java.util.Map<String, ?> map) throws Exception {
        SetRightPanelRequest self = new SetRightPanelRequest();
        return TeaModel.build(map, self);
    }

    public SetRightPanelRequest setForceExpand(Boolean forceExpand) {
        this.forceExpand = forceExpand;
        return this;
    }
    public Boolean getForceExpand() {
        return this.forceExpand;
    }

    public SetRightPanelRequest setIsQtWnd(Boolean isQtWnd) {
        this.isQtWnd = isQtWnd;
        return this;
    }
    public Boolean getIsQtWnd() {
        return this.isQtWnd;
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
         * <p>This parameter is required.</p>
         * 
         * <strong>example:</strong>
         * <p><a href="https://www.dingtalk.com/">https://www.dingtalk.com/</a></p>
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
