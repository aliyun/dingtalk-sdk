<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vresident_1_0\Models\AddResidentMemberRequest;

use AlibabaCloud\Tea\Model;

class residentAddInfo extends Model
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
     * @var mixed[]
     */
    public $memberDeptExtension;

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
     * @description 身份，1：业主，2：租客，3：亲友
     *
     * @var string
     */
    public $relateType;
    protected $_name = [
        'deptId'              => 'deptId',
        'isPropertyOwner'     => 'isPropertyOwner',
        'memberDeptExtension' => 'memberDeptExtension',
        'mobile'              => 'mobile',
        'name'                => 'name',
        'relateType'          => 'relateType',
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
        if (null !== $this->mobile) {
            $res['mobile'] = $this->mobile;
        }
        if (null !== $this->name) {
            $res['name'] = $this->name;
        }
        if (null !== $this->relateType) {
            $res['relateType'] = $this->relateType;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return residentAddInfo
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
        if (isset($map['mobile'])) {
            $model->mobile = $map['mobile'];
        }
        if (isset($map['name'])) {
            $model->name = $map['name'];
        }
        if (isset($map['relateType'])) {
            $model->relateType = $map['relateType'];
        }

        return $model;
    }
}
