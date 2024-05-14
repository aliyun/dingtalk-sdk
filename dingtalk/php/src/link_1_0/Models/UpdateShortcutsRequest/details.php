<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vlink_1_0\Models\UpdateShortcutsRequest;

use AlibabaCloud\Tea\Model;

class details extends Model
{
    /**
     * @example https://dingtalk.com
     *
     * @var string
     */
    public $actionUrl;

    /**
     * @example 033bd94b1168d7e4f0d644c3c95e35bf
     *
     * @var string
     */
    public $callbackKey;

    /**
     * @example e73e
     *
     * @var string
     */
    public $iconFont;

    /**
     * @description This parameter is required.
     *
     * @example @lADPDg7mWPzw0i_NArzNArw
     *
     * @var string
     */
    public $iconMediaId;

    /**
     * @description This parameter is required.
     *
     * @example test123456
     *
     * @var string
     */
    public $shortcutId;

    /**
     * @example @lADPDg7mWPzw0i_NArzNArw
     *
     * @var string
     */
    public $slideIconMediaId;

    /**
     * @description This parameter is required.
     *
     * @example 测试
     *
     * @var string
     */
    public $title;
    protected $_name = [
        'actionUrl'        => 'actionUrl',
        'callbackKey'      => 'callbackKey',
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
        if (null !== $this->callbackKey) {
            $res['callbackKey'] = $this->callbackKey;
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
        if (isset($map['callbackKey'])) {
            $model->callbackKey = $map['callbackKey'];
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
