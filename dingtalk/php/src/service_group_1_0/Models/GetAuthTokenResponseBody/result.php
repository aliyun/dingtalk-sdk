<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vservice_group_1_0\Models\GetAuthTokenResponseBody;

use AlibabaCloud\Tea\Model;

class result extends Model
{
    /**
     * @var string
     */
    public $authToken;

    /**
     * @var string
     */
    public $channel;

    /**
     * @var int
     */
    public $effectiveTime;

    /**
     * @var string
     */
    public $serverId;

    /**
     * @var string
     */
    public $serverName;
    protected $_name = [
        'authToken' => 'authToken',
        'channel' => 'channel',
        'effectiveTime' => 'effectiveTime',
        'serverId' => 'serverId',
        'serverName' => 'serverName',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->authToken) {
            $res['authToken'] = $this->authToken;
        }
        if (null !== $this->channel) {
            $res['channel'] = $this->channel;
        }
        if (null !== $this->effectiveTime) {
            $res['effectiveTime'] = $this->effectiveTime;
        }
        if (null !== $this->serverId) {
            $res['serverId'] = $this->serverId;
        }
        if (null !== $this->serverName) {
            $res['serverName'] = $this->serverName;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return result
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['authToken'])) {
            $model->authToken = $map['authToken'];
        }
        if (isset($map['channel'])) {
            $model->channel = $map['channel'];
        }
        if (isset($map['effectiveTime'])) {
            $model->effectiveTime = $map['effectiveTime'];
        }
        if (isset($map['serverId'])) {
            $model->serverId = $map['serverId'];
        }
        if (isset($map['serverName'])) {
            $model->serverName = $map['serverName'];
        }

        return $model;
    }
}
