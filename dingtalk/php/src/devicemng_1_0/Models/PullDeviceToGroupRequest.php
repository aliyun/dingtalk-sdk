<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vdevicemng_1_0\Models;

use AlibabaCloud\Tea\Model;

class PullDeviceToGroupRequest extends Model
{
    /**
     * @var string[]
     */
    public $deviceCodes;

    /**
     * @var string[]
     */
    public $deviceUuids;

    /**
     * @example cide+m5TmAcxA3OU6Un59xxxx==
     *
     * @var string
     */
    public $openConversationId;

    /**
     * @example manager1111
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
