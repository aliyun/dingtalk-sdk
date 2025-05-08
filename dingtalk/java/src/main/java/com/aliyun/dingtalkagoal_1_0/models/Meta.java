// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkagoal_1_0.models;

import com.aliyun.tea.*;

public class Meta extends TeaModel {
    /**
     * <strong>example:</strong>
     * <p>true</p>
     */
    @NameInMap("active")
    public Boolean active;

    /**
     * <strong>example:</strong>
     * <p>编码</p>
     */
    @NameInMap("alias")
    public String alias;

    /**
     * <strong>example:</strong>
     * <p>common</p>
     */
    @NameInMap("category")
    public String category;

    /**
     * <strong>example:</strong>
     * <p>title</p>
     */
    @NameInMap("code")
    public String code;

    /**
     * <strong>example:</strong>
     * <p>true</p>
     */
    @NameInMap("forceActive")
    public Boolean forceActive;

    /**
     * <strong>example:</strong>
     * <p>true</p>
     */
    @NameInMap("forceRequired")
    public Boolean forceRequired;

    /**
     * <strong>example:</strong>
     * <p>true</p>
     */
    @NameInMap("required")
    public Boolean required;

    /**
     * <strong>example:</strong>
     * <p>{&quot;width&quot;: 200}</p>
     */
    @NameInMap("scheme")
    public java.util.Map<String, ?> scheme;

    /**
     * <strong>example:</strong>
     * <p>名称</p>
     */
    @NameInMap("title")
    public String title;

    /**
     * <strong>example:</strong>
     * <p>string</p>
     */
    @NameInMap("type")
    public String type;

    public static Meta build(java.util.Map<String, ?> map) throws Exception {
        Meta self = new Meta();
        return TeaModel.build(map, self);
    }

    public Meta setActive(Boolean active) {
        this.active = active;
        return this;
    }
    public Boolean getActive() {
        return this.active;
    }

    public Meta setAlias(String alias) {
        this.alias = alias;
        return this;
    }
    public String getAlias() {
        return this.alias;
    }

    public Meta setCategory(String category) {
        this.category = category;
        return this;
    }
    public String getCategory() {
        return this.category;
    }

    public Meta setCode(String code) {
        this.code = code;
        return this;
    }
    public String getCode() {
        return this.code;
    }

    public Meta setForceActive(Boolean forceActive) {
        this.forceActive = forceActive;
        return this;
    }
    public Boolean getForceActive() {
        return this.forceActive;
    }

    public Meta setForceRequired(Boolean forceRequired) {
        this.forceRequired = forceRequired;
        return this;
    }
    public Boolean getForceRequired() {
        return this.forceRequired;
    }

    public Meta setRequired(Boolean required) {
        this.required = required;
        return this;
    }
    public Boolean getRequired() {
        return this.required;
    }

    public Meta setScheme(java.util.Map<String, ?> scheme) {
        this.scheme = scheme;
        return this;
    }
    public java.util.Map<String, ?> getScheme() {
        return this.scheme;
    }

    public Meta setTitle(String title) {
        this.title = title;
        return this;
    }
    public String getTitle() {
        return this.title;
    }

    public Meta setType(String type) {
        this.type = type;
        return this;
    }
    public String getType() {
        return this.type;
    }

}
