<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vdevicemng_1_0\Models;

use AlibabaCloud\Tea\Model;

class PullDeviceToGroupRequest extends Model
{
    /**
     * @description 设备业务标识
     *
     * @var string[]
     */
    public $deviceCodes;

    /**
     * @description 设备uuid，系统唯一标识
     *
     * @var string[]
     */
    public $deviceUuids;

    /**
     * @description 群id，群的唯一标识
     *
     * @var string
     */
    public $openConversationId;

    /**
     * @description 操作人userId
     *
     * @var string
     */
    public $operator;
    protected $_name = [
        'deviceCodes'        => 'deviceCodes',
        'deviceUuids'        => 'deviceUuids',
        'openConversationId' => 'openConversationId',
        'operator'           => 'operator',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->deviceCodes) {
            $res['deviceCodes'] = $this->deviceCodes;
        }
        if (null !== $this->deviceUuids) {
            $res['deviceUuids'] = $this->deviceUuids;
        }
        if (null !== $this->openConversationId) {
            $res['openConversationId'] = $this->openConversationId;
        }
        if (null !== $this->operator) {
            $res['operator'] = $this->operator;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return PullDeviceToGroupRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['deviceCodes'])) {
            if (!empty($map['deviceCodes'])) {
                $model->deviceCodes = $map['deviceCodes'];
            }
        }
        if (isset($map['deviceUuids'])) {
            if (!empty($map['deviceUuids'])) {
                $model->deviceUuids = $map['deviceUuids'];
            }
        }
        if (isset($map['openConversationId'])) {
            $model->openConversationId = $map['openConversationId'];
        }
        if (isset($map['operator'])) {
            $model->operator = $map['operator'];
        }

        return $model;
    }
}
