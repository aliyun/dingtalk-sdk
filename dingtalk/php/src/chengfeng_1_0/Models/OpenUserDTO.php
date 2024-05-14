<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vchengfeng_1_0\Models;

use AlibabaCloud\Tea\Model;

class OpenUserDTO extends Model
{
    /**
     * @description This parameter is required.
     *
     * @example 1
     *
     * @var string
     */
    public $id;

    /**
     * @description This parameter is required.
     *
     * @example 王五
     *
     * @var string
     */
    public $name;

    /**
     * @description This parameter is required.
     *
     * @example 015310183065939140
     *
     * @var string
     */
    public $userId;
    protected $_name = [
        'id'     => 'id',
        'name'   => 'name',
        'userId' => 'userId',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->id) {
            $res['id'] = $this->id;
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
     * @return OpenUserDTO
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['id'])) {
            $model->id = $map['id'];
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
