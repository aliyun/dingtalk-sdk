<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vyida_1_0\Models\GetInstancesByIdListResponseBody\result;

use AlibabaCloud\SDK\Dingtalk\Vyida_1_0\Models\GetInstancesByIdListResponseBody\result\originator\name;
use AlibabaCloud\Tea\Model;

class originator extends Model
{
    /**
     * @description 用户工号
     *
     * @var string
     */
    public $userId;

    /**
     * @description 用户名
     *
     * @var name
     */
    public $name;

    /**
     * @description 部门名称
     *
     * @var string
     */
    public $departmentName;

    /**
     * @description 邮箱
     *
     * @var string
     */
    public $email;
    protected $_name = [
        'userId'         => 'userId',
        'name'           => 'name',
        'departmentName' => 'departmentName',
        'email'          => 'email',
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
            $res['name'] = null !== $this->name ? $this->name->toMap() : null;
        }
        if (null !== $this->departmentName) {
            $res['departmentName'] = $this->departmentName;
        }
        if (null !== $this->email) {
            $res['email'] = $this->email;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return originator
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['userId'])) {
            $model->userId = $map['userId'];
        }
        if (isset($map['name'])) {
            $model->name = name::fromMap($map['name']);
        }
        if (isset($map['departmentName'])) {
            $model->departmentName = $map['departmentName'];
        }
        if (isset($map['email'])) {
            $model->email = $map['email'];
        }

        return $model;
    }
}
