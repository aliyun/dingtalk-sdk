<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vexclusive_1_0\Models\GetUserRealPeopleStateResponseBody;

use AlibabaCloud\Tea\Model;

class data extends Model
{
    /**
     * @description 认证状态 1-未认证 2-已认证
     *
     * @var int
     */
    public $state;

    /**
     * @description userId
     *
     * @var string
     */
    public $userId;
    protected $_name = [
        'state'  => 'state',
        'userId' => 'userId',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->state) {
            $res['state'] = $this->state;
        }
        if (null !== $this->userId) {
            $res['userId'] = $this->userId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return data
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['state'])) {
            $model->state = $map['state'];
        }
        if (isset($map['userId'])) {
            $model->userId = $map['userId'];
        }

        return $model;
    }
}
