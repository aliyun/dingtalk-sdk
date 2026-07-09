<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vcontact_1_0\Models;

use AlibabaCloud\Tea\Model;

class CreateUserGroupRequest extends Model
{
    /**
     * @description This parameter is required.
     *
     * @var bool
     */
    public $clientShow;

    /**
     * @example 静态用户组
     *
     * @var string
     */
    public $description;

    /**
     * @description This parameter is required.
     *
     * @example 静态用户组
     *
     * @var string
     */
    public $name;
    protected $_name = [
        'clientShow' => 'clientShow',
        'description' => 'description',
        'name' => 'name',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->clientShow) {
            $res['clientShow'] = $this->clientShow;
        }
        if (null !== $this->description) {
            $res['description'] = $this->description;
        }
        if (null !== $this->name) {
            $res['name'] = $this->name;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return CreateUserGroupRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['clientShow'])) {
            $model->clientShow = $map['clientShow'];
        }
        if (isset($map['description'])) {
            $model->description = $map['description'];
        }
        if (isset($map['name'])) {
            $model->name = $map['name'];
        }

        return $model;
    }
}
