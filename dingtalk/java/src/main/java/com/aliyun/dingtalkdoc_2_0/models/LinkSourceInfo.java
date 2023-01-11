// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdoc_2_0.models;

import com.aliyun.tea.*;

public class LinkSourceInfo extends TeaModel {
    /**
     * <p>快捷方式关联的源文件后缀。</p>
     */
    @NameInMap("extension")
    public String extension;

    /**
     * <p>非通用快捷方式的图标信息。</p>
     */
    @NameInMap("iconUrl")
    public LinkSourceInfoIconUrl iconUrl;

    /**
     * <p>快捷方式关联的源文件ID（空间内唯一）。</p>
     */
    @NameInMap("id")
    public String id;

    /**
     * <p>快捷方式类型。0-通用快捷方式；1-闪会快捷方式；2-日志快捷方式；3-闪会2.0快捷方式。</p>
     */
    @NameInMap("linkType")
    public Long linkType;

    /**
     * <p>快捷方式关联的源文件所属空间id。</p>
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
         * <p>默认的目录树图标。</p>
         */
        @NameInMap("line")
        public String line;

        /**
         * <p>被选中时的加深图标。</p>
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
