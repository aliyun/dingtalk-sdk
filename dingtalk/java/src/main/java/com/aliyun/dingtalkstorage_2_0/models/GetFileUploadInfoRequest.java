// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkstorage_2_0.models;

import com.aliyun.tea.*;

public class GetFileUploadInfoRequest extends TeaModel {
    /**
     * <p>可选参数</p>
     */
    @NameInMap("option")
    public GetFileUploadInfoRequestOption option;

    /**
     * <p>通过指定上传协议返回不同协议上传所需要的信息</p>
     * <p>对于部分企业开启了专属存储，必须实现HEADER加签，否则无法支持专属存储组织文件上传。</p>
     * <p>如果指定上传协议不支持，则会返回错误Errors.DENTRY_UPLOAD_PROTOCOL_NOTSUPPORT, 请尝试用其它协议上传。</p>
     * <p>枚举值:</p>
     * <p>	HEADER_SIGNATURE: Header加签</p>
     */
    @NameInMap("protocol")
    public String protocol;

    /**
     * <p>用户id</p>
     */
    @NameInMap("unionId")
    public String unionId;

    public static GetFileUploadInfoRequest build(java.util.Map<String, ?> map) throws Exception {
        GetFileUploadInfoRequest self = new GetFileUploadInfoRequest();
        return TeaModel.build(map, self);
    }

    public GetFileUploadInfoRequest setOption(GetFileUploadInfoRequestOption option) {
        this.option = option;
        return this;
    }
    public GetFileUploadInfoRequestOption getOption() {
        return this.option;
    }

    public GetFileUploadInfoRequest setProtocol(String protocol) {
        this.protocol = protocol;
        return this;
    }
    public String getProtocol() {
        return this.protocol;
    }

    public GetFileUploadInfoRequest setUnionId(String unionId) {
        this.unionId = unionId;
        return this;
    }
    public String getUnionId() {
        return this.unionId;
    }

    public static class GetFileUploadInfoRequestOptionPreCheckParam extends TeaModel {
        /**
         * <p>文件名称, 文件名称合法性和文件名称冲突校验</p>
         * <p>规则：</p>
         * <p>1. 头尾不能包含空格，否则会自动去除</p>
         * <p>2. 不能包含特殊字符，包括：制表符、*、"、<、>、|</p>
         * <p>3. 不能以"."结尾</p>
         */
        @NameInMap("name")
        public String name;

        /**
         * <p>文件大小, 做容量相关校验。不传则不做校验。</p>
         */
        @NameInMap("size")
        public Long size;

        public static GetFileUploadInfoRequestOptionPreCheckParam build(java.util.Map<String, ?> map) throws Exception {
            GetFileUploadInfoRequestOptionPreCheckParam self = new GetFileUploadInfoRequestOptionPreCheckParam();
            return TeaModel.build(map, self);
        }

        public GetFileUploadInfoRequestOptionPreCheckParam setName(String name) {
            this.name = name;
            return this;
        }
        public String getName() {
            return this.name;
        }

        public GetFileUploadInfoRequestOptionPreCheckParam setSize(Long size) {
            this.size = size;
            return this;
        }
        public Long getSize() {
            return this.size;
        }

    }

    public static class GetFileUploadInfoRequestOption extends TeaModel {
        /**
         * <p>预检查的字段。可实现对文件名称，文件完整性，容量的校验</p>
         */
        @NameInMap("preCheckParam")
        public GetFileUploadInfoRequestOptionPreCheckParam preCheckParam;

        /**
         * <p>优先使用内网传输</p>
         * <p>前提: 配置了专属存储内网传输</p>
         * <p>默认值:</p>
         * <p>	true</p>
         */
        @NameInMap("preferIntranet")
        public Boolean preferIntranet;

        /**
         * <p>优先地域, 倾向于将资源存到哪个地域，可实现就近上传等功能</p>
         * <p>枚举值:</p>
         * <p>	ZHANGJIAKOU: 张家口</p>
         * <p>	SHENZHEN: 深圳</p>
         * <p>	SHANGHAI: 上海</p>
         * <p>	SINGAPORE: 新加坡</p>
         * <p>	UNKNOWN: 未知</p>
         */
        @NameInMap("preferRegion")
        public String preferRegion;

        /**
         * <p>文件存储驱动类型, 当前只支持DINGTALK</p>
         * <p>枚举值:</p>
         * <p>	DINGTALK: 钉钉统一存储驱动</p>
         * <p>	ALIDOC: 钉钉文档存储驱动</p>
         * <p>	SHANJI: 闪记存储驱动</p>
         * <p>	UNKNOWN: 未知驱动</p>
         * <p>默认值:</p>
         * <p>	DINGTALK</p>
         */
        @NameInMap("storageDriver")
        public String storageDriver;

        public static GetFileUploadInfoRequestOption build(java.util.Map<String, ?> map) throws Exception {
            GetFileUploadInfoRequestOption self = new GetFileUploadInfoRequestOption();
            return TeaModel.build(map, self);
        }

        public GetFileUploadInfoRequestOption setPreCheckParam(GetFileUploadInfoRequestOptionPreCheckParam preCheckParam) {
            this.preCheckParam = preCheckParam;
            return this;
        }
        public GetFileUploadInfoRequestOptionPreCheckParam getPreCheckParam() {
            return this.preCheckParam;
        }

        public GetFileUploadInfoRequestOption setPreferIntranet(Boolean preferIntranet) {
            this.preferIntranet = preferIntranet;
            return this;
        }
        public Boolean getPreferIntranet() {
            return this.preferIntranet;
        }

        public GetFileUploadInfoRequestOption setPreferRegion(String preferRegion) {
            this.preferRegion = preferRegion;
            return this;
        }
        public String getPreferRegion() {
            return this.preferRegion;
        }

        public GetFileUploadInfoRequestOption setStorageDriver(String storageDriver) {
            this.storageDriver = storageDriver;
            return this;
        }
        public String getStorageDriver() {
            return this.storageDriver;
        }

    }

}
