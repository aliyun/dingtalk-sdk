<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vworkflow_1_0\Models\ProcessForecastResponseBody\result\workflowActors;

use AlibabaCloud\Tea\Model;

class activityActors extends Model
{
    /**
     * @description 用户 id
     *
     * @var string
     */
    public $userId;

    /**
     * @description 用户名字
     *
     * @var string
     */
    public $name;

    /**
     * @description 用户头像
     *
     * @var string
     */
    public $avatar;
    protected $_name = [
        'userId' => 'userId',
        'name'   => 'name',
        'avatar' => 'avatar',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->userId) {
            $res['userId'] = $this->userId;
        }
        if (null !== $this->name) {
            $res['name'] = $this->name;
        }
        if (null !== $this->avatar) {
            $res['avatar'] = $this->avatar;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return activityActors
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['userId'])) {
            $model->userId = $map['userId'];
        }
        if (isset($map['name'])) {
            $model->name = $map['name'];
        }
        if (isset($map['avatar'])) {
            $model->avatar = $map['avatar'];
        }

        return $model;
    }
}
