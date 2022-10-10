<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models;

use AlibabaCloud\Tea\Model;

class ActivateDeviceRequest extends Model
{
    /**
     * @description 授权码
     *
     * @var string
     */
    public $licenseKey;

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
     * @description 设备sn码
     *
     * @var string
     */
    public $sn;

    /**
     * @description 设备类型
     *
     * @var string
     */
    public $type;
    protected $_name = [
        'licenseKey' => 'licenseKey',
        'model'      => 'model',
        'name'       => 'name',
        'sn'         => 'sn',
        'type'       => 'type',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->licenseKey) {
            $res['licenseKey'] = $this->licenseKey;
        }
        if (null !== $this->model) {
            $res['model'] = $this->model;
        }
        if (null !== $this->name) {
            $res['name'] = $this->name;
        }
        if (null !== $this->sn) {
            $res['sn'] = $this->sn;
        }
        if (null !== $this->type) {
            $res['type'] = $this->type;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return ActivateDeviceRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['licenseKey'])) {
            $model->licenseKey = $map['licenseKey'];
        }
        if (isset($map['model'])) {
            $model->model = $map['model'];
        }
        if (isset($map['name'])) {
            $model->name = $map['name'];
        }
        if (isset($map['sn'])) {
            $model->sn = $map['sn'];
        }
        if (isset($map['type'])) {
            $model->type = $map['type'];
        }

        return $model;
    }
}
