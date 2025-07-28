<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vservice_group_1_0\Models;

use AlibabaCloud\Tea\Model;

class CreateGroupConversationRequest extends Model
{
    /**
     * @example dingadc88253b4d581bd35c2f4657eb6378f
     *
     * @var string
     */
    public $corpId;

    /**
     * @example fsfsfadfasfdasdfsaf
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
     * @example 57675657
     *
     * @var string
     */
    public $dingUserId;

    /**
     * @example 张三
     *
     * @var string
     */
    public $dingUserName;

    /**
     * @example {"isServerInitiative":"true"}
     *
     * @var string
     */
    public $extValues;

    /**
     * @var string
     */
    public $openTeamId;

    /**
     * @example 3434
     *
     * @var string
     */
    public $serverGroupId;
    protected $_name = [
        'corpId' => 'corpId',
        'dingGroupId' => 'dingGroupId',
        'dingSuiteKey' => 'dingSuiteKey',
        'dingTokenGrantType' => 'dingTokenGrantType',
        'dingUserId' => 'dingUserId',
        'dingUserName' => 'dingUserName',
        'extValues' => 'extValues',
        'openTeamId' => 'openTeamId',
        'serverGroupId' => 'serverGroupId',
    ];

    public function validate() {}

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
