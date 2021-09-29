<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vyida_1_0\Models\GetInstancesResponseBody\data;

use AlibabaCloud\SDK\Dingtalk\Vyida_1_0\Models\GetInstancesResponseBody\data\actionExecutor\name;
use AlibabaCloud\Tea\Model;

class actionExecutor extends Model
{
    /**
     * @description name
     *
     * @var name
     */
    public $name;

    /**
     * @description deptName
     *
     * @var string
     */
    public $deptName;

    /**
     * @description userId
     *
     * @var string
     */
    public $userId;

    /**
     * @description email
     *
     * @var string
     */
    public $email;
    protected $_name = [
        'name'     => 'name',
        'deptName' => 'deptName',
        'userId'   => 'userId',
        'email'    => 'email',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->name) {
            $res['name'] = null !== $this->name ? $this->name->toMap() : null;
        }
        if (null !== $this->deptName) {
            $res['deptName'] = $this->deptName;
        }
        if (null !== $this->userId) {
            $res['userId'] = $this->userId;
        }
        if (null !== $this->email) {
            $res['email'] = $this->email;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return actionExecutor
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['name'])) {
            $model->name = name::fromMap($map['name']);
        }
        if (isset($map['deptName'])) {
            $model->deptName = $map['deptName'];
        }
        if (isset($map['userId'])) {
            $model->userId = $map['userId'];
        }
        if (isset($map['email'])) {
            $model->email = $map['email'];
        }

        return $model;
    }
}
