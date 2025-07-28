<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vexclusive_1_0\Models\PushBadgeRequest;

use AlibabaCloud\Tea\Model;

class badgeItems extends Model
{
    /**
     * @example 1
     *
     * @var string
     */
    public $pushValue;

    /**
     * @example 12345
     *
     * @var string
     */
    public $userId;
    protected $_name = [
        'pushValue' => 'pushValue',
        'userId' => 'userId',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->pushValue) {
            $res['pushValue'] = $this->pushValue;
        }
        if (null !== $this->userId) {
            $res['userId'] = $this->userId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return badgeItems
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['pushValue'])) {
            $model->pushValue = $map['pushValue'];
        }
        if (isset($map['userId'])) {
            $model->userId = $map['userId'];
        }

        return $model;
    }
}
