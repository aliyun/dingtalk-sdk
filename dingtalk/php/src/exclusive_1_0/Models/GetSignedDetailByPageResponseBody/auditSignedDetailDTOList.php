<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vexclusive_1_0\Models\GetSignedDetailByPageResponseBody;

use AlibabaCloud\Tea\Model;

class auditSignedDetailDTOList extends Model
{
    /**
     * @description 部门名称
     *
     * @var string
     */
    public $deptName;

    /**
     * @description 邮件
     *
     * @var string
     */
    public $email;

    /**
     * @description 员工名称
     *
     * @var string
     */
    public $name;

    /**
     * @description 手机号
     *
     * @var string
     */
    public $phone;

    /**
     * @description 角色
     *
     * @var string
     */
    public $roles;

    /**
     * @description 工号
     *
     * @var string
     */
    public $staffId;

    /**
     * @description 职位
     *
     * @var string
     */
    public $title;
    protected $_name = [
        'deptName' => 'deptName',
        'email'    => 'email',
        'name'     => 'name',
        'phone'    => 'phone',
        'roles'    => 'roles',
        'staffId'  => 'staffId',
        'title'    => 'title',
    ];

    public function validate()
    {
    }

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
