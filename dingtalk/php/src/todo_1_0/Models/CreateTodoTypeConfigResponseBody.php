<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vtodo_1_0\Models;

use AlibabaCloud\SDK\Dingtalk\Vtodo_1_0\Models\CreateTodoTypeConfigResponseBody\actionList;
use AlibabaCloud\SDK\Dingtalk\Vtodo_1_0\Models\CreateTodoTypeConfigResponseBody\contentFieldList;
use AlibabaCloud\Tea\Model;

class CreateTodoTypeConfigResponseBody extends Model
{
    /**
     * @description 待办卡片操作区按钮配置
     *
     * @var actionList[]
     */
    public $actionList;

    /**
     * @description 接入应用标识
     *
     * @var string
     */
    public $bizTag;

    /**
     * @description 卡片类型（取值为：1-标准卡片，2-自定义卡片）
     *
     * @var int
     */
    public $cardType;

    /**
     * @description 待办卡片内容区表单自定义字段配置
     *
     * @var contentFieldList[]
     */
    public $contentFieldList;

    /**
     * @description 创建时间
     *
     * @var int
     */
    public $createdTime;

    /**
     * @description 创建者（用户的unionId）
     *
     * @var string
     */
    public $creatorId;

    /**
     * @description 待办卡片类型描述
     *
     * @var string
     */
    public $description;

    /**
     * @description 卡片类型icon，用于在待办列表展示
     *
     * @var string
     */
    public $icon;

    /**
     * @description id
     *
     * @var string
     */
    public $id;

    /**
     * @description 更新时间
     *
     * @var int
     */
    public $modifiedTime;

    /**
     * @description 更新者（用户的unionId）
     *
     * @var string
     */
    public $modifierId;

    /**
     * @description 详情页链接在PC端的打开方式，取值为：「PC_SLIDE」-PC端侧边栏打开，「PC_BROWSER」-浏览器打开
     *
     * @var string
     */
    public $pcDetailUrlOpenMode;

    /**
     * @description requestId
     *
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
