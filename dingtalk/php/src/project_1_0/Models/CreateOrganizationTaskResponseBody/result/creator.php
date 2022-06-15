<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vproject_1_0\Models\CreateOrganizationTaskResponseBody\result;

use AlibabaCloud\Tea\Model;

class creator extends Model
{
    /**
     * @description 创建者头像地址
     *
     * @var string
     */
    public $avatarUrl;

    /**
     * @description 创建者姓名
     *
     * @var string
     */
    public $name;

    /**
     * @description 创建者id
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
     * @return creator
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
