<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vexclusive_1_0\Models\GetSignedDetailByPageResponseBody;

use AlibabaCloud\Tea\Model;

class auditSignedDetailDTOList extends Model
{
    /**
     * @example 部门1
     *
     * @var string
     */
    public $deptName;

    /**
     * @example **@**.com
     *
     * @var string
     */
    public $email;

    /**
     * @example 小张
     *
     * @var string
     */
    public $name;

    /**
     * @example ***
     *
     * @var string
     */
    public $phone;

    /**
     * @example 主管理员
     *
     * @var string
     */
    public $roles;

    /**
     * @example 123***
     *
     * @var string
     */
    public $staffId;

    /**
     * @example 经理
     *
     * @var string
     */
    public $title;
    protected $_name = [
        'deptName' => 'deptName',
        'email' => 'email',
        'name' => 'name',
        'phone' => 'phone',
        'roles' => 'roles',
        'staffId' => 'staffId',
        'title' => 'title',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->deptName) {
            $res['deptName'] = $this->deptName;
        }
        if (null !== $this->email) {
            $res['email'] = $this->email;
        }
        if (null !== $this->name) {
            $res['name'] = $this->name;
        }
        if (null !== $this->phone) {
            $res['phone'] = $this->phone;
        }
        if (null !== $this->roles) {
            $res['roles'] = $this->roles;
        }
        if (null !== $this->staffId) {
            $res['staffId'] = $this->staffId;
        }
        if (null !== $this->title) {
            $res['title'] = $this->title;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return auditSignedDetailDTOList
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['deptName'])) {
            $model->deptName = $map['deptName'];
        }
        if (isset($map['email'])) {
            $model->email = $map['email'];
        }
        if (isset($map['name'])) {
            $model->name = $map['name'];
        }
        if (isset($map['phone'])) {
            $model->phone = $map['phone'];
        }
        if (isset($map['roles'])) {
            $model->roles = $map['roles'];
        }
        if (isset($map['staffId'])) {
            $model->staffId = $map['staffId'];
        }
        if (isset($map['title'])) {
            $model->title = $map['title'];
        }

        return $model;
    }
}
