<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models;

use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\CreateEduLlmModelReqRequest\chatMessageModelList;
use AlibabaCloud\Tea\Model;

class CreateEduLlmModelReqRequest extends Model
{
    /**
     * @var chatMessageModelList[]
     */
    public $chatMessageModelList;

    /**
     * @description This parameter is required.
     *
     * @example ding819xxxxxx
     *
     * @var string
     */
    public $corpId;

    /**
     * @var bool
     */
    public $enableThinking;

    /**
     * @example 8192
     *
     * @var int
     */
    public $maxTokens;

    /**
     * @example qwen-vl-max
     *
     * @var string
     */
    public $model;

    /**
     * @example https://example.cxxxx1.json
     *
     * @var string
     */
    public $reqLlmModelParamUrl;

    /**
     * @example {\"name\":\"手写文字识别\",\"schema\":{\"type\":\"object\",\"properties\":{\"type\":\"object\",\"required\":[\"题目1\",\"题目2\"],\"properties\":{\"题目1\":{\"type\":\"object\",\"properties\":{\"正确答案\":{\"type\":\"string\",\"description\":\"请根据题目描述正确答案\"},\"学生手写回答\":{\"type\":\"string\",\"description\":\"尽一切可能识别学生手写回答,对于有涂改的内容请识别其最终答案，当无法识别时返回 NAN\"},\"学生回答评价\":{\"type\":\"string\",\"description\":\"评价学生手写回答是否工整，请勿包含双引号\"}},\"required\":[\"正确答案\",\"学生手写回答\",\"学生回答评价\"],\"additionalProperties\":false},\"题目2\":{\"type\":\"object\",\"properties\":{\"正确答案\":{\"type\":\"string\",\"description\":\"请根据题目描述正确答案\"},\"学生手写回答\":{\"type\":\"string\",\"description\":\"尽一切可能识别学生手写回答,对于有涂改的内容请识别其最终答案，当无法识别时返回 NAN\"},\"学生回答评价\":{\"type\":\"string\",\"description\":\"评价学生手写回答是否工整，请勿包含双引号\"}},\"required\":[\"正确答案\",\"学生手写回答\",\"学生回答评价\"],\"additionalProperties\":false}}}},\"additionalProperties\":false}
     *
     * @var string
     */
    public $responseFormat;

    /**
     * @description This parameter is required.
     *
     * @example DING_xxxxxxxxxx
     *
     * @var string
     */
    public $taskCode;

    /**
     * @example 0.1
     *
     * @var float
     */
    public $temperature;

    /**
     * @example 1.0
     *
     * @var float
     */
    public $topP;
    protected $_name = [
        'chatMessageModelList' => 'chatMessageModelList',
        'corpId' => 'corpId',
        'enableThinking' => 'enableThinking',
        'maxTokens' => 'maxTokens',
        'model' => 'model',
        'reqLlmModelParamUrl' => 'reqLlmModelParamUrl',
        'responseFormat' => 'responseFormat',
        'taskCode' => 'taskCode',
        'temperature' => 'temperature',
        'topP' => 'topP',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->chatMessageModelList) {
            $res['chatMessageModelList'] = [];
            if (null !== $this->chatMessageModelList && \is_array($this->chatMessageModelList)) {
                $n = 0;
                foreach ($this->chatMessageModelList as $item) {
                    $res['chatMessageModelList'][$n++] = null !== $item ? $item->toMap() : $item;
                }
            }
        }
        if (null !== $this->corpId) {
            $res['corpId'] = $this->corpId;
        }
        if (null !== $this->enableThinking) {
            $res['enableThinking'] = $this->enableThinking;
        }
        if (null !== $this->maxTokens) {
            $res['maxTokens'] = $this->maxTokens;
        }
        if (null !== $this->model) {
            $res['model'] = $this->model;
        }
        if (null !== $this->reqLlmModelParamUrl) {
            $res['reqLlmModelParamUrl'] = $this->reqLlmModelParamUrl;
        }
        if (null !== $this->responseFormat) {
            $res['responseFormat'] = $this->responseFormat;
        }
        if (null !== $this->taskCode) {
            $res['taskCode'] = $this->taskCode;
        }
        if (null !== $this->temperature) {
            $res['temperature'] = $this->temperature;
        }
        if (null !== $this->topP) {
            $res['topP'] = $this->topP;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return CreateEduLlmModelReqRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['chatMessageModelList'])) {
            if (!empty($map['chatMessageModelList'])) {
                $model->chatMessageModelList = [];
                $n = 0;
                foreach ($map['chatMessageModelList'] as $item) {
                    $model->chatMessageModelList[$n++] = null !== $item ? chatMessageModelList::fromMap($item) : $item;
                }
            }
        }
        if (isset($map['corpId'])) {
            $model->corpId = $map['corpId'];
        }
        if (isset($map['enableThinking'])) {
            $model->enableThinking = $map['enableThinking'];
        }
        if (isset($map['maxTokens'])) {
            $model->maxTokens = $map['maxTokens'];
        }
        if (isset($map['model'])) {
            $model->model = $map['model'];
        }
        if (isset($map['reqLlmModelParamUrl'])) {
            $model->reqLlmModelParamUrl = $map['reqLlmModelParamUrl'];
        }
        if (isset($map['responseFormat'])) {
            $model->responseFormat = $map['responseFormat'];
        }
        if (isset($map['taskCode'])) {
            $model->taskCode = $map['taskCode'];
        }
        if (isset($map['temperature'])) {
            $model->temperature = $map['temperature'];
        }
        if (isset($map['topP'])) {
            $model->topP = $map['topP'];
        }

        return $model;
    }
}
