<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vexclusive_1_0\Models\SendMessageRequest\msgBody;

use AlibabaCloud\SDK\Dingtalk\Vexclusive_1_0\Models\SendMessageRequest\msgBody\actionCard\buttonList;
use AlibabaCloud\Tea\Model;

class actionCard extends Model
{
    /**
     * @example 0
     *
     * @var string
     */
    public $btnOrientation;

    /**
     * @var buttonList[]
     */
    public $buttonList;

    /**
     * @example markdown text
     *
     * @var string
     */
    public $markdown;

    /**
     * @example single title
     *
     * @var string
     */
    public $singleTitle;

    /**
     * @example https://dingtalk.com
     *
     * @var string
     */
    public $singleUrl;

    /**
     * @example title
     *
     * @var string
     */
    public $title;
    protected $_name = [
        'btnOrientation' => 'btn_orientation',
        'buttonList' => 'button_list',
        'markdown' => 'markdown',
        'singleTitle' => 'single_title',
        'singleUrl' => 'single_url',
        'title' => 'title',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->btnOrientation) {
            $res['btn_orientation'] = $this->btnOrientation;
        }
        if (null !== $this->buttonList) {
            $res['button_list'] = [];
            if (null !== $this->buttonList && \is_array($this->buttonList)) {
                $n = 0;
                foreach ($this->buttonList as $item) {
                    $res['button_list'][$n++] = null !== $item ? $item->toMap() : $item;
                }
            }
        }
        if (null !== $this->markdown) {
            $res['markdown'] = $this->markdown;
        }
        if (null !== $this->singleTitle) {
            $res['single_title'] = $this->singleTitle;
        }
        if (null !== $this->singleUrl) {
            $res['single_url'] = $this->singleUrl;
        }
        if (null !== $this->title) {
            $res['title'] = $this->title;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return actionCard
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['btn_orientation'])) {
            $model->btnOrientation = $map['btn_orientation'];
        }
        if (isset($map['button_list'])) {
            if (!empty($map['button_list'])) {
                $model->buttonList = [];
                $n = 0;
                foreach ($map['button_list'] as $item) {
                    $model->buttonList[$n++] = null !== $item ? buttonList::fromMap($item) : $item;
                }
            }
        }
        if (isset($map['markdown'])) {
            $model->markdown = $map['markdown'];
        }
        if (isset($map['single_title'])) {
            $model->singleTitle = $map['single_title'];
        }
        if (isset($map['single_url'])) {
            $model->singleUrl = $map['single_url'];
        }
        if (isset($map['title'])) {
            $model->title = $map['title'];
        }

        return $model;
    }
}
