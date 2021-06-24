<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vtodo_1_0\Models\QueryTodoTasksResponseBody\todoCards;

use AlibabaCloud\SDK\Dingtalk\Vtodo_1_0\Models\QueryTodoTasksResponseBody\todoCards\todoCardView\todoCardContentList;
use AlibabaCloud\Tea\Model;

class todoCardView extends Model
{
    /**
     * @description 卡片类型
     *
     * @var string
     */
    public $cardType;

    /**
     * @description 卡片左上角 区域类型是 icon, 或者checkbox 类型的
     *
     * @var string
     */
    public $circleELType;

    /**
     * @description icon, name ,内容区域类型是 icon+value, 或者name+value 类型的
     *
     * @var string
     */
    public $contentType;

    /**
     * @description link, button, 操作区类型，是链接类型，或者按钮类型
     *
     * @var string
     */
    public $actionType;

    /**
     * @description 卡片icon
     *
     * @var string
     */
    public $icon;

    /**
     * @description 卡片标题
     *
     * @var string
     */
    public $todoCardTitle;

    /**
     * @var todoCardContentList[]
     */
    public $todoCardContentList;
    protected $_name = [
        'cardType'            => 'cardType',
        'circleELType'        => 'circleELType',
        'contentType'         => 'contentType',
        'actionType'          => 'actionType',
        'icon'                => 'icon',
        'todoCardTitle'       => 'todoCardTitle',
        'todoCardContentList' => 'todoCardContentList',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->cardType) {
            $res['cardType'] = $this->cardType;
        }
        if (null !== $this->circleELType) {
            $res['circleELType'] = $this->circleELType;
        }
        if (null !== $this->contentType) {
            $res['contentType'] = $this->contentType;
        }
        if (null !== $this->actionType) {
            $res['actionType'] = $this->actionType;
        }
        if (null !== $this->icon) {
            $res['icon'] = $this->icon;
        }
        if (null !== $this->todoCardTitle) {
            $res['todoCardTitle'] = $this->todoCardTitle;
        }
        if (null !== $this->todoCardContentList) {
            $res['todoCardContentList'] = [];
            if (null !== $this->todoCardContentList && \is_array($this->todoCardContentList)) {
                $n = 0;
                foreach ($this->todoCardContentList as $item) {
                    $res['todoCardContentList'][$n++] = null !== $item ? $item->toMap() : $item;
                }
            }
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return todoCardView
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['cardType'])) {
            $model->cardType = $map['cardType'];
        }
        if (isset($map['circleELType'])) {
            $model->circleELType = $map['circleELType'];
        }
        if (isset($map['contentType'])) {
            $model->contentType = $map['contentType'];
        }
        if (isset($map['actionType'])) {
            $model->actionType = $map['actionType'];
        }
        if (isset($map['icon'])) {
            $model->icon = $map['icon'];
        }
        if (isset($map['todoCardTitle'])) {
            $model->todoCardTitle = $map['todoCardTitle'];
        }
        if (isset($map['todoCardContentList'])) {
            if (!empty($map['todoCardContentList'])) {
                $model->todoCardContentList = [];
                $n                          = 0;
                foreach ($map['todoCardContentList'] as $item) {
                    $model->todoCardContentList[$n++] = null !== $item ? todoCardContentList::fromMap($item) : $item;
                }
            }
        }

        return $model;
    }
}
