<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vblackboard_1_0\Models;

use AlibabaCloud\Tea\Model;

class QueryBlackboardSpaceRequest extends Model
{
    /**
     * @description 操作人userId。
     *
     * @var string
     */
    public $operationUserId;
    protected $_name = [
        'operationUserId' => 'operationUserId',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->operationUserId) {
            $res['operationUserId'] = $this->operationUserId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return QueryBlackboardSpaceRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['operationUserId'])) {
            $model->operationUserId = $map['operationUserId'];
        }

        return $model;
    }
}
