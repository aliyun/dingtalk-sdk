<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vtrajectory_1_0\Models;

use AlibabaCloud\Tea\Model;

class QueryCollectingTraceTaskRequest extends Model
{
    /**
     * @description 员工用户ID列表
     *
     * @var string[]
     */
    public $userIds;

    /**
     * @description isvOrgId
     *
     * @var int
     */
    public $dingIsvOrgId;

    /**
     * @description tokenGrantType
     *
     * @var int
     */
    public $dingTokenGrantType;

    /**
     * @description appKey
     *
     * @var string
     */
    public $dingClientId;

    /**
     * @description orgId
     *
     * @var int
     */
    public $dingOrgId;

    /**
     * @description oauthAppId
     *
     * @var int
     */
    public $dingOauthAppId;
    protected $_name = [
        'userIds'            => 'userIds',
        'dingIsvOrgId'       => 'dingIsvOrgId',
        'dingTokenGrantType' => 'dingTokenGrantType',
        'dingClientId'       => 'dingClientId',
        'dingOrgId'          => 'dingOrgId',
        'dingOauthAppId'     => 'dingOauthAppId',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->userIds) {
            $res['userIds'] = $this->userIds;
        }
        if (null !== $this->dingIsvOrgId) {
            $res['dingIsvOrgId'] = $this->dingIsvOrgId;
        }
        if (null !== $this->dingTokenGrantType) {
            $res['dingTokenGrantType'] = $this->dingTokenGrantType;
        }
        if (null !== $this->dingClientId) {
            $res['dingClientId'] = $this->dingClientId;
        }
        if (null !== $this->dingOrgId) {
            $res['dingOrgId'] = $this->dingOrgId;
        }
        if (null !== $this->dingOauthAppId) {
            $res['dingOauthAppId'] = $this->dingOauthAppId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return QueryCollectingTraceTaskRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['userIds'])) {
            if (!empty($map['userIds'])) {
                $model->userIds = $map['userIds'];
            }
        }
        if (isset($map['dingIsvOrgId'])) {
            $model->dingIsvOrgId = $map['dingIsvOrgId'];
        }
        if (isset($map['dingTokenGrantType'])) {
            $model->dingTokenGrantType = $map['dingTokenGrantType'];
        }
        if (isset($map['dingClientId'])) {
            $model->dingClientId = $map['dingClientId'];
        }
        if (isset($map['dingOrgId'])) {
            $model->dingOrgId = $map['dingOrgId'];
        }
        if (isset($map['dingOauthAppId'])) {
            $model->dingOauthAppId = $map['dingOauthAppId'];
        }

        return $model;
    }
}
