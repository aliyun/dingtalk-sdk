<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vservice_group_1_0\Models;

use AlibabaCloud\Tea\Model;

class QueryGroupResponseBody extends Model
{
    /**
     * @description 群bizId
     *
     * @var string
     */
    public $bizId;

    /**
     * @description 群名称
     *
     * @var string
     */
    public $groupName;

    /**
     * @description 入群URL
     *
     * @var string
     */
    public $groupUrl;

    /**
     * @description 开放群ID
     *
     * @var string
     */
    public $openConversationId;

    /**
     * @description 开放群组ID
     *
     * @var string
     */
    public $openGroupSetId;

    /**
     * @description 开放团队ID
     *
     * @var string
     */
    public $openTeamId;

    /**
     * @description 服务群机器人code
     *
     * @var string
     */
    public $robotCode;

    /**
     * @description 服务群机器人名称
     *
     * @var string
     */
    public $robotName;
    protected $_name = [
        'bizId'              => 'bizId',
        'groupName'          => 'groupName',
        'groupUrl'           => 'groupUrl',
        'openConversationId' => 'openConversationId',
        'openGroupSetId'     => 'openGroupSetId',
        'openTeamId'         => 'openTeamId',
        'robotCode'          => 'robotCode',
        'robotName'          => 'robotName',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->bizId) {
            $res['bizId'] = $this->bizId;
        }
        if (null !== $this->groupName) {
            $res['groupName'] = $this->groupName;
        }
        if (null !== $this->groupUrl) {
            $res['groupUrl'] = $this->groupUrl;
        }
        if (null !== $this->openConversationId) {
            $res['openConversationId'] = $this->openConversationId;
        }
        if (null !== $this->openGroupSetId) {
            $res['openGroupSetId'] = $this->openGroupSetId;
        }
        if (null !== $this->openTeamId) {
            $res['openTeamId'] = $this->openTeamId;
        }
        if (null !== $this->robotCode) {
            $res['robotCode'] = $this->robotCode;
        }
        if (null !== $this->robotName) {
            $res['robotName'] = $this->robotName;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return QueryGroupResponseBody
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['bizId'])) {
            $model->bizId = $map['bizId'];
        }
        if (isset($map['groupName'])) {
            $model->groupName = $map['groupName'];
        }
        if (isset($map['groupUrl'])) {
            $model->groupUrl = $map['groupUrl'];
        }
        if (isset($map['openConversationId'])) {
            $model->openConversationId = $map['openConversationId'];
        }
        if (isset($map['openGroupSetId'])) {
            $model->openGroupSetId = $map['openGroupSetId'];
        }
        if (isset($map['openTeamId'])) {
            $model->openTeamId = $map['openTeamId'];
        }
        if (isset($map['robotCode'])) {
            $model->robotCode = $map['robotCode'];
        }
        if (isset($map['robotName'])) {
            $model->robotName = $map['robotName'];
        }

        return $model;
    }
}
