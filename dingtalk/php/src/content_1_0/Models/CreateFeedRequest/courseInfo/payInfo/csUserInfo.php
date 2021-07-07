<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vcontent_1_0\Models\CreateFeedRequest\courseInfo\payInfo;

use AlibabaCloud\Tea\Model;

class csUserInfo extends Model
{
    /**
     * @description 客服头像链接
     *
     * @var string
     */
    public $avatar;

    /**
     * @description 客服用户Id
     *
     * @var string
     */
    public $userId;

    /**
     * @description 客服用户名称
     *
     * @var string
     */
    public $name;
    protected $_name = [
        'avatar' => 'avatar',
        'userId' => 'userId',
        'name'   => 'name',
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
        if (null !== $this->userId) {
            $res['userId'] = $this->userId;
        }
        if (null !== $this->name) {
            $res['name'] = $this->name;
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
        if (isset($map['userId'])) {
            $model->userId = $map['userId'];
        }
        if (isset($map['name'])) {
            $model->name = $map['name'];
        }

        return $model;
    }
}
