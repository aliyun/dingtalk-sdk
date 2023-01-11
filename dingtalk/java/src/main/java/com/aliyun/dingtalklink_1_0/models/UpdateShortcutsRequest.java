// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalklink_1_0.models;

import com.aliyun.tea.*;

public class UpdateShortcutsRequest extends TeaModel {
    /**
     * <p>配置详情</p>
     */
    @NameInMap("details")
    public java.util.List<UpdateShortcutsRequestDetails> details;

    /**
     * <p>会话id</p>
     */
    @NameInMap("sessionId")
    public String sessionId;

    /**
     * <p>用户信息</p>
     */
    @NameInMap("userId")
    public String userId;

    public static UpdateShortcutsRequest build(java.util.Map<String, ?> map) throws Exception {
        UpdateShortcutsRequest self = new UpdateShortcutsRequest();
        return TeaModel.build(map, self);
    }

    public UpdateShortcutsRequest setDetails(java.util.List<UpdateShortcutsRequestDetails> details) {
        this.details = details;
        return this;
    }
    public java.util.List<UpdateShortcutsRequestDetails> getDetails() {
        return this.details;
    }

    public UpdateShortcutsRequest setSessionId(String sessionId) {
        this.sessionId = sessionId;
        return this;
    }
    public String getSessionId() {
        return this.sessionId;
    }

    public UpdateShortcutsRequest setUserId(String userId) {
        this.userId = userId;
        return this;
    }
    public String getUserId() {
        return this.userId;
    }

    public static class UpdateShortcutsRequestDetails extends TeaModel {
        /**
         * <p>跳转链接</p>
         */
        @NameInMap("actionUrl")
        public String actionUrl;

        /**
         * <p>windows侧边栏图标的unicode</p>
         */
        @NameInMap("iconFont")
        public String iconFont;

        /**
         * <p>移动端图标</p>
         */
        @NameInMap("iconMediaId")
        public String iconMediaId;

        /**
         * <p>插件唯一标识</p>
         */
        @NameInMap("shortcutId")
        public String shortcutId;

        /**
         * <p>适配mac端侧边栏图标的mediaId</p>
         */
        @NameInMap("slideIconMediaId")
        public String slideIconMediaId;

        /**
         * <p>插件标题</p>
         */
        @NameInMap("title")
        public String title;

        public static UpdateShortcutsRequestDetails build(java.util.Map<String, ?> map) throws Exception {
            UpdateShortcutsRequestDetails self = new UpdateShortcutsRequestDetails();
            return TeaModel.build(map, self);
        }

        public UpdateShortcutsRequestDetails setActionUrl(String actionUrl) {
            this.actionUrl = actionUrl;
            return this;
        }
        public String getActionUrl() {
            return this.actionUrl;
        }

        public UpdateShortcutsRequestDetails setIconFont(String iconFont) {
            this.iconFont = iconFont;
            return this;
        }
        public String getIconFont() {
            return this.iconFont;
        }

        public UpdateShortcutsRequestDetails setIconMediaId(String iconMediaId) {
            this.iconMediaId = iconMediaId;
            return this;
        }
        public String getIconMediaId() {
            return this.iconMediaId;
        }

        public UpdateShortcutsRequestDetails setShortcutId(String shortcutId) {
            this.shortcutId = shortcutId;
            return this;
        }
        public String getShortcutId() {
            return this.shortcutId;
        }

        public UpdateShortcutsRequestDetails setSlideIconMediaId(String slideIconMediaId) {
            this.slideIconMediaId = slideIconMediaId;
            return this;
        }
        public String getSlideIconMediaId() {
            return this.slideIconMediaId;
        }

        public UpdateShortcutsRequestDetails setTitle(String title) {
            this.title = title;
            return this;
        }
        public String getTitle() {
            return this.title;
        }

    }

}
