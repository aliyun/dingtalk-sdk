<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vvip_member_1_0\Models;

use AlibabaCloud\Tea\Model;

class PreCheckRedeemVipMemberRequest extends Model
{
    /**
     * @var string
     */
    public $bizRequestId;

    /**
     * @var string
     */
    public $channel;

    /**
     * @var string
     */
    public $dingtalkId;

    /**
     * @var int
     */
    public $duration;

    /**
     * @var string
     */
    public $mobile;

    /**
     * @var string
     */
    public $uuid;
    protected $_name = [
        'bizRequestId' => 'bizRequestId',
        'channel' => 'channel',
        'dingtalkId' => 'dingtalkId',
        'duration' => 'duration',
        'mobile' => 'mobile',
        'uuid' => 'uuid',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->bizRequestId) {
            $res['bizRequestId'] = $this->bizRequestId;
        }
        if (null !== $this->channel) {
            $res['channel'] = $this->channel;
        }
        if (null !== $this->dingtalkId) {
            $res['dingtalkId'] = $this->dingtalkId;
        }
        if (null !== $this->duration) {
            $res['duration'] = $this->duration;
        }
        if (null !== $this->mobile) {
            $res['mobile'] = $this->mobile;
        }
        if (null !== $this->uuid) {
            $res['uuid'] = $this->uuid;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return PreCheckRedeemVipMemberRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['bizRequestId'])) {
            $model->bizRequestId = $map['bizRequestId'];
        }
        if (isset($map['channel'])) {
            $model->channel = $map['channel'];
        }
        if (isset($map['dingtalkId'])) {
            $model->dingtalkId = $map['dingtalkId'];
        }
        if (isset($map['duration'])) {
            $model->duration = $map['duration'];
        }
        if (isset($map['mobile'])) {
            $model->mobile = $map['mobile'];
        }
        if (isset($map['uuid'])) {
            $model->uuid = $map['uuid'];
        }

        return $model;
    }
}
