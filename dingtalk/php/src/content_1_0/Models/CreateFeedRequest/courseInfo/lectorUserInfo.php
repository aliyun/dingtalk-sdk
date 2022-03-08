<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vcontent_1_0\Models\CreateFeedRequest\courseInfo;

use AlibabaCloud\Tea\Model;

class lectorUserInfo extends Model
{
    /**
     * @description 讲师头像链接
     *
     * @var string
     */
    public $avatar;

    /**
     * @description 讲师用户名称
     *
     * @var string
     */
    public $name;

    /**
     * @description 讲师用户Id
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
     * @return lectorUserInfo
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
