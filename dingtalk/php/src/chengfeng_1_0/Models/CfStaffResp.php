<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vchengfeng_1_0\Models;

use AlibabaCloud\Tea\Model;

class CfStaffResp extends Model
{
    /**
     * @description 部门编码
     *
     * @var string
     */
    public $deptCode;

    /**
     * @description 部门名称
     *
     * @var string
     */
    public $deptName;

    /**
     * @description 邮箱
     *
     * @var string
     */
    public $email;

    /**
     * @description 手机号
     *
     * @var string
     */
    public $mobile;

    /**
     * @description 姓名
     *
     * @var string
     */
    public $name;

    /**
     * @description 花名
     *
     * @var string
     */
    public $nickName;

    /**
     * @description 工号
     *
     * @var string
     */
    public $workNumbers;
    protected $_name = [
        'deptCode'    => 'deptCode',
        'deptName'    => 'deptName',
        'email'       => 'email',
        'mobile'      => 'mobile',
        'name'        => 'name',
        'nickName'    => 'nickName',
        'workNumbers' => 'workNumbers',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->deptCode) {
            $res['deptCode'] = $this->deptCode;
        }
        if (null !== $this->deptName) {
            $res['deptName'] = $this->deptName;
        }
        if (null !== $this->email) {
            $res['email'] = $this->email;
        }
        if (null !== $this->mobile) {
            $res['mobile'] = $this->mobile;
        }
        if (null !== $this->name) {
            $res['name'] = $this->name;
        }
        if (null !== $this->nickName) {
            $res['nickName'] = $this->nickName;
        }
        if (null !== $this->workNumbers) {
            $res['workNumbers'] = $this->workNumbers;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return CfStaffResp
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['deptCode'])) {
            $model->deptCode = $map['deptCode'];
        }
        if (isset($map['deptName'])) {
            $model->deptName = $map['deptName'];
        }
        if (isset($map['email'])) {
            $model->email = $map['email'];
        }
        if (isset($map['mobile'])) {
            $model->mobile = $map['mobile'];
        }
        if (isset($map['name'])) {
            $model->name = $map['name'];
        }
        if (isset($map['nickName'])) {
            $model->nickName = $map['nickName'];
        }
        if (isset($map['workNumbers'])) {
            $model->workNumbers = $map['workNumbers'];
        }

        return $model;
    }
}
