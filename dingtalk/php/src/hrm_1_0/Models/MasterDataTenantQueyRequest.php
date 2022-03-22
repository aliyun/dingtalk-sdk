<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vhrm_1_0\Models;

use AlibabaCloud\Tea\Model;

class MasterDataTenantQueyRequest extends Model
{
    /**
     * @description 实体 code
     *
     * @var string
     */
    public $entityCode;

    /**
     * @description isv的业务领域
     *
     * @var string
     */
    public $scopeCode;
    protected $_name = [
        'entityCode' => 'entityCode',
        'scopeCode'  => 'scopeCode',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->entityCode) {
            $res['entityCode'] = $this->entityCode;
        }
        if (null !== $this->scopeCode) {
            $res['scopeCode'] = $this->scopeCode;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return MasterDataTenantQueyRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['entityCode'])) {
            $model->entityCode = $map['entityCode'];
        }
        if (isset($map['scopeCode'])) {
            $model->scopeCode = $map['scopeCode'];
        }

        return $model;
    }
}
