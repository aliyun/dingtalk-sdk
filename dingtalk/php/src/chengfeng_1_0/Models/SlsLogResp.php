<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vchengfeng_1_0\Models;

use AlibabaCloud\Tea\Model;

class SlsLogResp extends Model
{
    /**
     * @description This parameter is required.
     *
     * @example 新增
     *
     * @var string
     */
    public $action;

    /**
     * @description This parameter is required.
     *
     * @example HolidayChangeRecord
     *
     * @var string
     */
    public $entity;

    /**
     * @description This parameter is required.
     *
     * @example 0ba35cd517156543461401313d12b4|null
     *
     * @var string
     */
    public $header;

    /**
     * @description This parameter is required.
     *
     * @example 123
     *
     * @var string
     */
    public $id;

    /**
     * @description This parameter is required.
     *
     * @example 提交申请
     *
     * @var string
     */
    public $info;

    /**
     * @description This parameter is required.
     *
     * @example 维同
     *
     * @var string
     */
    public $operator;

    /**
     * @description This parameter is required.
     *
     * @example 橙奕科技
     *
     * @var string
     */
    public $tenant;

    /**
     * @description This parameter is required.
     *
     * @example 2
     *
     * @var string
     */
    public $tenantId;

    /**
     * @description This parameter is required.
     *
     * @example 1638892800000
     *
     * @var int
     */
    public $time;
    protected $_name = [
        'action'   => 'action',
        'entity'   => 'entity',
        'header'   => 'header',
        'id'       => 'id',
        'info'     => 'info',
        'operator' => 'operator',
        'tenant'   => 'tenant',
        'tenantId' => 'tenantId',
        'time'     => 'time',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->action) {
            $res['action'] = $this->action;
        }
        if (null !== $this->entity) {
            $res['entity'] = $this->entity;
        }
        if (null !== $this->header) {
            $res['header'] = $this->header;
        }
        if (null !== $this->id) {
            $res['id'] = $this->id;
        }
        if (null !== $this->info) {
            $res['info'] = $this->info;
        }
        if (null !== $this->operator) {
            $res['operator'] = $this->operator;
        }
        if (null !== $this->tenant) {
            $res['tenant'] = $this->tenant;
        }
        if (null !== $this->tenantId) {
            $res['tenantId'] = $this->tenantId;
        }
        if (null !== $this->time) {
            $res['time'] = $this->time;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return SlsLogResp
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['action'])) {
            $model->action = $map['action'];
        }
        if (isset($map['entity'])) {
            $model->entity = $map['entity'];
        }
        if (isset($map['header'])) {
            $model->header = $map['header'];
        }
        if (isset($map['id'])) {
            $model->id = $map['id'];
        }
        if (isset($map['info'])) {
            $model->info = $map['info'];
        }
        if (isset($map['operator'])) {
            $model->operator = $map['operator'];
        }
        if (isset($map['tenant'])) {
            $model->tenant = $map['tenant'];
        }
        if (isset($map['tenantId'])) {
            $model->tenantId = $map['tenantId'];
        }
        if (isset($map['time'])) {
            $model->time = $map['time'];
        }

        return $model;
    }
}
