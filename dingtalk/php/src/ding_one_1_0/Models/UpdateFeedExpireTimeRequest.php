<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vding_one_1_0\Models;

use AlibabaCloud\Tea\Model;

class UpdateFeedExpireTimeRequest extends Model
{
    /**
     * @description This parameter is required.
     *
     * @example 1772177962000
     *
     * @var int
     */
    public $expireTime;

    /**
     * @description This parameter is required.
     *
     * @example dd-one-work-eSo869uR9Vhse2sqTw3dDF
     *
     * @var string
     */
    public $feedId;

    /**
     * @description This parameter is required.
     *
     * @example ntThCP2X44FlskVliPIXPUQiEiE
     *
     * @var string
     */
    public $unionId;
    protected $_name = [
        'expireTime' => 'expireTime',
        'feedId' => 'feedId',
        'unionId' => 'unionId',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->expireTime) {
            $res['expireTime'] = $this->expireTime;
        }
        if (null !== $this->feedId) {
            $res['feedId'] = $this->feedId;
        }
        if (null !== $this->unionId) {
            $res['unionId'] = $this->unionId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return UpdateFeedExpireTimeRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['expireTime'])) {
            $model->expireTime = $map['expireTime'];
        }
        if (isset($map['feedId'])) {
            $model->feedId = $map['feedId'];
        }
        if (isset($map['unionId'])) {
            $model->unionId = $map['unionId'];
        }

        return $model;
    }
}
