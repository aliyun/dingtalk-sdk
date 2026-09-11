<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vcontact_1_0\Models;

use AlibabaCloud\Tea\Model;

class DeptGroupSettingUpdateRequest extends Model
{
    /**
     * @description This parameter is required.
     *
     * @var int
     */
    public $deptId;

    /**
     * @var bool
     */
    public $groupContainHiddenDept;

    /**
     * @var string[]
     */
    public $groupContainHrmEmployeeTypeLabels;

    /**
     * @var bool
     */
    public $groupContainOuterDept;

    /**
     * @var bool
     */
    public $groupContainSubDept;

    /**
     * @var string
     */
    public $permissionCode;

    /**
     * @var bool
     */
    public $syncMembers;
    protected $_name = [
        'deptId' => 'deptId',
        'groupContainHiddenDept' => 'groupContainHiddenDept',
        'groupContainHrmEmployeeTypeLabels' => 'groupContainHrmEmployeeTypeLabels',
        'groupContainOuterDept' => 'groupContainOuterDept',
        'groupContainSubDept' => 'groupContainSubDept',
        'permissionCode' => 'permissionCode',
        'syncMembers' => 'syncMembers',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->deptId) {
            $res['deptId'] = $this->deptId;
        }
        if (null !== $this->groupContainHiddenDept) {
            $res['groupContainHiddenDept'] = $this->groupContainHiddenDept;
        }
        if (null !== $this->groupContainHrmEmployeeTypeLabels) {
            $res['groupContainHrmEmployeeTypeLabels'] = $this->groupContainHrmEmployeeTypeLabels;
        }
        if (null !== $this->groupContainOuterDept) {
            $res['groupContainOuterDept'] = $this->groupContainOuterDept;
        }
        if (null !== $this->groupContainSubDept) {
            $res['groupContainSubDept'] = $this->groupContainSubDept;
        }
        if (null !== $this->permissionCode) {
            $res['permissionCode'] = $this->permissionCode;
        }
        if (null !== $this->syncMembers) {
            $res['syncMembers'] = $this->syncMembers;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return DeptGroupSettingUpdateRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['deptId'])) {
            $model->deptId = $map['deptId'];
        }
        if (isset($map['groupContainHiddenDept'])) {
            $model->groupContainHiddenDept = $map['groupContainHiddenDept'];
        }
        if (isset($map['groupContainHrmEmployeeTypeLabels'])) {
            if (!empty($map['groupContainHrmEmployeeTypeLabels'])) {
                $model->groupContainHrmEmployeeTypeLabels = $map['groupContainHrmEmployeeTypeLabels'];
            }
        }
        if (isset($map['groupContainOuterDept'])) {
            $model->groupContainOuterDept = $map['groupContainOuterDept'];
        }
        if (isset($map['groupContainSubDept'])) {
            $model->groupContainSubDept = $map['groupContainSubDept'];
        }
        if (isset($map['permissionCode'])) {
            $model->permissionCode = $map['permissionCode'];
        }
        if (isset($map['syncMembers'])) {
            $model->syncMembers = $map['syncMembers'];
        }

        return $model;
    }
}
