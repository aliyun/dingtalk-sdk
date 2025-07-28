<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vhrm_1_0\Models;

use AlibabaCloud\Tea\Model;

class UpdateHrmLegalEntityNameRequest extends Model
{
    /**
     * @example 57
     *
     * @var int
     */
    public $dingTenantId;

    /**
     * @description This parameter is required.
     *
     * @example 公司2
     *
     * @var string
     */
    public $legalEntityName;

    /**
     * @description This parameter is required.
     *
     * @example 公司1
     *
     * @var string
     */
    public $originLegalEntityName;
    protected $_name = [
        'dingTenantId' => 'dingTenantId',
        'legalEntityName' => 'legalEntityName',
        'originLegalEntityName' => 'originLegalEntityName',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->dingTenantId) {
            $res['dingTenantId'] = $this->dingTenantId;
        }
        if (null !== $this->legalEntityName) {
            $res['legalEntityName'] = $this->legalEntityName;
        }
        if (null !== $this->originLegalEntityName) {
            $res['originLegalEntityName'] = $this->originLegalEntityName;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return UpdateHrmLegalEntityNameRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['dingTenantId'])) {
            $model->dingTenantId = $map['dingTenantId'];
        }
        if (isset($map['legalEntityName'])) {
            $model->legalEntityName = $map['legalEntityName'];
        }
        if (isset($map['originLegalEntityName'])) {
            $model->originLegalEntityName = $map['originLegalEntityName'];
        }

        return $model;
    }
}
