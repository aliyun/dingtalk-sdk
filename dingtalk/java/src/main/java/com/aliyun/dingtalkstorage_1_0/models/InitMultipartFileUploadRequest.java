// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkstorage_1_0.models;

import com.aliyun.tea.*;

public class InitMultipartFileUploadRequest extends TeaModel {
    // 可选参数
    @NameInMap("option")
    public InitMultipartFileUploadRequestOption option;

    // 用户id
    @NameInMap("unionId")
    public String unionId;

    public static InitMultipartFileUploadRequest build(java.util.Map<String, ?> map) throws Exception {
        InitMultipartFileUploadRequest self = new InitMultipartFileUploadRequest();
        return TeaModel.build(map, self);
    }

    public InitMultipartFileUploadRequest setOption(InitMultipartFileUploadRequestOption option) {
        this.option = option;
        return this;
    }
    public InitMultipartFileUploadRequestOption getOption() {
        return this.option;
    }

    public InitMultipartFileUploadRequest setUnionId(String unionId) {
        this.unionId = unionId;
        return this;
    }
    public String getUnionId() {
        return this.unionId;
    }

    public static class InitMultipartFileUploadRequestOptionPreCheckParam extends TeaModel {
        // 文件md5值, 做文件完整性校验。不传则不做校验。
        @NameInMap("md5")
        public String md5;

        // 文件名称, 文件名称合法性和文件名称冲突校验
        // 规则：
        // 1. 头尾不能包含空格，否则会自动去除
        // 2. 不能包含特殊字符，包括：制表符、*、"、<、>、|
        // 3. 不能以"."结尾
        @NameInMap("name")
        public String name;

        // 父目录id
        // 根目录id值为0
        // 用于同目录文件名冲突校验
        @NameInMap("parentId")
        public String parentId;

        // 文件大小, 做容量相关校验。不传则不做校验。
        @NameInMap("size")
        public Long size;

        public static InitMultipartFileUploadRequestOptionPreCheckParam build(java.util.Map<String, ?> map) throws Exception {
            InitMultipartFileUploadRequestOptionPreCheckParam self = new InitMultipartFileUploadRequestOptionPreCheckParam();
            return TeaModel.build(map, self);
        }

        public InitMultipartFileUploadRequestOptionPreCheckParam setMd5(String md5) {
            this.md5 = md5;
            return this;
        }
        public String getMd5() {
            return this.md5;
        }

        public InitMultipartFileUploadRequestOptionPreCheckParam setName(String name) {
            this.name = name;
            return this;
        }
        public String getName() {
            return this.name;
        }

        public InitMultipartFileUploadRequestOptionPreCheckParam setParentId(String parentId) {
            this.parentId = parentId;
            return this;
        }
        public String getParentId() {
            return this.parentId;
        }

        public InitMultipartFileUploadRequestOptionPreCheckParam setSize(Long size) {
            this.size = size;
            return this;
        }
        public Long getSize() {
            return this.size;
        }

    }

    public static class InitMultipartFileUploadRequestOption extends TeaModel {
        // 预检查的字段。可实现对文件名称，文件完整性，容量的校验
        @NameInMap("preCheckParam")
        public InitMultipartFileUploadRequestOptionPreCheckParam preCheckParam;

        // 优先地域, 倾向于将资源存到哪个地域，可实现就近上传等功能
        // 枚举值:
        // 	ZHANGJIAKOU: 张家口
        // 	SHENZHEN: 深圳
        // 	SHANGHAI: 上海
        // 	SINGAPORE: 新加坡
        // 	UNKNOWN: 未知
        @NameInMap("preferRegion")
        public String preferRegion;

        // 文件存储驱动类型, 当前只支持DINGTALK
        // 枚举值:
        // 	DINGTALK: 钉钉统一存储驱动
        // 	ALIDOC: 钉钉文档存储驱动
        // 	SHANJI: 闪记存储驱动
        // 	UNKNOWN: 未知驱动
        // 默认值:
        // 	DINGTALK
        @NameInMap("storageDriver")
        public String storageDriver;

        public static InitMultipartFileUploadRequestOption build(java.util.Map<String, ?> map) throws Exception {
            InitMultipartFileUploadRequestOption self = new InitMultipartFileUploadRequestOption();
            return TeaModel.build(map, self);
        }

        public InitMultipartFileUploadRequestOption setPreCheckParam(InitMultipartFileUploadRequestOptionPreCheckParam preCheckParam) {
            this.preCheckParam = preCheckParam;
            return this;
        }
        public InitMultipartFileUploadRequestOptionPreCheckParam getPreCheckParam() {
            return this.preCheckParam;
        }

        public InitMultipartFileUploadRequestOption setPreferRegion(String preferRegion) {
            this.preferRegion = preferRegion;
            return this;
        }
        public String getPreferRegion() {
            return this.preferRegion;
        }

        public InitMultipartFileUploadRequestOption setStorageDriver(String storageDriver) {
            this.storageDriver = storageDriver;
            return this;
        }
        public String getStorageDriver() {
            return this.storageDriver;
        }

    }

}
