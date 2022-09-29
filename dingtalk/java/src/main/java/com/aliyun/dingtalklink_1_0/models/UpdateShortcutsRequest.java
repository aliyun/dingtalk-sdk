// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalklink_1_0.models;

import com.aliyun.tea.*;

public class UpdateShortcutsRequest extends TeaModel {
    // 配置详情
    @NameInMap("details")
    public java.util.List<UpdateShortcutsRequestDetails> details;

    // 用户信息
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

    public UpdateShortcutsRequest setUserId(String userId) {
        this.userId = userId;
        return this;
    }
    public String getUserId() {
        return this.userId;
    }

    public static class UpdateShortcutsRequestDetails extends TeaModel {
        // 跳转链接
        @NameInMap("actionUrl")
        public String actionUrl;

        // windows侧边栏图标的unicode
        @NameInMap("iconFont")
        public String iconFont;

        // 移动端图标
        @NameInMap("iconMediaId")
        public String iconMediaId;

        // 插件唯一标识
        @NameInMap("shortcutId")
        public String shortcutId;

        // 适配mac端侧边栏图标的mediaId
        @NameInMap("slideIconMediaId")
        public String slideIconMediaId;

        // 插件标题
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