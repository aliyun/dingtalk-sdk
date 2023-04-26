<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vbizfinance_1_0\Models;

use AlibabaCloud\Tea\Model;

class GetReceiptRequest extends Model
{
    /**
     * @example 19b98a1c-5a31-4d78-9da7-0e347593820a
     *
     * @var string
     */
    public $code;

    /**
     * @example EM-1017F28E03350B1738B3000X
     *
     * @var string
     */
    public $modelId;
    protected $_name = [
        'code'    => 'code',
        'modelId' => 'modelId',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->code) {
            $res['code'] = $this->code;
        }
        if (null !== $this->modelId) {
            $res['modelId'] = $this->modelId;
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
        if (isset($map['code'])) {
            $model->code = $map['code'];
        }
        if (isset($map['modelId'])) {
            $model->modelId = $map['modelId'];
        }

        return $model;
    }
}
