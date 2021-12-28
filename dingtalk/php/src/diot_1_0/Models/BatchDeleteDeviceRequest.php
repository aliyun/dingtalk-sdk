<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vdiot_1_0\Models;

use AlibabaCloud\Tea\Model;

class BatchDeleteDeviceRequest extends Model
{
    /**
     * @description 钉钉物联组织ID, 第三方平台必填，企业内部系统忽略。
     *
     * @var string
     */
    public $corpId;

    /**
     * @description 设备ID列表，最多500条。
     *
     * @var string[]
     */
    public $deviceIds;
    protected $_name = [
        'corpId'    => 'corpId',
        'deviceIds' => 'deviceIds',
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
        if (null !== $this->deviceIds) {
            $res['deviceIds'] = $this->deviceIds;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return BatchDeleteDeviceRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['corpId'])) {
            $model->corpId = $map['corpId'];
        }
        if (isset($map['deviceIds'])) {
            if (!empty($map['deviceIds'])) {
                $model->deviceIds = $map['deviceIds'];
            }
        }

        return $model;
    }
}
