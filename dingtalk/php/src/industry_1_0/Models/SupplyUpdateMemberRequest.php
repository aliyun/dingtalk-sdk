<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models;

use AlibabaCloud\Tea\Model;

class SupplyUpdateMemberRequest extends Model
{
    /**
     * @description This parameter is required.
     *
     * @var bool
     */
    public $isCopyDept;

    /**
     * @example 财务
     *
     * @var string
     */
    public $memberTitle;

    /**
     * @example 121212
     *
     * @var string
     */
    public $memberWorkNumber;

    /**
     * @example 13914772100
     *
     * @var string
     */
    public $mobile;

    /**
     * @description This parameter is required.
     *
     * @example 11
     *
     * @var int
     */
    public $newDeptId;

    /**
     * @description This parameter is required.
     *
     * @example 111
     *
     * @var int
     */
    public $oldDeptId;

    /**
     * @var string[]
     */
    public $roleIdList;

    /**
     * @example 111
     *
     * @var string
     */
    public $unionId;

    /**
     * @example 1212
     *
     * @var string
     */
    public $userId;
    protected $_name = [
        'isCopyDept' => 'isCopyDept',
        'memberTitle' => 'memberTitle',
        'memberWorkNumber' => 'memberWorkNumber',
        'mobile' => 'mobile',
        'newDeptId' => 'newDeptId',
        'oldDeptId' => 'oldDeptId',
        'roleIdList' => 'roleIdList',
        'unionId' => 'unionId',
        'userId' => 'userId',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->isCopyDept) {
            $res['isCopyDept'] = $this->isCopyDept;
        }
        if (null !== $this->memberTitle) {
            $res['memberTitle'] = $this->memberTitle;
        }
        if (null !== $this->memberWorkNumber) {
            $res['memberWorkNumber'] = $this->memberWorkNumber;
        }
        if (null !== $this->mobile) {
            $res['mobile'] = $this->mobile;
        }
        if (null !== $this->newDeptId) {
            $res['newDeptId'] = $this->newDeptId;
        }
        if (null !== $this->oldDeptId) {
            $res['oldDeptId'] = $this->oldDeptId;
        }
        if (null !== $this->roleIdList) {
            $res['roleIdList'] = $this->roleIdList;
        }
        if (null !== $this->unionId) {
            $res['unionId'] = $this->unionId;
        }
        if (null !== $this->userId) {
            $res['userId'] = $this->userId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return SupplyUpdateMemberRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['isCopyDept'])) {
            $model->isCopyDept = $map['isCopyDept'];
        }
        if (isset($map['memberTitle'])) {
            $model->memberTitle = $map['memberTitle'];
        }
        if (isset($map['memberWorkNumber'])) {
            $model->memberWorkNumber = $map['memberWorkNumber'];
        }
        if (isset($map['mobile'])) {
            $model->mobile = $map['mobile'];
        }
        if (isset($map['newDeptId'])) {
            $model->newDeptId = $map['newDeptId'];
        }
        if (isset($map['oldDeptId'])) {
            $model->oldDeptId = $map['oldDeptId'];
        }
        if (isset($map['roleIdList'])) {
            if (!empty($map['roleIdList'])) {
                $model->roleIdList = $map['roleIdList'];
            }
        }
        if (isset($map['unionId'])) {
            $model->unionId = $map['unionId'];
        }
        if (isset($map['userId'])) {
            $model->userId = $map['userId'];
        }

        return $model;
    }
}
