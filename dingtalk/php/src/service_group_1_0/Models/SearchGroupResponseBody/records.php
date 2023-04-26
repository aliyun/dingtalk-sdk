<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vservice_group_1_0\Models\SearchGroupResponseBody;

use AlibabaCloud\Tea\Model;

class records extends Model
{
    /**
     * @example 钉钉专属服务群
     *
     * @var string
     */
    public $groupName;

    /**
     * @example dingtalk:xxx
     *
     * @var string
     */
    public $groupUrl;

    /**
     * @example cidxxxxx==
     *
     * @var string
     */
    public $openConversationId;

    /**
     * @example xjfjdsiw
     *
     * @var string
     */
    public $openGroupSetId;

    /**
     * @example xkjhfker
     *
     * @var string
     */
    public $openTeamId;
    protected $_name = [
        'groupName'          => 'groupName',
        'groupUrl'           => 'groupUrl',
        'openConversationId' => 'openConversationId',
        'openGroupSetId'     => 'openGroupSetId',
        'openTeamId'         => 'openTeamId',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
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

        return $res;
    }

    /**
     * @param array $map
     *
     * @return records
     */
    public static function fromMap($map = [])
    {
        $model = new self();
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

        return $model;
    }
}
