<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vproject_1_0\Models\CreateOrganizationTaskResponseBody\result;

use AlibabaCloud\Tea\Model;

class involvers extends Model
{
    /**
     * @description 头像
     *
     * @var string
     */
    public $avatarUrl;

    /**
     * @description 用户id
     *
     * @var string
     */
    public $id;

    /**
     * @description 名字
     *
     * @var string
     */
    public $name;
    protected $_name = [
        'avatarUrl' => 'avatarUrl',
        'id'        => 'id',
        'name'      => 'name',
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
        if (null !== $this->id) {
            $res['id'] = $this->id;
        }
        if (null !== $this->name) {
            $res['name'] = $this->name;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return involvers
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['avatarUrl'])) {
            $model->avatarUrl = $map['avatarUrl'];
        }
        if (isset($map['id'])) {
            $model->id = $map['id'];
        }
        if (isset($map['name'])) {
            $model->name = $map['name'];
        }

        return $model;
    }
}
