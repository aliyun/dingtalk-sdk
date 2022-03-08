<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vresident_1_0\Models\GetResidentInfoResponseBody;

use AlibabaCloud\Tea\Model;

class projectManager extends Model
{
    /**
     * @description 头像
     *
     * @var string
     */
    public $avatar;

    /**
     * @description 人员唯一标识
     *
     * @var string
     */
    public $userId;

    /**
     * @description 姓名
     *
     * @var string
     */
    public $userName;
    protected $_name = [
        'avatar'   => 'avatar',
        'userId'   => 'userId',
        'userName' => 'userName',
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
        if (null !== $this->userName) {
            $res['userName'] = $this->userName;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return projectManager
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
        if (isset($map['userName'])) {
            $model->userName = $map['userName'];
        }

        return $model;
    }
}
