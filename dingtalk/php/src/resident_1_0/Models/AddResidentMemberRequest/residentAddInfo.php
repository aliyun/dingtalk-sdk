<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vresident_1_0\Models\AddResidentMemberRequest;

use AlibabaCloud\Tea\Model;

class residentAddInfo extends Model
{
    /**
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
     * @var mixed[]
     */
    public $memberDeptExtension;

    /**
     * @example 148********
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
     * @example 1
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
