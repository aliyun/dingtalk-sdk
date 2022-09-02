<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vcontact_1_0\Models;

use AlibabaCloud\Tea\Model;

class IsFriendResponseBody extends Model
{
    /**
     * @description 是否有好友关系
     *
     * @var bool
     */
    public $isFriend;
    protected $_name = [
        'isFriend' => 'isFriend',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->isFriend) {
            $res['isFriend'] = $this->isFriend;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return IsFriendResponseBody
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['isFriend'])) {
            $model->isFriend = $map['isFriend'];
        }

        return $model;
    }
}
