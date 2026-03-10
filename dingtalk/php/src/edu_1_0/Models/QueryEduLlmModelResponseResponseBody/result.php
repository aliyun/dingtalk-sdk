<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\QueryEduLlmModelResponseResponseBody;

use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\QueryEduLlmModelResponseResponseBody\result\modelResult;
use AlibabaCloud\Tea\Model;

class result extends Model
{
    /**
     * @var modelResult
     */
    public $modelResult;

    /**
     * @example requestxxxxxxx
     *
     * @var string
     */
    public $reqId;
    protected $_name = [
        'modelResult' => 'modelResult',
        'reqId' => 'reqId',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->modelResult) {
            $res['modelResult'] = null !== $this->modelResult ? $this->modelResult->toMap() : null;
        }
        if (null !== $this->reqId) {
            $res['reqId'] = $this->reqId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return result
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['modelResult'])) {
            $model->modelResult = modelResult::fromMap($map['modelResult']);
        }
        if (isset($map['reqId'])) {
            $model->reqId = $map['reqId'];
        }

        return $model;
    }
}
