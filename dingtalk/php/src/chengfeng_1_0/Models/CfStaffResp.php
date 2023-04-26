<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vchengfeng_1_0\Models;

use AlibabaCloud\Tea\Model;

class CfStaffResp extends Model
{
    /**
     * @example 123
     *
     * @var string
     */
    public $deptCode;

    /**
     * @example 开发部
     *
     * @var string
     */
    public $deptName;

    /**
     * @example 17*******@qq.com
     *
     * @var string
     */
    public $email;

    /**
     * @example 151********
     *
     * @var string
     */
    public $mobile;

    /**
     * @example 张三
     *
     * @var string
     */
    public $name;

    /**
     * @example 松柏
     *
     * @var string
     */
    public $nickName;

    /**
     * @example 123456
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
