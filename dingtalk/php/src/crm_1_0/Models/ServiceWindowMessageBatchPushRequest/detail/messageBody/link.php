<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vcrm_1_0\Models\ServiceWindowMessageBatchPushRequest\detail\messageBody;

use AlibabaCloud\Tea\Model;

class link extends Model
{
    /**
     * @var string
     */
    public $messageUrl;

    /**
     * @var string
     */
    public $picUrl;

    /**
     * @var string
     */
    public $text;

    /**
     * @var string
     */
    public $title;
    protected $_name = [
        'messageUrl' => 'messageUrl',
        'picUrl'     => 'picUrl',
        'text'       => 'text',
        'title'      => 'title',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->messageUrl) {
            $res['messageUrl'] = $this->messageUrl;
        }
        if (null !== $this->picUrl) {
            $res['picUrl'] = $this->picUrl;
        }
        if (null !== $this->text) {
            $res['text'] = $this->text;
        }
        if (null !== $this->title) {
            $res['title'] = $this->title;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return link
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['messageUrl'])) {
            $model->messageUrl = $map['messageUrl'];
        }
        if (isset($map['picUrl'])) {
            $model->picUrl = $map['picUrl'];
        }
        if (isset($map['text'])) {
            $model->text = $map['text'];
        }
        if (isset($map['title'])) {
            $model->title = $map['title'];
        }

        return $model;
    }
}
