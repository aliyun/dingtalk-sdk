<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vcrm_1_0\Models\ServiceWindowMessageBatchPushRequest\detail\messageBody;

use AlibabaCloud\SDK\Dingtalk\Vcrm_1_0\Models\ServiceWindowMessageBatchPushRequest\detail\messageBody\actionCard\buttonList;
use AlibabaCloud\Tea\Model;

class actionCard extends Model
{
    /**
     * @var buttonList[]
     */
    public $buttonList;

    /**
     * @var string
     */
    public $buttonOrientation;

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
        'buttonList'        => 'buttonList',
        'buttonOrientation' => 'buttonOrientation',
        'markdown'          => 'markdown',
        'singleTitle'       => 'singleTitle',
        'singleUrl'         => 'singleUrl',
        'title'             => 'title',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->buttonList) {
            $res['buttonList'] = [];
            if (null !== $this->buttonList && \is_array($this->buttonList)) {
                $n = 0;
                foreach ($this->buttonList as $item) {
                    $res['buttonList'][$n++] = null !== $item ? $item->toMap() : $item;
                }
            }
        }
        if (null !== $this->buttonOrientation) {
            $res['buttonOrientation'] = $this->buttonOrientation;
        }
        if (null !== $this->markdown) {
            $res['markdown'] = $this->markdown;
        }
        if (null !== $this->singleTitle) {
            $res['singleTitle'] = $this->singleTitle;
        }
        if (null !== $this->singleUrl) {
            $res['singleUrl'] = $this->singleUrl;
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
        if (isset($map['buttonList'])) {
            if (!empty($map['buttonList'])) {
                $model->buttonList = [];
                $n                 = 0;
                foreach ($map['buttonList'] as $item) {
                    $model->buttonList[$n++] = null !== $item ? buttonList::fromMap($item) : $item;
                }
            }
        }
        if (isset($map['buttonOrientation'])) {
            $model->buttonOrientation = $map['buttonOrientation'];
        }
        if (isset($map['markdown'])) {
            $model->markdown = $map['markdown'];
        }
        if (isset($map['singleTitle'])) {
            $model->singleTitle = $map['singleTitle'];
        }
        if (isset($map['singleUrl'])) {
            $model->singleUrl = $map['singleUrl'];
        }
        if (isset($map['title'])) {
            $model->title = $map['title'];
        }

        return $model;
    }
}
