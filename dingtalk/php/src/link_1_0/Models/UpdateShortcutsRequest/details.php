<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vlink_1_0\Models\UpdateShortcutsRequest;

use AlibabaCloud\Tea\Model;

class details extends Model
{
    /**
     * @description 跳转链接
     *
     * @var string
     */
    public $actionUrl;

    /**
     * @description windows侧边栏图标的unicode
     *
     * @var string
     */
    public $iconFont;

    /**
     * @description 移动端图标
     *
     * @var string
     */
    public $iconMediaId;

    /**
     * @description 插件唯一标识
     *
     * @var string
     */
    public $shortcutId;

    /**
     * @description 适配mac端侧边栏图标的mediaId
     *
     * @var string
     */
    public $slideIconMediaId;

    /**
     * @description 插件标题
     *
     * @var string
     */
    public $title;
    protected $_name = [
        'actionUrl'        => 'actionUrl',
        'iconFont'         => 'iconFont',
        'iconMediaId'      => 'iconMediaId',
        'shortcutId'       => 'shortcutId',
        'slideIconMediaId' => 'slideIconMediaId',
        'title'            => 'title',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->actionUrl) {
            $res['actionUrl'] = $this->actionUrl;
        }
        if (null !== $this->iconFont) {
            $res['iconFont'] = $this->iconFont;
        }
        if (null !== $this->iconMediaId) {
            $res['iconMediaId'] = $this->iconMediaId;
        }
        if (null !== $this->shortcutId) {
            $res['shortcutId'] = $this->shortcutId;
        }
        if (null !== $this->slideIconMediaId) {
            $res['slideIconMediaId'] = $this->slideIconMediaId;
        }
        if (null !== $this->title) {
            $res['title'] = $this->title;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return details
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['actionUrl'])) {
            $model->actionUrl = $map['actionUrl'];
        }
        if (isset($map['iconFont'])) {
            $model->iconFont = $map['iconFont'];
        }
        if (isset($map['iconMediaId'])) {
            $model->iconMediaId = $map['iconMediaId'];
        }
        if (isset($map['shortcutId'])) {
            $model->shortcutId = $map['shortcutId'];
        }
        if (isset($map['slideIconMediaId'])) {
            $model->slideIconMediaId = $map['slideIconMediaId'];
        }
        if (isset($map['title'])) {
            $model->title = $map['title'];
        }

        return $model;
    }
}