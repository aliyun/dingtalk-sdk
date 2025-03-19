<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vcrm_1_0\Models;

use AlibabaCloud\Tea\Model;

class OverrideUpdateCustomerDataAuthRequest extends Model
{
    /**
     * @description This parameter is required.
     *
     * @var string[]
     */
    public $customerIds;

    /**
     * @description This parameter is required.
     *
     * @var string[]
     */
    public $dataAuthUserIds;

    /**
     * @example PROC-98187D45-EFC0-4FC4-887E-45BD24209D69
     *
     * @var string
     */
    public $formCode;

    /**
     * @description This parameter is required.
     *
     * @example staffId2
     *
     * @var string
     */
    public $operateUserId;

    /**
     * @example crm_customer
     *
     * @var string
     */
    public $relationType;

    /**
     * @description This parameter is required.
     *
     * @example owner
     *
     * @var string
     */
    public $roleType;
    protected $_name = [
        'customerIds' => 'customerIds',
        'dataAuthUserIds' => 'dataAuthUserIds',
        'formCode' => 'formCode',
        'operateUserId' => 'operateUserId',
        'relationType' => 'relationType',
        'roleType' => 'roleType',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->customerIds) {
            $res['customerIds'] = $this->customerIds;
        }
        if (null !== $this->dataAuthUserIds) {
            $res['dataAuthUserIds'] = $this->dataAuthUserIds;
        }
        if (null !== $this->formCode) {
            $res['formCode'] = $this->formCode;
        }
        if (null !== $this->operateUserId) {
            $res['operateUserId'] = $this->operateUserId;
        }
        if (null !== $this->relationType) {
            $res['relationType'] = $this->relationType;
        }
        if (null !== $this->roleType) {
            $res['roleType'] = $this->roleType;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return OverrideUpdateCustomerDataAuthRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['customerIds'])) {
            if (!empty($map['customerIds'])) {
                $model->customerIds = $map['customerIds'];
            }
        }
        if (isset($map['dataAuthUserIds'])) {
            if (!empty($map['dataAuthUserIds'])) {
                $model->dataAuthUserIds = $map['dataAuthUserIds'];
            }
        }
        if (isset($map['formCode'])) {
            $model->formCode = $map['formCode'];
        }
        if (isset($map['operateUserId'])) {
            $model->operateUserId = $map['operateUserId'];
        }
        if (isset($map['relationType'])) {
            $model->relationType = $map['relationType'];
        }
        if (isset($map['roleType'])) {
            $model->roleType = $map['roleType'];
        }

        return $model;
    }
}
