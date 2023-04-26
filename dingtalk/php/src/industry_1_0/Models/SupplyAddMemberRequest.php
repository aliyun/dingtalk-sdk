<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models;

use AlibabaCloud\Tea\Model;

class SupplyAddMemberRequest extends Model
{
    /**
     * @example false
     *
     * @var bool
     */
    public $isPartnerManager;

    /**
     * @example 187xxxx0001
     *
     * @var string
     */
    public $memberMobile;

    /**
     * @example 李白
     *
     * @var string
     */
    public $memberName;

    /**
     * @example 1001
     *
     * @var string
     */
    public $memberWorkNumber;

    /**
     * @example 1111
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
