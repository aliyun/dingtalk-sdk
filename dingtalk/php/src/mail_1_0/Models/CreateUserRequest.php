<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vmail_1_0\Models;

use AlibabaCloud\Tea\Model;

class CreateUserRequest extends Model
{
    /**
     * @description This parameter is required.
     *
     * @example user@yourcompany.org
     *
     * @var string
     */
    public $email;

    /**
     * @description This parameter is required.
     *
     * @var string
     */
    public $employeeType;

    /**
     * @description This parameter is required.
     *
     * @var string
     */
    public $name;

    /**
     * @description This parameter is required.
     *
     * @example password
     *
     * @var string
     */
    public $password;
    protected $_name = [
        'email' => 'email',
        'employeeType' => 'employeeType',
        'name' => 'name',
        'password' => 'password',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->email) {
            $res['email'] = $this->email;
        }
        if (null !== $this->employeeType) {
            $res['employeeType'] = $this->employeeType;
        }
        if (null !== $this->name) {
            $res['name'] = $this->name;
        }
        if (null !== $this->password) {
            $res['password'] = $this->password;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return CreateUserRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['email'])) {
            $model->email = $map['email'];
        }
        if (isset($map['employeeType'])) {
            $model->employeeType = $map['employeeType'];
        }
        if (isset($map['name'])) {
            $model->name = $map['name'];
        }
        if (isset($map['password'])) {
            $model->password = $map['password'];
        }

        return $model;
    }
}
