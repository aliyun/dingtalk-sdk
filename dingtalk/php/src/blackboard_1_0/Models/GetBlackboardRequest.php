<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vblackboard_1_0\Models;

use AlibabaCloud\Tea\Model;

class GetBlackboardRequest extends Model
{
    /**
     * @example ca80xxxx0a04
     *
     * @var string
     */
    public $blackboardId;

    /**
     * @example manager01
     *
     * @var string
     */
    public $operationUserId;
    protected $_name = [
        'blackboardId' => 'blackboardId',
        'operationUserId' => 'operationUserId',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->blackboardId) {
            $res['blackboardId'] = $this->blackboardId;
        }
        if (null !== $this->operationUserId) {
            $res['operationUserId'] = $this->operationUserId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return GetBlackboardRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['blackboardId'])) {
            $model->blackboardId = $map['blackboardId'];
        }
        if (isset($map['operationUserId'])) {
            $model->operationUserId = $map['operationUserId'];
        }

        return $model;
    }
}
