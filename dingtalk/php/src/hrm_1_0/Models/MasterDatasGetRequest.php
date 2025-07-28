<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vhrm_1_0\Models;

use AlibabaCloud\Tea\Model;

class MasterDatasGetRequest extends Model
{
    /**
     * @description This parameter is required.
     *
     * @example uk1231
     *
     * @var string
     */
    public $objId;

    /**
     * @description This parameter is required.
     *
     * @example PERFORMANCE
     *
     * @var string
     */
    public $scopeCode;

    /**
     * @description This parameter is required.
     *
     * @example 3
     *
     * @var int
     */
    public $tenantId;

    /**
     * @description This parameter is required.
     *
     * @example base
     *
     * @var string
     */
    public $viewEntityCode;
    protected $_name = [
        'objId' => 'objId',
        'scopeCode' => 'scopeCode',
        'tenantId' => 'tenantId',
        'viewEntityCode' => 'viewEntityCode',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->objId) {
            $res['objId'] = $this->objId;
        }
        if (null !== $this->scopeCode) {
            $res['scopeCode'] = $this->scopeCode;
        }
        if (null !== $this->tenantId) {
            $res['tenantId'] = $this->tenantId;
        }
        if (null !== $this->viewEntityCode) {
            $res['viewEntityCode'] = $this->viewEntityCode;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return MasterDatasGetRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['objId'])) {
            $model->objId = $map['objId'];
        }
        if (isset($map['scopeCode'])) {
            $model->scopeCode = $map['scopeCode'];
        }
        if (isset($map['tenantId'])) {
            $model->tenantId = $map['tenantId'];
        }
        if (isset($map['viewEntityCode'])) {
            $model->viewEntityCode = $map['viewEntityCode'];
        }

        return $model;
    }
}
