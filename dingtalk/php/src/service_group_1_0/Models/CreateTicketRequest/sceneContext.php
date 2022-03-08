<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vservice_group_1_0\Models\CreateTicketRequest;

use AlibabaCloud\SDK\Dingtalk\Vservice_group_1_0\Models\CreateTicketRequest\sceneContext\groupMsgs;
use AlibabaCloud\Tea\Model;

class sceneContext extends Model
{
    /**
     * @description 工单相关的群消息列表
     *
     * @var groupMsgs[]
     */
    public $groupMsgs;

    /**
     * @description 服务群openConversationId
     *
     * @var string
     */
    public $openConversationId;

    /**
     * @description 工单相关人UnionId列表
     *
     * @var string[]
     */
    public $relevantorUnionIds;

    /**
     * @description VOC类型工单，对应话题ID
     *
     * @var string
     */
    public $topicId;
    protected $_name = [
        'groupMsgs'          => 'groupMsgs',
        'openConversationId' => 'openConversationId',
        'relevantorUnionIds' => 'relevantorUnionIds',
        'topicId'            => 'topicId',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->groupMsgs) {
            $res['groupMsgs'] = [];
            if (null !== $this->groupMsgs && \is_array($this->groupMsgs)) {
                $n = 0;
                foreach ($this->groupMsgs as $item) {
                    $res['groupMsgs'][$n++] = null !== $item ? $item->toMap() : $item;
                }
            }
        }
        if (null !== $this->openConversationId) {
            $res['openConversationId'] = $this->openConversationId;
        }
        if (null !== $this->relevantorUnionIds) {
            $res['relevantorUnionIds'] = $this->relevantorUnionIds;
        }
        if (null !== $this->topicId) {
            $res['topicId'] = $this->topicId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return sceneContext
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['groupMsgs'])) {
            if (!empty($map['groupMsgs'])) {
                $model->groupMsgs = [];
                $n                = 0;
                foreach ($map['groupMsgs'] as $item) {
                    $model->groupMsgs[$n++] = null !== $item ? groupMsgs::fromMap($item) : $item;
                }
            }
        }
        if (isset($map['openConversationId'])) {
            $model->openConversationId = $map['openConversationId'];
        }
        if (isset($map['relevantorUnionIds'])) {
            if (!empty($map['relevantorUnionIds'])) {
                $model->relevantorUnionIds = $map['relevantorUnionIds'];
            }
        }
        if (isset($map['topicId'])) {
            $model->topicId = $map['topicId'];
        }

        return $model;
    }
}
