// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkstorage_1_0.models;

import com.aliyun.tea.*;

public class GetDentryOpenInfoRequest extends TeaModel {
    /**
     * <p>可选参数</p>
     */
    @NameInMap("option")
    public GetDentryOpenInfoRequestOption option;

    /**
     * <p>用户id</p>
     */
    @NameInMap("unionId")
    public String unionId;

    public static GetDentryOpenInfoRequest build(java.util.Map<String, ?> map) throws Exception {
        GetDentryOpenInfoRequest self = new GetDentryOpenInfoRequest();
        return TeaModel.build(map, self);
    }

    public GetDentryOpenInfoRequest setOption(GetDentryOpenInfoRequestOption option) {
        this.option = option;
        return this;
    }
    public GetDentryOpenInfoRequestOption getOption() {
        return this.option;
    }

    public GetDentryOpenInfoRequest setUnionId(String unionId) {
        this.unionId = unionId;
        return this;
    }
    public String getUnionId() {
        return this.unionId;
    }

    public static class GetDentryOpenInfoRequestOption extends TeaModel {
        /**
         * <p>是否检查钉钉登录态, 目前仅对预览生效。</p>
         * <p>设置true时, 进入页面的时候会校验钉钉登录态。如果没有登录态, 会跳转到登录页面, 登录成功之后继续跳转到当前页面。</p>
         * <p>设置false时, 进入页面后不校验钉钉登录态, 但有以下的限制: </p>
         * <p>    1. 只支持WPS格式文件、有限图片格式, 不支持显示toolbar</p>
         * <p>    2. 一个链接只能使用一次(针对浏览器session)</p>
         * <p>    3. 链接5分钟不使用会失效</p>
         * <p>默认值:</p>
         * <p>	false</p>
         */
        @NameInMap("checkLogin")
        public Boolean checkLogin;

        /**
         * <p>打开方式，可以分为预览和编辑</p>
         * <p>枚举值:</p>
         * <p>	PREVIEW: 预览</p>
         * <p>	EDIT: 编辑</p>
         * <p>默认值:</p>
         * <p>	PREVIEW</p>
         */
        @NameInMap("type")
        public String type;

        /**
         * <p>历史版本号, 不填表示最新版本</p>
         */
        @NameInMap("version")
        public Long version;

        /**
         * <p>是否需要水印</p>
         * <p>默认值:</p>
         * <p>	false</p>
         */
        @NameInMap("waterMark")
        public Boolean waterMark;

        public static GetDentryOpenInfoRequestOption build(java.util.Map<String, ?> map) throws Exception {
            GetDentryOpenInfoRequestOption self = new GetDentryOpenInfoRequestOption();
            return TeaModel.build(map, self);
        }

        public GetDentryOpenInfoRequestOption setCheckLogin(Boolean checkLogin) {
            this.checkLogin = checkLogin;
            return this;
        }
        public Boolean getCheckLogin() {
            return this.checkLogin;
        }

        public GetDentryOpenInfoRequestOption setType(String type) {
            this.type = type;
            return this;
        }
        public String getType() {
            return this.type;
        }

        public GetDentryOpenInfoRequestOption setVersion(Long version) {
            this.version = version;
            return this;
        }
        public Long getVersion() {
            return this.version;
        }

        public GetDentryOpenInfoRequestOption setWaterMark(Boolean waterMark) {
            this.waterMark = waterMark;
            return this;
        }
        public Boolean getWaterMark() {
            return this.waterMark;
        }

    }

}
