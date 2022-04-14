<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vyida_1_0\Models\SearchFormDataRemovalTableDataResponseBody\data;

use AlibabaCloud\SDK\Dingtalk\Vyida_1_0\Models\SearchFormDataRemovalTableDataResponseBody\data\modifyUser\name;
use AlibabaCloud\Tea\Model;

class modifyUser extends Model
{
    /**
     * @description 部门名称
     *
     * @var string
     */
    public $departmentName;

    /**
     * @description 电子邮箱
     *
     * @var string
     */
    public $email;

    /**
     * @description 名称
     *
     * @var name
     */
    public $name;

    /**
     * @description 钉钉userId
     *
     * @var string
     */
    public $userId;
    protected $_name = [
        'departmentName' => 'departmentName',
        'email'          => 'email',
        'name'           => 'name',
        'userId'         => 'userId',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->departmentName) {
            $res['departmentName'] = $this->departmentName;
        }
        if (null !== $this->email) {
            $res['email'] = $this->email;
        }
        if (null !== $this->name) {
            $res['name'] = null !== $this->name ? $this->name->toMap() : null;
        }
        if (null !== $this->userId) {
            $res['userId'] = $this->userId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return modifyUser
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['departmentName'])) {
            $model->departmentName = $map['departmentName'];
        }
        if (isset($map['email'])) {
            $model->email = $map['email'];
        }
        if (isset($map['name'])) {
            $model->name = name::fromMap($map['name']);
        }
        if (isset($map['userId'])) {
            $model->userId = $map['userId'];
        }

        return $model;
    }
}
