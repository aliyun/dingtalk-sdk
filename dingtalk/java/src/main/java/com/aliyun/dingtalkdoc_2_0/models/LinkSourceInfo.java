// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdoc_2_0.models;

import com.aliyun.tea.*;

public class LinkSourceInfo extends TeaModel {
    /**
     * <strong>example:</strong>
     * <p>docx</p>
     */
    @NameInMap("extension")
    public String extension;

    @NameInMap("iconUrl")
    public LinkSourceInfoIconUrl iconUrl;

    /**
     * <strong>example:</strong>
     * <p>abc</p>
     */
    @NameInMap("id")
    public String id;

    /**
     * <strong>example:</strong>
     * <p>0</p>
     */
    @NameInMap("linkType")
    public Long linkType;

    /**
     * <strong>example:</strong>
     * <p>def</p>
     */
    @NameInMap("spaceId")
    public String spaceId;

    public static LinkSourceInfo build(java.util.Map<String, ?> map) throws Exception {
        LinkSourceInfo self = new LinkSourceInfo();
        return TeaModel.build(map, self);
    }

    public LinkSourceInfo setExtension(String extension) {
        this.extension = extension;
        return this;
    }
    public String getExtension() {
        return this.extension;
    }

    public LinkSourceInfo setIconUrl(LinkSourceInfoIconUrl iconUrl) {
        this.iconUrl = iconUrl;
        return this;
    }
    public LinkSourceInfoIconUrl getIconUrl() {
        return this.iconUrl;
    }

    public LinkSourceInfo setId(String id) {
        this.id = id;
        return this;
    }
    public String getId() {
        return this.id;
    }

    public LinkSourceInfo setLinkType(Long linkType) {
        this.linkType = linkType;
        return this;
    }
    public Long getLinkType() {
        return this.linkType;
    }

    public LinkSourceInfo setSpaceId(String spaceId) {
        this.spaceId = spaceId;
        return this;
    }
    public String getSpaceId() {
        return this.spaceId;
    }

    public static class LinkSourceInfoIconUrl extends TeaModel {
        /**
         * <strong>example:</strong>
         * <p>gh</p>
         */
        @NameInMap("line")
        public String line;

        /**
         * <strong>example:</strong>
         * <p>def</p>
         */
        @NameInMap("small")
        public String small;

        public static LinkSourceInfoIconUrl build(java.util.Map<String, ?> map) throws Exception {
            LinkSourceInfoIconUrl self = new LinkSourceInfoIconUrl();
            return TeaModel.build(map, self);
        }

        public LinkSourceInfoIconUrl setLine(String line) {
            this.line = line;
            return this;
        }
        public String getLine() {
            return this.line;
        }

        public LinkSourceInfoIconUrl setSmall(String small) {
            this.small = small;
            return this;
        }
        public String getSmall() {
            return this.small;
        }

    }

}
