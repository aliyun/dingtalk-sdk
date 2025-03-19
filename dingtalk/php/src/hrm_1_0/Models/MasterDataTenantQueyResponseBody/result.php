<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vhrm_1_0\Models\MasterDataTenantQueyResponseBody;

use AlibabaCloud\Tea\Model;

class result extends Model
{
    /**
     * @example true
     *
     * @var bool
     */
    public $hasData;

    /**
     * @example true
     *
     * @var bool
     */
    public $integrateDataAuth;

    /**
     * @description This parameter is required.
     *
     * @example "智能绩效"
     *
     * @var string
     */
    public $name;

    /**
     * @example true
     *
     * @var bool
     */
    public $readAuth;

    /**
     * @description This parameter is required.
     *
     * @example 4
     *
     * @var int
     */
    public $tenantId;

    /**
     * @description This parameter is required.
     *
     * @example 1
     *
     * @var int
     */
    public $type;
    protected $_name = [
        'hasData' => 'hasData',
        'integrateDataAuth' => 'integrateDataAuth',
        'name' => 'name',
        'readAuth' => 'readAuth',
        'tenantId' => 'tenantId',
        'type' => 'type',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->hasData) {
            $res['hasData'] = $this->hasData;
        }
        if (null !== $this->integrateDataAuth) {
            $res['integrateDataAuth'] = $this->integrateDataAuth;
        }
        if (null !== $this->name) {
            $res['name'] = $this->name;
        }
        if (null !== $this->readAuth) {
            $res['readAuth'] = $this->readAuth;
        }
        if (null !== $this->tenantId) {
            $res['tenantId'] = $this->tenantId;
        }
        if (null !== $this->type) {
            $res['type'] = $this->type;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return result
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['hasData'])) {
            $model->hasData = $map['hasData'];
        }
        if (isset($map['integrateDataAuth'])) {
            $model->integrateDataAuth = $map['integrateDataAuth'];
        }
        if (isset($map['name'])) {
            $model->name = $map['name'];
        }
        if (isset($map['readAuth'])) {
            $model->readAuth = $map['readAuth'];
        }
        if (isset($map['tenantId'])) {
            $model->tenantId = $map['tenantId'];
        }
        if (isset($map['type'])) {
            $model->type = $map['type'];
        }

        return $model;
    }
}
