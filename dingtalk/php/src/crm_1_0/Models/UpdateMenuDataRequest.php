<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vcrm_1_0\Models;

use AlibabaCloud\SDK\Dingtalk\Vcrm_1_0\Models\UpdateMenuDataRequest\navData;
use AlibabaCloud\Tea\Model;

class UpdateMenuDataRequest extends Model
{
    /**
     * @var mixed[]
     */
    public $attr;

    /**
     * @description This parameter is required.
     *
     * @example 89ez9DwVWQVgkhwndJNt1ZY
     *
     * @var string
     */
    public $bizTraceId;

    /**
     * @description This parameter is required.
     *
     * @example sale
     *
     * @var string
     */
    public $module;

    /**
     * @description This parameter is required.
     *
     * @var navData
     */
    public $navData;

    /**
     * @description This parameter is required.
     *
     * @example add
     *
     * @var string
     */
    public $operateType;

    /**
     * @description This parameter is required.
     *
     * @example 16044739461008808646
     *
     * @var string
     */
    public $operatorUserId;
    protected $_name = [
        'attr'           => 'attr',
        'bizTraceId'     => 'bizTraceId',
        'module'         => 'module',
        'navData'        => 'navData',
        'operateType'    => 'operateType',
        'operatorUserId' => 'operatorUserId',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->attr) {
            $res['attr'] = $this->attr;
        }
        if (null !== $this->bizTraceId) {
            $res['bizTraceId'] = $this->bizTraceId;
        }
        if (null !== $this->module) {
            $res['module'] = $this->module;
        }
        if (null !== $this->navData) {
            $res['navData'] = null !== $this->navData ? $this->navData->toMap() : null;
        }
        if (null !== $this->operateType) {
            $res['operateType'] = $this->operateType;
        }
        if (null !== $this->operatorUserId) {
            $res['operatorUserId'] = $this->operatorUserId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return UpdateMenuDataRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['attr'])) {
            $model->attr = $map['attr'];
        }
        if (isset($map['bizTraceId'])) {
            $model->bizTraceId = $map['bizTraceId'];
        }
        if (isset($map['module'])) {
            $model->module = $map['module'];
        }
        if (isset($map['navData'])) {
            $model->navData = navData::fromMap($map['navData']);
        }
        if (isset($map['operateType'])) {
            $model->operateType = $map['operateType'];
        }
        if (isset($map['operatorUserId'])) {
            $model->operatorUserId = $map['operatorUserId'];
        }

        return $model;
    }
}
