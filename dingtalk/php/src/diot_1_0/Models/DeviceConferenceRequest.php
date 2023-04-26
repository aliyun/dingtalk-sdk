<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vdiot_1_0\Models;

use AlibabaCloud\Tea\Model;

class DeviceConferenceRequest extends Model
{
    /**
     * @example 设备的应急会议
     *
     * @var string
     */
    public $confTitle;

    /**
     * @example 12345678
     *
     * @var string
     */
    public $conferenceId;

    /**
     * @example 123456
     *
     * @var string
     */
    public $conferencePassword;

    /**
     * @var string[]
     */
    public $deviceIds;
    protected $_name = [
        'confTitle'          => 'confTitle',
        'conferenceId'       => 'conferenceId',
        'conferencePassword' => 'conferencePassword',
        'deviceIds'          => 'deviceIds',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->confTitle) {
            $res['confTitle'] = $this->confTitle;
        }
        if (null !== $this->conferenceId) {
            $res['conferenceId'] = $this->conferenceId;
        }
        if (null !== $this->conferencePassword) {
            $res['conferencePassword'] = $this->conferencePassword;
        }
        if (null !== $this->deviceIds) {
            $res['deviceIds'] = $this->deviceIds;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return DeviceConferenceRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['confTitle'])) {
            $model->confTitle = $map['confTitle'];
        }
        if (isset($map['conferenceId'])) {
            $model->conferenceId = $map['conferenceId'];
        }
        if (isset($map['conferencePassword'])) {
            $model->conferencePassword = $map['conferencePassword'];
        }
        if (isset($map['deviceIds'])) {
            if (!empty($map['deviceIds'])) {
                $model->deviceIds = $map['deviceIds'];
            }
        }

        return $model;
    }
}
