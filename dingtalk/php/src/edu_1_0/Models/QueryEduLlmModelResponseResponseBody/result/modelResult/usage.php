<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\QueryEduLlmModelResponseResponseBody\result\modelResult;

use AlibabaCloud\Tea\Model;

class usage extends Model
{
    /**
     * @example 888
     *
     * @var int
     */
    public $inputTokens;

    /**
     * @example 666
     *
     * @var int
     */
    public $outputTokens;
    protected $_name = [
        'inputTokens' => 'inputTokens',
        'outputTokens' => 'outputTokens',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->inputTokens) {
            $res['inputTokens'] = $this->inputTokens;
        }
        if (null !== $this->outputTokens) {
            $res['outputTokens'] = $this->outputTokens;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return usage
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['inputTokens'])) {
            $model->inputTokens = $map['inputTokens'];
        }
        if (isset($map['outputTokens'])) {
            $model->outputTokens = $map['outputTokens'];
        }

        return $model;
    }
}
