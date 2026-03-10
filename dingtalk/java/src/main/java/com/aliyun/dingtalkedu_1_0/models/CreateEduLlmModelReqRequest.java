// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkedu_1_0.models;

import com.aliyun.tea.*;

public class CreateEduLlmModelReqRequest extends TeaModel {
    @NameInMap("chatMessageModelList")
    public java.util.List<CreateEduLlmModelReqRequestChatMessageModelList> chatMessageModelList;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>ding819xxxxxx</p>
     */
    @NameInMap("corpId")
    public String corpId;

    @NameInMap("enableThinking")
    public Boolean enableThinking;

    /**
     * <strong>example:</strong>
     * <p>8192</p>
     */
    @NameInMap("maxTokens")
    public Integer maxTokens;

    /**
     * <strong>example:</strong>
     * <p>qwen-vl-max</p>
     */
    @NameInMap("model")
    public String model;

    /**
     * <strong>example:</strong>
     * <p><a href="https://example.cxxxx1.json">https://example.cxxxx1.json</a></p>
     */
    @NameInMap("reqLlmModelParamUrl")
    public String reqLlmModelParamUrl;

    /**
     * <strong>example:</strong>
     * <p>{&quot;name&quot;:&quot;手写文字识别&quot;,&quot;schema&quot;:{&quot;type&quot;:&quot;object&quot;,&quot;properties&quot;:{&quot;type&quot;:&quot;object&quot;,&quot;required&quot;:[&quot;题目1&quot;,&quot;题目2&quot;],&quot;properties&quot;:{&quot;题目1&quot;:{&quot;type&quot;:&quot;object&quot;,&quot;properties&quot;:{&quot;正确答案&quot;:{&quot;type&quot;:&quot;string&quot;,&quot;description&quot;:&quot;请根据题目描述正确答案&quot;},&quot;学生手写回答&quot;:{&quot;type&quot;:&quot;string&quot;,&quot;description&quot;:&quot;尽一切可能识别学生手写回答,对于有涂改的内容请识别其最终答案，当无法识别时返回 NAN&quot;},&quot;学生回答评价&quot;:{&quot;type&quot;:&quot;string&quot;,&quot;description&quot;:&quot;评价学生手写回答是否工整，请勿包含双引号&quot;}},&quot;required&quot;:[&quot;正确答案&quot;,&quot;学生手写回答&quot;,&quot;学生回答评价&quot;],&quot;additionalProperties&quot;:false},&quot;题目2&quot;:{&quot;type&quot;:&quot;object&quot;,&quot;properties&quot;:{&quot;正确答案&quot;:{&quot;type&quot;:&quot;string&quot;,&quot;description&quot;:&quot;请根据题目描述正确答案&quot;},&quot;学生手写回答&quot;:{&quot;type&quot;:&quot;string&quot;,&quot;description&quot;:&quot;尽一切可能识别学生手写回答,对于有涂改的内容请识别其最终答案，当无法识别时返回 NAN&quot;},&quot;学生回答评价&quot;:{&quot;type&quot;:&quot;string&quot;,&quot;description&quot;:&quot;评价学生手写回答是否工整，请勿包含双引号&quot;}},&quot;required&quot;:[&quot;正确答案&quot;,&quot;学生手写回答&quot;,&quot;学生回答评价&quot;],&quot;additionalProperties&quot;:false}}}},&quot;additionalProperties&quot;:false}</p>
     */
    @NameInMap("responseFormat")
    public String responseFormat;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>DING_xxxxxxxxxx</p>
     */
    @NameInMap("taskCode")
    public String taskCode;

    /**
     * <strong>example:</strong>
     * <p>0.1</p>
     */
    @NameInMap("temperature")
    public Double temperature;

    /**
     * <strong>example:</strong>
     * <p>1.0</p>
     */
    @NameInMap("topP")
    public Double topP;

    public static CreateEduLlmModelReqRequest build(java.util.Map<String, ?> map) throws Exception {
        CreateEduLlmModelReqRequest self = new CreateEduLlmModelReqRequest();
        return TeaModel.build(map, self);
    }

    public CreateEduLlmModelReqRequest setChatMessageModelList(java.util.List<CreateEduLlmModelReqRequestChatMessageModelList> chatMessageModelList) {
        this.chatMessageModelList = chatMessageModelList;
        return this;
    }
    public java.util.List<CreateEduLlmModelReqRequestChatMessageModelList> getChatMessageModelList() {
        return this.chatMessageModelList;
    }

    public CreateEduLlmModelReqRequest setCorpId(String corpId) {
        this.corpId = corpId;
        return this;
    }
    public String getCorpId() {
        return this.corpId;
    }

    public CreateEduLlmModelReqRequest setEnableThinking(Boolean enableThinking) {
        this.enableThinking = enableThinking;
        return this;
    }
    public Boolean getEnableThinking() {
        return this.enableThinking;
    }

