<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vcontent_1_0\Models\CreateFeedRequest\courseInfo\payInfo;

use AlibabaCloud\Tea\Model;

class csUserInfo extends Model
{
    /**
     * @example https://static.dingtalk.com/media/lA****************p_169_169.png_60x60q90.jpg?bizType=avatar
     *
     * @var string
     */
    public $avatar;

    /**
     * @description This parameter is required.
     *
     * @example 用户名
     *
     * @var string
     */
    public $name;

    /**
     * @description This parameter is required.
     *
     * @example 16621*******284773
     *
     * @var string
     */
    public $userId;
    protected $_name = [
        'avatar' => 'avatar',
        'name'   => 'name',
        'userId' => 'userId',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->avatar) {
            $res['avatar'] = $this->avatar;
        }
        if (null !== $this->name) {
            $res['name'] = $this->name;
        }
        if (null !== $this->userId) {
            $res['userId'] = $this->userId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return csUserInfo
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['avatar'])) {
            $model->avatar = $map['avatar'];
        }
        if (isset($map['name'])) {
            $model->name = $map['name'];
        }
        if (isset($map['userId'])) {
            $model->userId = $map['userId'];
        }

        return $model;
    }
}
