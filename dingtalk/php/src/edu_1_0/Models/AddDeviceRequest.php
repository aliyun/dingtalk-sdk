<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models;

use AlibabaCloud\Tea\Model;

class AddDeviceRequest extends Model
{
    /**
     * @description 商户id
     *
     * @var string
     */
    public $merchantId;

    /**
     * @description 设备型号
     *
     * @var string
     */
    public $model;

    /**
     * @description 设备名称
     *
     * @var string
     */
    public $name;

    /**
     * @description 消费场景
     *
     * @var int
     */
    public $scene;

    /**
     * @description sn码
     *
     * @var string
     */
    public $sn;

    /**
     * @description 设备状态
     *
     * @var int
     */
    public $status;

    /**
     * @description 设备类型
     *
     * @var int
     */
    public $type;
    protected $_name = [
        'merchantId' => 'merchantId',
        'model'      => 'model',
        'name'       => 'name',
        'scene'      => 'scene',
        'sn'         => 'sn',
        'status'     => 'status',
        'type'       => 'type',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->merchantId) {
            $res['merchantId'] = $this->merchantId;
        }
        if (null !== $this->model) {
            $res['model'] = $this->model;
        }
        if (null !== $this->name) {
            $res['name'] = $this->name;
        }
        if (null !== $this->scene) {
            $res['scene'] = $this->scene;
        }
        if (null !== $this->sn) {
            $res['sn'] = $this->sn;
        }
        if (null !== $this->status) {
            $res['status'] = $this->status;
        }
        if (null !== $this->type) {
            $res['type'] = $this->type;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return AddDeviceRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['merchantId'])) {
            $model->merchantId = $map['merchantId'];
        }
        if (isset($map['model'])) {
            $model->model = $map['model'];
        }
        if (isset($map['name'])) {
            $model->name = $map['name'];
        }
        if (isset($map['scene'])) {
            $model->scene = $map['scene'];
        }
        if (isset($map['sn'])) {
            $model->sn = $map['sn'];
        }
        if (isset($map['status'])) {
            $model->status = $map['status'];
        }
        if (isset($map['type'])) {
            $model->type = $map['type'];
        }

        return $model;
    }
}
