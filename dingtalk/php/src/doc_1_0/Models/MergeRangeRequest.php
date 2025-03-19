<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vdoc_1_0\Models;

use AlibabaCloud\Tea\Model;

class MergeRangeRequest extends Model
{
    /**
     * @var string
     */
    public $mergeType;

    /**
     * @description This parameter is required.
     *
     * @example ppgAQuHfOoNVpJiStDwWCEgiEiE
     *
     * @var string
     */
    public $operatorId;
    protected $_name = [
        'mergeType' => 'mergeType',
        'operatorId' => 'operatorId',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->mergeType) {
            $res['mergeType'] = $this->mergeType;
        }
        if (null !== $this->operatorId) {
            $res['operatorId'] = $this->operatorId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return MergeRangeRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['mergeType'])) {
            $model->mergeType = $map['mergeType'];
        }
        if (isset($map['operatorId'])) {
            $model->operatorId = $map['operatorId'];
        }

        return $model;
    }
}
