// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkstorage_1_0.models;

import com.aliyun.tea.*;

public class RegisterOpenInfoRequest extends TeaModel {
    // 注册打开信息
    @NameInMap("openInfos")
    public java.util.List<RegisterOpenInfoRequestOpenInfos> openInfos;

    // 链接供应商名称
    // 枚举值:
    // 	MS_OFFICE: MS Office
    @NameInMap("provider")
    public String provider;

    // 用户id
    @NameInMap("unionId")
    public String unionId;

    public static RegisterOpenInfoRequest build(java.util.Map<String, ?> map) throws Exception {
        RegisterOpenInfoRequest self = new RegisterOpenInfoRequest();
        return TeaModel.build(map, self);
    }

    public RegisterOpenInfoRequest setOpenInfos(java.util.List<RegisterOpenInfoRequestOpenInfos> openInfos) {
        this.openInfos = openInfos;
        return this;
    }
    public java.util.List<RegisterOpenInfoRequestOpenInfos> getOpenInfos() {
        return this.openInfos;
    }

    public RegisterOpenInfoRequest setProvider(String provider) {
        this.provider = provider;
        return this;
    }
    public String getProvider() {
        return this.provider;
    }

    public RegisterOpenInfoRequest setUnionId(String unionId) {
        this.unionId = unionId;
        return this;
    }
    public String getUnionId() {
        return this.unionId;
    }

    public static class RegisterOpenInfoRequestOpenInfos extends TeaModel {
        // 打开方式
        // 枚举值:
        // 	PREVIEW: 预览
        // 	EDIT: 编辑
        @NameInMap("openType")
        public String openType;

        // 注册链接
        @NameInMap("url")
        public String url;

        public static RegisterOpenInfoRequestOpenInfos build(java.util.Map<String, ?> map) throws Exception {
            RegisterOpenInfoRequestOpenInfos self = new RegisterOpenInfoRequestOpenInfos();
            return TeaModel.build(map, self);
        }

        public RegisterOpenInfoRequestOpenInfos setOpenType(String openType) {
            this.openType = openType;
            return this;
        }
        public String getOpenType() {
            return this.openType;
        }

        public RegisterOpenInfoRequestOpenInfos setUrl(String url) {
            this.url = url;
            return this;
        }
        public String getUrl() {
            return this.url;
        }

    }

}
