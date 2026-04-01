<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vai_search_ask_1_0\Models;

use AlibabaCloud\SDK\Dingtalk\Vai_search_ask_1_0\Models\RetrieveRequest\dragRequestContext;
use AlibabaCloud\Tea\Model;

class RetrieveRequest extends Model
{
    /**
     * @description This parameter is required.
     *
     * @var string
     */
    public $answerer;

    /**
     * @var dragRequestContext
     */
    public $dragRequestContext;

    /**
     * @var string[]
     */
    public $keywordList;

    /**
     * @description This parameter is required.
     *
     * @var int
     */
    public $limit;

    /**
     * @description This parameter is required.
     *
     * @var string
     */
    public $question;

    /**
     * @description This parameter is required.
     *
     * @var RetrievalExtendParamsValue[]
     */
    public $retrievalExtendParams;

    /**
     * @var float
     */
    public $retrieveScoreThreshold;

    /**
     * @description This parameter is required.
     *
     * @var string
     */
    public $scene;

    /**
     * @description This parameter is required.
     *
     * @var string
     */
    public $tenant;

    /**
     * @var int
     */
    public $tokenLimit;
    protected $_name = [
        'answerer' => 'answerer',
        'dragRequestContext' => 'dragRequestContext',
        'keywordList' => 'keywordList',
        'limit' => 'limit',
        'question' => 'question',
        'retrievalExtendParams' => 'retrievalExtendParams',
        'retrieveScoreThreshold' => 'retrieveScoreThreshold',
        'scene' => 'scene',
        'tenant' => 'tenant',
        'tokenLimit' => 'tokenLimit',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->answerer) {
            $res['answerer'] = $this->answerer;
        }
        if (null !== $this->dragRequestContext) {
            $res['dragRequestContext'] = null !== $this->dragRequestContext ? $this->dragRequestContext->toMap() : null;
        }
        if (null !== $this->keywordList) {
            $res['keywordList'] = $this->keywordList;
        }
        if (null !== $this->limit) {
            $res['limit'] = $this->limit;
        }
        if (null !== $this->question) {
            $res['question'] = $this->question;
        }
        if (null !== $this->retrievalExtendParams) {
            $res['retrievalExtendParams'] = [];
            if (null !== $this->retrievalExtendParams && \is_array($this->retrievalExtendParams)) {
                foreach ($this->retrievalExtendParams as $key => $val) {
                    $res['retrievalExtendParams'][$key] = null !== $val ? $val->toMap() : $val;
                }
            }
        }
        if (null !== $this->retrieveScoreThreshold) {
            $res['retrieveScoreThreshold'] = $this->retrieveScoreThreshold;
        }
        if (null !== $this->scene) {
            $res['scene'] = $this->scene;
        }
        if (null !== $this->tenant) {
            $res['tenant'] = $this->tenant;
        }
        if (null !== $this->tokenLimit) {
            $res['tokenLimit'] = $this->tokenLimit;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return RetrieveRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['answerer'])) {
            $model->answerer = $map['answerer'];
        }
        if (isset($map['dragRequestContext'])) {
            $model->dragRequestContext = dragRequestContext::fromMap($map['dragRequestContext']);
        }
        if (isset($map['keywordList'])) {
            if (!empty($map['keywordList'])) {
                $model->keywordList = $map['keywordList'];
            }
        }
        if (isset($map['limit'])) {
            $model->limit = $map['limit'];
        }
        if (isset($map['question'])) {
            $model->question = $map['question'];
        }
        if (isset($map['retrievalExtendParams'])) {
            $model->retrievalExtendParams = $map['retrievalExtendParams'];
        }
        if (isset($map['retrieveScoreThreshold'])) {
            $model->retrieveScoreThreshold = $map['retrieveScoreThreshold'];
        }
        if (isset($map['scene'])) {
            $model->scene = $map['scene'];
        }
        if (isset($map['tenant'])) {
            $model->tenant = $map['tenant'];
        }
        if (isset($map['tokenLimit'])) {
            $model->tokenLimit = $map['tokenLimit'];
        }

        return $model;
    }
}
