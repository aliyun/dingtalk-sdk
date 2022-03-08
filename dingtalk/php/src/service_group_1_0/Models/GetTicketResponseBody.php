<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vservice_group_1_0\Models;

use AlibabaCloud\SDK\Dingtalk\Vservice_group_1_0\Models\GetTicketResponseBody\creator;
use AlibabaCloud\SDK\Dingtalk\Vservice_group_1_0\Models\GetTicketResponseBody\processor;
use AlibabaCloud\SDK\Dingtalk\Vservice_group_1_0\Models\GetTicketResponseBody\takers;
use AlibabaCloud\SDK\Dingtalk\Vservice_group_1_0\Models\GetTicketResponseBody\template;
use AlibabaCloud\Tea\Model;

class GetTicketResponseBody extends Model
{
    /**
     * @var string
     */
    public $createTime;

    /**
     * @var creator
     */
    public $creator;

    /**
     * @var string
     */
    public $customFields;

    /**
     * @var string
     */
    public $openConversationId;

    /**
     * @description Id of the request
     *
     * @var string
     */
    public $openTicketId;

    /**
     * @var processor
     */
    public $processor;

    /**
     * @var string
     */
    public $scene;

    /**
     * @var string
     */
    public $sceneContext;

    /**
     * @var string
     */
    public $stage;

    /**
     * @var takers[]
     */
    public $takers;

    /**
     * @var template
     */
    public $template;

    /**
     * @var string
     */
    public $title;

    /**
     * @var string
     */
    public $updateTime;
    protected $_name = [
        'createTime'         => 'createTime',
        'creator'            => 'creator',
        'customFields'       => 'customFields',
        'openConversationId' => 'openConversationId',
        'openTicketId'       => 'openTicketId',
        'processor'          => 'processor',
        'scene'              => 'scene',
        'sceneContext'       => 'sceneContext',
        'stage'              => 'stage',
        'takers'             => 'takers',
        'template'           => 'template',
        'title'              => 'title',
        'updateTime'         => 'updateTime',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->createTime) {
            $res['createTime'] = $this->createTime;
        }
        if (null !== $this->creator) {
            $res['creator'] = null !== $this->creator ? $this->creator->toMap() : null;
        }
        if (null !== $this->customFields) {
            $res['customFields'] = $this->customFields;
        }
        if (null !== $this->openConversationId) {
            $res['openConversationId'] = $this->openConversationId;
        }
        if (null !== $this->openTicketId) {
            $res['openTicketId'] = $this->openTicketId;
        }
        if (null !== $this->processor) {
            $res['processor'] = null !== $this->processor ? $this->processor->toMap() : null;
        }
        if (null !== $this->scene) {
            $res['scene'] = $this->scene;
        }
        if (null !== $this->sceneContext) {
            $res['sceneContext'] = $this->sceneContext;
        }
        if (null !== $this->stage) {
            $res['stage'] = $this->stage;
        }
        if (null !== $this->takers) {
            $res['takers'] = [];
            if (null !== $this->takers && \is_array($this->takers)) {
                $n = 0;
                foreach ($this->takers as $item) {
                    $res['takers'][$n++] = null !== $item ? $item->toMap() : $item;
                }
            }
        }
        if (null !== $this->template) {
            $res['template'] = null !== $this->template ? $this->template->toMap() : null;
        }
        if (null !== $this->title) {
            $res['title'] = $this->title;
        }
        if (null !== $this->updateTime) {
            $res['updateTime'] = $this->updateTime;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return GetTicketResponseBody
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['createTime'])) {
            $model->createTime = $map['createTime'];
        }
        if (isset($map['creator'])) {
            $model->creator = creator::fromMap($map['creator']);
        }
        if (isset($map['customFields'])) {
            $model->customFields = $map['customFields'];
        }
        if (isset($map['openConversationId'])) {
            $model->openConversationId = $map['openConversationId'];
        }
        if (isset($map['openTicketId'])) {
            $model->openTicketId = $map['openTicketId'];
        }
        if (isset($map['processor'])) {
            $model->processor = processor::fromMap($map['processor']);
        }
        if (isset($map['scene'])) {
            $model->scene = $map['scene'];
        }
        if (isset($map['sceneContext'])) {
            $model->sceneContext = $map['sceneContext'];
        }
        if (isset($map['stage'])) {
            $model->stage = $map['stage'];
        }
        if (isset($map['takers'])) {
            if (!empty($map['takers'])) {
                $model->takers = [];
                $n             = 0;
                foreach ($map['takers'] as $item) {
                    $model->takers[$n++] = null !== $item ? takers::fromMap($item) : $item;
                }
            }
        }
        if (isset($map['template'])) {
            $model->template = template::fromMap($map['template']);
        }
        if (isset($map['title'])) {
            $model->title = $map['title'];
        }
        if (isset($map['updateTime'])) {
            $model->updateTime = $map['updateTime'];
        }

        return $model;
    }
}
