<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vtodo_1_0\Models;

use AlibabaCloud\SDK\Dingtalk\Vtodo_1_0\Models\UpdateTodoTypeConfigRequest\actionList;
use AlibabaCloud\SDK\Dingtalk\Vtodo_1_0\Models\UpdateTodoTypeConfigRequest\contentFieldList;
use AlibabaCloud\Tea\Model;

class UpdateTodoTypeConfigRequest extends Model
{
    /**
     * @description 待办卡片操作区按钮配置
     *
     * @var actionList[]
     */
    public $actionList;

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
     * @description 详情页链接在PC端的打开方式，取值为：「PC_SLIDE」-PC端侧边栏打开，「PC_BROWSER」-浏览器打开
     *
     * @var string
     */
    public $pcDetailUrlOpenMode;

    /**
     * @description 当前操作者id，需传用户的unionId
     *
     * @var string
     */
    public $operatorId;
    protected $_name = [
        'actionList'          => 'actionList',
        'cardType'            => 'cardType',
        'contentFieldList'    => 'contentFieldList',
        'description'         => 'description',
        'icon'                => 'icon',
        'pcDetailUrlOpenMode' => 'pcDetailUrlOpenMode',
        'operatorId'          => 'operatorId',
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
        if (null !== $this->description) {
            $res['description'] = $this->description;
        }
        if (null !== $this->icon) {
            $res['icon'] = $this->icon;
        }
        if (null !== $this->pcDetailUrlOpenMode) {
            $res['pcDetailUrlOpenMode'] = $this->pcDetailUrlOpenMode;
        }
        if (null !== $this->operatorId) {
            $res['operatorId'] = $this->operatorId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return UpdateTodoTypeConfigRequest
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
        if (isset($map['description'])) {
            $model->description = $map['description'];
        }
        if (isset($map['icon'])) {
            $model->icon = $map['icon'];
        }
        if (isset($map['pcDetailUrlOpenMode'])) {
            $model->pcDetailUrlOpenMode = $map['pcDetailUrlOpenMode'];
        }
        if (isset($map['operatorId'])) {
            $model->operatorId = $map['operatorId'];
        }

        return $model;
    }
}
