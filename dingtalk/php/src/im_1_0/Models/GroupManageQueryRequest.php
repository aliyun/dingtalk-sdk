<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vim_1_0\Models;

use AlibabaCloud\Tea\Model;

class GroupManageQueryRequest extends Model
{
    /**
     * @description 群号
     *
     * @var string
     */
    public $groupId;

    /**
     * @description 群成员样例工号列表
     *
     * @var string[]
     */
    public $groupMemberSamples;

    /**
     * @description 群主工号
     *
     * @var string
     */
    public $groupOwner;

    /**
     * @description 群标题关键词列表
     *
     * @var string[]
     */
    public $groupTitleKeywords;

    /**
     * @description 群链接
     *
     * @var string
     */
    public $groupUrl;

    /**
     * @description 开放群id
     *
     * @var string
     */
    public $openConversationId;
    protected $_name = [
        'groupId'            => 'groupId',
        'groupMemberSamples' => 'groupMemberSamples',
        'groupOwner'         => 'groupOwner',
        'groupTitleKeywords' => 'groupTitleKeywords',
        'groupUrl'           => 'groupUrl',
        'openConversationId' => 'openConversationId',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->groupId) {
            $res['groupId'] = $this->groupId;
        }
        if (null !== $this->groupMemberSamples) {
            $res['groupMemberSamples'] = $this->groupMemberSamples;
        }
        if (null !== $this->groupOwner) {
            $res['groupOwner'] = $this->groupOwner;
        }
        if (null !== $this->groupTitleKeywords) {
            $res['groupTitleKeywords'] = $this->groupTitleKeywords;
        }
        if (null !== $this->groupUrl) {
            $res['groupUrl'] = $this->groupUrl;
        }
        if (null !== $this->openConversationId) {
            $res['openConversationId'] = $this->openConversationId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return GroupManageQueryRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['groupId'])) {
            $model->groupId = $map['groupId'];
        }
        if (isset($map['groupMemberSamples'])) {
            if (!empty($map['groupMemberSamples'])) {
                $model->groupMemberSamples = $map['groupMemberSamples'];
            }
        }
        if (isset($map['groupOwner'])) {
            $model->groupOwner = $map['groupOwner'];
        }
        if (isset($map['groupTitleKeywords'])) {
            if (!empty($map['groupTitleKeywords'])) {
                $model->groupTitleKeywords = $map['groupTitleKeywords'];
            }
        }
        if (isset($map['groupUrl'])) {
            $model->groupUrl = $map['groupUrl'];
        }
        if (isset($map['openConversationId'])) {
            $model->openConversationId = $map['openConversationId'];
        }

        return $model;
    }
}
