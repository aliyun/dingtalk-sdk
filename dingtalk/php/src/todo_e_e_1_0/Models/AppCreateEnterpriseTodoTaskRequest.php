<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vtodo_e_e_1_0\Models;

use AlibabaCloud\SDK\Dingtalk\Vtodo_e_e_1_0\Models\AppCreateEnterpriseTodoTaskRequest\customFields;
use AlibabaCloud\SDK\Dingtalk\Vtodo_e_e_1_0\Models\AppCreateEnterpriseTodoTaskRequest\detailUrl;
use AlibabaCloud\SDK\Dingtalk\Vtodo_e_e_1_0\Models\AppCreateEnterpriseTodoTaskRequest\notifyConfigs;
use AlibabaCloud\Tea\Model;

class AppCreateEnterpriseTodoTaskRequest extends Model
{
    /**
     * @var string
     */
    public $bizCategoryId;

    /**
     * @var int
     */
    public $bizCreatedTime;

    /**
     * @var customFields[]
     */
    public $customFields;

    /**
     * @var string
     */
    public $description;

    /**
     * @var detailUrl
     */
    public $detailUrl;

    /**
     * @var int
     */
    public $dueTime;

    /**
     * @var string[]
     */
    public $executorIds;

    /**
     * @var notifyConfigs
     */
    public $notifyConfigs;

    /**
     * @var string
     */
    public $operatorId;

    /**
     * @var int
     */
    public $priority;

    /**
     * @var string
     */
    public $sourceId;

    /**
     * @var string
     */
    public $sourceTitle;

    /**
     * @var string
     */
    public $subject;

    /**
     * @var string
     */
    public $toolbarTemplateKey;

    /**
     * @var string
     */
    public $type;
    protected $_name = [
        'bizCategoryId'      => 'bizCategoryId',
        'bizCreatedTime'     => 'bizCreatedTime',
        'customFields'       => 'customFields',
        'description'        => 'description',
        'detailUrl'          => 'detailUrl',
        'dueTime'            => 'dueTime',
        'executorIds'        => 'executorIds',
        'notifyConfigs'      => 'notifyConfigs',
        'operatorId'         => 'operatorId',
        'priority'           => 'priority',
        'sourceId'           => 'sourceId',
        'sourceTitle'        => 'sourceTitle',
        'subject'            => 'subject',
        'toolbarTemplateKey' => 'toolbarTemplateKey',
        'type'               => 'type',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->bizCategoryId) {
            $res['bizCategoryId'] = $this->bizCategoryId;
        }
        if (null !== $this->bizCreatedTime) {
            $res['bizCreatedTime'] = $this->bizCreatedTime;
        }
        if (null !== $this->customFields) {
            $res['customFields'] = [];
            if (null !== $this->customFields && \is_array($this->customFields)) {
                $n = 0;
                foreach ($this->customFields as $item) {
                    $res['customFields'][$n++] = null !== $item ? $item->toMap() : $item;
                }
            }
        }
        if (null !== $this->description) {
            $res['description'] = $this->description;
        }
        if (null !== $this->detailUrl) {
            $res['detailUrl'] = null !== $this->detailUrl ? $this->detailUrl->toMap() : null;
        }
        if (null !== $this->dueTime) {
            $res['dueTime'] = $this->dueTime;
        }
        if (null !== $this->executorIds) {
            $res['executorIds'] = $this->executorIds;
        }
        if (null !== $this->notifyConfigs) {
            $res['notifyConfigs'] = null !== $this->notifyConfigs ? $this->notifyConfigs->toMap() : null;
        }
        if (null !== $this->operatorId) {
            $res['operatorId'] = $this->operatorId;
        }
        if (null !== $this->priority) {
            $res['priority'] = $this->priority;
        }
        if (null !== $this->sourceId) {
            $res['sourceId'] = $this->sourceId;
        }
        if (null !== $this->sourceTitle) {
            $res['sourceTitle'] = $this->sourceTitle;
        }
        if (null !== $this->subject) {
            $res['subject'] = $this->subject;
        }
        if (null !== $this->toolbarTemplateKey) {
            $res['toolbarTemplateKey'] = $this->toolbarTemplateKey;
        }
        if (null !== $this->type) {
            $res['type'] = $this->type;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return AppCreateEnterpriseTodoTaskRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['bizCategoryId'])) {
            $model->bizCategoryId = $map['bizCategoryId'];
        }
        if (isset($map['bizCreatedTime'])) {
            $model->bizCreatedTime = $map['bizCreatedTime'];
        }
        if (isset($map['customFields'])) {
            if (!empty($map['customFields'])) {
                $model->customFields = [];
                $n                   = 0;
                foreach ($map['customFields'] as $item) {
                    $model->customFields[$n++] = null !== $item ? customFields::fromMap($item) : $item;
                }
            }
        }
        if (isset($map['description'])) {
            $model->description = $map['description'];
        }
        if (isset($map['detailUrl'])) {
            $model->detailUrl = detailUrl::fromMap($map['detailUrl']);
        }
        if (isset($map['dueTime'])) {
            $model->dueTime = $map['dueTime'];
        }
        if (isset($map['executorIds'])) {
            if (!empty($map['executorIds'])) {
                $model->executorIds = $map['executorIds'];
            }
        }
        if (isset($map['notifyConfigs'])) {
            $model->notifyConfigs = notifyConfigs::fromMap($map['notifyConfigs']);
        }
        if (isset($map['operatorId'])) {
            $model->operatorId = $map['operatorId'];
        }
        if (isset($map['priority'])) {
            $model->priority = $map['priority'];
        }
        if (isset($map['sourceId'])) {
            $model->sourceId = $map['sourceId'];
        }
        if (isset($map['sourceTitle'])) {
            $model->sourceTitle = $map['sourceTitle'];
        }
        if (isset($map['subject'])) {
            $model->subject = $map['subject'];
        }
        if (isset($map['toolbarTemplateKey'])) {
            $model->toolbarTemplateKey = $map['toolbarTemplateKey'];
        }
        if (isset($map['type'])) {
            $model->type = $map['type'];
        }

        return $model;
    }
}
