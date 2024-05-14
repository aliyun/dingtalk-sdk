<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vresident_1_0\Models;

use AlibabaCloud\SDK\Dingtalk\Vresident_1_0\Models\UpdateResidentUserRequest\extField;
use AlibabaCloud\Tea\Model;

class UpdateResidentUserRequest extends Model
{
    /**
     * @example 美好社区创景街道万通公寓
     *
     * @var string
     */
    public $address;

    /**
     * @description This parameter is required.
     *
     * @example 12345
     *
     * @var int
     */
    public $departmentId;

    /**
     * @var extField[]
     */
    public $extField;

    /**
     * @example false
     *
     * @var bool
     */
    public $isRetainOldDept;

    /**
     * @example 15612345678
     *
     * @var string
     */
    public $mobile;

    /**
     * @description This parameter is required.
     *
     * @example 12345
     *
     * @var int
     */
    public $oldDepartmentId;

    /**
     * @example SELF
     *
     * @var string
     */
    public $relateType;

    /**
     * @description This parameter is required.
     *
     * @example 12345
     *
     * @var string
     */
    public $userId;

    /**
     * @description This parameter is required.
     *
     * @example 王建国
     *
     * @var string
     */
    public $userName;
    protected $_name = [
        'address'         => 'address',
        'departmentId'    => 'departmentId',
        'extField'        => 'extField',
        'isRetainOldDept' => 'isRetainOldDept',
        'mobile'          => 'mobile',
        'oldDepartmentId' => 'oldDepartmentId',
        'relateType'      => 'relateType',
        'userId'          => 'userId',
        'userName'        => 'userName',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->address) {
            $res['address'] = $this->address;
        }
        if (null !== $this->departmentId) {
            $res['departmentId'] = $this->departmentId;
        }
        if (null !== $this->extField) {
            $res['extField'] = [];
            if (null !== $this->extField && \is_array($this->extField)) {
                $n = 0;
                foreach ($this->extField as $item) {
                    $res['extField'][$n++] = null !== $item ? $item->toMap() : $item;
                }
            }
        }
        if (null !== $this->isRetainOldDept) {
            $res['isRetainOldDept'] = $this->isRetainOldDept;
        }
        if (null !== $this->mobile) {
            $res['mobile'] = $this->mobile;
        }
        if (null !== $this->oldDepartmentId) {
            $res['oldDepartmentId'] = $this->oldDepartmentId;
        }
        if (null !== $this->relateType) {
            $res['relateType'] = $this->relateType;
        }
        if (null !== $this->userId) {
            $res['userId'] = $this->userId;
        }
        if (null !== $this->userName) {
            $res['userName'] = $this->userName;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return UpdateResidentUserRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['address'])) {
            $model->address = $map['address'];
        }
        if (isset($map['departmentId'])) {
            $model->departmentId = $map['departmentId'];
        }
        if (isset($map['extField'])) {
            if (!empty($map['extField'])) {
                $model->extField = [];
                $n               = 0;
                foreach ($map['extField'] as $item) {
                    $model->extField[$n++] = null !== $item ? extField::fromMap($item) : $item;
                }
            }
        }
        if (isset($map['isRetainOldDept'])) {
            $model->isRetainOldDept = $map['isRetainOldDept'];
        }
        if (isset($map['mobile'])) {
            $model->mobile = $map['mobile'];
        }
        if (isset($map['oldDepartmentId'])) {
            $model->oldDepartmentId = $map['oldDepartmentId'];
        }
        if (isset($map['relateType'])) {
            $model->relateType = $map['relateType'];
        }
        if (isset($map['userId'])) {
            $model->userId = $map['userId'];
        }
        if (isset($map['userName'])) {
            $model->userName = $map['userName'];
        }

        return $model;
    }
}
