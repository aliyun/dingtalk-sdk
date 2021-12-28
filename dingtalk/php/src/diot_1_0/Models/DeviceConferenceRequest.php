<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vdiot_1_0\Models;

use AlibabaCloud\Tea\Model;

class DeviceConferenceRequest extends Model
{
    /**
     * @description 会议主题，最多不能超20个中文。
     *
     * @var string
     */
    public $confTitle;

    /**
     * @description 钉钉会议ID，加入已存在的会议必填。
     *
     * @var string
     */
    public $conferenceId;

    /**
     * @description 钉钉会议密码，加入已存在的会议必填。
     *
     * @var string
     */
    public $conferencePassword;

    /**
     * @description 需要邀请的设备ID，最多5个。
     *
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
