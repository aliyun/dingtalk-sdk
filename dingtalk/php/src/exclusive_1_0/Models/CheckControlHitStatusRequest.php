<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vexclusive_1_0\Models;

use AlibabaCloud\Tea\Model;

class CheckControlHitStatusRequest extends Model
{
    /**
     * @var bool
     */
    public $needMissedFunction;

    /**
     * @description This parameter is required.
     *
     * @example staffId
     *
     * @var string
     */
    public $userId;
    protected $_name = [
        'needMissedFunction' => 'needMissedFunction',
        'userId' => 'userId',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->needMissedFunction) {
            $res['needMissedFunction'] = $this->needMissedFunction;
        }
        if (null !== $this->userId) {
            $res['userId'] = $this->userId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return CheckControlHitStatusRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['needMissedFunction'])) {
            $model->needMissedFunction = $map['needMissedFunction'];
        }
        if (isset($map['userId'])) {
            $model->userId = $map['userId'];
        }

        return $model;
    }
}
