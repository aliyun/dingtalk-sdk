// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalklink_1_0.models;

import com.aliyun.tea.*;

public class UpdateShortcutsRequest extends TeaModel {
    @NameInMap("details")
    public java.util.List<UpdateShortcutsRequestDetails> details;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>sid001234</p>
     */
    @NameInMap("sessionId")
    public String sessionId;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>idzb26bxl64vqx2keyi</p>
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
         * <strong>example:</strong>
         * <p><a href="https://dingtalk.com">https://dingtalk.com</a></p>
         */
        @NameInMap("actionUrl")
        public String actionUrl;

        /**
         * <strong>example:</strong>
         * <p>033bd94b1168d7e4f0d644c3c95e35bf</p>
         */
        @NameInMap("callbackKey")
        public String callbackKey;

        /**
         * <strong>example:</strong>
         * <p>e73e</p>
         */
        @NameInMap("iconFont")
        public String iconFont;

        /**
         * <p>This parameter is required.</p>
         * 
         * <strong>example:</strong>
         * <p>@lADPDg7mWPzw0i_NArzNArw</p>
         */
        @NameInMap("iconMediaId")
        public String iconMediaId;

        /**
         * <p>This parameter is required.</p>
         * 
         * <strong>example:</strong>
         * <p>test123456</p>
         */
        @NameInMap("shortcutId")
        public String shortcutId;

        /**
         * <strong>example:</strong>
         * <p>@lADPDg7mWPzw0i_NArzNArw</p>
         */
        @NameInMap("slideIconMediaId")
        public String slideIconMediaId;

        /**
         * <p>This parameter is required.</p>
         * 
         * <strong>example:</strong>
         * <p>测试</p>
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

        public UpdateShortcutsRequestDetails setCallbackKey(String callbackKey) {
            this.callbackKey = callbackKey;
            return this;
        }
        public String getCallbackKey() {
            return this.callbackKey;
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
