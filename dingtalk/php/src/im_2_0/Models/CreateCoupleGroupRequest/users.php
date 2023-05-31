<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vim_2_0\Models\CreateCoupleGroupRequest;

use AlibabaCloud\Tea\Model;

class users extends Model
{
    /**
     * @example 1107****2120
     *
     * @var string
     */
    public $appUserId;

    /**
     * @var bool
     */
    public $groupOwner;

    /**
     * @example 1745****8778
     *
     * @var string
     */
    public $userId;
    protected $_name = [
        'appUserId'  => 'appUserId',
        'groupOwner' => 'groupOwner',
        'userId'     => 'userId',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->appUserId) {
            $res['appUserId'] = $this->appUserId;
        }
        if (null !== $this->groupOwner) {
            $res['groupOwner'] = $this->groupOwner;
        }
        if (null !== $this->userId) {
            $res['userId'] = $this->userId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return users
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['appUserId'])) {
            $model->appUserId = $map['appUserId'];
        }
        if (isset($map['groupOwner'])) {
            $model->groupOwner = $map['groupOwner'];
        }
        if (isset($map['userId'])) {
            $model->userId = $map['userId'];
        }

        return $model;
    }
}
