<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vcrm_1_0\Models\ServiceWindowMessageBatchPushRequest\detail\messageBody;

use AlibabaCloud\SDK\Dingtalk\Vcrm_1_0\Models\ServiceWindowMessageBatchPushRequest\detail\messageBody\actionCard\buttonList;
use AlibabaCloud\Tea\Model;

class actionCard extends Model
{
    /**
     * @var string
     */
    public $buttonOrientation;

    /**
     * @var string
     */
    public $singleUrl;

    /**
     * @var string
     */
    public $singleTitle;

    /**
     * @var string
     */
    public $markdown;

    /**
     * @var string
     */
    public $title;

    /**
     * @var buttonList[]
     */
    public $buttonList;
    protected $_name = [
        'buttonOrientation' => 'buttonOrientation',
        'singleUrl'         => 'singleUrl',
        'singleTitle'       => 'singleTitle',
        'markdown'          => 'markdown',
        'title'             => 'title',
        'buttonList'        => 'buttonList',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->buttonOrientation) {
            $res['buttonOrientation'] = $this->buttonOrientation;
        }
        if (null !== $this->singleUrl) {
            $res['singleUrl'] = $this->singleUrl;
        }
        if (null !== $this->singleTitle) {
            $res['singleTitle'] = $this->singleTitle;
        }
        if (null !== $this->markdown) {
            $res['markdown'] = $this->markdown;
        }
        if (null !== $this->title) {
            $res['title'] = $this->title;
        }
        if (null !== $this->buttonList) {
            $res['buttonList'] = [];
            if (null !== $this->buttonList && \is_array($this->buttonList)) {
                $n = 0;
                foreach ($this->buttonList as $item) {
                    $res['buttonList'][$n++] = null !== $item ? $item->toMap() : $item;
                }
            }
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
        if (isset($map['buttonOrientation'])) {
            $model->buttonOrientation = $map['buttonOrientation'];
        }
        if (isset($map['singleUrl'])) {
            $model->singleUrl = $map['singleUrl'];
        }
        if (isset($map['singleTitle'])) {
            $model->singleTitle = $map['singleTitle'];
        }
        if (isset($map['markdown'])) {
            $model->markdown = $map['markdown'];
        }
        if (isset($map['title'])) {
            $model->title = $map['title'];
        }
        if (isset($map['buttonList'])) {
            if (!empty($map['buttonList'])) {
                $model->buttonList = [];
                $n                 = 0;
                foreach ($map['buttonList'] as $item) {
                    $model->buttonList[$n++] = null !== $item ? buttonList::fromMap($item) : $item;
                }
            }
        }

        return $model;
    }
}
