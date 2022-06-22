<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vresident_1_0\Models\UpdateResidentMemberRequest;

use AlibabaCloud\Tea\Model;

class residentUpdateInfo extends Model
{
    /**
     * @description 部门id
     *
     * @var int
     */
    public $deptId;

    /**
     * @description 是否是产权人
     *
     * @var bool
     */
    public $isPropertyOwner;

    /**
     * @description 人员扩展信息，目前只有租客的起止时间
     *
     * @var string[]
     */
    public $memberDeptExtension;

    /**
     * @description 姓名
     *
     * @var string
     */
    public $name;

    /**
     * @description 旧部门id
     *
     * @var int
     */
    public $oldDeptId;

    /**
     * @description 身份，1：业主，2：租客，3：亲友
     *
     * @var string
     */
    public $relateType;

    /**
     * @description 用户id
     *
     * @var string
     */
    public $userId;
    protected $_name = [
        'deptId'              => 'deptId',
        'isPropertyOwner'     => 'isPropertyOwner',
        'memberDeptExtension' => 'memberDeptExtension',
        'name'                => 'name',
        'oldDeptId'           => 'oldDeptId',
        'relateType'          => 'relateType',
        'userId'              => 'userId',
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