    public CreateEduLlmModelReqRequest setMaxTokens(Integer maxTokens) {
        this.maxTokens = maxTokens;
        return this;
    }
    public Integer getMaxTokens() {
        return this.maxTokens;
    }

    public CreateEduLlmModelReqRequest setModel(String model) {
        this.model = model;
        return this;
    }
    public String getModel() {
        return this.model;
    }

    public CreateEduLlmModelReqRequest setReqLlmModelParamUrl(String reqLlmModelParamUrl) {
        this.reqLlmModelParamUrl = reqLlmModelParamUrl;
        return this;
    }
    public String getReqLlmModelParamUrl() {
        return this.reqLlmModelParamUrl;
    }

    public CreateEduLlmModelReqRequest setResponseFormat(String responseFormat) {
        this.responseFormat = responseFormat;
        return this;
    }
    public String getResponseFormat() {
        return this.responseFormat;
    }

    public CreateEduLlmModelReqRequest setTaskCode(String taskCode) {
        this.taskCode = taskCode;
        return this;
    }
    public String getTaskCode() {
        return this.taskCode;
    }

    public CreateEduLlmModelReqRequest setTemperature(Double temperature) {
        this.temperature = temperature;
        return this;
    }
    public Double getTemperature() {
        return this.temperature;
    }

    public CreateEduLlmModelReqRequest setTopP(Double topP) {
        this.topP = topP;
        return this;
    }
    public Double getTopP() {
        return this.topP;
    }

    public static class CreateEduLlmModelReqRequestChatMessageModelListContentListImageModel extends TeaModel {
        @NameInMap("detail")
        public String detail;

        @NameInMap("url")
        public String url;

        public static CreateEduLlmModelReqRequestChatMessageModelListContentListImageModel build(java.util.Map<String, ?> map) throws Exception {
            CreateEduLlmModelReqRequestChatMessageModelListContentListImageModel self = new CreateEduLlmModelReqRequestChatMessageModelListContentListImageModel();
            return TeaModel.build(map, self);
        }

        public CreateEduLlmModelReqRequestChatMessageModelListContentListImageModel setDetail(String detail) {
            this.detail = detail;
            return this;
        }
        public String getDetail() {
            return this.detail;
        }

        public CreateEduLlmModelReqRequestChatMessageModelListContentListImageModel setUrl(String url) {
            this.url = url;
            return this;
        }
        public String getUrl() {
            return this.url;
        }

    }

    public static class CreateEduLlmModelReqRequestChatMessageModelListContentList extends TeaModel {
        @NameInMap("imageModel")
        public CreateEduLlmModelReqRequestChatMessageModelListContentListImageModel imageModel;

        @NameInMap("text")
        public String text;

        @NameInMap("type")
        public String type;

        public static CreateEduLlmModelReqRequestChatMessageModelListContentList build(java.util.Map<String, ?> map) throws Exception {
            CreateEduLlmModelReqRequestChatMessageModelListContentList self = new CreateEduLlmModelReqRequestChatMessageModelListContentList();
            return TeaModel.build(map, self);
        }

        public CreateEduLlmModelReqRequestChatMessageModelListContentList setImageModel(CreateEduLlmModelReqRequestChatMessageModelListContentListImageModel imageModel) {
            this.imageModel = imageModel;
            return this;
        }
        public CreateEduLlmModelReqRequestChatMessageModelListContentListImageModel getImageModel() {
            return this.imageModel;
        }

        public CreateEduLlmModelReqRequestChatMessageModelListContentList setText(String text) {
            this.text = text;
            return this;
        }
        public String getText() {
            return this.text;
        }

        public CreateEduLlmModelReqRequestChatMessageModelListContentList setType(String type) {
            this.type = type;
            return this;
        }
        public String getType() {
            return this.type;
        }

    }

    public static class CreateEduLlmModelReqRequestChatMessageModelList extends TeaModel {
        @NameInMap("contentList")
        public java.util.List<CreateEduLlmModelReqRequestChatMessageModelListContentList> contentList;

        /**
         * <strong>example:</strong>
         * <p>user</p>
         */
        @NameInMap("role")
        public String role;

        public static CreateEduLlmModelReqRequestChatMessageModelList build(java.util.Map<String, ?> map) throws Exception {
            CreateEduLlmModelReqRequestChatMessageModelList self = new CreateEduLlmModelReqRequestChatMessageModelList();
            return TeaModel.build(map, self);
        }

        public CreateEduLlmModelReqRequestChatMessageModelList setContentList(java.util.List<CreateEduLlmModelReqRequestChatMessageModelListContentList> contentList) {
            this.contentList = contentList;
            return this;
        }
        public java.util.List<CreateEduLlmModelReqRequestChatMessageModelListContentList> getContentList() {
            return this.contentList;
        }

        public CreateEduLlmModelReqRequestChatMessageModelList setRole(String role) {
            this.role = role;
            return this;
        }
        public String getRole() {
            return this.role;
        }

    }

}
