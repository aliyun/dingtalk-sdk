<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vdiot_1_0\Models;

use AlibabaCloud\SDK\Dingtalk\Vdiot_1_0\Models\BatchRegisterDeviceRequest\devices;
use AlibabaCloud\Tea\Model;

class BatchRegisterDeviceRequest extends Model
{
    /**
     * @description 钉钉物联组织ID, 第三方平台必填，企业内部系统忽略。
     *
     * @var string
     */
    public $corpId;

    /**
     * @description 设备列表。
     *
     * @var devices[]
     */
    public $devices;
    protected $_name = [
        'corpId'  => 'corpId',
        'devices' => 'devices',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->corpId) {
            $res['corpId'] = $this->corpId;
        }
        if (null !== $this->devices) {
            $res['devices'] = [];
            if (null !== $this->devices && \is_array($this->devices)) {
                $n = 0;
                foreach ($this->devices as $item) {
                    $res['devices'][$n++] = null !== $item ? $item->toMap() : $item;
                }
            }
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return BatchRegisterDeviceRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['corpId'])) {
            $model->corpId = $map['corpId'];
        }
        if (isset($map['devices'])) {
            if (!empty($map['devices'])) {
                $model->devices = [];
                $n              = 0;
                foreach ($map['devices'] as $item) {
                    $model->devices[$n++] = null !== $item ? devices::fromMap($item) : $item;
                }
            }
        }

        return $model;
    }
}
