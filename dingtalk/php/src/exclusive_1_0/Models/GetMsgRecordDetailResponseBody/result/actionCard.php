<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vexclusive_1_0\Models\GetMsgRecordDetailResponseBody\result;

use AlibabaCloud\SDK\Dingtalk\Vexclusive_1_0\Models\GetMsgRecordDetailResponseBody\result\actionCard\buttonList;
use AlibabaCloud\Tea\Model;

class actionCard extends Model
{
    /**
     * @var string
     */
    public $bntOrientation;

    /**
     * @var buttonList[]
     */
    public $buttonList;

    /**
     * @var string
     */
    public $markdown;

    /**
     * @var string
     */
    public $singleTitle;

    /**
     * @var string
     */
    public $singleUrl;

    /**
     * @var string
     */
    public $title;
    protected $_name = [
        'bntOrientation' => 'bnt_orientation',
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
        if (null !== $this->bntOrientation) {
            $res['bnt_orientation'] = $this->bntOrientation;
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
        if (isset($map['bnt_orientation'])) {
            $model->bntOrientation = $map['bnt_orientation'];
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
