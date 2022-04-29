<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vservice_group_1_0\Models;

use AlibabaCloud\Tea\Model;

class CreateGroupConversationRequest extends Model
{
    /**
     * @description 开放corpid
     *
     * @var string
     */
    public $corpId;

    /**
     * @description 钉群openID
     *
     * @var string
     */
    public $dingGroupId;

    /**
     * @var string
     */
    public $dingSuiteKey;

    /**
     * @var int
     */
    public $dingTokenGrantType;

    /**
     * @description 钉群内发起人工服务的客户的ID
     *
     * @var string
     */
    public $dingUserId;

    /**
     * @description 钉群内发起人工服务的客户的名称
     *
     * @var string
     */
    public $dingUserName;

    /**
     * @description 扩展信息
     *
     * @var string
     */
    public $extValues;

    /**
     * @var string
     */
    public $openTeamId;

    /**
     * @description 小二技能组ID
     *
     * @var string
     */
    public $serverGroupId;
    protected $_name = [
        'corpId'             => 'corpId',
        'dingGroupId'        => 'dingGroupId',
        'dingSuiteKey'       => 'dingSuiteKey',
        'dingTokenGrantType' => 'dingTokenGrantType',
        'dingUserId'         => 'dingUserId',
        'dingUserName'       => 'dingUserName',
        'extValues'          => 'extValues',
        'openTeamId'         => 'openTeamId',
        'serverGroupId'      => 'serverGroupId',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->corpId) {
            $res['corpId'] = $this->corpId;
        }
        if (null !== $this->dingGroupId) {
            $res['dingGroupId'] = $this->dingGroupId;
        }
        if (null !== $this->dingSuiteKey) {
            $res['dingSuiteKey'] = $this->dingSuiteKey;
        }
        if (null !== $this->dingTokenGrantType) {
            $res['dingTokenGrantType'] = $this->dingTokenGrantType;
        }
        if (null !== $this->dingUserId) {
            $res['dingUserId'] = $this->dingUserId;
        }
        if (null !== $this->dingUserName) {
            $res['dingUserName'] = $this->dingUserName;
        }
        if (null !== $this->extValues) {
            $res['extValues'] = $this->extValues;
        }
        if (null !== $this->openTeamId) {
            $res['openTeamId'] = $this->openTeamId;
        }
        if (null !== $this->serverGroupId) {
            $res['serverGroupId'] = $this->serverGroupId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return CreateGroupConversationRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['corpId'])) {
            $model->corpId = $map['corpId'];
        }
        if (isset($map['dingGroupId'])) {
            $model->dingGroupId = $map['dingGroupId'];
        }
        if (isset($map['dingSuiteKey'])) {
            $model->dingSuiteKey = $map['dingSuiteKey'];
        }
        if (isset($map['dingTokenGrantType'])) {
            $model->dingTokenGrantType = $map['dingTokenGrantType'];
        }
        if (isset($map['dingUserId'])) {
            $model->dingUserId = $map['dingUserId'];
        }
        if (isset($map['dingUserName'])) {
            $model->dingUserName = $map['dingUserName'];
        }
        if (isset($map['extValues'])) {
            $model->extValues = $map['extValues'];
        }
        if (isset($map['openTeamId'])) {
            $model->openTeamId = $map['openTeamId'];
        }
        if (isset($map['serverGroupId'])) {
            $model->serverGroupId = $map['serverGroupId'];
        }

        return $model;
    }
}
