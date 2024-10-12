<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vteam_sphere_1_0\Models\CreateOrganizationTaskResponseBody\result;

use AlibabaCloud\Tea\Model;

class executor extends Model
{
    /**
     * @example https://xxxxxxxxxx
     *
     * @var string
     */
    public $avatarUrl;

    /**
     * @example 鬼斩
     *
     * @var string
     */
    public $name;

    /**
     * @example 173xxxx
     *
     * @var string
     */
    public $userId;
    protected $_name = [
        'avatarUrl' => 'avatarUrl',
        'name'      => 'name',
        'userId'    => 'userId',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->avatarUrl) {
            $res['avatarUrl'] = $this->avatarUrl;
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
     * @return executor
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['avatarUrl'])) {
            $model->avatarUrl = $map['avatarUrl'];
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
