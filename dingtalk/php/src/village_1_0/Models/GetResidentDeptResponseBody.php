<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vvillage_1_0\Models;

use AlibabaCloud\Tea\Model;

class GetResidentDeptResponseBody extends Model
{
    /**
     * @description This parameter is required.
     *
     * @var string
     */
    public $contactType;

    /**
     * @description This parameter is required.
     *
     * @var int
     */
    public $departmentId;

    /**
     * @description This parameter is required.
     *
     * @var string
     */
    public $departmentName;

    /**
     * @description This parameter is required.
     *
     * @var string
     */
    public $deptType;

    /**
     * @description This parameter is required.
     *
     * @var string
     */
    public $feature;
    protected $_name = [
        'contactType' => 'contactType',
        'departmentId' => 'departmentId',
        'departmentName' => 'departmentName',
        'deptType' => 'deptType',
        'feature' => 'feature',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->contactType) {
            $res['contactType'] = $this->contactType;
        }
        if (null !== $this->departmentId) {
            $res['departmentId'] = $this->departmentId;
        }
        if (null !== $this->departmentName) {
            $res['departmentName'] = $this->departmentName;
        }
        if (null !== $this->deptType) {
            $res['deptType'] = $this->deptType;
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
        if (isset($map['contactType'])) {
            $model->contactType = $map['contactType'];
        }
        if (isset($map['departmentId'])) {
            $model->departmentId = $map['departmentId'];
        }
        if (isset($map['departmentName'])) {
            $model->departmentName = $map['departmentName'];
        }
        if (isset($map['deptType'])) {
            $model->deptType = $map['deptType'];
        }
        if (isset($map['feature'])) {
            $model->feature = $map['feature'];
        }

        return $model;
    }
}
