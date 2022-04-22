<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vservice_group_1_0\Models;

use AlibabaCloud\Tea\Model;

class GetAuthTokenRequest extends Model
{
    /**
     * @description 渠道DT/LINKS
     *
     * @var string
     */
    public $channel;

    /**
     * @description token有效时间（秒）-可不传
     *
     * @var int
     */
    public $effectiveTime;

    /**
     * @description 团队ID
     *
     * @var string
     */
    public $openTeamId;

    /**
     * @description 小二id
     *
     * @var string
     */
    public $serverId;

    /**
     * @description 小二名称
     *
     * @var string
     */
    public $serverName;
    protected $_name = [
        'channel'       => 'channel',
        'effectiveTime' => 'effectiveTime',
        'openTeamId'    => 'openTeamId',
        'serverId'      => 'serverId',
        'serverName'    => 'serverName',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->channel) {
            $res['channel'] = $this->channel;
        }
        if (null !== $this->effectiveTime) {
            $res['effectiveTime'] = $this->effectiveTime;
        }
        if (null !== $this->openTeamId) {
            $res['openTeamId'] = $this->openTeamId;
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
     * @return GetAuthTokenRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['channel'])) {
            $model->channel = $map['channel'];
        }
        if (isset($map['effectiveTime'])) {
            $model->effectiveTime = $map['effectiveTime'];
        }
        if (isset($map['openTeamId'])) {
            $model->openTeamId = $map['openTeamId'];
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
