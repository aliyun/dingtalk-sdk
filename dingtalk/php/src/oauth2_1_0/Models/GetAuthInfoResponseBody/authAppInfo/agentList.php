<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Voauth2_1_0\Models\GetAuthInfoResponseBody\authAppInfo;

use AlibabaCloud\Tea\Model;

class agentList extends Model
{
    /**
     * @description 对此微应用有管理权限的管理员列表
     *
     * @var string[]
     */
    public $adminList;

    /**
     * @description 应用id
     *
     * @var int
     */
    public $agentId;

    /**
     * @description 应用名称
     *
     * @var string
     */
    public $agentName;

    /**
     * @description 三方应用id
     *
     * @var int
     */
    public $appId;
    protected $_name = [
        'adminList' => 'adminList',
        'agentId'   => 'agentId',
        'agentName' => 'agentName',
        'appId'     => 'appId',
    ];

    public function validate()
    {
    }

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
