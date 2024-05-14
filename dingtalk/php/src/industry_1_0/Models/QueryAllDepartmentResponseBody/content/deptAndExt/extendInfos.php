<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models\QueryAllDepartmentResponseBody\content\deptAndExt;

use AlibabaCloud\Tea\Model;

class extendInfos extends Model
{
    /**
     * @description This parameter is required.
     *
     * @example asd123
     *
     * @var string
     */
    public $deptCode;

    /**
     * @description This parameter is required.
     *
     * @example 科室、医务科、医生都不一样
     *
     * @var string
     */
    public $deptExtendDisplayName;

    /**
     * @description This parameter is required.
     *
     * @example 科室、医务科、医生都不一样
     *
     * @var string
     */
    public $deptExtendKey;

    /**
     * @description This parameter is required.
     *
     * @example 科室、医务科、医生都不一样
     *
     * @var string
     */
    public $deptExtendValue;

    /**
     * @description This parameter is required.
     *
     * @example 2021-08-24 20:30:31
     *
     * @var string
     */
    public $gmtCreateStr;

    /**
     * @description This parameter is required.
     *
     * @example 2021-08-24 20:30:31
     *
     * @var string
     */
    public $gmtModifiedStr;

    /**
     * @description This parameter is required.
     *
     * @example 20000
     *
     * @var int
     */
    public $id;

    /**
     * @description This parameter is required.
     *
     * @example 0
     *
     * @var int
     */
    public $status;
    protected $_name = [
        'deptCode'              => 'deptCode',
        'deptExtendDisplayName' => 'deptExtendDisplayName',
        'deptExtendKey'         => 'deptExtendKey',
        'deptExtendValue'       => 'deptExtendValue',
        'gmtCreateStr'          => 'gmtCreateStr',
        'gmtModifiedStr'        => 'gmtModifiedStr',
        'id'                    => 'id',
        'status'                => 'status',
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
        if (null !== $this->deptExtendDisplayName) {
            $res['deptExtendDisplayName'] = $this->deptExtendDisplayName;
        }
        if (null !== $this->deptExtendKey) {
            $res['deptExtendKey'] = $this->deptExtendKey;
        }
        if (null !== $this->deptExtendValue) {
            $res['deptExtendValue'] = $this->deptExtendValue;
        }
        if (null !== $this->gmtCreateStr) {
            $res['gmtCreateStr'] = $this->gmtCreateStr;
        }
        if (null !== $this->gmtModifiedStr) {
            $res['gmtModifiedStr'] = $this->gmtModifiedStr;
        }
        if (null !== $this->id) {
            $res['id'] = $this->id;
        }
        if (null !== $this->status) {
            $res['status'] = $this->status;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return extendInfos
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['deptCode'])) {
            $model->deptCode = $map['deptCode'];
        }
        if (isset($map['deptExtendDisplayName'])) {
            $model->deptExtendDisplayName = $map['deptExtendDisplayName'];
        }
        if (isset($map['deptExtendKey'])) {
            $model->deptExtendKey = $map['deptExtendKey'];
        }
        if (isset($map['deptExtendValue'])) {
            $model->deptExtendValue = $map['deptExtendValue'];
        }
        if (isset($map['gmtCreateStr'])) {
            $model->gmtCreateStr = $map['gmtCreateStr'];
        }
        if (isset($map['gmtModifiedStr'])) {
            $model->gmtModifiedStr = $map['gmtModifiedStr'];
        }
        if (isset($map['id'])) {
            $model->id = $map['id'];
        }
        if (isset($map['status'])) {
            $model->status = $map['status'];
        }

        return $model;
    }
}
