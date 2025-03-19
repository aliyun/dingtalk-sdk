<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vresident_1_0\Models\UpdateResidentMemberRequest;

use AlibabaCloud\Tea\Model;

class residentUpdateInfo extends Model
{
    /**
     * @description This parameter is required.
     *
     * @example 11112
     *
     * @var int
     */
    public $deptId;

    /**
     * @example true
     *
     * @var bool
     */
    public $isPropertyOwner;

    /**
     * @example {"startTime":1652358627106,"endTime":1652445027106}
     *
     * @var string[]
     */
    public $memberDeptExtension;

    /**
     * @description This parameter is required.
     *
     * @example 张三
     *
     * @var string
     */
    public $name;

    /**
     * @description This parameter is required.
     *
     * @example 11123
     *
     * @var int
     */
    public $oldDeptId;

    /**
     * @example 1
     *
     * @var string
     */
    public $relateType;

    /**
     * @example 11123
     *
     * @var string
     */
    public $userId;
    protected $_name = [
        'deptId' => 'deptId',
        'isPropertyOwner' => 'isPropertyOwner',
        'memberDeptExtension' => 'memberDeptExtension',
        'name' => 'name',
        'oldDeptId' => 'oldDeptId',
        'relateType' => 'relateType',
        'userId' => 'userId',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->deptId) {
            $res['deptId'] = $this->deptId;
        }
        if (null !== $this->isPropertyOwner) {
            $res['isPropertyOwner'] = $this->isPropertyOwner;
        }
        if (null !== $this->memberDeptExtension) {
            $res['memberDeptExtension'] = $this->memberDeptExtension;
        }
        if (null !== $this->name) {
            $res['name'] = $this->name;
        }
        if (null !== $this->oldDeptId) {
            $res['oldDeptId'] = $this->oldDeptId;
        }
        if (null !== $this->relateType) {
            $res['relateType'] = $this->relateType;
        }
        if (null !== $this->userId) {
            $res['userId'] = $this->userId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return residentUpdateInfo
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['deptId'])) {
            $model->deptId = $map['deptId'];
        }
        if (isset($map['isPropertyOwner'])) {
            $model->isPropertyOwner = $map['isPropertyOwner'];
        }
        if (isset($map['memberDeptExtension'])) {
            $model->memberDeptExtension = $map['memberDeptExtension'];
        }
        if (isset($map['name'])) {
            $model->name = $map['name'];
        }
        if (isset($map['oldDeptId'])) {
            $model->oldDeptId = $map['oldDeptId'];
        }
        if (isset($map['relateType'])) {
            $model->relateType = $map['relateType'];
        }
        if (isset($map['userId'])) {
            $model->userId = $map['userId'];
        }

        return $model;
    }
}
