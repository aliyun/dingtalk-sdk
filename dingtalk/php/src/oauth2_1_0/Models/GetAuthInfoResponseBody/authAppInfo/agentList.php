<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Voauth2_1_0\Models\GetAuthInfoResponseBody\authAppInfo;

use AlibabaCloud\Tea\Model;

class agentList extends Model
{
    /**
     * @description This parameter is required.
     *
     * @var string[]
     */
    public $adminList;

    /**
     * @description This parameter is required.
     *
     * @example 835880322
     *
     * @var int
     */
    public $agentId;

    /**
     * @description This parameter is required.
     *
     * @example 小程序DEMO
     *
     * @var string
     */
    public $agentName;

    /**
     * @description This parameter is required.
     *
     * @example 111
     *
     * @var int
     */
    public $appId;
    protected $_name = [
        'adminList' => 'adminList',
        'agentId' => 'agentId',
        'agentName' => 'agentName',
        'appId' => 'appId',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->adminList) {
            $res['adminList'] = $this->adminList;
        }
        if (null !== $this->agentId) {
            $res['agentId'] = $this->agentId;
        }
        if (null !== $this->agentName) {
            $res['agentName'] = $this->agentName;
        }
        if (null !== $this->appId) {
            $res['appId'] = $this->appId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return agentList
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['adminList'])) {
            if (!empty($map['adminList'])) {
                $model->adminList = $map['adminList'];
            }
        }
        if (isset($map['agentId'])) {
            $model->agentId = $map['agentId'];
        }
        if (isset($map['agentName'])) {
            $model->agentName = $map['agentName'];
        }
        if (isset($map['appId'])) {
            $model->appId = $map['appId'];
        }

        return $model;
    }
}
