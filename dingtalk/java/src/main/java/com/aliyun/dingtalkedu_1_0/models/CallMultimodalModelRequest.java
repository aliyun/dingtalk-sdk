// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkedu_1_0.models;

import com.aliyun.tea.*;

public class CallMultimodalModelRequest extends TeaModel {
    @NameInMap("chatMessageModelList")
    public java.util.List<CallMultimodalModelRequestChatMessageModelList> chatMessageModelList;

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
     * <p>10000</p>
     */
    @NameInMap("maxTokens")
    public Integer maxTokens;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>qwen3.5-plus</p>
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
     * <p>{&quot;name&quot;:&quot;手写文字识别&quot;,&quot;schema&quot;:{&quot;type&quot;:&quot;object&quot;,&quot;properties&quot;:{&quot;type&quot;:&quot;object&quot;,&quot;required&quot;:[&quot;题目1&quot;,&quot;题目2&quot;],&quot;properties&quot;:{&quot;题目1&quot;:{&quot;type&quot;:&quot;object&quot;,&quot;properties&quot;:{&quot;正确答案&quot;:{&quot;type&quot;:&quot;string&quot;,&quot;description&quot;:&quot;请根据题目描述正确答案&quot;},&quot;学生手写回答&quot;:{&quot;type&quot;:&quot;string&quot;,&quot;description&quot;:&quot;尽一切可能识别学生手写回答,对于有涂改的内容请识别其最终答案，当无法识别时返回 NAN&quot;},&quot;学生回答评价&quot;:{&quot;type&quot;:&quot;string&quot;,&quot;description&quot;:&quot;评价学生手写回答是否工整，请勿包含双引号&quot;}},&quot;required&quot;:[&quot;正确答案&quot;,&quot;学生手写回答&quot;,&quot;学生回答评价&quot;],&quot;additionalProperties&quot;:false},&quot;题目2&quot;:{&quot;type&quot;:&quot;object&quot;,&quot;properties&quot;:{&quot;正确答案&quot;:{&quot;type&quot;:&quot;string&quot;,&quot;description&quot;:&quot;请根据题目描述正确答案&quot;},&quot;学生手写回答&quot;:{&quot;type&quot;:&quot;string&quot;,&quot;description&quot;:&quot;尽一切可能识别学生手写回答,对于有涂改的内容请识别其最终答案，当无法识别时返回 NAN&quot;},&quot;学生回答评价&quot;:{&quot;type&quot;:&quot;string&quot;,&quot;description&quot;:&quot;评价学生手写回答是否工整，请勿包含双引号&quot;}},&quot;required&quot;:[&quot;正确答案&quot;,&quot;学生手写回答&quot;,&quot;学生回答评价&quot;],&quot;additionalProperties&quot;:false}}}},&quot;additionalProperties&quot;:fals</p>
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
     * <p>1.0</p>
     */
    @NameInMap("temperature")
    public Double temperature;

    /**
     * <strong>example:</strong>
     * <p>0.8</p>
     */
    @NameInMap("topP")
    public Double topP;

    public static CallMultimodalModelRequest build(java.util.Map<String, ?> map) throws Exception {
        CallMultimodalModelRequest self = new CallMultimodalModelRequest();
        return TeaModel.build(map, self);
    }

    public CallMultimodalModelRequest setChatMessageModelList(java.util.List<CallMultimodalModelRequestChatMessageModelList> chatMessageModelList) {
        this.chatMessageModelList = chatMessageModelList;
        return this;
    }
    public java.util.List<CallMultimodalModelRequestChatMessageModelList> getChatMessageModelList() {
        return this.chatMessageModelList;
    }

    public CallMultimodalModelRequest setCorpId(String corpId) {
        this.corpId = corpId;
        return this;
    }
    public String getCorpId() {
        return this.corpId;
    }

    public CallMultimodalModelRequest setEnableThinking(Boolean enableThinking) {
        this.enableThinking = enableThinking;
        return this;
    }
    public Boolean getEnableThinking() {
        return this.enableThinking;
    }

    public CallMultimodalModelRequest setMaxTokens(Integer maxTokens) {
        this.maxTokens = maxTokens;
        return this;
    }
    public Integer getMaxTokens() {
        return this.maxTokens;
    }

    public CallMultimodalModelRequest setModel(String model) {
        this.model = model;
        return this;
    }
    public String getModel() {
        return this.model;
    }

    public CallMultimodalModelRequest setReqLlmModelParamUrl(String reqLlmModelParamUrl) {
        this.reqLlmModelParamUrl = reqLlmModelParamUrl;
        return this;
    }
    public String getReqLlmModelParamUrl() {
        return this.reqLlmModelParamUrl;
    }

    public CallMultimodalModelRequest setResponseFormat(String responseFormat) {
        this.responseFormat = responseFormat;
        return this;
    }
    public String getResponseFormat() {
        return this.responseFormat;
    }

    public CallMultimodalModelRequest setTaskCode(String taskCode) {
        this.taskCode = taskCode;
        return this;
    }
    public String getTaskCode() {
        return this.taskCode;
    }

    public CallMultimodalModelRequest setTemperature(Double temperature) {
        this.temperature = temperature;
        return this;
    }
    public Double getTemperature() {
        return this.temperature;
    }

    public CallMultimodalModelRequest setTopP(Double topP) {
        this.topP = topP;
        return this;
    }
    public Double getTopP() {
        return this.topP;
    }

    public static class CallMultimodalModelRequestChatMessageModelListContentListImageModel extends TeaModel {
        @NameInMap("detail")
        public String detail;

        @NameInMap("url")
        public String url;

        public static CallMultimodalModelRequestChatMessageModelListContentListImageModel build(java.util.Map<String, ?> map) throws Exception {
            CallMultimodalModelRequestChatMessageModelListContentListImageModel self = new CallMultimodalModelRequestChatMessageModelListContentListImageModel();
            return TeaModel.build(map, self);
        }

        public CallMultimodalModelRequestChatMessageModelListContentListImageModel setDetail(String detail) {
            this.detail = detail;
            return this;
        }
        public String getDetail() {
            return this.detail;
        }

        public CallMultimodalModelRequestChatMessageModelListContentListImageModel setUrl(String url) {
            this.url = url;
            return this;
        }
        public String getUrl() {
            return this.url;
        }

    }

    public static class CallMultimodalModelRequestChatMessageModelListContentList extends TeaModel {
        @NameInMap("imageModel")
        public CallMultimodalModelRequestChatMessageModelListContentListImageModel imageModel;

        @NameInMap("text")
        public String text;

        @NameInMap("type")
        public String type;

        public static CallMultimodalModelRequestChatMessageModelListContentList build(java.util.Map<String, ?> map) throws Exception {
            CallMultimodalModelRequestChatMessageModelListContentList self = new CallMultimodalModelRequestChatMessageModelListContentList();
            return TeaModel.build(map, self);
        }

        public CallMultimodalModelRequestChatMessageModelListContentList setImageModel(CallMultimodalModelRequestChatMessageModelListContentListImageModel imageModel) {
            this.imageModel = imageModel;
            return this;
        }
        public CallMultimodalModelRequestChatMessageModelListContentListImageModel getImageModel() {
            return this.imageModel;
        }

        public CallMultimodalModelRequestChatMessageModelListContentList setText(String text) {
            this.text = text;
            return this;
        }
        public String getText() {
            return this.text;
        }

        public CallMultimodalModelRequestChatMessageModelListContentList setType(String type) {
            this.type = type;
            return this;
        }
        public String getType() {
            return this.type;
        }

    }

    public static class CallMultimodalModelRequestChatMessageModelList extends TeaModel {
        @NameInMap("contentList")
        public java.util.List<CallMultimodalModelRequestChatMessageModelListContentList> contentList;

        /**
         * <strong>example:</strong>
         * <p>user</p>
         */
        @NameInMap("role")
        public String role;

        public static CallMultimodalModelRequestChatMessageModelList build(java.util.Map<String, ?> map) throws Exception {
            CallMultimodalModelRequestChatMessageModelList self = new CallMultimodalModelRequestChatMessageModelList();
            return TeaModel.build(map, self);
        }

        public CallMultimodalModelRequestChatMessageModelList setContentList(java.util.List<CallMultimodalModelRequestChatMessageModelListContentList> contentList) {
            this.contentList = contentList;
            return this;
        }
        public java.util.List<CallMultimodalModelRequestChatMessageModelListContentList> getContentList() {
            return this.contentList;
        }

        public CallMultimodalModelRequestChatMessageModelList setRole(String role) {
            this.role = role;
            return this;
        }
        public String getRole() {
            return this.role;
        }

    }

}
