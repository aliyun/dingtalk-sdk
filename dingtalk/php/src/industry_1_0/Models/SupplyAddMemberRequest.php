<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models;

use AlibabaCloud\Tea\Model;

class SupplyAddMemberRequest extends Model
{
    /**
     * @description 是否为伙伴负责人
     *
     * @var bool
     */
    public $isPartnerManager;

    /**
     * @description 成员手机号
     *
     * @var string
     */
    public $memberMobile;

    /**
     * @description 成员名字
     *
     * @var string
     */
    public $memberName;

    /**
     * @description 成员编码/工号
     *
     * @var string
     */
    public $memberWorkNumber;

    /**
     * @description 所属伙伴/子部门
     *
     * @var int
     */
    public $supplyDeptId;
    protected $_name = [
        'isPartnerManager' => 'isPartnerManager',
        'memberMobile'     => 'memberMobile',
        'memberName'       => 'memberName',
        'memberWorkNumber' => 'memberWorkNumber',
        'supplyDeptId'     => 'supplyDeptId',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->isPartnerManager) {
            $res['isPartnerManager'] = $this->isPartnerManager;
        }
        if (null !== $this->memberMobile) {
            $res['memberMobile'] = $this->memberMobile;
        }
        if (null !== $this->memberName) {
            $res['memberName'] = $this->memberName;
        }
        if (null !== $this->memberWorkNumber) {
            $res['memberWorkNumber'] = $this->memberWorkNumber;
        }
        if (null !== $this->supplyDeptId) {
            $res['supplyDeptId'] = $this->supplyDeptId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return SupplyAddMemberRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['isPartnerManager'])) {
            $model->isPartnerManager = $map['isPartnerManager'];
        }
        if (isset($map['memberMobile'])) {
            $model->memberMobile = $map['memberMobile'];
        }
        if (isset($map['memberName'])) {
            $model->memberName = $map['memberName'];
        }
        if (isset($map['memberWorkNumber'])) {
            $model->memberWorkNumber = $map['memberWorkNumber'];
        }
        if (isset($map['supplyDeptId'])) {
            $model->supplyDeptId = $map['supplyDeptId'];
        }

        return $model;
    }
}
