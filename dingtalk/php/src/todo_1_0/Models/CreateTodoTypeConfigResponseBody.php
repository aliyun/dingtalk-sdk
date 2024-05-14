<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vtodo_1_0\Models;

use AlibabaCloud\SDK\Dingtalk\Vtodo_1_0\Models\CreateTodoTypeConfigResponseBody\actionList;
use AlibabaCloud\SDK\Dingtalk\Vtodo_1_0\Models\CreateTodoTypeConfigResponseBody\contentFieldList;
use AlibabaCloud\Tea\Model;

class CreateTodoTypeConfigResponseBody extends Model
{
    /**
     * @var actionList[]
     */
    public $actionList;

    /**
     * @var string
     */
    public $bizTag;

    /**
     * @var int
     */
    public $cardType;

    /**
     * @var contentFieldList[]
     */
    public $contentFieldList;

    /**
     * @description This parameter is required.
     *
     * @var int
     */
    public $createdTime;

    /**
     * @description This parameter is required.
     *
     * @var string
     */
    public $creatorId;

    /**
     * @var string
     */
    public $description;

    /**
     * @var string
     */
    public $icon;

    /**
     * @description This parameter is required.
     *
     * @var string
     */
    public $id;

    /**
     * @description This parameter is required.
     *
     * @var int
     */
    public $modifiedTime;

    /**
     * @description This parameter is required.
     *
     * @var string
     */
    public $modifierId;

    /**
     * @var string
     */
    public $pcDetailUrlOpenMode;

    /**
     * @var string
     */
    public $requestId;
    protected $_name = [
        'actionList'          => 'actionList',
        'bizTag'              => 'bizTag',
        'cardType'            => 'cardType',
        'contentFieldList'    => 'contentFieldList',
        'createdTime'         => 'createdTime',
        'creatorId'           => 'creatorId',
        'description'         => 'description',
        'icon'                => 'icon',
        'id'                  => 'id',
        'modifiedTime'        => 'modifiedTime',
        'modifierId'          => 'modifierId',
        'pcDetailUrlOpenMode' => 'pcDetailUrlOpenMode',
        'requestId'           => 'requestId',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->actionList) {
            $res['actionList'] = [];
            if (null !== $this->actionList && \is_array($this->actionList)) {
                $n = 0;
                foreach ($this->actionList as $item) {
                    $res['actionList'][$n++] = null !== $item ? $item->toMap() : $item;
                }
            }
        }
        if (null !== $this->bizTag) {
            $res['bizTag'] = $this->bizTag;
        }
        if (null !== $this->cardType) {
            $res['cardType'] = $this->cardType;
        }
        if (null !== $this->contentFieldList) {
            $res['contentFieldList'] = [];
            if (null !== $this->contentFieldList && \is_array($this->contentFieldList)) {
                $n = 0;
                foreach ($this->contentFieldList as $item) {
                    $res['contentFieldList'][$n++] = null !== $item ? $item->toMap() : $item;
                }
            }
        }
        if (null !== $this->createdTime) {
            $res['createdTime'] = $this->createdTime;
        }
        if (null !== $this->creatorId) {
            $res['creatorId'] = $this->creatorId;
        }
        if (null !== $this->description) {
            $res['description'] = $this->description;
        }
        if (null !== $this->icon) {
            $res['icon'] = $this->icon;
        }
        if (null !== $this->id) {
            $res['id'] = $this->id;
        }
        if (null !== $this->modifiedTime) {
            $res['modifiedTime'] = $this->modifiedTime;
        }
        if (null !== $this->modifierId) {
            $res['modifierId'] = $this->modifierId;
        }
        if (null !== $this->pcDetailUrlOpenMode) {
            $res['pcDetailUrlOpenMode'] = $this->pcDetailUrlOpenMode;
        }
        if (null !== $this->requestId) {
            $res['requestId'] = $this->requestId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return CreateTodoTypeConfigResponseBody
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['actionList'])) {
            if (!empty($map['actionList'])) {
                $model->actionList = [];
                $n                 = 0;
                foreach ($map['actionList'] as $item) {
                    $model->actionList[$n++] = null !== $item ? actionList::fromMap($item) : $item;
                }
            }
        }
        if (isset($map['bizTag'])) {
            $model->bizTag = $map['bizTag'];
        }
        if (isset($map['cardType'])) {
            $model->cardType = $map['cardType'];
        }
        if (isset($map['contentFieldList'])) {
            if (!empty($map['contentFieldList'])) {
                $model->contentFieldList = [];
                $n                       = 0;
                foreach ($map['contentFieldList'] as $item) {
                    $model->contentFieldList[$n++] = null !== $item ? contentFieldList::fromMap($item) : $item;
                }
            }
        }
        if (isset($map['createdTime'])) {
            $model->createdTime = $map['createdTime'];
        }
        if (isset($map['creatorId'])) {
            $model->creatorId = $map['creatorId'];
        }
        if (isset($map['description'])) {
            $model->description = $map['description'];
        }
        if (isset($map['icon'])) {
            $model->icon = $map['icon'];
        }
        if (isset($map['id'])) {
            $model->id = $map['id'];
        }
        if (isset($map['modifiedTime'])) {
            $model->modifiedTime = $map['modifiedTime'];
        }
        if (isset($map['modifierId'])) {
            $model->modifierId = $map['modifierId'];
        }
        if (isset($map['pcDetailUrlOpenMode'])) {
            $model->pcDetailUrlOpenMode = $map['pcDetailUrlOpenMode'];
        }
        if (isset($map['requestId'])) {
            $model->requestId = $map['requestId'];
        }

        return $model;
    }
}
