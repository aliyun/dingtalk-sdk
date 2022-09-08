<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vlink_1_0\Models\GetFollowerInfoResponseBody;

use AlibabaCloud\SDK\Dingtalk\Vlink_1_0\Models\GetFollowerInfoResponseBody\result\user;
use AlibabaCloud\Tea\Model;

class result extends Model
{
    /**
     * @var user
     */
    public $user;
    protected $_name = [
        'user' => 'user',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->user) {
            $res['user'] = null !== $this->user ? $this->user->toMap() : null;
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
        if (isset($map['user'])) {
            $model->user = user::fromMap($map['user']);
        }

        return $model;
    }
}
