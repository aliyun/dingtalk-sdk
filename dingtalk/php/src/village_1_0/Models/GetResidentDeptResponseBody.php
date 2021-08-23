<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vvillage_1_0\Models;

use AlibabaCloud\Tea\Model;

class GetResidentDeptResponseBody extends Model
{
    /**
     * @description 部门ID
     *
     * @var int
     */
    public $deptId;

    /**
     * @description 部门名称
     *
     * @var string
     */
    public $name;

    /**
     * @description 部门类型
     *
     * @var string
     */
    public $deptType;

    /**
     * @description 通讯录架构类型
     *
     * @var string
     */
    public $contactType;

    /**
     * @description 部门属性
     *
     * @var string
     */
    public $feature;
    protected $_name = [
        'deptId'      => 'deptId',
        'name'        => 'name',
        'deptType'    => 'deptType',
        'contactType' => 'contactType',
        'feature'     => 'feature',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->deptId) {
            $res['deptId'] = $this->deptId;
        }
        if (null !== $this->name) {
            $res['name'] = $this->name;
        }
        if (null !== $this->deptType) {
            $res['deptType'] = $this->deptType;
        }
        if (null !== $this->contactType) {
            $res['contactType'] = $this->contactType;
        }
        if (null !== $this->feature) {
            $res['feature'] = $this->feature;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return GetResidentDeptResponseBody
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['deptId'])) {
            $model->deptId = $map['deptId'];
        }
        if (isset($map['name'])) {
            $model->name = $map['name'];
        }
        if (isset($map['deptType'])) {
            $model->deptType = $map['deptType'];
        }
        if (isset($map['contactType'])) {
            $model->contactType = $map['contactType'];
        }
        if (isset($map['feature'])) {
            $model->feature = $map['feature'];
        }

        return $model;
    }
}
