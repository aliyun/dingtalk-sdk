<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vcrm_1_0\Models;

use AlibabaCloud\Tea\Model;

class GetNavigationCatalogRequest extends Model
{
    /**
     * @example 6360a371-4ffa-464b-a935-39817c3ccbe8
     *
     * @var string
     */
    public $bizTraceId;

    /**
     * @example sale
     *
     * @var string
     */
    public $module;

    /**
     * @example 16044739461008808747
     *
     * @var string
     */
    public $operatorUserId;
    protected $_name = [
        'bizTraceId'     => 'bizTraceId',
        'module'         => 'module',
        'operatorUserId' => 'operatorUserId',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->bizTraceId) {
            $res['bizTraceId'] = $this->bizTraceId;
        }
        if (null !== $this->module) {
            $res['module'] = $this->module;
        }
        if (null !== $this->operatorUserId) {
            $res['operatorUserId'] = $this->operatorUserId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return GetNavigationCatalogRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['bizTraceId'])) {
            $model->bizTraceId = $map['bizTraceId'];
        }
        if (isset($map['module'])) {
            $model->module = $map['module'];
        }
        if (isset($map['operatorUserId'])) {
            $model->operatorUserId = $map['operatorUserId'];
        }

        return $model;
    }
}
