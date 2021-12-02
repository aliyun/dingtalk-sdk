<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vbizfinance_1_0\Models;

use AlibabaCloud\Tea\Model;

class GetReceiptRequest extends Model
{
    /**
     * @description 模型id
     *
     * @var string
     */
    public $modelId;

    /**
     * @description 单据号
     *
     * @var string
     */
    public $code;
    protected $_name = [
        'modelId' => 'modelId',
        'code'    => 'code',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->modelId) {
            $res['modelId'] = $this->modelId;
        }
        if (null !== $this->code) {
            $res['code'] = $this->code;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return GetReceiptRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['modelId'])) {
            $model->modelId = $map['modelId'];
        }
        if (isset($map['code'])) {
            $model->code = $map['code'];
        }

        return $model;
    }
}
